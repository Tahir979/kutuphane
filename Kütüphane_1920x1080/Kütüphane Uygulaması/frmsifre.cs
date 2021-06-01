using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Kütüphane_Uygulaması
{
    public partial class frmsifre : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public frmsifre()
        {
            InitializeComponent();
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
        private void frmsifre_Load(object sender, EventArgs e)
        {
            dogrulama();
            label2.Enabled = false;
            textBox2.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;

            label6.Enabled = false;
            textBox3.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;

            button1.Text = Localization.frmsifre_btn1;
            button2.Text = Localization.frmsifre_btn1;
            button3.Text = Localization.frmsifre_btn1;

            label1.Text = Localization.frmsifre_label1;
            label2.Text = Localization.frmsifre_label2;
            label6.Text = Localization.frmsifre_label6;

            label1.Location = new Point(1, 7);
            textBox1.Location = new Point(142, 5);
            textBox1.Size = new Size(158, 30);

            label2.Location = new Point(1, 124);
            textBox2.Location = new Point(163, 122);
            textBox2.Size = new Size(137, 30);

            label6.Location = new Point(1, 238);
            textBox3.Location = new Point(134, 236);
            textBox3.Size = new Size(166, 30);

            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                label1.Location = new Point(1, 7);
                textBox1.Location = new Point(177, 5);
                textBox1.Size = new Size(123, 30);

                label2.Location = new Point(1, 124);
                textBox2.Location = new Point(163, 122);
                textBox2.Size = new Size(137, 30);

                label6.Location = new Point(1, 238);
                textBox3.Location = new Point(144, 236);
                textBox3.Size = new Size(156, 30);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(hotmail\\.)+com)$";
            string pattern2 = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(gmail\\.)+com)$";
            if (Regex.IsMatch(textBox1.Text, pattern) || Regex.IsMatch(textBox1.Text, pattern2))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();

                Griddoldur();
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "mail Like '%" + textBox1.Text + "%'";
                dataGridView1.DataSource = dv;

                try
                {
                    txt_kontrol.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    txt_isim.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txt_ID.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();

                    if (txt_kontrol.Text == textBox1.Text)
                    {
                        errorProvider1.SetError(this.textBox1, Localization.fsdagad);
                        errorProvider2.Clear();
                        txt_errorprovider2.Text = Localization.kapalii;
                    }
                }
                catch
                {

                }
            }
            else
            {
                errorProvider1.Clear();
                errorProvider2.SetError(this.textBox1, Localization.frmadmin_gty);
                txt_errorprovider2.Text = Localization.acikk;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Localization.bosdeger)
            {
                MessageBox.Show(Localization.frmadmin_ktc, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_errorprovider2.Text == Localization.acikk)
            {
                MessageBox.Show(Localization.frmadmin_err, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = Localization.smtp;
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(Localization.maill, Localization.sifree);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Localization.maill, Localization.hüpt);
                mail.To.Add(textBox1.Text);
                mail.Subject = Localization.gdfhgh; mail.IsBodyHtml = true; mail.Body = Localization.Dear + txt_isim.Text + Localization.ytrjgf + txt_kod.Text;
                sc.Send(mail);

                MessageBox.Show(Localization.gfdhdf, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);

                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;

                label2.Enabled = true;
                textBox2.Enabled = true;
                button2.Enabled = true;
                button5.Enabled = true;

                label6.Enabled = false;
                textBox3.Enabled = false;
                button3.Enabled = false;
                button6.Enabled = false;
            }
            catch
            {
                MessageBox.Show(Localization.frmadmin_fgh, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == txt_kod.Text)
            {
                MessageBox.Show(Localization.ghsg, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);

                label1.Enabled = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;

                label2.Enabled = false;
                textBox2.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;

                label6.Enabled = true;
                textBox3.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show(Localization.frmadmin_ktc, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != txt_kod.Text)
            {
                MessageBox.Show(Localization.frmadmin_xb, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show(Localization.frmadmin_ktc, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "update adminler set sifre=@sifre where ID=@ID";
                cmd.Parameters.AddWithValue(Localization.g, textBox3.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_ID, txt_ID.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                Griddoldur();
                MessageBox.Show(txt_isim.Text + Localization.jytjdf, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmgiris x = new frmgiris();
                x.Show();
                this.Hide();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frmgiris x = new frmgiris();
            x.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmgiris x = new frmgiris();
            x.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            frmgiris x = new frmgiris();
            x.Show();
            this.Hide();
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
    }
}
