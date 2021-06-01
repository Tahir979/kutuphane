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