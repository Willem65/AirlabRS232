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
                checkBox12.Visible = true;
                checkBox13.Visible = true;
                checkBox14.Visible = false;
                checkBox15.Visible = false;
                checkBox16.Visible = false;
                checkBox17.Visible = false;
                checkBox18.Visible = true;
                checkBox19.Visible = true;
                checkBox20.Visible = false;
                checkBox21.Visible = true;
                checkBox22.Visible = true;
                checkBox23.Visible = false;
                checkBox24.Visible = true;
                checkBox25.Visible = false;
                checkBox26.Visible = false;
                checkBox27.Visible = false;
                checkBox28.Visible = false;
                checkBox29.Visible = false;
                checkBox30.Visible = false;
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