namespace SmartCharging
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      menuStrip1 = new MenuStrip();
      toolStripMenuItem1 = new ToolStripMenuItem();
      toolStripTextBox1 = new ToolStripTextBox();
      toolStripTextBox2 = new ToolStripTextBox();
      toolStripMenuItem2 = new ToolStripMenuItem();
      toolStripTextBox3 = new ToolStripTextBox();
      tabControl1 = new TabControl();
      TabOpen = new TabPage();
      tabControl2 = new TabControl();
      TabLink = new TabPage();
      PBStatus = new PictureBox();
      BOpen = new Button();
      BClose = new Button();
      label5 = new Label();
      CBBaudRate = new ComboBox();
      BRefreshCOM = new Button();
      label4 = new Label();
      CBDevice = new ComboBox();
      label3 = new Label();
      TBSerialNumber = new TextBox();
      label2 = new Label();
      TBAddress = new TextBox();
      label1 = new Label();
      CBPort = new ComboBox();
      TabAsso = new TabPage();
      TabEXE = new TabPage();
      label6 = new Label();
      BDelete = new Button();
      BExecute = new Button();
      TBTextFile = new TextBox();
      BRefreshFiles = new Button();
      LBFiles = new ListBox();
      TBPath = new TextBox();
      BChangePath = new Button();
      TabCharging = new TabPage();
      GBStationName = new GroupBox();
      LStationName = new Label();
      GBPrice = new GroupBox();
      LPrice = new Label();
      GBEnergy = new GroupBox();
      LEnergy = new Label();
      GBStartTime = new GroupBox();
      LStartTime = new Label();
      GBChargeActions = new GroupBox();
      BStartStop = new Button();
      LCurrent = new Label();
      TBCurrent = new TrackBar();
      LChargingCurrent = new Label();
      RBScheduled = new RadioButton();
      RBAuto = new RadioButton();
      RBManual = new RadioButton();
      LChargeMode = new Label();
      PBPlug = new PictureBox();
      LBOutput = new ListBox();
      label7 = new Label();
      button1 = new Button();
      PBIAT = new PictureBox();
      timer = new System.Windows.Forms.Timer(components);
      menuStrip1.SuspendLayout();
      tabControl1.SuspendLayout();
      TabOpen.SuspendLayout();
      tabControl2.SuspendLayout();
      TabLink.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)PBStatus).BeginInit();
      TabEXE.SuspendLayout();
      TabCharging.SuspendLayout();
      GBStationName.SuspendLayout();
      GBPrice.SuspendLayout();
      GBEnergy.SuspendLayout();
      GBStartTime.SuspendLayout();
      GBChargeActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)TBCurrent).BeginInit();
      ((System.ComponentModel.ISupportInitialize)PBPlug).BeginInit();
      ((System.ComponentModel.ISupportInitialize)PBIAT).BeginInit();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(823, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripTextBox2 });
      toolStripMenuItem1.Name = "toolStripMenuItem1";
      toolStripMenuItem1.Size = new Size(93, 20);
      toolStripMenuItem1.Text = "Configuration";
      // 
      // toolStripTextBox1
      // 
      toolStripTextBox1.Name = "toolStripTextBox1";
      toolStripTextBox1.ReadOnly = true;
      toolStripTextBox1.Size = new Size(100, 23);
      toolStripTextBox1.Text = "Save";
      // 
      // toolStripTextBox2
      // 
      toolStripTextBox2.Name = "toolStripTextBox2";
      toolStripTextBox2.ReadOnly = true;
      toolStripTextBox2.Size = new Size(100, 23);
      toolStripTextBox2.Text = "Save As ...";
      // 
      // toolStripMenuItem2
      // 
      toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox3 });
      toolStripMenuItem2.Name = "toolStripMenuItem2";
      toolStripMenuItem2.Size = new Size(44, 20);
      toolStripMenuItem2.Text = "Help";
      // 
      // toolStripTextBox3
      // 
      toolStripTextBox3.Name = "toolStripTextBox3";
      toolStripTextBox3.ReadOnly = true;
      toolStripTextBox3.Size = new Size(100, 23);
      toolStripTextBox3.Text = "About";
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(TabOpen);
      tabControl1.Controls.Add(TabEXE);
      tabControl1.Controls.Add(TabCharging);
      tabControl1.Location = new Point(8, 27);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(809, 502);
      tabControl1.TabIndex = 1;
      // 
      // TabOpen
      // 
      TabOpen.Controls.Add(tabControl2);
      TabOpen.Location = new Point(4, 24);
      TabOpen.Name = "TabOpen";
      TabOpen.Padding = new Padding(3);
      TabOpen.Size = new Size(801, 474);
      TabOpen.TabIndex = 0;
      TabOpen.Text = "Communication";
      TabOpen.UseVisualStyleBackColor = true;
      // 
      // tabControl2
      // 
      tabControl2.Controls.Add(TabLink);
      tabControl2.Controls.Add(TabAsso);
      tabControl2.Location = new Point(15, 24);
      tabControl2.Name = "tabControl2";
      tabControl2.SelectedIndex = 0;
      tabControl2.Size = new Size(761, 425);
      tabControl2.TabIndex = 0;
      // 
      // TabLink
      // 
      TabLink.Controls.Add(PBStatus);
      TabLink.Controls.Add(BOpen);
      TabLink.Controls.Add(BClose);
      TabLink.Controls.Add(label5);
      TabLink.Controls.Add(CBBaudRate);
      TabLink.Controls.Add(BRefreshCOM);
      TabLink.Controls.Add(label4);
      TabLink.Controls.Add(CBDevice);
      TabLink.Controls.Add(label3);
      TabLink.Controls.Add(TBSerialNumber);
      TabLink.Controls.Add(label2);
      TabLink.Controls.Add(TBAddress);
      TabLink.Controls.Add(label1);
      TabLink.Controls.Add(CBPort);
      TabLink.Location = new Point(4, 24);
      TabLink.Name = "TabLink";
      TabLink.Padding = new Padding(3);
      TabLink.Size = new Size(753, 397);
      TabLink.TabIndex = 0;
      TabLink.Text = "Link";
      TabLink.UseVisualStyleBackColor = true;
      // 
      // PBStatus
      // 
      PBStatus.Location = new Point(576, 229);
      PBStatus.Name = "PBStatus";
      PBStatus.Size = new Size(171, 162);
      PBStatus.TabIndex = 9;
      PBStatus.TabStop = false;
      // 
      // BOpen
      // 
      BOpen.Location = new Point(27, 168);
      BOpen.Name = "BOpen";
      BOpen.Size = new Size(85, 34);
      BOpen.TabIndex = 12;
      BOpen.Text = "OPEN";
      BOpen.UseVisualStyleBackColor = true;
      BOpen.Click += BOpen_Click;
      // 
      // BClose
      // 
      BClose.Location = new Point(118, 168);
      BClose.Name = "BClose";
      BClose.Size = new Size(85, 34);
      BClose.TabIndex = 11;
      BClose.Text = "CLOSE";
      BClose.UseVisualStyleBackColor = true;
      BClose.Click += BClose_Click;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(346, 107);
      label5.Name = "label5";
      label5.Size = new Size(57, 15);
      label5.TabIndex = 10;
      label5.Text = "Baud rate";
      // 
      // CBBaudRate
      // 
      CBBaudRate.FormattingEnabled = true;
      CBBaudRate.Location = new Point(349, 125);
      CBBaudRate.Name = "CBBaudRate";
      CBBaudRate.Size = new Size(121, 23);
      CBBaudRate.TabIndex = 9;
      // 
      // BRefreshCOM
      // 
      BRefreshCOM.Location = new Point(248, 125);
      BRefreshCOM.Name = "BRefreshCOM";
      BRefreshCOM.Size = new Size(23, 23);
      BRefreshCOM.TabIndex = 8;
      BRefreshCOM.Text = "<";
      BRefreshCOM.UseVisualStyleBackColor = true;
      BRefreshCOM.Click += BRefreshCOM_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(27, 107);
      label4.Name = "label4";
      label4.Size = new Size(42, 15);
      label4.TabIndex = 7;
      label4.Text = "Device";
      // 
      // CBDevice
      // 
      CBDevice.FormattingEnabled = true;
      CBDevice.Location = new Point(30, 125);
      CBDevice.Name = "CBDevice";
      CBDevice.Size = new Size(209, 23);
      CBDevice.TabIndex = 6;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(417, 49);
      label3.Name = "label3";
      label3.Size = new Size(82, 15);
      label3.TabIndex = 5;
      label3.Text = "Serial Number";
      // 
      // TBSerialNumber
      // 
      TBSerialNumber.Location = new Point(419, 67);
      TBSerialNumber.Name = "TBSerialNumber";
      TBSerialNumber.Size = new Size(131, 23);
      TBSerialNumber.TabIndex = 4;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(236, 49);
      label2.Name = "label2";
      label2.Size = new Size(49, 15);
      label2.TabIndex = 3;
      label2.Text = "Address";
      // 
      // TBAddress
      // 
      TBAddress.Location = new Point(238, 67);
      TBAddress.Name = "TBAddress";
      TBAddress.Size = new Size(100, 23);
      TBAddress.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(28, 49);
      label1.Name = "label1";
      label1.Size = new Size(29, 15);
      label1.TabIndex = 1;
      label1.Text = "Port";
      // 
      // CBPort
      // 
      CBPort.FormattingEnabled = true;
      CBPort.Location = new Point(30, 67);
      CBPort.Name = "CBPort";
      CBPort.Size = new Size(121, 23);
      CBPort.TabIndex = 0;
      // 
      // TabAsso
      // 
      TabAsso.Location = new Point(4, 24);
      TabAsso.Name = "TabAsso";
      TabAsso.Padding = new Padding(3);
      TabAsso.Size = new Size(753, 397);
      TabAsso.TabIndex = 1;
      TabAsso.Text = "Asso";
      TabAsso.UseVisualStyleBackColor = true;
      // 
      // TabEXE
      // 
      TabEXE.Controls.Add(label6);
      TabEXE.Controls.Add(BDelete);
      TabEXE.Controls.Add(BExecute);
      TabEXE.Controls.Add(TBTextFile);
      TabEXE.Controls.Add(BRefreshFiles);
      TabEXE.Controls.Add(LBFiles);
      TabEXE.Controls.Add(TBPath);
      TabEXE.Controls.Add(BChangePath);
      TabEXE.Location = new Point(4, 24);
      TabEXE.Name = "TabEXE";
      TabEXE.Padding = new Padding(3);
      TabEXE.Size = new Size(801, 474);
      TabEXE.TabIndex = 1;
      TabEXE.Text = "File Explorer";
      TabEXE.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(355, 57);
      label6.Name = "label6";
      label6.Size = new Size(38, 15);
      label6.TabIndex = 7;
      label6.Text = "Input:";
      // 
      // BDelete
      // 
      BDelete.BackColor = Color.IndianRed;
      BDelete.Location = new Point(410, 50);
      BDelete.Name = "BDelete";
      BDelete.Size = new Size(26, 25);
      BDelete.TabIndex = 6;
      BDelete.UseVisualStyleBackColor = false;
      // 
      // BExecute
      // 
      BExecute.Location = new Point(355, 419);
      BExecute.Name = "BExecute";
      BExecute.Size = new Size(97, 29);
      BExecute.TabIndex = 5;
      BExecute.Text = "Execute";
      BExecute.UseVisualStyleBackColor = true;
      // 
      // TBTextFile
      // 
      TBTextFile.Location = new Point(355, 79);
      TBTextFile.Multiline = true;
      TBTextFile.Name = "TBTextFile";
      TBTextFile.Size = new Size(419, 334);
      TBTextFile.TabIndex = 4;
      // 
      // BRefreshFiles
      // 
      BRefreshFiles.Location = new Point(16, 419);
      BRefreshFiles.Name = "BRefreshFiles";
      BRefreshFiles.Size = new Size(107, 29);
      BRefreshFiles.TabIndex = 3;
      BRefreshFiles.Text = "Refresh files";
      BRefreshFiles.UseVisualStyleBackColor = true;
      BRefreshFiles.Click += BRefreshFiles_Click;
      // 
      // LBFiles
      // 
      LBFiles.FormattingEnabled = true;
      LBFiles.ItemHeight = 15;
      LBFiles.Location = new Point(16, 79);
      LBFiles.Name = "LBFiles";
      LBFiles.Size = new Size(321, 334);
      LBFiles.TabIndex = 2;
      LBFiles.SelectedIndexChanged += LBFiles_SelectedIndexChanged_1;
      // 
      // TBPath
      // 
      TBPath.Location = new Point(122, 21);
      TBPath.Name = "TBPath";
      TBPath.Size = new Size(652, 23);
      TBPath.TabIndex = 1;
      // 
      // BChangePath
      // 
      BChangePath.Location = new Point(18, 21);
      BChangePath.Name = "BChangePath";
      BChangePath.Size = new Size(98, 37);
      BChangePath.TabIndex = 0;
      BChangePath.Text = "Change path";
      BChangePath.UseVisualStyleBackColor = true;
      BChangePath.Click += BChangePath_Click;
      // 
      // TabCharging
      // 
      TabCharging.Controls.Add(GBStationName);
      TabCharging.Controls.Add(GBPrice);
      TabCharging.Controls.Add(GBEnergy);
      TabCharging.Controls.Add(GBStartTime);
      TabCharging.Controls.Add(GBChargeActions);
      TabCharging.Controls.Add(PBPlug);
      TabCharging.Location = new Point(4, 24);
      TabCharging.Name = "TabCharging";
      TabCharging.Padding = new Padding(3);
      TabCharging.Size = new Size(801, 474);
      TabCharging.TabIndex = 2;
      TabCharging.Text = "Charging";
      TabCharging.UseVisualStyleBackColor = true;
      // 
      // GBStationName
      // 
      GBStationName.Controls.Add(LStationName);
      GBStationName.Location = new Point(442, 95);
      GBStationName.Name = "GBStationName";
      GBStationName.Size = new Size(173, 47);
      GBStationName.TabIndex = 14;
      GBStationName.TabStop = false;
      GBStationName.Text = "Station Name";
      // 
      // LStationName
      // 
      LStationName.AutoSize = true;
      LStationName.Font = new Font("Segoe UI", 12F);
      LStationName.Location = new Point(68, 18);
      LStationName.Name = "LStationName";
      LStationName.Size = new Size(102, 21);
      LStationName.TabIndex = 0;
      LStationName.Text = "EVSE25IAT01";
      // 
      // GBPrice
      // 
      GBPrice.Controls.Add(LPrice);
      GBPrice.Location = new Point(621, 148);
      GBPrice.Name = "GBPrice";
      GBPrice.Size = new Size(172, 47);
      GBPrice.TabIndex = 14;
      GBPrice.TabStop = false;
      GBPrice.Text = "Session Price";
      // 
      // LPrice
      // 
      LPrice.AutoSize = true;
      LPrice.Font = new Font("Segoe UI", 12F);
      LPrice.Location = new Point(78, 19);
      LPrice.Name = "LPrice";
      LPrice.Size = new Size(84, 21);
      LPrice.TabIndex = 0;
      LPrice.Text = "00.00 TND";
      // 
      // GBEnergy
      // 
      GBEnergy.Controls.Add(LEnergy);
      GBEnergy.Location = new Point(442, 148);
      GBEnergy.Name = "GBEnergy";
      GBEnergy.Size = new Size(173, 47);
      GBEnergy.TabIndex = 13;
      GBEnergy.TabStop = false;
      GBEnergy.Text = "Session energy";
      // 
      // LEnergy
      // 
      LEnergy.AutoSize = true;
      LEnergy.Font = new Font("Segoe UI", 12F);
      LEnergy.Location = new Point(81, 18);
      LEnergy.Name = "LEnergy";
      LEnergy.Size = new Size(86, 21);
      LEnergy.TabIndex = 0;
      LEnergy.Text = "00.00 KWh";
      // 
      // GBStartTime
      // 
      GBStartTime.Controls.Add(LStartTime);
      GBStartTime.Location = new Point(621, 95);
      GBStartTime.Name = "GBStartTime";
      GBStartTime.Size = new Size(172, 47);
      GBStartTime.TabIndex = 12;
      GBStartTime.TabStop = false;
      GBStartTime.Text = "Session time";
      // 
      // LStartTime
      // 
      LStartTime.AutoSize = true;
      LStartTime.Font = new Font("Segoe UI", 14F);
      LStartTime.Location = new Point(86, 15);
      LStartTime.Name = "LStartTime";
      LStartTime.Size = new Size(80, 25);
      LStartTime.TabIndex = 0;
      LStartTime.Text = "00:00:00";
      // 
      // GBChargeActions
      // 
      GBChargeActions.Controls.Add(BStartStop);
      GBChargeActions.Controls.Add(LCurrent);
      GBChargeActions.Controls.Add(TBCurrent);
      GBChargeActions.Controls.Add(LChargingCurrent);
      GBChargeActions.Controls.Add(RBScheduled);
      GBChargeActions.Controls.Add(RBAuto);
      GBChargeActions.Controls.Add(RBManual);
      GBChargeActions.Controls.Add(LChargeMode);
      GBChargeActions.Location = new Point(11, 6);
      GBChargeActions.Name = "GBChargeActions";
      GBChargeActions.Size = new Size(782, 83);
      GBChargeActions.TabIndex = 11;
      GBChargeActions.TabStop = false;
      // 
      // BStartStop
      // 
      BStartStop.Font = new Font("Segoe UI", 12F);
      BStartStop.Location = new Point(641, 22);
      BStartStop.Name = "BStartStop";
      BStartStop.Size = new Size(131, 48);
      BStartStop.TabIndex = 7;
      BStartStop.Text = "CHARGE NOW";
      BStartStop.UseVisualStyleBackColor = true;
      BStartStop.Click += BStartStop_Click;
      // 
      // LCurrent
      // 
      LCurrent.AutoSize = true;
      LCurrent.Font = new Font("Segoe UI", 12F);
      LCurrent.Location = new Point(564, 37);
      LCurrent.Name = "LCurrent";
      LCurrent.Size = new Size(27, 21);
      LCurrent.TabIndex = 6;
      LCurrent.Text = ". A";
      // 
      // TBCurrent
      // 
      TBCurrent.BackColor = SystemColors.Window;
      TBCurrent.Location = new Point(414, 29);
      TBCurrent.Name = "TBCurrent";
      TBCurrent.Size = new Size(142, 45);
      TBCurrent.TabIndex = 5;
      TBCurrent.Scroll += TBCurrent_Scroll;
      // 
      // LChargingCurrent
      // 
      LChargingCurrent.AutoSize = true;
      LChargingCurrent.Location = new Point(414, 15);
      LChargingCurrent.Name = "LChargingCurrent";
      LChargingCurrent.Size = new Size(142, 15);
      LChargingCurrent.TabIndex = 4;
      LChargingCurrent.Text = "Charging current [6-32A]:";
      // 
      // RBScheduled
      // 
      RBScheduled.AutoSize = true;
      RBScheduled.Location = new Point(231, 34);
      RBScheduled.Name = "RBScheduled";
      RBScheduled.Size = new Size(80, 19);
      RBScheduled.TabIndex = 3;
      RBScheduled.TabStop = true;
      RBScheduled.Text = "Scheduled";
      RBScheduled.UseVisualStyleBackColor = true;
      // 
      // RBAuto
      // 
      RBAuto.AutoSize = true;
      RBAuto.Location = new Point(174, 34);
      RBAuto.Name = "RBAuto";
      RBAuto.Size = new Size(51, 19);
      RBAuto.TabIndex = 2;
      RBAuto.TabStop = true;
      RBAuto.Text = "Auto";
      RBAuto.UseVisualStyleBackColor = true;
      // 
      // RBManual
      // 
      RBManual.AutoSize = true;
      RBManual.Location = new Point(103, 34);
      RBManual.Name = "RBManual";
      RBManual.Size = new Size(65, 19);
      RBManual.TabIndex = 1;
      RBManual.TabStop = true;
      RBManual.Text = "Manual";
      RBManual.UseVisualStyleBackColor = true;
      RBManual.CheckedChanged += RBManuel_CheckedChanged;
      // 
      // LChargeMode
      // 
      LChargeMode.AutoSize = true;
      LChargeMode.Location = new Point(15, 34);
      LChargeMode.Name = "LChargeMode";
      LChargeMode.Size = new Size(88, 15);
      LChargeMode.TabIndex = 0;
      LChargeMode.Text = "Charge mode : ";
      // 
      // PBPlug
      // 
      PBPlug.Location = new Point(27, 113);
      PBPlug.Name = "PBPlug";
      PBPlug.Size = new Size(394, 297);
      PBPlug.TabIndex = 10;
      PBPlug.TabStop = false;
      // 
      // LBOutput
      // 
      LBOutput.FormattingEnabled = true;
      LBOutput.ItemHeight = 15;
      LBOutput.Location = new Point(8, 589);
      LBOutput.Name = "LBOutput";
      LBOutput.Size = new Size(805, 124);
      LBOutput.TabIndex = 2;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(23, 561);
      label7.Name = "label7";
      label7.Size = new Size(45, 15);
      label7.TabIndex = 3;
      label7.Text = "Output";
      // 
      // button1
      // 
      button1.BackColor = Color.IndianRed;
      button1.Location = new Point(74, 558);
      button1.Name = "button1";
      button1.Size = new Size(26, 25);
      button1.TabIndex = 8;
      button1.UseVisualStyleBackColor = false;
      // 
      // PBIAT
      // 
      PBIAT.Location = new Point(705, 531);
      PBIAT.Name = "PBIAT";
      PBIAT.Size = new Size(100, 52);
      PBIAT.TabIndex = 9;
      PBIAT.TabStop = false;
      // 
      // timer
      // 
      timer.Interval = 1000;
      timer.Tick += Timer_Tick;
      // 
      // Main
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      AutoSizeMode = AutoSizeMode.GrowAndShrink;
      BackColor = SystemColors.InactiveCaption;
      ClientSize = new Size(823, 792);
      Controls.Add(PBIAT);
      Controls.Add(button1);
      Controls.Add(label7);
      Controls.Add(LBOutput);
      Controls.Add(tabControl1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "Main";
      Text = "Form1";
      Load += Main_Load;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      tabControl1.ResumeLayout(false);
      TabOpen.ResumeLayout(false);
      tabControl2.ResumeLayout(false);
      TabLink.ResumeLayout(false);
      TabLink.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)PBStatus).EndInit();
      TabEXE.ResumeLayout(false);
      TabEXE.PerformLayout();
      TabCharging.ResumeLayout(false);
      GBStationName.ResumeLayout(false);
      GBStationName.PerformLayout();
      GBPrice.ResumeLayout(false);
      GBPrice.PerformLayout();
      GBEnergy.ResumeLayout(false);
      GBEnergy.PerformLayout();
      GBStartTime.ResumeLayout(false);
      GBStartTime.PerformLayout();
      GBChargeActions.ResumeLayout(false);
      GBChargeActions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)TBCurrent).EndInit();
      ((System.ComponentModel.ISupportInitialize)PBPlug).EndInit();
      ((System.ComponentModel.ISupportInitialize)PBIAT).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripTextBox toolStripTextBox1;
    private ToolStripTextBox toolStripTextBox2;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripTextBox toolStripTextBox3;
    private TabControl tabControl1;
    private TabPage TabOpen;
    private TabPage TabEXE;
    private TabControl tabControl2;
    private TabPage TabLink;
    private TabPage TabAsso;
    private Label label5;
    private ComboBox CBBaudRate;
    private Button BRefreshCOM;
    private Label label4;
    private ComboBox CBDevice;
    private Label label3;
    private TextBox TBSerialNumber;
    private Label label2;
    private TextBox TBAddress;
    private Label label1;
    private ComboBox CBPort;
    private Button BOpen;
    private Button BClose;
    private TextBox TBPath;
    private Button BChangePath;
    private ListBox LBFiles;
    private Label label6;
    private Button BDelete;
    private Button BExecute;
    private TextBox TBTextFile;
    private Button BRefreshFiles;
    private ListBox LBOutput;
    private Label label7;
    private Button button1;
    private PictureBox PBStatus;
    private PictureBox PBIAT;
    private TabPage TabCharging;
    private PictureBox PBPlug;
    private GroupBox GBChargeActions;
    private Label LChargeMode;
    private RadioButton RBScheduled;
    private RadioButton RBAuto;
    private RadioButton RBManual;
    private Label LCurrent;
    private TrackBar TBCurrent;
    private Label LChargingCurrent;
    private Button BStartStop;
    private GroupBox GBEnergy;
    private Label LEnergy;
    private GroupBox GBStartTime;
    private Label LStartTime;
    private GroupBox GBPrice;
    private Label LPrice;
    private GroupBox GBStationName;
    private Label LStationName;
  }
}
