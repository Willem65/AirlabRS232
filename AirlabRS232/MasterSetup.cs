using System;
using System.Threading;

namespace AirlabRS232
{
    //------------------------------------- MasterSetup -------------------------------------------------
    public partial class Form1
    {
        private void checkBoxAutoCueReset_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxAutoCueReset.Checked == true) chTrueFalse = 1;
            else if (checkBoxAutoCueReset.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxStateMaster(2, chTrueFalse);
        }

        private void checkBoxCueToCrm_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxCueToCrm.Checked == true) chTrueFalse = 1;
            else if (checkBoxCueToCrm.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxStateMaster(3, chTrueFalse);
        }

        private void checkBoxAutoCom_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxAutoCom.Checked == true) chTrueFalse = 1;
            else if (checkBoxAutoCom.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxStateMaster(4, chTrueFalse);
        }

        private void checkBoxRS232_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxRS232.Checked == true) chTrueFalse = 1;
            else if (checkBoxRS232.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxStateMaster(5, chTrueFalse);
        }

        private void checkBoxConsole_Click(object sender, EventArgs e)
        {
            int chTrueFalse = 0;
            if (checkBoxConsole.Checked == true) chTrueFalse = 1;
            else if (checkBoxConsole.Checked == false) chTrueFalse = 0;
            ChangeCheckBoxStateMaster(6, chTrueFalse);
        }

        private void ChangeCheckBoxStateMaster(int boxnr, int chTrueFalse)
        {
            byte[] byteBuffer = new byte[7];
            byteBuffer[0] = 0x94;
            byteBuffer[1] = 0x00;


            for (int t = 2; t < 7; t++)
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

            byteBuffer[5] = 0x01; // WARNING dit moet 6 zijn er wordt bewust een funtie overgeslagen, namelijk het kunnen uit zetten van de RS232 communicatie !?!?!
            byteBuffer[6] = 0x01; // Ook deze altijd aan gezet, anders kun je het op het mengpaneel zelf niet meer configureren
            serialPort1.Write(byteBuffer, 0, 7);
            Thread.Sleep(70);
            byte[] bytestosend = {0xb4, 0x0, 0x00};
            serialPort1.Write(bytestosend, 0, 3);
        }
    }
}