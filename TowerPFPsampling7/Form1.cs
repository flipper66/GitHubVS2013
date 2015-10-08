using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;


namespace WindowsFormsApplication1
{
    public partial class frm_TOWER_PFP : Form
    {
        Boolean[] FLASKSAMPLED = new Boolean[13];
        Boolean bool_Monitor_Checked;
        Boolean bool_GETPFPNUMBER;
        Boolean bool_GETHISTORY_E;
        Boolean bool_GETHISTORY_T;
        Boolean bool_GETSAMPLEPLAN;
        Boolean bool_FINDSAMPLEPLANADD;
        Boolean bool_PREFILLLIMITS;
        Boolean bool_MANUALSAMPLE;
        Boolean bool_SAMPLELIMITS;
        Boolean bool_WRITESAMPLEPLANADD;
        Boolean bool_ENDLOGGING;
        Boolean bool_SYSTEMTEST;
        Boolean bool_EXECUTINGPREFILLSEQUENCE;
        Boolean bool_EXECUTEPREFILLNEEDED;
        Boolean bool_EXECUTEPREFILL;

        int[] SamplePlanAltitude = new int[13];
        int[] DaysIntoYearSample = new int[13];
        int[] ALTITUDEADD = new int[2];
        int[] SAMPLEADD = new int[2];

        int CMDcount = 0;
        int TIMER4count = 0;
        int TIMER5count = 0;
        int STARTUPcounter_Seconds = 0;

        String RxString1;
        String TxString1;
        string flask2fill;
        string sEMAILMESSAGE;
        string TIMESTAMP;
        string[] PFPCMDs = new string[100];
        string sLASTHISTORY;
        string Site_Settings_String;
        DateTime dt_UTCNOWTIME;

        private StreamWriter PFPdata;
        private StreamWriter PFPprefillinfo;
        private StreamWriter PFPhistoryFile;

