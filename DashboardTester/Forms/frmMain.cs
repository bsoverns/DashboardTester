using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace DashboardTester
{
    public partial class frmMain : Form
    {
        System.Timers.Timer _timer;
        string DataSource; //used to save the datasource from the dsnNames
        string InitialCatalog; //used to save the InitialCatalog        
        SQLConnectionClass SQLConnect = new SQLConnectionClass("", "", "", "", false);
        DataTable Records;
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now;        

        public frmMain()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            dgvGridPreview.RowHeadersVisible = false;
            dgvGridPreview.ReadOnly = true;

#if DEBUG
            txtInstance.Text = @"192.1.0.0";
            txtDatabase.Text = @"database";
            txtLogin.Text = @"sa";
            txtPassword.Text = @"password";
            txtCommandString.Text = @"SELECT TOP 100 * FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME";
            cmbInterval.SelectedIndex = 0;
#endif
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtInstance.Text != "" && txtDatabase.Text != "" && txtLogin.Text != "" && txtPassword.Text != "")
            {
                btnConnect.Enabled = false;
                txtDatabase.Enabled = false;
                txtInstance.Enabled = false;
                txtLogin.Enabled = false;
                txtPassword.Enabled = false;
                ckbxSQL_DirectIP.Enabled = false;
                btnConnect.Text = "Please wait";

                SQLConnect.dataSource = txtInstance.Text;
                SQLConnect.initialCatalog = txtDatabase.Text;
                SQLConnect.userID = txtLogin.Text;
                SQLConnect.password = txtPassword.Text;
                SQLConnect.useIPAdress = ckbxSQL_DirectIP.Checked;

                try
                {
                    DataSource = txtInstance.Text;
                    InitialCatalog = txtDatabase.Text;

                    SqlConnection sqlConnString = new SqlConnection("Data Source=" + SQLConnect.dataSource + ";Initial Catalog=" + SQLConnect.initialCatalog + ";User ID=" + SQLConnect.userID + ";Password=" + SQLConnect.password + ";Connect Timeout = 120;");

                    if (SQLConnect.useIPAdress == true)
                    {
                        IPAddress ip = new IPHelper().get_ip_from_host_name(SQLConnect.dataSource);
                        sqlConnString = new SqlConnection("Data Source=" + ip.ToString() + ";Initial Catalog=" + SQLConnect.initialCatalog + ";User ID=" + SQLConnect.userID + ";Password=" + SQLConnect.password + ";Connect Timeout = 120;");

                        //MessageBox.Show(ip.ToString());
                    }

                    //version
                    SqlDataAdapter read_version = new SqlDataAdapter("select top 1 TABLE_NAME from INFORMATION_SCHEMA.TABLES", sqlConnString);
                    DataTable version_table = new DataTable();
                                        
                    sqlConnString.Open();
                    read_version.Fill(version_table);
                    sqlConnString.Close();

                    btnConnect.Text = "Valid";
                    grpExtract.Enabled = true;
                    version_table.Dispose();

                    //SQLGBSCustomProcess Tables = new SQLGBSCustomProcess();
                    //Tables.CreateTables();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error connecting to database");
                    btnConnect.Enabled = true;
                    btnConnect.Text = "Connect";
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            lblStartTime.Text = @"Start Time: ";
            lblEndTime.Text = @"End Time: ";
            lblTimeSpan.Text = @"Time Span: ";
            DisableControls();
            TimerRun();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _timer.Dispose();
            EnableControls();
        }

        private void TimerRun()
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Interval = Int32.Parse(cmbInterval.SelectedItem.ToString()) * 1000; 
            _timer.Enabled = true;
            _timer.Start();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Enabled = false;

            try
            {
                if (!txtCommandString.Text.ToUpper().Contains("UPDATE") && !txtCommandString.Text.ToUpper().Contains("DELETE") && !txtCommandString.Text.ToUpper().Contains("INSERT"))
                {
                    Thread backgroundpopulate_ProcessCommand = new Thread(ProcessCommand);
                    backgroundpopulate_ProcessCommand.IsBackground = true;
                    backgroundpopulate_ProcessCommand.Start();
                }

                else
                {
                    //MessageBox.Show("You cannot include \"update\", \"insert\", or \"delete\" in your statement.");
                    //btnExtract.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            finally
            {
                _timer.Enabled = true;
            }
        }

        private void ProcessCommand()
        {
            try
            {
                DataTable returnTable = new DataTable();
                string _commandString = txtCommandString.Text;

                SQLGBSCustomProcess sqlReadData = new SQLGBSCustomProcess();
                returnTable.Clear();
                startTime = DateTime.Now;
                returnTable = sqlReadData.databaseReturnDataTable(txtInstance.Text, txtDatabase.Text, txtLogin.Text, txtPassword.Text, ckbxSQL_DirectIP.Enabled, _commandString);
                endTime = DateTime.Now;                

                Records = returnTable;

                //dgvGridPreview.DataSource = returnTable;
                Invoke(new UIUpdate(UpdateDvgGridView));

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            finally
            {
                //Invoke(new UIUpdate(EnableControls));
            }
        }


        public delegate void UIUpdate();

        public void UpdateDvgGridView()
        {
            //dgvGridPreview.Columns.Clear();
            //dgvGridPreview.Rows.Clear();
            //dgvGridPreview.Refresh();
            dgvGridPreview.DataSource = Records;
            TimeSpan ts = endTime - startTime;
            lblStartTime.Text = @"Start Time: " + startTime.ToString("HH:mm:ss.fffffff");
            lblEndTime.Text = @"End Time: " + endTime.ToString("HH:mm:ss.fffffff");
            lblTimeSpan.Text = @"Time Span: " + ts.TotalSeconds.ToString() + ".ss - " + ts.TotalMilliseconds.ToString() + ".ms";
        }

        private void EnableControls()
        {
            gbxDataPull.Enabled = true;
            txtCommandString.Enabled = true;
            btnExtract.Enabled = true;
            btnStop.Enabled = false;
        }

        private void DisableControls()
        {
            gbxDataPull.Enabled = false;
            txtCommandString.Enabled = false;
            btnExtract.Enabled = false;
            btnStop.Enabled = true;
        }
    }
}
