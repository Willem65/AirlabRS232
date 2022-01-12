using System;
using System.Threading;

namespace AirlabRS232
{
    //-------------------------------- ModuleSetup ----------------------------------------
    public partial class Form1
    {
        private void checkBoxTimerLineA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxTimerLineA.Checked == true) chTrueFalse = 1;
            else if (checkBoxTimerLineA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(2, chTrueFalse);
        }

        private void checkBoxTimerLineB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxTimerLineB.Checked == true) chTrueFalse = 1;
            else if (checkBoxTimerLineB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(3, chTrueFalse);
        }

        private void checkBoxTimerMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxTimerMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxTimerMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(4, chTrueFalse);
        }

        private void checkBoxStartLineA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartLineA.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartLineA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(5, chTrueFalse);
        }

        private void checkBoxStartLineB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartLineB.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartLineB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(6, chTrueFalse);
        }

        private void checkBoxStartMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(7, chTrueFalse);
        }

        private void checkBoxStartFader_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartFader.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartFader.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(8, chTrueFalse);
        }

        private void checkBoxStartOn_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartOn.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartOn.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(9, chTrueFalse);
        }

        private void checkBoxStartCue_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartCue.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartCue.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(10, chTrueFalse);
        }

        private void checkBoxStartPuls_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStartPuls.Checked == true) chTrueFalse = 1;
            else if (checkBoxStartPuls.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(11, chTrueFalse);
        }

        private void checkBoxRemoteCueA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRemoteCueA.Checked == true) chTrueFalse = 1;
            else if (checkBoxRemoteCueA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(12, chTrueFalse);
        }

        private void checkBoxRemoteCueB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRemoteCueB.Checked == true) chTrueFalse = 1;
            else if (checkBoxRemoteCueB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(13, chTrueFalse);
        }

        private void checkBoxRemoteCueByMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRemoteCueByMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxRemoteCueByMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(14, chTrueFalse);
        }

        private void checkBoxDjMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxDjMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxDjMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(15, chTrueFalse);
        }

        private void checkBoxAnnMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxAnnMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxAnnMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(16, chTrueFalse);
        }

        private void checkBoxStudioMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxStudioMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxStudioMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(17, chTrueFalse);
        }

        private void checkBoxOnair1ByA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxOnair1ByA.Checked == true) chTrueFalse = 1;
            else if (checkBoxOnair1ByA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(18, chTrueFalse);
        }

        private void checkBoxOnair1ByB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxOnair1ByB.Checked == true) chTrueFalse = 1;
            else if (checkBoxOnair1ByB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(19, chTrueFalse);
        }

        private void checkBoxOnAir1ByMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxOnAir1ByMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxOnAir1ByMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(20, chTrueFalse);
        }

        private void checkBoxOnair2ByA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxOnair2ByA.Checked == true) chTrueFalse = 1;
            else if (checkBoxOnair2ByA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(21, chTrueFalse);
        }

        private void checkBoxOnair2ByB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxOnair2ByB.Checked == true) chTrueFalse = 1;
            else if (checkBoxOnair2ByB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(22, chTrueFalse);
        }

        private void checkBoxOnAir2ByMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxOnAir2ByMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxOnAir2ByMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(23, chTrueFalse);
        }

        private void checkBoxModPowerOn_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxModPowerOn.Checked == true) chTrueFalse = 1;
            else if (checkBoxModPowerOn.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(24, chTrueFalse);
        }

        private void checkBoxMicLineA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxMicLineA.Checked == true) chTrueFalse = 1;
            else if (checkBoxMicLineA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(25, chTrueFalse);
        }

        private void checkBoxMicLineB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxMicLineB.Checked == true) chTrueFalse = 1;
            else if (checkBoxMicLineB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(26, chTrueFalse);
        }

        private void checkBoxRemoteByMic_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRemoteByMic.Checked == true) chTrueFalse = 1;
            else if (checkBoxRemoteByMic.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(27, chTrueFalse);
        }

        private void checkBoxRemoteByA_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRemoteByA.Checked == true) chTrueFalse = 1;
            else if (checkBoxRemoteByA.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(28, chTrueFalse);
        }

        private void checkBoxRemoteByB_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRemoteByB.Checked == true) chTrueFalse = 1;
            else if (checkBoxRemoteByB.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(29, chTrueFalse);
        }

        private void checkBoxSwitchStart_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxSwitchStart.Checked == true) chTrueFalse = 1;
            else if (checkBoxSwitchStart.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(30, chTrueFalse);
        }

        private void ChangeCheckBoxState(int boxnr, int chTrueFalse)
        {
            byte[] byteBuffer = new byte[31];
            byte kanaal = (byte) (Convert.ToByte(numericUpDown1.Value.ToString(), 10) - 0x1);
            byteBuffer[0] = 0x93;
            byteBuffer[1] = kanaal;

            for (int t = 2; t < 31; t++)
            {
                string hexValue = hexStr.Split(' ')[t];
                byteBuffer[t] = Convert.ToByte(hexValue, 16);
            }

            if (chTrueFalse == 1)
            {
                byteBuffer[boxnr] = 0x01;
            }
            else
            {
                byteBuffer[boxnr] = 0x00;
            }

            serialPort1.Write(byteBuffer, 0, 31);
            Thread.Sleep(70);
            readHexString();
        }
    }
}