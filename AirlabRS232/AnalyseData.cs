using System;
using System.IO;

namespace AirlabRS232
{
    public partial class Form1
    {
        
        private int teller = 0;
        private string hexStr = "", bericht = "", vanwie = "";
        private string[] dedata = new string[100];

        //-------------------------------------- textBoxMessages, geef de dedata in tekst weer -----------------------------------------------------------
        private void AnalyseData(string text)
        {
            if (checkBoxClearMsgBox.Checked)
                textBoxMessages.Clear();

            hexStr = text;
            text = text + "EINDE BERICHT";

            //text = "9A 00 44 26 52 20 41 69 72 6C 61 62 20 76 32 2E 30 34 20 2D 20 30 38 2F 32 30 30 36 00 00 00 00 EINDE BERICHT";  // Test

            for (int t = 0; t < 100; t++)
            {
                dedata[t] = "00";
            }

            String lineSaved = "";

            bool vlag = false;

            textBoxMessages.AppendText(text + "\r\n\r\n");

            while (true)
            {
                string hexValue = "";
                hexValue = text.Split(' ')[teller];

                if (hexValue.Contains("EINDE") || hexValue.Contains("BERICHT")) return;

                int value = Convert.ToInt32(hexValue, 16);

                // Eerste Byte het Bericht
                if (value > 127) // Alles >= 0x80 is het begin van een bericht
                {
                    vlag = true;

                    StreamReader sr = new StreamReader(@"BerichtBegin.txt");

                    while (true)
                    {
                        String line = sr.ReadLine();
                        if (line == null)
                        {
                            sr.Close();
                            textBoxMessages.AppendText("\r\n");
                            break;
                        }

                        if ((line.Contains(hexValue)) && (line.Length > 2))
                        {
                            textBoxMessages.AppendText(line);
                            bericht = hexValue;
                            lineSaved = line;
                        }
                    }
                }


                // Tweede Byte van Wie
                teller++;
                hexValue = text.Split(' ')[teller];
                string tweedeByte = hexValue;
                if (vlag == true)
                {
                    vlag = false;

                    StreamReader sr = new StreamReader(@"Welk-Kanaal.txt");

                    while (true)
                    {
                        String line = sr.ReadLine();

                        if (line == null)
                        {
                            sr.Close();
                            textBoxMessages.AppendText("\r\n");
                            break;
                        }

                        if (line.Contains(hexValue))
                        {
                            if (bericht.Contains("80") || bericht.Contains("81") || bericht.Contains("82") || bericht.Contains("D5") ||
                                bericht.Contains("83") || bericht.Contains("93") || bericht.Contains("B3") || bericht.Contains("95"))
                            {
                                textBoxMessages.AppendText(line);
                            }
                            else
                            {
                                textBoxMessages.AppendText(hexValue + " <-- Kijk in de TABEL van wie dit BERICHT komt");
                            }

                            vanwie = hexValue;
                        }
                    }
                    
                    // Derde Byte en de rest, De Data , wat er mee moet gebeuren
                    for (int positie = 1; positie < 40; positie++)
                    {
                        hexValue = text.Split(' ')[positie + teller];

                        if (hexValue.Contains("EINDE") || hexValue.Contains("BERICHT"))
                        {
                            teller = 0;
                            textBoxMessages.AppendText("_________________________________________________________________________________________ \r\n\r\n");
                            ShowState(tweedeByte);
                            return;
                        }

                        int value2 = Convert.ToInt32(hexValue, 16);

                        if (value2 > 127) // Alles >= 0x80 is het begin van een bericht,  exstra ruimte tussen de regels
                        {
                            textBoxMessages.AppendText("\r\n");
                            break;
                        }

                        lineSaved = lineSaved.TrimEnd();
                        int lengte = lineSaved.Length;

                        if (lengte > 1)
                        {
                            string line3 = lineSaved.Substring(3, lengte - 3);
                            textBoxMessages.AppendText(hexValue + " <-- Kijk bij " + line3 +
                                                       " in de TABEL wat deze DATA betekent\r\n");
                            dedata[positie - 1] = hexValue;
                        }
                    }
                }
                ShowState(tweedeByte);
            }
        }
    }
}