using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace denemeSerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bayrak = 0, sayac2;
        bool calis = true;
        string dosyaYolu;
        int sayac;
        private void Calistir(string islem)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtMessage.Text = islem;
                    serialPort1.WriteLine(islem);
                    Thread.Sleep(1000);
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalistirHizli(string islem)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtMessage.Text = islem;
                    serialPort1.WriteLine(islem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();
            cboPort.Items.AddRange(ports);
            try
            {
                cboPort.SelectedIndex = 1;
                cboBRate.SelectedIndex = 11;
                comboBox1.SelectedIndex = 0;
                btnClose.Enabled = false;
                textBox3.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            System.IO.File.Create("testOlustur.txt");
            System.IO.File.Create("testOlustur2.txt");

        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {

            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            try
            {
                serialPort1.PortName = cboPort.Text;
                serialPort1.Open();
                serialPort1.BaudRate = Convert.ToInt32(cboBRate.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                sayac2 = 0;
                timer2.Start();
                serialPort1.WriteLine("GET_SW_VER");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Focus();
        }
        private int TestiCalistir(string satir, int satirSayisi)
        {
            calis = true;
            try
            {
                for (int k = 0; k < checkedListBox1.Items.Count; k++)
                {
                    if (checkedListBox1.GetItemChecked(k))
                    {
                        for (int i = 0; i < Convert.ToInt32(textBox3.Text); i++)
                        {
                            FileStream dosyaOku = new FileStream(checkedListBox1.Items[k].ToString(), FileMode.Open, FileAccess.Read);
                            label10.Text = (i + 1).ToString();
                            label11.Text = (Convert.ToInt32(textBox3.Text) - i - 1).ToString();
                            StreamReader oku = new StreamReader(dosyaOku);
                            satir = oku.ReadLine();
                            while (satir != null && calis == true)
                            {
                                if (satirSayisi != 0)
                                {
                                    int j;
                                    for (j = 0; j < satirSayisi; j++)
                                    {
                                        satir = oku.ReadLine();
                                    }
                                    if (j == satirSayisi) satirSayisi = 0;
                                    if (satir.Substring(0, 5) == "Bekle")
                                    {
                                        Thread.Sleep(TimeSpan.FromSeconds(Convert.ToInt32(satir.Substring(6))));
                                        Application.DoEvents();
                                    }
                                    else
                                    {
                                        Calistir(satir);
                                        txtMessage.Text = "\n";
                                    }
                                    satir = oku.ReadLine();
                                    sayac++;
                                }
                                else
                                {
                                    if (satir.Substring(0, 5) == "Bekle")
                                    {
                                        Thread.Sleep(TimeSpan.FromSeconds(Convert.ToInt32(satir.Substring(6))));
                                        Application.DoEvents();
                                    }
                                    else
                                    {
                                        Calistir(satir);
                                        txtMessage.Text = "\n";
                                    }
                                    satir = oku.ReadLine();
                                    sayac++;
                                }
                            }
                            oku.Close();
                            dosyaOku.Close();
                        }
                        label10.Text = "Test bitti.";
                        label11.Text = "Test bitti.";
                    }
                    //if(satir==null) btnDurDevam.Enabled = false;
                }
                return sayac;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }
        private void BtnSend_Click(object sender, EventArgs e)
        {
            sayac = 0;
            //btnDurDevam.Enabled = true;
            string satir = null;
            int a = TestiCalistir(satir, 0);
            label12.Focus();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            try
            {
                serialPort1.Close();
                System.IO.File.Delete("SW.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Focus();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                System.IO.File.Delete("testOlustur.txt");
                System.IO.File.Delete("testOlustur2.txt");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer1.Stop();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtReceive.Text = serialPort1.ReadExisting() + txtReceive.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dosya = new SaveFileDialog();
                dosya.ShowDialog();
                string dosyaYolu = dosya.FileName;
                FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(txtReceive.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Focus();
        }
        private void DosyayaYaz(string komut)
        {
            try
            {
                FileStream dosya2 = new FileStream("testOlustur.txt", FileMode.Append, FileAccess.Write);
                StreamWriter yaz = new StreamWriter(dosya2);
                yaz.WriteLine(komut);
                yaz.Flush();
                yaz.Close();
                dosya2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 1");
                Calistir("SETCHANNEL 1");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 1");
                CalistirHizli("KEY 1");
            }
            label12.Focus();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 2");
                Calistir("SETCHANNEL 2");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 2");
                CalistirHizli("KEY 2");
            }
            label12.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 3");
                Calistir("SETCHANNEL 3");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 3");
                CalistirHizli("KEY 3");
            }
            label12.Focus();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 4");
                Calistir("SETCHANNEL 4");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 4");
                CalistirHizli("KEY 4");
            }
            label12.Focus();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 5");
                Calistir("SETCHANNEL 5");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 5");
                CalistirHizli("KEY 5");
            }
            label12.Focus();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 6");
                Calistir("SETCHANNEL 6");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 6");
                CalistirHizli("KEY 6");
            }
            label12.Focus();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 7");
                Calistir("SETCHANNEL 7");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 7");
                CalistirHizli("KEY 7");
            }
            label12.Focus();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 8");
                Calistir("SETCHANNEL 8");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 8");
                CalistirHizli("KEY 8");
            }
            label12.Focus();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("SETCHANNEL 9");
                Calistir("SETCHANNEL 9");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("KEY 9");
                CalistirHizli("KEY 9");
            }
            label12.Focus();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY mute");
            Calistir("KEY mute");
            label12.Focus();
        }
        private void BtnSendTxt_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz(textBox1.Text);
            Calistir(textBox1.Text);
            textBox1.Clear();
            label12.Focus();
        }
        private void BtnDur_Click(object sender, EventArgs e)
        {
            calis = false;
            label12.Focus();
        }
        private void BtnDurDevam_Click(object sender, EventArgs e)
        {
            if (bayrak == 0)
            {
                btnDurDevam.BackColor = Color.Yellow;
                btnDurDevam.Text = "DEVAM ETTİR";
                bayrak = 1;
                calis = false;
            }
            else if (bayrak == 1)
            {
                btnDurDevam.BackColor = Color.Red;
                btnDurDevam.Text = "DURAKLAT";
                bayrak = 0;
                calis = true;
                int b = TestiCalistir("", sayac);
            }
            label12.Focus();
        }
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dosya = new SaveFileDialog();
                dosya.ShowDialog();
                dosyaYolu = dosya.FileName;
                System.IO.File.Copy("testOlustur.txt", dosyaYolu, true);
                checkedListBox1.Items.Add(dosyaYolu);
                System.IO.File.Delete("testOlustur.txt");
                System.IO.File.Create("testOlustur.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Focus();
        }
        private void BtnTestSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.ShowDialog();
                string fileN = file.FileName;
                checkedListBox1.Items.Add(fileN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Focus();
        }
        private void BtnAntenSecim_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Calistir("BROADCAST 0");
                if (checkBox2.Checked)
                    DosyayaYaz("BROADCAST 0");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox2.Checked)
                    DosyayaYaz("BROADCAST 1");
                Calistir("BROADCAST 1");
            }
            else
            {
                if (checkBox2.Checked)
                    DosyayaYaz("BROADCAST 2");
                Calistir("BROADCAST 2");
            }
            label12.Focus();
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY 0");
            CalistirHizli("KEY 0");
            label12.Focus();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY vol+");
            Calistir("KEY vol+");
            label12.Focus();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY vol-");
            Calistir("KEY vol-");
            label12.Focus();
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY prog+");
            Calistir("KEY prog+");
            label12.Focus();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY prog-");
            Calistir("KEY prog-");
            label12.Focus();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY up");
            Calistir("KEY up");
            label12.Focus();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY down");
            Calistir("KEY down");
            label12.Focus();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY right");
            Calistir("KEY right");
            label12.Focus();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY left");
            Calistir("KEY left");
            label12.Focus();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY ok");
            Calistir("KEY ok");
            label12.Focus();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY menu");
            Calistir("KEY menu");
            label12.Focus();
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("Bekle " + maskedTextBox1.Text);
            maskedTextBox1.Text = "";
            label12.Focus();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY tv");
            Calistir("KEY tv");
            label12.Focus();
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY exit");
            Calistir("KEY exit");
            label12.Focus();
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                int dizi = 0;
                FileStream d = new FileStream("testOlustur.txt", FileMode.Open, FileAccess.Read);
                StreamReader oku = new StreamReader(d);
                string s = oku.ReadLine();
                while (s != null)
                {
                    dizi++;
                    s = oku.ReadLine();
                }
                oku.Close();
                d.Close();
                FileStream f = new FileStream("testOlustur2.txt", FileMode.Open, FileAccess.Write);
                FileStream c = new FileStream("testOlustur.txt", FileMode.Open, FileAccess.Read);
                StreamReader oku2 = new StreamReader(c);
                StreamWriter yaz = new StreamWriter(f);
                int sayac = 0;
                s = oku2.ReadLine();
                while (s != null)
                {
                    if (sayac != (dizi - 1))
                        yaz.WriteLine(s);
                    sayac++;
                    s = oku2.ReadLine();
                }
                yaz.Close();
                oku2.Close();
                f.Close();
                c.Close();
                System.IO.File.Delete("testOlustur.txt");
                System.IO.File.Move("testOlustur2.txt", "testOlustur.txt");
                System.IO.File.Create("testOlustur2.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Focus();
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY netflix");
            Calistir("KEY netflix");
            label12.Focus();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY youtube");
            Calistir("KEY youtube");
            label12.Focus();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            label12.Focus();
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("testOlustur.txt");
            System.IO.File.Create("testOlustur.txt");
            label12.Focus();
        }


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("PICTUREMODE 1");
            Calistir("PICTUREMODE 1");
            label12.Focus();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("PICTUREMODE 2");
            Calistir("PICTUREMODE 2");
            label12.Focus();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("PICTUREMODE 3");
            Calistir("PICTUREMODE 3");
            label12.Focus();
        }
        private void Button30_Click(object sender, EventArgs e)
        {
            int sourceDeger = 0;
            int secili = comboBox2.SelectedIndex;
            if (secili == 0) sourceDeger = 0;
            else if (secili == 1) sourceDeger = 1;
            else if (secili == 2) sourceDeger = 3;
            else if (secili >= 3) sourceDeger = secili + 2;

            if (checkBox2.Checked)
                DosyayaYaz("SELECTSOURCE " + sourceDeger);
            Calistir("SELECTSOURCE " + sourceDeger);
            label12.Focus();
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            string secenek;
            if (comboBox3.SelectedIndex == 0) secenek = "eth0-";
            else if (comboBox3.SelectedIndex == 1) secenek = "wifi-";
            else secenek = "bt-";
            if (checkBox2.Checked)
                DosyayaYaz("set_mac_address " + secenek + textBox2.Text);
            Calistir("set_mac_address " + secenek + textBox2.Text);
            label12.Focus();
        }
        private void TxtReceive_TextChanged(object sender, EventArgs e)
        {
            label12.Focus();
        }

        private void Kapat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("BACKLIGHTDIM off");
            Calistir("BACKLIGHTDIM off");
            label12.Focus();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("BACKLIGHTDIM low");
            Calistir("BACKLIGHTDIM low");
            label12.Focus();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("BACKLIGHTDIM high");
            Calistir("BACKLIGHTDIM high");
            label12.Focus();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY amazon");
            Calistir("KEY amazon");
            label12.Focus();
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("KEY info");
            Calistir("KEY info");
            label12.Focus();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("SW.txt", serialPort1.ReadExisting());
            sayac++;
            if (sayac == 5)
            {
                timer2.Stop();
                FileStream f = new FileStream("SW.txt", FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(f);
                string satir = r.ReadLine();
                while (satir != null)
                {
                    if (satir.Contains("#*SW_VER"))
                        label6.Text = satir.Substring(10);
                    satir = r.ReadLine();
                }
                r.Close();
                f.Close();
                timer1.Start();
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("STANDBY");
            Calistir("STANDBY");
            label12.Focus();
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                DosyayaYaz("reboot");
            Calistir("reboot");
            label12.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!maskedTextBox1.Focused)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY right");
                    Calistir("KEY right");
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY left");
                    Calistir("KEY left");
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY down");
                    Calistir("KEY down");
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY up");
                    Calistir("KEY up");
                }
                if (e.KeyCode == Keys.NumPad0)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY 0");
                    CalistirHizli("KEY 0");
                }
                if (e.KeyCode == Keys.NumPad1)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 1");
                        Calistir("SETCHANNEL 1");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 1");
                        CalistirHizli("KEY 1");
                    }
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 2");
                        Calistir("SETCHANNEL 2");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 2");
                        CalistirHizli("KEY 2");
                    }
                }
                if (e.KeyCode == Keys.NumPad3)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 3");
                        Calistir("SETCHANNEL 3");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 3");
                        CalistirHizli("KEY 3");
                    }
                }
                if (e.KeyCode == Keys.NumPad4)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 4");
                        Calistir("SETCHANNEL 4");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 4");
                        CalistirHizli("KEY 4");
                    }
                }
                if (e.KeyCode == Keys.NumPad5)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 5");
                        Calistir("SETCHANNEL 5");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 5");
                        CalistirHizli("KEY 5");
                    }
                }
                if (e.KeyCode == Keys.NumPad6)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 6");
                        Calistir("SETCHANNEL 6");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 6");
                        CalistirHizli("KEY 6");
                    }
                }
                if (e.KeyCode == Keys.NumPad7)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 7");
                        Calistir("SETCHANNEL 7");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 7");
                        CalistirHizli("KEY 7");
                    }
                }
                if (e.KeyCode == Keys.NumPad8)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 8");
                        Calistir("SETCHANNEL 8");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 8");
                        CalistirHizli("KEY 8");
                    }
                }
                if (e.KeyCode == Keys.NumPad9)
                {
                    if (checkBox1.Checked)
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("SETCHANNEL 9");
                        Calistir("SETCHANNEL 9");
                    }
                    else
                    {
                        if (checkBox2.Checked)
                            DosyayaYaz("KEY 9");
                        CalistirHizli("KEY 9");
                    }
                }
                if (e.KeyCode == Keys.Add)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY vol+");
                    Calistir("KEY vol+");
                }
                if (e.KeyCode == Keys.Subtract)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY vol-");
                    Calistir("KEY vol-");
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY ok");
                    Calistir("KEY ok");
                }
                if (e.KeyCode == Keys.Escape)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY exit");
                    Calistir("KEY exit");
                }
                if (e.KeyCode == Keys.Home)
                {
                    if (checkBox2.Checked)
                        DosyayaYaz("KEY menu");
                    Calistir("KEY menu");
                }
            }
        }
    }    
}
