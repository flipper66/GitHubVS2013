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

namespace WindowsFormsApplication1
{
    public partial class frm_TOWER_PFP : Form
    {
        Boolean[] FLASKSAMPLED = new Boolean[13];
        Boolean bool_Monitor_Checked;
        Boolean bool_GETPFPNUMBER;
        Boolean bool_GETHISTORY;
        Boolean bool_GETSAMPLEPLAN;
        Boolean bool_FINDSAMPLEPLANADD;
        Boolean bool_PREFILLLIMITS;
        Boolean bool_MANUALSAMPLE;
        Boolean bool_SAMPLELIMITS;
        Boolean bool_WRITESAMPLEPLANADD;
        Boolean bool_ENDLOGGING;
        Boolean bool_SYSTEMTEST;
        Boolean bool_EXECUTINGPREFILLSEQUENCE;
     
        int[] SamplePlanAltitude = new int[13];
        int[] DaysIntoYearSample = new int[13];
        int[] ALTITUDEADD = new int[2];
        int[] SAMPLEADD = new int[2];

        int CMDcount = 0;
        int TIMER4count = 0;
        int PREFILLCOUNT = 0;

        String RxString1;
        String allenblahtest = "wee";
        String TxString1;
        string flask2fill;
        string TIMESTAMP;
        string[] PFPCMDs = new string[100];

        DateTime dt_UTCNOWTIME;

        private StreamWriter PFPdata;
        private StreamWriter PFPprefillinfo;

