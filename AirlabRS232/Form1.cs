using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirlabRS232
{
    //---------------------------------------- Begin van het programma -----------------------------------------------
    public partial class Form1 : Form
    {
        private int runOneTime = 0;  // Een keer iets runnen in de timer1 functie

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 50);
        }

        // Tijdens het laden van het Form de nodige dingen vooraf instellen
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxClearMsgBox.Checked = false;
            buttonSend.Enabled = false;
            buttonStartTimer.Enabled = false;
            buttonStopTimer.Enabled = false;
            buttonResetTimer.Enabled = false;
            buttonSaveInternal.Enabled = false;
            buttonSaveChipCard.Enabled = false;
            button7.Enabled = false;
            foreach (var serialPort in SerialPort.GetPortNames())
            {
                comboBoxComPort.Items.Add(serialPort);
            }
            groupBoxModule.Enabled = false;
            groupBoxMaster.Enabled = false;
        }

        //----------buttonConnect Start _Click-------------------------------------------------------------------------------------------------------------
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0x01;
            if (!(comboBoxComPort.Text.Length > 0)) return;

            try
            {
                serialPort1.PortName = comboBoxComPort.Text;
            }
            catch (Exception)
            {
                buttonDisconnect.Enabled = true;
                MessageBox.Show($"Seriële poortverbinding is mislukt\nDruk op de Stop Button en probeer opnieuw");
                return;
            }

            serialPort1.BaudRate = 57600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Encoding = System.Text.Encoding.Default;
            serialPort1.ReadTimeout = 1500;
            serialPort1.WriteTimeout = 1500;

            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                buttonDisconnect.Enabled = true;
                MessageBox.Show($"Seriële poortverbinding kan niet worden geopend\nDruk op de Stop Button en probeer opnieuw"); 
                return;
            }

            byte[] bytestosend = { 0xb5, 0x00, 0x00 }; // eventjes uit gezet
            try
            {
                serialPort1.Write(bytestosend, 0, 3);
            }
            catch (Exception)
            {
                buttonDisconnect.Enabled = true;
                MessageBox.Show($"Seriële poortverbinding is mislukt\nHeeft U soms niet de juiste comport gekozen ? \n");
                return;
            }

            buttonDisconnect.Enabled = false;
            Thread.Sleep(170);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = true;
            buttonSend.Enabled = true;
            buttonStartTimer.Enabled = true;
            buttonStopTimer.Enabled = true;
            buttonResetTimer.Enabled = true;
            buttonSaveInternal.Enabled = true;
            buttonSaveChipCard.Enabled = true;
            button7.Enabled = true;
            timer1.Start();
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
        }

        //###########################################################################################################################################
        //------------serialPort1_DataReceived-------------------------------------------------------------------------------------------------------
        //###########################################################################################################################################
        // 11111111111111 Werner D 1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111

        //private int currentMessageLength = 0;
        //private int totalMessageLength = 0;
        //private string newMessage = "";

        //public delegate void DelegateAanroep(string str);

        //private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    // Read all data in the buffer
        //    int hoeveelheidBytes = serialPort1.BytesToRead;
        //    byte[] buffer = new byte[hoeveelheidBytes];
        //    serialPort1.Read(buffer, 0, hoeveelheidBytes);

        //    // Walk over all bytes received.
        //    for (var index = 0; index < hoeveelheidBytes; index++)
        //    {
        //        var newByte = buffer[index];
        //        if (newByte >= 0x80)
        //        {
        //            // Start of message detected. Reset message and get total message length
        //            newMessage = "";
        //            currentMessageLength = 0;
        //            totalMessageLength = GetLengthForMessageType(newByte);
        //        }
        //        currentMessageLength++;
        //        newMessage += newByte.ToString("X2") + " ";

        //        // If message is complete, analyse it.
        //        if (currentMessageLength == totalMessageLength)
        //        {
        //            // Make a copy (maybe not needed in C#?)
        //            string msg = string.Copy(newMessage);
        //            textBoxMessages.Invoke(new DelegateAanroep(AnalyseData), msg);
        //        }
        //    }
        //}

        //// This method returns the length a specifc message type.
        //// For example. GetLengthForMessageType(0x80) -> 3.
        //private int GetLengthForMessageType(byte messageType)
        //{
        //    // Tabel met (bericht type, bericht lengte) voor elk type.
        //    int[,] messageLengths =
        //    {
        //        {0x80, 3},
        //        {0x81, 3},
        //        {0x82, 3},
        //        {0x83, 3},
        //        {0x84, 3},
        //        {0x85, 3},

        //        {0x90, 3},
        //        {0x91, 3},
        //        {0x92, 3},
        //        {0x93, 31},
        //        {0x94, 7},
        //        {0x95, 18},
        //        {0x96, 3},
        //        {0x97, 3},
        //        {0x98, 4},
        //        {0x9a, 32},

        //        {0xb3, 3},
        //        {0xb4, 3},
        //        {0xb5, 3},
        //        {0xb8, 3},
        //        {0xba, 3},

        //        {0xd0, 3},
        //    };

        //    totalMessageLength = 0;
        //    for (var idx = 0; idx < messageLengths.GetLength(0); idx++)
        //        if (messageLengths[idx, 0] == messageType)
        //        {
        //            totalMessageLength = messageLengths[idx, 1];
        //            break;
        //        }

        //    if (totalMessageLength == 0)
        //        MessageBox.Show("Onbekend messagetype 0x" + messageType.ToString("X2") + ", niet afgehandeld!");
        //    return totalMessageLength;
        //}

        //1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
        //##############################################################################################################
        //222222222222222222 Willem 222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222


        public delegate void DelegateAanroep(string str);

        private string bufferInhoud = "";
        private int positie, berichtLengte;

        // Zet wat er op de comport binnen komt, om in een string wat later geanalyseerd kan worden.
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int hoeveelheidBytes = serialPort1.BytesToRead;
            byte[] serialBuffer = new byte[serialPort1.BytesToRead];
            serialPort1.Read(serialBuffer, 0, hoeveelheidBytes);

            for (int index = 0; index < hoeveelheidBytes; index++)
            {
                if (serialBuffer[index] > 127)
                {
                    berichtLengte = ZoekDeLengteInDeFile(serialBuffer, index);
                    bufferInhoud = "";
                    positie = 0;                                                             // Reset positie teller
                }

                bufferInhoud = bufferInhoud + serialBuffer[index].ToString("X2") + " ";
                positie++;
                if (positie == berichtLengte)             // Kijk of de lengte gehaald is, en print de bufferinhoud dan pas uit
                {
                    string bufferCopy = string.Copy(bufferInhoud);                          // Kopie in C# is wel of niet nodig,  geen idee ?
                    textBoxMessages.Invoke(new DelegateAanroep(AnalyseData), bufferCopy);   // De uiteindelijke string verkregen
                }
            }
        }
        // Zoekt in de File "BerichtGrootte.txt" uit hoeveel bytes het bericht bestaat.
        private int ZoekDeLengteInDeFile(byte[] serialBuffer, int index)
        {
            StreamReader fileStream = new StreamReader(@"BerichtGrootte.txt");
            int lengteVanHetBericht = 0;
            while (true)
            {
                string readLineInFile = fileStream.ReadLine();
                if (readLineInFile == null)
                {
                    fileStream.Close();
                    break;
                }

                if (readLineInFile.Split(' ').Contains(serialBuffer[index].ToString()))
                {
                    lengteVanHetBericht = Convert.ToInt32(readLineInFile.Split(' ')[lengteVanHetBericht + 1]);
                }
            }
            return lengteVanHetBericht;
        }

        //22222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222222
        //##############################################################################################################
        //33333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333

        //private string bufferInhoud = "";

        //public delegate void DelegateAanroep(string str);

        //private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{

        //    Thread.Sleep(40);
        //    bufferInhoud = "";



        //    int hoeveelheidBytes = serialPort1.BytesToRead;
        //    byte[] buffer = new byte[hoeveelheidBytes];
        //    int nbrDataRead = serialPort1.Read(buffer, 0, hoeveelheidBytes);

        //    for (int index = 0; index < hoeveelheidBytes; index++)
        //    {
        //        bufferInhoud = bufferInhoud + buffer[index].ToString("X2") + " ";
        //    }

        //    string msg = string.Copy(bufferInhoud);
        //    textBoxMessages.Invoke(new DelegateAanroep(AnalyseData), msg);
        //    Debug.WriteLine(bufferInhoud);


        //}



        //33333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333
        //##############################################################################################################
        //444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444

        //private string bufferInhoud = "";
        //byte[] serialBuffer = new byte[100];
        //private int hoeveelheidBytesTemp;

        //public delegate void DelegateAanroep(string str);

        //private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{

        //    Thread.Sleep(40);
        //    int hoeveelheidBytes = serialPort1.BytesToRead;
        //    int nbrDataRead = serialPort1.Read(serialBuffer, hoeveelheidBytesTemp, hoeveelheidBytes);
        //    hoeveelheidBytesTemp += hoeveelheidBytes;


        //    for (int index = 0; index < hoeveelheidBytes; index++)
        //    {
        //        bufferInhoud = bufferInhoud + serialBuffer[index].ToString("X2") + " ";
        //    }

        //    hoeveelheidBytesTemp = 0;
        //    string msg = string.Copy(bufferInhoud);
        //    textBoxMessages.Invoke(new DelegateAanroep(AnalyseData), msg);
        //    Debug.WriteLine(bufferInhoud);
        //    bufferInhoud = "";

        //}




        //444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444444
        //##############################################################################################################





        // buttonDisconnect Comport verbinding verbreken
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (!(serialPort1.IsOpen)) return;
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
            serialPort1.Dispose();
            serialPort1.Close();
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            buttonSend.Enabled = false;
            textBoxMessages.Clear();
            runOneTime = 0;
            timer1.Stop();
            groupBoxMaster.Enabled = false;
            groupBoxModule.Enabled = false;
            buttonStartTimer.Enabled = false;
            buttonStopTimer.Enabled = false;
            buttonResetTimer.Enabled = false;
            buttonSaveInternal.Enabled = false;
            buttonSaveChipCard.Enabled = false;
            button7.Enabled = false;
        }




        // Zelf ingetikte data verzenden naar het muxbord buttonSend_Click
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            string buf = textBoxMyMessage.Text;
            string byteorg = buf.TrimEnd();
            int lengte = byteorg.Length;
            if (lengte > 1)
            {
                string byte1 = byteorg.Substring(0, lengte - 4);
                string byte2 = byteorg.Substring(2, lengte - 4);
                string byte3 = byteorg.Substring(4, lengte - 4);

                byte value1 = Convert.ToByte(byte1, 16);
                byte value2 = Convert.ToByte(byte2, 16);
                byte value3 = Convert.ToByte(byte3, 16);

                byte[] bytestosend = { value1, value2, value3 };
                serialPort1.Write(bytestosend, 0, 3);
            }
        }



        // Clear de inhoud van de messagebox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMessages.Clear();
        }



        // UpDown Selector, kies kanaal module 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            readHexString();
        }



        // Haal de informatie op van de Module die geselecteerd is door de UpDownSelector
        private void readHexString()
        {
            if (!serialPort1.IsOpen) return;
            byte numv = (byte) (Convert.ToByte(numericUpDown1.Value.ToString(), 10) - 0x1);
            byte[] bytestosend = { 0xb3, numv, 0x00 };
            serialPort1.Write(bytestosend, 0, 3);
        }



        // Start de Timer op de Airlab
        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            byte[] bytestosend = { 0x90, 0x00, 0x00 };
            serialPort1.Write(bytestosend, 0, 3);
        }





        // Save to Internal EEprom x24c16 op het mux bord
        private void buttonSaveInternal_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            byte[] bytestosend = { 0x96, 0x00, 0x00 };
            serialPort1.Write(bytestosend, 0, 3);
            MessageBox.Show("Alle instellingen zijn nu dusdanig opgeslagen dat ze ook na het uit en aanzetten van het apparaat worden bewaard. \n\nDe instellingen zijn nu opgeslagen in het EEPROMtje op het MUX bord X24C16 IC");
        }



        // Sla alle instellingen van de airlab op in de SmartCard
        private void buttonSaveChipCard_Click(object sender, EventArgs e)
        {
            if (label7.BackColor == Color.LightGray)
            {
                MessageBox.Show("Geen SmartCard aanwezig in het apparaat.\n\n");
            }
            else
            {
                byte[] bytestosend = {0x97, 0x00, 0x00};
                serialPort1.Write(bytestosend, 0, 3);
                MessageBox.Show("Alle instellingen worden nu op de SmartCard bewaard. \n\n");
            }
        }



        // Stop de Timer op de Airlab
        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            byte[] bytestosend = { 0x91, 0x00, 0x00 };
            serialPort1.Write(bytestosend, 0, 3);
        }



        // Reset de Timer op de Airlab
        private void buttonResetTimer_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            byte[] bytestosend = { 0x92, 0x00, 0x00 };
            serialPort1.Write(bytestosend, 0, 3);
        }



        private bool toggleButton7=false;

        private void comboBoxComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Schakel tussen ModuleSetup en MasterSetup de Timer op de Airlab
        private void button7_Click(object sender, EventArgs e)
        {

            toggleButton7 = !toggleButton7;
            if (toggleButton7)
            {
                byte[] bytestosend = {0xb4, 0x00, 0x00};
                serialPort1.Write(bytestosend, 0, 3);
                Thread.Sleep(170);
            }
            else
            {
                byte kanaal = (byte)(Convert.ToByte(numericUpDown1.Value.ToString(), 10) - 0x1);
                byte[] bytestosend = { 0xb3, kanaal, 0x00 };
                serialPort1.Write(bytestosend, 0, 3);
                Thread.Sleep(170);
            }
        }
    }
}


