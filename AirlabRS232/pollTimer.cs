using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace AirlabRS232
{
    //-------------------------------- Timer1 --------------------------------------------
    public partial class Form1
    {
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (runOneTime == 0 && serialPort1.IsOpen)
            {
                runOneTime = 1;
                Thread.Sleep(170);
                byte[] bytestosend = { 0xb3, 0x00, 0x00 };     // eventjes uitgezet
                serialPort1.Write(bytestosend, 0, 3);
            }

            if (bericht.Contains("93"))
            {
                groupBoxModule.Enabled = true;
                groupBoxMaster.Enabled = false;
            }
            else if (bericht.Contains("94"))
            {
                groupBoxMaster.Enabled = true;
                groupBoxModule.Enabled = false;
            }
            else
            {
                groupBoxMaster.Enabled = false;
                groupBoxModule.Enabled = false;
            }

            int value = 0;

            if (vanwie != "")
            {
                value = Convert.ToInt32(vanwie, 16);
            }

            

            if (deConfig[value] == "telcoKanaal" && bericht.Contains("93"))
            {
                groupBoxModule.Enabled = true;
                checkBoxTimerLineA.Visible = true;
                checkBoxTimerLineB.Visible = true;
                checkBoxTimerMic.Visible = false;
                checkBoxStartLineA.Visible = false;
                checkBoxStartLineB.Visible = false;
                checkBoxStartMic.Visible = false;
                checkBoxStartFader.Visible = false;
                checkBoxStartOn.Visible = false;
                checkBoxStartCue.Visible = false;
                checkBoxStartPuls.Visible = false;
                checkBoxRemoteCueA.Visible = true;
                checkBoxRemoteCueB.Visible = true;
                checkBoxRemoteCueByMic.Visible = false;
                checkBoxDjMic.Visible = false;
                checkBoxAnnMic.Visible = false;
                checkBoxStudioMic.Visible = false;
                checkBoxOnair1ByA.Visible = true;
                checkBoxOnair1ByB.Visible = true;
                checkBoxOnAir1ByMic.Visible = false;
                checkBoxOnair2ByA.Visible = true;
                checkBoxOnair2ByB.Visible = true;
                checkBoxOnAir2ByMic.Visible = false;
                checkBoxModPowerOn.Visible = true;
                checkBoxMicLineA.Visible = false;
                checkBoxMicLineB.Visible = false;
                checkBoxRemoteByMic.Visible = false;
                checkBoxRemoteByA.Visible = false;
                checkBoxRemoteByB.Visible = false;
                checkBoxSwitchStart.Visible = false;
            }

            if (deConfig[value] == "tripleKanaal" && bericht.Contains("93"))
            {
                groupBoxModule.Enabled = true;
                foreach (var vari in groupBoxModule.Controls)
                {
                    var cb = (CheckBox) vari;
                    if (cb != null)
                    {
                        cb.Visible = true;
                    }
                }
            }

            if (deConfig[value] == "leegKanaal" || !bericht.Contains("93"))
            {
                foreach (var vari in groupBoxModule.Controls)
                {
                    var cb = (CheckBox) vari;
                    if (cb != null)
                    {
                        cb.Visible = false;
                    }
                }
            }
        }
    }
}