using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Kütüphane_Uygulaması
{
    public partial class frmadmin : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public frmadmin()
        {
            InitializeComponent();
        }
        void dogrulama()
        {
            Random rastgele = new Random();
            string harfler = Localization.tfg;
            string Huret = Localization.bosdeger;
            for (int i = 0; i < 6; i++)
            {
                Huret += harfler[rastgele.Next(harfler.Length)];
            }
            string kod2 = Huret;
            txt_kod.Text = kod2;
        }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect * from adminler", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.adminler);
            dataGridView1.DataSource = ds.Tables[Localization.adminler];
            con.Close();
        }
        void engduzelt()
        {
            label3.Location = new Point(102, 169);
            label4.Location = new Point(74, 205);
            label10.Location = new Point(64, 59);
            label11.Location = new Point(99,132);
            label12.Location = new Point(68,96);
            checkBox1.Location = new Point(49, 101);
        }
        private void frmadmin_Load(object sender, EventArgs e)
        {
            Griddoldur();
            dogrulama();

            label1.Text = Localization.frmadmin_label1;
            label3.Text = Localization.frmadmin_label3;
            label4.Text = Localization.frmadmin_label4;
            label10.Text = Localization.frmadmin_label10;
            label12.Text = Localization.frmadmin_label12;
            btn_adminol.Text = Localization.frmadmin_btn;
            label6.Text = Localization.frmadmin_label6;
            label7.Text = Localization.frmadmin_label7;
            label8.Text = Localization.frmadmin_label8;

            errorProvider1.SetError(this.textBox1, Localization.frmadmin_ktc);
            errorProvider2.SetError(this.textBox2, Localization.frmadmin_ktc);
            errorProvider3.SetError(this.txt_email_2, Localization.frmadmin_ktc);
            errorProvider4.SetError(this.txt_gecicisifre, Localization.frmadmin_ktc);
            errorProvider5.SetError(this.txt_adsoyad_2, Localization.frmadmin_ktc);
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider9.Clear();
            errorProvider10.Clear();

            label3.Location = new Point(128, 170);
            label4.Location = new Point(96, 206);
            label10.Location = new Point(46, 61);
            label12.Location = new Point(113, 97);
            checkBox1.Location = new Point(97, 102);
            label11.Location = new Point(99, 132);

            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                engduzelt();
            }
        }
        private void btn_adminol_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_adsoyad_2.Text) == true || string.IsNullOrEmpty(txt_email_2.Text) == true || string.IsNullOrEmpty(txt_gecicisifre.Text) == true || string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(txt_error_1.Text == Localization.frm_bir || txt_error_2.Text == Localization.frm_bir || txt_error_3.Text == Localization.frm_bir || txt_error_4.Text == Localization.frm_bir || txt_error_5.Text == Localization.frm_bir)
            {
                MessageBox.Show(Localization.frmadmin_err, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SmtpClient sc = new SmtpClient();
                    sc.Port = 587;
                    sc.Host = Localization.smtp;
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential(Localization.maill, Localization.sifree);
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(Localization.maill, Localization.hüpt);
                    mail.To.Add(txt_email_2.Text.ToString());
                    mail.Subject = Localization.verifi; mail.IsBodyHtml = true; mail.Body = Localization.Dear + txt_adsoyad_2.Text + Localization.mssg + txt_kod.Text + Localization.edcv;
                    sc.Send(mail);

                    MessageBox.Show(Localization.frmadmin_kgh, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmdoğrulama a = new frmdoğrulama();
                    a.kod2 = txt_kod.Text;
                    a.isim = txt_adsoyad_2.Text;
                    a.sifre = txt_gecicisifre.Text;
                    a.mail = txt_email_2.Text;
                    a.gisim = textBox1.Text;
                    a.gsoyad = textBox2.Text;
                    a.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show(Localization.frmadmin_fgh, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Frm2 x = new Frm2();
            x.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_gecicisifre.PasswordChar = '\0';
            }
            else
            {
                txt_gecicisifre.PasswordChar = '*';
            }
        }
        private void txt_email_2_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(hotmail\\.)+com)$";
            string pattern2 = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(gmail\\.)+com)$";
            if (Regex.IsMatch(txt_email_2.Text, pattern) || Regex.IsMatch(txt_email_2.Text, pattern2))
            {
                Griddoldur();
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "mail Like '%" + txt_email_2.Text + "%'";
                dataGridView1.DataSource = dv;

                try
                {
                    txt_kontrol.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();

                    if (txt_kontrol.Text == txt_email_2.Text)
                    {
                        errorProvider8.Clear();
                        errorProvider3.SetError(this.txt_email_2, Localization.frmadmin_asd);
                        txt_error_3.Text = Localization.frm_bir;
                    }
                    else
                    {
                        errorProvider3.Clear();
                        errorProvider8.SetError(this.txt_email_2, Localization.frmadmin_ghj);
                        txt_error_3.Text = Localization.frm_sifir;
                    }
                }
                catch
                {
                    errorProvider3.Clear();
                    errorProvider8.SetError(this.txt_email_2, Localization.frmadmin_ghj);
                    txt_error_3.Text = Localization.frm_sifir;
                }
            }
            else
            {
                errorProvider8.Clear();
                errorProvider3.SetError(this.txt_email_2, Localization.frmadmin_gty);
                txt_error_3.Text = Localization.frm_bir;
            }
        }
        private void btn_adminol_MouseEnter(object sender, EventArgs e)
        {
            btn_adminol.ForeColor = Color.Red;
        }
        private void btn_adminol_MouseLeave(object sender, EventArgs e)
        {
            btn_adminol.ForeColor = Color.Black;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
        private void txt_adsoyad_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txt_adsoyad_2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void txt_gecicisifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txt_gecicisifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txt_email_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txt_adsoyad_2_TextChanged(object sender, EventArgs e)
        {
            Griddoldur();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "kullaniciadi Like '%" + txt_adsoyad_2.Text + "%'";
            dataGridView1.DataSource = dv;

            try
            {
                txt_kontrol.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();//MUHTEMELEN İLKİNDE BU ŞARTIN HATASINI VERDİĞİ İÇİN CATCH YAPISINA DÜŞÜYOR VE ORADAN DA GÖRÜLMÜYOR HALİYLE
                //EĞER O ZAMAN CATCH'E DÜŞEN YAPIDA DA ERRORPROVİDER'I SİLDİRMEDEN ÖNCE SATIRLAR AYNI MI DEĞİL Mİ DİYE KONTROL ETTİREYİM, AYNIYSA GÖRÜLSÜN UYARI

                //Heye kesin öyle, "Talha " şeklinde kaydedersen tabi bulamaz uygulama, nasıl öyle bir hata yapmışım ya boşlukla isim kaydetmek gibi, sonra arayıp duruyorum bende neden görmüyor acaba ilk satırı diye

                if (txt_adsoyad_2.Text == txt_kontrol.Text)
                {
                    errorProvider5.SetError(this.txt_adsoyad_2, Localization.frmadmin_ert);
                    txt_error_5.Text = Localization.frm_bir;

                    errorProvider10.Clear();
                }
                else
                {
                    errorProvider10.SetError(this.txt_adsoyad_2, Localization.frmadmin_ujk);

                    errorProvider5.Clear();
                    txt_error_5.Text = Localization.frm_sifir;
                }


                if(string.IsNullOrEmpty(txt_adsoyad_2.Text) == true)
                {
                    errorProvider5.SetError(this.txt_adsoyad_2, Localization.frmadmin_klj);
                    txt_error_5.Text = Localization.frm_bir;

                    errorProvider10.Clear();
                }
            }
            catch
            {
                errorProvider10.SetError(this.txt_adsoyad_2, Localization.frmadmin_ujk);

                errorProvider5.Clear(); //vay amk hakkaten de try içinde hata oluşan bloktan itibaren sonrasında sadece catchten devam ediyor işlerine
                txt_error_5.Text = Localization.frm_sifir;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                errorProvider7.Clear();
                errorProvider2.SetError(this.textBox2, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider2.Clear();
                txt_error_2.Text = Localization.frm_sifir;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                errorProvider6.Clear();
                errorProvider1.SetError(this.textBox1, Localization.frmadmin_ktc);
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider1.Clear();
                txt_error_1.Text = Localization.frm_sifir;
            }
        }
        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (string.IsNullOrEmpty(textBox1.Text) == true)
                {
                    errorProvider1.SetError(this.textBox1, Localization.frmadmin_ktc);
                    errorProvider6.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider6.SetError(this.textBox1, Localization.suitable);
                }
            }
        }
        private void txt_gecicisifre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_gecicisifre.Text) == true)
            {
                errorProvider9.Clear();
                errorProvider4.SetError(this.txt_gecicisifre, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider4.Clear();
                txt_error_4.Text = Localization.frm_sifir;
            }
        }
        private void txt_gecicisifre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (string.IsNullOrEmpty(txt_gecicisifre.Text) == true)
                {
                    errorProvider4.SetError(this.txt_gecicisifre, Localization.frmadmin_ktc);
                    errorProvider9.Clear();
                }
                else
                {
                    errorProvider4.Clear();
                    errorProvider9.SetError(this.txt_gecicisifre, Localization.suitable);
                }
            }
        }
        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (string.IsNullOrEmpty(textBox2.Text) == true)
                {
                    errorProvider2.SetError(this.textBox2, Localization.frmadmin_ktc);
                    errorProvider7.Clear();
                }
                else
                {
                    errorProvider2.Clear();
                    errorProvider7.SetError(this.textBox2, Localization.suitable);
                }
            }
        }
        private void txt_gecicisifre_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_gecicisifre.Text) == true)
            {
                errorProvider9.Clear();
                errorProvider4.SetError(this.txt_gecicisifre, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider4.Clear();
                errorProvider9.SetError(this.txt_gecicisifre, Localization.suitable);
                txt_error_4.Text = Localization.frm_sifir;
            }
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                errorProvider6.Clear();
                errorProvider1.SetError(this.textBox1, Localization.frmadmin_ktc);
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider6.SetError(this.textBox1, Localization.suitable);
                txt_error_1.Text = Localization.frm_sifir;
            }
        }
        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                errorProvider7.Clear();
                errorProvider2.SetError(this.textBox2, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider2.Clear();
                errorProvider7.SetError(this.textBox2, Localization.suitable);
                txt_error_2.Text = Localization.frm_sifir;
            }
        }
    }
}