        public frm_TOWER_PFP()
        {

            InitializeComponent();
            PFPdata = new StreamWriter(new FileStream(@"C:\a\PFPserialdata.txt", FileMode.Append));
            PFPprefillinfo = new StreamWriter(new FileStream(@"C:\a\PFPprefillinformation.txt", FileMode.Append));
            PFPhistoryFile = new StreamWriter(new FileStream(@"C:\a\PFPhistory.txt", FileMode.Create));

            btn_NEWPFP_Click(null, null);
            btnOpenCom_Click(null, null);
            timer7.Interval = 60000;
            //timer7.Start();
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false && lbl_SITE_CODE.Text != "SNP")
            {
                serialPort1.PortName = txt_COM_NAME.Text;
                serialPort1.Open();
                lbl_COM_PORT_OPEN.Text = "IS OPEN";
                lbl_COM_PORT_OPEN.ForeColor = Color.Green;
                btnOpenCom.BackColor = SystemColors.Control;
            }
            chk_MONITOR_PFP.Checked = true;
        }
        private void btnCloseCom_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                chk_MONITOR_PFP.Checked = false;
                serialPort1.Close();
                lbl_COM_PORT_OPEN.Text = "NOT OPEN";
                lbl_COM_PORT_OPEN.ForeColor = Color.Red;
            }
        }
        private void btn_READ_COM_Click(object sender, EventArgs e)
        {
            RxString1 = serialPort1.ReadExisting();
            if (RxString1.Contains("starting sample") | RxString1.Contains("sample done"))
            {
                PFPprefillinfo.WriteLine(TIMESTAMP + RxString1.Substring(0, 50));
                PFPprefillinfo.Flush();

            }
            if (chk_SAVE_TO_FILE.Checked == true)
            {
                PFPdata.WriteLine(TIMESTAMP + RxString1);
                PFPdata.Flush();
            }
            int x = txt_PFP_TEXT.TextLength;
            txt_PFP_TEXT.Text = txt_PFP_TEXT.Text + RxString1;
        }
        private void btnSendText2PFP_Click(object sender, EventArgs e)
        {
            TxString1 = txt_TXT2PFP.Text + "\r\n";
            serialPort1.Write(TxString1);
            txt_TXT2PFP.Text = "";
        }

        private void btn_MANUAL_SAMPLE_Click(object sender, EventArgs e)
        {
            bool_MANUALSAMPLE = true;
            if (chk_F12.Checked == false)
            {
                PFPCMDs[1] = "q_n300";
                PFPCMDs[2] = "q_n300";
                PFPCMDs[3] = "m_n300";
                PFPCMDs[4] = "n_n400";
                PFPCMDs[5] = "y_n300";
                chk_MONITOR_PFP.Checked = true;
                CMDcount = 0;
                PFPprefillinfo.WriteLine(TIMESTAMP + "(UTC) MANUAL PREFILL SAMPLE STARTED  ");
                PFPprefillinfo.Flush();
                timer1.Start();
            }
            else
            {
                txt_PFP_TEXT.Text = "ALL FLASKS FULL.  RE-CHECK HISTORY. OR SET FLASK 2 FILL TO A NUMBER";
            }
        }


        private void txt_MANUAL_FNUMBER_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EXECUTE_CMDS_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            timer1.Start();

        }



        private void chk_MONITOR_PFP_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MONITOR_PFP.Checked == true)
            {
                timer2.Interval = Convert.ToInt32(txt_MONITOR_FREQUENCY.Text);
                timer2.Start();
            }
            else
            {
                timer2.Stop();
            }
        }

        private void btn_CLEAR_SCREEN_Click(object sender, EventArgs e)
        {
            txt_PFP_TEXT.Text = "";
        }

        private void btn_GET_HISTORY_Click(object sender, EventArgs e)
        {
            timer5.Start(); // checks the history_e and history_t
        }

        private void btn_GET_HISTORY_E_Click(object sender, EventArgs e)
        {
            PFPCMDs[1] = "q_n300";
            PFPCMDs[2] = "q_n300";
            PFPCMDs[3] = "h_n300";
            PFPCMDs[4] = "e_c1500";
            PFPCMDs[5] = "q_n400";
            bool_GETHISTORY_E = true;
            btn_GET_HISTORY.BackColor = Color.LightGreen;
            timer1.Start();
        }

        private void GET_NFILL_T(object sender, EventArgs e)
        {
            Console.WriteLine("get_nfill_t");
            dt_UTCNOWTIME = DateTime.UtcNow;
            //int intDAYSBETWEENSAMPLES;
            string nowyear = dt_UTCNOWTIME.Year.ToString();
            string lastyear =  Convert.ToString(Convert.ToInt32(nowyear) - 1);
            Console.WriteLine(nowyear);
            Console.WriteLine(lastyear);

            string[] FLSKDATE = new string[13];
            string[] FLSKTIME = new string[13];
            string[] FLSKTIME2 = new string[13];
            flask2fill = null;                          // PARSE HISTORY INTO SECTIONS OF STRING BY FLASK NUMBER
            int[] HISTORYINDEX = new int[14];           // HISTORY INDEX IS THE INDICIES OF THE START FOR EACH PFP
            string PFPHISTORY = txt_PFP_TEXT.Text;
            Console.WriteLine(PFPHISTORY);
            sLASTHISTORY = PFPHISTORY;
            PFPhistoryFile.Write(lbl_SITE_CODE.Text + " " + lbl_PFPNUMBER.Text + " " + PFPHISTORY);
            PFPhistoryFile.Flush();
            int HISTORYLEN = PFPHISTORY.Length;
            for (int iFLASK = 1; iFLASK < 13; iFLASK++)
            {
                for (int I = 1; I < HISTORYLEN; I++)
                {
                    String ISTRING = "  " + Convert.ToString(iFLASK) + " ";
                    HISTORYINDEX[iFLASK] = PFPHISTORY.IndexOf(ISTRING); // history index is the index of the start of each
                    // line in the pfp history file
                }
            }
            HISTORYINDEX[13] = HISTORYLEN;
            for (int i2 = 1; i2 < 13; i2++) // loop through 12 "sample" and use number of dashes to determine if sampled
            {
                int istart = HISTORYINDEX[i2];
                int iend = HISTORYINDEX[i2 + 1];
                int ilen = iend - istart;
                string tHISTORY = PFPHISTORY.Substring(istart, ilen);
                string tHISTORY_NODASH = tHISTORY.Replace("--", "");
                int nDASH = tHISTORY.Length - tHISTORY_NODASH.Length;
                Console.WriteLine(nDASH);
                int t1thisyear = tHISTORY.IndexOf(lastyear);
                int t1lastyear = tHISTORY.IndexOf(nowyear);
                int t1 = t1lastyear + t1thisyear + 1;
                Console.WriteLine(t1lastyear);
                Console.WriteLine(t1thisyear);
                Console.WriteLine(t1);

                int t2 = tHISTORY.IndexOf(":");
                if (t1 > 2) // the flask sample has a start date/time
                {                                                     // this is a valid flask sample
                    FLSKDATE[i2] = tHISTORY.Substring(t1 + 5, 5);
                    DaysIntoYearSample[i2] = Convert.ToInt32((Convert.ToDateTime(tHISTORY.Substring(t1, 10))).DayOfYear);
                    FLSKTIME[i2] = tHISTORY.Substring(t2 - 2, 5);
                    FLSKTIME2[i2] = tHISTORY.Substring(t2 + 21, 5);
                    //lbl_LASTFILLEDFLASK.Text = "FLASK " + Convert.ToString(i2).Trim();
                }
                else
                {                                          // this is not a flask sample
                    FLSKDATE[i2] = "--";
                    FLSKTIME[i2] = "--";
                    FLSKTIME2[i2] = "--";
                    DaysIntoYearSample[i2] = 0;
                }

                if (nDASH > 8)
                {
                    //FLASKSAMPLED[i2] = false;
                    DaysIntoYearSample[i2] = 0;
                    if (flask2fill == null)
                    {
                        flask2fill = Convert.ToString(i2); // flask to fill is the first non-filled flask
                    }
                }
                else // this is sampled flask, but may not be successfully sampled
                {
                    //FLASKSAMPLED[i2] = true;
                    //flasksfilledcount++;
                }
            }

            funcSHOWFLASKSFILLED(null, null);
            lbl_d1.Text = FLSKDATE[1];
            lbl_t1.Text = FLSKTIME[1];
            lbl_tf1.Text = FLSKTIME2[1];
            lbl_d2.Text = FLSKDATE[2];
            lbl_t2.Text = FLSKTIME[2];
            lbl_tf2.Text = FLSKTIME2[2];
            lbl_d3.Text = FLSKDATE[3];
            lbl_t3.Text = FLSKTIME[3];
            lbl_tf3.Text = FLSKTIME2[3];
            lbl_d4.Text = FLSKDATE[4];
            lbl_t4.Text = FLSKTIME[4];
            lbl_tf4.Text = FLSKTIME2[4];
            lbl_d5.Text = FLSKDATE[5];
            lbl_t5.Text = FLSKTIME[5];
            lbl_tf5.Text = FLSKTIME2[5];
            lbl_d6.Text = FLSKDATE[6];
            lbl_t6.Text = FLSKTIME[6];
            lbl_tf6.Text = FLSKTIME2[6];
            lbl_d7.Text = FLSKDATE[7];
            lbl_t7.Text = FLSKTIME[7];
            lbl_tf7.Text = FLSKTIME2[7];
            lbl_d8.Text = FLSKDATE[8];
            lbl_t8.Text = FLSKTIME[8];
            lbl_tf8.Text = FLSKTIME2[8];
            lbl_d9.Text = FLSKDATE[9];
            lbl_t9.Text = FLSKTIME[9];
            lbl_tf9.Text = FLSKTIME2[9];
            lbl_d10.Text = FLSKDATE[10];
            lbl_t10.Text = FLSKTIME[10];
            lbl_tf10.Text = FLSKTIME2[10];
            lbl_d11.Text = FLSKDATE[11];
            lbl_t11.Text = FLSKTIME[11];
            lbl_tf11.Text = FLSKTIME2[11];
            lbl_d12.Text = FLSKDATE[12];
            lbl_t12.Text = FLSKTIME[12];
            lbl_tf12.Text = FLSKTIME2[12];
            int DOY_LASTSAMPLE = DaysIntoYearSample.Max();
            lbl_DOY_LASTSAMPLE.Text = Convert.ToString(DOY_LASTSAMPLE);

        }

        private void GET_NFILL_E(object sender, EventArgs e)
        {
            Console.WriteLine("get_nfill_e");

            flask2fill = null;                          // PARSE HISTORY INTO SECTIONS OF STRING BY FLASK NUMBER
            int[] HISTORYINDEX = new int[14];           // HISTORY INDEX IS THE INDICIES OF THE START FOR EACH PFP
            int flasksfilledcount = 0;
            string PFPHISTORY = txt_PFP_TEXT.Text;
            Console.WriteLine(PFPHISTORY);
            int HISTORYLEN = PFPHISTORY.Length;
            for (int iFLASK = 1; iFLASK < 13; iFLASK++)
            {
                    String ISTRING = " " + Convert.ToString(iFLASK) + " ";
                    HISTORYINDEX[iFLASK] = PFPHISTORY.IndexOf(ISTRING); // history index is the index of the start of each
                    // line in the pfp history file
                    Console.WriteLine(ISTRING);
                   // Console.WriteLine(HISTORYINDEX[iFLASK]};
            }
            HISTORYINDEX[13] = HISTORYLEN;
            for (int i2 = 1; i2 < 13; i2++) // loop through 12 "sample" and use number of dashes to determine if sampled
            {
                int istart = HISTORYINDEX[i2];
                int iend = HISTORYINDEX[i2 + 1];
                int ilen = iend - istart;
                string eHISTORY = PFPHISTORY.Substring(istart, ilen);
                int t1 = eHISTORY.IndexOf("taken");
                int t2 = eHISTORY.IndexOf("aborted");
                int t3 = eHISTORY.IndexOf("manual");
                if (t1 > 1 | t2 > 1 | t3 > 1) // the flask attempted a sample and was taken or aborted
                {
                    lbl_LASTFILLEDFLASK.Text = "FLASK " + Convert.ToString(i2).Trim();
                    FLASKSAMPLED[i2] = true;
                    flasksfilledcount++;
                }
                else
                {
                    FLASKSAMPLED[i2] = false;
                }

            }
            lbl_NEXTSAMPLE.Text = Convert.ToString(flasksfilledcount + 1).Trim();
            funcSHOWFLASKSFILLED(null, null);
           

        }
        private void funcSHOWFLASKSFILLED(object sender, EventArgs e)
        {
            chk_F1.Checked = FLASKSAMPLED[1];
            chk_F2.Checked = FLASKSAMPLED[2];
            chk_F3.Checked = FLASKSAMPLED[3];
            chk_F4.Checked = FLASKSAMPLED[4];
            chk_F5x.Checked = FLASKSAMPLED[5];
            chk_F6.Checked = FLASKSAMPLED[6];
            chk_F7.Checked = FLASKSAMPLED[7];
            chk_F8.Checked = FLASKSAMPLED[8];
            chk_F9.Checked = FLASKSAMPLED[9];
            chk_F10.Checked = FLASKSAMPLED[10];
            chk_F11.Checked = FLASKSAMPLED[11];
            chk_F12.Checked = FLASKSAMPLED[12];
        }

        private void btn_PREFILL_LIMITS_Click(object sender, EventArgs e)
        {
            btn_PREFILL_LIMITS.BackColor = Color.LightGreen;
            bool_PREFILLLIMITS = true;
            PFPCMDs[1] = "q_c300"; // quit to get to main menu
            PFPCMDs[2] = "q_n300"; // quit to get to main menu
            PFPCMDs[3] = "s_n300"; // set up
            PFPCMDs[4] = "l_n300"; // limits
            PFPCMDs[5] = "s_n500"; // sampling limits
            PFPCMDs[6] = txt_LIM_1MFT.Text + "_n500"; // max flush time
            PFPCMDs[7] = txt_LIM_2MF_prefill.Text + "_n500"; // manifold flush volume
            PFPCMDs[8] = txt_LIM_4SF_prefill.Text + "_n500"; // sample flush volume
            PFPCMDs[9] = txt_LIM_2MF_prefill.Text + "_n500";// manifold prefill flush volume
            PFPCMDs[10] = txt_LIM_2MF_samplefill.Text + "_n500";// sample prefill flush volume
            PFPCMDs[11] = txt_DELAYTIMEAFTERPREFILL.Text + "_n500";   //  pause after prefill
            PFPCMDs[12] = txt_PFASYSTEST.Text + "_n500"; // prefill all samples after system test
            PFPCMDs[13] = txt_PFEACHSAMPLE.Text + "_n500"; // prefull each sample before sampling
            PFPCMDs[14] = txt_LIM_3DMF.Text + "_n500"; //default manifold flush volume(old), manifold flush volume w/o pcp(new)
            PFPCMDs[15] = txt_LIM_5DSF.Text + "_n500"; // default sqample flush time(old), manifold flush time w/o PCP(new)
            PFPCMDs[16] = txt_LIM_6MFT.Text + "_n500"; //max fill time 
            PFPCMDs[17] = txt_LIM_7MFP.Text + "_n500"; // min fill pressure
            PFPCMDs[18] = "q_n300";
            PFPCMDs[19] = "q_n300";
            timer1.Start();
        }

        private void btn_SAMP_FILL_LIMITS_Click(object sender, EventArgs e)
        {
            bool_SAMPLELIMITS = true;
            btn_SAMP_FILL_LIMITS.BackColor = Color.LightGreen;
            PFPCMDs[1] = "q_c300"; // quit to get to main menu
            PFPCMDs[2] = "q_n300"; // quit to get to main menu
            PFPCMDs[3] = "s_n300"; // set up
            PFPCMDs[4] = "l_n300"; // limits
            PFPCMDs[5] = "s_n500"; // sampling limits
            PFPCMDs[6] = txt_LIM_1MFT.Text + "_n500";
            PFPCMDs[7] = txt_LIM_2MF_samplefill.Text + "_n500";
            PFPCMDs[8] = txt_LIM_3DMF.Text + "_n500";
            PFPCMDs[9] = txt_LIM_4SF_samplefill.Text + "_n500";
            PFPCMDs[10] = txt_LIM_5DSF.Text + "_n500";
            PFPCMDs[11] = txt_LIM_6MFT.Text + "_n500";
            PFPCMDs[12] = txt_LIM_7MFP.Text + "_n500";
            PFPCMDs[13] = "q_n300";
            PFPCMDs[14] = "q_n300";
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e) // timer 1 is for stepping through writing commands to the PFP
        {
            txt_PFP_TEXT.ForeColor = Color.Black;
            if (chk_MONITOR_PFP.Checked == true && bool_SYSTEMTEST == false)
            {
                chk_MONITOR_PFP.Checked = false;
                bool_Monitor_Checked = true;
            }
            if (serialPort1.IsOpen == false)
            {
                txt_PFP_TEXT.ForeColor = Color.Red;
                txt_PFP_TEXT.Text = "COM PORT NOT OPEN, click 6. OPEN COMM' \r\nthen try again";
                for (int I = 1; I < 100; I++)
                {
                    PFPCMDs[I] = null;               // RESET COMMANDS TO NULL
                    CMDcount = 0;
                }
                timer1.Stop();
                return;
            }


            string PFPCMDprevious = PFPCMDs[CMDcount].Substring(0, 1);
            RxString1 = serialPort1.ReadExisting();
            int RXLEN = RxString1.Length;
            // REPORT SPECIAL STRINGS TO THE PREFILL REPORT FILE
            if (RxString1.Contains("starting sample") | RxString1.Contains("sample done") | RxString1.Contains("Pressu"))
            {
                if (RXLEN > 50)
                {
                    PFPprefillinfo.WriteLine(TIMESTAMP + RxString1.Substring(0, 50));
                    PFPprefillinfo.Flush();
                }
                else
                {
                    PFPprefillinfo.WriteLine(TIMESTAMP + RxString1.Substring(0, RXLEN));
                    PFPprefillinfo.Flush();
                }
                if (RxString1.Contains("sample done") == true)
                {
                    PFPCMDs[1] = "Q_n300";
                    timer1.Start();
                }

            }
            // REPORT ALL NON NULL STRINGS TO THE FULL DATA FILE
            if (chk_SAVE_TO_FILE.Checked == true && RXLEN > 0)
            {
                PFPdata.WriteLine(TIMESTAMP + RxString1);
                PFPdata.Flush();
            }

            txt_PFP_TEXT.Text = txt_PFP_TEXT.Text + RxString1;
            CMDcount = CMDcount + 1;
            if (PFPCMDs[CMDcount] == null) // AFTER THE LAST COMMAND IN THE SEQUENCE HAS BEEN EXECTUETED
            {
                timer1.Stop();                   //STOP TIMER
                for (int I = 1; I < 100; I++)
                {
                    PFPCMDs[I] = null;               // RESET COMMANDS TO NULL
                    CMDcount = 0;
                }
                if (bool_Monitor_Checked == true)
                {
                    chk_MONITOR_PFP.Checked = true;    // IF MONITOR WAS CHECKED, RE-CHECK IT
                    bool_Monitor_Checked = false;
                }
                if (bool_GETPFPNUMBER == true)   // IF GET PFPNUMBER COMMANDS WERE EXECUTED, THEN EXTRACT THE PFP NUMBER FROM THE 
                {                                    // RETURN STRING
                    bool_GETPFPNUMBER = false;
                    string strHISTORYSN = txt_PFP_TEXT.Text;
                    lbl_PFPNUMBER.Text = strHISTORYSN.Substring(Convert.ToInt32(strHISTORYSN.IndexOf("Serial Number")) + 14, 4) + "-FP";
                    btn_GETPFPNUMBER.BackColor = SystemColors.Control;
                }
                if (bool_GETHISTORY_E == true) // IF GET HISTORY WAS EXECTUED, THEN EXTRACT THE HISTORY AND DISPLAY IT
                {
                    bool_GETHISTORY_E = false;
                    GET_NFILL_E(null, null);
                    btn_GET_HISTORY.BackColor = SystemColors.Control;
                }
                if (bool_GETHISTORY_T == true) // IF GET HISTORY WAS EXECTUED, THEN EXTRACT THE HISTORY AND DISPLAY IT
                {
                    bool_GETHISTORY_T = false;
                    GET_NFILL_T(null, null);
                    btn_GET_HISTORY.BackColor = SystemColors.Control;
                }
                if (bool_GETSAMPLEPLAN == true)  // IF GET SAMPLE PLAN WAS EXECUTED, THEN EXTRACT THE SAMPLE PLAN AND DISPLAY IT.
                {
                    bool_GETSAMPLEPLAN = false;
                    btn_GET_SAMPLE_PLAN_Click(null, null);
                    btn_SAMPLE_PLAN.BackColor = SystemColors.Control;
                }

                // **************************************************

                if (bool_FINDSAMPLEPLANADD == true)
                {
                    bool_FINDSAMPLEPLANADD = false;
                    btn_FIND_SAMPLE_ADD.BackColor = SystemColors.Control;
                }
                if (bool_PREFILLLIMITS == true)
                {
                    bool_PREFILLLIMITS = false;
                    btn_PREFILL_LIMITS.BackColor = SystemColors.Control;
                }
                if (bool_MANUALSAMPLE == true)
                {
                    bool_MANUALSAMPLE = false;
                    btn_MANUAL_SAMPLE.BackColor = SystemColors.Control;
                }
                if (bool_SAMPLELIMITS == true)
                {
                    bool_SAMPLELIMITS = false;
                    btn_SAMP_FILL_LIMITS.BackColor = SystemColors.Control;
                }
                if (bool_WRITESAMPLEPLANADD == true)
                {
                    bool_WRITESAMPLEPLANADD = false;
                    btn_WRITE_PLAN.BackColor = SystemColors.Control;
                }
                if (bool_ENDLOGGING == true)
                {
                    bool_ENDLOGGING = false;
                    btn_END_LOGGING.BackColor = SystemColors.Control;
                }
                if (bool_GETPFPNUMBER == true)
                {
                    bool_GETPFPNUMBER = false;
                    btn_GETPFPNUMBER.BackColor = SystemColors.Control;
                }
                if (bool_SYSTEMTEST == true)
                {
                    bool_SYSTEMTEST = false;
                    btn_SYSTEMTEST.BackColor = SystemColors.Control;
                    chk_MONITOR_PFP.Checked = true;
                }

                // **********************************************
                return;
            }
            else // if not the last command in the sequence, then disect it into PFP command , clear or no clear, delay time
            {
                int index1 = PFPCMDs[CMDcount].IndexOf("_");
                string PFPCMD = PFPCMDs[CMDcount].Substring(0, index1);
                string CLRSCR = PFPCMDs[CMDcount].Substring(index1 + 1, 1);
                string MSEC = PFPCMDs[CMDcount].Substring(index1 + 2);
                timer1.Interval = Convert.ToInt32(MSEC);

                if (CLRSCR == "c")
                {
                    txt_PFP_TEXT.Text = ""; // clear the screen
                }
                if (PFPCMD != "")
                {
                    serialPort1.Write(PFPCMD + "\r");
                }
            }

        }
        private void timer2_Tick(object sender, EventArgs e) // for reading serial data at regular intervals
        {
            if (serialPort1.IsOpen == false && lbl_SITE_CODE.Text != "SNP")
            {
                txt_PFP_TEXT.Text = "NEED TO OPEN COM PORT FIRST";
            }
            //if (TIMER4count != 0)
            //{
            //    PREFILLCOUNT++;
            //    lbl_PREFILL_COUNT.Text = Convert.ToString(PREFILLCOUNT);
            //}
            RxString1 = serialPort1.ReadExisting();

            int RXLEN = RxString1.Length;
            if (RxString1.Contains("starting sample") | RxString1.Contains("sample done") | RxString1.Contains("Pressu"))
            {
                if (RXLEN > 50)
                {
                    PFPprefillinfo.WriteLine(TIMESTAMP + RxString1.Substring(0, 50));
                    PFPprefillinfo.Flush();
                }
                else
                {
                    PFPprefillinfo.WriteLine(TIMESTAMP + RxString1.Substring(0, RXLEN));
                    PFPprefillinfo.Flush();
                }

            }

            if (RxString1.Contains("sample done"))
            {
                PFPCMDs[1] = "Q_n300";
                timer1.Start();
            }

            if (chk_SAVE_TO_FILE.Checked == true && RXLEN > 0)
            {
                //Console.WriteLine(RxString1);
                //Console.WriteLine(RXLEN);
                PFPdata.WriteLine(TIMESTAMP + RxString1);
                PFPdata.Flush();
            }
            string PFPTEXT;
            PFPTEXT = txt_PFP_TEXT.Text;
            char[] sep = { '\n' };
            string[] res = PFPTEXT.Split(sep);
            int PFPLINEFEEDCOUNT = res.Length;
            int PFPTEXTSTRINGLENGTH = PFPTEXT.Length;
            //if (PFPTEXTSTRINGLENGTH > 0)
            //{
            //    Console.WriteLine(Convert.ToString(PFPTEXTSTRINGLENGTH));
            //    Console.WriteLine(Convert.ToString(PFPLINEFEEDCOUNT));
            //}
            if (PFPLINEFEEDCOUNT < 38)
            {
                txt_PFP_TEXT.Text = txt_PFP_TEXT.Text + RxString1;
            }
            else
            {
                txt_PFP_TEXT.Text = RxString1;
            }
        }


        private void timer3_Tick(object sender, EventArgs e) // for the time clock and triggering a pre-sample and sample
        // and monitoring the seial port status and a history check.  This executes every second
        {
            if (STARTUPcounter_Seconds <= 100)// this only executes if startupcounter < 100
            {
                STARTUPcounter_Seconds++;
                if (STARTUPcounter_Seconds == 2)
                {
                    btn_GETPFPNUMBER_Click(null, null);
                }
                if (STARTUPcounter_Seconds == 8)
                {
                    btn_GET_HISTORY_Click(null, null);
                }
                if (STARTUPcounter_Seconds == 30 && lbl_SITE_CODE.Text == "MWO")// 
                {
                    timer7.Interval = 60000;
                    timer7.Start();
                }
                lbl_StartupCounter.Text = Convert.ToString(STARTUPcounter_Seconds);


            }


            dt_UTCNOWTIME = DateTime.UtcNow;

            int intDAYSBETWEENSAMPLES;
            string nowtime = dt_UTCNOWTIME.ToString("HH:mm:ss");
            TIMESTAMP = lbl_PFPNUMBER.Text + " " + dt_UTCNOWTIME.ToString("MM/dd/yy HH:mm:ss") + ":";
            lbl_UTC_TIME.Text = nowtime;
            if (lbl_SITE_CODE.Text == "SNP" && nowtime.Substring(3, 5) == "01:59")
            {
                EMAIL_SNP_BALED_FILE(null, null);
            }
            lbl_DOY.Text = Convert.ToString(dt_UTCNOWTIME.DayOfYear);
            string prefilltime = txt_PREFILLTIME.Text;
            string sampletime = txt_SAMPLE_TIME.Text;
            string sampletime2 = txt_SAMPLETIME2.Text;
            string prefilltime2 = txt_PREFILLTIME2.Text;
            string[] sampletimea = sampletime.Split(new char[] { ':' });
            string[] prefilltimea = prefilltime.Split(new char[] { ':' });
            string[] sampletime2a = sampletime2.Split(new char[] { ':' });
            string[] prefilltime2a = prefilltime2.Split(new char[] { ':' });
            string[] nowtimea = nowtime.Split(new char[] { ':' });
            Int32 nts = Convert.ToInt32(nowtimea[0]) * 3600 + Convert.ToInt32(nowtimea[1]) * 60 + Convert.ToInt32(nowtimea[2]);
            Int32 sts = Convert.ToInt32(sampletimea[0]) * 3600 + Convert.ToInt32(sampletimea[1]) * 60 + Convert.ToInt32(sampletimea[2]);
            Int32 sts2 = Convert.ToInt32(sampletime2a[0]) * 3600 + Convert.ToInt32(sampletime2a[1]) * 60 + Convert.ToInt32(sampletime2a[2]);
            
            
            //Console.WriteLine(nts);
            //Console.WriteLine(sts);

            if (bool_EXECUTINGPREFILLSEQUENCE)
            {
                lbl_PREFILL_COUNT.Text = Convert.ToString(Convert.ToInt32(lbl_PREFILL_COUNT.Text) + 1);
                if (Convert.ToInt32(lbl_PREFILL_COUNT.Text) > 400)
                {
                    bool_EXECUTINGPREFILLSEQUENCE = false;
                    TIMER4count = 0;
                    btn_SAMP_FILL_LIMITS.BackColor = SystemColors.Control;
                    lbl_PREFILL_COUNT.Text = "0";
                    lbl_PREFILL_COUNT.ForeColor = SystemColors.ControlText;
                    timer4.Interval = 6000;
                    chk_MONITOR_PFP.Checked = true;
                    txt_MONITOR_FREQUENCY.Text = "1000";
                    lbl_EXECUTINGSEQUENCE.Text = "if green, executing prefill sequence";
                    lbl_EXECUTINGSEQUENCE.BackColor = SystemColors.Control;// Color.LightGreen;
                    bool_EXECUTINGPREFILLSEQUENCE = false;
                    timer4.Stop();
                }

            }
            else
            {
                lbl_PREFILL_COUNT.Text = "0";
            }

            if (bool_EXECUTEPREFILLNEEDED == false)
            {
                btn_EXECUTE_PREFILL.Text = "13. EXECUTE PREFILL";
                btn_EXECUTE_PREFILL.BackColor = SystemColors.Control;
                bool_EXECUTEPREFILLNEEDED = true;
            }

            if (serialPort1.IsOpen == true)
            {
                lbl_COM_PORT_OPEN.ForeColor = Color.Green;
                lbl_COM_PORT_OPEN.Text = "IS OPEN";
            }
            else
            {
                lbl_COM_PORT_OPEN.ForeColor = Color.Red;
                lbl_COM_PORT_OPEN.Text = "NOT OPEN";
            }

            //
            if (nts == sts + 2400)// RECORD HISTORY FOR EMAIL MESSAGE IF 40 MINUTES AFTER SCHEDULED PFP FILL TIME
            {
                btn_HISTORY_T_Click(null, null); // GET HISTORY
            }
            if (nts == sts + 2408) // SEND EMAIL.
            {
                sEMAILMESSAGE = sEMAILMESSAGE + "Post Sample fill History (TIME)- " + lbl_SITE_CODE.Text + "\r\n" + lbl_PFPNUMBER.Text + "\r\n " + txt_PCPNUMBER.Text + "\r\n" + DateTime.Now.ToString("MM/dd/yy-HH:mm:ss tt") + "\r\n";
                sEMAILMESSAGE = sEMAILMESSAGE + txt_PFP_TEXT.Text + "\r\n\r\n";
            }

            if (nts == sts + 2410)// RECORD HISTORY FOR EMAIL MESSAGE IF 40 MINUTES AFTER SCHEDULED PFP FILL TIME
            {
                btn_HISTORY_E_Click(null, null); // GET HISTORY
            }
            if (nts == sts + 2418) // SEND EMAIL.
            {
                sEMAILMESSAGE = sEMAILMESSAGE + "Post Sample fill History (ERRORS)- " + lbl_SITE_CODE.Text + "\r\n" + lbl_PFPNUMBER.Text + "\r\n " + txt_PCPNUMBER.Text + "\r\n" + DateTime.Now.ToString("MM/dd/yy-HH:mm:ss tt") + "\r\n";
                sEMAILMESSAGE = sEMAILMESSAGE + txt_PFP_TEXT.Text + "\r\n\r\n";
                if (chk_SEND_HISTORYEMAIL.Checked == true)
                {
                    btn_SendEmail_Click(null, null);
                }
            }

            if (nts == sts + 2508)// RESET EMAIL MESSAGE
            {
                sEMAILMESSAGE = " ";
            }


            // step through the pre-fill steps if it is the time of day of a pre-fiil.
            if (prefilltimea[0] == nowtimea[0] && prefilltimea[1] == nowtimea[1] && prefilltimea[2] == nowtimea[2])
            {
                if (chk_PREFILLTIME.Checked == true)// this will complete the prefill
                {
                    bool_EXECUTEPREFILL = true;
                }
                if (chk_PREFILLTIME.Checked == false) // this will only find the manual sample next
                {
                    bool_EXECUTEPREFILL = false;
                }
                timer4.Start();// at the prefill time it will step through the first 5 steps to find this history and sample plan
            }
            if (prefilltime2a[0] == nowtimea[0] && prefilltime2a[1] == nowtimea[1] && prefilltime2a[2] == nowtimea[2])
            {
                if (chk_PREFILLTIME2.Checked == true)// this will complete the prefill
                {
                    bool_EXECUTEPREFILL = true;
                }
                if (chk_PREFILLTIME2.Checked == false) // this will only find the manual sample next
                {
                    bool_EXECUTEPREFILL = false;
                }
                timer4.Start();// at the prefill time it will step through the first 5 steps to find this history and sample plan
            }

            // TAKE A SAMPLE IF IT IS THE TIME OF DAY, AND IF IT IS THE CORRECT NUMBER OF DAYS SINCE THE LAST SAMPLE
            Boolean bool_SAMPLET1 = sampletimea[0] == nowtimea[0] && sampletimea[1] == nowtimea[1] && sampletimea[2] == nowtimea[2];
            Boolean bool_SAMPLET2 = sampletime2a[0] == nowtimea[0] && sampletime2a[1] == nowtimea[1] && sampletime2a[2] == nowtimea[2];

            if ((bool_SAMPLET1 | bool_SAMPLET2) && lbl_SITE_CODE.Text == "MWO")
            {

            }

            Boolean bool_SAMPLE1 = bool_SAMPLET1 && chk_SAMPLE_TIME.Checked == true;
            Boolean bool_SAMPLE2 = bool_SAMPLET2 && chk_SAMPLETIME2.Checked == true;

            if (bool_SAMPLE1 | bool_SAMPLE2)
            {
                if (rbtn_EVERYDAY.Checked == true)
                {
                    intDAYSBETWEENSAMPLES = 1;
                }
                else
                {
                    intDAYSBETWEENSAMPLES = 2;
                }
                // trigger a manual sample if it is the a day or every other day or it is the first sample.

                if ((Convert.ToInt32(dt_UTCNOWTIME.DayOfYear) >= DaysIntoYearSample.Max() + intDAYSBETWEENSAMPLES) | (!chk_F1.Checked) | (Convert.ToInt32(dt_UTCNOWTIME.DayOfYear) - DaysIntoYearSample.Max()) <= - 355)
                {
                    btn_MANUAL_SAMPLE_Click(null, null);
                    if (chk_LASTSAMPLE.Checked == true)
                    {
                        chk_SAMPLE_TIME.Checked = false;
                        //chk_PREFILLTIME.Checked = false;
                        chk_LASTSAMPLE.Checked = false;
                    }
                }
                if (lbl_SITE_CODE.Text == "MWO") // MWO doesn't need to wait until the next day to sample because
                { // it has a special sampling plan
                    btn_MANUAL_SAMPLE_Click(null, null);
                }


            }
        }

        private void timer4_Tick(object sender, EventArgs e) // for stepping through the pre-FILL at the prefill time of the day.
        {// this executes every day at the prefill time.  If prefill is not checked it only goes through step 5
            TIMER4count++;

            if (TIMER4count == 1)// get sample plan
            {
                Console.WriteLine("timer4count = 1");
                bool_EXECUTINGPREFILLSEQUENCE = true;
                lbl_EXECUTINGSEQUENCE.Text = "EXECUTING PREFILL SEQUENCE";
                lbl_EXECUTINGSEQUENCE.BackColor = Color.LightGreen;
                chk_MONITOR_PFP.Checked = false;
                lbl_PREFILL_COUNT.ForeColor = Color.Green;
                btn_SAMPLE_PLAN.BackColor = Color.LightGreen;
                btn_SAMPLE_PLAN_ClicK(null, null);
                //txt_MONITOR_FREQUENCY.Text = "2000";
                timer4.Interval = 8000;
            }

            if (TIMER4count == 2)// get history to check if full
            {
                Console.WriteLine("timer4count = 2");
                btn_SAMPLE_PLAN.BackColor = SystemColors.Control;
                btn_GET_HISTORY.BackColor = Color.LightGreen;
                btn_GET_HISTORY_Click(null, null);
                timer4.Interval = 16000;
            }

            if (TIMER4count == 3)// if package full, then abort pre-sample 
            {
                Console.WriteLine("timer4count = 3");
                if (chk_F12.Checked == true) //   txt_MANUAL_FNUMBER.Text == "99")
                {
                    btn_GET_HISTORY.BackColor = SystemColors.Control;
                    btn_GET_NFILL2.BackColor = SystemColors.Control;
                    txt_PFP_TEXT.Text = txt_PFP_TEXT.Text + "FLASK PACKAGE FULL ABORT PRE-SAMPLE";
                    chk_PREFILLTIME.Checked = false;
                    chk_SAMPLE_TIME.Checked = false;
                    timer4.Stop();
                }
            }
            if (TIMER4count == 4) // find sample(s) to add (before prefill (this is the first empty flask and its altitude partner (if any)))
            {
                Console.WriteLine("timer4count = 4");
                btn_GET_HISTORY.BackColor = SystemColors.Control;
                btn_GET_NFILL2.BackColor = SystemColors.Control;
                btn_FIND_SAMPLE_ADD.BackColor = Color.LightGreen;
                btn_FIND_SAMPLE_ADD_Click(null, null);
                timer4.Interval = 2000;
                //chk_MONITOR_PFP.Checked = true;
            }
            if (TIMER4count == 5)// set prefill limits
            {
                if (bool_EXECUTEPREFILL == true)
                {
                    btn_FIND_SAMPLE_ADD.BackColor = SystemColors.Control;
                    btn_PREFILL_LIMITS.BackColor = Color.LightGreen;
                    btn_PREFILL_LIMITS_Click(null, null);
                    timer4.Interval = 13000;
                }
                if (bool_EXECUTEPREFILL == false)
                {
                    Console.WriteLine("I am here");
                    if (lbl_SITE_CODE.Text == "MWO")
                    {
                        FIND_MWO_SAMPLE(null, null);
                    }
                    if (lbl_SITE_CODE.Text == "MBO")
                    {
                        FIND_MBO_SAMPLE(null, null);
                    }
                    lbl_EXECUTINGSEQUENCE.Text = "if green, executing prefill sequence";
                    lbl_EXECUTINGSEQUENCE.BackColor = SystemColors.Control;// Color.LightGreen;
                    bool_EXECUTINGPREFILLSEQUENCE = false;
                    btn_EXECUTE_PREFILL.Text = "13. EXECUTE PREFILL";
                    btn_EXECUTE_PREFILL.BackColor = SystemColors.Control;
                    TIMER4count = 0;
                    bool_EXECUTINGPREFILLSEQUENCE = false;
                    btn_FIND_SAMPLE_ADD.BackColor = SystemColors.Control;
                    btn_EXECUTE_PREFILL.BackColor = SystemColors.Control;
                    timer4.Stop();
                }
            }
            if (TIMER4count == 6)// take manual sample next (prefill) allow 5 minutes for prefill
            {
                btn_PREFILL_LIMITS.BackColor = SystemColors.Control;
                btn_MANUAL_SAMPLE.BackColor = Color.LightGreen;
                btn_MANUAL_SAMPLE_Click(null, null);
                chk_MONITOR_PFP.Checked = true;
                txt_MONITOR_FREQUENCY.Text = "2000";
                timer4.Interval = 300000;
            }

            if (TIMER4count == 7)// get post prefill history
            {
                btn_MANUAL_SAMPLE.BackColor = SystemColors.Control;
                btn_GET_HISTORY.BackColor = Color.LightGreen;
                btn_GET_HISTORY_Click(null, null);
                timer4.Interval = 8000;
            }
            // **************************** re-program... overwrite prefill sample (just filled) 
            if (TIMER4count == 8)// re-set the pre-sampled flask
            {
                sEMAILMESSAGE = "Post Prefill History - " + lbl_SITE_CODE.Text + "\r\n" + lbl_PFPNUMBER.Text + "\r\n " + txt_PCPNUMBER.Text + "\r\n" + DateTime.Now.ToString("MM/dd/yy-HH:mm:ss tt") + "\r\n";
                sEMAILMESSAGE = sEMAILMESSAGE + txt_PFP_TEXT.Text + "\r\n\r\n";
                btn_GET_HISTORY.BackColor = SystemColors.Control;
                btn_WRITE_PLAN.BackColor = Color.LightGreen;
                btn_WRITE_PLAN_Click(null, null);
                timer4.Interval = 13000;
                chk_MONITOR_PFP.Checked = false;
            }
            if (TIMER4count == 9)// set sample limits for next sample
            {
                btn_WRITE_PLAN.BackColor = SystemColors.Control;
                btn_SAMP_FILL_LIMITS.BackColor = Color.LightGreen;
                btn_SAMP_FILL_LIMITS_Click(null, null);
                timer4.Interval = 13000;
            }
            if (TIMER4count == 10) // quit to main menu
            {
                btn_SAMP_FILL_LIMITS.BackColor = SystemColors.Control;
                btn_GET_HISTORY.BackColor = Color.LightGreen;
                btn_GET_HISTORY_Click(null, null);
                timer4.Interval = 8000;
            }
            if (TIMER4count == 11)// stop and reset timer
            {
                sEMAILMESSAGE = sEMAILMESSAGE + "Post Prefill History 2 - " + lbl_SITE_CODE.Text + "\r\n" + lbl_PFPNUMBER.Text + "\r\n " + txt_PCPNUMBER.Text + "\r\n" + DateTime.Now.ToString("MM/dd/yy-HH:mm:ss tt") + "\r\n";
                sEMAILMESSAGE = sEMAILMESSAGE + txt_PFP_TEXT.Text + "\r\n\r\n";
                TIMER4count = 0;
                btn_SAMP_FILL_LIMITS.BackColor = SystemColors.Control;
                lbl_PREFILL_COUNT.Text = "0";
                lbl_PREFILL_COUNT.ForeColor = SystemColors.ControlText;
                timer4.Interval = 6000;
                chk_MONITOR_PFP.Checked = true;
                txt_MONITOR_FREQUENCY.Text = "1000";
                if (txt_SAMPADD1.Text == "12" | txt_SAMPADD2.Text == "12")
                {
                    chk_SAMPLE_TIME.Checked = true;
                    chk_LASTSAMPLE.Checked = true;
                }
                lbl_EXECUTINGSEQUENCE.Text = "if green, executing prefill sequence";
                lbl_EXECUTINGSEQUENCE.BackColor = SystemColors.Control;// Color.LightGreen;
                bool_EXECUTINGPREFILLSEQUENCE = false;
                btn_EXECUTE_PREFILL.Text = "13. EXECUTE PREFILL";
                btn_EXECUTE_PREFILL.BackColor = SystemColors.Control;
                timer4.Stop();
            }

        }

        private void btn_QUIT_TO_MAIN_Click(object sender, EventArgs e)
        {
            PFPCMDs[1] = "q_c300";
            PFPCMDs[2] = "q_n300";
            timer1.Start();
        }

        private void btn_LOAD_SITE_SETTINGS_Click(object sender, EventArgs e) // SET SPECIFIC SITE LIMITS WHEN CLICKED
        {

        }



        private void btn_SAMPLE_PLAN_ClicK(object sender, EventArgs e)
        {
            PFPCMDs[1] = "q_n300";
            PFPCMDs[2] = "q_n300";
            PFPCMDs[3] = "s_n300";
            PFPCMDs[4] = "s_n300";
            PFPCMDs[5] = "l_c2000";
            PFPCMDs[6] = "q_n300";
            PFPCMDs[7] = "q_n300";
            bool_GETSAMPLEPLAN = true;
            btn_SAMPLE_PLAN.BackColor = Color.LightGreen;
            timer1.Start();
        }

        private void btn_GET_SAMPLE_PLAN_Click(object sender, EventArgs e)
        {
            int[] SAMPLEPLANINDEX = new int[14];
            string PFPSAMPLEPLAN = txt_PFP_TEXT.Text;
            int PFPSAMPLELEN = PFPSAMPLEPLAN.Length;
            for (int iFLASK = 1; iFLASK < 13; iFLASK++)
            {
                for (int I = 1; I < PFPSAMPLELEN; I++)
                {
                    String ISTRING = Convert.ToString(iFLASK);
                    SAMPLEPLANINDEX[iFLASK] = PFPSAMPLEPLAN.IndexOf(ISTRING);
                }
            }
            SAMPLEPLANINDEX[13] = PFPSAMPLELEN;
            for (int i2 = 1; i2 < 13; i2++)
            {
                int istart = SAMPLEPLANINDEX[i2];
                int iend = SAMPLEPLANINDEX[i2 + 1];
                int ilen = iend - istart;
                string eSAMPLEPLAN = PFPSAMPLEPLAN.Substring(istart, ilen);
                SamplePlanAltitude[i2] = Convert.ToInt32(eSAMPLEPLAN.Substring(16, 4));
                //console.writeline(Convert.ToString(SamplePlanAltitude[i2]));
            }
            lbl_alt1.Text = Convert.ToString(SamplePlanAltitude[1]);
            lbl_alt2.Text = Convert.ToString(SamplePlanAltitude[2]);
            lbl_alt3.Text = Convert.ToString(SamplePlanAltitude[3]);
            lbl_alt4.Text = Convert.ToString(SamplePlanAltitude[4]);
            lbl_alt5.Text = Convert.ToString(SamplePlanAltitude[5]);
            lbl_alt6.Text = Convert.ToString(SamplePlanAltitude[6]);
            lbl_alt7.Text = Convert.ToString(SamplePlanAltitude[7]);
            lbl_alt8.Text = Convert.ToString(SamplePlanAltitude[8]);
            lbl_alt9.Text = Convert.ToString(SamplePlanAltitude[9]);
            lbl_alt10.Text = Convert.ToString(SamplePlanAltitude[10]);
            lbl_alt11.Text = Convert.ToString(SamplePlanAltitude[11]);
            lbl_alt12.Text = Convert.ToString(SamplePlanAltitude[12]);
        }

        private void btn_FIND_SAMPLE_ADD_Click(object sender, EventArgs e)
        {
            bool_FINDSAMPLEPLANADD = false;
            SAMPLEADD[0] = 0;
            SAMPLEADD[1] = 0;
            ALTITUDEADD[0] = 0;
            ALTITUDEADD[1] = 0;
            for (int i2 = 1; i2 < 13; i2++)
            {
                if (FLASKSAMPLED[i2] == false)
                {
                    SAMPLEADD[0] = i2;
                    ALTITUDEADD[0] = SamplePlanAltitude[i2];

                    if (i2 < 12)
                    {
                        if (SamplePlanAltitude[i2] == SamplePlanAltitude[i2 + 1])
                        {
                            SAMPLEADD[1] = i2 + 1;
                            ALTITUDEADD[1] = SamplePlanAltitude[i2 + 1];
                        }
                    }
                    goto DoneFinding;
                }
            }
        DoneFinding:
            txt_SAMPADD1.Text = Convert.ToString(SAMPLEADD[0]);
            lbl_NEXTSAMPLE.Text = Convert.ToString(SAMPLEADD[0]);
            txt_SAMPADD2.Text = Convert.ToString(SAMPLEADD[1]);
            txt_ALTADD1.Text = Convert.ToString(ALTITUDEADD[0]);
            txt_ALTADD2.Text = Convert.ToString(ALTITUDEADD[1]);
        }

        private void btn_WRITE_PLAN_Click(object sender, EventArgs e)
        {
            bool_WRITESAMPLEPLANADD = true;
            btn_WRITE_PLAN.BackColor = Color.LightGreen;
            if (txt_ALTADD1.Text != "0")
            {
                PFPCMDs[1] = "q_c300"; // quit to get to main menu
                PFPCMDs[2] = "q_n300"; // quit to get to main menu
                PFPCMDs[3] = "s_n300"; // set up
                PFPCMDs[4] = "s_n500"; //  sample plan
                PFPCMDs[5] = "a_n500"; // add
                PFPCMDs[6] = txt_SAMPADD1.Text + "_n500";
                PFPCMDs[7] = txt_ALTADD1.Text + "_n500";
                PFPCMDs[8] = "\r_n500";
                PFPCMDs[9] = "\r_n500";
                PFPCMDs[10] = "\r_n500";
                PFPCMDs[11] = "q_c300"; // quit back to main menu
            }
            else
            {
                PFPCMDs[1] = "q_c300"; // quit to get to main menu
                PFPCMDs[2] = "q_n300"; // quit to get to main menu
                txt_PFP_TEXT.Text = txt_PFP_TEXT.Text + "NO SAMPLE TO ADD";
            }
            if (txt_ALTADD2.Text != "0")
            {
                PFPCMDs[11] = "a_c500"; // quit to get to main menu
                PFPCMDs[12] = txt_SAMPADD2.Text + "_n500";
                PFPCMDs[13] = txt_ALTADD2.Text + "_n500";
                PFPCMDs[14] = "\r_n500";
                PFPCMDs[15] = "\r_n500";
                PFPCMDs[16] = "\r_n500";
                PFPCMDs[17] = "q_c300"; // quit back to main menu
            }

            timer1.Start();
        }

        private void FIND_MWO_SAMPLE(object sender, EventArgs e)
        {
            Console.WriteLine("find_mwo_sample");
            Console.WriteLine("x" + lbl_NEXTSAMPLE.Text + "x");
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "1")
            {
                chk_SAMPLE_TIME.Checked = true;
                chk_SAMPLETIME2.Checked = false; // first sample is a night time sample 
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "2")
            {
                chk_SAMPLE_TIME.Checked = false;
                chk_SAMPLETIME2.Checked = true; // second sample is a day time sample
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "3")
            {
                chk_SAMPLE_TIME.Checked = true; // third sample is a double night time sample
                chk_SAMPLETIME2.Checked = false;
                Console.WriteLine("Hi, whatsup?");
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "4")
            {
                chk_SAMPLE_TIME.Checked = true; // this should not happen, but it is here for consisitency
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "5")
            {
                chk_SAMPLE_TIME.Checked = true; // 5th is a night time sample
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "6")
            {
                chk_SAMPLE_TIME.Checked = false; // 6th is a day time sample
                chk_SAMPLETIME2.Checked = true;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "7")
            {
                chk_SAMPLE_TIME.Checked = true; // 7th is a night time sample
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "8")
            {
                chk_SAMPLE_TIME.Checked = true; //8,9 are night time
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "9")
            {
                chk_SAMPLE_TIME.Checked = true;
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "10")
            {
                chk_SAMPLE_TIME.Checked = true; // 10th sample is night time
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "11")
            {
                chk_SAMPLE_TIME.Checked = false; // 11th is a day time sample
                chk_SAMPLETIME2.Checked = true;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "12")
            {
                chk_SAMPLE_TIME.Checked = true; // 12th is a night time.
                chk_SAMPLETIME2.Checked = false;
            }
            if (lbl_SITE_CODE.Text == "MWO" && lbl_NEXTSAMPLE.Text == "13")
            {
                chk_SAMPLE_TIME.Checked = false;
                chk_SAMPLETIME2.Checked = false;
            }
        }


        private void FIND_MBO_SAMPLE(object sender, EventArgs e)
        {

        }


        private void btn_END_LOGGING_Click(object sender, EventArgs e)
        {
            btn_END_LOGGING.BackColor = Color.LightGreen;
            bool_ENDLOGGING = true;
            PFPCMDs[1] = "q_n400";
            PFPCMDs[2] = "q_n400";
            PFPCMDs[3] = "S_n400";
            PFPCMDs[4] = "F_n400";
            PFPCMDs[5] = "i_c700";
            PFPCMDs[6] = "25_n600";
            PFPCMDs[7] = "0_n700";
            PFPCMDs[8] = "0_n700";
            PFPCMDs[9] = "0_n700";
            PFPCMDs[10] = "q_n700";
            PFPCMDs[11] = "Q_n700";
            timer1.Start();
        }

        private void btn_OPEN_COM_2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = txt_COM_NAME.Text;
                serialPort1.Open();
                lbl_COM_PORT_OPEN.Text = "IS OPEN";
                lbl_COM_PORT_OPEN.ForeColor = Color.Green;
            }
        }

        private void btn_GETPFPNUMBER_Click(object sender, EventArgs e)
        {
            txt_TANKCHANGEPERSON.Text = txt_INITIALS.Text;
            bool_GETPFPNUMBER = true;
            btn_GETPFPNUMBER.BackColor = Color.LightGreen;
            PFPCMDs[1] = "q_n400";
            PFPCMDs[2] = "q_n400";
            PFPCMDs[3] = "H_c400";
            PFPCMDs[4] = "N_n700";
            PFPCMDs[5] = "Q_n700";
            bool_GETPFPNUMBER = true;
            chk_MONITOR_PFP.Checked = true;
            timer1.Start();
        }

        private void cbo_SITE_CODE_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_LOAD_SITE_SETTINGS_Click(null, null);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (TIMER5count == 0)
            {
                Console.WriteLine("call btn_history_e_click from timer5");

                btn_HISTORY_E_Click(null, null);
                timer5.Interval = 6000;

            }
            if (TIMER5count == 1)

            {
                Console.WriteLine("call btn_history_t_click from timer5");
                btn_HISTORY_T_Click(null, null);
                timer5.Interval = 6000;
                TIMER5count = 0;
                timer5.Stop();
            }

            TIMER5count++;
        }

        private void btn_SYSTEMTEST_Click(object sender, EventArgs e)
        {
            bool_SYSTEMTEST = true;
            btn_SYSTEMTEST.BackColor = Color.LightGreen;
            PFPCMDs[1] = "q_n400";
            PFPCMDs[2] = "q_n400";
            PFPCMDs[3] = "T_c400";
            PFPCMDs[4] = "S_n60000";
            PFPCMDs[5] = "Q_n700";
            timer1.Start();
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            dt_UTCNOWTIME = DateTime.UtcNow;
            TIMESTAMP = dt_UTCNOWTIME.ToString("MM/dd/yy HH:mm:ss");
            MailMessage msg = new MailMessage();
            msg.To.Add("noaapfp@gmail.com");
            if (txt_EMAILADD1.Text != "")
            {
                msg.To.Add(txt_EMAILADD1.Text);
            }
            if (txt_EMAILADD2.Text != "")
            {
                msg.To.Add(txt_EMAILADD2.Text);
            }
            if (txt_EMAILADD3.Text != "")
            {
                msg.To.Add(txt_EMAILADD3.Text);
            }
            if (txt_EMAILADD4.Text != "")
            {
                msg.To.Add(txt_EMAILADD4.Text);
            }
            msg.From = new MailAddress("noaapfp@gmail.com");
            msg.Subject = lbl_SITE_CODE.Text + " " + lbl_LASTFILLEDFLASK.Text + " filled";
            msg.Body = sEMAILMESSAGE; //cbo_SITE_CODE.Text + " " +  lbl_PFPNUMBER.Text + "\r\n" + TIMESTAMP + "\r\n" + sLASTHISTORY;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("noaapfp@gmail.com", "325JDKjcw");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
        }

        private void txt_GETHISTORYTIME_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SEND_NEWPFP_EMAIL_Click(object sender, EventArgs e)
        {
            string EBODY1;
            string EBODY2;
            string EBODY3;

            dt_UTCNOWTIME = DateTime.UtcNow;
            TIMESTAMP = dt_UTCNOWTIME.ToString("MM/dd/yy HH:mm:ss");
            MailMessage msg = new MailMessage();
            msg.To.Add("noaapfp@gmail.com");
            msg.From = new MailAddress("noaapfp@gmail.com");
            msg.Subject = lbl_SITE_CODE.Text + " new pfp " + lbl_PFPNUMBER.Text + " INSTALLED ";
            EBODY1 = "site code:" + lbl_SITE_CODE.Text + "\r\n new pfp number " + lbl_PFPNUMBER.Text + "\r\n time executed: ";
            EBODY2 = TIMESTAMP + "\r\n PCP NUMBER: " + txt_PCPNUMBER.Text + "\r\n OPERATOR: " + txt_INITIALS.Text + "\r\n NOTES: " + txt_INSTALLNOTES.Text;
            EBODY3 = "\r\n leak test performed: " + Convert.ToString(rbn_leaktestyes.Checked);
            msg.Body = EBODY1 + EBODY2 + EBODY3;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("noaapfp@gmail.com", "325JDKjcw");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
            btn_SEND_NEWPFP_EMAIL.BackColor = Color.LightGreen;
            btn_SEND_NEWPFP_EMAIL.Text = "EMAIL SENT, THANK YOU";
            timer6.Interval = 3000;
            timer6.Start();
        }

        private void btn_EXECUTE_PREFILL_Click(object sender, EventArgs e)
        {
            dt_UTCNOWTIME = DateTime.UtcNow;
            string nowtime = dt_UTCNOWTIME.ToString("HH:mm:ss");
            string prefilltime = txt_PREFILLTIME.Text;
            string sampletime = txt_SAMPLE_TIME.Text;
            string[] sampletimea = sampletime.Split(':');
            string[] prefilltimea = prefilltime.Split(':');
            string[] nowtimea = nowtime.Split(':');
            double nt = Convert.ToDouble(nowtimea[0]) + Convert.ToDouble(nowtimea[1]) / 60.0 + Convert.ToDouble(nowtimea[2]) / 3600;
            double pt = Convert.ToDouble(prefilltimea[0]) + Convert.ToDouble(prefilltimea[1]) / 60.0 + Convert.ToDouble(prefilltimea[2]) / 3600.0;
            double stm6 = Convert.ToDouble(sampletimea[0]) + Convert.ToDouble(sampletimea[1]) / 60.0 + Convert.ToDouble(sampletimea[2]) / 3600.0 - 5.7 / 60.0;
            //Console.WriteLine(nt);
            //Console.WriteLine(pt);
            //Console.WriteLine(stm6);
            if (bool_EXECUTINGPREFILLSEQUENCE == false && nt > pt && nt < stm6)
            {
                timer4.Start();
                bool_EXECUTEPREFILLNEEDED = true;
                btn_EXECUTE_PREFILL.Text = "EXECCUTING PREFILL";
            }
            else
            {
                bool_EXECUTEPREFILLNEEDED = false;
                btn_EXECUTE_PREFILL.BackColor = Color.LightCyan;
                btn_EXECUTE_PREFILL.Text = "PREFILL NOT NEEDED";
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            btn_SEND_NEWPFP_EMAIL.Text = "10. NEW PFP EMAIL";
            btn_SEND_NEWPFP_EMAIL.BackColor = SystemColors.Control;
            timer6.Stop();
        }

        private void btn_NEWPFP_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader Site_Settings_File = new System.IO.StreamReader(@"C:\a\Site_Settings.txt");
            Site_Settings_String = Site_Settings_File.ReadLine();
            Site_Settings_File.Close();
            timer3.Start();
            PFPCMDs[0] = "a";
            //Console.WriteLine(Site_Settings_String);
            string[] Settings_Array = Site_Settings_String.Split(',');
            txt_INITIALS.Text = Settings_Array[0];
            lbl_SITE_CODE.Text = Settings_Array[1];
            if (lbl_SITE_CODE.Text == "SNP")
            {
                chk_SEND_HISTORYEMAIL.Checked = false;
            }
            txt_SITE_COMNAME.Text = Settings_Array[2];
            txt_COM_NAME.Text = Settings_Array[2];
            if (Settings_Array[3] == "CHK")
            {
                chk_PREFILLTIME.Checked = true;
            }
            else
            {
                chk_PREFILLTIME.Checked = false;
            }
            txt_PREFILLTIME.Text = Settings_Array[4];
            if (Settings_Array[5] == "CHK")
            {
                chk_SAMPLE_TIME.Checked = true;
            }
            else
            {
                chk_SAMPLE_TIME.Checked = false;
            }
            txt_SAMPLE_TIME.Text = Settings_Array[6];
            if (Settings_Array[7] == "CHK")
            {
                chk_PREFILLTIME2.Checked = true;
            }
            else
            {
                chk_PREFILLTIME2.Checked = false;
            }
            txt_PREFILLTIME2.Text = Settings_Array[8];
            if (Settings_Array[9] == "CHK")
            {
                chk_SAMPLETIME2.Checked = true;
            }
            else
            {
                chk_SAMPLETIME2.Checked = false;
            }
            txt_SAMPLETIME2.Text = Settings_Array[10];
            txt_SITE_Mflush.Text = Settings_Array[11];
            txt_LIM_2MF_samplefill.Text = Settings_Array[11];
            txt_SITE_Sflush.Text = Settings_Array[12];
            txt_LIM_4SF_samplefill.Text = Settings_Array[12];
            if (Settings_Array[13] == "EODAY")
            {
                rbtn_EVERYOTHERDAY.Checked = true;
            }
            if (Settings_Array[13] == "EDAY")
            {
                rbtn_EVERYDAY.Checked = true;
            }
            if (Settings_Array.Length >= 15)
            {
                txt_EMAILADD1.Text = Settings_Array[14];
            }
            if (Settings_Array.Length >= 16)
            {
                txt_EMAILADD2.Text = Settings_Array[15];
            }
            if (Settings_Array.Length >= 17)
            {
                txt_EMAILADD3.Text = Settings_Array[16];
            }
            if (Settings_Array.Length >= 18)
            {
                txt_EMAILADD4.Text = Settings_Array[17];
            }
            btnOpenCom_Click(null, null);
        }




        private void btn_NOTIFY_Click(object sender, EventArgs e)
        {
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostEntry(host);
            string S_IPADDRESS = (ip.AddressList[0].ToString());
            //Console.WriteLine(S_IPADDRESS);
            TIMESTAMP = DateTime.UtcNow.ToString("MM/dd/yy HH:mm:ss");
            MailMessage msg = new MailMessage();
            msg.To.Add("jonathan.kofler@noaa.gov");
            msg.From = new MailAddress("noaapfp@gmail.com");
            msg.Subject = lbl_SITE_CODE.Text + " SITE CONTACT AT SITE, IP=" + S_IPADDRESS;
            msg.Body = sEMAILMESSAGE; //cbo_SITE_CODE.Text + " " +  lbl_PFPNUMBER.Text + "\r\n" + TIMESTAMP + "\r\n" + sLASTHISTORY;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("noaapfp@gmail.com", "325JDKjcw");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
        }

        private void chk_F1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void EMAIL_SNP_BALED_FILE(object sender, EventArgs e)
        {
            string fileattachname;
            string EBODY1;
            DateTime dt_UTCM1HR;
            dt_UTCNOWTIME = DateTime.UtcNow;
            dt_UTCM1HR = dt_UTCNOWTIME.AddHours(-1.0);
            TIMESTAMP = "on " + dt_UTCNOWTIME.ToString("MM/dd/yyyy") + ", at " + dt_UTCNOWTIME.ToString("HH:mm:ss") + " UTC, ";
            string YR = dt_UTCM1HR.ToString("yyyy") + "_";
            string MO = dt_UTCM1HR.ToString("MM") + "_";
            string DY = dt_UTCM1HR.ToString("dd") + "_";
            string HR = dt_UTCM1HR.ToString("HH") + "00.DAT";
            fileattachname = "snp_cotwo_" + YR + MO + DY + HR;
            string filepathandname = @"C:\Campbellsci\Baler\BalingDir\CR10XPB\" + fileattachname;
            //Console.WriteLine(filepathandname);
            MailMessage msg = new MailMessage();
            //msg.To.Add("jonathan.kofler@noaa.gov");
            msg.To.Add("dataretriever01@gmail.com");
            msg.Attachments.Add(new Attachment(filepathandname));
            msg.From = new MailAddress("noaapfp@gmail.com");
            msg.Subject = lbl_SITE_CODE.Text + " Cal Std Change Notice ";
            EBODY1 = "last hourly SNP data file attached";
            msg.Body = EBODY1;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("noaapfp@gmail.com", "325JDKjcw");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
            timer6.Interval = 3000;
            timer6.Start();

        }


        private void btn_EMAIL_TANK_CHANGE_Click(object sender, EventArgs e)
        {
            string EBODY;
            string EBODY1;
            string EBODY2;
            string EBODY3;
            dt_UTCNOWTIME = DateTime.UtcNow;
            TIMESTAMP = txt_TANKCHANGEDATETIME.Text;
            // "on " + dt_UTCNOWTIME.ToString("MM/dd/yyyy") + ", at " + dt_UTCNOWTIME.ToString("HH:mm:ss") + " UTC, ";
            MailMessage msg = new MailMessage();
            msg.To.Add("jonathan.kofler@noaa.gov");
            msg.To.Add("duane.r.kitzis@noaa.gov");
            msg.To.Add("patricia.m.lang@noaa.gov");
            msg.To.Add("michael.trudeau@noaa.gov");
            msg.To.Add("arlyn.andrews@noaa.gov");
            msg.To.Add("philip.handley@noaa.gov");
            msg.From = new MailAddress("noaapfp@gmail.com");
            msg.Subject = lbl_SITE_CODE.Text + " Cal Std Change Notice ";
            EBODY1 = TIMESTAMP + txt_TANKCHANGEPERSON.Text + " replaced the following cylinders:";
            EBODY2 = "\r\n\r\n" + cbo_TANK_ID_DESCRIPT.Text + "\r\nOLD: " + txt_OLDTANK.Text + "\r\nNEW: " + txt_NEWTANK.Text;
            EBODY3 = "\r\n\r\nkofler will update the Ref Gas Manager ";
            msg.Body = EBODY1 + EBODY2 + EBODY3;
            EBODY = "/r/n" + EBODY1 + EBODY2 + EBODY3;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("noaapfp@gmail.com", "325JDKjcw");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
            timer6.Interval = 3000;
            timer6.Start();

            lbl_TANKCHANGEEMAILMSG.Text = "subject: " + lbl_SITE_CODE.Text + " Cal Std Change Notice " + EBODY;
        }

        private void txt_INITIALS_TextChanged(object sender, EventArgs e)
        {
            txt_TANKCHANGEPERSON.Text = txt_INITIALS.Text;
        }

        private void btn_CLEAR_TANK_CHANGE_Click(object sender, EventArgs e)
        {
            lbl_TANKCHANGEEMAILMSG.Text = "email msg";
            txt_NEWTANK.Text = "CA0????";
            txt_OLDTANK.Text = "CA0????";
            cbo_TANK_ID_DESCRIPT.SelectedIndex = 0;
        }

        private void lbl_UTC_TIME_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMAIL_SNP_BALED_FILE(null, null);
        }

        private void chk_PREFILLTIME_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frm_TOWER_PFP_Load(object sender, EventArgs e)
        {

        }

        private void txt_PREFILLTIME_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EMAILADD1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer7_Tick(object sender, EventArgs e)// use this to set the sample schedule for MWO
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt_SITE_Mflush_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_SEND_HISTORYEMAIL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_PFP_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GETDATETIME_Click(object sender, EventArgs e)
        {
            dt_UTCNOWTIME = DateTime.UtcNow;
            txt_TANKCHANGEDATETIME.Text = "on " + dt_UTCNOWTIME.ToString("MM/dd/yyyy") + ", at " + dt_UTCNOWTIME.ToString("HH:mm:ss") + " UTC, ";
 
        }

        private void btn_HISTORY_E_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_HISTORY_E_Click");
            PFPCMDs[1] = "q_n300";
            PFPCMDs[2] = "q_n300";
            PFPCMDs[3] = "h_n300";
            PFPCMDs[4] = "E_c1500";
            PFPCMDs[5] = "q_n400";
            bool_GETHISTORY_E = true;
            btn_GET_HISTORY.BackColor = Color.LightGreen;
            timer1.Start();
            //btn_GET_HISTORY_Click(null, null);
        }

        private void btn_HISTORY_T_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn_HISTORY_T_Click");
            PFPCMDs[1] = "q_n300";
            PFPCMDs[2] = "q_n300";
            PFPCMDs[3] = "h_n300";
            PFPCMDs[4] = "t_c1500";
            PFPCMDs[5] = "q_n400";
            bool_GETHISTORY_T = true;
            btn_GET_HISTORY.BackColor = Color.LightGreen;
            timer1.Start();
            //btn_GET_HISTORY_Click(null, null);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_StartupCounter_Click(object sender, EventArgs e)
        {

        }

        private void btn_testfindmwosample_Click(object sender, EventArgs e)
        {
            FIND_MWO_SAMPLE(null, null);
        }

        private void btn_GET_NFILL2_Click(object sender, EventArgs e)
        {

        }




    }
           

}