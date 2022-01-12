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
            this.checkBoxClearMsgBox = new System.Windows.Forms.CheckBox();
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
            this.checkBoxRemoteCueA = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoteCueB = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoteCueByMic = new System.Windows.Forms.CheckBox();
            this.checkBoxDjMic = new System.Windows.Forms.CheckBox();
            this.checkBoxAnnMic = new System.Windows.Forms.CheckBox();
            this.checkBoxStudioMic = new System.Windows.Forms.CheckBox();
            this.checkBoxOnair1ByA = new System.Windows.Forms.CheckBox();
            this.checkBoxOnair1ByB = new System.Windows.Forms.CheckBox();
            this.checkBoxOnAir1ByMic = new System.Windows.Forms.CheckBox();
            this.checkBoxOnair2ByA = new System.Windows.Forms.CheckBox();
            this.checkBoxOnair2ByB = new System.Windows.Forms.CheckBox();
            this.checkBoxOnAir2ByMic = new System.Windows.Forms.CheckBox();
            this.checkBoxModPowerOn = new System.Windows.Forms.CheckBox();
            this.checkBoxMicLineA = new System.Windows.Forms.CheckBox();
            this.checkBoxMicLineB = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoteByMic = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoteByA = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoteByB = new System.Windows.Forms.CheckBox();
            this.checkBoxSwitchStart = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoCueReset = new System.Windows.Forms.CheckBox();
            this.checkBoxCueToCrm = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoCom = new System.Windows.Forms.CheckBox();
            this.checkBoxRS232 = new System.Windows.Forms.CheckBox();
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.buttonStopTimer = new System.Windows.Forms.Button();
            this.buttonResetTimer = new System.Windows.Forms.Button();
            this.buttonSaveInternal = new System.Windows.Forms.Button();
            this.buttonSaveChipCard = new System.Windows.Forms.Button();
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
            // checkBoxClearMsgBox
            // 
            this.checkBoxClearMsgBox.AutoSize = true;
            this.checkBoxClearMsgBox.Location = new System.Drawing.Point(810, 47);
            this.checkBoxClearMsgBox.Name = "checkBoxClearMsgBox";
            this.checkBoxClearMsgBox.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClearMsgBox.TabIndex = 13;
            this.checkBoxClearMsgBox.UseVisualStyleBackColor = true;
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
            // checkBoxRemoteCueA
            // 
            this.checkBoxRemoteCueA.AutoSize = true;
            this.checkBoxRemoteCueA.Location = new System.Drawing.Point(10, 260);
            this.checkBoxRemoteCueA.Name = "checkBoxRemoteCueA";
            this.checkBoxRemoteCueA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemoteCueA.TabIndex = 28;
            this.checkBoxRemoteCueA.Text = "Remote CUE enabled by Line A";
            this.checkBoxRemoteCueA.UseVisualStyleBackColor = true;
            this.checkBoxRemoteCueA.Click += new System.EventHandler(this.checkBoxRemoteCueA_Click);
            // 
            // checkBoxRemoteCueB
            // 
            this.checkBoxRemoteCueB.AutoSize = true;
            this.checkBoxRemoteCueB.Location = new System.Drawing.Point(10, 283);
            this.checkBoxRemoteCueB.Name = "checkBoxRemoteCueB";
            this.checkBoxRemoteCueB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemoteCueB.TabIndex = 27;
            this.checkBoxRemoteCueB.Text = "Remote CUE enabled by Line B";
            this.checkBoxRemoteCueB.UseVisualStyleBackColor = true;
            this.checkBoxRemoteCueB.Click += new System.EventHandler(this.checkBoxRemoteCueB_Click);
            // 
            // checkBoxRemoteCueByMic
            // 
            this.checkBoxRemoteCueByMic.AutoSize = true;
            this.checkBoxRemoteCueByMic.Location = new System.Drawing.Point(10, 306);
            this.checkBoxRemoteCueByMic.Name = "checkBoxRemoteCueByMic";
            this.checkBoxRemoteCueByMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemoteCueByMic.TabIndex = 26;
            this.checkBoxRemoteCueByMic.Text = "Remote CUE enabled by MIC";
            this.checkBoxRemoteCueByMic.UseVisualStyleBackColor = true;
            this.checkBoxRemoteCueByMic.Click += new System.EventHandler(this.checkBoxRemoteCueByMic_Click);
            // 
            // checkBoxDjMic
            // 
            this.checkBoxDjMic.AutoSize = true;
            this.checkBoxDjMic.Location = new System.Drawing.Point(10, 330);
            this.checkBoxDjMic.Name = "checkBoxDjMic";
            this.checkBoxDjMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDjMic.TabIndex = 25;
            this.checkBoxDjMic.Text = "DJ MIC";
            this.checkBoxDjMic.UseVisualStyleBackColor = true;
            this.checkBoxDjMic.Click += new System.EventHandler(this.checkBoxDjMic_Click);
            // 
            // checkBoxAnnMic
            // 
            this.checkBoxAnnMic.AutoSize = true;
            this.checkBoxAnnMic.Location = new System.Drawing.Point(10, 353);
            this.checkBoxAnnMic.Name = "checkBoxAnnMic";
            this.checkBoxAnnMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnnMic.TabIndex = 24;
            this.checkBoxAnnMic.Text = "ANN MIC";
            this.checkBoxAnnMic.UseVisualStyleBackColor = true;
            this.checkBoxAnnMic.Click += new System.EventHandler(this.checkBoxAnnMic_Click);
            // 
            // checkBoxStudioMic
            // 
            this.checkBoxStudioMic.AutoSize = true;
            this.checkBoxStudioMic.Location = new System.Drawing.Point(10, 376);
            this.checkBoxStudioMic.Name = "checkBoxStudioMic";
            this.checkBoxStudioMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStudioMic.TabIndex = 23;
            this.checkBoxStudioMic.Text = "Studio MIC";
            this.checkBoxStudioMic.UseVisualStyleBackColor = true;
            this.checkBoxStudioMic.Click += new System.EventHandler(this.checkBoxStudioMic_Click);
            // 
            // checkBoxOnair1ByA
            // 
            this.checkBoxOnair1ByA.AutoSize = true;
            this.checkBoxOnair1ByA.Location = new System.Drawing.Point(191, 30);
            this.checkBoxOnair1ByA.Name = "checkBoxOnair1ByA";
            this.checkBoxOnair1ByA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnair1ByA.TabIndex = 34;
            this.checkBoxOnair1ByA.Text = "ONAIR 1 enabled by LINE A";
            this.checkBoxOnair1ByA.UseVisualStyleBackColor = true;
            this.checkBoxOnair1ByA.Click += new System.EventHandler(this.checkBoxOnair1ByA_Click);
            // 
            // checkBoxOnair1ByB
            // 
            this.checkBoxOnair1ByB.AutoSize = true;
            this.checkBoxOnair1ByB.Location = new System.Drawing.Point(191, 53);
            this.checkBoxOnair1ByB.Name = "checkBoxOnair1ByB";
            this.checkBoxOnair1ByB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnair1ByB.TabIndex = 33;
            this.checkBoxOnair1ByB.Text = "ONAIR 1 enabled by LINE B";
            this.checkBoxOnair1ByB.UseVisualStyleBackColor = true;
            this.checkBoxOnair1ByB.Click += new System.EventHandler(this.checkBoxOnair1ByB_Click);
            // 
            // checkBoxOnAir1ByMic
            // 
            this.checkBoxOnAir1ByMic.AutoSize = true;
            this.checkBoxOnAir1ByMic.Location = new System.Drawing.Point(191, 76);
            this.checkBoxOnAir1ByMic.Name = "checkBoxOnAir1ByMic";
            this.checkBoxOnAir1ByMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnAir1ByMic.TabIndex = 32;
            this.checkBoxOnAir1ByMic.Text = "ONAIR 1 enabled by MIC";
            this.checkBoxOnAir1ByMic.UseVisualStyleBackColor = true;
            this.checkBoxOnAir1ByMic.Click += new System.EventHandler(this.checkBoxOnAir1ByMic_Click);
            // 
            // checkBoxOnair2ByA
            // 
            this.checkBoxOnair2ByA.AutoSize = true;
            this.checkBoxOnair2ByA.Location = new System.Drawing.Point(191, 99);
            this.checkBoxOnair2ByA.Name = "checkBoxOnair2ByA";
            this.checkBoxOnair2ByA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnair2ByA.TabIndex = 31;
            this.checkBoxOnair2ByA.Text = "ONAIR 2 enabled by LINE A";
            this.checkBoxOnair2ByA.UseVisualStyleBackColor = true;
            this.checkBoxOnair2ByA.Click += new System.EventHandler(this.checkBoxOnair2ByA_Click);
            // 
            // checkBoxOnair2ByB
            // 
            this.checkBoxOnair2ByB.AutoSize = true;
            this.checkBoxOnair2ByB.Location = new System.Drawing.Point(191, 122);
            this.checkBoxOnair2ByB.Name = "checkBoxOnair2ByB";
            this.checkBoxOnair2ByB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnair2ByB.TabIndex = 38;
            this.checkBoxOnair2ByB.Text = "ONAIR 2 enabled by LINE B";
            this.checkBoxOnair2ByB.UseVisualStyleBackColor = true;
            this.checkBoxOnair2ByB.Click += new System.EventHandler(this.checkBoxOnair2ByB_Click);
            // 
            // checkBoxOnAir2ByMic
            // 
            this.checkBoxOnAir2ByMic.AutoSize = true;
            this.checkBoxOnAir2ByMic.Location = new System.Drawing.Point(191, 145);
            this.checkBoxOnAir2ByMic.Name = "ONAIR 2 enabled by MIC";
            this.checkBoxOnAir2ByMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnAir2ByMic.TabIndex = 37;
            this.checkBoxOnAir2ByMic.Text = "ONAIR 2 enabled by MIC";
            this.checkBoxOnAir2ByMic.UseVisualStyleBackColor = true;
            this.checkBoxOnAir2ByMic.Click += new System.EventHandler(this.checkBoxOnAir2ByMic_Click);
            // 
            // checkBoxModPowerOn
            // 
            this.checkBoxModPowerOn.AutoSize = true;
            this.checkBoxModPowerOn.Location = new System.Drawing.Point(191, 168);
            this.checkBoxModPowerOn.Name = "checkBoxModPowerOn";
            this.checkBoxModPowerOn.Size = new System.Drawing.Size(15, 14);
            this.checkBoxModPowerOn.TabIndex = 36;
            this.checkBoxModPowerOn.Text = "Module ON at Power";
            this.checkBoxModPowerOn.UseVisualStyleBackColor = true;
            this.checkBoxModPowerOn.Click += new System.EventHandler(this.checkBoxModPowerOn_Click);
            // 
            // checkBoxMicLineA
            // 
            this.checkBoxMicLineA.AutoSize = true;
            this.checkBoxMicLineA.Location = new System.Drawing.Point(191, 191);
            this.checkBoxMicLineA.Name = "checkBoxMicLineA";
            this.checkBoxMicLineA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMicLineA.TabIndex = 35;
            this.checkBoxMicLineA.Text = "Mic at Line A";
            this.checkBoxMicLineA.UseVisualStyleBackColor = true;
            this.checkBoxMicLineA.Click += new System.EventHandler(this.checkBoxMicLineA_Click);
            // 
            // checkBoxMicLineB
            // 
            this.checkBoxMicLineB.AutoSize = true;
            this.checkBoxMicLineB.Location = new System.Drawing.Point(191, 214);
            this.checkBoxMicLineB.Name = "checkBoxMicLineB";
            this.checkBoxMicLineB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMicLineB.TabIndex = 42;
            this.checkBoxMicLineB.Text = "Mic at Line B";
            this.checkBoxMicLineB.UseVisualStyleBackColor = true;
            this.checkBoxMicLineB.Click += new System.EventHandler(this.checkBoxMicLineB_Click);
            // 
            // checkBoxRemoteByMic
            // 
            this.checkBoxRemoteByMic.AutoSize = true;
            this.checkBoxRemoteByMic.Location = new System.Drawing.Point(191, 237);
            this.checkBoxRemoteByMic.Name = "checkBoxRemoteByMic";
            this.checkBoxRemoteByMic.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemoteByMic.TabIndex = 41;
            this.checkBoxRemoteByMic.Text = "Remote ON enabled by MIC";
            this.checkBoxRemoteByMic.UseVisualStyleBackColor = true;
            this.checkBoxRemoteByMic.Click += new System.EventHandler(this.checkBoxRemoteByMic_Click);
            // 
            // checkBoxRemoteByA
            // 
            this.checkBoxRemoteByA.AutoSize = true;
            this.checkBoxRemoteByA.Location = new System.Drawing.Point(191, 260);
            this.checkBoxRemoteByA.Name = "checkBoxRemoteByA";
            this.checkBoxRemoteByA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemoteByA.TabIndex = 40;
            this.checkBoxRemoteByA.Text = "Remote ON enabled by Line A";
            this.checkBoxRemoteByA.UseVisualStyleBackColor = true;
            this.checkBoxRemoteByA.Click += new System.EventHandler(this.checkBoxRemoteByA_Click);
            // 
            // checkBoxRemoteByB
            // 
            this.checkBoxRemoteByB.AutoSize = true;
            this.checkBoxRemoteByB.Location = new System.Drawing.Point(191, 283);
            this.checkBoxRemoteByB.Name = "checkBoxRemoteByB";
            this.checkBoxRemoteByB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemoteByB.TabIndex = 39;
            checkBoxRemoteByB.Text = "Remote ON enabled by Line B";
            this.checkBoxRemoteByB.UseVisualStyleBackColor = true;
            this.checkBoxRemoteByB.Click += new System.EventHandler(this.checkBoxRemoteByB_Click);
            // 
            // checkBoxSwitchStart
            // 
            this.checkBoxSwitchStart.AutoSize = true;
            this.checkBoxSwitchStart.Location = new System.Drawing.Point(191, 306);
            this.checkBoxSwitchStart.Name = "checkBoxSwitchStart";
            this.checkBoxSwitchStart.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSwitchStart.TabIndex = 43;
            this.checkBoxSwitchStart.Text = "Switch Start";
            this.checkBoxSwitchStart.UseVisualStyleBackColor = true;
            this.checkBoxSwitchStart.Click += new System.EventHandler(this.checkBoxSwitchStart_Click);
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
            // buttonStartTimer
            // 
            this.buttonStartTimer.Location = new System.Drawing.Point(33, 28);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTimer.TabIndex = 52;
            this.buttonStartTimer.Text = "Start";
            this.buttonStartTimer.UseVisualStyleBackColor = true;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // buttonStopTimer
            // 
            this.buttonStopTimer.Location = new System.Drawing.Point(33, 57);
            this.buttonStopTimer.Name = "buttonStopTimer";
            this.buttonStopTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonStopTimer.TabIndex = 53;
            this.buttonStopTimer.Text = "Stop";
            this.buttonStopTimer.UseVisualStyleBackColor = true;
            this.buttonStopTimer.Click += new System.EventHandler(this.buttonStopTimer_Click);
            // 
            // button4
            // 
            this.buttonResetTimer.Location = new System.Drawing.Point(33, 92);
            this.buttonResetTimer.Name = "buttonResetTimer";
            this.buttonResetTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonResetTimer.TabIndex = 54;
            this.buttonResetTimer.Text = "Reset";
            this.buttonResetTimer.UseVisualStyleBackColor = true;
            this.buttonResetTimer.Click += new System.EventHandler(this.buttonResetTimer_Click);
            // 
            // buttonSaveInternal
            // 
            this.buttonSaveInternal.Location = new System.Drawing.Point(25, 34);
            this.buttonSaveInternal.Name = "buttonSaveInternal";
            this.buttonSaveInternal.Size = new System.Drawing.Size(109, 23);
            this.buttonSaveInternal.TabIndex = 55;
            this.buttonSaveInternal.Text = "Save Internal";
            this.buttonSaveInternal.UseVisualStyleBackColor = true;
            this.buttonSaveInternal.Click += new System.EventHandler(this.buttonSaveInternal_Click);
            // 
            // buttonSaveChipCard
            // 
            this.buttonSaveChipCard.Location = new System.Drawing.Point(185, 34);
            this.buttonSaveChipCard.Name = "buttonSaveChipCard";
            this.buttonSaveChipCard.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveChipCard.TabIndex = 56;
            this.buttonSaveChipCard.Text = "Save to ChipCard";
            this.buttonSaveChipCard.UseVisualStyleBackColor = true;
            this.buttonSaveChipCard.Click += new System.EventHandler(this.buttonSaveChipCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.buttonStopTimer);
            this.groupBox1.Controls.Add(this.buttonStartTimer);
            this.groupBox1.Controls.Add(this.buttonResetTimer);
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
            this.groupBox3.Controls.Add(this.buttonSaveChipCard);
            this.groupBox3.Controls.Add(this.buttonSaveInternal);
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
            this.groupBoxModule.Controls.Add(this.checkBoxSwitchStart);
            this.groupBoxModule.Controls.Add(this.checkBoxMicLineB);
            this.groupBoxModule.Controls.Add(this.checkBoxRemoteByMic);
            this.groupBoxModule.Controls.Add(this.checkBoxRemoteByA);
            this.groupBoxModule.Controls.Add(this.checkBoxRemoteByB);
            this.groupBoxModule.Controls.Add(this.checkBoxOnair2ByB);
            this.groupBoxModule.Controls.Add(this.checkBoxOnAir2ByMic);
            this.groupBoxModule.Controls.Add(this.checkBoxModPowerOn);
            this.groupBoxModule.Controls.Add(this.checkBoxMicLineA);
            this.groupBoxModule.Controls.Add(this.checkBoxOnair1ByA);
            this.groupBoxModule.Controls.Add(this.checkBoxOnair1ByB);
            this.groupBoxModule.Controls.Add(this.checkBoxOnAir1ByMic);
            this.groupBoxModule.Controls.Add(this.checkBoxOnair2ByA);
            this.groupBoxModule.Controls.Add(this.checkBoxStartCue);
            this.groupBoxModule.Controls.Add(this.checkBoxStartPuls);
            this.groupBoxModule.Controls.Add(this.checkBoxRemoteCueA);
            this.groupBoxModule.Controls.Add(this.checkBoxRemoteCueB);
            this.groupBoxModule.Controls.Add(this.checkBoxRemoteCueByMic);
            this.groupBoxModule.Controls.Add(this.checkBoxDjMic);
            this.groupBoxModule.Controls.Add(this.checkBoxAnnMic);
            this.groupBoxModule.Controls.Add(this.checkBoxStudioMic);
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
            this.Controls.Add(this.checkBoxClearMsgBox);
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
        private System.Windows.Forms.CheckBox checkBoxClearMsgBox;
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
        private System.Windows.Forms.CheckBox checkBoxRemoteCueA;
        private System.Windows.Forms.CheckBox checkBoxRemoteCueB;
        private System.Windows.Forms.CheckBox checkBoxRemoteCueByMic;
        private System.Windows.Forms.CheckBox checkBoxDjMic;
        private System.Windows.Forms.CheckBox checkBoxAnnMic;
        private System.Windows.Forms.CheckBox checkBoxStudioMic;
        private System.Windows.Forms.CheckBox checkBoxOnair1ByA;
        private System.Windows.Forms.CheckBox checkBoxOnair1ByB;
        private System.Windows.Forms.CheckBox checkBoxOnAir1ByMic;
        private System.Windows.Forms.CheckBox checkBoxOnair2ByA;
        private System.Windows.Forms.CheckBox checkBoxOnair2ByB;
        private System.Windows.Forms.CheckBox checkBoxOnAir2ByMic;
        private System.Windows.Forms.CheckBox checkBoxModPowerOn;
        private System.Windows.Forms.CheckBox checkBoxMicLineA;
        private System.Windows.Forms.CheckBox checkBoxMicLineB;
        private System.Windows.Forms.CheckBox checkBoxRemoteByMic;
        private System.Windows.Forms.CheckBox checkBoxRemoteByA;
        private System.Windows.Forms.CheckBox checkBoxRemoteByB;
        private System.Windows.Forms.CheckBox checkBoxSwitchStart;
        private System.Windows.Forms.CheckBox checkBoxAutoCueReset;
        private System.Windows.Forms.CheckBox checkBoxCueToCrm;
        private System.Windows.Forms.CheckBox checkBoxAutoCom;
        private System.Windows.Forms.CheckBox checkBoxRS232;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Button buttonStopTimer;
        private System.Windows.Forms.Button buttonResetTimer;
        private System.Windows.Forms.Button buttonSaveInternal;
        private System.Windows.Forms.Button buttonSaveChipCard;
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

