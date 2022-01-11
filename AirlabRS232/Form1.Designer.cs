namespace AirlabRS232
{
    partial class Form1
    {
        //------------------------------- Alle instellingen voor de design tools ----------------------------------------

        private System.ComponentModel.IContainer components = null;

        ///<param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.textBoxMyMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelOnAir1 = new System.Windows.Forms.Label();
            this.labelOnAir2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxTimerLineA = new System.Windows.Forms.CheckBox();
            this.checkBoxTimerLineB = new System.Windows.Forms.CheckBox();
            this.checkBoxTimerMic = new System.Windows.Forms.CheckBox();
            this.checkBoxStartLineA = new System.Windows.Forms.CheckBox();
            this.checkBoxStartLineB = new System.Windows.Forms.CheckBox();
            this.checkBoxStartMic = new System.Windows.Forms.CheckBox();
            this.checkBoxStartFader = new System.Windows.Forms.CheckBox();
            this.checkBoxStartOn = new System.Windows.Forms.CheckBox();
            this.checkBoxStartCue = new System.Windows.Forms.CheckBox();
            this.checkBoxStartPuls = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoCueReset = new System.Windows.Forms.CheckBox();
            this.checkBoxCueToCrm = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoCom = new System.Windows.Forms.CheckBox();
            this.checkBoxRS232 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMaster = new System.Windows.Forms.GroupBox();
            this.checkBoxConsole = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxModule = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxMaster.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(12, 39);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(143, 21);
            this.comboBoxComPort.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 70);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(55, 21);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Start";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(99, 70);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(56, 21);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Stop";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.AcceptsReturn = true;
            this.textBoxMessages.AcceptsTab = true;
            this.textBoxMessages.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessages.Location = new System.Drawing.Point(12, 113);
            this.textBoxMessages.Multiline = true;
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(945, 807);
            this.textBoxMessages.TabIndex = 2;
            // 
            // textBoxMyMessage
            // 
            this.textBoxMyMessage.Location = new System.Drawing.Point(970, 14);
            this.textBoxMyMessage.Name = "textBoxMyMessage";
            this.textBoxMyMessage.Size = new System.Drawing.Size(70, 20);
            this.textBoxMyMessage.TabIndex = 3;
            this.textBoxMyMessage.Text = "B30000";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(1050, 13);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(53, 20);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(827, 69);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 22);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelOnAir1
            // 
            this.labelOnAir1.AutoSize = true;
            this.labelOnAir1.BackColor = System.Drawing.Color.LightGray;
            this.labelOnAir1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnAir1.Location = new System.Drawing.Point(220, 31);
            this.labelOnAir1.Name = "labelOnAir1";
            this.labelOnAir1.Size = new System.Drawing.Size(94, 25);
            this.labelOnAir1.TabIndex = 7;
            this.labelOnAir1.Text = "ON AIR 1";
            // 
            // labelOnAir2
            // 
            this.labelOnAir2.AutoSize = true;
            this.labelOnAir2.BackColor = System.Drawing.Color.LightGray;
            this.labelOnAir2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnAir2.Location = new System.Drawing.Point(220, 85);
            this.labelOnAir2.Name = "labelOnAir2";
            this.labelOnAir2.Size = new System.Drawing.Size(94, 25);
            this.labelOnAir2.TabIndex = 8;
            this.labelOnAir2.Text = "ON AIR 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "CRM MUTE      ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "STUDIO MUTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(970, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 195);
            this.label5.TabIndex = 11;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Comport";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(810, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "CARD INSERTED";
            // 
            // checkBoxTimerLineA
            // 
            this.checkBoxTimerLineA.AutoSize = true;
            this.checkBoxTimerLineA.Location = new System.Drawing.Point(10, 30);
            this.checkBoxTimerLineA.Name = "checkBoxTimerLineA";
            this.checkBoxTimerLineA.Size = new System.Drawing.Size(140, 17);
            this.checkBoxTimerLineA.TabIndex = 15;
            this.checkBoxTimerLineA.Text = "Timer enabled by Line A";
            this.checkBoxTimerLineA.UseVisualStyleBackColor = true;
            this.checkBoxTimerLineA.Click += new System.EventHandler(this.checkBoxTimerLineA_Click);
            // 
            // checkBoxTimerLineB
            // 
            this.checkBoxTimerLineB.AutoSize = true;
            this.checkBoxTimerLineB.Location = new System.Drawing.Point(10, 53);
            this.checkBoxTimerLineB.Name = "checkBoxTimerLineB";
            this.checkBoxTimerLineB.Size = new System.Drawing.Size(140, 17);
            this.checkBoxTimerLineB.TabIndex = 16;
            this.checkBoxTimerLineB.Text = "Timer enabled by Line B";
            this.checkBoxTimerLineB.UseVisualStyleBackColor = true;
            this.checkBoxTimerLineB.Click += new System.EventHandler(this.checkBoxTimerLineB_Click);
            // 
            // checkBoxTimerMic
            // 
            this.checkBoxTimerMic.AutoSize = true;
            this.checkBoxTimerMic.Location = new System.Drawing.Point(10, 76);
            this.checkBoxTimerMic.Name = "checkBoxTimerMic";
            this.checkBoxTimerMic.Size = new System.Drawing.Size(127, 17);
            this.checkBoxTimerMic.TabIndex = 17;
            this.checkBoxTimerMic.Text = "Timer enabled by Mic";
            this.checkBoxTimerMic.UseVisualStyleBackColor = true;
            this.checkBoxTimerMic.Click += new System.EventHandler(this.checkBoxTimerMic_Click);
            // 
            // checkBoxStartLineA
            // 
            this.checkBoxStartLineA.AutoSize = true;
            this.checkBoxStartLineA.Location = new System.Drawing.Point(10, 98);
            this.checkBoxStartLineA.Name = "checkBoxStartLineA";
            this.checkBoxStartLineA.Size = new System.Drawing.Size(136, 17);
            this.checkBoxStartLineA.TabIndex = 18;
            this.checkBoxStartLineA.Text = "Start enabled by Line A";
            this.checkBoxStartLineA.UseVisualStyleBackColor = true;
            this.checkBoxStartLineA.Click += new System.EventHandler(this.checkBoxStartLineA_Click);
            // 
            // checkBoxStartLineB
            // 
            this.checkBoxStartLineB.AutoSize = true;
            this.checkBoxStartLineB.Location = new System.Drawing.Point(10, 122);
            this.checkBoxStartLineB.Name = "checkBoxStartLineB";
            this.checkBoxStartLineB.Size = new System.Drawing.Size(136, 17);
            this.checkBoxStartLineB.TabIndex = 22;
            this.checkBoxStartLineB.Text = "Start enabled by Line B";
            this.checkBoxStartLineB.UseVisualStyleBackColor = true;
            this.checkBoxStartLineB.Click += new System.EventHandler(this.checkBoxStartLineB_Click);
            // 
            // checkBoxStartMic
            // 
            this.checkBoxStartMic.AutoSize = true;
            this.checkBoxStartMic.Location = new System.Drawing.Point(10, 145);
            this.checkBoxStartMic.Name = "checkBoxStartMic";
            this.checkBoxStartMic.Size = new System.Drawing.Size(125, 17);
            this.checkBoxStartMic.TabIndex = 21;
            this.checkBoxStartMic.Text = "Start enabled by MIC";
            this.checkBoxStartMic.UseVisualStyleBackColor = true;
            this.checkBoxStartMic.Click += new System.EventHandler(this.checkBoxStartMic_Click);
            // 
            // checkBoxStartFader
            // 
            this.checkBoxStartFader.AutoSize = true;
            this.checkBoxStartFader.Location = new System.Drawing.Point(10, 168);
            this.checkBoxStartFader.Name = "checkBoxStartFader";
            this.checkBoxStartFader.Size = new System.Drawing.Size(152, 17);
            this.checkBoxStartFader.TabIndex = 20;
            this.checkBoxStartFader.Text = "Start generated by FADER";
            this.checkBoxStartFader.UseVisualStyleBackColor = true;
            this.checkBoxStartFader.Click += new System.EventHandler(this.checkBoxStartFader_Click);
            // 
            // checkBoxStartOn
            // 
            this.checkBoxStartOn.AutoSize = true;
            this.checkBoxStartOn.Location = new System.Drawing.Point(10, 191);
            this.checkBoxStartOn.Name = "checkBoxStartOn";
            this.checkBoxStartOn.Size = new System.Drawing.Size(132, 17);
            this.checkBoxStartOn.TabIndex = 19;
            this.checkBoxStartOn.Text = "Start generated by ON";
            this.checkBoxStartOn.UseVisualStyleBackColor = true;
            this.checkBoxStartOn.Click += new System.EventHandler(this.checkBoxStartOn_Click);
            // 
            // checkBoxStartCue
            // 
            this.checkBoxStartCue.AutoSize = true;
            this.checkBoxStartCue.Location = new System.Drawing.Point(10, 214);
            this.checkBoxStartCue.Name = "checkBoxStartCue";
            this.checkBoxStartCue.Size = new System.Drawing.Size(138, 17);
            this.checkBoxStartCue.TabIndex = 30;
            this.checkBoxStartCue.Text = "Start generated by CUE";
            this.checkBoxStartCue.UseVisualStyleBackColor = true;
            this.checkBoxStartCue.Click += new System.EventHandler(this.checkBoxStartCue_Click);
            // 
            // checkBoxStartPuls
            // 
            this.checkBoxStartPuls.AutoSize = true;
            this.checkBoxStartPuls.Location = new System.Drawing.Point(10, 237);
            this.checkBoxStartPuls.Name = "checkBoxStartPuls";
            this.checkBoxStartPuls.Size = new System.Drawing.Size(157, 17);
            this.checkBoxStartPuls.TabIndex = 29;
            this.checkBoxStartPuls.Text = "Start is PULS or Continuous";
            this.checkBoxStartPuls.UseVisualStyleBackColor = true;
            this.checkBoxStartPuls.Click += new System.EventHandler(this.checkBoxStartPuls_Click);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(10, 260);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 28;
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.Click += new System.EventHandler(this.checkBox12_Click);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(10, 283);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 27;
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.Click += new System.EventHandler(this.checkBox13_Click);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(10, 306);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 26;
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.Click += new System.EventHandler(this.checkBox14_Click);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(10, 330);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 25;
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.Click += new System.EventHandler(this.checkBox15_Click);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(10, 353);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 14);
            this.checkBox16.TabIndex = 24;
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.Click += new System.EventHandler(this.checkBox16_Click);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(10, 376);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(15, 14);
            this.checkBox17.TabIndex = 23;
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.Click += new System.EventHandler(this.checkBox17_Click);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(191, 30);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(15, 14);
            this.checkBox18.TabIndex = 34;
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.Click += new System.EventHandler(this.checkBox18_Click);
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(191, 53);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(15, 14);
            this.checkBox19.TabIndex = 33;
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.Click += new System.EventHandler(this.checkBox19_Click);
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(191, 76);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(15, 14);
            this.checkBox20.TabIndex = 32;
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.Click += new System.EventHandler(this.checkBox20_Click);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(191, 99);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(15, 14);
            this.checkBox21.TabIndex = 31;
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.Click += new System.EventHandler(this.checkBox21_Click);
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(191, 122);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(15, 14);
            this.checkBox22.TabIndex = 38;
            this.checkBox22.UseVisualStyleBackColor = true;
            this.checkBox22.Click += new System.EventHandler(this.checkBox22_Click);
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(191, 145);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(15, 14);
            this.checkBox23.TabIndex = 37;
            this.checkBox23.UseVisualStyleBackColor = true;
            this.checkBox23.Click += new System.EventHandler(this.checkBox23_Click);
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(191, 168);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(15, 14);
            this.checkBox24.TabIndex = 36;
            this.checkBox24.UseVisualStyleBackColor = true;
            this.checkBox24.Click += new System.EventHandler(this.checkBox24_Click);
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(191, 191);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(15, 14);
            this.checkBox25.TabIndex = 35;
            this.checkBox25.UseVisualStyleBackColor = true;
            this.checkBox25.Click += new System.EventHandler(this.checkBox25_Click);
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(191, 214);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(15, 14);
            this.checkBox26.TabIndex = 42;
            this.checkBox26.UseVisualStyleBackColor = true;
            this.checkBox26.Click += new System.EventHandler(this.checkBox26_Click);
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(191, 237);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(15, 14);
            this.checkBox27.TabIndex = 41;
            this.checkBox27.UseVisualStyleBackColor = true;
            this.checkBox27.Click += new System.EventHandler(this.checkBox27_Click);
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(191, 260);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(15, 14);
            this.checkBox28.TabIndex = 40;
            this.checkBox28.UseVisualStyleBackColor = true;
            this.checkBox28.Click += new System.EventHandler(this.checkBox28_Click);
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(191, 283);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(15, 14);
            this.checkBox29.TabIndex = 39;
            this.checkBox29.UseVisualStyleBackColor = true;
            this.checkBox29.Click += new System.EventHandler(this.checkBox29_Click);
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(191, 306);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(15, 14);
            this.checkBox30.TabIndex = 43;
            this.checkBox30.UseVisualStyleBackColor = true;
            this.checkBox30.Click += new System.EventHandler(this.checkBox30_Click);
            // 
            // checkBoxAutoCueReset
            // 
            this.checkBoxAutoCueReset.AutoSize = true;
            this.checkBoxAutoCueReset.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAutoCueReset.Name = "checkBoxAutoCueReset";
            this.checkBoxAutoCueReset.Size = new System.Drawing.Size(104, 17);
            this.checkBoxAutoCueReset.TabIndex = 46;
            this.checkBoxAutoCueReset.Text = "Auto CUE Reset";
            this.checkBoxAutoCueReset.UseVisualStyleBackColor = true;
            this.checkBoxAutoCueReset.Click += new System.EventHandler(this.checkBoxAutoCueReset_Click);
            // 
            // checkBoxCueToCrm
            // 
            this.checkBoxCueToCrm.AutoSize = true;
            this.checkBoxCueToCrm.Location = new System.Drawing.Point(6, 42);
            this.checkBoxCueToCrm.Name = "checkBoxCueToCrm";
            this.checkBoxCueToCrm.Size = new System.Drawing.Size(87, 17);
            this.checkBoxCueToCrm.TabIndex = 47;
            this.checkBoxCueToCrm.Text = "CUE to CRM";
            this.checkBoxCueToCrm.UseVisualStyleBackColor = true;
            this.checkBoxCueToCrm.Click += new System.EventHandler(this.checkBoxCueToCrm_Click);
            // 
            // checkBoxAutoCom
            // 
            this.checkBoxAutoCom.AutoSize = true;
            this.checkBoxAutoCom.Location = new System.Drawing.Point(6, 64);
            this.checkBoxAutoCom.Name = "checkBoxAutoCom";
            this.checkBoxAutoCom.Size = new System.Drawing.Size(123, 17);
            this.checkBoxAutoCom.TabIndex = 49;
            this.checkBoxAutoCom.Text = "Auto Communication";
            this.checkBoxAutoCom.UseVisualStyleBackColor = true;
            this.checkBoxAutoCom.Click += new System.EventHandler(this.checkBoxAutoCom_Click);
            // 
            // checkBoxRS232
            // 
            this.checkBoxRS232.AutoSize = true;
            this.checkBoxRS232.Location = new System.Drawing.Point(6, 88);
            this.checkBoxRS232.Name = "checkBoxRS232";
            this.checkBoxRS232.Size = new System.Drawing.Size(179, 17);
            this.checkBoxRS232.TabIndex = 48;
            this.checkBoxRS232.Text = "Enable RS232 (Always Enabled)";
            this.checkBoxRS232.UseVisualStyleBackColor = true;
            this.checkBoxRS232.Click += new System.EventHandler(this.checkBoxRS232_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 53;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 55;
            this.button5.Text = "Save Internal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(185, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 56;
            this.button6.Text = "Save to ChipCard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(1157, 681);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 146);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // groupBoxMaster
            // 
            this.groupBoxMaster.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBoxMaster.Controls.Add(this.checkBoxConsole);
            this.groupBoxMaster.Controls.Add(this.checkBoxRS232);
            this.groupBoxMaster.Controls.Add(this.checkBoxCueToCrm);
            this.groupBoxMaster.Controls.Add(this.checkBoxAutoCueReset);
            this.groupBoxMaster.Controls.Add(this.checkBoxAutoCom);
            this.groupBoxMaster.Enabled = false;
            this.groupBoxMaster.Location = new System.Drawing.Point(966, 681);
            this.groupBoxMaster.Name = "groupBoxMaster";
            this.groupBoxMaster.Size = new System.Drawing.Size(185, 146);
            this.groupBoxMaster.TabIndex = 61;
            this.groupBoxMaster.TabStop = false;
            this.groupBoxMaster.Text = "Master Settings";
            // 
            // checkBoxConsole
            // 
            this.checkBoxConsole.AutoSize = true;
            this.checkBoxConsole.Location = new System.Drawing.Point(6, 111);
            this.checkBoxConsole.Name = "checkBoxConsole";
            this.checkBoxConsole.Size = new System.Drawing.Size(173, 17);
            this.checkBoxConsole.TabIndex = 50;
            this.checkBoxConsole.Text = "Enable Setup Console (Always)";
            this.checkBoxConsole.UseVisualStyleBackColor = true;
            this.checkBoxConsole.Click += new System.EventHandler(this.checkBoxConsole_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(966, 833);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 87);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage";
            // 
            // groupBoxModule
            // 
            this.groupBoxModule.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxModule.Controls.Add(this.checkBox30);
            this.groupBoxModule.Controls.Add(this.checkBox26);
            this.groupBoxModule.Controls.Add(this.checkBox27);
            this.groupBoxModule.Controls.Add(this.checkBox28);
            this.groupBoxModule.Controls.Add(this.checkBox29);
            this.groupBoxModule.Controls.Add(this.checkBox22);
            this.groupBoxModule.Controls.Add(this.checkBox23);
            this.groupBoxModule.Controls.Add(this.checkBox24);
            this.groupBoxModule.Controls.Add(this.checkBox25);
            this.groupBoxModule.Controls.Add(this.checkBox18);
            this.groupBoxModule.Controls.Add(this.checkBox19);
            this.groupBoxModule.Controls.Add(this.checkBox20);
            this.groupBoxModule.Controls.Add(this.checkBox21);
            this.groupBoxModule.Controls.Add(this.checkBoxStartCue);
            this.groupBoxModule.Controls.Add(this.checkBoxStartPuls);
            this.groupBoxModule.Controls.Add(this.checkBox12);
            this.groupBoxModule.Controls.Add(this.checkBox13);
            this.groupBoxModule.Controls.Add(this.checkBox14);
            this.groupBoxModule.Controls.Add(this.checkBox15);
            this.groupBoxModule.Controls.Add(this.checkBox16);
            this.groupBoxModule.Controls.Add(this.checkBox17);
            this.groupBoxModule.Controls.Add(this.checkBoxStartLineB);
            this.groupBoxModule.Controls.Add(this.checkBoxStartMic);
            this.groupBoxModule.Controls.Add(this.checkBoxStartFader);
            this.groupBoxModule.Controls.Add(this.checkBoxStartOn);
            this.groupBoxModule.Controls.Add(this.checkBoxStartLineA);
            this.groupBoxModule.Controls.Add(this.checkBoxTimerMic);
            this.groupBoxModule.Controls.Add(this.checkBoxTimerLineB);
            this.groupBoxModule.Controls.Add(this.checkBoxTimerLineA);
            this.groupBoxModule.Location = new System.Drawing.Point(966, 245);
            this.groupBoxModule.Name = "groupBoxModule";
            this.groupBoxModule.Size = new System.Drawing.Size(373, 404);
            this.groupBoxModule.TabIndex = 63;
            this.groupBoxModule.TabStop = false;
            this.groupBoxModule.Text = "Module Setup";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1139, 234);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 44;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(831, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Auto Clear";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(970, 650);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 25);
            this.button7.TabIndex = 65;
            this.button7.Text = "Change Master or Module";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1073, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Module nr :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1160, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 75);
            this.label10.TabIndex = 67;
            this.label10.Text = "930000 SEND/RECIEVE MODULE \r\n94xx00 SEND/RECIEVE MASTER \r\n95xx01 Triple/Telco ide" +
    "ntification\r\n98xx01 Card Inserted\r\n9Axx1-30  ID Version String ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1160, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 105);
            this.label11.TabIndex = 68;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(221, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "84xx00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(221, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 70;
            this.label15.Text = "85xx00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(334, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 71;
            this.label16.Text = "D00000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(335, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 15);
            this.label17.TabIndex = 72;
            this.label17.Text = "D00100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(566, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 15);
            this.label18.TabIndex = 73;
            this.label18.Text = "98xx00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1355, 932);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBoxModule);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxMaster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOnAir2);
            this.Controls.Add(this.labelOnAir1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMyMessage);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxComPort);
            this.Name = "Form1";
            this.Text = "RS232-11012022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMaster.ResumeLayout(false);
            this.groupBoxMaster.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxModule.ResumeLayout(false);
            this.groupBoxModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.TextBox textBoxMyMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelOnAir1;
        private System.Windows.Forms.Label labelOnAir2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxTimerLineA;
        private System.Windows.Forms.CheckBox checkBoxTimerLineB;
        private System.Windows.Forms.CheckBox checkBoxTimerMic;
        private System.Windows.Forms.CheckBox checkBoxStartLineA;
        private System.Windows.Forms.CheckBox checkBoxStartLineB;
        private System.Windows.Forms.CheckBox checkBoxStartMic;
        private System.Windows.Forms.CheckBox checkBoxStartFader;
        private System.Windows.Forms.CheckBox checkBoxStartOn;
        private System.Windows.Forms.CheckBox checkBoxStartCue;
        private System.Windows.Forms.CheckBox checkBoxStartPuls;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBoxAutoCueReset;
        private System.Windows.Forms.CheckBox checkBoxCueToCrm;
        private System.Windows.Forms.CheckBox checkBoxAutoCom;
        private System.Windows.Forms.CheckBox checkBoxRS232;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMaster;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxModule;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBoxConsole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

