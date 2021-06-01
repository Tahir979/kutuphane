using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace Kütüphane_Uygulaması
{
    public partial class frmbilgi : Form
    {
        public frmbilgi()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbCommand cmd4;
        OleDbDataAdapter da;
        OleDbDataAdapter da2;
        DataSet ds;
        DataSet ds2;
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect * from adminler", con);
            da2 = new OleDbDataAdapter("SElect * from islemdokumadm", con);
            ds = new DataSet();
            ds2 = new DataSet();
            con.Open();
            da.Fill(ds, Localization.adminler);
            da2.Fill(ds2, Localization.islemdokumadm);
            dataGridView1.DataSource = ds.Tables[Localization.adminler];
            dataGridView2.DataSource = ds2.Tables[Localization.islemdokumadm];
            con.Close();
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
        void error()
        {
            if (panel3.Enabled == true)
            {
                errorProvider1.SetError(this.textBox1, Localization.frmadmin_ktc);
                errorProvider2.SetError(this.textBox2, Localization.frmadmin_ktc);

                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
                errorProvider8.Clear();
            }
            else if (panel2.Enabled == true)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();

                errorProvider8.SetError(this.textBox8, Localization.frmadmin_ktc);
            }
            else if (panel1.Enabled == true)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();

                errorProvider9.SetError(this.textBox3, Localization.trehdf);
                errorProvider10.SetError(this.textBox4, Localization.dfhfd);
                errorProvider11.SetError(this.textBox5, Localization.trfhtr);
                errorProvider12.SetError(this.textBox6, Localization.gdsa);
                errorProvider13.SetError(this.textBox7, Localization.htrhg);

                errorProvider8.Clear();
            }
        }
        void guncelleadm()
        {
            if (textBox3.Text != textBox9.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox14.Text + " ID numaralı adminin kullanıcı adında değişiklik yapılmıştır.\n" + " \nEski kayıt: " + textBox1.Text + " \nYeni kayıt: " + textBox3.Text;

                cmd4.CommandText = "insert into islemdokumadm (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox3.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, textBox18.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (textBox4.Text != textBox10.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox14.Text + " ID numaralı adminin şifresinde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + textBox10.Text + " \nYeni kayıt: " + textBox4.Text;

                cmd4.CommandText = "insert into islemdokumadm (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox3.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, textBox18.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (textBox5.Text != textBox11.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox14.Text + " ID numaralı adminin emailinde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + textBox11.Text + " \nYeni kayıt: " + textBox5.Text;

                cmd4.CommandText = "insert into islemdokumadm (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox3.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, textBox18.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (textBox6.Text != textBox12.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox14.Text + " ID numaralı adminin isminde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + textBox12.Text + " \nYeni kayıt: " + textBox6.Text;

                cmd4.CommandText = "insert into islemdokumadm (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox3.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, textBox18.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (textBox7.Text != textBox13.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox14.Text + " ID numaralı adminin soyisminde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + textBox13.Text + " \nYeni kayıt: " + textBox7.Text;

                cmd4.CommandText = "insert into islemdokumadm (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox3.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, textBox18.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frmgiris frm = new frmgiris();
            frm.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Griddoldur();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "kullaniciadi Like '%" + textBox1.Text + "%' and sifre Like '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = dv;

            try
            {
                textBox9.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                textBox10.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textBox11.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                textBox12.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                textBox13.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                textBox14.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                txt_email_sabit.Text = textBox11.Text;
            }
            catch
            {

            }

            if (textBox1.Text == textBox9.Text && textBox2.Text == textBox10.Text)
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
                    mail.To.Add(textBox11.Text.ToString());
                    mail.Subject = Localization.tytfdh; mail.IsBodyHtml = true; mail.Body = Localization.Dear + textBox1.Text + Localization.tyutgfdd + txt_kod.Text;
                    sc.Send(mail);

                    MessageBox.Show(Localization.gfdhdf, Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);

                    panel3.Enabled = false;
                    panel1.Enabled = false;
                    panel2.Enabled = true;
                    error();
                }
                catch
                {
                    MessageBox.Show(Localization.frmadmin_fgh, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Localization.frmgrs_msg, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmbilgi_Load(object sender, EventArgs e)
        {
            Griddoldur();
            dogrulama();
            panel1.Enabled = false;
            panel2.Enabled = false;
            error();

            button1.Text = Localization.anasayfa_linklabel8;
            button2.Text = Localization.frmsifre_btn1;
            button3.Text = Localization.update;
            label2.Text = Localization.frmadmin_label10;
            label3.Text = Localization.frmadmin_label12;
            label10.Text = Localization.bmn;
            label4.Text = Localization.frmadmin_label10;
            label5.Text = Localization.frmadmin_label12;
            label7.Text = Localization.frmadmin_label3;
            label8.Text = Localization.frmadmin_label4;
            label11.Text = Localization.frmadmin_label6;
            label12.Text = Localization.klo;
            label13.Text = Localization.frmadmin_label8;
            label14.Text = Localization.hyg;

            label2.Location = new Point(15, 5);
            label3.Location = new Point(82, 40);
            label10.Location = new Point(7, 5);
            label4.Location = new Point(19, 7);
            label5.Location = new Point(86, 42);
            label7.Location = new Point(101, 114);
            label8.Location = new Point(69, 150);
            checkBox1.Location = new Point(69, 48);

            textBox1.Location = new Point(140, 3);
            textBox1.Size = new Size(159, 30);

            textBox2.Location = new Point(140, 38);
            textBox2.Size = new Size(159, 30);

            textBox8.Location = new Point(176, 26);
            textBox8.Size = new Size(123, 30);

            textBox3.Location = new Point(145, 6);
            textBox3.Size = new Size(159, 30);

            textBox4.Location = new Point(145, 41);
            textBox4.Size = new Size(159, 30);

            textBox6.Location = new Point(145, 113);
            textBox6.Size = new Size(159, 30);

            textBox7.Location = new Point(145, 149);
            textBox7.Size = new Size(159, 30);

            if(Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                label2.Location = new Point(31, 5);
                label3.Location = new Point(35, 40);
                label10.Location = new Point(7, 6);
                label4.Location = new Point(34, 8);
                label5.Location = new Point(38, 43);
                label7.Location = new Point(74, 115);
                label8.Location = new Point(46, 151);
                checkBox1.Location = new Point(21, 49);

                textBox8.Location = new Point(184, 26);
                textBox8.Size = new Size(115, 30);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == txt_kod.Text)
            {
                MessageBox.Show(Localization.fdhhfd, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Enabled = true;
                panel2.Enabled = false;
                panel3.Enabled = false;
                error();

                textBox3.Text = textBox9.Text;
                textBox4.Text = textBox10.Text;
                textBox5.Text = textBox11.Text;
                textBox6.Text = textBox12.Text;
                textBox7.Text = textBox13.Text;
            }
            else if (textBox8.Text == string.Empty)
            {
                MessageBox.Show(Localization.frmadmin_ktc, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox8.Text != txt_kod.Text)
            {
                MessageBox.Show(Localization.frmadmin_xb, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            errorProvider1.Clear();
            txt_errorprovider.Text = Localization.kapalii;
            txt_errorprovider2.Text = Localization.kapalii;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty || textBox6.Text == string.Empty || textBox7.Text == string.Empty)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_errorprovider.Text == Localization.acikk || txt_errorprovider2.Text == Localization.acikk)
            {
                MessageBox.Show(Localization.frmadmin_err, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox3.Text == textBox9.Text && textBox4.Text == textBox10.Text && textBox5.Text == textBox11.Text && textBox6.Text == textBox12.Text && textBox7.Text == textBox13.Text)
            {
                MessageBox.Show(Localization.gfhfd, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "update adminler set kullaniciadi=@kullaniciadi, sifre=@sifre, mail=@mail, ad=@ad, soyad=@soyad where ID=@ID";
                cmd.Parameters.AddWithValue(Localization.dsgas, textBox3.Text);
                cmd.Parameters.AddWithValue(Localization.g, textBox4.Text);
                cmd.Parameters.AddWithValue(Localization.h, textBox5.Text);
                cmd.Parameters.AddWithValue(Localization.j, textBox6.Text);
                cmd.Parameters.AddWithValue(Localization.k, textBox7.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_ID, textBox14.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                Griddoldur();
                guncelleadm();
                MessageBox.Show(Localization.frmkisi_guncelle_mb_part1, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmgiris x = new frmgiris();
                x.Show();
                this.Hide();
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text == Localization.bosdeger)
            {
                errorProvider9.Clear();
                errorProvider14.Clear();
                errorProvider3.SetError(this.textBox3, Localization.frmadmin_ktc);
                txt_error_3.Text = Localization.frm_bir;
            }
            else
            {
                Griddoldur();
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "kullaniciadi Like '%" + textBox3.Text + "%'";
                dataGridView1.DataSource = dv;
                try
                {
                    textBox9.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();

                    if (textBox3.Text == textBox9.Text)
                    {
                        if (textBox1.Text == textBox3.Text)
                        {
                            errorProvider3.Clear();
                            errorProvider14.Clear();
                            txt_error_3.Text = Localization.kapalii;
                            errorProvider9.SetError(this.textBox3, Localization.trehdf);
                        }
                        else
                        {
                            errorProvider9.Clear();
                            errorProvider14.Clear();
                            errorProvider3.SetError(this.textBox3, Localization.frmadmin_ert);
                            txt_error_3.Text = Localization.acikk;
                        }
                    }
                    else
                    {
                        errorProvider9.Clear();
                        errorProvider3.Clear();
                        errorProvider14.SetError(this.textBox3, Localization.suitable);
                        txt_error_3.Text = Localization.kapalii;
                    }
                }
                catch
                {
                    errorProvider9.Clear();
                    errorProvider3.Clear(); //vay amk hakkaten de try içinde hata oluşan bloktan itibaren sonrasında sadece catchten devam ediyor işlerine
                    errorProvider14.SetError(this.textBox3, Localization.suitable);
                    txt_error_3.Text = Localization.kapalii;
                }
            }
            //sizin şuanki kullanıcıadınız mailiniz filan diye çıksın yanında yeşil semboller, ilk 2 kısımda yeşiller çıkmasına gerek yok 
            //çünkü kendi kullanıcı adı ve şifresini girerken zaten butonla kontrol edeceğiz ve doğrulama kodunuda aynı şekilde
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(hotmail\\.)+com)$";
            string pattern2 = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(gmail\\.)+com)$";
            if (Regex.IsMatch(textBox5.Text, pattern) || Regex.IsMatch(textBox5.Text, pattern2))
            {
                if(textBox5.Text == Localization.bosdeger)
                {
                    errorProvider11.Clear();
                    errorProvider16.Clear();
                    errorProvider5.SetError(this.textBox5, Localization.frmadmin_ktc);
                    txt_errorprovider.Text = Localization.kapalii;
                }
                else
                {
                    Griddoldur();
                    DataView dv = ds.Tables[0].DefaultView;
                    dv.RowFilter = "mail Like '%" + textBox5.Text + "%'";
                    dataGridView1.DataSource = dv;

                    try
                    {
                        textBox11.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();

                        if (textBox5.Text == textBox11.Text)
                        {
                            if (txt_email_sabit.Text == textBox5.Text)
                            {
                                errorProvider5.Clear();
                                errorProvider16.Clear();
                                txt_errorprovider.Text = Localization.kapalii;

                                errorProvider11.SetError(this.textBox5, Localization.trfhtr);
                            }
                            else
                            {
                                errorProvider11.Clear();
                                errorProvider16.Clear();
                                errorProvider5.SetError(this.textBox5, Localization.frmadmin_asd);
                                txt_errorprovider2.Text = Localization.acikk;
                            }
                        }
                        else
                        {
                            errorProvider5.Clear();
                            errorProvider11.Clear();
                            errorProvider16.SetError(this.textBox5, Localization.suitable);
                            txt_errorprovider.Text = Localization.kapalii;
                        }
                    }
                    catch
                    {
                        errorProvider5.Clear();
                        errorProvider11.Clear();
                        errorProvider16.SetError(this.textBox5, Localization.suitable);
                        txt_errorprovider.Text = Localization.kapalii;
                    }
                }
            }
            else
            {
                errorProvider11.Clear();
                errorProvider16.Clear();
                errorProvider5.SetError(this.textBox5, Localization.frmadmin_gty);
                txt_errorprovider2.Text = Localization.acikk;

                if (textBox5.Text == Localization.bosdeger)
                {
                    errorProvider11.Clear();
                    errorProvider16.Clear();
                    errorProvider5.SetError(this.textBox5, Localization.frmadmin_ktc);
                    txt_errorprovider.Text = Localization.kapalii;
                }
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmgiris frm = new frmgiris();
            frm.Show();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            frmgiris frm = new frmgiris();
            frm.Show();
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == Localization.bosdeger)
            {
                errorProvider1.SetError(this.textBox1, Localization.frmadmin_ktc);
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider1.Clear();
                txt_error_1.Text = Localization.frm_sifir;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == Localization.bosdeger)
            {
                errorProvider2.SetError(this.textBox2, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider2.Clear();
                txt_error_2.Text = Localization.frm_sifir;
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == Localization.bosdeger)
            {
                errorProvider8.SetError(this.textBox8, Localization.frmadmin_ktc);
                txt_error_8.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider8.Clear();
                txt_error_8.Text = Localization.frm_sifir;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == Localization.bosdeger)
            {
                errorProvider13.Clear();
                errorProvider18.Clear();
                errorProvider7.SetError(this.textBox7, Localization.frmadmin_ktc);
                txt_error_7.Text = Localization.frm_bir;
            }
            else
            {
                try
                {
                    textBox17.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();

                    if (textBox17.Text == textBox7.Text)
                    {
                        errorProvider7.Clear();
                        errorProvider18.Clear();
                        errorProvider13.SetError(this.textBox7, Localization.htrhg);
                        txt_error_7.Text = Localization.frm_sifir;
                    }
                    else if (textBox17.Text != textBox7.Text)
                    {
                        errorProvider7.Clear();
                        errorProvider13.Clear();
                        errorProvider18.SetError(this.textBox7, Localization.suitable);
                        txt_error_7.Text = Localization.frm_sifir;
                    }
                }
                catch
                {
                    errorProvider7.Clear();
                    errorProvider13.Clear();
                    errorProvider18.SetError(this.textBox7, Localization.suitable);
                    txt_error_7.Text = Localization.frm_sifir;
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == Localization.bosdeger)
            {
                errorProvider12.Clear();
                errorProvider17.Clear();
                errorProvider6.SetError(this.textBox6, Localization.frmadmin_ktc);
                txt_error_6.Text = Localization.frm_bir;
            }
            else
            {
                try
                {
                    textBox16.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();

                    if(textBox16.Text == textBox6.Text)
                    {
                        errorProvider6.Clear();
                        errorProvider17.Clear();
                        errorProvider12.SetError(this.textBox6, Localization.gdsa);
                        txt_error_6.Text = Localization.frm_sifir;
                    }
                    else if(textBox16.Text != textBox6.Text)
                    {
                        errorProvider6.Clear();
                        errorProvider12.Clear();
                        errorProvider17.SetError(this.textBox6, Localization.suitable);
                        txt_error_6.Text = Localization.frm_sifir;
                    }
                }
                catch
                {
                    errorProvider6.Clear();
                    errorProvider12.Clear();
                    errorProvider17.SetError(this.textBox6, Localization.suitable);
                    txt_error_6.Text = Localization.frm_sifir;
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == Localization.bosdeger)
            {
                errorProvider10.Clear();
                errorProvider15.Clear();
                errorProvider4.SetError(this.textBox4, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                try
                {
                    if (textBox2.Text == textBox4.Text)
                    {
                        errorProvider4.Clear();
                        errorProvider15.Clear();
                        errorProvider10.SetError(this.textBox4, Localization.dfhfd);
                        txt_error_4.Text = Localization.frm_sifir;
                    }

                    else if (textBox2.Text != textBox4.Text)
                    {
                        errorProvider4.Clear();
                        errorProvider10.Clear();
                        errorProvider15.SetError(this.textBox4, Localization.suitable);
                        txt_error_4.Text = Localization.frm_sifir;
                    }
                }
                catch
                {
                    errorProvider4.Clear();
                    errorProvider10.Clear();
                    errorProvider15.SetError(this.textBox4, Localization.suitable);
                    txt_error_4.Text = Localization.frm_sifir;
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox18.Text = DateTime.Now.ToString();
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Red;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
        }
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Red;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Black;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }
    }
}
