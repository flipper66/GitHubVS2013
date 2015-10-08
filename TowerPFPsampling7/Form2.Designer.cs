namespace WindowsFormsApplication1
{
    partial class frm_TOWER_PFP
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txt_PFP_TEXT = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txt_TXT2PFP = new System.Windows.Forms.TextBox();
            this.btnSendText2PFP = new System.Windows.Forms.Button();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.btnCloseCom = new System.Windows.Forms.Button();
            this.txt_COM_NAME = new System.Windows.Forms.TextBox();
            this.btn_GET_HISTORY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_READ_COM = new System.Windows.Forms.Button();
            this.btn_MANUAL_SAMPLE = new System.Windows.Forms.Button();
            this.chk_MONITOR_PFP = new System.Windows.Forms.CheckBox();
            this.txt_MONITOR_FREQUENCY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CLEAR_SCREEN = new System.Windows.Forms.Button();
            this.lbl_UTC_TIME = new System.Windows.Forms.Label();
            this.tb_cmds = new System.Windows.Forms.TabControl();
            this.chk_F5 = new System.Windows.Forms.TabPage();
            this.lbl_DOY_LASTSAMPLE = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_tf12 = new System.Windows.Forms.Label();
            this.lbl_tf11 = new System.Windows.Forms.Label();
            this.lbl_tf10 = new System.Windows.Forms.Label();
            this.lbl_tf9 = new System.Windows.Forms.Label();
            this.lbl_tf8 = new System.Windows.Forms.Label();
            this.lbl_tf7 = new System.Windows.Forms.Label();
            this.lbl_tf6 = new System.Windows.Forms.Label();
            this.lbl_tf5 = new System.Windows.Forms.Label();
            this.lbl_tf4 = new System.Windows.Forms.Label();
            this.lbl_tf3 = new System.Windows.Forms.Label();
            this.lbl_tf2 = new System.Windows.Forms.Label();
            this.lbl_tf1 = new System.Windows.Forms.Label();
            this.lbl_alt12 = new System.Windows.Forms.Label();
            this.chk_F12 = new System.Windows.Forms.CheckBox();
            this.lbl_alt11 = new System.Windows.Forms.Label();
            this.chk_F4 = new System.Windows.Forms.CheckBox();
            this.lbl_alt10 = new System.Windows.Forms.Label();
            this.chk_F11 = new System.Windows.Forms.CheckBox();
            this.lbl_alt9 = new System.Windows.Forms.Label();
            this.chk_F3 = new System.Windows.Forms.CheckBox();
            this.lbl_alt8 = new System.Windows.Forms.Label();
            this.chk_F10 = new System.Windows.Forms.CheckBox();
            this.lbl_alt7 = new System.Windows.Forms.Label();
            this.chk_F9 = new System.Windows.Forms.CheckBox();
            this.lbl_alt6 = new System.Windows.Forms.Label();
            this.chk_F1 = new System.Windows.Forms.CheckBox();
            this.lbl_alt5 = new System.Windows.Forms.Label();
            this.chk_F8 = new System.Windows.Forms.CheckBox();
            this.lbl_alt4 = new System.Windows.Forms.Label();
            this.chk_F7 = new System.Windows.Forms.CheckBox();
            this.lbl_alt3 = new System.Windows.Forms.Label();
            this.chk_F6 = new System.Windows.Forms.CheckBox();
            this.lbl_alt2 = new System.Windows.Forms.Label();
            this.chk_F5x = new System.Windows.Forms.CheckBox();
            this.lbl_alt1 = new System.Windows.Forms.Label();
            this.chk_F2 = new System.Windows.Forms.CheckBox();
            this.lbl_t1 = new System.Windows.Forms.Label();
            this.lbl_d1 = new System.Windows.Forms.Label();
            this.lbl_t2 = new System.Windows.Forms.Label();
            this.lbl_t3 = new System.Windows.Forms.Label();
            this.lbl_t4 = new System.Windows.Forms.Label();
            this.lbl_t5 = new System.Windows.Forms.Label();
            this.lbl_t6 = new System.Windows.Forms.Label();
            this.lbl_t7 = new System.Windows.Forms.Label();
            this.lbl_t8 = new System.Windows.Forms.Label();
            this.lbl_t9 = new System.Windows.Forms.Label();
            this.lbl_t10 = new System.Windows.Forms.Label();
            this.lbl_t11 = new System.Windows.Forms.Label();
            this.lbl_t12 = new System.Windows.Forms.Label();
            this.lbl_d2 = new System.Windows.Forms.Label();
            this.lbl_d3 = new System.Windows.Forms.Label();
            this.lbl_d4 = new System.Windows.Forms.Label();
            this.lbl_d5 = new System.Windows.Forms.Label();
            this.lbl_d6 = new System.Windows.Forms.Label();
            this.lbl_d7 = new System.Windows.Forms.Label();
            this.lbl_d9 = new System.Windows.Forms.Label();
            this.lbl_d10 = new System.Windows.Forms.Label();
            this.lbl_d11 = new System.Windows.Forms.Label();
            this.lbl_d12 = new System.Windows.Forms.Label();
            this.lbl_d8 = new System.Windows.Forms.Label();
            this.lbl_PREFILL_COUNT = new System.Windows.Forms.Label();
            this.lbl_EXECUTINGSEQUENCE = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btn_WRITE_PLAN = new System.Windows.Forms.Button();
            this.btn_SAMPLE_PLAN = new System.Windows.Forms.Button();
            this.btn_SAMP_FILL_LIMITS = new System.Windows.Forms.Button();
            this.btn_PREFILL_LIMITS = new System.Windows.Forms.Button();
            this.btn_FIND_SAMPLE_ADD = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ALTADD1 = new System.Windows.Forms.TextBox();
            this.txt_ALTADD2 = new System.Windows.Forms.TextBox();
            this.txt_SAMPADD2 = new System.Windows.Forms.TextBox();
            this.txt_SAMPADD1 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_LIM_4SF_samplefill = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_LIM_2MF_samplefill = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_LIM_1MFT = new System.Windows.Forms.TextBox();
            this.txt_LIM_4SF_prefill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_LIM_3DMF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_LIM_7MFP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_LIM_6MFT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_LIM_5DSF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_LIM_2MF_prefill = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbF12 = new System.Windows.Forms.TextBox();
            this.tbF11 = new System.Windows.Forms.TextBox();
            this.tbF10 = new System.Windows.Forms.TextBox();
            this.tbF9 = new System.Windows.Forms.TextBox();
            this.tbF8 = new System.Windows.Forms.TextBox();
            this.tbF7 = new System.Windows.Forms.TextBox();
            this.tbF6 = new System.Windows.Forms.TextBox();
            this.tbF5 = new System.Windows.Forms.TextBox();
            this.tbF4 = new System.Windows.Forms.TextBox();
            this.tbF3 = new System.Windows.Forms.TextBox();
            this.tbF2 = new System.Windows.Forms.TextBox();
            this.tbF1 = new System.Windows.Forms.TextBox();
            this.btn_EXECUTE_CMDS = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chk_Eday_MWO = new System.Windows.Forms.CheckBox();
            this.txt_MWO_SFLUSH = new System.Windows.Forms.TextBox();
            this.txt_MWO_MFLUSH = new System.Windows.Forms.TextBox();
            this.txt_MWO_COM = new System.Windows.Forms.TextBox();
            this.txt_MWO_TIME = new System.Windows.Forms.TextBox();
            this.chk_COMTRIGS_MBO = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_WGC = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_WKT = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_WBI = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_SCT = new System.Windows.Forms.CheckBox();
            this.chk_EdayWKT = new System.Windows.Forms.CheckBox();
            this.chk_EdayWBI = new System.Windows.Forms.CheckBox();
            this.chk_EdaySCT = new System.Windows.Forms.CheckBox();
            this.chk_EdayLEF = new System.Windows.Forms.CheckBox();
            this.chk_EdayBAO = new System.Windows.Forms.CheckBox();
            this.chk_EdayWGC = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_WGC_Sflush = new System.Windows.Forms.TextBox();
            this.txt_WKT_Sflush = new System.Windows.Forms.TextBox();
            this.txt_WBI_Sflush = new System.Windows.Forms.TextBox();
            this.txt_SCT_Sflush = new System.Windows.Forms.TextBox();
            this.txt_LEF_Sflush = new System.Windows.Forms.TextBox();
            this.txt_BAO_Sflush = new System.Windows.Forms.TextBox();
            this.txt_WGC_Mflush = new System.Windows.Forms.TextBox();
            this.txt_WKT_Mflush = new System.Windows.Forms.TextBox();
            this.txt_WBI_Mflush = new System.Windows.Forms.TextBox();
            this.txt_SCT_Mflush = new System.Windows.Forms.TextBox();
            this.txt_LEF_Mflush = new System.Windows.Forms.TextBox();
            this.txt_BAO_Mflush = new System.Windows.Forms.TextBox();
            this.txt_AMT_Mflush = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txt_WGC_COM = new System.Windows.Forms.TextBox();
            this.txt_WBI_COM = new System.Windows.Forms.TextBox();
            this.txt_SCT_COM = new System.Windows.Forms.TextBox();
            this.txt_LEF_COM = new System.Windows.Forms.TextBox();
            this.txt_BAO_COM = new System.Windows.Forms.TextBox();
            this.txt_AMT_COM = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_WGC_time = new System.Windows.Forms.TextBox();
            this.txt_WKT_time = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_WBI_time = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_SCT_time = new System.Windows.Forms.TextBox();
            this.txt_LEF_time = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_BAO_time = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_AMT_time = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txt_AMT_Sflush = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_LEW_time = new System.Windows.Forms.TextBox();
            this.txt_LEW_COM = new System.Windows.Forms.TextBox();
            this.txt_LEW_Mflush = new System.Windows.Forms.TextBox();
            this.txt_LEW_Sflush = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.chk_EdayAMT = new System.Windows.Forms.CheckBox();
            this.chk_EdayMBO = new System.Windows.Forms.CheckBox();
            this.chk_EdayLEW = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_AMT = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_BAO = new System.Windows.Forms.CheckBox();
            this.chk_COMTRIGS_LEW = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.chk_COMTRIGS_LEF = new System.Windows.Forms.CheckBox();
            this.txt_WKT_COM = new System.Windows.Forms.TextBox();
            this.chk_COMTRIG_MWO = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_GET_SAMPLE_PLAN = new System.Windows.Forms.Button();
            this.btn_GET_NFILL2 = new System.Windows.Forms.Button();
            this.btn_LOAD_SITE_SETTINGS = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_PREFILLTIME = new System.Windows.Forms.TextBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.chk_SAVE_TO_FILE = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_SAMPLE_TIME = new System.Windows.Forms.CheckBox();
            this.chk_PREFILLTIME = new System.Windows.Forms.CheckBox();
            this.txt_SAMPLE_TIME = new System.Windows.Forms.TextBox();
            this.lbl_COM_PORT_OPEN = new System.Windows.Forms.Label();
            this.btn_QUIT_TO_MAIN = new System.Windows.Forms.Button();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.btn_END_LOGGING = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.btn_GETPFPNUMBER = new System.Windows.Forms.Button();
            this.rbtn_EVERYDAY = new System.Windows.Forms.RadioButton();
            this.rbtn_EVERYOTHERDAY = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_LASTSAMPLE = new System.Windows.Forms.CheckBox();
            this.lbl_PFPNUMBER = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DOY = new System.Windows.Forms.Label();
            this.cbo_SITE_CODE = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SYSTEMTEST = new System.Windows.Forms.Button();
            this.txt_PREFILLTIME2 = new System.Windows.Forms.TextBox();
            this.txt_SAMPLETIME2 = new System.Windows.Forms.TextBox();
            this.chk_SAMPLETIME2 = new System.Windows.Forms.CheckBox();
            this.chk_PREFILLTIME2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tb_cmds.SuspendLayout();
            this.chk_F5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_PFP_TEXT
            // 
            this.txt_PFP_TEXT.Location = new System.Drawing.Point(17, 101);
            this.txt_PFP_TEXT.Multiline = true;
            this.txt_PFP_TEXT.Name = "txt_PFP_TEXT";
            this.txt_PFP_TEXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PFP_TEXT.Size = new System.Drawing.Size(395, 380);
            this.txt_PFP_TEXT.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txt_TXT2PFP
            // 
            this.txt_TXT2PFP.Location = new System.Drawing.Point(19, 78);
            this.txt_TXT2PFP.Name = "txt_TXT2PFP";
            this.txt_TXT2PFP.Size = new System.Drawing.Size(46, 20);
            this.txt_TXT2PFP.TabIndex = 26;
            // 
            // btnSendText2PFP
            // 
            this.btnSendText2PFP.Location = new System.Drawing.Point(73, 79);
            this.btnSendText2PFP.Name = "btnSendText2PFP";
            this.btnSendText2PFP.Size = new System.Drawing.Size(86, 19);
            this.btnSendText2PFP.TabIndex = 27;
            this.btnSendText2PFP.Text = "SEND TO PFP";
            this.btnSendText2PFP.UseVisualStyleBackColor = true;
            this.btnSendText2PFP.Click += new System.EventHandler(this.btnSendText2PFP_Click);
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(210, 5);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(87, 19);
            this.btnOpenCom.TabIndex = 28;
            this.btnOpenCom.Text = "2. OPEN COM";
            this.btnOpenCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // btnCloseCom
            // 
            this.btnCloseCom.Location = new System.Drawing.Point(295, 77);
            this.btnCloseCom.Name = "btnCloseCom";
            this.btnCloseCom.Size = new System.Drawing.Size(77, 19);
            this.btnCloseCom.TabIndex = 29;
            this.btnCloseCom.Text = "CLOSE COM";
            this.btnCloseCom.UseVisualStyleBackColor = true;
            this.btnCloseCom.Click += new System.EventHandler(this.btnCloseCom_Click);
            // 
            // txt_COM_NAME
            // 
            this.txt_COM_NAME.Location = new System.Drawing.Point(242, 53);
            this.txt_COM_NAME.Name = "txt_COM_NAME";
            this.txt_COM_NAME.Size = new System.Drawing.Size(45, 20);
            this.txt_COM_NAME.TabIndex = 31;
            this.txt_COM_NAME.Text = "COM8";
            // 
            // btn_GET_HISTORY
            // 
            this.btn_GET_HISTORY.Location = new System.Drawing.Point(6, 106);
            this.btn_GET_HISTORY.Name = "btn_GET_HISTORY";
            this.btn_GET_HISTORY.Size = new System.Drawing.Size(115, 19);
            this.btn_GET_HISTORY.TabIndex = 32;
            this.btn_GET_HISTORY.Text = "2. HISTORY?";
            this.btn_GET_HISTORY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GET_HISTORY.UseVisualStyleBackColor = true;
            this.btn_GET_HISTORY.Click += new System.EventHandler(this.btn_GET_HISTORY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "TEXT TO SEND TO PFP";
            // 
            // btn_READ_COM
            // 
            this.btn_READ_COM.Location = new System.Drawing.Point(336, 497);
            this.btn_READ_COM.Name = "btn_READ_COM";
            this.btn_READ_COM.Size = new System.Drawing.Size(77, 21);
            this.btn_READ_COM.TabIndex = 35;
            this.btn_READ_COM.Text = "READ COM";
            this.btn_READ_COM.UseVisualStyleBackColor = true;
            this.btn_READ_COM.Click += new System.EventHandler(this.btn_READ_COM_Click);
            // 
            // btn_MANUAL_SAMPLE
            // 
            this.btn_MANUAL_SAMPLE.Location = new System.Drawing.Point(6, 181);
            this.btn_MANUAL_SAMPLE.Name = "btn_MANUAL_SAMPLE";
            this.btn_MANUAL_SAMPLE.Size = new System.Drawing.Size(152, 19);
            this.btn_MANUAL_SAMPLE.TabIndex = 38;
            this.btn_MANUAL_SAMPLE.Text = "5. MANUAL SAMPLE NEXT";
            this.btn_MANUAL_SAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MANUAL_SAMPLE.UseVisualStyleBackColor = true;
            this.btn_MANUAL_SAMPLE.Click += new System.EventHandler(this.btn_MANUAL_SAMPLE_Click);
            // 
            // chk_MONITOR_PFP
            // 
            this.chk_MONITOR_PFP.AutoSize = true;
            this.chk_MONITOR_PFP.Location = new System.Drawing.Point(178, 499);
            this.chk_MONITOR_PFP.Name = "chk_MONITOR_PFP";
            this.chk_MONITOR_PFP.Size = new System.Drawing.Size(141, 17);
            this.chk_MONITOR_PFP.TabIndex = 42;
            this.chk_MONITOR_PFP.Text = "MONITOR PFP SERIAL";
            this.chk_MONITOR_PFP.UseVisualStyleBackColor = true;
            this.chk_MONITOR_PFP.CheckedChanged += new System.EventHandler(this.chk_MONITOR_PFP_CheckedChanged);
            // 
            // txt_MONITOR_FREQUENCY
            // 
            this.txt_MONITOR_FREQUENCY.Location = new System.Drawing.Point(178, 520);
            this.txt_MONITOR_FREQUENCY.Name = "txt_MONITOR_FREQUENCY";
            this.txt_MONITOR_FREQUENCY.Size = new System.Drawing.Size(67, 20);
            this.txt_MONITOR_FREQUENCY.TabIndex = 44;
            this.txt_MONITOR_FREQUENCY.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "MONITOR FREQUENCY (ms)";
            // 
            // btn_CLEAR_SCREEN
            // 
            this.btn_CLEAR_SCREEN.Location = new System.Drawing.Point(17, 497);
            this.btn_CLEAR_SCREEN.Name = "btn_CLEAR_SCREEN";
            this.btn_CLEAR_SCREEN.Size = new System.Drawing.Size(120, 25);
            this.btn_CLEAR_SCREEN.TabIndex = 45;
            this.btn_CLEAR_SCREEN.Text = "CLEAR SCREEN";
            this.btn_CLEAR_SCREEN.UseVisualStyleBackColor = true;
            this.btn_CLEAR_SCREEN.Click += new System.EventHandler(this.btn_CLEAR_SCREEN_Click);
            // 
            // lbl_UTC_TIME
            // 
            this.lbl_UTC_TIME.AutoSize = true;
            this.lbl_UTC_TIME.Location = new System.Drawing.Point(432, 517);
            this.lbl_UTC_TIME.Name = "lbl_UTC_TIME";
            this.lbl_UTC_TIME.Size = new System.Drawing.Size(58, 13);
            this.lbl_UTC_TIME.TabIndex = 46;
            this.lbl_UTC_TIME.Text = "UTC TIME";
            // 
            // tb_cmds
            // 
            this.tb_cmds.Controls.Add(this.chk_F5);
            this.tb_cmds.Controls.Add(this.tabPage2);
            this.tb_cmds.Controls.Add(this.tabPage1);
            this.tb_cmds.Controls.Add(this.tabPage3);
            this.tb_cmds.Controls.Add(this.tabPage4);
            this.tb_cmds.Controls.Add(this.tabPage5);
            this.tb_cmds.Location = new System.Drawing.Point(431, 88);
            this.tb_cmds.Name = "tb_cmds";
            this.tb_cmds.SelectedIndex = 0;
            this.tb_cmds.Size = new System.Drawing.Size(417, 393);
            this.tb_cmds.TabIndex = 47;
            // 
            // chk_F5
            // 
            this.chk_F5.Controls.Add(this.lbl_DOY_LASTSAMPLE);
            this.chk_F5.Controls.Add(this.label39);
            this.chk_F5.Controls.Add(this.tableLayoutPanel4);
            this.chk_F5.Controls.Add(this.lbl_PREFILL_COUNT);
            this.chk_F5.Controls.Add(this.lbl_EXECUTINGSEQUENCE);
            this.chk_F5.Controls.Add(this.label38);
            this.chk_F5.Controls.Add(this.btn_WRITE_PLAN);
            this.chk_F5.Controls.Add(this.btn_SAMPLE_PLAN);
            this.chk_F5.Controls.Add(this.btn_SAMP_FILL_LIMITS);
            this.chk_F5.Controls.Add(this.btn_MANUAL_SAMPLE);
            this.chk_F5.Controls.Add(this.btn_GET_HISTORY);
            this.chk_F5.Controls.Add(this.btn_PREFILL_LIMITS);
            this.chk_F5.Controls.Add(this.btn_FIND_SAMPLE_ADD);
            this.chk_F5.Controls.Add(this.label33);
            this.chk_F5.Controls.Add(this.tableLayoutPanel2);
            this.chk_F5.Controls.Add(this.label34);
            this.chk_F5.Location = new System.Drawing.Point(4, 22);
            this.chk_F5.Name = "chk_F5";
            this.chk_F5.Padding = new System.Windows.Forms.Padding(3);
            this.chk_F5.Size = new System.Drawing.Size(409, 367);
            this.chk_F5.TabIndex = 0;
            this.chk_F5.Text = "PREFILL STEPS";
            this.chk_F5.UseVisualStyleBackColor = true;
            // 
            // lbl_DOY_LASTSAMPLE
            // 
            this.lbl_DOY_LASTSAMPLE.AutoSize = true;
            this.lbl_DOY_LASTSAMPLE.Location = new System.Drawing.Point(364, 335);
            this.lbl_DOY_LASTSAMPLE.Name = "lbl_DOY_LASTSAMPLE";
            this.lbl_DOY_LASTSAMPLE.Size = new System.Drawing.Size(30, 13);
            this.lbl_DOY_LASTSAMPLE.TabIndex = 80;
            this.lbl_DOY_LASTSAMPLE.Text = "DOY";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(225, 335);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(109, 13);
            this.label39.TabIndex = 79;
            this.label39.Text = "DOY LAST SAMPLE:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.19753F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.80247F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf12, 4, 11);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf11, 4, 10);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf10, 4, 9);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf9, 4, 8);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf8, 4, 7);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf7, 4, 6);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf6, 4, 5);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf5, 4, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf4, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf3, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf2, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_tf1, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt12, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.chk_F12, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt11, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.chk_F4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt10, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.chk_F11, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt9, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.chk_F3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt8, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.chk_F10, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt7, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.chk_F9, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt6, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.chk_F1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt5, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.chk_F8, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt4, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.chk_F7, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt3, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.chk_F6, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.chk_F5x, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_alt1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.chk_F2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t1, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d1, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t2, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t3, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t4, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t5, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t6, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t7, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t8, 3, 7);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t9, 3, 8);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t10, 3, 9);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t11, 3, 10);
            this.tableLayoutPanel4.Controls.Add(this.lbl_t12, 3, 11);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d3, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d4, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d5, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d6, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d7, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d9, 2, 8);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d10, 2, 9);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d11, 2, 10);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d12, 2, 11);
            this.tableLayoutPanel4.Controls.Add(this.lbl_d8, 2, 7);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(182, 59);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 12;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 273);
            this.tableLayoutPanel4.TabIndex = 70;
            // 
            // lbl_tf12
            // 
            this.lbl_tf12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf12.AutoSize = true;
            this.lbl_tf12.Location = new System.Drawing.Point(183, 255);
            this.lbl_tf12.Name = "lbl_tf12";
            this.lbl_tf12.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf12.TabIndex = 102;
            this.lbl_tf12.Text = "--";
            // 
            // lbl_tf11
            // 
            this.lbl_tf11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf11.AutoSize = true;
            this.lbl_tf11.Location = new System.Drawing.Point(183, 231);
            this.lbl_tf11.Name = "lbl_tf11";
            this.lbl_tf11.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf11.TabIndex = 101;
            this.lbl_tf11.Text = "--";
            // 
            // lbl_tf10
            // 
            this.lbl_tf10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf10.AutoSize = true;
            this.lbl_tf10.Location = new System.Drawing.Point(183, 208);
            this.lbl_tf10.Name = "lbl_tf10";
            this.lbl_tf10.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf10.TabIndex = 100;
            this.lbl_tf10.Text = "--";
            // 
            // lbl_tf9
            // 
            this.lbl_tf9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf9.AutoSize = true;
            this.lbl_tf9.Location = new System.Drawing.Point(183, 187);
            this.lbl_tf9.Name = "lbl_tf9";
            this.lbl_tf9.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf9.TabIndex = 99;
            this.lbl_tf9.Text = "--";
            // 
            // lbl_tf8
            // 
            this.lbl_tf8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf8.AutoSize = true;
            this.lbl_tf8.Location = new System.Drawing.Point(183, 165);
            this.lbl_tf8.Name = "lbl_tf8";
            this.lbl_tf8.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf8.TabIndex = 98;
            this.lbl_tf8.Text = "--";
            // 
            // lbl_tf7
            // 
            this.lbl_tf7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf7.AutoSize = true;
            this.lbl_tf7.Location = new System.Drawing.Point(183, 142);
            this.lbl_tf7.Name = "lbl_tf7";
            this.lbl_tf7.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf7.TabIndex = 97;
            this.lbl_tf7.Text = "--";
            // 
            // lbl_tf6
            // 
            this.lbl_tf6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf6.AutoSize = true;
            this.lbl_tf6.Location = new System.Drawing.Point(183, 120);
            this.lbl_tf6.Name = "lbl_tf6";
            this.lbl_tf6.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf6.TabIndex = 96;
            this.lbl_tf6.Text = "--";
            // 
            // lbl_tf5
            // 
            this.lbl_tf5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf5.AutoSize = true;
            this.lbl_tf5.Location = new System.Drawing.Point(183, 98);
            this.lbl_tf5.Name = "lbl_tf5";
            this.lbl_tf5.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf5.TabIndex = 95;
            this.lbl_tf5.Text = "--";
            // 
            // lbl_tf4
            // 
            this.lbl_tf4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf4.AutoSize = true;
            this.lbl_tf4.Location = new System.Drawing.Point(183, 76);
            this.lbl_tf4.Name = "lbl_tf4";
            this.lbl_tf4.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf4.TabIndex = 94;
            this.lbl_tf4.Text = "--";
            // 
            // lbl_tf3
            // 
            this.lbl_tf3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf3.AutoSize = true;
            this.lbl_tf3.Location = new System.Drawing.Point(183, 53);
            this.lbl_tf3.Name = "lbl_tf3";
            this.lbl_tf3.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf3.TabIndex = 93;
            this.lbl_tf3.Text = "--";
            // 
            // lbl_tf2
            // 
            this.lbl_tf2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf2.AutoSize = true;
            this.lbl_tf2.Location = new System.Drawing.Point(183, 29);
            this.lbl_tf2.Name = "lbl_tf2";
            this.lbl_tf2.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf2.TabIndex = 92;
            this.lbl_tf2.Text = "--";
            // 
            // lbl_tf1
            // 
            this.lbl_tf1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tf1.AutoSize = true;
            this.lbl_tf1.Location = new System.Drawing.Point(183, 5);
            this.lbl_tf1.Name = "lbl_tf1";
            this.lbl_tf1.Size = new System.Drawing.Size(13, 13);
            this.lbl_tf1.TabIndex = 73;
            this.lbl_tf1.Text = "--";
            // 
            // lbl_alt12
            // 
            this.lbl_alt12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt12.AutoSize = true;
            this.lbl_alt12.Location = new System.Drawing.Point(59, 255);
            this.lbl_alt12.Name = "lbl_alt12";
            this.lbl_alt12.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt12.TabIndex = 91;
            this.lbl_alt12.Text = "X";
            // 
            // chk_F12
            // 
            this.chk_F12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F12.AutoSize = true;
            this.chk_F12.Location = new System.Drawing.Point(4, 253);
            this.chk_F12.Name = "chk_F12";
            this.chk_F12.Size = new System.Drawing.Size(44, 17);
            this.chk_F12.TabIndex = 37;
            this.chk_F12.Text = "F12";
            this.chk_F12.UseVisualStyleBackColor = true;
            // 
            // lbl_alt11
            // 
            this.lbl_alt11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt11.AutoSize = true;
            this.lbl_alt11.Location = new System.Drawing.Point(59, 231);
            this.lbl_alt11.Name = "lbl_alt11";
            this.lbl_alt11.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt11.TabIndex = 90;
            this.lbl_alt11.Text = "X";
            // 
            // chk_F4
            // 
            this.chk_F4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F4.AutoSize = true;
            this.chk_F4.Location = new System.Drawing.Point(7, 75);
            this.chk_F4.Name = "chk_F4";
            this.chk_F4.Size = new System.Drawing.Size(38, 16);
            this.chk_F4.TabIndex = 36;
            this.chk_F4.Text = "F4";
            this.chk_F4.UseVisualStyleBackColor = true;
            // 
            // lbl_alt10
            // 
            this.lbl_alt10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt10.AutoSize = true;
            this.lbl_alt10.Location = new System.Drawing.Point(59, 208);
            this.lbl_alt10.Name = "lbl_alt10";
            this.lbl_alt10.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt10.TabIndex = 89;
            this.lbl_alt10.Text = "X";
            // 
            // chk_F11
            // 
            this.chk_F11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F11.AutoSize = true;
            this.chk_F11.Location = new System.Drawing.Point(4, 229);
            this.chk_F11.Name = "chk_F11";
            this.chk_F11.Size = new System.Drawing.Size(44, 17);
            this.chk_F11.TabIndex = 32;
            this.chk_F11.Text = "F11";
            this.chk_F11.UseVisualStyleBackColor = true;
            // 
            // lbl_alt9
            // 
            this.lbl_alt9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt9.AutoSize = true;
            this.lbl_alt9.Location = new System.Drawing.Point(59, 187);
            this.lbl_alt9.Name = "lbl_alt9";
            this.lbl_alt9.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt9.TabIndex = 88;
            this.lbl_alt9.Text = "X";
            // 
            // chk_F3
            // 
            this.chk_F3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F3.AutoSize = true;
            this.chk_F3.Location = new System.Drawing.Point(7, 51);
            this.chk_F3.Name = "chk_F3";
            this.chk_F3.Size = new System.Drawing.Size(38, 17);
            this.chk_F3.TabIndex = 35;
            this.chk_F3.Text = "F3";
            this.chk_F3.UseVisualStyleBackColor = true;
            // 
            // lbl_alt8
            // 
            this.lbl_alt8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt8.AutoSize = true;
            this.lbl_alt8.Location = new System.Drawing.Point(59, 165);
            this.lbl_alt8.Name = "lbl_alt8";
            this.lbl_alt8.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt8.TabIndex = 87;
            this.lbl_alt8.Text = "X";
            // 
            // chk_F10
            // 
            this.chk_F10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F10.AutoSize = true;
            this.chk_F10.Location = new System.Drawing.Point(4, 207);
            this.chk_F10.Name = "chk_F10";
            this.chk_F10.Size = new System.Drawing.Size(44, 16);
            this.chk_F10.TabIndex = 31;
            this.chk_F10.Text = "F10";
            this.chk_F10.UseVisualStyleBackColor = true;
            // 
            // lbl_alt7
            // 
            this.lbl_alt7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt7.AutoSize = true;
            this.lbl_alt7.Location = new System.Drawing.Point(59, 142);
            this.lbl_alt7.Name = "lbl_alt7";
            this.lbl_alt7.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt7.TabIndex = 86;
            this.lbl_alt7.Text = "X";
            // 
            // chk_F9
            // 
            this.chk_F9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F9.AutoSize = true;
            this.chk_F9.Location = new System.Drawing.Point(7, 187);
            this.chk_F9.Name = "chk_F9";
            this.chk_F9.Size = new System.Drawing.Size(38, 14);
            this.chk_F9.TabIndex = 30;
            this.chk_F9.Text = "F9";
            this.chk_F9.UseVisualStyleBackColor = true;
            // 
            // lbl_alt6
            // 
            this.lbl_alt6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt6.AutoSize = true;
            this.lbl_alt6.Location = new System.Drawing.Point(59, 120);
            this.lbl_alt6.Name = "lbl_alt6";
            this.lbl_alt6.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt6.TabIndex = 85;
            this.lbl_alt6.Text = "X";
            // 
            // chk_F1
            // 
            this.chk_F1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F1.AutoSize = true;
            this.chk_F1.Location = new System.Drawing.Point(7, 3);
            this.chk_F1.Name = "chk_F1";
            this.chk_F1.Size = new System.Drawing.Size(38, 17);
            this.chk_F1.TabIndex = 34;
            this.chk_F1.Text = "F1";
            this.chk_F1.UseVisualStyleBackColor = true;
            // 
            // lbl_alt5
            // 
            this.lbl_alt5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt5.AutoSize = true;
            this.lbl_alt5.Location = new System.Drawing.Point(59, 98);
            this.lbl_alt5.Name = "lbl_alt5";
            this.lbl_alt5.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt5.TabIndex = 84;
            this.lbl_alt5.Text = "X";
            // 
            // chk_F8
            // 
            this.chk_F8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F8.AutoSize = true;
            this.chk_F8.Location = new System.Drawing.Point(7, 163);
            this.chk_F8.Name = "chk_F8";
            this.chk_F8.Size = new System.Drawing.Size(38, 17);
            this.chk_F8.TabIndex = 29;
            this.chk_F8.Text = "F8";
            this.chk_F8.UseVisualStyleBackColor = true;
            // 
            // lbl_alt4
            // 
            this.lbl_alt4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt4.AutoSize = true;
            this.lbl_alt4.Location = new System.Drawing.Point(59, 76);
            this.lbl_alt4.Name = "lbl_alt4";
            this.lbl_alt4.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt4.TabIndex = 83;
            this.lbl_alt4.Text = "X";
            // 
            // chk_F7
            // 
            this.chk_F7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F7.AutoSize = true;
            this.chk_F7.Location = new System.Drawing.Point(7, 141);
            this.chk_F7.Name = "chk_F7";
            this.chk_F7.Size = new System.Drawing.Size(38, 16);
            this.chk_F7.TabIndex = 28;
            this.chk_F7.Text = "F7";
            this.chk_F7.UseVisualStyleBackColor = true;
            // 
            // lbl_alt3
            // 
            this.lbl_alt3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt3.AutoSize = true;
            this.lbl_alt3.Location = new System.Drawing.Point(59, 53);
            this.lbl_alt3.Name = "lbl_alt3";
            this.lbl_alt3.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt3.TabIndex = 82;
            this.lbl_alt3.Text = "X";
            // 
            // chk_F6
            // 
            this.chk_F6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F6.AutoSize = true;
            this.chk_F6.Location = new System.Drawing.Point(7, 119);
            this.chk_F6.Name = "chk_F6";
            this.chk_F6.Size = new System.Drawing.Size(38, 16);
            this.chk_F6.TabIndex = 27;
            this.chk_F6.Text = "F6";
            this.chk_F6.UseVisualStyleBackColor = true;
            // 
            // lbl_alt2
            // 
            this.lbl_alt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt2.AutoSize = true;
            this.lbl_alt2.Location = new System.Drawing.Point(59, 29);
            this.lbl_alt2.Name = "lbl_alt2";
            this.lbl_alt2.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt2.TabIndex = 81;
            this.lbl_alt2.Text = "X";
            // 
            // chk_F5x
            // 
            this.chk_F5x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F5x.AutoSize = true;
            this.chk_F5x.Location = new System.Drawing.Point(7, 97);
            this.chk_F5x.Name = "chk_F5x";
            this.chk_F5x.Size = new System.Drawing.Size(38, 16);
            this.chk_F5x.TabIndex = 26;
            this.chk_F5x.Text = "F5";
            this.chk_F5x.UseVisualStyleBackColor = true;
            // 
            // lbl_alt1
            // 
            this.lbl_alt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_alt1.AutoSize = true;
            this.lbl_alt1.Location = new System.Drawing.Point(59, 5);
            this.lbl_alt1.Name = "lbl_alt1";
            this.lbl_alt1.Size = new System.Drawing.Size(14, 13);
            this.lbl_alt1.TabIndex = 69;
            this.lbl_alt1.Text = "X";
            // 
            // chk_F2
            // 
            this.chk_F2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_F2.AutoSize = true;
            this.chk_F2.Location = new System.Drawing.Point(7, 27);
            this.chk_F2.Name = "chk_F2";
            this.chk_F2.Size = new System.Drawing.Size(38, 17);
            this.chk_F2.TabIndex = 25;
            this.chk_F2.Text = "F2";
            this.chk_F2.UseVisualStyleBackColor = true;
            // 
            // lbl_t1
            // 
            this.lbl_t1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t1.AutoSize = true;
            this.lbl_t1.Location = new System.Drawing.Point(139, 5);
            this.lbl_t1.Name = "lbl_t1";
            this.lbl_t1.Size = new System.Drawing.Size(13, 13);
            this.lbl_t1.TabIndex = 69;
            this.lbl_t1.Text = "--";
            // 
            // lbl_d1
            // 
            this.lbl_d1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d1.AutoSize = true;
            this.lbl_d1.Location = new System.Drawing.Point(96, 5);
            this.lbl_d1.Name = "lbl_d1";
            this.lbl_d1.Size = new System.Drawing.Size(13, 13);
            this.lbl_d1.TabIndex = 68;
            this.lbl_d1.Text = "--";
            // 
            // lbl_t2
            // 
            this.lbl_t2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t2.AutoSize = true;
            this.lbl_t2.Location = new System.Drawing.Point(139, 29);
            this.lbl_t2.Name = "lbl_t2";
            this.lbl_t2.Size = new System.Drawing.Size(13, 13);
            this.lbl_t2.TabIndex = 81;
            this.lbl_t2.Text = "--";
            // 
            // lbl_t3
            // 
            this.lbl_t3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t3.AutoSize = true;
            this.lbl_t3.Location = new System.Drawing.Point(139, 53);
            this.lbl_t3.Name = "lbl_t3";
            this.lbl_t3.Size = new System.Drawing.Size(13, 13);
            this.lbl_t3.TabIndex = 82;
            this.lbl_t3.Text = "--";
            // 
            // lbl_t4
            // 
            this.lbl_t4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t4.AutoSize = true;
            this.lbl_t4.Location = new System.Drawing.Point(139, 76);
            this.lbl_t4.Name = "lbl_t4";
            this.lbl_t4.Size = new System.Drawing.Size(13, 13);
            this.lbl_t4.TabIndex = 83;
            this.lbl_t4.Text = "--";
            // 
            // lbl_t5
            // 
            this.lbl_t5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t5.AutoSize = true;
            this.lbl_t5.Location = new System.Drawing.Point(139, 98);
            this.lbl_t5.Name = "lbl_t5";
            this.lbl_t5.Size = new System.Drawing.Size(13, 13);
            this.lbl_t5.TabIndex = 84;
            this.lbl_t5.Text = "--";
            // 
            // lbl_t6
            // 
            this.lbl_t6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t6.AutoSize = true;
            this.lbl_t6.Location = new System.Drawing.Point(139, 120);
            this.lbl_t6.Name = "lbl_t6";
            this.lbl_t6.Size = new System.Drawing.Size(13, 13);
            this.lbl_t6.TabIndex = 85;
            this.lbl_t6.Text = "--";
            // 
            // lbl_t7
            // 
            this.lbl_t7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t7.AutoSize = true;
            this.lbl_t7.Location = new System.Drawing.Point(139, 142);
            this.lbl_t7.Name = "lbl_t7";
            this.lbl_t7.Size = new System.Drawing.Size(13, 13);
            this.lbl_t7.TabIndex = 86;
            this.lbl_t7.Text = "--";
            // 
            // lbl_t8
            // 
            this.lbl_t8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t8.AutoSize = true;
            this.lbl_t8.Location = new System.Drawing.Point(139, 165);
            this.lbl_t8.Name = "lbl_t8";
            this.lbl_t8.Size = new System.Drawing.Size(13, 13);
            this.lbl_t8.TabIndex = 87;
            this.lbl_t8.Text = "--";
            // 
            // lbl_t9
            // 
            this.lbl_t9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t9.AutoSize = true;
            this.lbl_t9.Location = new System.Drawing.Point(139, 187);
            this.lbl_t9.Name = "lbl_t9";
            this.lbl_t9.Size = new System.Drawing.Size(13, 13);
            this.lbl_t9.TabIndex = 88;
            this.lbl_t9.Text = "--";
            // 
            // lbl_t10
            // 
            this.lbl_t10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t10.AutoSize = true;
            this.lbl_t10.Location = new System.Drawing.Point(139, 208);
            this.lbl_t10.Name = "lbl_t10";
            this.lbl_t10.Size = new System.Drawing.Size(13, 13);
            this.lbl_t10.TabIndex = 89;
            this.lbl_t10.Text = "--";
            // 
            // lbl_t11
            // 
            this.lbl_t11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t11.AutoSize = true;
            this.lbl_t11.Location = new System.Drawing.Point(139, 231);
            this.lbl_t11.Name = "lbl_t11";
            this.lbl_t11.Size = new System.Drawing.Size(13, 13);
            this.lbl_t11.TabIndex = 90;
            this.lbl_t11.Text = "--";
            // 
            // lbl_t12
            // 
            this.lbl_t12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_t12.AutoSize = true;
            this.lbl_t12.Location = new System.Drawing.Point(139, 255);
            this.lbl_t12.Name = "lbl_t12";
            this.lbl_t12.Size = new System.Drawing.Size(13, 13);
            this.lbl_t12.TabIndex = 91;
            this.lbl_t12.Text = "--";
            // 
            // lbl_d2
            // 
            this.lbl_d2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d2.AutoSize = true;
            this.lbl_d2.Location = new System.Drawing.Point(96, 29);
            this.lbl_d2.Name = "lbl_d2";
            this.lbl_d2.Size = new System.Drawing.Size(13, 13);
            this.lbl_d2.TabIndex = 80;
            this.lbl_d2.Text = "--";
            // 
            // lbl_d3
            // 
            this.lbl_d3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d3.AutoSize = true;
            this.lbl_d3.Location = new System.Drawing.Point(96, 53);
            this.lbl_d3.Name = "lbl_d3";
            this.lbl_d3.Size = new System.Drawing.Size(13, 13);
            this.lbl_d3.TabIndex = 79;
            this.lbl_d3.Text = "--";
            // 
            // lbl_d4
            // 
            this.lbl_d4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d4.AutoSize = true;
            this.lbl_d4.Location = new System.Drawing.Point(96, 76);
            this.lbl_d4.Name = "lbl_d4";
            this.lbl_d4.Size = new System.Drawing.Size(13, 13);
            this.lbl_d4.TabIndex = 78;
            this.lbl_d4.Text = "--";
            // 
            // lbl_d5
            // 
            this.lbl_d5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d5.AutoSize = true;
            this.lbl_d5.Location = new System.Drawing.Point(96, 98);
            this.lbl_d5.Name = "lbl_d5";
            this.lbl_d5.Size = new System.Drawing.Size(13, 13);
            this.lbl_d5.TabIndex = 77;
            this.lbl_d5.Text = "--";
            // 
            // lbl_d6
            // 
            this.lbl_d6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d6.AutoSize = true;
            this.lbl_d6.Location = new System.Drawing.Point(96, 120);
            this.lbl_d6.Name = "lbl_d6";
            this.lbl_d6.Size = new System.Drawing.Size(13, 13);
            this.lbl_d6.TabIndex = 76;
            this.lbl_d6.Text = "--";
            // 
            // lbl_d7
            // 
            this.lbl_d7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d7.AutoSize = true;
            this.lbl_d7.Location = new System.Drawing.Point(96, 142);
            this.lbl_d7.Name = "lbl_d7";
            this.lbl_d7.Size = new System.Drawing.Size(13, 13);
            this.lbl_d7.TabIndex = 75;
            this.lbl_d7.Text = "--";
            // 
            // lbl_d9
            // 
            this.lbl_d9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d9.AutoSize = true;
            this.lbl_d9.Location = new System.Drawing.Point(96, 187);
            this.lbl_d9.Name = "lbl_d9";
            this.lbl_d9.Size = new System.Drawing.Size(13, 13);
            this.lbl_d9.TabIndex = 73;
            this.lbl_d9.Text = "--";
            // 
            // lbl_d10
            // 
            this.lbl_d10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d10.AutoSize = true;
            this.lbl_d10.Location = new System.Drawing.Point(96, 208);
            this.lbl_d10.Name = "lbl_d10";
            this.lbl_d10.Size = new System.Drawing.Size(13, 13);
            this.lbl_d10.TabIndex = 72;
            this.lbl_d10.Text = "--";
            // 
            // lbl_d11
            // 
            this.lbl_d11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d11.AutoSize = true;
            this.lbl_d11.Location = new System.Drawing.Point(96, 231);
            this.lbl_d11.Name = "lbl_d11";
            this.lbl_d11.Size = new System.Drawing.Size(13, 13);
            this.lbl_d11.TabIndex = 71;
            this.lbl_d11.Text = "--";
            // 
            // lbl_d12
            // 
            this.lbl_d12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d12.AutoSize = true;
            this.lbl_d12.Location = new System.Drawing.Point(96, 255);
            this.lbl_d12.Name = "lbl_d12";
            this.lbl_d12.Size = new System.Drawing.Size(13, 13);
            this.lbl_d12.TabIndex = 70;
            this.lbl_d12.Text = "--";
            // 
            // lbl_d8
            // 
            this.lbl_d8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_d8.AutoSize = true;
            this.lbl_d8.Location = new System.Drawing.Point(96, 165);
            this.lbl_d8.Name = "lbl_d8";
            this.lbl_d8.Size = new System.Drawing.Size(13, 13);
            this.lbl_d8.TabIndex = 74;
            this.lbl_d8.Text = "--";
            // 
            // lbl_PREFILL_COUNT
            // 
            this.lbl_PREFILL_COUNT.AutoSize = true;
            this.lbl_PREFILL_COUNT.Location = new System.Drawing.Point(21, 54);
            this.lbl_PREFILL_COUNT.Name = "lbl_PREFILL_COUNT";
            this.lbl_PREFILL_COUNT.Size = new System.Drawing.Size(16, 13);
            this.lbl_PREFILL_COUNT.TabIndex = 69;
            this.lbl_PREFILL_COUNT.Text = "0 ";
            this.lbl_PREFILL_COUNT.Click += new System.EventHandler(this.lbl_PREFILL_COUNT_Click);
            // 
            // lbl_EXECUTINGSEQUENCE
            // 
            this.lbl_EXECUTINGSEQUENCE.AutoSize = true;
            this.lbl_EXECUTINGSEQUENCE.Location = new System.Drawing.Point(4, 36);
            this.lbl_EXECUTINGSEQUENCE.Name = "lbl_EXECUTINGSEQUENCE";
            this.lbl_EXECUTINGSEQUENCE.Size = new System.Drawing.Size(172, 13);
            this.lbl_EXECUTINGSEQUENCE.TabIndex = 68;
            this.lbl_EXECUTINGSEQUENCE.Text = "If green, executing prefill sequence";
            this.lbl_EXECUTINGSEQUENCE.Click += new System.EventHandler(this.lbl_EXECUTINGSEQUENCE_Click);
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(182, 36);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(212, 20);
            this.label38.TabIndex = 67;
            this.label38.Text = "FLASK     PLAN    DATE   START     END";
            // 
            // btn_WRITE_PLAN
            // 
            this.btn_WRITE_PLAN.Location = new System.Drawing.Point(6, 310);
            this.btn_WRITE_PLAN.Name = "btn_WRITE_PLAN";
            this.btn_WRITE_PLAN.Size = new System.Drawing.Size(170, 19);
            this.btn_WRITE_PLAN.TabIndex = 65;
            this.btn_WRITE_PLAN.Text = "7. WRITE SAMPLE PLAN ADD";
            this.btn_WRITE_PLAN.UseVisualStyleBackColor = true;
            this.btn_WRITE_PLAN.Click += new System.EventHandler(this.btn_WRITE_PLAN_Click);
            // 
            // btn_SAMPLE_PLAN
            // 
            this.btn_SAMPLE_PLAN.Location = new System.Drawing.Point(6, 81);
            this.btn_SAMPLE_PLAN.Name = "btn_SAMPLE_PLAN";
            this.btn_SAMPLE_PLAN.Size = new System.Drawing.Size(117, 19);
            this.btn_SAMPLE_PLAN.TabIndex = 61;
            this.btn_SAMPLE_PLAN.Text = "1. SAMPLE PLAN?";
            this.btn_SAMPLE_PLAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAMPLE_PLAN.UseVisualStyleBackColor = true;
            this.btn_SAMPLE_PLAN.Click += new System.EventHandler(this.btn_SAMPLE_PLAN_ClicK);
            // 
            // btn_SAMP_FILL_LIMITS
            // 
            this.btn_SAMP_FILL_LIMITS.Location = new System.Drawing.Point(6, 206);
            this.btn_SAMP_FILL_LIMITS.Name = "btn_SAMP_FILL_LIMITS";
            this.btn_SAMP_FILL_LIMITS.Size = new System.Drawing.Size(159, 19);
            this.btn_SAMP_FILL_LIMITS.TabIndex = 50;
            this.btn_SAMP_FILL_LIMITS.Text = "6. SET SAMPLE FILL LIMITS";
            this.btn_SAMP_FILL_LIMITS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAMP_FILL_LIMITS.UseVisualStyleBackColor = true;
            this.btn_SAMP_FILL_LIMITS.Click += new System.EventHandler(this.btn_SAMP_FILL_LIMITS_Click);
            // 
            // btn_PREFILL_LIMITS
            // 
            this.btn_PREFILL_LIMITS.Location = new System.Drawing.Point(6, 156);
            this.btn_PREFILL_LIMITS.Name = "btn_PREFILL_LIMITS";
            this.btn_PREFILL_LIMITS.Size = new System.Drawing.Size(143, 19);
            this.btn_PREFILL_LIMITS.TabIndex = 49;
            this.btn_PREFILL_LIMITS.Text = "4. SET PRE FILL LIMITS";
            this.btn_PREFILL_LIMITS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PREFILL_LIMITS.UseVisualStyleBackColor = true;
            this.btn_PREFILL_LIMITS.Click += new System.EventHandler(this.btn_PREFILL_LIMITS_Click);
            // 
            // btn_FIND_SAMPLE_ADD
            // 
            this.btn_FIND_SAMPLE_ADD.Location = new System.Drawing.Point(6, 131);
            this.btn_FIND_SAMPLE_ADD.Name = "btn_FIND_SAMPLE_ADD";
            this.btn_FIND_SAMPLE_ADD.Size = new System.Drawing.Size(159, 19);
            this.btn_FIND_SAMPLE_ADD.TabIndex = 63;
            this.btn_FIND_SAMPLE_ADD.Text = "3.  FIND SAMPLE PLAN ADD";
            this.btn_FIND_SAMPLE_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FIND_SAMPLE_ADD.UseVisualStyleBackColor = true;
            this.btn_FIND_SAMPLE_ADD.Click += new System.EventHandler(this.btn_FIND_SAMPLE_ADD_Click);
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(3, 243);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 58);
            this.label33.TabIndex = 35;
            this.label33.Text = "SAMPLE PLAN ADD TO OVERWRITE PREFILL";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_ALTADD1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_ALTADD2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_SAMPADD2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_SAMPADD1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(101, 243);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(72, 61);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // txt_ALTADD1
            // 
            this.txt_ALTADD1.Location = new System.Drawing.Point(39, 3);
            this.txt_ALTADD1.Name = "txt_ALTADD1";
            this.txt_ALTADD1.Size = new System.Drawing.Size(30, 20);
            this.txt_ALTADD1.TabIndex = 29;
            // 
            // txt_ALTADD2
            // 
            this.txt_ALTADD2.Location = new System.Drawing.Point(39, 33);
            this.txt_ALTADD2.Name = "txt_ALTADD2";
            this.txt_ALTADD2.Size = new System.Drawing.Size(30, 20);
            this.txt_ALTADD2.TabIndex = 31;
            // 
            // txt_SAMPADD2
            // 
            this.txt_SAMPADD2.Location = new System.Drawing.Point(3, 33);
            this.txt_SAMPADD2.Name = "txt_SAMPADD2";
            this.txt_SAMPADD2.Size = new System.Drawing.Size(30, 20);
            this.txt_SAMPADD2.TabIndex = 30;
            // 
            // txt_SAMPADD1
            // 
            this.txt_SAMPADD1.Location = new System.Drawing.Point(3, 3);
            this.txt_SAMPADD1.Name = "txt_SAMPADD1";
            this.txt_SAMPADD1.Size = new System.Drawing.Size(30, 20);
            this.txt_SAMPADD1.TabIndex = 28;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(101, 232);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 20);
            this.label34.TabIndex = 36;
            this.label34.Text = "flask altitude";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txt_LIM_4SF_samplefill);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txt_LIM_2MF_samplefill);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_LIM_1MFT);
            this.tabPage2.Controls.Add(this.txt_LIM_4SF_prefill);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txt_LIM_3DMF);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_LIM_7MFP);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_LIM_6MFT);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txt_LIM_5DSF);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_LIM_2MF_prefill);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LIMITS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "SAMPLE SAMPLING LIMITS";
            // 
            // txt_LIM_4SF_samplefill
            // 
            this.txt_LIM_4SF_samplefill.Location = new System.Drawing.Point(196, 305);
            this.txt_LIM_4SF_samplefill.Name = "txt_LIM_4SF_samplefill";
            this.txt_LIM_4SF_samplefill.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_4SF_samplefill.TabIndex = 60;
            this.txt_LIM_4SF_samplefill.Text = "70";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "MANIFOLD FLUSH VOLUME";
            // 
            // txt_LIM_2MF_samplefill
            // 
            this.txt_LIM_2MF_samplefill.Location = new System.Drawing.Point(196, 280);
            this.txt_LIM_2MF_samplefill.Name = "txt_LIM_2MF_samplefill";
            this.txt_LIM_2MF_samplefill.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_2MF_samplefill.TabIndex = 58;
            this.txt_LIM_2MF_samplefill.Text = "80";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 308);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "SAMPLE FLUSH VOLUME";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "PRE-FILL SAMPLING LIMITS";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 27);
            this.label14.TabIndex = 55;
            this.label14.Text = "BOTH PRE-FILL SAMPLING LIMITS AND SAMPLE LIMITS";
            // 
            // txt_LIM_1MFT
            // 
            this.txt_LIM_1MFT.Location = new System.Drawing.Point(193, 50);
            this.txt_LIM_1MFT.Name = "txt_LIM_1MFT";
            this.txt_LIM_1MFT.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_1MFT.TabIndex = 42;
            this.txt_LIM_1MFT.Text = "600";
            // 
            // txt_LIM_4SF_prefill
            // 
            this.txt_LIM_4SF_prefill.Location = new System.Drawing.Point(194, 228);
            this.txt_LIM_4SF_prefill.Name = "txt_LIM_4SF_prefill";
            this.txt_LIM_4SF_prefill.Size = new System.Drawing.Size(50, 20);
            this.txt_LIM_4SF_prefill.TabIndex = 54;
            this.txt_LIM_4SF_prefill.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "MANIFOLD FLUSH VOLUME";
            // 
            // txt_LIM_3DMF
            // 
            this.txt_LIM_3DMF.Location = new System.Drawing.Point(193, 77);
            this.txt_LIM_3DMF.Name = "txt_LIM_3DMF";
            this.txt_LIM_3DMF.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_3DMF.TabIndex = 52;
            this.txt_LIM_3DMF.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "DEFAULT MANIFOLD FLUSH";
            // 
            // txt_LIM_7MFP
            // 
            this.txt_LIM_7MFP.Location = new System.Drawing.Point(193, 154);
            this.txt_LIM_7MFP.Name = "txt_LIM_7MFP";
            this.txt_LIM_7MFP.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_7MFP.TabIndex = 50;
            this.txt_LIM_7MFP.Text = "40";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "MIN FILL PRESSURE";
            // 
            // txt_LIM_6MFT
            // 
            this.txt_LIM_6MFT.Location = new System.Drawing.Point(193, 128);
            this.txt_LIM_6MFT.Name = "txt_LIM_6MFT";
            this.txt_LIM_6MFT.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_6MFT.TabIndex = 48;
            this.txt_LIM_6MFT.Text = "150";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "MAX FILL TIME";
            // 
            // txt_LIM_5DSF
            // 
            this.txt_LIM_5DSF.Location = new System.Drawing.Point(193, 103);
            this.txt_LIM_5DSF.Name = "txt_LIM_5DSF";
            this.txt_LIM_5DSF.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_5DSF.TabIndex = 46;
            this.txt_LIM_5DSF.Text = "40";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "DEFAULT SAMPLE FLUSH";
            // 
            // txt_LIM_2MF_prefill
            // 
            this.txt_LIM_2MF_prefill.Location = new System.Drawing.Point(193, 201);
            this.txt_LIM_2MF_prefill.Name = "txt_LIM_2MF_prefill";
            this.txt_LIM_2MF_prefill.Size = new System.Drawing.Size(50, 20);
            this.txt_LIM_2MF_prefill.TabIndex = 44;
            this.txt_LIM_2MF_prefill.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "SAMPLE FLUSH VOLUME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "MAX FLUSH TIME";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_EXECUTE_CMDS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 367);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "CMD\'S";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AllowDrop = true;
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(-3, 3);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(414, 13);
            this.label43.TabIndex = 44;
            this.label43.Text = "Example: q_n300 (q = quit, n for don\'t clear text box, 300 = wait 300 ms after co" +
    "mmand";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbF12);
            this.groupBox1.Controls.Add(this.tbF11);
            this.groupBox1.Controls.Add(this.tbF10);
            this.groupBox1.Controls.Add(this.tbF9);
            this.groupBox1.Controls.Add(this.tbF8);
            this.groupBox1.Controls.Add(this.tbF7);
            this.groupBox1.Controls.Add(this.tbF6);
            this.groupBox1.Controls.Add(this.tbF5);
            this.groupBox1.Controls.Add(this.tbF4);
            this.groupBox1.Controls.Add(this.tbF3);
            this.groupBox1.Controls.Add(this.tbF2);
            this.groupBox1.Controls.Add(this.tbF1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 320);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PFP CMDS";
            // 
            // tbF12
            // 
            this.tbF12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF12.Location = new System.Drawing.Point(15, 287);
            this.tbF12.Name = "tbF12";
            this.tbF12.Size = new System.Drawing.Size(57, 20);
            this.tbF12.TabIndex = 22;
            // 
            // tbF11
            // 
            this.tbF11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF11.Location = new System.Drawing.Point(15, 262);
            this.tbF11.Name = "tbF11";
            this.tbF11.Size = new System.Drawing.Size(57, 20);
            this.tbF11.TabIndex = 21;
            // 
            // tbF10
            // 
            this.tbF10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF10.Location = new System.Drawing.Point(15, 237);
            this.tbF10.Name = "tbF10";
            this.tbF10.Size = new System.Drawing.Size(57, 20);
            this.tbF10.TabIndex = 20;
            // 
            // tbF9
            // 
            this.tbF9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF9.Location = new System.Drawing.Point(15, 212);
            this.tbF9.Name = "tbF9";
            this.tbF9.Size = new System.Drawing.Size(57, 20);
            this.tbF9.TabIndex = 19;
            // 
            // tbF8
            // 
            this.tbF8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF8.Location = new System.Drawing.Point(15, 188);
            this.tbF8.Name = "tbF8";
            this.tbF8.Size = new System.Drawing.Size(57, 20);
            this.tbF8.TabIndex = 18;
            // 
            // tbF7
            // 
            this.tbF7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF7.Location = new System.Drawing.Point(15, 162);
            this.tbF7.Name = "tbF7";
            this.tbF7.Size = new System.Drawing.Size(57, 20);
            this.tbF7.TabIndex = 17;
            // 
            // tbF6
            // 
            this.tbF6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF6.Location = new System.Drawing.Point(15, 137);
            this.tbF6.Name = "tbF6";
            this.tbF6.Size = new System.Drawing.Size(57, 20);
            this.tbF6.TabIndex = 16;
            // 
            // tbF5
            // 
            this.tbF5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF5.Location = new System.Drawing.Point(15, 114);
            this.tbF5.Name = "tbF5";
            this.tbF5.Size = new System.Drawing.Size(57, 20);
            this.tbF5.TabIndex = 15;
            // 
            // tbF4
            // 
            this.tbF4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF4.Location = new System.Drawing.Point(15, 90);
            this.tbF4.Name = "tbF4";
            this.tbF4.Size = new System.Drawing.Size(57, 20);
            this.tbF4.TabIndex = 14;
            // 
            // tbF3
            // 
            this.tbF3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF3.Location = new System.Drawing.Point(15, 66);
            this.tbF3.Name = "tbF3";
            this.tbF3.Size = new System.Drawing.Size(57, 20);
            this.tbF3.TabIndex = 13;
            // 
            // tbF2
            // 
            this.tbF2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF2.Location = new System.Drawing.Point(15, 42);
            this.tbF2.Name = "tbF2";
            this.tbF2.Size = new System.Drawing.Size(57, 20);
            this.tbF2.TabIndex = 12;
            // 
            // tbF1
            // 
            this.tbF1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbF1.Location = new System.Drawing.Point(15, 18);
            this.tbF1.Name = "tbF1";
            this.tbF1.Size = new System.Drawing.Size(57, 20);
            this.tbF1.TabIndex = 1;
            // 
            // btn_EXECUTE_CMDS
            // 
            this.btn_EXECUTE_CMDS.Location = new System.Drawing.Point(133, 319);
            this.btn_EXECUTE_CMDS.Name = "btn_EXECUTE_CMDS";
            this.btn_EXECUTE_CMDS.Size = new System.Drawing.Size(73, 37);
            this.btn_EXECUTE_CMDS.TabIndex = 43;
            this.btn_EXECUTE_CMDS.Text = "EXECUTE CMDS";
            this.btn_EXECUTE_CMDS.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 367);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "SITE SETTINGS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.10744F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.89256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.chk_Eday_MWO, 5, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_MWO_SFLUSH, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_MWO_MFLUSH, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_MWO_COM, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.txt_MWO_TIME, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_MBO, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_WGC, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_WKT, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_WBI, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_SCT, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayWKT, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayWBI, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdaySCT, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayLEF, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayBAO, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayWGC, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.label42, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label41, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label35, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_WGC_Sflush, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_WKT_Sflush, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_WBI_Sflush, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_SCT_Sflush, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEF_Sflush, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_BAO_Sflush, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_WGC_Mflush, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_WKT_Mflush, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_WBI_Mflush, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_SCT_Mflush, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEF_Mflush, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_BAO_Mflush, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_AMT_Mflush, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label32, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label31, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_WGC_COM, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_WBI_COM, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_SCT_COM, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEF_COM, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_BAO_COM, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_AMT_COM, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label29, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_WGC_time, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_WKT_time, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_WBI_time, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_SCT_time, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEF_time, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_BAO_time, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_AMT_time, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label30, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_AMT_Sflush, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label37, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label40, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEW_time, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEW_COM, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEW_Mflush, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.txt_LEW_Sflush, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label27, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayAMT, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayMBO, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.chk_EdayLEW, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_AMT, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_BAO, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_LEW, 6, 12);
            this.tableLayoutPanel1.Controls.Add(this.label36, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIGS_LEF, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_WKT_COM, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.chk_COMTRIG_MWO, 6, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 347);
            this.tableLayoutPanel1.TabIndex = 62;
            // 
            // chk_Eday_MWO
            // 
            this.chk_Eday_MWO.AutoSize = true;
            this.chk_Eday_MWO.Checked = true;
            this.chk_Eday_MWO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Eday_MWO.Location = new System.Drawing.Point(217, 247);
            this.chk_Eday_MWO.Name = "chk_Eday_MWO";
            this.chk_Eday_MWO.Size = new System.Drawing.Size(33, 16);
            this.chk_Eday_MWO.TabIndex = 88;
            this.chk_Eday_MWO.Text = "E";
            this.chk_Eday_MWO.UseVisualStyleBackColor = true;
            // 
            // txt_MWO_SFLUSH
            // 
            this.txt_MWO_SFLUSH.Location = new System.Drawing.Point(178, 247);
            this.txt_MWO_SFLUSH.Name = "txt_MWO_SFLUSH";
            this.txt_MWO_SFLUSH.Size = new System.Drawing.Size(33, 20);
            this.txt_MWO_SFLUSH.TabIndex = 87;
            this.txt_MWO_SFLUSH.Text = "10";
            // 
            // txt_MWO_MFLUSH
            // 
            this.txt_MWO_MFLUSH.Location = new System.Drawing.Point(137, 247);
            this.txt_MWO_MFLUSH.Name = "txt_MWO_MFLUSH";
            this.txt_MWO_MFLUSH.Size = new System.Drawing.Size(35, 20);
            this.txt_MWO_MFLUSH.TabIndex = 88;
            this.txt_MWO_MFLUSH.Text = "25";
            // 
            // txt_MWO_COM
            // 
            this.txt_MWO_COM.Location = new System.Drawing.Point(90, 247);
            this.txt_MWO_COM.Name = "txt_MWO_COM";
            this.txt_MWO_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_MWO_COM.TabIndex = 89;
            this.txt_MWO_COM.Text = "COM4";
            // 
            // txt_MWO_TIME
            // 
            this.txt_MWO_TIME.Location = new System.Drawing.Point(44, 247);
            this.txt_MWO_TIME.Name = "txt_MWO_TIME";
            this.txt_MWO_TIME.Size = new System.Drawing.Size(40, 20);
            this.txt_MWO_TIME.TabIndex = 90;
            this.txt_MWO_TIME.Text = "10:00:00";
            // 
            // chk_COMTRIGS_MBO
            // 
            this.chk_COMTRIGS_MBO.AutoSize = true;
            this.chk_COMTRIGS_MBO.Location = new System.Drawing.Point(265, 220);
            this.chk_COMTRIGS_MBO.Name = "chk_COMTRIGS_MBO";
            this.chk_COMTRIGS_MBO.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_MBO.TabIndex = 134;
            this.chk_COMTRIGS_MBO.Text = "C";
            this.chk_COMTRIGS_MBO.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_WGC
            // 
            this.chk_COMTRIGS_WGC.AutoSize = true;
            this.chk_COMTRIGS_WGC.Location = new System.Drawing.Point(265, 191);
            this.chk_COMTRIGS_WGC.Name = "chk_COMTRIGS_WGC";
            this.chk_COMTRIGS_WGC.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_WGC.TabIndex = 130;
            this.chk_COMTRIGS_WGC.Text = "C";
            this.chk_COMTRIGS_WGC.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_WKT
            // 
            this.chk_COMTRIGS_WKT.AutoSize = true;
            this.chk_COMTRIGS_WKT.Location = new System.Drawing.Point(265, 163);
            this.chk_COMTRIGS_WKT.Name = "chk_COMTRIGS_WKT";
            this.chk_COMTRIGS_WKT.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_WKT.TabIndex = 129;
            this.chk_COMTRIGS_WKT.Text = "C";
            this.chk_COMTRIGS_WKT.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_WBI
            // 
            this.chk_COMTRIGS_WBI.AutoSize = true;
            this.chk_COMTRIGS_WBI.Location = new System.Drawing.Point(265, 136);
            this.chk_COMTRIGS_WBI.Name = "chk_COMTRIGS_WBI";
            this.chk_COMTRIGS_WBI.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_WBI.TabIndex = 128;
            this.chk_COMTRIGS_WBI.Text = "C";
            this.chk_COMTRIGS_WBI.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_SCT
            // 
            this.chk_COMTRIGS_SCT.AutoSize = true;
            this.chk_COMTRIGS_SCT.Location = new System.Drawing.Point(265, 110);
            this.chk_COMTRIGS_SCT.Name = "chk_COMTRIGS_SCT";
            this.chk_COMTRIGS_SCT.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_SCT.TabIndex = 127;
            this.chk_COMTRIGS_SCT.Text = "C";
            this.chk_COMTRIGS_SCT.UseVisualStyleBackColor = true;
            // 
            // chk_EdayWKT
            // 
            this.chk_EdayWKT.AutoSize = true;
            this.chk_EdayWKT.Location = new System.Drawing.Point(217, 163);
            this.chk_EdayWKT.Name = "chk_EdayWKT";
            this.chk_EdayWKT.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayWKT.TabIndex = 126;
            this.chk_EdayWKT.Text = "E";
            this.chk_EdayWKT.UseVisualStyleBackColor = true;
            // 
            // chk_EdayWBI
            // 
            this.chk_EdayWBI.AutoSize = true;
            this.chk_EdayWBI.Checked = true;
            this.chk_EdayWBI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_EdayWBI.Location = new System.Drawing.Point(217, 136);
            this.chk_EdayWBI.Name = "chk_EdayWBI";
            this.chk_EdayWBI.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayWBI.TabIndex = 124;
            this.chk_EdayWBI.Text = "E";
            this.chk_EdayWBI.UseVisualStyleBackColor = true;
            // 
            // chk_EdaySCT
            // 
            this.chk_EdaySCT.AutoSize = true;
            this.chk_EdaySCT.Location = new System.Drawing.Point(217, 110);
            this.chk_EdaySCT.Name = "chk_EdaySCT";
            this.chk_EdaySCT.Size = new System.Drawing.Size(33, 17);
            this.chk_EdaySCT.TabIndex = 122;
            this.chk_EdaySCT.Text = "E";
            this.chk_EdaySCT.UseVisualStyleBackColor = true;
            // 
            // chk_EdayLEF
            // 
            this.chk_EdayLEF.AutoSize = true;
            this.chk_EdayLEF.Location = new System.Drawing.Point(217, 83);
            this.chk_EdayLEF.Name = "chk_EdayLEF";
            this.chk_EdayLEF.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayLEF.TabIndex = 120;
            this.chk_EdayLEF.Text = "E";
            this.chk_EdayLEF.UseVisualStyleBackColor = true;
            // 
            // chk_EdayBAO
            // 
            this.chk_EdayBAO.AutoSize = true;
            this.chk_EdayBAO.Checked = true;
            this.chk_EdayBAO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_EdayBAO.Location = new System.Drawing.Point(217, 56);
            this.chk_EdayBAO.Name = "chk_EdayBAO";
            this.chk_EdayBAO.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayBAO.TabIndex = 118;
            this.chk_EdayBAO.Text = "E";
            this.chk_EdayBAO.UseVisualStyleBackColor = true;
            // 
            // chk_EdayWGC
            // 
            this.chk_EdayWGC.AutoSize = true;
            this.chk_EdayWGC.Location = new System.Drawing.Point(217, 191);
            this.chk_EdayWGC.Name = "chk_EdayWGC";
            this.chk_EdayWGC.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayWGC.TabIndex = 79;
            this.chk_EdayWGC.Text = "E";
            this.chk_EdayWGC.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(217, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(39, 26);
            this.label42.TabIndex = 92;
            this.label42.Text = "Eday/EOday";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 323);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(31, 13);
            this.label41.TabIndex = 111;
            this.label41.Text = "LEW";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 217);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(31, 13);
            this.label35.TabIndex = 106;
            this.label35.Text = "MBO";
            // 
            // txt_WGC_Sflush
            // 
            this.txt_WGC_Sflush.Location = new System.Drawing.Point(178, 191);
            this.txt_WGC_Sflush.Name = "txt_WGC_Sflush";
            this.txt_WGC_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_WGC_Sflush.TabIndex = 94;
            this.txt_WGC_Sflush.Text = "10";
            // 
            // txt_WKT_Sflush
            // 
            this.txt_WKT_Sflush.Location = new System.Drawing.Point(178, 163);
            this.txt_WKT_Sflush.Name = "txt_WKT_Sflush";
            this.txt_WKT_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_WKT_Sflush.TabIndex = 95;
            this.txt_WKT_Sflush.Text = "70";
            // 
            // txt_WBI_Sflush
            // 
            this.txt_WBI_Sflush.Location = new System.Drawing.Point(178, 136);
            this.txt_WBI_Sflush.Name = "txt_WBI_Sflush";
            this.txt_WBI_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_WBI_Sflush.TabIndex = 96;
            this.txt_WBI_Sflush.Text = "70";
            // 
            // txt_SCT_Sflush
            // 
            this.txt_SCT_Sflush.Location = new System.Drawing.Point(178, 110);
            this.txt_SCT_Sflush.Name = "txt_SCT_Sflush";
            this.txt_SCT_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_SCT_Sflush.TabIndex = 97;
            this.txt_SCT_Sflush.Text = "70";
            // 
            // txt_LEF_Sflush
            // 
            this.txt_LEF_Sflush.Location = new System.Drawing.Point(178, 83);
            this.txt_LEF_Sflush.Name = "txt_LEF_Sflush";
            this.txt_LEF_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_LEF_Sflush.TabIndex = 98;
            this.txt_LEF_Sflush.Text = "70";
            // 
            // txt_BAO_Sflush
            // 
            this.txt_BAO_Sflush.Location = new System.Drawing.Point(178, 56);
            this.txt_BAO_Sflush.Name = "txt_BAO_Sflush";
            this.txt_BAO_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_BAO_Sflush.TabIndex = 99;
            this.txt_BAO_Sflush.Text = "70";
            // 
            // txt_WGC_Mflush
            // 
            this.txt_WGC_Mflush.Location = new System.Drawing.Point(137, 191);
            this.txt_WGC_Mflush.Name = "txt_WGC_Mflush";
            this.txt_WGC_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_WGC_Mflush.TabIndex = 100;
            this.txt_WGC_Mflush.Text = "25";
            // 
            // txt_WKT_Mflush
            // 
            this.txt_WKT_Mflush.Location = new System.Drawing.Point(137, 163);
            this.txt_WKT_Mflush.Name = "txt_WKT_Mflush";
            this.txt_WKT_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_WKT_Mflush.TabIndex = 101;
            this.txt_WKT_Mflush.Text = "80";
            // 
            // txt_WBI_Mflush
            // 
            this.txt_WBI_Mflush.Location = new System.Drawing.Point(137, 136);
            this.txt_WBI_Mflush.Name = "txt_WBI_Mflush";
            this.txt_WBI_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_WBI_Mflush.TabIndex = 102;
            this.txt_WBI_Mflush.Text = "80";
            // 
            // txt_SCT_Mflush
            // 
            this.txt_SCT_Mflush.Location = new System.Drawing.Point(137, 110);
            this.txt_SCT_Mflush.Name = "txt_SCT_Mflush";
            this.txt_SCT_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_SCT_Mflush.TabIndex = 103;
            this.txt_SCT_Mflush.Text = "80";
            // 
            // txt_LEF_Mflush
            // 
            this.txt_LEF_Mflush.Location = new System.Drawing.Point(137, 83);
            this.txt_LEF_Mflush.Name = "txt_LEF_Mflush";
            this.txt_LEF_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_LEF_Mflush.TabIndex = 104;
            this.txt_LEF_Mflush.Text = "80";
            // 
            // txt_BAO_Mflush
            // 
            this.txt_BAO_Mflush.Location = new System.Drawing.Point(137, 56);
            this.txt_BAO_Mflush.Name = "txt_BAO_Mflush";
            this.txt_BAO_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_BAO_Mflush.TabIndex = 105;
            this.txt_BAO_Mflush.Text = "80";
            // 
            // txt_AMT_Mflush
            // 
            this.txt_AMT_Mflush.Location = new System.Drawing.Point(137, 30);
            this.txt_AMT_Mflush.Name = "txt_AMT_Mflush";
            this.txt_AMT_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_AMT_Mflush.TabIndex = 93;
            this.txt_AMT_Mflush.Text = "80";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(178, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 26);
            this.label32.TabIndex = 92;
            this.label32.Text = "S flush";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(137, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 26);
            this.label31.TabIndex = 91;
            this.label31.Text = "M flush";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(44, 220);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(33, 20);
            this.textBox10.TabIndex = 90;
            this.textBox10.Text = "1";
            // 
            // txt_WGC_COM
            // 
            this.txt_WGC_COM.Location = new System.Drawing.Point(90, 191);
            this.txt_WGC_COM.Name = "txt_WGC_COM";
            this.txt_WGC_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_WGC_COM.TabIndex = 88;
            this.txt_WGC_COM.Text = "COM9";
            // 
            // txt_WBI_COM
            // 
            this.txt_WBI_COM.Location = new System.Drawing.Point(90, 136);
            this.txt_WBI_COM.Name = "txt_WBI_COM";
            this.txt_WBI_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_WBI_COM.TabIndex = 86;
            this.txt_WBI_COM.Text = "COM9";
            // 
            // txt_SCT_COM
            // 
            this.txt_SCT_COM.Location = new System.Drawing.Point(90, 110);
            this.txt_SCT_COM.Name = "txt_SCT_COM";
            this.txt_SCT_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_SCT_COM.TabIndex = 85;
            this.txt_SCT_COM.Text = "COM7";
            // 
            // txt_LEF_COM
            // 
            this.txt_LEF_COM.Location = new System.Drawing.Point(90, 83);
            this.txt_LEF_COM.Name = "txt_LEF_COM";
            this.txt_LEF_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_LEF_COM.TabIndex = 84;
            this.txt_LEF_COM.Text = "COM14";
            // 
            // txt_BAO_COM
            // 
            this.txt_BAO_COM.Location = new System.Drawing.Point(90, 56);
            this.txt_BAO_COM.Name = "txt_BAO_COM";
            this.txt_BAO_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_BAO_COM.TabIndex = 83;
            this.txt_BAO_COM.Text = "COM10";
            // 
            // txt_AMT_COM
            // 
            this.txt_AMT_COM.Location = new System.Drawing.Point(90, 30);
            this.txt_AMT_COM.Name = "txt_AMT_COM";
            this.txt_AMT_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_AMT_COM.TabIndex = 66;
            this.txt_AMT_COM.Text = "COM5";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(44, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 27);
            this.label29.TabIndex = 81;
            this.label29.Text = "SAMPLE TIME";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 13);
            this.label28.TabIndex = 63;
            this.label28.Text = "SITE";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 188);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 79;
            this.label26.Text = "WGC";
            // 
            // txt_WGC_time
            // 
            this.txt_WGC_time.Location = new System.Drawing.Point(44, 191);
            this.txt_WGC_time.Name = "txt_WGC_time";
            this.txt_WGC_time.Size = new System.Drawing.Size(40, 20);
            this.txt_WGC_time.TabIndex = 72;
            this.txt_WGC_time.Text = "22:00:00";
            // 
            // txt_WKT_time
            // 
            this.txt_WKT_time.Location = new System.Drawing.Point(44, 163);
            this.txt_WKT_time.Name = "txt_WKT_time";
            this.txt_WKT_time.Size = new System.Drawing.Size(40, 20);
            this.txt_WKT_time.TabIndex = 71;
            this.txt_WKT_time.Text = "20:25:00";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 78;
            this.label25.Text = "WKT";
            // 
            // txt_WBI_time
            // 
            this.txt_WBI_time.Location = new System.Drawing.Point(44, 136);
            this.txt_WBI_time.Name = "txt_WBI_time";
            this.txt_WBI_time.Size = new System.Drawing.Size(40, 20);
            this.txt_WBI_time.TabIndex = 70;
            this.txt_WBI_time.Text = "20:25:00";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 77;
            this.label24.Text = "WBI";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 107);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 76;
            this.label23.Text = "SCT";
            // 
            // txt_SCT_time
            // 
            this.txt_SCT_time.Location = new System.Drawing.Point(44, 110);
            this.txt_SCT_time.Name = "txt_SCT_time";
            this.txt_SCT_time.Size = new System.Drawing.Size(40, 20);
            this.txt_SCT_time.TabIndex = 69;
            this.txt_SCT_time.Text = "19:15:00";
            // 
            // txt_LEF_time
            // 
            this.txt_LEF_time.Location = new System.Drawing.Point(44, 83);
            this.txt_LEF_time.Name = "txt_LEF_time";
            this.txt_LEF_time.Size = new System.Drawing.Size(40, 20);
            this.txt_LEF_time.TabIndex = 68;
            this.txt_LEF_time.Text = "20:25:00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 75;
            this.label22.Text = "LEF";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "BAO";
            // 
            // txt_BAO_time
            // 
            this.txt_BAO_time.Location = new System.Drawing.Point(44, 56);
            this.txt_BAO_time.Name = "txt_BAO_time";
            this.txt_BAO_time.Size = new System.Drawing.Size(40, 20);
            this.txt_BAO_time.TabIndex = 67;
            this.txt_BAO_time.Text = "21:00:00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "AMT";
            // 
            // txt_AMT_time
            // 
            this.txt_AMT_time.Location = new System.Drawing.Point(44, 30);
            this.txt_AMT_time.Name = "txt_AMT_time";
            this.txt_AMT_time.Size = new System.Drawing.Size(40, 20);
            this.txt_AMT_time.TabIndex = 66;
            this.txt_AMT_time.Text = "19:15:00";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(90, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 26);
            this.label30.TabIndex = 82;
            this.label30.Text = "COM NAME";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(90, 220);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 20);
            this.textBox9.TabIndex = 89;
            this.textBox9.Text = "COM14";
            // 
            // txt_AMT_Sflush
            // 
            this.txt_AMT_Sflush.Location = new System.Drawing.Point(178, 30);
            this.txt_AMT_Sflush.Name = "txt_AMT_Sflush";
            this.txt_AMT_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_AMT_Sflush.TabIndex = 94;
            this.txt_AMT_Sflush.Text = "70";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 244);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 13);
            this.label37.TabIndex = 108;
            this.label37.Text = "MWO";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 266);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 13);
            this.label40.TabIndex = 109;
            this.label40.Text = "STR";
            // 
            // txt_LEW_time
            // 
            this.txt_LEW_time.Location = new System.Drawing.Point(44, 326);
            this.txt_LEW_time.Name = "txt_LEW_time";
            this.txt_LEW_time.Size = new System.Drawing.Size(40, 20);
            this.txt_LEW_time.TabIndex = 112;
            this.txt_LEW_time.Text = "22:00:00";
            // 
            // txt_LEW_COM
            // 
            this.txt_LEW_COM.Location = new System.Drawing.Point(90, 326);
            this.txt_LEW_COM.Name = "txt_LEW_COM";
            this.txt_LEW_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_LEW_COM.TabIndex = 113;
            this.txt_LEW_COM.Text = "COM14";
            // 
            // txt_LEW_Mflush
            // 
            this.txt_LEW_Mflush.Location = new System.Drawing.Point(137, 326);
            this.txt_LEW_Mflush.Name = "txt_LEW_Mflush";
            this.txt_LEW_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_LEW_Mflush.TabIndex = 115;
            this.txt_LEW_Mflush.Text = "80";
            // 
            // txt_LEW_Sflush
            // 
            this.txt_LEW_Sflush.Location = new System.Drawing.Point(178, 326);
            this.txt_LEW_Sflush.Name = "txt_LEW_Sflush";
            this.txt_LEW_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_LEW_Sflush.TabIndex = 114;
            this.txt_LEW_Sflush.Text = "80";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "LAB";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(265, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 116;
            this.label27.Text = "ComTrigger";
            // 
            // chk_EdayAMT
            // 
            this.chk_EdayAMT.AutoSize = true;
            this.chk_EdayAMT.Location = new System.Drawing.Point(217, 30);
            this.chk_EdayAMT.Name = "chk_EdayAMT";
            this.chk_EdayAMT.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayAMT.TabIndex = 117;
            this.chk_EdayAMT.Text = "E";
            this.chk_EdayAMT.UseVisualStyleBackColor = true;
            // 
            // chk_EdayMBO
            // 
            this.chk_EdayMBO.AutoSize = true;
            this.chk_EdayMBO.Location = new System.Drawing.Point(217, 220);
            this.chk_EdayMBO.Name = "chk_EdayMBO";
            this.chk_EdayMBO.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayMBO.TabIndex = 119;
            this.chk_EdayMBO.Text = "E";
            this.chk_EdayMBO.UseVisualStyleBackColor = true;
            // 
            // chk_EdayLEW
            // 
            this.chk_EdayLEW.AutoSize = true;
            this.chk_EdayLEW.Location = new System.Drawing.Point(217, 326);
            this.chk_EdayLEW.Name = "chk_EdayLEW";
            this.chk_EdayLEW.Size = new System.Drawing.Size(33, 17);
            this.chk_EdayLEW.TabIndex = 125;
            this.chk_EdayLEW.Text = "E";
            this.chk_EdayLEW.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_AMT
            // 
            this.chk_COMTRIGS_AMT.AutoSize = true;
            this.chk_COMTRIGS_AMT.Location = new System.Drawing.Point(265, 30);
            this.chk_COMTRIGS_AMT.Name = "chk_COMTRIGS_AMT";
            this.chk_COMTRIGS_AMT.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_AMT.TabIndex = 121;
            this.chk_COMTRIGS_AMT.Text = "C";
            this.chk_COMTRIGS_AMT.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_BAO
            // 
            this.chk_COMTRIGS_BAO.AutoSize = true;
            this.chk_COMTRIGS_BAO.Location = new System.Drawing.Point(265, 56);
            this.chk_COMTRIGS_BAO.Name = "chk_COMTRIGS_BAO";
            this.chk_COMTRIGS_BAO.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_BAO.TabIndex = 123;
            this.chk_COMTRIGS_BAO.Text = "C";
            this.chk_COMTRIGS_BAO.UseVisualStyleBackColor = true;
            // 
            // chk_COMTRIGS_LEW
            // 
            this.chk_COMTRIGS_LEW.AutoSize = true;
            this.chk_COMTRIGS_LEW.Checked = true;
            this.chk_COMTRIGS_LEW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_COMTRIGS_LEW.Location = new System.Drawing.Point(265, 326);
            this.chk_COMTRIGS_LEW.Name = "chk_COMTRIGS_LEW";
            this.chk_COMTRIGS_LEW.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_LEW.TabIndex = 131;
            this.chk_COMTRIGS_LEW.Text = "C";
            this.chk_COMTRIGS_LEW.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(137, 217);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 13);
            this.label36.TabIndex = 107;
            // 
            // chk_COMTRIGS_LEF
            // 
            this.chk_COMTRIGS_LEF.AutoSize = true;
            this.chk_COMTRIGS_LEF.Location = new System.Drawing.Point(265, 83);
            this.chk_COMTRIGS_LEF.Name = "chk_COMTRIGS_LEF";
            this.chk_COMTRIGS_LEF.Size = new System.Drawing.Size(33, 17);
            this.chk_COMTRIGS_LEF.TabIndex = 133;
            this.chk_COMTRIGS_LEF.Text = "C";
            this.chk_COMTRIGS_LEF.UseVisualStyleBackColor = true;
            // 
            // txt_WKT_COM
            // 
            this.txt_WKT_COM.Location = new System.Drawing.Point(90, 163);
            this.txt_WKT_COM.Name = "txt_WKT_COM";
            this.txt_WKT_COM.Size = new System.Drawing.Size(41, 20);
            this.txt_WKT_COM.TabIndex = 87;
            this.txt_WKT_COM.Text = "COM7";
            // 
            // chk_COMTRIG_MWO
            // 
            this.chk_COMTRIG_MWO.AutoSize = true;
            this.chk_COMTRIG_MWO.Checked = true;
            this.chk_COMTRIG_MWO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_COMTRIG_MWO.Location = new System.Drawing.Point(265, 247);
            this.chk_COMTRIG_MWO.Name = "chk_COMTRIG_MWO";
            this.chk_COMTRIG_MWO.Size = new System.Drawing.Size(33, 16);
            this.chk_COMTRIG_MWO.TabIndex = 135;
            this.chk_COMTRIG_MWO.Text = "C";
            this.chk_COMTRIG_MWO.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_GET_SAMPLE_PLAN);
            this.tabPage4.Controls.Add(this.btn_GET_NFILL2);
            this.tabPage4.Controls.Add(this.btn_LOAD_SITE_SETTINGS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 367);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "TEST";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_GET_SAMPLE_PLAN
            // 
            this.btn_GET_SAMPLE_PLAN.Location = new System.Drawing.Point(27, 26);
            this.btn_GET_SAMPLE_PLAN.Name = "btn_GET_SAMPLE_PLAN";
            this.btn_GET_SAMPLE_PLAN.Size = new System.Drawing.Size(117, 19);
            this.btn_GET_SAMPLE_PLAN.TabIndex = 62;
            this.btn_GET_SAMPLE_PLAN.Text = "GET SAMPLE PLAN";
            this.btn_GET_SAMPLE_PLAN.UseVisualStyleBackColor = true;
            this.btn_GET_SAMPLE_PLAN.Click += new System.EventHandler(this.btn_GET_SAMPLE_PLAN_Click);
            // 
            // btn_GET_NFILL2
            // 
            this.btn_GET_NFILL2.Location = new System.Drawing.Point(27, 66);
            this.btn_GET_NFILL2.Name = "btn_GET_NFILL2";
            this.btn_GET_NFILL2.Size = new System.Drawing.Size(154, 19);
            this.btn_GET_NFILL2.TabIndex = 48;
            this.btn_GET_NFILL2.Text = "GET NFILL FROM HISTORY";
            this.btn_GET_NFILL2.UseVisualStyleBackColor = true;
            this.btn_GET_NFILL2.Click += new System.EventHandler(this.btn_GET_NFILL2_Click);
            // 
            // btn_LOAD_SITE_SETTINGS
            // 
            this.btn_LOAD_SITE_SETTINGS.Location = new System.Drawing.Point(25, 113);
            this.btn_LOAD_SITE_SETTINGS.Name = "btn_LOAD_SITE_SETTINGS";
            this.btn_LOAD_SITE_SETTINGS.Size = new System.Drawing.Size(140, 19);
            this.btn_LOAD_SITE_SETTINGS.TabIndex = 66;
            this.btn_LOAD_SITE_SETTINGS.Text = "2. LOAD SITE SETTINGS";
            this.btn_LOAD_SITE_SETTINGS.UseVisualStyleBackColor = true;
            this.btn_LOAD_SITE_SETTINGS.Click += new System.EventHandler(this.btn_LOAD_SITE_SETTINGS_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(409, 367);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "MWO_SAMPLE";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(46, 78);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 242);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txt_PREFILLTIME
            // 
            this.txt_PREFILLTIME.Location = new System.Drawing.Point(23, 18);
            this.txt_PREFILLTIME.Name = "txt_PREFILLTIME";
            this.txt_PREFILLTIME.Size = new System.Drawing.Size(55, 20);
            this.txt_PREFILLTIME.TabIndex = 57;
            this.txt_PREFILLTIME.Text = "10:00:00";
            this.txt_PREFILLTIME.TextChanged += new System.EventHandler(this.txt_PREFILLTIME_TextChanged);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // chk_SAVE_TO_FILE
            // 
            this.chk_SAVE_TO_FILE.AutoSize = true;
            this.chk_SAVE_TO_FILE.Checked = true;
            this.chk_SAVE_TO_FILE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SAVE_TO_FILE.Location = new System.Drawing.Point(17, 528);
            this.chk_SAVE_TO_FILE.Name = "chk_SAVE_TO_FILE";
            this.chk_SAVE_TO_FILE.Size = new System.Drawing.Size(131, 17);
            this.chk_SAVE_TO_FILE.TabIndex = 58;
            this.chk_SAVE_TO_FILE.Text = "SAVE COMS TO FILE";
            this.chk_SAVE_TO_FILE.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "1. CHOOSE SITE CODE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "UTC TIME";
            // 
            // chk_SAMPLE_TIME
            // 
            this.chk_SAMPLE_TIME.AutoSize = true;
            this.chk_SAMPLE_TIME.Location = new System.Drawing.Point(84, 18);
            this.chk_SAMPLE_TIME.Name = "chk_SAMPLE_TIME";
            this.chk_SAMPLE_TIME.Size = new System.Drawing.Size(15, 14);
            this.chk_SAMPLE_TIME.TabIndex = 61;
            this.chk_SAMPLE_TIME.UseVisualStyleBackColor = true;
            // 
            // chk_PREFILLTIME
            // 
            this.chk_PREFILLTIME.AutoSize = true;
            this.chk_PREFILLTIME.Checked = true;
            this.chk_PREFILLTIME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_PREFILLTIME.Location = new System.Drawing.Point(3, 18);
            this.chk_PREFILLTIME.Name = "chk_PREFILLTIME";
            this.chk_PREFILLTIME.Size = new System.Drawing.Size(14, 14);
            this.chk_PREFILLTIME.TabIndex = 62;
            this.chk_PREFILLTIME.UseVisualStyleBackColor = true;
            // 
            // txt_SAMPLE_TIME
            // 
            this.txt_SAMPLE_TIME.Location = new System.Drawing.Point(106, 18);
            this.txt_SAMPLE_TIME.Name = "txt_SAMPLE_TIME";
            this.txt_SAMPLE_TIME.Size = new System.Drawing.Size(67, 20);
            this.txt_SAMPLE_TIME.TabIndex = 62;
            this.txt_SAMPLE_TIME.Text = "11:00:00";
            // 
            // lbl_COM_PORT_OPEN
            // 
            this.lbl_COM_PORT_OPEN.AutoSize = true;
            this.lbl_COM_PORT_OPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_COM_PORT_OPEN.ForeColor = System.Drawing.Color.Red;
            this.lbl_COM_PORT_OPEN.Location = new System.Drawing.Point(296, 56);
            this.lbl_COM_PORT_OPEN.Name = "lbl_COM_PORT_OPEN";
            this.lbl_COM_PORT_OPEN.Size = new System.Drawing.Size(71, 13);
            this.lbl_COM_PORT_OPEN.TabIndex = 60;
            this.lbl_COM_PORT_OPEN.Text = "NOT OPEN";
            // 
            // btn_QUIT_TO_MAIN
            // 
            this.btn_QUIT_TO_MAIN.Location = new System.Drawing.Point(165, 78);
            this.btn_QUIT_TO_MAIN.Name = "btn_QUIT_TO_MAIN";
            this.btn_QUIT_TO_MAIN.Size = new System.Drawing.Size(125, 19);
            this.btn_QUIT_TO_MAIN.TabIndex = 60;
            this.btn_QUIT_TO_MAIN.Text = "QUIT TO MAIN MENU";
            this.btn_QUIT_TO_MAIN.UseVisualStyleBackColor = true;
            this.btn_QUIT_TO_MAIN.Click += new System.EventHandler(this.btn_QUIT_TO_MAIN_Click);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btn_END_LOGGING
            // 
            this.btn_END_LOGGING.Location = new System.Drawing.Point(303, 5);
            this.btn_END_LOGGING.Name = "btn_END_LOGGING";
            this.btn_END_LOGGING.Size = new System.Drawing.Size(116, 19);
            this.btn_END_LOGGING.TabIndex = 67;
            this.btn_END_LOGGING.Text = "3. STOP LOGGING";
            this.btn_END_LOGGING.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_END_LOGGING.UseVisualStyleBackColor = true;
            this.btn_END_LOGGING.Click += new System.EventHandler(this.btn_END_LOGGING_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(171, 60);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 13);
            this.label53.TabIndex = 69;
            this.label53.Text = "COM PORT:";
            // 
            // btn_GETPFPNUMBER
            // 
            this.btn_GETPFPNUMBER.Location = new System.Drawing.Point(425, 5);
            this.btn_GETPFPNUMBER.Name = "btn_GETPFPNUMBER";
            this.btn_GETPFPNUMBER.Size = new System.Drawing.Size(125, 19);
            this.btn_GETPFPNUMBER.TabIndex = 70;
            this.btn_GETPFPNUMBER.Text = "4. GET PFP NUMBER";
            this.btn_GETPFPNUMBER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GETPFPNUMBER.UseVisualStyleBackColor = true;
            this.btn_GETPFPNUMBER.Click += new System.EventHandler(this.btn_GETPFPNUMBER_Click);
            // 
            // rbtn_EVERYDAY
            // 
            this.rbtn_EVERYDAY.AutoSize = true;
            this.rbtn_EVERYDAY.Location = new System.Drawing.Point(11, 3);
            this.rbtn_EVERYDAY.Name = "rbtn_EVERYDAY";
            this.rbtn_EVERYDAY.Size = new System.Drawing.Size(86, 17);
            this.rbtn_EVERYDAY.TabIndex = 72;
            this.rbtn_EVERYDAY.TabStop = true;
            this.rbtn_EVERYDAY.Text = "EVERY DAY";
            this.rbtn_EVERYDAY.UseVisualStyleBackColor = true;
            // 
            // rbtn_EVERYOTHERDAY
            // 
            this.rbtn_EVERYOTHERDAY.AutoSize = true;
            this.rbtn_EVERYOTHERDAY.Location = new System.Drawing.Point(11, 23);
            this.rbtn_EVERYOTHERDAY.Name = "rbtn_EVERYOTHERDAY";
            this.rbtn_EVERYOTHERDAY.Size = new System.Drawing.Size(102, 17);
            this.rbtn_EVERYOTHERDAY.TabIndex = 73;
            this.rbtn_EVERYOTHERDAY.TabStop = true;
            this.rbtn_EVERYOTHERDAY.Text = "EVERY OTHER";
            this.rbtn_EVERYOTHERDAY.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_EVERYDAY);
            this.panel1.Controls.Add(this.rbtn_EVERYOTHERDAY);
            this.panel1.Location = new System.Drawing.Point(733, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 47);
            this.panel1.TabIndex = 74;
            // 
            // chk_LASTSAMPLE
            // 
            this.chk_LASTSAMPLE.AutoSize = true;
            this.chk_LASTSAMPLE.Location = new System.Drawing.Point(609, 571);
            this.chk_LASTSAMPLE.Name = "chk_LASTSAMPLE";
            this.chk_LASTSAMPLE.Size = new System.Drawing.Size(99, 17);
            this.chk_LASTSAMPLE.TabIndex = 75;
            this.chk_LASTSAMPLE.Text = "LAST SAMPLE";
            this.chk_LASTSAMPLE.UseVisualStyleBackColor = true;
            // 
            // lbl_PFPNUMBER
            // 
            this.lbl_PFPNUMBER.AutoSize = true;
            this.lbl_PFPNUMBER.Location = new System.Drawing.Point(556, 8);
            this.lbl_PFPNUMBER.Name = "lbl_PFPNUMBER";
            this.lbl_PFPNUMBER.Size = new System.Drawing.Size(51, 13);
            this.lbl_PFPNUMBER.TabIndex = 76;
            this.lbl_PFPNUMBER.Text = "FP-XXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "DOY:";
            // 
            // lbl_DOY
            // 
            this.lbl_DOY.AutoSize = true;
            this.lbl_DOY.Location = new System.Drawing.Point(468, 538);
            this.lbl_DOY.Name = "lbl_DOY";
            this.lbl_DOY.Size = new System.Drawing.Size(30, 13);
            this.lbl_DOY.TabIndex = 78;
            this.lbl_DOY.Text = "DOY";
            // 
            // cbo_SITE_CODE
            // 
            this.cbo_SITE_CODE.FormattingEnabled = true;
            this.cbo_SITE_CODE.Items.AddRange(new object[] {
            "AMT",
            "BAO",
            "LEF",
            "MWO",
            "SCT",
            "STR",
            "WBI",
            "WGC",
            "WKT",
            "",
            "",
            ""});
            this.cbo_SITE_CODE.Location = new System.Drawing.Point(138, 5);
            this.cbo_SITE_CODE.Name = "cbo_SITE_CODE";
            this.cbo_SITE_CODE.Size = new System.Drawing.Size(66, 21);
            this.cbo_SITE_CODE.TabIndex = 79;
            this.cbo_SITE_CODE.SelectedIndexChanged += new System.EventHandler(this.cbo_SITE_CODE_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_SYSTEMTEST);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.cbo_SITE_CODE);
            this.panel2.Controls.Add(this.btnOpenCom);
            this.panel2.Controls.Add(this.lbl_PFPNUMBER);
            this.panel2.Controls.Add(this.btn_END_LOGGING);
            this.panel2.Controls.Add(this.btn_GETPFPNUMBER);
            this.panel2.Location = new System.Drawing.Point(73, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 35);
            this.panel2.TabIndex = 80;
            // 
            // btn_SYSTEMTEST
            // 
            this.btn_SYSTEMTEST.Location = new System.Drawing.Point(615, 7);
            this.btn_SYSTEMTEST.Name = "btn_SYSTEMTEST";
            this.btn_SYSTEMTEST.Size = new System.Drawing.Size(125, 19);
            this.btn_SYSTEMTEST.TabIndex = 81;
            this.btn_SYSTEMTEST.Text = "5. SYSTEM TEST";
            this.btn_SYSTEMTEST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SYSTEMTEST.UseVisualStyleBackColor = true;
            this.btn_SYSTEMTEST.Click += new System.EventHandler(this.btn_SYSTEMTEST_Click);
            // 
            // txt_PREFILLTIME2
            // 
            this.txt_PREFILLTIME2.Location = new System.Drawing.Point(23, 46);
            this.txt_PREFILLTIME2.Name = "txt_PREFILLTIME2";
            this.txt_PREFILLTIME2.Size = new System.Drawing.Size(55, 20);
            this.txt_PREFILLTIME2.TabIndex = 81;
            this.txt_PREFILLTIME2.Text = "22:00:00";
            // 
            // txt_SAMPLETIME2
            // 
            this.txt_SAMPLETIME2.Location = new System.Drawing.Point(106, 46);
            this.txt_SAMPLETIME2.Name = "txt_SAMPLETIME2";
            this.txt_SAMPLETIME2.Size = new System.Drawing.Size(67, 20);
            this.txt_SAMPLETIME2.TabIndex = 82;
            this.txt_SAMPLETIME2.Text = "23:00:00";
            // 
            // chk_SAMPLETIME2
            // 
            this.chk_SAMPLETIME2.AutoSize = true;
            this.chk_SAMPLETIME2.Location = new System.Drawing.Point(84, 46);
            this.chk_SAMPLETIME2.Name = "chk_SAMPLETIME2";
            this.chk_SAMPLETIME2.Size = new System.Drawing.Size(15, 14);
            this.chk_SAMPLETIME2.TabIndex = 83;
            this.chk_SAMPLETIME2.UseVisualStyleBackColor = true;
            // 
            // chk_PREFILLTIME2
            // 
            this.chk_PREFILLTIME2.AutoSize = true;
            this.chk_PREFILLTIME2.Checked = true;
            this.chk_PREFILLTIME2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_PREFILLTIME2.Location = new System.Drawing.Point(3, 46);
            this.chk_PREFILLTIME2.Name = "chk_PREFILLTIME2";
            this.chk_PREFILLTIME2.Size = new System.Drawing.Size(14, 14);
            this.chk_PREFILLTIME2.TabIndex = 84;
            this.chk_PREFILLTIME2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.24272F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.75728F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.Controls.Add(this.chk_PREFILLTIME, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.chk_SAMPLE_TIME, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_PREFILLTIME, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_SAMPLE_TIME, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_PREFILLTIME2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.txt_SAMPLETIME2, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.chk_PREFILLTIME2, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.chk_SAMPLETIME2, 2, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(521, 501);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.11628F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 64);
            this.tableLayoutPanel5.TabIndex = 85;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Prefill Time";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(106, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 13);
            this.label44.TabIndex = 87;
            this.label44.Text = "Sample Time";
            // 
            // frm_TOWER_PFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 603);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_DOY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_LASTSAMPLE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.txt_COM_NAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_SAVE_TO_FILE);
            this.Controls.Add(this.tb_cmds);
            this.Controls.Add(this.btnCloseCom);
            this.Controls.Add(this.btn_READ_COM);
            this.Controls.Add(this.btn_CLEAR_SCREEN);
            this.Controls.Add(this.lbl_COM_PORT_OPEN);
            this.Controls.Add(this.lbl_UTC_TIME);
            this.Controls.Add(this.btn_QUIT_TO_MAIN);
            this.Controls.Add(this.txt_MONITOR_FREQUENCY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_MONITOR_PFP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendText2PFP);
            this.Controls.Add(this.txt_TXT2PFP);
            this.Controls.Add(this.txt_PFP_TEXT);
            this.Name = "frm_TOWER_PFP";
            this.Text = "Tower PFP Sampler version 7.0";
            this.tb_cmds.ResumeLayout(false);
            this.chk_F5.ResumeLayout(false);
            this.chk_F5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txt_PFP_TEXT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txt_TXT2PFP;
        private System.Windows.Forms.Button btnSendText2PFP;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btnCloseCom;
        private System.Windows.Forms.TextBox txt_COM_NAME;
        private System.Windows.Forms.Button btn_GET_HISTORY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_READ_COM;
        private System.Windows.Forms.Button btn_MANUAL_SAMPLE;
        private System.Windows.Forms.CheckBox chk_MONITOR_PFP;
        private System.Windows.Forms.TextBox txt_MONITOR_FREQUENCY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CLEAR_SCREEN;
        private System.Windows.Forms.Label lbl_UTC_TIME;
        private System.Windows.Forms.TabControl tb_cmds;
        private System.Windows.Forms.TabPage chk_F5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_LIM_4SF_prefill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_LIM_3DMF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_LIM_7MFP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_LIM_6MFT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_LIM_5DSF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_LIM_2MF_prefill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_LIM_1MFT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_LIM_4SF_samplefill;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_LIM_2MF_samplefill;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_GET_NFILL2;
        private System.Windows.Forms.CheckBox chk_F12;
        private System.Windows.Forms.CheckBox chk_F4;
        private System.Windows.Forms.CheckBox chk_F3;
        private System.Windows.Forms.CheckBox chk_F1;
        private System.Windows.Forms.CheckBox chk_F11;
        private System.Windows.Forms.CheckBox chk_F10;
        private System.Windows.Forms.CheckBox chk_F9;
        private System.Windows.Forms.CheckBox chk_F8;
        private System.Windows.Forms.CheckBox chk_F7;
        private System.Windows.Forms.CheckBox chk_F6;
        private System.Windows.Forms.CheckBox chk_F5x;
        private System.Windows.Forms.CheckBox chk_F2;
        private System.Windows.Forms.Button btn_PREFILL_LIMITS;
        private System.Windows.Forms.Button btn_SAMP_FILL_LIMITS;
        private System.Windows.Forms.TextBox txt_PREFILLTIME;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.CheckBox chk_SAVE_TO_FILE;
        private System.Windows.Forms.Label lbl_COM_PORT_OPEN;
        private System.Windows.Forms.Button btn_QUIT_TO_MAIN;
        private System.Windows.Forms.TextBox txt_SAMPLE_TIME;
        private System.Windows.Forms.CheckBox chk_SAMPLE_TIME;
        private System.Windows.Forms.CheckBox chk_PREFILLTIME;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbF12;
        private System.Windows.Forms.TextBox tbF11;
        private System.Windows.Forms.TextBox tbF10;
        private System.Windows.Forms.TextBox tbF9;
        private System.Windows.Forms.TextBox tbF8;
        private System.Windows.Forms.TextBox tbF7;
        private System.Windows.Forms.TextBox tbF6;
        private System.Windows.Forms.TextBox tbF5;
        private System.Windows.Forms.TextBox tbF4;
        private System.Windows.Forms.TextBox tbF3;
        private System.Windows.Forms.TextBox tbF2;
        private System.Windows.Forms.TextBox tbF1;
        private System.Windows.Forms.Button btn_EXECUTE_CMDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_AMT_time;
        private System.Windows.Forms.TextBox txt_BAO_time;
        private System.Windows.Forms.TextBox txt_LEF_time;
        private System.Windows.Forms.TextBox txt_WBI_time;
        private System.Windows.Forms.TextBox txt_WKT_time;
        private System.Windows.Forms.TextBox txt_WGC_time;
        private System.Windows.Forms.TextBox txt_SCT_time;
        private System.Windows.Forms.Button btn_LOAD_SITE_SETTINGS;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txt_WGC_COM;
        private System.Windows.Forms.TextBox txt_WKT_COM;
        private System.Windows.Forms.TextBox txt_WBI_COM;
        private System.Windows.Forms.TextBox txt_SCT_COM;
        private System.Windows.Forms.TextBox txt_LEF_COM;
        private System.Windows.Forms.TextBox txt_BAO_COM;
        private System.Windows.Forms.TextBox txt_AMT_COM;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txt_WGC_Sflush;
        private System.Windows.Forms.TextBox txt_WKT_Sflush;
        private System.Windows.Forms.TextBox txt_WBI_Sflush;
        private System.Windows.Forms.TextBox txt_SCT_Sflush;
        private System.Windows.Forms.TextBox txt_LEF_Sflush;
        private System.Windows.Forms.TextBox txt_BAO_Sflush;
        private System.Windows.Forms.TextBox txt_WGC_Mflush;
        private System.Windows.Forms.TextBox txt_WKT_Mflush;
        private System.Windows.Forms.TextBox txt_WBI_Mflush;
        private System.Windows.Forms.TextBox txt_SCT_Mflush;
        private System.Windows.Forms.TextBox txt_LEF_Mflush;
        private System.Windows.Forms.TextBox txt_BAO_Mflush;
        private System.Windows.Forms.TextBox txt_AMT_Mflush;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_AMT_Sflush;
        private System.Windows.Forms.Button btn_SAMPLE_PLAN;
        private System.Windows.Forms.Button btn_GET_SAMPLE_PLAN;
        private System.Windows.Forms.Button btn_FIND_SAMPLE_ADD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_ALTADD2;
        private System.Windows.Forms.TextBox txt_SAMPADD2;
        private System.Windows.Forms.TextBox txt_ALTADD1;
        private System.Windows.Forms.TextBox txt_SAMPADD1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_WRITE_PLAN;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbl_alt12;
        private System.Windows.Forms.Label lbl_alt11;
        private System.Windows.Forms.Label lbl_alt10;
        private System.Windows.Forms.Label lbl_alt9;
        private System.Windows.Forms.Label lbl_alt8;
        private System.Windows.Forms.Label lbl_alt7;
        private System.Windows.Forms.Label lbl_alt6;
        private System.Windows.Forms.Label lbl_alt5;
        private System.Windows.Forms.Label lbl_alt4;
        private System.Windows.Forms.Label lbl_alt3;
        private System.Windows.Forms.Label lbl_alt2;
        private System.Windows.Forms.Label lbl_alt1;
        private System.Windows.Forms.Label lbl_EXECUTINGSEQUENCE;
        private System.Windows.Forms.Label lbl_PREFILL_COUNT;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_t12;
        private System.Windows.Forms.Label lbl_t11;
        private System.Windows.Forms.Label lbl_t10;
        private System.Windows.Forms.Label lbl_t9;
        private System.Windows.Forms.Label lbl_t8;
        private System.Windows.Forms.Label lbl_t7;
        private System.Windows.Forms.Label lbl_t6;
        private System.Windows.Forms.Label lbl_t5;
        private System.Windows.Forms.Label lbl_t4;
        private System.Windows.Forms.Label lbl_t3;
        private System.Windows.Forms.Label lbl_t2;
        private System.Windows.Forms.Label lbl_t1;
        private System.Windows.Forms.Label lbl_d12;
        private System.Windows.Forms.Label lbl_d11;
        private System.Windows.Forms.Label lbl_d10;
        private System.Windows.Forms.Label lbl_d9;
        private System.Windows.Forms.Label lbl_d8;
        private System.Windows.Forms.Label lbl_d7;
        private System.Windows.Forms.Label lbl_d6;
        private System.Windows.Forms.Label lbl_d5;
        private System.Windows.Forms.Label lbl_d4;
        private System.Windows.Forms.Label lbl_d3;
        private System.Windows.Forms.Label lbl_d2;
        private System.Windows.Forms.Label lbl_d1;
        private System.Windows.Forms.Button btn_END_LOGGING;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lbl_tf12;
        private System.Windows.Forms.Label lbl_tf11;
        private System.Windows.Forms.Label lbl_tf10;
        private System.Windows.Forms.Label lbl_tf9;
        private System.Windows.Forms.Label lbl_tf8;
        private System.Windows.Forms.Label lbl_tf7;
        private System.Windows.Forms.Label lbl_tf6;
        private System.Windows.Forms.Label lbl_tf5;
        private System.Windows.Forms.Label lbl_tf4;
        private System.Windows.Forms.Label lbl_tf3;
        private System.Windows.Forms.Label lbl_tf2;
        private System.Windows.Forms.Label lbl_tf1;
        private System.Windows.Forms.Button btn_GETPFPNUMBER;
        private System.Windows.Forms.RadioButton rbtn_EVERYDAY;
        private System.Windows.Forms.RadioButton rbtn_EVERYOTHERDAY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_LASTSAMPLE;
        private System.Windows.Forms.Label lbl_PFPNUMBER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DOY;
        private System.Windows.Forms.Label lbl_DOY_LASTSAMPLE;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txt_LEW_time;
        private System.Windows.Forms.TextBox txt_LEW_COM;
        private System.Windows.Forms.TextBox txt_LEW_Mflush;
        private System.Windows.Forms.TextBox txt_LEW_Sflush;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_MBO;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_WGC;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_WKT;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_WBI;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_SCT;
        private System.Windows.Forms.CheckBox chk_EdayWKT;
        private System.Windows.Forms.CheckBox chk_EdayWBI;
        private System.Windows.Forms.CheckBox chk_EdaySCT;
        private System.Windows.Forms.CheckBox chk_EdayLEF;
        private System.Windows.Forms.CheckBox chk_EdayBAO;
        private System.Windows.Forms.CheckBox chk_EdayWGC;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chk_EdayAMT;
        private System.Windows.Forms.CheckBox chk_EdayMBO;
        private System.Windows.Forms.CheckBox chk_EdayLEW;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_AMT;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_BAO;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_LEW;
        private System.Windows.Forms.CheckBox chk_COMTRIGS_LEF;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbo_SITE_CODE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SYSTEMTEST;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txt_PREFILLTIME2;
        private System.Windows.Forms.TextBox txt_SAMPLETIME2;
        private System.Windows.Forms.CheckBox chk_SAMPLETIME2;
        private System.Windows.Forms.CheckBox chk_PREFILLTIME2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.CheckBox chk_Eday_MWO;
        private System.Windows.Forms.TextBox txt_MWO_SFLUSH;
        private System.Windows.Forms.TextBox txt_MWO_MFLUSH;
        private System.Windows.Forms.TextBox txt_MWO_COM;
        private System.Windows.Forms.TextBox txt_MWO_TIME;
        private System.Windows.Forms.CheckBox chk_COMTRIG_MWO;
    }
}

