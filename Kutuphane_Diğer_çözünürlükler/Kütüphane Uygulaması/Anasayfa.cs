using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }
        public string kontrolana { get; set;}
        public string isim { get; set; }
        void cozunurluk()
        {
            int bizimPcGenislik = 1920;
            int bizimPcYukseklik = 1080;

            float ölcek = 120;

            float dpiX;
            Graphics graphics = this.CreateGraphics();
            dpiX = graphics.DpiX;

            float altinoran = ölcek / dpiX;

            string nesFontAdi;
            float nesFont, nesX, nesY, nesGen, nesYuk;
            int fontBuyuk;

            float form_g = this.Width;
            float form_y = this.Height;

            float panel1_lx = panel1.Location.X;
            float panel1_ly = panel1.Location.Y;

            float panel1_g = panel1.Width;
            float panel1_y = panel1.Height;

            float panel2_lx = panel2.Location.X;
            float panel2_ly = panel2.Location.Y;

            float panel2_g = panel2.Width;
            float panel2_y = panel2.Height;

            float panel3_lx = panel3.Location.X;
            float panel3_ly = panel3.Location.Y;

            float panel3_g = panel3.Width;
            float panel3_y = panel3.Height;

            float panel4_lx = panel4.Location.X;
            float panel4_ly = panel4.Location.Y;

            float panel4_g = panel4.Width;
            float panel4_y = panel4.Height;

            float panel5_lx = panel5.Location.X;
            float panel5_ly = panel5.Location.Y;

            float panel5_g = panel5.Width;
            float panel5_y = panel5.Height;

            float kullanilanPcGenislik = SystemInformation.PrimaryMonitorSize.Width;
            float kullanilanPcYukseklik = SystemInformation.PrimaryMonitorSize.Height;

            float genislikOrani = (bizimPcGenislik / kullanilanPcGenislik);
            float yukseklikOrani = (bizimPcYukseklik / kullanilanPcYukseklik);

            if (dpiX == 120)
            {
                foreach (Control nesne in this.Controls)
                {
                    float x = bizimPcGenislik / form_g;
                    float y = bizimPcYukseklik / form_y;

                    nesFontAdi = nesne.Font.SystemFontName; //demek sorun bu nesne locationlarının yanlış ayarlanmasıymış form içinde
                    nesFont = nesne.Font.Size;
                    fontBuyuk = (int)(nesFont / yukseklikOrani);
                    if (fontBuyuk < 8) fontBuyuk = 8;
                    nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                    this.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                }

                foreach (Control nesne in panel1.Controls)
                {
                    float x = bizimPcGenislik / panel1_g;
                    float y = bizimPcYukseklik / panel1_y;

                    float lx = bizimPcGenislik / panel1_lx;
                    float ly = bizimPcYukseklik / panel1_ly;

                    nesFontAdi = nesne.Font.SystemFontName;
                    nesFont = nesne.Font.Size;
                    nesX = nesne.Location.X;
                    nesY = nesne.Location.Y;
                    nesGen = nesne.Size.Width;
                    nesYuk = nesne.Size.Height;
                    nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                    nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                    fontBuyuk = (int)(nesFont / yukseklikOrani);
                    nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                    panel1.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                    panel1.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
                }

                foreach (Control nesne in panel2.Controls)
                {
                    float x = bizimPcGenislik / panel2_g;
                    float y = bizimPcYukseklik / panel2_y;

                    float lx = bizimPcGenislik / panel2_lx;
                    float ly = bizimPcYukseklik / panel2_ly;

                    nesFontAdi = nesne.Font.SystemFontName;
                    nesFont = nesne.Font.Size;
                    nesX = nesne.Location.X;
                    nesY = nesne.Location.Y;
                    nesGen = nesne.Size.Width;
                    nesYuk = nesne.Size.Height;
                    nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                    nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                    fontBuyuk = (int)(nesFont / yukseklikOrani);
                    nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                    panel2.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                    panel2.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
                }

                foreach (Control nesne in panel3.Controls)
                {
                    float x = bizimPcGenislik / panel3_g;
                    float y = bizimPcYukseklik / panel3_y;

                    float lx = bizimPcGenislik / panel3_lx;
                    float ly = bizimPcYukseklik / panel3_ly;

                    nesFontAdi = nesne.Font.SystemFontName;
                    nesFont = nesne.Font.Size;
                    nesX = nesne.Location.X;
                    nesY = nesne.Location.Y;
                    nesGen = nesne.Size.Width;
                    nesYuk = nesne.Size.Height;
                    nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                    nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                    fontBuyuk = (int)(nesFont / yukseklikOrani);
                    nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                    panel3.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                    panel3.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
                }

                foreach (Control nesne in panel4.Controls)
                {
                    float x = bizimPcGenislik / panel4_g;
                    float y = bizimPcYukseklik / panel4_y;

                    float lx = bizimPcGenislik / panel4_lx;
                    float ly = bizimPcYukseklik / panel4_ly;

                    nesFontAdi = nesne.Font.SystemFontName;
                    nesFont = nesne.Font.Size;
                    nesX = nesne.Location.X;
                    nesY = nesne.Location.Y;
                    nesGen = nesne.Size.Width;
                    nesYuk = nesne.Size.Height;
                    nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                    nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                    fontBuyuk = (int)(nesFont / yukseklikOrani);
                    nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                    panel4.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                    panel4.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
                }

                foreach (Control nesne in panel5.Controls)
                {
                    float x = bizimPcGenislik / panel5_g;
                    float y = bizimPcYukseklik / panel5_y;

                    float lx = bizimPcGenislik / panel5_lx;
                    float ly = bizimPcYukseklik / panel5_ly;

                    nesFontAdi = nesne.Font.SystemFontName;
                    nesFont = nesne.Font.Size;
                    nesX = nesne.Location.X;
                    nesY = nesne.Location.Y;
                    nesGen = nesne.Size.Width;
                    nesYuk = nesne.Size.Height;
                    nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                    nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                    fontBuyuk = (int)(nesFont / yukseklikOrani);
                    nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                    panel5.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                    panel5.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
                }
            }
        }
        private void Btn_yenikitap_Click(object sender, EventArgs e)
        {
            Frm3 frm = new Frm3
            {
                kontrol2 = textBox1.Text,
                isimkontrol2 = label12.Text,
                sifre2 = txt_alinansifre.Text
            };
            this.Hide();
            frm.Show();
        }
        private void Btn_kitapalankişiler_Click(object sender, EventArgs e)
        {
            Frm7 frm = new Frm7
            {
                kontrol = textBox1.Text, 
                isimkontrolkak = label12.Text,
                alinansifre = txt_alinansifre.Text
            };

            this.Hide();
            frm.Show();
            //anaprograma this.close uygularsan uygulama kökten kapanır tabi amq
        }
        private void Btn_kapa_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        void metin()
        {
            label8.Text = Localization.kapali;
            label9.Text = Localization.acik;
            
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_en);
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_jp);
            }

            Btn_yenikitap.Text = Localization.Anasayfa_Btnyenikitap_Text;
            Btn_kitapalankişiler.Text = Localization.Anasayfa_Btnkitapalankisiler_Text;
            label2.Text = Localization.Anasayfa_Label2_Text;
            linkLabel1.Text = Localization.Anasayfa_Linklabel1_Text;
            linkLabel2.Text = Localization.Anasayfa_Linklabel2_Text;
            linkLabel3.Text = Localization.Anasayfa_Linklabel3_Text;
            linkLabel5.Text = Localization.Anasayfa_Linklabel5_Text;
            label11.Text = Localization.kim;

            Regex rgx = new Regex("(.{50}\\s)");
            string WrappedMessage1 = rgx.Replace(Localization.btnyenikitap_tooltiptext, "$1\n");

            toolTip1.SetToolTip(this.Btn_yenikitap, WrappedMessage1);
            toolTip1.SetToolTip(this.Btn_kitapalankişiler, Localization.btn_kitapalankısıler_tooltiptext);
            toolTip1.SetToolTip(this.button2, Localization.btn_minimize);
            toolTip1.SetToolTip(this.button1, Localization.btn_kapa);
            toolTip1.ToolTipTitle = Localization.Bilgilendirme;

            dilSeçimiToolStripMenuItem.Text = Localization.Programagiris_dilsecim_Text;
            türkçeToolStripMenuItem.Text = Localization.Programagiris_turkcetoolstrip_Text;
            ingilizceToolStripMenuItem.Text = Localization.Programagiris_englishtoolstrip_Text;
            //japoncaToolStripMenuItem.Text = Localization.Programagiris_日本語toolstrip_Text;

            label10.Text = Localization.anasayfa_label10;
            label7.Text = Localization.anasayfa_label7;
            label8.Text = Localization.kapali;
            label9.Text = Localization.acik;
            label5.Text = Localization.anasayfa_label5;
            label16.Text = Localization.anasayfa_label16;
            label17.Text = Localization.anasayfa_label17;
            label15.Text = Localization.anasayfa_label15;
            label13.Text = Localization.Anasayfa_Label2_Text;
            linkLabel7.Text = Localization.anasayfa_linklabel7;
            linkLabel8.Text = Localization.anasayfa_linklabel8;
            linkLabel6.Text = Localization.anasayfa_linklabel6;
            linkLabel9.Text = Localization.anasayfa_linklabel9;
        }
        void engduzelt()
        {
            Btn_yenikitap.Font = new Font(Localization.frmanasayfa_font,12,FontStyle.Regular);
            Btn_kitapalankişiler.Font = new Font(Localization.frmanasayfa_font, 12,FontStyle.Regular);
            linkLabel1.Location = new Point(66, 186);
            linkLabel2.Location = new Point(20, 220);
            linkLabel3.Location = new Point(70, 252);
            linkLabel5.Location = new Point(43, 316);
            label2.Location = new Point(59, 142);
            pictureBox1.Location = new Point(205, 69);
            pictureBox2.Location = new Point(205, 69);
            label8.Location = new Point(139, 70);
            label9.Location = new Point(142, 70);
            label11.Location = new Point(130, 102);
            linkLabel7.Location = new Point(34, 186);
            linkLabel8.Location = new Point(100, 252);
            linkLabel6.Location = new Point(6, 284);
            linkLabel9.Location = new Point(25, 316);

            label1.Text = Localization.xxx;
        }
        void japanduzelt()
        {

        }
        void turduzelt()
        {
            Btn_yenikitap.Font = new Font(Localization.frmanasayfa_font, 18, FontStyle.Regular);
            Btn_kitapalankişiler.Font = new Font(Localization.frmanasayfa_font, 18, FontStyle.Regular);
            label2.Location = new Point(46, 142);
            linkLabel1.Location = new Point(45, 186);
            linkLabel2.Location = new Point(42, 220);
            linkLabel3.Location = new Point(82, 252);
            linkLabel5.Location = new Point(40, 316);
            pictureBox1.Location = new Point(212, 69);
            pictureBox2.Location = new Point(212, 69);
            label8.Location = new Point(139, 70);
            label9.Location = new Point(142, 70);
            label11.Location = new Point(121, 102);
            linkLabel7.Location = new Point(49, 186);
            linkLabel8.Location = new Point(85, 252);
            linkLabel6.Location = new Point(57, 284);
            linkLabel9.Location = new Point(18, 316);

            label1.Text = Localization.yyyyyy;
        }
        private void Frm2_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                metin();
                engduzelt();
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                metin();
                japanduzelt();
            }
            else
            {
                metin();
                turduzelt();
            }
            Btn_yenikitap.Focus();
            //cozunurluk();
        }
        private void Frm2_Shown(object sender, EventArgs e)
        {
            Btn_yenikitap.Focus();
        }
        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_tr);
            Settings1.Default.dil = Localization.formload_toolstripmenu_turkce;
            Settings1.Default.Save();
            turduzelt();
            metin();
        }
        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_en);
            Settings1.Default.dil = Localization.formload_toolstripmenu_ingilizce;
            Settings1.Default.Save();
            engduzelt();
            metin();
        }
        private void japoncaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_jp);
            Settings1.Default.dil = Localization.formload_toolstripmenu_japonca;
            Settings1.Default.Save();
            japanduzelt();
            metin();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show(Localization.prg_kapa, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Localization.mb_3, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show(Localization.mb_2, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                label8.Visible = true;
                label9.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                label11.Visible = true;
                label12.Text = Localization.bosdeger;
                label12.Visible = false;
                textBox1.Text = Localization.kapalii;
                txt_alinansifre.Text = Localization.bosdeger;
            }
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDüzen x = new FormDüzen();
            x.Show();
        }
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKural x = new FormKural();
            x.Show();
        }
        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAmac x = new FormAmac();
            x.Show();
        }
        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmtüm x = new frmtüm();
            x.Show();
        }
        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmadmin x = new frmadmin();
            x.Show();
            this.Hide();
        }
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nedenadmin x = new nedenadmin();
            x.Show();
        }
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(label8.Visible == true)
            {
                frmgiris x = new frmgiris();
                x.Show();
                this.Hide();
            }
            else if(label8.Visible == false)
            {
                MessageBox.Show(Localization.mb_1,Localization.Hata,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            islemkayit x = new islemkayit();
            x.Show();
        }
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            proje x = new proje();
            x.Show();
        }
        private void Btn_yenikitap_MouseEnter(object sender, EventArgs e)
        {
            Btn_yenikitap.ForeColor = Color.Red;
        }
        private void Btn_yenikitap_MouseLeave(object sender, EventArgs e)
        {
            Btn_yenikitap.ForeColor = Color.Black;
        }
        private void Btn_kitapalankişiler_MouseEnter(object sender, EventArgs e)
        {
            Btn_kitapalankişiler.ForeColor = Color.Red;
        }
        private void Btn_kitapalankişiler_MouseLeave(object sender, EventArgs e)
        {
            Btn_kitapalankişiler.ForeColor = Color.Black;
        }
    }
}