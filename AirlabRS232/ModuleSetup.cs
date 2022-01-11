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

        private void checkBox12_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox12.Checked == true) chTrueFalse = 1;
            else if (checkBox12.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(12, chTrueFalse);
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox13.Checked == true) chTrueFalse = 1;
            else if (checkBox13.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(13, chTrueFalse);
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox14.Checked == true) chTrueFalse = 1;
            else if (checkBox14.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(14, chTrueFalse);
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox15.Checked == true) chTrueFalse = 1;
            else if (checkBox15.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(15, chTrueFalse);
        }

        private void checkBox16_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox16.Checked == true) chTrueFalse = 1;
            else if (checkBox16.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(16, chTrueFalse);
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox17.Checked == true) chTrueFalse = 1;
            else if (checkBox17.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(17, chTrueFalse);
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox18.Checked == true) chTrueFalse = 1;
            else if (checkBox18.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(18, chTrueFalse);
        }

        private void checkBox19_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox19.Checked == true) chTrueFalse = 1;
            else if (checkBox19.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(19, chTrueFalse);
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox20.Checked == true) chTrueFalse = 1;
            else if (checkBox20.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(20, chTrueFalse);
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox21.Checked == true) chTrueFalse = 1;
            else if (checkBox21.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(21, chTrueFalse);
        }

        private void checkBox22_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox22.Checked == true) chTrueFalse = 1;
            else if (checkBox22.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(22, chTrueFalse);
        }

        private void checkBox23_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox23.Checked == true) chTrueFalse = 1;
            else if (checkBox23.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(23, chTrueFalse);
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox24.Checked == true) chTrueFalse = 1;
            else if (checkBox24.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(24, chTrueFalse);
        }

        private void checkBox25_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox25.Checked == true) chTrueFalse = 1;
            else if (checkBox25.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(25, chTrueFalse);
        }

        private void checkBox26_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox26.Checked == true) chTrueFalse = 1;
            else if (checkBox26.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(26, chTrueFalse);
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox27.Checked == true) chTrueFalse = 1;
            else if (checkBox27.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(27, chTrueFalse);
        }

        private void checkBox28_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox28.Checked == true) chTrueFalse = 1;
            else if (checkBox28.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(28, chTrueFalse);
        }

        private void checkBox29_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox29.Checked == true) chTrueFalse = 1;
            else if (checkBox29.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxState(29, chTrueFalse);
        }

        private void checkBox30_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBox30.Checked == true) chTrueFalse = 1;
            else if (checkBox30.Checked == false) chTrueFalse = 0;
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