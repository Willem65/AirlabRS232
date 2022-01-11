using System.Drawing;
using System.Globalization;
using System.Text;

namespace AirlabRS232
{
    //------------------------------------- ShowState, verzamel de state van de berichten en geef ze weer ---------------------------------------------
    public partial class Form1
    {
        private string[] deConfig = new string[17];

        public void ShowState(string kanaal) //, string BERICHT, string VANWIE, string[] DATA)
        {

            // Module Type configuration
            for (int t = 0; t<17; t++)
            {
                if (bericht.Contains("95") && vanwie.Contains("00") && dedata[t].Contains("00"))
                    deConfig[t] = "leegKanaal";
                if (bericht.Contains("95") && vanwie.Contains("00") && dedata[t].Contains("01"))
                    deConfig[t] = "tripleKanaal";
                if (bericht.Contains("95") && vanwie.Contains("00") && dedata[t].Contains("02"))
                    deConfig[t] = "telcoKanaal";
            }

            // Master Setup
            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[0].Contains("01"))
                checkBoxAutoCueReset.Checked = true;
            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[0].Contains("00"))
                checkBoxAutoCueReset.Checked = false;

            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[1].Contains("01"))
                checkBoxCueToCrm.Checked = true;
            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[1].Contains("00"))
                checkBoxCueToCrm.Checked = false;

            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[2].Contains("01"))
                checkBoxAutoCom.Checked = true;
            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[2].Contains("00"))
                checkBoxAutoCom.Checked = false;

            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[3].Contains("01"))
                checkBoxRS232.Checked = true;
            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[3].Contains("00"))
                checkBoxRS232.Checked = false;

            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[4].Contains("01"))
                checkBoxConsole.Checked = true;
            if (bericht.Contains("94") && vanwie.Contains("00") && dedata[4].Contains("00"))
                checkBoxConsole.Checked = false;


            // OnAir 1
            if (bericht.Contains("84") && vanwie.Contains("00") && dedata[0].Contains("01"))
            {
                labelOnAir1.BackColor = Color.FromArgb(255, 0, 0);
                label14.Text = @"84xx01";
            }

            if (bericht.Contains("84") && vanwie.Contains("00") && dedata[0].Contains("00"))
            {
                labelOnAir1.BackColor = Color.LightGray;
                label14.Text = @"84xx00";
            }

            // OnAir 2
            if (bericht.Contains("85") && vanwie.Contains("00") && dedata[0].Contains("01"))
            {
                labelOnAir2.BackColor = Color.Red;
                label15.Text = @"85xx01";
            }

            if (bericht.Contains("85") && vanwie.Contains("00") && dedata[0].Contains("00"))
            {
                labelOnAir2.BackColor = Color.LightGray;
                label15.Text = @"85xx00";
            }

            // CRM Mute
            if (bericht.Contains("D0") && vanwie.Contains("00") && dedata[0].Contains("01"))
            {
                label3.BackColor = Color.Red;
                label16.Text = @"D00001";
            }

            if (bericht.Contains("D0") && vanwie.Contains("00") && dedata[0].Contains("00"))
            {
                label3.BackColor = Color.LightGray;
                label16.Text = @"D00000";
            }

            // Studio Mute
            if (bericht.Contains("D0") && vanwie.Contains("01") && dedata[0].Contains("01"))
            {
                label4.BackColor = Color.Red;
                label17.Text = @"D00101";
            }

            if (bericht.Contains("D0") && vanwie.Contains("01") && dedata[0].Contains("00"))
            {
                label4.BackColor = Color.LightGray;
                label17.Text = @"D00100";
            }

            // Card inserted
            if (bericht.Contains("98") && vanwie.Contains("00") && dedata[0].Contains("01"))
            {
                label7.BackColor = Color.Green;
                label17.Text = @"98xx01";
            }

            if (bericht.Contains("98") && vanwie.Contains("00") && dedata[0].Contains("00"))
            {
                label7.BackColor = Color.LightGray;
                label17.Text = @"98xx00";
            }

            // ID String D&R
            if (bericht.Contains("9A")) // && VANWIE.Contains("00") && DATA[0].Contains("00"))
            {
                var sb = new StringBuilder();
                var a = hexStr.Split(' ');

                for (var t = 2; t < a.Length - 5; t++) sb.Append((char) int.Parse(a[t], NumberStyles.HexNumber));

                textBoxMessages.AppendText(sb.ToString() + " ");
            }

            //----------1----------------------------------------------------------------------------------------------------
            // Module config
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[0].Contains("01"))
                checkBoxTimerLineA.Checked = true;

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[0].Contains("00"))
                checkBoxTimerLineA.Checked = false;

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[1].Contains("01"))
            {
                checkBoxTimerLineB.Width = checkBoxTimerLineB.Parent.Width - checkBoxTimerLineB.Left - 1;
                checkBoxTimerLineB.Text = "Timer enabled by Line B";
                checkBoxTimerLineB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[1].Contains("00"))
            {
                checkBoxTimerLineB.Width = checkBoxTimerLineB.Parent.Width - checkBoxTimerLineB.Left - 1;
                checkBoxTimerLineB.Text = "Timer enabled by Line B";
                checkBoxTimerLineB.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[2].Contains("01"))
            {
                checkBoxTimerMic.Width = checkBoxTimerMic.Parent.Width - checkBoxTimerMic.Left - 1;
                checkBoxTimerMic.Text = "Timer enabled by Mic";
                checkBoxTimerMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[2].Contains("00"))
            {
                checkBoxTimerMic.Width = checkBoxTimerMic.Parent.Width - checkBoxTimerMic.Left - 1;
                checkBoxTimerMic.Text = "Timer enabled by Mic";
                checkBoxTimerMic.Checked = false;
            }

            //
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[3].Contains("01"))
            {
                checkBoxStartLineA.Width = checkBoxStartLineA.Parent.Width - checkBoxStartLineA.Left - 1;
                checkBoxStartLineA.Text = "Start enabled by Line A";
                checkBoxStartLineA.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[3].Contains("00"))
            {
                checkBoxStartLineA.Width = checkBoxStartLineA.Parent.Width - checkBoxStartLineA.Left - 1;
                checkBoxStartLineA.Text = "Start enabled by Line A";
                checkBoxStartLineA.Checked = false;
            }

            // /*
            //---------6-----------------------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[4].Contains("01"))
            {
                checkBoxStartLineB.Width = checkBoxStartLineB.Parent.Width - checkBoxStartLineB.Left - 1;
                checkBoxStartLineB.Text = "Start enabled by Line B";
                checkBoxStartLineB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[4].Contains("00"))
            {
                checkBoxStartLineB.Width = checkBoxStartLineB.Parent.Width - checkBoxStartLineB.Left - 1;
                checkBoxStartLineB.Text = "Start enabled by Line B";
                checkBoxStartLineB.Checked = false;
            }

            // /*
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[5].Contains("01"))
            {
                checkBoxStartMic.Width = checkBoxStartMic.Parent.Width - checkBoxStartMic.Left - 1;
                checkBoxStartMic.Text = "Start enabled by MIC";
                checkBoxStartMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[5].Contains("00"))
            {
                checkBoxStartMic.Width = checkBoxStartMic.Parent.Width - checkBoxStartMic.Left - 1;
                checkBoxStartMic.Text = "Start enabled by MIC";
                checkBoxStartMic.Checked = false;
            }

            // /*
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[6].Contains("01"))
            {
                checkBoxStartFader.Width = checkBoxStartFader.Parent.Width - checkBoxStartFader.Left - 1;
                checkBoxStartFader.Text = "Start generated by FADER";
                checkBoxStartFader.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[6].Contains("00"))
            {
                checkBoxStartFader.Width = checkBoxStartFader.Parent.Width - checkBoxStartFader.Left - 1;
                checkBoxStartFader.Text = "Start generated by FADER";
                checkBoxStartFader.Checked = false;
            }

            // /*            
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[7].Contains("01"))
            {
                checkBoxStartOn.Width = checkBoxStartOn.Parent.Width - checkBoxStartOn.Left - 1;
                checkBoxStartOn.Text = "Start generated by ON";
                checkBoxStartOn.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[7].Contains("00"))
            {
                checkBoxStartOn.Width = checkBoxStartOn.Parent.Width - checkBoxStartOn.Left - 1;
                checkBoxStartOn.Text = "Start generated by ON";
                checkBoxStartOn.Checked = false;
            }

            ///*
            //-----------10----------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[8].Contains("01"))
            {
                checkBoxStartCue.Width = checkBoxStartCue.Parent.Width - checkBoxStartCue.Left - 1;
                checkBoxStartCue.Text = "Start generated by CUE";
                checkBoxStartCue.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[8].Contains("00"))
            {
                checkBoxStartCue.Width = checkBoxStartCue.Parent.Width - checkBoxStartCue.Left - 1;
                checkBoxStartCue.Text = "Start generated by CUE";
                checkBoxStartCue.Checked = false;
            }

            // /*
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[9].Contains("01"))
            {
                checkBoxStartPuls.Width = 180;
                checkBoxStartPuls.Text = "Start is PULS or Continuous";
                checkBoxStartPuls.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[9].Contains("00"))
            {
                checkBoxStartPuls.Width = 180;
                checkBoxStartPuls.Text = "Start is PULS or Continuous";
                checkBoxStartPuls.Checked = false;
            }

            // /*
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[10].Contains("01"))
            {
                checkBox12.Width = checkBox12.Parent.Width - checkBox12.Left - 1;
                checkBox12.Text = "Remote CUE enabled by Line A";
                checkBox12.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[10].Contains("00"))
            {
                checkBox12.Width = checkBox12.Parent.Width - checkBox12.Left - 1;
                checkBox12.Text = "Remote CUE enabled by Line A";
                checkBox12.Checked = false;
            }


            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[11].Contains("01"))
            {
                checkBox13.Width = checkBox13.Parent.Width - checkBox13.Left - 1;
                checkBox13.Text = "Remote CUE enabled by Line B";
                checkBox13.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[11].Contains("00"))
            {
                checkBox13.Width = checkBox13.Parent.Width - checkBox13.Left - 1;
                checkBox13.Text = "Remote CUE enabled by Line B";
                checkBox13.Checked = false;
            }


            //------------14-----------------------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[12].Contains("01"))
            {
                checkBox14.Width = checkBox14.Parent.Width - checkBox14.Left - 1;
                checkBox14.Text = "Remote CUE enabled by MIC";
                checkBox14.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[12].Contains("00"))
            {
                checkBox14.Width = checkBox14.Parent.Width - checkBox14.Left - 1;
                checkBox14.Text = "Remote CUE enabled by MIC";
                checkBox14.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[13].Contains("01"))
            {
                checkBox15.Width = checkBox15.Parent.Width - checkBox15.Left - 1;
                checkBox15.Text = "DJ MIC";
                checkBox15.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[13].Contains("00"))
            {
                checkBox15.Width = checkBox15.Parent.Width - checkBox15.Left - 1;
                checkBox15.Text = "DJ MIC";
                checkBox15.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[14].Contains("01"))
            {
                checkBox16.Width = checkBox16.Parent.Width - checkBox16.Left - 1;
                checkBox16.Text = "ANN MIC";
                checkBox16.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[14].Contains("00"))
            {
                checkBox16.Width = checkBox16.Parent.Width - checkBox16.Left - 1;
                checkBox16.Text = "ANN MIC";
                checkBox16.Checked = false;
            }

            //
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[15].Contains("01"))
            {
                checkBox17.Width = checkBox17.Parent.Width - checkBox17.Left - 1;
                checkBox17.Text = "Studio MIC";
                checkBox17.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[15].Contains("00"))
            {
                checkBox17.Width = checkBox17.Parent.Width - checkBox17.Left - 1;
                checkBox17.Text = "Studio MIC";
                checkBox17.Checked = false;
            }

            //----------------------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[16].Contains("01"))
            {
                checkBox18.Width = checkBox18.Parent.Width - checkBox18.Left - 1;
                checkBox18.Text = "ONAIR 1 enabled by LINE A";
                checkBox18.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[16].Contains("00"))
            {
                checkBox18.Width = checkBox18.Parent.Width - checkBox18.Left - 1;
                checkBox18.Text = "ONAIR 1 enabled by LINE A";
                checkBox18.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[17].Contains("01"))
            {
                checkBox19.Width = checkBox19.Parent.Width - checkBox19.Left - 1;
                checkBox19.Text = "ONAIR 1 enabled by LINE B";
                checkBox19.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[17].Contains("00"))
            {
                checkBox19.Width = checkBox19.Parent.Width - checkBox19.Left - 1;
                checkBox19.Text = "ONAIR 1 enabled by LINE B";
                checkBox19.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[18].Contains("01"))
            {
                checkBox20.Width = checkBox20.Parent.Width - checkBox20.Left - 1;
                checkBox20.Text = "ONAIR 1 enabled by MIC";
                checkBox20.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[18].Contains("00"))
            {
                checkBox20.Width = checkBox20.Parent.Width - checkBox20.Left - 1;
                checkBox20.Text = "ONAIR 1 enabled by MIC";
                checkBox20.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[19].Contains("01"))
            {
                checkBox21.Width = checkBox21.Parent.Width - checkBox21.Left - 1;
                checkBox21.Text = "ONAIR 2 enabled by LINE A";
                checkBox21.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[19].Contains("00"))
            {
                checkBox21.Width = checkBox21.Parent.Width - checkBox21.Left - 1;
                checkBox21.Text = "ONAIR 2 enabled by LINE A";
                checkBox21.Checked = false;
            }

            //------------22----------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[20].Contains("01"))
            {
                checkBox22.Width = checkBox22.Parent.Width - checkBox22.Left - 1;
                checkBox22.Text = "ONAIR 2 enabled by LINE B";
                checkBox22.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[20].Contains("00"))
            {
                checkBox22.Width = checkBox22.Parent.Width - checkBox22.Left - 1;
                checkBox22.Text = "ONAIR 2 enabled by LINE B";
                checkBox22.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[21].Contains("01"))
            {
                checkBox23.Width = checkBox23.Parent.Width - checkBox23.Left - 1;
                checkBox23.Text = "ONAIR 2 enabled by MIC";
                checkBox23.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[21].Contains("00"))
            {
                checkBox23.Width = checkBox23.Parent.Width - checkBox23.Left - 1;
                checkBox23.Text = "ONAIR 2 enabled by MIC";
                checkBox23.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[22].Contains("01"))
            {
                checkBox24.Width = checkBox24.Parent.Width - checkBox24.Left - 1;
                checkBox24.Text = "Module ON at Power";
                checkBox24.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[22].Contains("00"))
            {
                checkBox24.Width = checkBox24.Parent.Width - checkBox24.Left - 1;
                checkBox24.Text = "Module ON at Power";
                checkBox24.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[23].Contains("01"))
            {
                checkBox25.Width = checkBox25.Parent.Width - checkBox25.Left - 1;
                checkBox25.Text = "Mic at Line A";
                checkBox25.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[23].Contains("00"))
            {
                checkBox25.Width = checkBox25.Parent.Width - checkBox25.Left - 1;
                checkBox25.Text = "Mic at Line A";
                checkBox25.Checked = false;
            }
            //----------------------------------------------------------------------------------------------------

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[24].Contains("01"))
            {
                checkBox26.Width = checkBox26.Parent.Width - checkBox26.Left - 1;
                checkBox26.Text = "Mic at Line B";
                checkBox26.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[24].Contains("00"))
            {
                checkBox26.Width = checkBox26.Parent.Width - checkBox26.Left - 1;
                checkBox26.Text = "Mic at Line B";
                checkBox26.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[25].Contains("01"))
            {
                checkBox27.Width = checkBox27.Parent.Width - checkBox27.Left - 1;
                checkBox27.Text = "Remote ON enabled by MIC";
                checkBox27.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[25].Contains("00"))
            {
                checkBox27.Width = checkBox27.Parent.Width - checkBox27.Left - 1;
                checkBox27.Text = "Remote ON enabled by MIC";
                checkBox27.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[26].Contains("01"))
            {
                checkBox28.Width = 180;
                checkBox28.Text = "Remote ON enabled by Line A";
                checkBox28.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[26].Contains("00"))
            {
                checkBox28.Width = 180;
                checkBox28.Text = "Remote ON enabled by Line A";
                checkBox28.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[27].Contains("01"))
            {
                checkBox29.Width = 180;
                checkBox29.Text = "Remote ON enabled by Line B";
                checkBox29.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[27].Contains("00"))
            {
                checkBox29.Width = 180;
                checkBox29.Text = "Remote ON enabled by Line B";
                checkBox29.Checked = false;
            }
            //----------------------------------------------------------------------------------------------------

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[28].Contains("01"))
            {
                checkBox30.Width = checkBox30.Parent.Width - checkBox30.Left - 1;
                checkBox30.Text = "Switch Start";
                checkBox30.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[28].Contains("00"))
            {
                checkBox30.Width = checkBox30.Parent.Width - checkBox30.Left - 1;
                checkBox30.Text = "Switch Start";
                checkBox30.Checked = false;
            }
        }
    }
}