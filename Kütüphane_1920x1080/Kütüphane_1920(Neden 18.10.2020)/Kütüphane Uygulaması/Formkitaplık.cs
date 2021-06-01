using System;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class Formkitaplık : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        OleDbCommand komut;

        public Formkitaplık()
        {
            InitializeComponent();
        }
        void griddoldur2()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("Select * from kitaplik", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.frmkitaplik);
            dataGridView1.DataSource = ds.Tables[Localization.frmkitaplik];
            con.Close();
        }
        public void Xyz()
        {
            OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
            baglan.Open();
            OleDbCommand command = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from kitaplik"
            };
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_kitaplıkismiekle.Items.Add(reader[Localization.Ad]);
            }
        }
        private void btn_kitaplıkismiekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult x = MessageBox.Show(Localization.frmkitaplik_kesinles, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = "insert into kitaplik(Ad) values (@Ad)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue(Localization.Ad_2, textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Localization.frmkitaplik_mb1, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    griddoldur2();
                    cmb_kitaplıkismiekle.Text = Localization.bosdeger;
                    cmb_kitaplıkismiekle.Items.Clear();
                    Xyz();
                    textBox1.Clear();
                }
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_kitaplıkismiekle.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult x = MessageBox.Show(Localization.frmkitapliksil_kesinles, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    string vtyolu = Localization.oledbcon;
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string sorgu = "Delete From kitaplik Where Ad=@Ad";
                    komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue(Localization.Ad_2, cmb_kitaplıkismiekle.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Localization.frmkitaplik_Sil_2, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    griddoldur2();
                    cmb_kitaplıkismiekle.Text = Localization.bosdeger;
                    cmb_kitaplıkismiekle.Items.Clear();
                    Xyz();
                }
            }
        }
        void metin()
        {
            this.Text = Localization.frmkitaplik_frmname;
            btn_kitaplıkismiekle.Text = Localization.frmkitaplik_ekle;
            btn_sil.Text = Localization.frmkitaplik_sil;
        }
        private void Formkitaplık_Load(object sender, EventArgs e)
        {
            Xyz();
            metin();
        }
        private void Btn_kitaplıkismiekle_MouseEnter(object sender, EventArgs e)
        {
            btn_kitaplıkismiekle.ForeColor = Color.Red;
        }
        private void Btn_kitaplıkismiekle_MouseLeave(object sender, EventArgs e)
        {
            btn_kitaplıkismiekle.ForeColor = Color.Black;
        }
        private void Btn_sil_MouseEnter(object sender, EventArgs e)
        {
            btn_sil.ForeColor = Color.Red;
        }
        private void Btn_sil_MouseLeave(object sender, EventArgs e)
        {
            btn_sil.ForeColor = Color.Black;
        }
        private void Formkitaplık_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void cmb_kitaplıkismiekle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void btn_kitaplıkismiekle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                //MessageBox.Show("4"); // bu formu kapatan asıl kod bu
                this.Close();
            }
        }
        private void btn_sil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