        public frm_TOWER_PFP()
        {

            InitializeComponent();
            PFPdata = new StreamWriter(new FileStream(@"C:\a\PFPserialdata.txt", FileMode.Append));
            PFPprefillinfo = new StreamWriter(new FileStream(@"C:\a\PFPprefillinformation.txt", FileMode.Append));
            timer3.Start();
            PFPCMDs[0] = "a";
            //chk_MONITOR_PFP.Checked = true;
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = txt_COM_NAME.Text;
                serialPort1.Open();
                lbl_COM_PORT_OPEN.Text = "IS OPEN";
                lbl_COM_PORT_OPEN.ForeColor = Color.Green;
                btnOpenCom.BackColor = SystemColors.Control; ;
            }
        }
        private void btnCloseCom_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
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
                PFPprefillinfo.WriteLine(TIMESTAMP + RxString1.Substring(0,50));
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
            PFPCMDs[1] = "q_n300";
            PFPCMDs[2] = "q_n300";
            PFPCMDs[3] = "h_n300";
            PFPCMDs[4] = "t_c1500";
            PFPCMDs[5] = "q_n400";
            bool_GETHISTORY = true;
            btn_GET_HISTORY.BackColor = Color.LightGreen;
            timer1.Start();
        }


        private void btn_GET_NFILL2_Click(object sender, EventArgs e)
        {
            string[] FLSKDATE = new string[13];
            string[] FLSKTIME = new string[13];
            string[] FLSKTIME2 = new string[13];
            flask2fill = null;                          // PARSE HISTORY INTO SECTIONS OF STRING BY FLASK NUMBER
            int[] HISTORYINDEX = new int[14];           // HISTORY INDEX IS THE INDICIES OF THE START FOR EACH PFP
            int flasksfilledcount = 0;
            string PFPHISTORY = txt_PFP_TEXT.Text;
            int HISTORYLEN = PFPHISTORY.Length;
            for (int iFLASK = 1; iFLASK < 13; iFLASK++)
            {
                for (int I = 1; I < HISTORYLEN; I++)
                {
                    String ISTRING = "  " + Convert.ToString(iFLASK) + " ";
                    HISTORYINDEX[iFLASK] = PFPHISTORY.IndexOf(ISTRING);
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
                int t1 = tHISTORY.IndexOf("2013");
                int t2 = tHISTORY.IndexOf(":");
                if (t1 > 2)
                {
                    FLSKDATE[i2] = tHISTORY.Substring(t1 + 5, 5);
                    DaysIntoYearSample[i2] = Convert.ToInt32((Convert.ToDateTime(tHISTORY.Substring(t1, 10))).DayOfYear);
                    FLSKTIME[i2] = tHISTORY.Substring(t2 - 2, 5);
                    FLSKTIME2[i2] = tHISTORY.Substring(t2 + 21, 5);
                }
                else
                {
                    FLSKDATE[i2] = "--";
                    FLSKTIME[i2] = "--";
                    FLSKTIME2[i2] = "--";
                }

                if (nDASH > 5)
                {
                    FLASKSAMPLED[i2] = false;

                    if (flask2fill == null)
                    {
                        flask2fill = Convert.ToString(i2); // flask to fill is the first non-filled flask
                    }
                }
                else
                {
                    FLASKSAMPLED[i2] = true;
                    flasksfilledcount++;
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
            PFPCMDs[6] = txt_LIM_1MFT.Text+"_n500";
            PFPCMDs[7] = txt_LIM_2MF_prefill.Text+"_n500";
            PFPCMDs[8] = txt_LIM_3DMF.Text +"_n500";
            PFPCMDs[9] = txt_LIM_4SF_prefill.Text+"_n500";
            PFPCMDs[10] = txt_LIM_5DSF.Text+"_n500";
            PFPCMDs[11] = txt_LIM_6MFT.Text+"_n500";
            PFPCMDs[12] = txt_LIM_7MFP.Text+"_n500";
            PFPCMDs[13] = "q_n300";
            PFPCMDs[14] = "q_n300";
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
            if (chk_MONITOR_PFP.Checked == true)
            {
                chk_MONITOR_PFP.Checked = false;
                bool_Monitor_Checked = true;
            }
            if (serialPort1.IsOpen == false)
            {
                txt_PFP_TEXT.Text = "COM PORT NOT OPEN, OPEN COMMUNICATIONS PORT FIRST";
            }

            // EXECUTE A SEQUENCE OF COMMANDS.
            if (CMDcount == 0 && tbF1.Text != "")
            {
                PFPCMDs[1] = tbF1.Text;
                PFPCMDs[2] = tbF2.Text;
                PFPCMDs[3] = tbF3.Text;
                PFPCMDs[4] = tbF4.Text;
                PFPCMDs[5] = tbF5.Text;
                PFPCMDs[6] = tbF6.Text;
                PFPCMDs[7] = tbF7.Text;
                PFPCMDs[8] = tbF8.Text;
                PFPCMDs[9] = tbF9.Text;
                PFPCMDs[10] = tbF10.Text;
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
                    lbl_PFPNUMBER.Text = "FP-"+strHISTORYSN.Substring(Convert.ToInt32(strHISTORYSN.IndexOf("Serial Number"))+14,4)+"-";
                    btn_GETPFPNUMBER.BackColor = SystemColors.Control;
                }
                if (bool_GETHISTORY == true) // IF GET HISTORY WAS EXECTUED, THEN EXTRACT THE HISTORY AND DISPLAY IT
                {
                    bool_GETHISTORY = false;
                    btn_GET_NFILL2_Click(null, null);
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
            if (serialPort1.IsOpen == false)
            {
                txt_PFP_TEXT.Text = "NEED TO OPEN COM PORT FIRST";
            }
            if (TIMER4count != 0)
            {
                PREFILLCOUNT++;
                lbl_PREFILL_COUNT.Text = Convert.ToString(PREFILLCOUNT);
            }
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
            int PFPTEXTSTRINGLENGTH = PFPTEXT.Length;
            if (PFPTEXTSTRINGLENGTH < 999)
            {
                txt_PFP_TEXT.Text = txt_PFP_TEXT.Text + RxString1;
            }
            else
            {
                txt_PFP_TEXT.Text = RxString1;
            }
        }


        private void timer3_Tick(object sender, EventArgs e) // for the time clock and triggering a pre-sample and sample
            // and monitoring the seial port status
        {
            dt_UTCNOWTIME = DateTime.UtcNow;
           
            int intDAYSBETWEENSAMPLES;
            string nowtime = dt_UTCNOWTIME.ToString("HH:mm:ss");
            TIMESTAMP = lbl_PFPNUMBER.Text + " " +  dt_UTCNOWTIME.ToString("MM/dd/yy HH:mm:ss "); 
            lbl_UTC_TIME.Text = nowtime;
            lbl_DOY.Text =  Convert.ToString(dt_UTCNOWTIME.DayOfYear);
            string prefilltime = txt_PREFILLTIME.Text;
            string sampletime = txt_SAMPLE_TIME.Text;
            string sampletime2 = txt_SAMPLETIME2.Text;
            string prefilltime2 = txt_PREFILLTIME2.Text;
            string[] sampletimea = sampletime.Split(new char[] { ':' });
            string[] prefilltimea = prefilltime.Split(new char[] { ':' });
            string[] sampletime2a = sampletime2.Split(new char[] { ':' });
            string[] prefilltime2a = prefilltime2.Split(new char[] { ':' });
            string[] nowtimea = nowtime.Split(new char[] { ':' });
            string sampletimeplus1hour = Convert.ToString(Convert.ToUInt32(nowtimea[0])+1);

            if (bool_EXECUTINGPREFILLSEQUENCE)
            {
                lbl_PREFILL_COUNT.Text = Convert.ToString(Convert.ToInt32(lbl_PREFILL_COUNT.Text) + 1);
            }
            else
            {
                lbl_PREFILL_COUNT.Text = "0";
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

            // step through the pre-fill steps if it is the time of day of a pre-fiil.
            if (prefilltimea[0] == nowtimea[0] && prefilltimea[1] == nowtimea[1] && prefilltimea[2] == nowtimea[2] && chk_PREFILLTIME.Checked == true)
            {
                timer4.Start();
            }
            if (prefilltime2a[0] == nowtimea[0] && prefilltime2a[1] == nowtimea[1] && prefilltime2a[2] == nowtimea[2] &&  chk_PREFILLTIME2.Checked == true)
            {
                timer4.Start();
            }

            
            // if sample time of day, then take a real sample (not a pre-fill)
            Boolean bool_SAMPLE1 = sampletimea[0] == nowtimea[0] && sampletimea[1] == nowtimea[1] && sampletimea[2] == nowtimea[2] && chk_SAMPLE_TIME.Checked == true;
            Boolean bool_SAMPLE2 = sampletimea[0] == nowtimea[0] && sampletimea[1] == nowtimea[1] && sampletimea[2] == nowtimea[2] && chk_SAMPLE_TIME.Checked == true;
            if (bool_SAMPLE1 | bool_SAMPLE2)
            {
                //Console.WriteLine(DaysIntoYearSample.Max());
                if (rbtn_EVERYDAY.Checked == true)
                {
                    intDAYSBETWEENSAMPLES = 0;
                }
                else
                {
                    intDAYSBETWEENSAMPLES = 2;
                }
                // trigger a manual sample if it is the a day or every other day or it is the first sample.
                if (DaysIntoYearSample.Max() + intDAYSBETWEENSAMPLES >= Convert.ToInt32(dt_UTCNOWTIME.DayOfYear) | (!chk_F1.Checked))
                {
                    btn_MANUAL_SAMPLE_Click(null, null);
                    if (chk_LASTSAMPLE.Checked == true)
                    {
                        chk_SAMPLE_TIME.Checked = false;
                        chk_PREFILLTIME.Checked = false;
                        chk_LASTSAMPLE.Checked = false;
                    }
                }
            }
            // an hour after the sample get the history so that it is on display if someone logs in to check it will show the most current data
            if (sampletimeplus1hour == nowtimea[0] && sampletimea[1] == nowtimea[1] && sampletimea[2] == nowtimea[2] && chk_SAMPLE_TIME.Checked == true)
            {
                btn_GET_HISTORY_Click(null, null);
            }
        }
                
        private void timer4_Tick(object sender, EventArgs e) // for stepping through the pre-sample
        {
            TIMER4count++;

            if (TIMER4count == 1)// get sample plan
            {
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
                btn_SAMPLE_PLAN.BackColor = SystemColors.Control;
                btn_GET_HISTORY.BackColor = Color.LightGreen;
                btn_GET_HISTORY_Click(null, null);
                timer4.Interval = 8000;
            }

            if (TIMER4count == 3)// if package full, then abort pre-sample 
            {
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
                btn_GET_HISTORY.BackColor = SystemColors.Control;
                btn_GET_NFILL2.BackColor = SystemColors.Control;
                btn_FIND_SAMPLE_ADD.BackColor = Color.LightGreen;
                btn_FIND_SAMPLE_ADD_Click(null, null);
                timer4.Interval = 2000;
                //chk_MONITOR_PFP.Checked = true;
            } 
            if (TIMER4count == 5)// set prefill limits
            {
                btn_FIND_SAMPLE_ADD.BackColor = SystemColors.Control;
                btn_PREFILL_LIMITS.BackColor = Color.LightGreen;
                btn_PREFILL_LIMITS_Click(null, null);
                timer4.Interval = 13000;
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
            // **************************** re-program... overwrite prefill sample (just filled) 
            if (TIMER4count == 7)// re-set the pre-sampled flask
            {
                btn_MANUAL_SAMPLE.BackColor = SystemColors.Control;
                btn_WRITE_PLAN.BackColor = Color.LightGreen;
                btn_WRITE_PLAN_Click(null, null);
                timer4.Interval = 13000;
                chk_MONITOR_PFP.Checked = false;
            }
            if (TIMER4count == 8)// set sample limits for next sample
            {
                btn_WRITE_PLAN.BackColor = SystemColors.Control;
                btn_SAMP_FILL_LIMITS.BackColor = Color.LightGreen;
                btn_SAMP_FILL_LIMITS_Click(null, null);
                timer4.Interval = 13000;
            }
            if (TIMER4count == 9) // quit to main menu
            {
                btn_QUIT_TO_MAIN_Click(null, null);
                timer4.Interval = 4000;
            }
            if (TIMER4count == 10)// stop and reset timer
            {
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
            if (cbo_SITE_CODE.Text == "MWO")
            {
                txt_SAMPLE_TIME.Text = txt_MWO_TIME.Text;// txt_MWO_time.Text;
                txt_COM_NAME.Text = txt_MWO_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_MWO_MFLUSH.Text;
                txt_LIM_4SF_samplefill.Text = txt_MWO_SFLUSH.Text;
                rbtn_EVERYDAY.Checked = chk_Eday_MWO.Checked;// chk_EdayBAO.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_Eday_MWO.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIG_MWO.Checked;
                chk_SAMPLETIME2.Checked = chk_COMTRIG_MWO.Checked;
                chk_PREFILLTIME2.Checked = true;
                chk_PREFILLTIME.Checked = true;
                txt_PREFILLTIME.Text = "10:30:00";
                txt_PREFILLTIME2.Text = "22:30:00";
                txt_SAMPLE_TIME.Text = "11:00:00";
                txt_SAMPLETIME2.Text = "23:00:00";
            }

            if (cbo_SITE_CODE.Text == "BAO")
            {
                txt_SAMPLE_TIME.Text = txt_BAO_time.Text;
                txt_COM_NAME.Text = txt_BAO_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_BAO_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_BAO_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayBAO.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayBAO.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_BAO.Checked;
            }
            if (cbo_SITE_CODE.Text == "AMT")
            {
                txt_SAMPLE_TIME.Text = txt_AMT_time.Text;
                txt_COM_NAME.Text = txt_AMT_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_AMT_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_AMT_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayAMT.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayAMT.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_AMT.Checked;
            }

            if (cbo_SITE_CODE.Text == "LEF")
            {
                txt_SAMPLE_TIME.Text = txt_LEF_time.Text;
                txt_COM_NAME.Text = txt_LEF_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_LEF_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_LEF_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayLEF.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayLEF.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_LEF.Checked;
            }

            if (cbo_SITE_CODE.Text == "SCT")
            {
                txt_SAMPLE_TIME.Text = txt_SCT_time.Text;
                txt_COM_NAME.Text = txt_SCT_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_SCT_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_SCT_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdaySCT.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdaySCT.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_SCT.Checked;
            }

            if (cbo_SITE_CODE.Text == "WBI")
            {
                txt_SAMPLE_TIME.Text = txt_WBI_time.Text;
                txt_COM_NAME.Text = txt_WBI_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_WBI_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_WBI_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayWBI.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayWBI.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_WBI.Checked;
            }

            if (cbo_SITE_CODE.Text == "WKT")
            {
                txt_SAMPLE_TIME.Text = txt_WKT_time.Text;
                txt_COM_NAME.Text = txt_WKT_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_WKT_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_WKT_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayWKT.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayWKT.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_WKT.Checked;
            }
            if (cbo_SITE_CODE.Text == "LEW")
            {
                txt_SAMPLE_TIME.Text = txt_LEW_time.Text;
                txt_COM_NAME.Text = txt_LEW_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_LEW_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_LEW_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayLEW.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayLEW.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_LEW.Checked;
            }
            if (cbo_SITE_CODE.Text == "WGC")
            {
                txt_SAMPLE_TIME.Text = txt_WGC_time.Text;
                txt_COM_NAME.Text = txt_WGC_COM.Text;
                txt_LIM_2MF_samplefill.Text = txt_WGC_Mflush.Text;
                txt_LIM_4SF_samplefill.Text = txt_WGC_Sflush.Text;
                rbtn_EVERYDAY.Checked = chk_EdayLEW.Checked;
                rbtn_EVERYOTHERDAY.Checked = !(chk_EdayWGC.Checked);
                chk_SAMPLE_TIME.Checked = chk_COMTRIGS_WGC.Checked;
            }
        } //  END OF SITE SETUP

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
            }

            timer1.Start();
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

        private void lbl_EXECUTINGSEQUENCE_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PREFILL_COUNT_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_PREFILLTIME_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
