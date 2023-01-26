namespace DashboardTester
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpDatabaseLogin = new System.Windows.Forms.GroupBox();
            this.ckbxSQL_DirectIP = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpExtract = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.dgvGridPreview = new System.Windows.Forms.DataGridView();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtCommandString = new System.Windows.Forms.TextBox();
            this.gbxDataPull = new System.Windows.Forms.GroupBox();
            this.lblTimeSpan = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatabaseLogin.SuspendLayout();
            this.grpExtract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridPreview)).BeginInit();
            this.gbxDataPull.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatabaseLogin
            // 
            this.grpDatabaseLogin.Controls.Add(this.ckbxSQL_DirectIP);
            this.grpDatabaseLogin.Controls.Add(this.txtPassword);
            this.grpDatabaseLogin.Controls.Add(this.txtLogin);
            this.grpDatabaseLogin.Controls.Add(this.txtDatabase);
            this.grpDatabaseLogin.Controls.Add(this.txtInstance);
            this.grpDatabaseLogin.Controls.Add(this.label5);
            this.grpDatabaseLogin.Controls.Add(this.btnConnect);
            this.grpDatabaseLogin.Controls.Add(this.label4);
            this.grpDatabaseLogin.Controls.Add(this.label3);
            this.grpDatabaseLogin.Controls.Add(this.label2);
            this.grpDatabaseLogin.Location = new System.Drawing.Point(12, 12);
            this.grpDatabaseLogin.Name = "grpDatabaseLogin";
            this.grpDatabaseLogin.Size = new System.Drawing.Size(379, 152);
            this.grpDatabaseLogin.TabIndex = 24;
            this.grpDatabaseLogin.TabStop = false;
            this.grpDatabaseLogin.Text = "SQL Login Information";
            // 
            // ckbxSQL_DirectIP
            // 
            this.ckbxSQL_DirectIP.AutoSize = true;
            this.ckbxSQL_DirectIP.Location = new System.Drawing.Point(61, 124);
            this.ckbxSQL_DirectIP.Name = "ckbxSQL_DirectIP";
            this.ckbxSQL_DirectIP.Size = new System.Drawing.Size(132, 17);
            this.ckbxSQL_DirectIP.TabIndex = 22;
            this.ckbxSQL_DirectIP.Text = "Use Direct IP/Address";
            this.ckbxSQL_DirectIP.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(61, 69);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(312, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(61, 43);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(312, 20);
            this.txtDatabase.TabIndex = 5;
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(61, 17);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(312, 20);
            this.txtInstance.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(298, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 21);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instance";
            // 
            // grpExtract
            // 
            this.grpExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExtract.Controls.Add(this.btnStop);
            this.grpExtract.Controls.Add(this.dgvGridPreview);
            this.grpExtract.Controls.Add(this.btnExtract);
            this.grpExtract.Controls.Add(this.txtCommandString);
            this.grpExtract.Enabled = false;
            this.grpExtract.Location = new System.Drawing.Point(12, 170);
            this.grpExtract.Name = "grpExtract";
            this.grpExtract.Size = new System.Drawing.Size(776, 426);
            this.grpExtract.TabIndex = 25;
            this.grpExtract.TabStop = false;
            this.grpExtract.Text = "Put SQL Command Here";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(94, 397);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dgvGridPreview
            // 
            this.dgvGridPreview.AllowUserToResizeRows = false;
            this.dgvGridPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGridPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGridPreview.Location = new System.Drawing.Point(13, 199);
            this.dgvGridPreview.MultiSelect = false;
            this.dgvGridPreview.Name = "dgvGridPreview";
            this.dgvGridPreview.RowHeadersWidth = 51;
            this.dgvGridPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGridPreview.Size = new System.Drawing.Size(757, 190);
            this.dgvGridPreview.TabIndex = 4;
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExtract.Location = new System.Drawing.Point(13, 397);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Run";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtCommandString
            // 
            this.txtCommandString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandString.Location = new System.Drawing.Point(10, 20);
            this.txtCommandString.Multiline = true;
            this.txtCommandString.Name = "txtCommandString";
            this.txtCommandString.Size = new System.Drawing.Size(760, 172);
            this.txtCommandString.TabIndex = 0;
            // 
            // gbxDataPull
            // 
            this.gbxDataPull.Controls.Add(this.lblTimeSpan);
            this.gbxDataPull.Controls.Add(this.lblEndTime);
            this.gbxDataPull.Controls.Add(this.lblStartTime);
            this.gbxDataPull.Controls.Add(this.cmbInterval);
            this.gbxDataPull.Controls.Add(this.label1);
            this.gbxDataPull.Location = new System.Drawing.Point(397, 12);
            this.gbxDataPull.Name = "gbxDataPull";
            this.gbxDataPull.Size = new System.Drawing.Size(296, 152);
            this.gbxDataPull.TabIndex = 26;
            this.gbxDataPull.TabStop = false;
            this.gbxDataPull.Text = "Data Pull Time Frame";
            // 
            // lblTimeSpan
            // 
            this.lblTimeSpan.AutoSize = true;
            this.lblTimeSpan.Location = new System.Drawing.Point(10, 95);
            this.lblTimeSpan.Name = "lblTimeSpan";
            this.lblTimeSpan.Size = new System.Drawing.Size(64, 13);
            this.lblTimeSpan.TabIndex = 4;
            this.lblTimeSpan.Text = "Time Span: ";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(10, 72);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(58, 13);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End Time: ";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(10, 49);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(61, 13);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "Start Time: ";
            // 
            // cmbInterval
            // 
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "25",
            "60",
            "120"});
            this.cmbInterval.Location = new System.Drawing.Point(111, 19);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(95, 21);
            this.cmbInterval.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interval in Seconds";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.gbxDataPull);
            this.Controls.Add(this.grpExtract);
            this.Controls.Add(this.grpDatabaseLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Test Dashboard Code";
            this.grpDatabaseLogin.ResumeLayout(false);
            this.grpDatabaseLogin.PerformLayout();
            this.grpExtract.ResumeLayout(false);
            this.grpExtract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGridPreview)).EndInit();
            this.gbxDataPull.ResumeLayout(false);
            this.gbxDataPull.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatabaseLogin;
        private System.Windows.Forms.CheckBox ckbxSQL_DirectIP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpExtract;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtCommandString;
        private System.Windows.Forms.DataGridView dgvGridPreview;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox gbxDataPull;
        private System.Windows.Forms.ComboBox cmbInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeSpan;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
    }
}

