using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Uygulaması
{
    public partial class frmgiris : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public frmgiris()
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
        private void frmgiris_Load(object sender, EventArgs e)
        {
            Griddoldur();
            linkLabel2.Text = Localization.frmgrs_linklabel2;
            linkLabel1.Text = Localization.frmgrs_linklabel1;
            button1.Text = Localization.frmgrs_btn1;
            label1.Text = Localization.frmgrs_label1;
            label2.Text = Localization.frmgrs_label2;

            label1.Location = new Point(-1, 9);
            label2.Location = new Point(66, 45);

            if(Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                label1.Location = new Point(14, 8);
                label2.Location = new Point(18, 44);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Griddoldur();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "kullaniciadi Like '%" + txt_kullaniciadi.Text + "%' and sifre Like '%" + txt_sifre.Text + "%'";
            dataGridView1.DataSource = dv;

            try
            {
                txt_kontrol_kullaniciadi.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txt_kontrol_sifre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            }
            catch
            {
               
            }

            if(txt_kullaniciadi.Text == txt_kontrol_kullaniciadi.Text && txt_sifre.Text == txt_kontrol_sifre.Text)
            {
                MessageBox.Show(Localization.frmgrs_grs,Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);

                Frm2 frm = new Frm2();

                frm.label9.Visible = true;
                frm.label8.Visible = false;
                frm.textBox1.Text = Localization.acikk;
                frm.pictureBox1.Visible = false;
                frm.pictureBox2.Visible = true;
                frm.label11.Visible = false;
                frm.label12.Text = txt_kullaniciadi.Text;
                frm.txt_alinansifre.Text = txt_sifre.Text;

                frm.Show();
                this.Close();
            }
            else if(string.IsNullOrEmpty(txt_kullaniciadi.Text) == true || string.IsNullOrEmpty(txt_sifre.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1,Localization.Hata,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Localization.frmgrs_msg,Localization.Hata,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Frm2 frm = new Frm2();
            frm.Show();
            this.Close();
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
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmbilgi x = new frmbilgi();
            x.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsifre x = new frmsifre();
            x.Show();
            this.Hide();
        }
    }
}
