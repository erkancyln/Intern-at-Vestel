namespace denemeSerialPort
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBRate = new System.Windows.Forms.ComboBox();
            this.btnSendTxt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDurDevam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Kapat = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button31 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button30 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button29 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAntenSecim = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestSec = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(104, 26);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 28);
            this.cboPort.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Bağlantıyı Kes";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(145, 137);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(220, 42);
            this.txtMessage.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(231, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 51);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Bağlantı Kur";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(371, 137);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 44);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Baud Rate:";
            // 
            // cboBRate
            // 
            this.cboBRate.FormattingEnabled = true;
            this.cboBRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "144000",
            "192000",
            "384000",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cboBRate.Location = new System.Drawing.Point(104, 60);
            this.cboBRate.Name = "cboBRate";
            this.cboBRate.Size = new System.Drawing.Size(121, 28);
            this.cboBRate.TabIndex = 12;
            // 
            // btnSendTxt
            // 
            this.btnSendTxt.Location = new System.Drawing.Point(125, 71);
            this.btnSendTxt.Name = "btnSendTxt";
            this.btnSendTxt.Size = new System.Drawing.Size(274, 33);
            this.btnSendTxt.TabIndex = 24;
            this.btnSendTxt.Text = "Gönder";
            this.btnSendTxt.UseVisualStyleBackColor = true;
            this.btnSendTxt.Click += new System.EventHandler(this.BtnSendTxt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 35);
            this.textBox1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Komut gönder:";
            // 
            // btnDurDevam
            // 
            this.btnDurDevam.BackColor = System.Drawing.Color.Red;
            this.btnDurDevam.Enabled = false;
            this.btnDurDevam.Location = new System.Drawing.Point(653, 521);
            this.btnDurDevam.Name = "btnDurDevam";
            this.btnDurDevam.Size = new System.Drawing.Size(118, 47);
            this.btnDurDevam.TabIndex = 27;
            this.btnDurDevam.Text = "DURAKLAT";
            this.btnDurDevam.UseVisualStyleBackColor = false;
            this.btnDurDevam.Visible = false;
            this.btnDurDevam.Click += new System.EventHandler(this.BtnDurDevam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button34);
            this.groupBox1.Controls.Add(this.button33);
            this.groupBox1.Controls.Add(this.button32);
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.button29);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button28);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 553);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrol";
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(455, 195);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(94, 39);
            this.button34.TabIndex = 85;
            this.button34.Text = "Reboot";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.Button34_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(342, 195);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(94, 39);
            this.button33.TabIndex = 84;
            this.button33.Text = "Standby";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.Button33_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(536, 251);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(82, 39);
            this.button32.TabIndex = 83;
            this.button32.Text = "İnfo";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.Button32_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(397, 302);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(102, 47);
            this.button25.TabIndex = 82;
            this.button25.Text = "AMAZON";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.Button25_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.radioButton5);
            this.groupBox10.Controls.Add(this.radioButton4);
            this.groupBox10.Controls.Add(this.Kapat);
            this.groupBox10.Location = new System.Drawing.Point(663, 395);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(109, 142);
            this.groupBox10.TabIndex = 81;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Backlight";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 101);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 24);
            this.radioButton5.TabIndex = 76;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Çok Aç";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 71);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 24);
            this.radioButton4.TabIndex = 75;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Az Aç";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // Kapat
            // 
            this.Kapat.AutoSize = true;
            this.Kapat.Location = new System.Drawing.Point(6, 41);
            this.Kapat.Name = "Kapat";
            this.Kapat.Size = new System.Drawing.Size(76, 24);
            this.Kapat.TabIndex = 74;
            this.Kapat.TabStop = true;
            this.Kapat.Text = "Kapat";
            this.Kapat.UseVisualStyleBackColor = true;
            this.Kapat.CheckedChanged += new System.EventHandler(this.Kapat_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBox3);
            this.groupBox9.Controls.Add(this.button31);
            this.groupBox9.Controls.Add(this.textBox2);
            this.groupBox9.Location = new System.Drawing.Point(519, 395);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(138, 142);
            this.groupBox9.TabIndex = 80;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Mac Adres";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Ethernet",
            "Wifi",
            "Bluetooth"});
            this.comboBox3.Location = new System.Drawing.Point(6, 69);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 81;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(26, 101);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(84, 35);
            this.button31.TabIndex = 80;
            this.button31.Text = "Gönder";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.Button31_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 79;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button30);
            this.groupBox8.Controls.Add(this.comboBox2);
            this.groupBox8.Location = new System.Drawing.Point(384, 395);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(123, 142);
            this.groupBox8.TabIndex = 78;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Source";
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(22, 75);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 32);
            this.button30.TabIndex = 1;
            this.button30.Text = "Aç";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.Button30_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TV",
            "SCART1",
            "SCART2",
            "FAV",
            "S-VIDEO",
            "HDMI1",
            "HDMI2",
            "HDMI3",
            "HDMI4",
            "YPBPR",
            "PC",
            "EXT2-S",
            "DTV",
            "BAV",
            "SCART1S",
            "DVD",
            "DVI",
            "DP (DISPLAY PORT) ",
            "OPS (for Signage Products)"});
            this.comboBox2.Location = new System.Drawing.Point(0, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton3);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Location = new System.Drawing.Point(266, 395);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(112, 142);
            this.groupBox7.TabIndex = 77;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Picture Mode";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cinema";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Natural";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dynamic";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(643, 116);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(87, 36);
            this.button29.TabIndex = 76;
            this.button29.Text = "Sıfırla";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.Button29_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maskedTextBox1);
            this.groupBox6.Controls.Add(this.button22);
            this.groupBox6.Location = new System.Drawing.Point(148, 395);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(113, 142);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Beklet";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 37);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 69;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(19, 79);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 36);
            this.button22.TabIndex = 44;
            this.button22.Text = "Bekle";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(643, 70);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(87, 40);
            this.button26.TabIndex = 70;
            this.button26.Text = "Geri Al";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.Button26_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(505, 302);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(101, 47);
            this.button28.TabIndex = 75;
            this.button28.Text = "YOUTUBE";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.Button28_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(298, 302);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(91, 47);
            this.button27.TabIndex = 74;
            this.button27.Text = "NETFLIX";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.Button27_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(617, 15);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(130, 49);
            this.btnOlustur.TabIndex = 43;
            this.btnOlustur.Text = "Test Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.btnAntenSecim);
            this.groupBox5.Location = new System.Drawing.Point(6, 395);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 142);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Anten Seçimi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Terrestrial",
            "Cable",
            "Satellite"});
            this.comboBox1.Location = new System.Drawing.Point(6, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 48;
            // 
            // btnAntenSecim
            // 
            this.btnAntenSecim.Location = new System.Drawing.Point(28, 79);
            this.btnAntenSecim.Name = "btnAntenSecim";
            this.btnAntenSecim.Size = new System.Drawing.Size(75, 42);
            this.btnAntenSecim.TabIndex = 49;
            this.btnAntenSecim.Text = "Aç";
            this.btnAntenSecim.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(34, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(208, 24);
            this.checkBox2.TabIndex = 70;
            this.checkBox2.Text = "Test Oluşturmaya Başlat";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(285, 251);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 39);
            this.button24.TabIndex = 67;
            this.button24.Text = "EXIT";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Button24_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(455, 251);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 39);
            this.button23.TabIndex = 66;
            this.button23.Text = "TV";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Button23_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(58, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 24);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "Kanala Git";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(370, 251);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(79, 39);
            this.button21.TabIndex = 64;
            this.button21.Text = "MENU";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(422, 80);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(48, 31);
            this.button20.TabIndex = 63;
            this.button20.Text = "OK";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(476, 80);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(54, 36);
            this.button19.TabIndex = 62;
            this.button19.Text = "right";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(417, 118);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(63, 33);
            this.button18.TabIndex = 61;
            this.button18.Text = "down";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(422, 35);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(48, 39);
            this.button17.TabIndex = 60;
            this.button17.Text = "up";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(366, 76);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(43, 39);
            this.button16.TabIndex = 59;
            this.button16.Text = "left";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(161, 312);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 46);
            this.button15.TabIndex = 58;
            this.button15.Text = "P-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(161, 268);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 40);
            this.button13.TabIndex = 57;
            this.button13.Text = "P+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(18, 312);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 44);
            this.button11.TabIndex = 56;
            this.button11.Text = "V-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 38);
            this.button1.TabIndex = 55;
            this.button1.Text = "V+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(94, 195);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 31);
            this.button14.TabIndex = 54;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(71, 285);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(77, 40);
            this.button12.TabIndex = 45;
            this.button12.Text = "MUTE";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(159, 156);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 33);
            this.button9.TabIndex = 44;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(94, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 33);
            this.button8.TabIndex = 43;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(34, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 33);
            this.button7.TabIndex = 42;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(159, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 34);
            this.button6.TabIndex = 41;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 34);
            this.button5.TabIndex = 40;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 34);
            this.button4.TabIndex = 39;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 33);
            this.button3.TabIndex = 38;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 33);
            this.button2.TabIndex = 37;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(34, 77);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 33);
            this.button10.TabIndex = 36;
            this.button10.TabStop = false;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTestSec);
            this.groupBox2.Controls.Add(this.btnDur);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 509);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 174);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(420, 234);
            this.checkedListBox1.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "SW:";
            // 
            // btnTestSec
            // 
            this.btnTestSec.Location = new System.Drawing.Point(225, 113);
            this.btnTestSec.Name = "btnTestSec";
            this.btnTestSec.Size = new System.Drawing.Size(205, 55);
            this.btnTestSec.TabIndex = 48;
            this.btnTestSec.Text = "Dosyadan Test Seç";
            this.btnTestSec.UseVisualStyleBackColor = true;
            this.btnTestSec.Click += new System.EventHandler(this.BtnTestSec_Click);
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(149, 430);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(136, 62);
            this.btnDur.TabIndex = 49;
            this.btnDur.Text = "DURDUR";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.BtnDur_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Kalan Test Adımı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Test Adımı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Tekrar Sayısı:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 43;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 113);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(205, 55);
            this.btnSend.TabIndex = 42;
            this.btnSend.Text = "Testi Başlat";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(497, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 608);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnDurDevam);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Test Başlatma";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test Oluşturma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboPort);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cboBRate);
            this.groupBox3.Location = new System.Drawing.Point(12, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 129);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Çalıştırılan Komut:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnSendTxt);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(27, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 129);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Komut Gönderme";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(12, 185);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceive.Size = new System.Drawing.Size(479, 321);
            this.txtReceive.TabIndex = 6;
            this.txtReceive.TextChanged += new System.EventHandler(this.TxtReceive_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1278, 627);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 656);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Yazılım Kalite Güvence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtMessage;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBRate;
        private System.Windows.Forms.Button btnSendTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDurDevam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnTestSec;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAntenSecim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton Kapat;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label label12;
    }
}

