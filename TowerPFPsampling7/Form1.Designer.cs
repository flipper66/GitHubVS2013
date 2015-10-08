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
            this.btnCloseCom = new System.Windows.Forms.Button();
            this.txt_COM_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_READ_COM = new System.Windows.Forms.Button();
            this.chk_MONITOR_PFP = new System.Windows.Forms.CheckBox();
            this.txt_MONITOR_FREQUENCY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CLEAR_SCREEN = new System.Windows.Forms.Button();
            this.lbl_UTC_TIME = new System.Windows.Forms.Label();
            this.txt_PREFILLTIME = new System.Windows.Forms.TextBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.chk_SAVE_TO_FILE = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_SAMPLE_TIME = new System.Windows.Forms.CheckBox();
            this.chk_PREFILLTIME = new System.Windows.Forms.CheckBox();
            this.txt_SAMPLE_TIME = new System.Windows.Forms.TextBox();
            this.lbl_COM_PORT_OPEN = new System.Windows.Forms.Label();
            this.btn_QUIT_TO_MAIN = new System.Windows.Forms.Button();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.label53 = new System.Windows.Forms.Label();
            this.rbtn_EVERYDAY = new System.Windows.Forms.RadioButton();
            this.rbtn_EVERYOTHERDAY = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_LASTSAMPLE = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DOY = new System.Windows.Forms.Label();
            this.txt_PREFILLTIME2 = new System.Windows.Forms.TextBox();
            this.txt_SAMPLETIME2 = new System.Windows.Forms.TextBox();
            this.chk_SAMPLETIME2 = new System.Windows.Forms.CheckBox();
            this.chk_PREFILLTIME2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.btn_HISTORY_T = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_testfindmwosample = new System.Windows.Forms.Button();
            this.lbl_StartupCounter = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chk_PREFILLANYTIME = new System.Windows.Forms.CheckBox();
            this.chk_SEND_HISTORYEMAIL = new System.Windows.Forms.CheckBox();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.btn_GET_SAMPLE_PLAN = new System.Windows.Forms.Button();
            this.btn_GET_NFILL2 = new System.Windows.Forms.Button();
            this.btn_LOAD_SITE_SETTINGS = new System.Windows.Forms.Button();
            this.lbl_LASTFILLEDFLASK = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_PFEACHSAMPLE = new System.Windows.Forms.TextBox();
            this.txt_PFASYSTEST = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.txt_DELAYTIMEAFTERPREFILL = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label42 = new System.Windows.Forms.Label();
            this.txt_SITE_Mflush = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_SITE_COMNAME = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_SITESAMPLE_time = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_SITE_Sflush = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.chk_SITE_Eday = new System.Windows.Forms.CheckBox();
            this.chk_SITE_COMTRIGGER = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_LIM_4SF_samplefill = new System.Windows.Forms.TextBox();
            this.txt_LIM_2MF_samplefill = new System.Windows.Forms.TextBox();
            this.txt_LIM_1MFT = new System.Windows.Forms.TextBox();
            this.txt_LIM_4SF_prefill = new System.Windows.Forms.TextBox();
            this.txt_LIM_2MF_prefill = new System.Windows.Forms.TextBox();
            this.txt_LIM_3DMF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_LIM_7MFP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_LIM_6MFT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_LIM_5DSF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chk_F5 = new System.Windows.Forms.TabPage();
            this.btn_EXECUTE_PREFILL = new System.Windows.Forms.Button();
            this.lbl_NEXTSAMPLE = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
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
            this.btn_MANUAL_SAMPLE = new System.Windows.Forms.Button();
            this.btn_GET_HISTORY = new System.Windows.Forms.Button();
            this.btn_PREFILL_LIMITS = new System.Windows.Forms.Button();
            this.btn_FIND_SAMPLE_ADD = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ALTADD1 = new System.Windows.Forms.TextBox();
            this.txt_ALTADD2 = new System.Windows.Forms.TextBox();
            this.txt_SAMPADD2 = new System.Windows.Forms.TextBox();
            this.txt_SAMPADD1 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txt_PCPNUMBER = new System.Windows.Forms.TextBox();
            this.txt_INSTALLNOTES = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbn_leaktestyes = new System.Windows.Forms.RadioButton();
            this.rbn_leaktestno = new System.Windows.Forms.RadioButton();
            this.label47 = new System.Windows.Forms.Label();
            this.btn_SEND_NEWPFP_EMAIL = new System.Windows.Forms.Button();
            this.lbl_PFPNUMBER = new System.Windows.Forms.Label();
            this.btn_SYSTEMTEST = new System.Windows.Forms.Button();
            this.btn_GETPFPNUMBER = new System.Windows.Forms.Button();
            this.btn_END_LOGGING = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NOTIFY = new System.Windows.Forms.Button();
            this.txt_INITIALS = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.tb_SITE = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_EMAILADD4 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_EMAILADD3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_EMAILADD2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_EMAILADD1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_GETDATETIME = new System.Windows.Forms.Button();
            this.txt_TANKCHANGEDATETIME = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_CLEAR_TANK_CHANGE = new System.Windows.Forms.Button();
            this.lbl_TANKCHANGEEMAILMSG = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_TANKCHANGEPERSON = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cbo_TANK_ID_DESCRIPT = new System.Windows.Forms.ComboBox();
            this.btn_EMAIL_TANK_CHANGE = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_NEWTANK = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_OLDTANK = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_SITE_CODE = new System.Windows.Forms.Label();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.btn_HISTORY_E = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.chk_F5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tb_SITE.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_PFP_TEXT
            // 
            this.txt_PFP_TEXT.Location = new System.Drawing.Point(453, 100);
            this.txt_PFP_TEXT.Multiline = true;
            this.txt_PFP_TEXT.Name = "txt_PFP_TEXT";
            this.txt_PFP_TEXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PFP_TEXT.Size = new System.Drawing.Size(395, 370);
            this.txt_PFP_TEXT.TabIndex = 25;
            this.txt_PFP_TEXT.TextChanged += new System.EventHandler(this.txt_PFP_TEXT_TextChanged);
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
            this.txt_TXT2PFP.Location = new System.Drawing.Point(453, 68);
            this.txt_TXT2PFP.Name = "txt_TXT2PFP";
            this.txt_TXT2PFP.Size = new System.Drawing.Size(46, 20);
            this.txt_TXT2PFP.TabIndex = 26;
            // 
            // btnSendText2PFP
            // 
            this.btnSendText2PFP.Location = new System.Drawing.Point(507, 69);
            this.btnSendText2PFP.Name = "btnSendText2PFP";
            this.btnSendText2PFP.Size = new System.Drawing.Size(86, 19);
            this.btnSendText2PFP.TabIndex = 27;
            this.btnSendText2PFP.Text = "SEND TO PFP";
            this.btnSendText2PFP.UseVisualStyleBackColor = true;
            this.btnSendText2PFP.Click += new System.EventHandler(this.btnSendText2PFP_Click);
            // 
            // btnCloseCom
            // 
            this.btnCloseCom.Location = new System.Drawing.Point(729, 67);
            this.btnCloseCom.Name = "btnCloseCom";
            this.btnCloseCom.Size = new System.Drawing.Size(77, 19);
            this.btnCloseCom.TabIndex = 29;
            this.btnCloseCom.Text = "CLOSE COM";
            this.btnCloseCom.UseVisualStyleBackColor = true;
            this.btnCloseCom.Click += new System.EventHandler(this.btnCloseCom_Click);
            // 
            // txt_COM_NAME
            // 
            this.txt_COM_NAME.Location = new System.Drawing.Point(676, 43);
            this.txt_COM_NAME.Name = "txt_COM_NAME";
            this.txt_COM_NAME.Size = new System.Drawing.Size(45, 20);
            this.txt_COM_NAME.TabIndex = 31;
            this.txt_COM_NAME.Text = "COM11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "TEXT TO SEND TO PFP";
            // 
            // btn_READ_COM
            // 
            this.btn_READ_COM.Location = new System.Drawing.Point(771, 476);
            this.btn_READ_COM.Name = "btn_READ_COM";
            this.btn_READ_COM.Size = new System.Drawing.Size(77, 21);
            this.btn_READ_COM.TabIndex = 35;
            this.btn_READ_COM.Text = "READ COM";
            this.btn_READ_COM.UseVisualStyleBackColor = true;
            this.btn_READ_COM.Click += new System.EventHandler(this.btn_READ_COM_Click);
            // 
            // chk_MONITOR_PFP
            // 
            this.chk_MONITOR_PFP.AutoSize = true;
            this.chk_MONITOR_PFP.Location = new System.Drawing.Point(613, 478);
            this.chk_MONITOR_PFP.Name = "chk_MONITOR_PFP";
            this.chk_MONITOR_PFP.Size = new System.Drawing.Size(141, 17);
            this.chk_MONITOR_PFP.TabIndex = 42;
            this.chk_MONITOR_PFP.Text = "MONITOR PFP SERIAL";
            this.chk_MONITOR_PFP.UseVisualStyleBackColor = true;
            this.chk_MONITOR_PFP.CheckedChanged += new System.EventHandler(this.chk_MONITOR_PFP_CheckedChanged);
            // 
            // txt_MONITOR_FREQUENCY
            // 
            this.txt_MONITOR_FREQUENCY.Location = new System.Drawing.Point(613, 499);
            this.txt_MONITOR_FREQUENCY.Name = "txt_MONITOR_FREQUENCY";
            this.txt_MONITOR_FREQUENCY.Size = new System.Drawing.Size(67, 20);
            this.txt_MONITOR_FREQUENCY.TabIndex = 44;
            this.txt_MONITOR_FREQUENCY.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "MONITOR FREQUENCY (ms)";
            // 
            // btn_CLEAR_SCREEN
            // 
            this.btn_CLEAR_SCREEN.Location = new System.Drawing.Point(452, 476);
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
            this.lbl_UTC_TIME.Location = new System.Drawing.Point(20, 517);
            this.lbl_UTC_TIME.Name = "lbl_UTC_TIME";
            this.lbl_UTC_TIME.Size = new System.Drawing.Size(58, 13);
            this.lbl_UTC_TIME.TabIndex = 46;
            this.lbl_UTC_TIME.Text = "UTC TIME";
            this.lbl_UTC_TIME.Click += new System.EventHandler(this.lbl_UTC_TIME_Click);
            // 
            // txt_PREFILLTIME
            // 
            this.txt_PREFILLTIME.Location = new System.Drawing.Point(27, 18);
            this.txt_PREFILLTIME.Name = "txt_PREFILLTIME";
            this.txt_PREFILLTIME.Size = new System.Drawing.Size(58, 20);
            this.txt_PREFILLTIME.TabIndex = 57;
            this.txt_PREFILLTIME.Text = "18:00:00";
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
            this.chk_SAVE_TO_FILE.Location = new System.Drawing.Point(452, 507);
            this.chk_SAVE_TO_FILE.Name = "chk_SAVE_TO_FILE";
            this.chk_SAVE_TO_FILE.Size = new System.Drawing.Size(131, 17);
            this.chk_SAVE_TO_FILE.TabIndex = 58;
            this.chk_SAVE_TO_FILE.Text = "SAVE COMS TO FILE";
            this.chk_SAVE_TO_FILE.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "UTC TIME";
            // 
            // chk_SAMPLE_TIME
            // 
            this.chk_SAMPLE_TIME.AutoSize = true;
            this.chk_SAMPLE_TIME.Location = new System.Drawing.Point(91, 18);
            this.chk_SAMPLE_TIME.Name = "chk_SAMPLE_TIME";
            this.chk_SAMPLE_TIME.Size = new System.Drawing.Size(12, 14);
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
            this.chk_PREFILLTIME.Size = new System.Drawing.Size(15, 14);
            this.chk_PREFILLTIME.TabIndex = 62;
            this.chk_PREFILLTIME.UseVisualStyleBackColor = true;
            this.chk_PREFILLTIME.CheckedChanged += new System.EventHandler(this.chk_PREFILLTIME_CheckedChanged);
            // 
            // txt_SAMPLE_TIME
            // 
            this.txt_SAMPLE_TIME.Location = new System.Drawing.Point(109, 18);
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
            this.lbl_COM_PORT_OPEN.Location = new System.Drawing.Point(730, 46);
            this.lbl_COM_PORT_OPEN.Name = "lbl_COM_PORT_OPEN";
            this.lbl_COM_PORT_OPEN.Size = new System.Drawing.Size(71, 13);
            this.lbl_COM_PORT_OPEN.TabIndex = 60;
            this.lbl_COM_PORT_OPEN.Text = "NOT OPEN";
            // 
            // btn_QUIT_TO_MAIN
            // 
            this.btn_QUIT_TO_MAIN.Location = new System.Drawing.Point(599, 68);
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
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(605, 50);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 13);
            this.label53.TabIndex = 69;
            this.label53.Text = "COM PORT:";
            // 
            // rbtn_EVERYDAY
            // 
            this.rbtn_EVERYDAY.AutoSize = true;
            this.rbtn_EVERYDAY.Checked = true;
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
            this.rbtn_EVERYOTHERDAY.Text = "EVERY OTHER";
            this.rbtn_EVERYOTHERDAY.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_EVERYDAY);
            this.panel1.Controls.Add(this.rbtn_EVERYOTHERDAY);
            this.panel1.Location = new System.Drawing.Point(321, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 47);
            this.panel1.TabIndex = 74;
            // 
            // chk_LASTSAMPLE
            // 
            this.chk_LASTSAMPLE.AutoSize = true;
            this.chk_LASTSAMPLE.Location = new System.Drawing.Point(102, 570);
            this.chk_LASTSAMPLE.Name = "chk_LASTSAMPLE";
            this.chk_LASTSAMPLE.Size = new System.Drawing.Size(99, 17);
            this.chk_LASTSAMPLE.TabIndex = 75;
            this.chk_LASTSAMPLE.Text = "LAST SAMPLE";
            this.chk_LASTSAMPLE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "DOY:";
            // 
            // lbl_DOY
            // 
            this.lbl_DOY.AutoSize = true;
            this.lbl_DOY.Location = new System.Drawing.Point(56, 538);
            this.lbl_DOY.Name = "lbl_DOY";
            this.lbl_DOY.Size = new System.Drawing.Size(30, 13);
            this.lbl_DOY.TabIndex = 78;
            this.lbl_DOY.Text = "DOY";
            // 
            // txt_PREFILLTIME2
            // 
            this.txt_PREFILLTIME2.Location = new System.Drawing.Point(27, 46);
            this.txt_PREFILLTIME2.Name = "txt_PREFILLTIME2";
            this.txt_PREFILLTIME2.Size = new System.Drawing.Size(57, 20);
            this.txt_PREFILLTIME2.TabIndex = 81;
            this.txt_PREFILLTIME2.Text = "22:00:00";
            // 
            // txt_SAMPLETIME2
            // 
            this.txt_SAMPLETIME2.Location = new System.Drawing.Point(109, 46);
            this.txt_SAMPLETIME2.Name = "txt_SAMPLETIME2";
            this.txt_SAMPLETIME2.Size = new System.Drawing.Size(67, 20);
            this.txt_SAMPLETIME2.TabIndex = 82;
            this.txt_SAMPLETIME2.Text = "23:00:00";
            // 
            // chk_SAMPLETIME2
            // 
            this.chk_SAMPLETIME2.AutoSize = true;
            this.chk_SAMPLETIME2.Location = new System.Drawing.Point(91, 46);
            this.chk_SAMPLETIME2.Name = "chk_SAMPLETIME2";
            this.chk_SAMPLETIME2.Size = new System.Drawing.Size(12, 14);
            this.chk_SAMPLETIME2.TabIndex = 83;
            this.chk_SAMPLETIME2.UseVisualStyleBackColor = true;
            // 
            // chk_PREFILLTIME2
            // 
            this.chk_PREFILLTIME2.AutoSize = true;
            this.chk_PREFILLTIME2.Location = new System.Drawing.Point(3, 46);
            this.chk_PREFILLTIME2.Name = "chk_PREFILLTIME2";
            this.chk_PREFILLTIME2.Size = new System.Drawing.Size(15, 14);
            this.chk_PREFILLTIME2.TabIndex = 84;
            this.chk_PREFILLTIME2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.38095F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.61905F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(102, 498);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.88372F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.11628F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 64);
            this.tableLayoutPanel5.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Prefill Time";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(109, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 13);
            this.label44.TabIndex = 87;
            this.label44.Text = "Sample Time";
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // btn_HISTORY_T
            // 
            this.btn_HISTORY_T.Location = new System.Drawing.Point(452, 21);
            this.btn_HISTORY_T.Name = "btn_HISTORY_T";
            this.btn_HISTORY_T.Size = new System.Drawing.Size(91, 19);
            this.btn_HISTORY_T.TabIndex = 95;
            this.btn_HISTORY_T.Text = " HISTORY_T?";
            this.btn_HISTORY_T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HISTORY_T.UseVisualStyleBackColor = true;
            this.btn_HISTORY_T.Click += new System.EventHandler(this.btn_HISTORY_T_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(449, 538);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(0, 13);
            this.label50.TabIndex = 96;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_testfindmwosample);
            this.tabPage4.Controls.Add(this.lbl_StartupCounter);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.chk_PREFILLANYTIME);
            this.tabPage4.Controls.Add(this.chk_SEND_HISTORYEMAIL);
            this.tabPage4.Controls.Add(this.btn_SendEmail);
            this.tabPage4.Controls.Add(this.btn_GET_SAMPLE_PLAN);
            this.tabPage4.Controls.Add(this.btn_GET_NFILL2);
            this.tabPage4.Controls.Add(this.btn_LOAD_SITE_SETTINGS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 405);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "TEST";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btn_testfindmwosample
            // 
            this.btn_testfindmwosample.Location = new System.Drawing.Point(260, 187);
            this.btn_testfindmwosample.Name = "btn_testfindmwosample";
            this.btn_testfindmwosample.Size = new System.Drawing.Size(117, 19);
            this.btn_testfindmwosample.TabIndex = 94;
            this.btn_testfindmwosample.Text = "test_find mwo sample";
            this.btn_testfindmwosample.UseVisualStyleBackColor = true;
            this.btn_testfindmwosample.Click += new System.EventHandler(this.btn_testfindmwosample_Click);
            // 
            // lbl_StartupCounter
            // 
            this.lbl_StartupCounter.AutoSize = true;
            this.lbl_StartupCounter.Location = new System.Drawing.Point(59, 282);
            this.lbl_StartupCounter.Name = "lbl_StartupCounter";
            this.lbl_StartupCounter.Size = new System.Drawing.Size(16, 13);
            this.lbl_StartupCounter.TabIndex = 93;
            this.lbl_StartupCounter.Text = "0 ";
            this.lbl_StartupCounter.Click += new System.EventHandler(this.lbl_StartupCounter_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(33, 256);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(87, 13);
            this.label54.TabIndex = 92;
            this.label54.Text = "Starutup Counter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 19);
            this.button1.TabIndex = 91;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_PREFILLANYTIME
            // 
            this.chk_PREFILLANYTIME.AutoSize = true;
            this.chk_PREFILLANYTIME.Location = new System.Drawing.Point(25, 212);
            this.chk_PREFILLANYTIME.Name = "chk_PREFILLANYTIME";
            this.chk_PREFILLANYTIME.Size = new System.Drawing.Size(120, 17);
            this.chk_PREFILLANYTIME.TabIndex = 90;
            this.chk_PREFILLANYTIME.Text = "PREFILL ANYTIME";
            this.chk_PREFILLANYTIME.UseVisualStyleBackColor = true;
            // 
            // chk_SEND_HISTORYEMAIL
            // 
            this.chk_SEND_HISTORYEMAIL.AutoSize = true;
            this.chk_SEND_HISTORYEMAIL.Checked = true;
            this.chk_SEND_HISTORYEMAIL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SEND_HISTORYEMAIL.Location = new System.Drawing.Point(27, 189);
            this.chk_SEND_HISTORYEMAIL.Name = "chk_SEND_HISTORYEMAIL";
            this.chk_SEND_HISTORYEMAIL.Size = new System.Drawing.Size(91, 17);
            this.chk_SEND_HISTORYEMAIL.TabIndex = 88;
            this.chk_SEND_HISTORYEMAIL.Text = "SEND EMAIL";
            this.chk_SEND_HISTORYEMAIL.UseVisualStyleBackColor = true;
            this.chk_SEND_HISTORYEMAIL.CheckedChanged += new System.EventHandler(this.chk_SEND_HISTORYEMAIL_CheckedChanged);
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Location = new System.Drawing.Point(27, 138);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(140, 19);
            this.btn_SendEmail.TabIndex = 67;
            this.btn_SendEmail.Text = "SendEmail";
            this.btn_SendEmail.UseVisualStyleBackColor = true;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // btn_GET_SAMPLE_PLAN
            // 
            this.btn_GET_SAMPLE_PLAN.Location = new System.Drawing.Point(25, 63);
            this.btn_GET_SAMPLE_PLAN.Name = "btn_GET_SAMPLE_PLAN";
            this.btn_GET_SAMPLE_PLAN.Size = new System.Drawing.Size(117, 19);
            this.btn_GET_SAMPLE_PLAN.TabIndex = 62;
            this.btn_GET_SAMPLE_PLAN.Text = "GET SAMPLE PLAN";
            this.btn_GET_SAMPLE_PLAN.UseVisualStyleBackColor = true;
            this.btn_GET_SAMPLE_PLAN.Click += new System.EventHandler(this.btn_GET_SAMPLE_PLAN_Click);
            // 
            // btn_GET_NFILL2
            // 
            this.btn_GET_NFILL2.Location = new System.Drawing.Point(25, 88);
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
            // lbl_LASTFILLEDFLASK
            // 
            this.lbl_LASTFILLEDFLASK.AutoSize = true;
            this.lbl_LASTFILLEDFLASK.Location = new System.Drawing.Point(133, 349);
            this.lbl_LASTFILLEDFLASK.Name = "lbl_LASTFILLEDFLASK";
            this.lbl_LASTFILLEDFLASK.Size = new System.Drawing.Size(53, 13);
            this.lbl_LASTFILLEDFLASK.TabIndex = 89;
            this.lbl_LASTFILLEDFLASK.Text = "FLASK X ";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(12, 349);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(115, 13);
            this.label45.TabIndex = 86;
            this.label45.Text = "LAST FILLED FLASK: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_PFEACHSAMPLE);
            this.tabPage2.Controls.Add(this.txt_PFASYSTEST);
            this.tabPage2.Controls.Add(this.label55);
            this.tabPage2.Controls.Add(this.label56);
            this.tabPage2.Controls.Add(this.txt_DELAYTIMEAFTERPREFILL);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txt_LIM_4SF_samplefill);
            this.tabPage2.Controls.Add(this.txt_LIM_2MF_samplefill);
            this.tabPage2.Controls.Add(this.txt_LIM_1MFT);
            this.tabPage2.Controls.Add(this.txt_LIM_4SF_prefill);
            this.tabPage2.Controls.Add(this.txt_LIM_2MF_prefill);
            this.tabPage2.Controls.Add(this.txt_LIM_3DMF);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txt_LIM_7MFP);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txt_LIM_6MFT);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_LIM_5DSF);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LIMITS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_PFEACHSAMPLE
            // 
            this.txt_PFEACHSAMPLE.Location = new System.Drawing.Point(345, 177);
            this.txt_PFEACHSAMPLE.Name = "txt_PFEACHSAMPLE";
            this.txt_PFEACHSAMPLE.Size = new System.Drawing.Size(50, 20);
            this.txt_PFEACHSAMPLE.TabIndex = 69;
            this.txt_PFEACHSAMPLE.Text = "Y";
            // 
            // txt_PFASYSTEST
            // 
            this.txt_PFASYSTEST.Location = new System.Drawing.Point(344, 153);
            this.txt_PFASYSTEST.Name = "txt_PFASYSTEST";
            this.txt_PFASYSTEST.Size = new System.Drawing.Size(50, 20);
            this.txt_PFASYSTEST.TabIndex = 67;
            this.txt_PFASYSTEST.Text = "N";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(161, 156);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(174, 13);
            this.label55.TabIndex = 68;
            this.label55.Text = "PRE-FILL ALL AFTER SYS TEST?";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(139, 177);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(195, 13);
            this.label56.TabIndex = 66;
            this.label56.Text = "PRE-FILL EACH BEFORE SAMPLING?";
            // 
            // txt_DELAYTIMEAFTERPREFILL
            // 
            this.txt_DELAYTIMEAFTERPREFILL.Location = new System.Drawing.Point(345, 126);
            this.txt_DELAYTIMEAFTERPREFILL.Name = "txt_DELAYTIMEAFTERPREFILL";
            this.txt_DELAYTIMEAFTERPREFILL.Size = new System.Drawing.Size(50, 20);
            this.txt_DELAYTIMEAFTERPREFILL.TabIndex = 65;
            this.txt_DELAYTIMEAFTERPREFILL.Text = "0";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(13, 133);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(179, 13);
            this.label51.TabIndex = 64;
            this.label51.Text = "DELAY TIME AFTER PREFILL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.51852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.48148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.label42, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_SITE_Mflush, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label32, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label31, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_SITE_COMNAME, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label29, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_SITESAMPLE_time, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label30, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_SITE_Sflush, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label27, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.chk_SITE_Eday, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.chk_SITE_COMTRIGGER, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 63);
            this.tableLayoutPanel1.TabIndex = 63;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(208, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(39, 26);
            this.label42.TabIndex = 92;
            this.label42.Text = "Eday/EOday";
            // 
            // txt_SITE_Mflush
            // 
            this.txt_SITE_Mflush.Location = new System.Drawing.Point(118, 35);
            this.txt_SITE_Mflush.Name = "txt_SITE_Mflush";
            this.txt_SITE_Mflush.Size = new System.Drawing.Size(24, 20);
            this.txt_SITE_Mflush.TabIndex = 93;
            this.txt_SITE_Mflush.Text = "80";
            this.txt_SITE_Mflush.TextChanged += new System.EventHandler(this.txt_SITE_Mflush_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(165, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 26);
            this.label32.TabIndex = 92;
            this.label32.Text = "S flush";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(118, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 13);
            this.label31.TabIndex = 91;
            this.label31.Text = "M flush";
            // 
            // txt_SITE_COMNAME
            // 
            this.txt_SITE_COMNAME.Location = new System.Drawing.Point(61, 35);
            this.txt_SITE_COMNAME.Name = "txt_SITE_COMNAME";
            this.txt_SITE_COMNAME.Size = new System.Drawing.Size(46, 20);
            this.txt_SITE_COMNAME.TabIndex = 66;
            this.txt_SITE_COMNAME.Text = "COM7";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(28, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 32);
            this.label29.TabIndex = 81;
            this.label29.Text = "SAMPLE TIME";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 32);
            this.label28.TabIndex = 63;
            this.label28.Text = "SITE";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 31);
            this.label20.TabIndex = 61;
            this.label20.Text = "AMT";
            // 
            // txt_SITESAMPLE_time
            // 
            this.txt_SITESAMPLE_time.Location = new System.Drawing.Point(28, 35);
            this.txt_SITESAMPLE_time.Name = "txt_SITESAMPLE_time";
            this.txt_SITESAMPLE_time.Size = new System.Drawing.Size(27, 20);
            this.txt_SITESAMPLE_time.TabIndex = 66;
            this.txt_SITESAMPLE_time.Text = "19:15:00";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(61, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 26);
            this.label30.TabIndex = 82;
            this.label30.Text = "COM NAME";
            // 
            // txt_SITE_Sflush
            // 
            this.txt_SITE_Sflush.Location = new System.Drawing.Point(165, 35);
            this.txt_SITE_Sflush.Name = "txt_SITE_Sflush";
            this.txt_SITE_Sflush.Size = new System.Drawing.Size(24, 20);
            this.txt_SITE_Sflush.TabIndex = 94;
            this.txt_SITE_Sflush.Text = "70";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(253, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 116;
            this.label27.Text = "ComTrigger";
            // 
            // chk_SITE_Eday
            // 
            this.chk_SITE_Eday.AutoSize = true;
            this.chk_SITE_Eday.Location = new System.Drawing.Point(208, 35);
            this.chk_SITE_Eday.Name = "chk_SITE_Eday";
            this.chk_SITE_Eday.Size = new System.Drawing.Size(33, 17);
            this.chk_SITE_Eday.TabIndex = 117;
            this.chk_SITE_Eday.Text = "E";
            this.chk_SITE_Eday.UseVisualStyleBackColor = true;
            // 
            // chk_SITE_COMTRIGGER
            // 
            this.chk_SITE_COMTRIGGER.AutoSize = true;
            this.chk_SITE_COMTRIGGER.Location = new System.Drawing.Point(253, 35);
            this.chk_SITE_COMTRIGGER.Name = "chk_SITE_COMTRIGGER";
            this.chk_SITE_COMTRIGGER.Size = new System.Drawing.Size(33, 17);
            this.chk_SITE_COMTRIGGER.TabIndex = 121;
            this.chk_SITE_COMTRIGGER.Text = "C";
            this.chk_SITE_COMTRIGGER.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "SAMPLE SAMPLING LIMITS";
            // 
            // txt_LIM_4SF_samplefill
            // 
            this.txt_LIM_4SF_samplefill.Location = new System.Drawing.Point(349, 232);
            this.txt_LIM_4SF_samplefill.Name = "txt_LIM_4SF_samplefill";
            this.txt_LIM_4SF_samplefill.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_4SF_samplefill.TabIndex = 60;
            this.txt_LIM_4SF_samplefill.Text = "70";
            // 
            // txt_LIM_2MF_samplefill
            // 
            this.txt_LIM_2MF_samplefill.Location = new System.Drawing.Point(347, 207);
            this.txt_LIM_2MF_samplefill.Name = "txt_LIM_2MF_samplefill";
            this.txt_LIM_2MF_samplefill.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_2MF_samplefill.TabIndex = 58;
            this.txt_LIM_2MF_samplefill.Text = "80";
            // 
            // txt_LIM_1MFT
            // 
            this.txt_LIM_1MFT.Location = new System.Drawing.Point(285, 273);
            this.txt_LIM_1MFT.Name = "txt_LIM_1MFT";
            this.txt_LIM_1MFT.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_1MFT.TabIndex = 42;
            this.txt_LIM_1MFT.Text = "600";
            // 
            // txt_LIM_4SF_prefill
            // 
            this.txt_LIM_4SF_prefill.Location = new System.Drawing.Point(349, 100);
            this.txt_LIM_4SF_prefill.Name = "txt_LIM_4SF_prefill";
            this.txt_LIM_4SF_prefill.Size = new System.Drawing.Size(50, 20);
            this.txt_LIM_4SF_prefill.TabIndex = 54;
            this.txt_LIM_4SF_prefill.Text = "10";
            // 
            // txt_LIM_2MF_prefill
            // 
            this.txt_LIM_2MF_prefill.Location = new System.Drawing.Point(348, 76);
            this.txt_LIM_2MF_prefill.Name = "txt_LIM_2MF_prefill";
            this.txt_LIM_2MF_prefill.Size = new System.Drawing.Size(50, 20);
            this.txt_LIM_2MF_prefill.TabIndex = 44;
            this.txt_LIM_2MF_prefill.Text = "5";
            // 
            // txt_LIM_3DMF
            // 
            this.txt_LIM_3DMF.Location = new System.Drawing.Point(285, 297);
            this.txt_LIM_3DMF.Name = "txt_LIM_3DMF";
            this.txt_LIM_3DMF.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_3DMF.TabIndex = 52;
            this.txt_LIM_3DMF.Text = "5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(182, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "MANIFOLD FLUSH VOLUME";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(182, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "SAMPLE FLUSH VOLUME";
            // 
            // txt_LIM_7MFP
            // 
            this.txt_LIM_7MFP.Location = new System.Drawing.Point(286, 368);
            this.txt_LIM_7MFP.Name = "txt_LIM_7MFP";
            this.txt_LIM_7MFP.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_7MFP.TabIndex = 50;
            this.txt_LIM_7MFP.Text = "40";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "PRE-FILL SAMPLING LIMITS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "MANIFOLD FLUSH VOLUME";
            // 
            // txt_LIM_6MFT
            // 
            this.txt_LIM_6MFT.Location = new System.Drawing.Point(286, 346);
            this.txt_LIM_6MFT.Name = "txt_LIM_6MFT";
            this.txt_LIM_6MFT.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_6MFT.TabIndex = 48;
            this.txt_LIM_6MFT.Text = "150";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "SAMPLE FLUSH VOLUME";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 88);
            this.label14.TabIndex = 55;
            this.label14.Text = "BOTH PRE-FILL SAMPLING LIMITS AND SAMPLE LIMITS";
            // 
            // txt_LIM_5DSF
            // 
            this.txt_LIM_5DSF.Location = new System.Drawing.Point(286, 321);
            this.txt_LIM_5DSF.Name = "txt_LIM_5DSF";
            this.txt_LIM_5DSF.Size = new System.Drawing.Size(49, 20);
            this.txt_LIM_5DSF.TabIndex = 46;
            this.txt_LIM_5DSF.Text = "40";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "MAX FLUSH TIME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "DEFAULT SAMPLE FLUSH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "MAX FILL TIME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "MIN FILL PRESSURE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "DEFAULT MANIFOLD FLUSH";
            // 
            // chk_F5
            // 
            this.chk_F5.Controls.Add(this.btn_EXECUTE_PREFILL);
            this.chk_F5.Controls.Add(this.lbl_NEXTSAMPLE);
            this.chk_F5.Controls.Add(this.lbl_LASTFILLEDFLASK);
            this.chk_F5.Controls.Add(this.label41);
            this.chk_F5.Controls.Add(this.lbl_DOY_LASTSAMPLE);
            this.chk_F5.Controls.Add(this.label45);
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
            this.chk_F5.Size = new System.Drawing.Size(409, 405);
            this.chk_F5.TabIndex = 0;
            this.chk_F5.Text = "PREFILL STEPS";
            this.chk_F5.UseVisualStyleBackColor = true;
            // 
            // btn_EXECUTE_PREFILL
            // 
            this.btn_EXECUTE_PREFILL.Location = new System.Drawing.Point(7, 6);
            this.btn_EXECUTE_PREFILL.Name = "btn_EXECUTE_PREFILL";
            this.btn_EXECUTE_PREFILL.Size = new System.Drawing.Size(117, 19);
            this.btn_EXECUTE_PREFILL.TabIndex = 83;
            this.btn_EXECUTE_PREFILL.Text = "EXECUTE PREFILL";
            this.btn_EXECUTE_PREFILL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EXECUTE_PREFILL.UseVisualStyleBackColor = true;
            this.btn_EXECUTE_PREFILL.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_NEXTSAMPLE
            // 
            this.lbl_NEXTSAMPLE.AutoSize = true;
            this.lbl_NEXTSAMPLE.Location = new System.Drawing.Point(106, 384);
            this.lbl_NEXTSAMPLE.Name = "lbl_NEXTSAMPLE";
            this.lbl_NEXTSAMPLE.Size = new System.Drawing.Size(14, 13);
            this.lbl_NEXTSAMPLE.TabIndex = 82;
            this.lbl_NEXTSAMPLE.Text = "#";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 384);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(85, 13);
            this.label41.TabIndex = 81;
            this.label41.Text = "NEXT SAMPLE:";
            // 
            // lbl_DOY_LASTSAMPLE
            // 
            this.lbl_DOY_LASTSAMPLE.AutoSize = true;
            this.lbl_DOY_LASTSAMPLE.Location = new System.Drawing.Point(138, 368);
            this.lbl_DOY_LASTSAMPLE.Name = "lbl_DOY_LASTSAMPLE";
            this.lbl_DOY_LASTSAMPLE.Size = new System.Drawing.Size(30, 13);
            this.lbl_DOY_LASTSAMPLE.TabIndex = 80;
            this.lbl_DOY_LASTSAMPLE.Text = "DOY";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 368);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(183, 61);
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
            this.chk_F1.CheckedChanged += new System.EventHandler(this.chk_F1_CheckedChanged);
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
            // 
            // lbl_EXECUTINGSEQUENCE
            // 
            this.lbl_EXECUTINGSEQUENCE.AutoSize = true;
            this.lbl_EXECUTINGSEQUENCE.Location = new System.Drawing.Point(4, 36);
            this.lbl_EXECUTINGSEQUENCE.Name = "lbl_EXECUTINGSEQUENCE";
            this.lbl_EXECUTINGSEQUENCE.Size = new System.Drawing.Size(172, 13);
            this.lbl_EXECUTINGSEQUENCE.TabIndex = 68;
            this.lbl_EXECUTINGSEQUENCE.Text = "If green, executing prefill sequence";
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
            this.btn_WRITE_PLAN.Location = new System.Drawing.Point(6, 287);
            this.btn_WRITE_PLAN.Name = "btn_WRITE_PLAN";
            this.btn_WRITE_PLAN.Size = new System.Drawing.Size(170, 19);
            this.btn_WRITE_PLAN.TabIndex = 65;
            this.btn_WRITE_PLAN.Text = "6. WRITE SAMPLE PLAN ADD";
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
            this.btn_SAMP_FILL_LIMITS.Location = new System.Drawing.Point(7, 315);
            this.btn_SAMP_FILL_LIMITS.Name = "btn_SAMP_FILL_LIMITS";
            this.btn_SAMP_FILL_LIMITS.Size = new System.Drawing.Size(159, 19);
            this.btn_SAMP_FILL_LIMITS.TabIndex = 50;
            this.btn_SAMP_FILL_LIMITS.Text = "7. SET SAMPLE FILL LIMITS";
            this.btn_SAMP_FILL_LIMITS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SAMP_FILL_LIMITS.UseVisualStyleBackColor = true;
            this.btn_SAMP_FILL_LIMITS.Click += new System.EventHandler(this.btn_SAMP_FILL_LIMITS_Click);
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
            // btn_PREFILL_LIMITS
            // 
            this.btn_PREFILL_LIMITS.Location = new System.Drawing.Point(6, 156);
            this.btn_PREFILL_LIMITS.Name = "btn_PREFILL_LIMITS";
            this.btn_PREFILL_LIMITS.Size = new System.Drawing.Size(143, 19);
            this.btn_PREFILL_LIMITS.TabIndex = 49;
            this.btn_PREFILL_LIMITS.Text = "4. SET PFP LIMITS";
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
            this.label33.Location = new System.Drawing.Point(3, 211);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(101, 211);
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(409, 405);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "INSTALL STEPS";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.txt_PCPNUMBER);
            this.groupBox2.Controls.Add(this.txt_INSTALLNOTES);
            this.groupBox2.Controls.Add(this.label49);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Controls.Add(this.btn_SEND_NEWPFP_EMAIL);
            this.groupBox2.Controls.Add(this.lbl_PFPNUMBER);
            this.groupBox2.Controls.Add(this.btn_SYSTEMTEST);
            this.groupBox2.Controls.Add(this.btn_GETPFPNUMBER);
            this.groupBox2.Controls.Add(this.btn_END_LOGGING);
            this.groupBox2.Location = new System.Drawing.Point(16, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 256);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "After New PFP is installed";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(163, 207);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(172, 13);
            this.label52.TabIndex = 95;
            this.label52.Text = "(Wait to complete before next step)";
            // 
            // txt_PCPNUMBER
            // 
            this.txt_PCPNUMBER.Location = new System.Drawing.Point(144, 26);
            this.txt_PCPNUMBER.Name = "txt_PCPNUMBER";
            this.txt_PCPNUMBER.Size = new System.Drawing.Size(67, 20);
            this.txt_PCPNUMBER.TabIndex = 86;
            this.txt_PCPNUMBER.Text = "XXXX-CP";
            // 
            // txt_INSTALLNOTES
            // 
            this.txt_INSTALLNOTES.Location = new System.Drawing.Point(10, 100);
            this.txt_INSTALLNOTES.Multiline = true;
            this.txt_INSTALLNOTES.Name = "txt_INSTALLNOTES";
            this.txt_INSTALLNOTES.Size = new System.Drawing.Size(329, 41);
            this.txt_INSTALLNOTES.TabIndex = 90;
            this.txt_INSTALLNOTES.Text = "100 TORR, 1 TORR GAIN IN 5 MINUTES";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 33);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(130, 13);
            this.label49.TabIndex = 93;
            this.label49.Text = "3. ENTER PCP NUMBER";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(7, 84);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(321, 13);
            this.label48.TabIndex = 91;
            this.label48.Text = "5. ENTER ANY SPECIAL NOTES ... LEAK TEST RESULTS, ETC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbn_leaktestyes);
            this.panel2.Controls.Add(this.rbn_leaktestno);
            this.panel2.Location = new System.Drawing.Point(171, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 22);
            this.panel2.TabIndex = 89;
            // 
            // rbn_leaktestyes
            // 
            this.rbn_leaktestyes.AutoSize = true;
            this.rbn_leaktestyes.Location = new System.Drawing.Point(11, 3);
            this.rbn_leaktestyes.Name = "rbn_leaktestyes";
            this.rbn_leaktestyes.Size = new System.Drawing.Size(46, 17);
            this.rbn_leaktestyes.TabIndex = 72;
            this.rbn_leaktestyes.TabStop = true;
            this.rbn_leaktestyes.Text = "YES";
            this.rbn_leaktestyes.UseVisualStyleBackColor = true;
            // 
            // rbn_leaktestno
            // 
            this.rbn_leaktestno.AutoSize = true;
            this.rbn_leaktestno.Location = new System.Drawing.Point(63, 3);
            this.rbn_leaktestno.Name = "rbn_leaktestno";
            this.rbn_leaktestno.Size = new System.Drawing.Size(41, 17);
            this.rbn_leaktestno.TabIndex = 73;
            this.rbn_leaktestno.TabStop = true;
            this.rbn_leaktestno.Text = "NO";
            this.rbn_leaktestno.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 59);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(154, 13);
            this.label47.TabIndex = 88;
            this.label47.Text = "4. LEAK TEST PERFORMED?";
            // 
            // btn_SEND_NEWPFP_EMAIL
            // 
            this.btn_SEND_NEWPFP_EMAIL.Location = new System.Drawing.Point(9, 226);
            this.btn_SEND_NEWPFP_EMAIL.Name = "btn_SEND_NEWPFP_EMAIL";
            this.btn_SEND_NEWPFP_EMAIL.Size = new System.Drawing.Size(362, 19);
            this.btn_SEND_NEWPFP_EMAIL.TabIndex = 82;
            this.btn_SEND_NEWPFP_EMAIL.Text = "9. SEND NEW PFP EMAIL (NOTES FROM 5. WILL BE INCLUDED)";
            this.btn_SEND_NEWPFP_EMAIL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SEND_NEWPFP_EMAIL.UseVisualStyleBackColor = true;
            this.btn_SEND_NEWPFP_EMAIL.Click += new System.EventHandler(this.btn_SEND_NEWPFP_EMAIL_Click);
            // 
            // lbl_PFPNUMBER
            // 
            this.lbl_PFPNUMBER.AutoSize = true;
            this.lbl_PFPNUMBER.Location = new System.Drawing.Point(141, 154);
            this.lbl_PFPNUMBER.Name = "lbl_PFPNUMBER";
            this.lbl_PFPNUMBER.Size = new System.Drawing.Size(51, 13);
            this.lbl_PFPNUMBER.TabIndex = 76;
            this.lbl_PFPNUMBER.Text = "XXXX-FP";
            // 
            // btn_SYSTEMTEST
            // 
            this.btn_SYSTEMTEST.Location = new System.Drawing.Point(9, 201);
            this.btn_SYSTEMTEST.Name = "btn_SYSTEMTEST";
            this.btn_SYSTEMTEST.Size = new System.Drawing.Size(147, 19);
            this.btn_SYSTEMTEST.TabIndex = 81;
            this.btn_SYSTEMTEST.Text = "8. SYSTEM TEST (60sec)";
            this.btn_SYSTEMTEST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SYSTEMTEST.UseVisualStyleBackColor = true;
            this.btn_SYSTEMTEST.Click += new System.EventHandler(this.btn_SYSTEMTEST_Click);
            // 
            // btn_GETPFPNUMBER
            // 
            this.btn_GETPFPNUMBER.Location = new System.Drawing.Point(10, 151);
            this.btn_GETPFPNUMBER.Name = "btn_GETPFPNUMBER";
            this.btn_GETPFPNUMBER.Size = new System.Drawing.Size(125, 19);
            this.btn_GETPFPNUMBER.TabIndex = 70;
            this.btn_GETPFPNUMBER.Text = "6. GET PFP NUMBER";
            this.btn_GETPFPNUMBER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GETPFPNUMBER.UseVisualStyleBackColor = true;
            this.btn_GETPFPNUMBER.Click += new System.EventHandler(this.btn_GETPFPNUMBER_Click);
            // 
            // btn_END_LOGGING
            // 
            this.btn_END_LOGGING.Location = new System.Drawing.Point(9, 176);
            this.btn_END_LOGGING.Name = "btn_END_LOGGING";
            this.btn_END_LOGGING.Size = new System.Drawing.Size(131, 19);
            this.btn_END_LOGGING.TabIndex = 67;
            this.btn_END_LOGGING.Text = "7. STOP PFP LOGGING";
            this.btn_END_LOGGING.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_END_LOGGING.UseVisualStyleBackColor = true;
            this.btn_END_LOGGING.Click += new System.EventHandler(this.btn_END_LOGGING_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NOTIFY);
            this.groupBox1.Controls.Add(this.txt_INITIALS);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 79);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "When First Arriving At site";
            // 
            // btn_NOTIFY
            // 
            this.btn_NOTIFY.Location = new System.Drawing.Point(27, 40);
            this.btn_NOTIFY.Name = "btn_NOTIFY";
            this.btn_NOTIFY.Size = new System.Drawing.Size(80, 20);
            this.btn_NOTIFY.TabIndex = 96;
            this.btn_NOTIFY.Text = "2. NOTIFY";
            this.btn_NOTIFY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NOTIFY.UseVisualStyleBackColor = true;
            this.btn_NOTIFY.Click += new System.EventHandler(this.btn_NOTIFY_Click);
            // 
            // txt_INITIALS
            // 
            this.txt_INITIALS.Location = new System.Drawing.Point(126, 17);
            this.txt_INITIALS.Name = "txt_INITIALS";
            this.txt_INITIALS.Size = new System.Drawing.Size(129, 20);
            this.txt_INITIALS.TabIndex = 86;
            this.txt_INITIALS.Text = "John Doe";
            this.txt_INITIALS.TextChanged += new System.EventHandler(this.txt_INITIALS_TextChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(17, 24);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(90, 13);
            this.label46.TabIndex = 87;
            this.label46.Text = "1. ENTER NAME";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(24, 383);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(301, 13);
            this.label24.TabIndex = 98;
            this.label24.Text = "JON KOFLER 303-4967-4679 (OFFICE), 720-839-6839 (CELL)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 367);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(198, 13);
            this.label23.TabIndex = 97;
            this.label23.Text = "THANK YOU !... HAVE A GREAT DAY !";
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(676, 20);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(87, 19);
            this.btnOpenCom.TabIndex = 28;
            this.btnOpenCom.Text = " OPEN COM";
            this.btnOpenCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // tb_SITE
            // 
            this.tb_SITE.Controls.Add(this.tabPage5);
            this.tb_SITE.Controls.Add(this.chk_F5);
            this.tb_SITE.Controls.Add(this.tabPage2);
            this.tb_SITE.Controls.Add(this.tabPage4);
            this.tb_SITE.Controls.Add(this.tabPage1);
            this.tb_SITE.Controls.Add(this.tabPage3);
            this.tb_SITE.Location = new System.Drawing.Point(19, 52);
            this.tb_SITE.Name = "tb_SITE";
            this.tb_SITE.SelectedIndex = 0;
            this.tb_SITE.Size = new System.Drawing.Size(417, 431);
            this.tb_SITE.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_EMAILADD4);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.txt_EMAILADD3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.txt_EMAILADD2);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txt_EMAILADD1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 405);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "SITE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_EMAILADD4
            // 
            this.txt_EMAILADD4.Location = new System.Drawing.Point(133, 113);
            this.txt_EMAILADD4.Name = "txt_EMAILADD4";
            this.txt_EMAILADD4.Size = new System.Drawing.Size(254, 20);
            this.txt_EMAILADD4.TabIndex = 94;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(33, 120);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(76, 13);
            this.label40.TabIndex = 95;
            this.label40.Text = "EmailAddress4";
            // 
            // txt_EMAILADD3
            // 
            this.txt_EMAILADD3.Location = new System.Drawing.Point(133, 87);
            this.txt_EMAILADD3.Name = "txt_EMAILADD3";
            this.txt_EMAILADD3.Size = new System.Drawing.Size(254, 20);
            this.txt_EMAILADD3.TabIndex = 92;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 94);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 93;
            this.label22.Text = "EmailAddress3";
            // 
            // txt_EMAILADD2
            // 
            this.txt_EMAILADD2.Location = new System.Drawing.Point(133, 61);
            this.txt_EMAILADD2.Name = "txt_EMAILADD2";
            this.txt_EMAILADD2.Size = new System.Drawing.Size(254, 20);
            this.txt_EMAILADD2.TabIndex = 90;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 68);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 91;
            this.label21.Text = "EmailAddress2";
            // 
            // txt_EMAILADD1
            // 
            this.txt_EMAILADD1.Location = new System.Drawing.Point(133, 35);
            this.txt_EMAILADD1.Name = "txt_EMAILADD1";
            this.txt_EMAILADD1.Size = new System.Drawing.Size(254, 20);
            this.txt_EMAILADD1.TabIndex = 88;
            this.txt_EMAILADD1.TextChanged += new System.EventHandler(this.txt_EMAILADD1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "EmailAddress1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_GETDATETIME);
            this.tabPage3.Controls.Add(this.txt_TANKCHANGEDATETIME);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.btn_CLEAR_TANK_CHANGE);
            this.tabPage3.Controls.Add(this.lbl_TANKCHANGEEMAILMSG);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.txt_TANKCHANGEPERSON);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.cbo_TANK_ID_DESCRIPT);
            this.tabPage3.Controls.Add(this.btn_EMAIL_TANK_CHANGE);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.txt_NEWTANK);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.txt_OLDTANK);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 405);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.Text = "TANK_CHANGE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_GETDATETIME
            // 
            this.btn_GETDATETIME.Location = new System.Drawing.Point(136, 159);
            this.btn_GETDATETIME.Name = "btn_GETDATETIME";
            this.btn_GETDATETIME.Size = new System.Drawing.Size(158, 19);
            this.btn_GETDATETIME.TabIndex = 105;
            this.btn_GETDATETIME.Text = "GET CURRENT DATE TIME";
            this.btn_GETDATETIME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GETDATETIME.UseVisualStyleBackColor = true;
            this.btn_GETDATETIME.Click += new System.EventHandler(this.btn_GETDATETIME_Click);
            // 
            // txt_TANKCHANGEDATETIME
            // 
            this.txt_TANKCHANGEDATETIME.Location = new System.Drawing.Point(72, 178);
            this.txt_TANKCHANGEDATETIME.Name = "txt_TANKCHANGEDATETIME";
            this.txt_TANKCHANGEDATETIME.Size = new System.Drawing.Size(323, 20);
            this.txt_TANKCHANGEDATETIME.TabIndex = 104;
            this.txt_TANKCHANGEDATETIME.Text = "CLICK BUTTON ABOVE";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 181);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(65, 13);
            this.label43.TabIndex = 103;
            this.label43.Text = "DATE TIME";
            // 
            // btn_CLEAR_TANK_CHANGE
            // 
            this.btn_CLEAR_TANK_CHANGE.Location = new System.Drawing.Point(144, 377);
            this.btn_CLEAR_TANK_CHANGE.Name = "btn_CLEAR_TANK_CHANGE";
            this.btn_CLEAR_TANK_CHANGE.Size = new System.Drawing.Size(92, 19);
            this.btn_CLEAR_TANK_CHANGE.TabIndex = 102;
            this.btn_CLEAR_TANK_CHANGE.Text = "CLEAR FORM";
            this.btn_CLEAR_TANK_CHANGE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CLEAR_TANK_CHANGE.UseVisualStyleBackColor = true;
            this.btn_CLEAR_TANK_CHANGE.Click += new System.EventHandler(this.btn_CLEAR_TANK_CHANGE_Click);
            // 
            // lbl_TANKCHANGEEMAILMSG
            // 
            this.lbl_TANKCHANGEEMAILMSG.AutoSize = true;
            this.lbl_TANKCHANGEEMAILMSG.Location = new System.Drawing.Point(17, 229);
            this.lbl_TANKCHANGEEMAILMSG.Name = "lbl_TANKCHANGEEMAILMSG";
            this.lbl_TANKCHANGEEMAILMSG.Size = new System.Drawing.Size(53, 13);
            this.lbl_TANKCHANGEEMAILMSG.TabIndex = 101;
            this.lbl_TANKCHANGEEMAILMSG.Text = "email msg";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(17, 57);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(121, 13);
            this.label37.TabIndex = 100;
            this.label37.Text = "CHANGING CYLINDER";
            // 
            // txt_TANKCHANGEPERSON
            // 
            this.txt_TANKCHANGEPERSON.Location = new System.Drawing.Point(144, 50);
            this.txt_TANKCHANGEPERSON.Name = "txt_TANKCHANGEPERSON";
            this.txt_TANKCHANGEPERSON.Size = new System.Drawing.Size(129, 20);
            this.txt_TANKCHANGEPERSON.TabIndex = 98;
            this.txt_TANKCHANGEPERSON.Text = "John Doe";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(35, 38);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(103, 13);
            this.label36.TabIndex = 99;
            this.label36.Text = "NAME OF PERSON";
            // 
            // cbo_TANK_ID_DESCRIPT
            // 
            this.cbo_TANK_ID_DESCRIPT.FormattingEnabled = true;
            this.cbo_TANK_ID_DESCRIPT.Items.AddRange(new object[] {
            "select value",
            "id01_CO2_REF",
            "id02_CO2_C2",
            "id03_CO2_C1",
            "id04_CO2_TGT",
            "id05_CO2_C3",
            "id06_CO2_C4",
            "id07_C0_LOW",
            "id08_CO_TGT",
            "id09_CO_hi",
            "id_10_NPURGE"});
            this.cbo_TANK_ID_DESCRIPT.Location = new System.Drawing.Point(144, 132);
            this.cbo_TANK_ID_DESCRIPT.Name = "cbo_TANK_ID_DESCRIPT";
            this.cbo_TANK_ID_DESCRIPT.Size = new System.Drawing.Size(129, 21);
            this.cbo_TANK_ID_DESCRIPT.TabIndex = 97;
            // 
            // btn_EMAIL_TANK_CHANGE
            // 
            this.btn_EMAIL_TANK_CHANGE.Location = new System.Drawing.Point(142, 204);
            this.btn_EMAIL_TANK_CHANGE.Name = "btn_EMAIL_TANK_CHANGE";
            this.btn_EMAIL_TANK_CHANGE.Size = new System.Drawing.Size(152, 19);
            this.btn_EMAIL_TANK_CHANGE.TabIndex = 96;
            this.btn_EMAIL_TANK_CHANGE.Text = "SUBMIT/EMAIL/CONFIRM";
            this.btn_EMAIL_TANK_CHANGE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EMAIL_TANK_CHANGE.UseVisualStyleBackColor = true;
            this.btn_EMAIL_TANK_CHANGE.Click += new System.EventHandler(this.btn_EMAIL_TANK_CHANGE_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(35, 135);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 13);
            this.label35.TabIndex = 93;
            this.label35.Text = "TANK DESCRIPT";
            // 
            // txt_NEWTANK
            // 
            this.txt_NEWTANK.Location = new System.Drawing.Point(144, 102);
            this.txt_NEWTANK.Name = "txt_NEWTANK";
            this.txt_NEWTANK.Size = new System.Drawing.Size(129, 20);
            this.txt_NEWTANK.TabIndex = 90;
            this.txt_NEWTANK.Text = "CA0????";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(35, 109);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 91;
            this.label26.Text = "NEW TANK #";
            // 
            // txt_OLDTANK
            // 
            this.txt_OLDTANK.Location = new System.Drawing.Point(144, 76);
            this.txt_OLDTANK.Name = "txt_OLDTANK";
            this.txt_OLDTANK.Size = new System.Drawing.Size(129, 20);
            this.txt_OLDTANK.TabIndex = 88;
            this.txt_OLDTANK.Text = "CA0????";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(35, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 13);
            this.label25.TabIndex = 89;
            this.label25.Text = "OLD TANK #";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(92, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 97;
            this.label19.Text = "(SITE CODE)";
            // 
            // lbl_SITE_CODE
            // 
            this.lbl_SITE_CODE.AutoSize = true;
            this.lbl_SITE_CODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SITE_CODE.ForeColor = System.Drawing.Color.Purple;
            this.lbl_SITE_CODE.Location = new System.Drawing.Point(19, 20);
            this.lbl_SITE_CODE.Name = "lbl_SITE_CODE";
            this.lbl_SITE_CODE.Size = new System.Drawing.Size(104, 20);
            this.lbl_SITE_CODE.TabIndex = 98;
            this.lbl_SITE_CODE.Text = "SITE CODE";
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // btn_HISTORY_E
            // 
            this.btn_HISTORY_E.Location = new System.Drawing.Point(558, 20);
            this.btn_HISTORY_E.Name = "btn_HISTORY_E";
            this.btn_HISTORY_E.Size = new System.Drawing.Size(91, 19);
            this.btn_HISTORY_E.TabIndex = 99;
            this.btn_HISTORY_E.Text = " HISTORY_E?";
            this.btn_HISTORY_E.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HISTORY_E.UseVisualStyleBackColor = true;
            this.btn_HISTORY_E.Click += new System.EventHandler(this.btn_HISTORY_E_Click);
            // 
            // frm_TOWER_PFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 603);
            this.Controls.Add(this.btn_HISTORY_E);
            this.Controls.Add(this.lbl_SITE_CODE);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.btn_HISTORY_T);
            this.Controls.Add(this.tb_SITE);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.lbl_DOY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_LASTSAMPLE);
            this.Controls.Add(this.btnOpenCom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.txt_COM_NAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_SAVE_TO_FILE);
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
            this.Text = "Tower PFP Sampler version 10.24";
            this.Load += new System.EventHandler(this.frm_TOWER_PFP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.chk_F5.ResumeLayout(false);
            this.chk_F5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tb_SITE.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button btnCloseCom;
        private System.Windows.Forms.TextBox txt_COM_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_READ_COM;
        private System.Windows.Forms.CheckBox chk_MONITOR_PFP;
        private System.Windows.Forms.TextBox txt_MONITOR_FREQUENCY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CLEAR_SCREEN;
        private System.Windows.Forms.Label lbl_UTC_TIME;
        private System.Windows.Forms.TextBox txt_PREFILLTIME;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.CheckBox chk_SAVE_TO_FILE;
        private System.Windows.Forms.Label lbl_COM_PORT_OPEN;
        private System.Windows.Forms.Button btn_QUIT_TO_MAIN;
        private System.Windows.Forms.TextBox txt_SAMPLE_TIME;
        private System.Windows.Forms.CheckBox chk_SAMPLE_TIME;
        private System.Windows.Forms.CheckBox chk_PREFILLTIME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.RadioButton rbtn_EVERYDAY;
        private System.Windows.Forms.RadioButton rbtn_EVERYOTHERDAY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_LASTSAMPLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DOY;
        private System.Windows.Forms.TextBox txt_PREFILLTIME2;
        private System.Windows.Forms.TextBox txt_SAMPLETIME2;
        private System.Windows.Forms.CheckBox chk_SAMPLETIME2;
        private System.Windows.Forms.CheckBox chk_PREFILLTIME2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button btn_HISTORY_T;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chk_PREFILLANYTIME;
        private System.Windows.Forms.Label lbl_LASTFILLEDFLASK;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.CheckBox chk_SEND_HISTORYEMAIL;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Button btn_GET_SAMPLE_PLAN;
        private System.Windows.Forms.Button btn_GET_NFILL2;
        private System.Windows.Forms.Button btn_LOAD_SITE_SETTINGS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txt_SITE_Mflush;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_SITE_COMNAME;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_SITESAMPLE_time;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txt_SITE_Sflush;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox chk_SITE_Eday;
        private System.Windows.Forms.CheckBox chk_SITE_COMTRIGGER;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_LIM_4SF_samplefill;
        private System.Windows.Forms.TextBox txt_LIM_2MF_samplefill;
        private System.Windows.Forms.TextBox txt_LIM_1MFT;
        private System.Windows.Forms.TextBox txt_LIM_4SF_prefill;
        private System.Windows.Forms.TextBox txt_LIM_3DMF;
        private System.Windows.Forms.TextBox txt_LIM_7MFP;
        private System.Windows.Forms.TextBox txt_LIM_6MFT;
        private System.Windows.Forms.TextBox txt_LIM_5DSF;
        private System.Windows.Forms.TextBox txt_LIM_2MF_prefill;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage chk_F5;
        private System.Windows.Forms.Label lbl_DOY_LASTSAMPLE;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
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
        private System.Windows.Forms.Label lbl_alt12;
        private System.Windows.Forms.CheckBox chk_F12;
        private System.Windows.Forms.Label lbl_alt11;
        private System.Windows.Forms.CheckBox chk_F4;
        private System.Windows.Forms.Label lbl_alt10;
        private System.Windows.Forms.CheckBox chk_F11;
        private System.Windows.Forms.Label lbl_alt9;
        private System.Windows.Forms.CheckBox chk_F3;
        private System.Windows.Forms.Label lbl_alt8;
        private System.Windows.Forms.CheckBox chk_F10;
        private System.Windows.Forms.Label lbl_alt7;
        private System.Windows.Forms.CheckBox chk_F9;
        private System.Windows.Forms.Label lbl_alt6;
        private System.Windows.Forms.CheckBox chk_F1;
        private System.Windows.Forms.Label lbl_alt5;
        private System.Windows.Forms.CheckBox chk_F8;
        private System.Windows.Forms.Label lbl_alt4;
        private System.Windows.Forms.CheckBox chk_F7;
        private System.Windows.Forms.Label lbl_alt3;
        private System.Windows.Forms.CheckBox chk_F6;
        private System.Windows.Forms.Label lbl_alt2;
        private System.Windows.Forms.CheckBox chk_F5x;
        private System.Windows.Forms.Label lbl_alt1;
        private System.Windows.Forms.CheckBox chk_F2;
        private System.Windows.Forms.Label lbl_t1;
        private System.Windows.Forms.Label lbl_d1;
        private System.Windows.Forms.Label lbl_t2;
        private System.Windows.Forms.Label lbl_t3;
        private System.Windows.Forms.Label lbl_t4;
        private System.Windows.Forms.Label lbl_t5;
        private System.Windows.Forms.Label lbl_t6;
        private System.Windows.Forms.Label lbl_t7;
        private System.Windows.Forms.Label lbl_t8;
        private System.Windows.Forms.Label lbl_t9;
        private System.Windows.Forms.Label lbl_t10;
        private System.Windows.Forms.Label lbl_t11;
        private System.Windows.Forms.Label lbl_t12;
        private System.Windows.Forms.Label lbl_d2;
        private System.Windows.Forms.Label lbl_d3;
        private System.Windows.Forms.Label lbl_d4;
        private System.Windows.Forms.Label lbl_d5;
        private System.Windows.Forms.Label lbl_d6;
        private System.Windows.Forms.Label lbl_d7;
        private System.Windows.Forms.Label lbl_d9;
        private System.Windows.Forms.Label lbl_d10;
        private System.Windows.Forms.Label lbl_d11;
        private System.Windows.Forms.Label lbl_d12;
        private System.Windows.Forms.Label lbl_d8;
        private System.Windows.Forms.Label lbl_PREFILL_COUNT;
        private System.Windows.Forms.Label lbl_EXECUTINGSEQUENCE;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btn_WRITE_PLAN;
        private System.Windows.Forms.Button btn_SAMPLE_PLAN;
        private System.Windows.Forms.Button btn_SAMP_FILL_LIMITS;
        private System.Windows.Forms.Button btn_MANUAL_SAMPLE;
        private System.Windows.Forms.Button btn_GET_HISTORY;
        private System.Windows.Forms.Button btn_PREFILL_LIMITS;
        private System.Windows.Forms.Button btn_FIND_SAMPLE_ADD;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_ALTADD1;
        private System.Windows.Forms.TextBox txt_ALTADD2;
        private System.Windows.Forms.TextBox txt_SAMPADD2;
        private System.Windows.Forms.TextBox txt_SAMPADD1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_NOTIFY;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txt_PCPNUMBER;
        private System.Windows.Forms.TextBox txt_INSTALLNOTES;
        private System.Windows.Forms.TextBox txt_INITIALS;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbn_leaktestyes;
        private System.Windows.Forms.RadioButton rbn_leaktestno;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button btn_SEND_NEWPFP_EMAIL;
        private System.Windows.Forms.Label lbl_PFPNUMBER;
        private System.Windows.Forms.Button btn_SYSTEMTEST;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btn_GETPFPNUMBER;
        private System.Windows.Forms.Button btn_END_LOGGING;
        private System.Windows.Forms.TabControl tb_SITE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_EMAILADD3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_EMAILADD2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_EMAILADD1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_SITE_CODE;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbo_TANK_ID_DESCRIPT;
        private System.Windows.Forms.Button btn_EMAIL_TANK_CHANGE;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_NEWTANK;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_OLDTANK;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txt_TANKCHANGEPERSON;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_CLEAR_TANK_CHANGE;
        private System.Windows.Forms.Label lbl_TANKCHANGEEMAILMSG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_NEXTSAMPLE;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txt_EMAILADD4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Button btn_EXECUTE_PREFILL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GETDATETIME;
        private System.Windows.Forms.TextBox txt_TANKCHANGEDATETIME;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btn_HISTORY_E;
        private System.Windows.Forms.Label lbl_StartupCounter;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button btn_testfindmwosample;
        private System.Windows.Forms.TextBox txt_DELAYTIMEAFTERPREFILL;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txt_PFEACHSAMPLE;
        private System.Windows.Forms.TextBox txt_PFASYSTEST;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
    }
}

