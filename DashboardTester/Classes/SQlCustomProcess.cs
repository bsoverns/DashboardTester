using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
//using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Reflection;

namespace DashboardTester
{
    class SQLGBSCustomProcess
    {
        public DataTable databaseReturnDataTable(string dataSource, string initialCatalog, string login, string password, bool useIPAddress, string command)
        {
            DataTable returnTable = new DataTable();
            SqlConnection sqlConnString = new SqlConnection("Data Source=" + dataSource + ";Initial Catalog=" + initialCatalog + ";User ID=" + login + ";Password=" + password + ";Connect Timeout = 120;");

            try
            {
                if (useIPAddress == true)
                {
                    IPAddress ip = new IPHelper().get_ip_from_host_name(dataSource);
                    sqlConnString = new SqlConnection("Data Source=" + ip.ToString() + ";Initial Catalog=" + initialCatalog + ";User ID=" + login + ";Password=" + password + ";Connect Timeout = 120;");

                    //MessageBox.Show(ip.ToString());
                }

                SqlDataAdapter read_practice = new SqlDataAdapter(command, sqlConnString);

                returnTable.Clear();
                sqlConnString.Open();
                read_practice.Fill(returnTable);
                sqlConnString.Close();

                return returnTable;
            }

            catch (Exception ex)
            {
                return returnTable;
            }

            finally
            {
                if (sqlConnString.State.ToString() == "Open")
                {
                    sqlConnString.Close();
                }
            }
        }        
    }
}

