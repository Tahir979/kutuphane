using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Uygulaması
{
    public partial class frmdoğrulama : Form
    {
        public string kod2 { get; set; }
        public string isim { get; set; }
        public string sifre { get; set; }
        public string mail { get; set; }
        public string gisim { get; set; }
        public string gsoyad { get; set; }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public frmdoğrulama()
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
        private void frmdoğrulama_Load(object sender, EventArgs e)
        {
            Griddoldur();
            textBox2.Text = kod2;
            textBox3.Text = isim;
            txt_sifre.Text = sifre;
            txt_mail.Text = mail;
            txt_gisim.Text = gisim;
            txt_gsoyisim.Text = gsoyad;

            button1.Text = Localization.frmdgr_btn;
            label1.Text = Localization.frmdgr_label1;

            textBox1.Size = new Size(195,30);
            textBox1.Location = new Point(246, 6);

            if(Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                textBox1.Size = new Size(139, 30);
                textBox1.Location = new Point(302, 6);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == textBox2.Text)
            {
                string y1 = Localization.oledbcon;
                OleDbConnection baglanti1 = new OleDbConnection(y1);
                baglanti1.Open();
                string ekle1 = "insert into adminler (kullaniciadi,sifre, mail, ad, soyad) values (@kullaniciadi,@sifre,@mail,@ad,@soyad)";
                OleDbCommand komut1 = new OleDbCommand(ekle1, baglanti1);

                komut1.Parameters.AddWithValue(Localization.f, textBox3.Text);
                komut1.Parameters.AddWithValue(Localization.g, txt_sifre.Text);
                komut1.Parameters.AddWithValue(Localization.h,txt_mail.Text);
                komut1.Parameters.AddWithValue(Localization.j, txt_gisim.Text);
                komut1.Parameters.AddWithValue(Localization.k, txt_gsoyisim.Text);
                komut1.ExecuteNonQuery();

                baglanti1.Close();
                MessageBox.Show(Localization.frmdgr_basari, Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Griddoldur();
                Frm2 x = new Frm2();
                x.label9.Visible = true;
                x.label8.Visible = false;
                x.textBox1.Text = Localization.acikk;
                x.label12.Text = textBox3.Text;
                x.txt_alinansifre.Text = txt_sifre.Text;
                x.label11.Visible = false;
                x.pictureBox1.Visible = false;
                x.pictureBox2.Visible = true;
                x.Show();
                this.Hide();
            }
            else if(textBox1.Text == string.Empty)
            {
                MessageBox.Show(Localization.frmadmin_ktc, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox1.Text != textBox2.Text)
            {
                MessageBox.Show(Localization.frmadmin_xb, Localization.Hata,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Frm2 x = new Frm2();
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
    }
}
