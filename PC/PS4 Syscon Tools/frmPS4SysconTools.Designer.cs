﻿namespace PS4_Syscon_Tools
{
    partial class frmPS4SysconTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPS4SysconTools));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslSysconToolPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSysconToolPortValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSysconToolDebugMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSysconToolDebugModeValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.grbSysconProcess = new System.Windows.Forms.GroupBox();
            this.chkEnableDebugMode = new System.Windows.Forms.CheckBox();
            this.chkAutoErase = new System.Windows.Forms.CheckBox();
            this.nudNoOfDumps = new System.Windows.Forms.NumericUpDown();
            this.lblNoOfDumps = new System.Windows.Forms.Label();
            this.nudEndBlock = new System.Windows.Forms.NumericUpDown();
            this.nudStartBlock = new System.Windows.Forms.NumericUpDown();
            this.lblEndBlock = new System.Windows.Forms.Label();
            this.lblStartBlock = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtInputOutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSysconProcess = new System.Windows.Forms.ComboBox();
            this.lblSysconProcessType = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grbDeviceConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.cboCOMPorts = new System.Windows.Forms.ComboBox();
            this.lblCOMPort = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScanCOMPort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.grbLog = new System.Windows.Forms.GroupBox();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.grbSysconProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfDumps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartBlock)).BeginInit();
            this.grbDeviceConnection.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSysconToolPort,
            this.tslSysconToolPortValue,
            this.tslSysconToolDebugMode,
            this.tslSysconToolDebugModeValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(527, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "staMain";
            // 
            // tslSysconToolPort
            // 
            this.tslSysconToolPort.ForeColor = System.Drawing.Color.Blue;
            this.tslSysconToolPort.Name = "tslSysconToolPort";
            this.tslSysconToolPort.Size = new System.Drawing.Size(97, 17);
            this.tslSysconToolPort.Text = "Syscon Tool Port:";
            // 
            // tslSysconToolPortValue
            // 
            this.tslSysconToolPortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslSysconToolPortValue.Name = "tslSysconToolPortValue";
            this.tslSysconToolPortValue.Size = new System.Drawing.Size(0, 17);
            // 
            // tslSysconToolDebugMode
            // 
            this.tslSysconToolDebugMode.ForeColor = System.Drawing.Color.Blue;
            this.tslSysconToolDebugMode.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.tslSysconToolDebugMode.Name = "tslSysconToolDebugMode";
            this.tslSysconToolDebugMode.Size = new System.Drawing.Size(79, 17);
            this.tslSysconToolDebugMode.Text = "Debug Mode:";
            // 
            // tslSysconToolDebugModeValue
            // 
            this.tslSysconToolDebugModeValue.Name = "tslSysconToolDebugModeValue";
            this.tslSysconToolDebugModeValue.Size = new System.Drawing.Size(0, 17);
            // 
            // grbSysconProcess
            // 
            this.grbSysconProcess.Controls.Add(this.chkEnableDebugMode);
            this.grbSysconProcess.Controls.Add(this.chkAutoErase);
            this.grbSysconProcess.Controls.Add(this.nudNoOfDumps);
            this.grbSysconProcess.Controls.Add(this.lblNoOfDumps);
            this.grbSysconProcess.Controls.Add(this.nudEndBlock);
            this.grbSysconProcess.Controls.Add(this.nudStartBlock);
            this.grbSysconProcess.Controls.Add(this.lblEndBlock);
            this.grbSysconProcess.Controls.Add(this.lblStartBlock);
            this.grbSysconProcess.Controls.Add(this.btnBrowse);
            this.grbSysconProcess.Controls.Add(this.txtInputOutputFile);
            this.grbSysconProcess.Controls.Add(this.label1);
            this.grbSysconProcess.Controls.Add(this.cboSysconProcess);
            this.grbSysconProcess.Controls.Add(this.lblSysconProcessType);
            this.grbSysconProcess.Location = new System.Drawing.Point(9, 82);
            this.grbSysconProcess.Name = "grbSysconProcess";
            this.grbSysconProcess.Size = new System.Drawing.Size(510, 143);
            this.grbSysconProcess.TabIndex = 6;
            this.grbSysconProcess.TabStop = false;
            this.grbSysconProcess.Text = "PS4 Syscon Process";
            // 
            // chkEnableDebugMode
            // 
            this.chkEnableDebugMode.AutoSize = true;
            this.chkEnableDebugMode.Location = new System.Drawing.Point(254, 119);
            this.chkEnableDebugMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEnableDebugMode.Name = "chkEnableDebugMode";
            this.chkEnableDebugMode.Size = new System.Drawing.Size(124, 17);
            this.chkEnableDebugMode.TabIndex = 23;
            this.chkEnableDebugMode.Text = "Enable Debug Mode";
            this.chkEnableDebugMode.UseVisualStyleBackColor = true;
            // 
            // chkAutoErase
            // 
            this.chkAutoErase.AutoSize = true;
            this.chkAutoErase.Location = new System.Drawing.Point(104, 119);
            this.chkAutoErase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAutoErase.Name = "chkAutoErase";
            this.chkAutoErase.Size = new System.Drawing.Size(140, 17);
            this.chkAutoErase.TabIndex = 22;
            this.chkAutoErase.Text = "Auto Erase Before Write";
            this.chkAutoErase.UseVisualStyleBackColor = true;
            // 
            // nudNoOfDumps
            // 
            this.nudNoOfDumps.Location = new System.Drawing.Point(440, 90);
            this.nudNoOfDumps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNoOfDumps.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNoOfDumps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfDumps.Name = "nudNoOfDumps";
            this.nudNoOfDumps.Size = new System.Drawing.Size(61, 20);
            this.nudNoOfDumps.TabIndex = 21;
            this.nudNoOfDumps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNoOfDumps.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblNoOfDumps
            // 
            this.lblNoOfDumps.AutoSize = true;
            this.lblNoOfDumps.Location = new System.Drawing.Point(354, 92);
            this.lblNoOfDumps.Name = "lblNoOfDumps";
            this.lblNoOfDumps.Size = new System.Drawing.Size(77, 13);
            this.lblNoOfDumps.TabIndex = 20;
            this.lblNoOfDumps.Text = "No. Of Dumps:";
            // 
            // nudEndBlock
            // 
            this.nudEndBlock.Location = new System.Drawing.Point(254, 90);
            this.nudEndBlock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudEndBlock.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.nudEndBlock.Name = "nudEndBlock";
            this.nudEndBlock.Size = new System.Drawing.Size(61, 20);
            this.nudEndBlock.TabIndex = 19;
            this.nudEndBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEndBlock.Value = new decimal(new int[] {
            511,
            0,
            0,
            0});
            // 
            // nudStartBlock
            // 
            this.nudStartBlock.Location = new System.Drawing.Point(104, 90);
            this.nudStartBlock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudStartBlock.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.nudStartBlock.Name = "nudStartBlock";
            this.nudStartBlock.Size = new System.Drawing.Size(61, 20);
            this.nudStartBlock.TabIndex = 18;
            this.nudStartBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEndBlock
            // 
            this.lblEndBlock.AutoSize = true;
            this.lblEndBlock.Location = new System.Drawing.Point(185, 92);
            this.lblEndBlock.Name = "lblEndBlock";
            this.lblEndBlock.Size = new System.Drawing.Size(59, 13);
            this.lblEndBlock.TabIndex = 17;
            this.lblEndBlock.Text = "End Block:";
            // 
            // lblStartBlock
            // 
            this.lblStartBlock.AutoSize = true;
            this.lblStartBlock.Location = new System.Drawing.Point(31, 92);
            this.lblStartBlock.Name = "lblStartBlock";
            this.lblStartBlock.Size = new System.Drawing.Size(62, 13);
            this.lblStartBlock.TabIndex = 16;
            this.lblStartBlock.Text = "Start Block:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(456, 57);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(45, 21);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "....";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtInputOutputFile
            // 
            this.txtInputOutputFile.Location = new System.Drawing.Point(103, 58);
            this.txtInputOutputFile.MaxLength = 25;
            this.txtInputOutputFile.Name = "txtInputOutputFile";
            this.txtInputOutputFile.Size = new System.Drawing.Size(348, 20);
            this.txtInputOutputFile.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input/Output File:";
            // 
            // cboSysconProcess
            // 
            this.cboSysconProcess.FormattingEnabled = true;
            this.cboSysconProcess.Items.AddRange(new object[] {
            "Dump Full Syscon Flash",
            "Dump Partial Syscon Flash",
            "Dump Syscon NVS/SNVS Only",
            "Erase Full Syscon Flash (Danger)",
            "Erase Full Syscon Flash Expect Boot0 Block (Safe)",
            "Erase Partial Syscon Flash",
            "Erase Syscon NVS/SNVS Only",
            "Write Full Syscon Flash",
            "Write Partial Syscon Flash",
            "Write Syscon NVS/SNVS Only",
            "Enable Syscon Debug Mode (Rewrite Boot0 Blocks)"});
            this.cboSysconProcess.Location = new System.Drawing.Point(103, 28);
            this.cboSysconProcess.Name = "cboSysconProcess";
            this.cboSysconProcess.Size = new System.Drawing.Size(399, 21);
            this.cboSysconProcess.TabIndex = 3;
            this.cboSysconProcess.SelectedIndexChanged += new System.EventHandler(this.cboTransactionsType_SelectedIndexChanged);
            // 
            // lblSysconProcessType
            // 
            this.lblSysconProcessType.AutoSize = true;
            this.lblSysconProcessType.Location = new System.Drawing.Point(5, 32);
            this.lblSysconProcessType.Name = "lblSysconProcessType";
            this.lblSysconProcessType.Size = new System.Drawing.Size(86, 13);
            this.lblSysconProcessType.TabIndex = 2;
            this.lblSysconProcessType.Text = "Syscon Process:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(8, 19);
            this.txtLog.MaxLength = 0;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(497, 199);
            this.txtLog.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(429, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "&Start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grbDeviceConnection
            // 
            this.grbDeviceConnection.Controls.Add(this.btnConnect);
            this.grbDeviceConnection.Controls.Add(this.btnScan);
            this.grbDeviceConnection.Controls.Add(this.cboCOMPorts);
            this.grbDeviceConnection.Controls.Add(this.lblCOMPort);
            this.grbDeviceConnection.Location = new System.Drawing.Point(9, 27);
            this.grbDeviceConnection.Name = "grbDeviceConnection";
            this.grbDeviceConnection.Size = new System.Drawing.Size(510, 56);
            this.grbDeviceConnection.TabIndex = 5;
            this.grbDeviceConnection.TabStop = false;
            this.grbDeviceConnection.Text = "PS4 Syscon Tool Device Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(329, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(426, 19);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "&Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cboCOMPorts
            // 
            this.cboCOMPorts.FormattingEnabled = true;
            this.cboCOMPorts.Location = new System.Drawing.Point(127, 23);
            this.cboCOMPorts.Name = "cboCOMPorts";
            this.cboCOMPorts.Size = new System.Drawing.Size(121, 21);
            this.cboCOMPorts.TabIndex = 1;
            // 
            // lblCOMPort
            // 
            this.lblCOMPort.AutoSize = true;
            this.lblCOMPort.Location = new System.Drawing.Point(8, 25);
            this.lblCOMPort.Name = "lblCOMPort";
            this.lblCOMPort.Size = new System.Drawing.Size(114, 13);
            this.lblCOMPort.TabIndex = 0;
            this.lblCOMPort.Text = "PS4 Syscon Tool Port:";
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDevices});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(527, 24);
            this.mnuMain.TabIndex = 7;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuDevices
            // 
            this.mnuDevices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScanCOMPort,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuDevices.Name = "mnuDevices";
            this.mnuDevices.Size = new System.Drawing.Size(59, 20);
            this.mnuDevices.Text = "&Devices";
            // 
            // mnuScanCOMPort
            // 
            this.mnuScanCOMPort.Name = "mnuScanCOMPort";
            this.mnuScanCOMPort.Size = new System.Drawing.Size(160, 22);
            this.mnuScanCOMPort.Text = "&Scan COM Ports";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(160, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnStart);
            this.grbProcess.Controls.Add(this.prbProgress);
            this.grbProcess.Controls.Add(this.lblProgress);
            this.grbProcess.Location = new System.Drawing.Point(9, 232);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(510, 56);
            this.grbProcess.TabIndex = 9;
            this.grbProcess.TabStop = false;
            // 
            // prbProgress
            // 
            this.prbProgress.Location = new System.Drawing.Point(78, 20);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(329, 23);
            this.prbProgress.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(14, 24);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 13);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "Progress:";
            // 
            // grbLog
            // 
            this.grbLog.Controls.Add(this.txtLog);
            this.grbLog.Location = new System.Drawing.Point(9, 292);
            this.grbLog.Name = "grbLog";
            this.grbLog.Size = new System.Drawing.Size(510, 223);
            this.grbLog.TabIndex = 10;
            this.grbLog.TabStop = false;
            this.grbLog.Text = "Process Log";
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "bin";
            this.dlgSaveFile.Filter = "PS4 Syscon FW Dump (*.bin)|*bin|All Files (*.*)|*.*";
            this.dlgSaveFile.Title = "Please Select Where You Want To Save Syscon FW Dump File";
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "dlgOpenFile";
            this.dlgOpenFile.Filter = "PS4 Syscon FW Dump (*.bin)|*bin|All Files (*.*)|*.*";
            this.dlgOpenFile.Title = "Please Select Syscon FW Dump File";
            // 
            // frmPS4SysconTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 544);
            this.Controls.Add(this.grbLog);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbSysconProcess);
            this.Controls.Add(this.grbDeviceConnection);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmPS4SysconTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 Syscon Tools v1.01 by Abkarino & EgyCnq";
            this.Load += new System.EventHandler(this.frmPS4SysconTools_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbSysconProcess.ResumeLayout(false);
            this.grbSysconProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfDumps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartBlock)).EndInit();
            this.grbDeviceConnection.ResumeLayout(false);
            this.grbDeviceConnection.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbProcess.PerformLayout();
            this.grbLog.ResumeLayout(false);
            this.grbLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grbSysconProcess;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboSysconProcess;
        private System.Windows.Forms.Label lblSysconProcessType;
        private System.Windows.Forms.GroupBox grbDeviceConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cboCOMPorts;
        private System.Windows.Forms.Label lblCOMPort;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuDevices;
        private System.Windows.Forms.ToolStripMenuItem mnuScanCOMPort;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox grbLog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtInputOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.ToolStripStatusLabel tslSysconToolPort;
        private System.Windows.Forms.ToolStripStatusLabel tslSysconToolPortValue;
        private System.Windows.Forms.ToolStripStatusLabel tslSysconToolDebugMode;
        private System.Windows.Forms.ToolStripStatusLabel tslSysconToolDebugModeValue;
        private System.Windows.Forms.NumericUpDown nudNoOfDumps;
        private System.Windows.Forms.Label lblNoOfDumps;
        private System.Windows.Forms.NumericUpDown nudEndBlock;
        private System.Windows.Forms.NumericUpDown nudStartBlock;
        private System.Windows.Forms.Label lblEndBlock;
        private System.Windows.Forms.Label lblStartBlock;
        private System.Windows.Forms.CheckBox chkEnableDebugMode;
        private System.Windows.Forms.CheckBox chkAutoErase;
    }
}

