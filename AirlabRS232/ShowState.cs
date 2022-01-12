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
                checkBoxRemoteCueA.Width = checkBoxRemoteCueA.Parent.Width - checkBoxRemoteCueA.Left - 1;
                checkBoxRemoteCueA.Text = "Remote CUE enabled by Line A";
                checkBoxRemoteCueA.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[10].Contains("00"))
            {
                checkBoxRemoteCueA.Width = checkBoxRemoteCueA.Parent.Width - checkBoxRemoteCueA.Left - 1;
                checkBoxRemoteCueA.Text = "Remote CUE enabled by Line A";
                checkBoxRemoteCueA.Checked = false;
            }


            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[11].Contains("01"))
            {
                checkBoxRemoteCueB.Width = checkBoxRemoteCueB.Parent.Width - checkBoxRemoteCueB.Left - 1;
                checkBoxRemoteCueB.Text = "Remote CUE enabled by Line B";
                checkBoxRemoteCueB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[11].Contains("00"))
            {
                checkBoxRemoteCueB.Width = checkBoxRemoteCueB.Parent.Width - checkBoxRemoteCueB.Left - 1;
                checkBoxRemoteCueB.Text = "Remote CUE enabled by Line B";
                checkBoxRemoteCueB.Checked = false;
            }


            //------------14-----------------------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[12].Contains("01"))
            {
                checkBoxRemoteCueByMic.Width = checkBoxRemoteCueByMic.Parent.Width - checkBoxRemoteCueByMic.Left - 1;
                checkBoxRemoteCueByMic.Text = "Remote CUE enabled by MIC";
                checkBoxRemoteCueByMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[12].Contains("00"))
            {
                checkBoxRemoteCueByMic.Width = checkBoxRemoteCueByMic.Parent.Width - checkBoxRemoteCueByMic.Left - 1;
                checkBoxRemoteCueByMic.Text = "Remote CUE enabled by MIC";
                checkBoxRemoteCueByMic.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[13].Contains("01"))
            {
                checkBoxDjMic.Width = checkBoxDjMic.Parent.Width - checkBoxDjMic.Left - 1;
                checkBoxDjMic.Text = "DJ MIC";
                checkBoxDjMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[13].Contains("00"))
            {
                checkBoxDjMic.Width = checkBoxDjMic.Parent.Width - checkBoxDjMic.Left - 1;
                checkBoxDjMic.Text = "DJ MIC";
                checkBoxDjMic.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[14].Contains("01"))
            {
                checkBoxAnnMic.Width = checkBoxAnnMic.Parent.Width - checkBoxAnnMic.Left - 1;
                checkBoxAnnMic.Text = "ANN MIC";
                checkBoxAnnMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[14].Contains("00"))
            {
                checkBoxAnnMic.Width = checkBoxAnnMic.Parent.Width - checkBoxAnnMic.Left - 1;
                checkBoxAnnMic.Text = "ANN MIC";
                checkBoxAnnMic.Checked = false;
            }

            //
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[15].Contains("01"))
            {
                checkBoxStudioMic.Width = checkBoxStudioMic.Parent.Width - checkBoxStudioMic.Left - 1;
                checkBoxStudioMic.Text = "Studio MIC";
                checkBoxStudioMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[15].Contains("00"))
            {
                checkBoxStudioMic.Width = checkBoxStudioMic.Parent.Width - checkBoxStudioMic.Left - 1;
                checkBoxStudioMic.Text = "Studio MIC";
                checkBoxStudioMic.Checked = false;
            }

            //----------------------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[16].Contains("01"))
            {
                checkBoxOnair1ByA.Width = checkBoxOnair1ByA.Parent.Width - checkBoxOnair1ByA.Left - 1;
                checkBoxOnair1ByA.Text = "ONAIR 1 enabled by LINE A";
                checkBoxOnair1ByA.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[16].Contains("00"))
            {
                checkBoxOnair1ByA.Width = checkBoxOnair1ByA.Parent.Width - checkBoxOnair1ByA.Left - 1;
                checkBoxOnair1ByA.Text = "ONAIR 1 enabled by LINE A";
                checkBoxOnair1ByA.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[17].Contains("01"))
            {
                checkBoxOnair1ByB.Width = checkBoxOnair1ByB.Parent.Width - checkBoxOnair1ByB.Left - 1;
                checkBoxOnair1ByB.Text = "ONAIR 1 enabled by LINE B";
                checkBoxOnair1ByB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[17].Contains("00"))
            {
                checkBoxOnair1ByB.Width = checkBoxOnair1ByB.Parent.Width - checkBoxOnair1ByB.Left - 1;
                checkBoxOnair1ByB.Text = "ONAIR 1 enabled by LINE B";
                checkBoxOnair1ByB.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[18].Contains("01"))
            {
                checkBoxOnAir1ByMic.Width = checkBoxOnAir1ByMic.Parent.Width - checkBoxOnAir1ByMic.Left - 1;
                checkBoxOnAir1ByMic.Text = "ONAIR 1 enabled by MIC";
                checkBoxOnAir1ByMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[18].Contains("00"))
            {
                checkBoxOnAir1ByMic.Width = checkBoxOnAir1ByMic.Parent.Width - checkBoxOnAir1ByMic.Left - 1;
                checkBoxOnAir1ByMic.Text = "ONAIR 1 enabled by MIC";
                checkBoxOnAir1ByMic.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[19].Contains("01"))
            {
                checkBoxOnair2ByA.Width = checkBoxOnair2ByA.Parent.Width - checkBoxOnair2ByA.Left - 1;
                checkBoxOnair2ByA.Text = "ONAIR 2 enabled by LINE A";
                checkBoxOnair2ByA.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[19].Contains("00"))
            {
                checkBoxOnair2ByA.Width = checkBoxOnair2ByA.Parent.Width - checkBoxOnair2ByA.Left - 1;
                checkBoxOnair2ByA.Text = "ONAIR 2 enabled by LINE A";
                checkBoxOnair2ByA.Checked = false;
            }

            //------------22----------------------------------------------------------------------------------------
            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[20].Contains("01"))
            {
                checkBoxOnair2ByB.Width = checkBoxOnair2ByB.Parent.Width - checkBoxOnair2ByB.Left - 1;
                checkBoxOnair2ByB.Text = "ONAIR 2 enabled by LINE B";
                checkBoxOnair2ByB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[20].Contains("00"))
            {
                checkBoxOnair2ByB.Width = checkBoxOnair2ByB.Parent.Width - checkBoxOnair2ByB.Left - 1;
                checkBoxOnair2ByB.Text = "ONAIR 2 enabled by LINE B";
                checkBoxOnair2ByB.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[21].Contains("01"))
            {
                checkBoxOnAir2ByMic.Width = checkBoxOnAir2ByMic.Parent.Width - checkBoxOnAir2ByMic.Left - 1;
                checkBoxOnAir2ByMic.Text = "ONAIR 2 enabled by MIC";
                checkBoxOnAir2ByMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[21].Contains("00"))
            {
                checkBoxOnAir2ByMic.Width = checkBoxOnAir2ByMic.Parent.Width - checkBoxOnAir2ByMic.Left - 1;
                checkBoxOnAir2ByMic.Text = "ONAIR 2 enabled by MIC";
                checkBoxOnAir2ByMic.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[22].Contains("01"))
            {
                checkBoxModPowerOn.Width = checkBoxModPowerOn.Parent.Width - checkBoxModPowerOn.Left - 1;
                checkBoxModPowerOn.Text = "Module ON at Power";
                checkBoxModPowerOn.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[22].Contains("00"))
            {
                checkBoxModPowerOn.Width = checkBoxModPowerOn.Parent.Width - checkBoxModPowerOn.Left - 1;
                checkBoxModPowerOn.Text = "Module ON at Power";
                checkBoxModPowerOn.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[23].Contains("01"))
            {
                checkBoxMicLineA.Width = checkBoxMicLineA.Parent.Width - checkBoxMicLineA.Left - 1;
                checkBoxMicLineA.Text = "Mic at Line A";
                checkBoxMicLineA.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[23].Contains("00"))
            {
                checkBoxMicLineA.Width = checkBoxMicLineA.Parent.Width - checkBoxMicLineA.Left - 1;
                checkBoxMicLineA.Text = "Mic at Line A";
                checkBoxMicLineA.Checked = false;
            }
            //----------------------------------------------------------------------------------------------------

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[24].Contains("01"))
            {
                checkBoxMicLineB.Width = checkBoxMicLineB.Parent.Width - checkBoxMicLineB.Left - 1;
                checkBoxMicLineB.Text = "Mic at Line B";
                checkBoxMicLineB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[24].Contains("00"))
            {
                checkBoxMicLineB.Width = checkBoxMicLineB.Parent.Width - checkBoxMicLineB.Left - 1;
                checkBoxMicLineB.Text = "Mic at Line B";
                checkBoxMicLineB.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[25].Contains("01"))
            {
                checkBoxRemoteByMic.Width = checkBoxRemoteByMic.Parent.Width - checkBoxRemoteByMic.Left - 1;
                checkBoxRemoteByMic.Text = "Remote ON enabled by MIC";
                checkBoxRemoteByMic.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[25].Contains("00"))
            {
                checkBoxRemoteByMic.Width = checkBoxRemoteByMic.Parent.Width - checkBoxRemoteByMic.Left - 1;
                checkBoxRemoteByMic.Text = "Remote ON enabled by MIC";
                checkBoxRemoteByMic.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[26].Contains("01"))
            {
                checkBoxRemoteByA.Width = 180;
                checkBoxRemoteByA.Text = "Remote ON enabled by Line A";
                checkBoxRemoteByA.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[26].Contains("00"))
            {
                checkBoxRemoteByA.Width = 180;
                checkBoxRemoteByA.Text = "Remote ON enabled by Line A";
                checkBoxRemoteByA.Checked = false;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[27].Contains("01"))
            {
                checkBoxRemoteByB.Width = 180;
                checkBoxRemoteByB.Text = "Remote ON enabled by Line B";
                checkBoxRemoteByB.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[27].Contains("00"))
            {
                checkBoxRemoteByB.Width = 180;
                checkBoxRemoteByB.Text = "Remote ON enabled by Line B";
                checkBoxRemoteByB.Checked = false;
            }
            //----------------------------------------------------------------------------------------------------

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[28].Contains("01"))
            {
                checkBoxSwitchStart.Width = checkBoxSwitchStart.Parent.Width - checkBoxSwitchStart.Left - 1;
                checkBoxSwitchStart.Text = "Switch Start";
                checkBoxSwitchStart.Checked = true;
            }

            if (bericht.Contains("93") && vanwie.Contains(kanaal) && dedata[28].Contains("00"))
            {
                checkBoxSwitchStart.Width = checkBoxSwitchStart.Parent.Width - checkBoxSwitchStart.Left - 1;
                checkBoxSwitchStart.Text = "Switch Start";
                checkBoxSwitchStart.Checked = false;
            }
        }
    }
}