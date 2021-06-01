using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Uygulaması
{
    public partial class frmkitapara : Form
    {
        int Move1;
        int Mouse_X;
        int Mouse_Y;
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public frmkitapara()
        {
            InitializeComponent();
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.MultiSelect = false;
        }
        public string ad { get; set; }
        public string kitapid { get; set; }
        public string telno { get; set; }
        public string onay { get; set; }
        public string id { get; set; }
        public string tarih { get; set; }
        public string x { get; set; }
        public string email_frmara { get; set; }
        public string kontrol5 { get; set; }
        public string xyz { get; set; }
        public string sifr { get; set; }
        public string kayit1_1 { get; set; }
        public string kayit2_2 { get; set; }
        public string kayit3_3 { get; set; }
        public string kayit4_4 { get; set; }
        public string kayit5_5 { get; set; }
        public string kayit6_6 { get; set; }
        public string cmb { get; set; }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect *from kitap", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.frmkisi_kitap);
            DataGridView1.DataSource = ds.Tables[Localization.frmkisi_kitap];
            con.Close();
        }
        void cozunurluk()
        {
            int bizimPcGenislik = 1920;
            int bizimPcYukseklik = 1080;

            float kullanilanPcGenislik = SystemInformation.PrimaryMonitorSize.Width;
            float kullanilanPcYukseklik = SystemInformation.PrimaryMonitorSize.Height;

            float forGen = this.Size.Width;
            float forYuk = this.Size.Height;

            float genislikOrani = (bizimPcGenislik / kullanilanPcGenislik);
            float yukseklikOrani = (bizimPcYukseklik / kullanilanPcYukseklik);

            float dt1_g = DataGridView1.Width;
            float dt1_y = DataGridView1.Height;

            float dt1_lx = DataGridView1.Location.X;
            float dt1_ly = DataGridView1.Location.Y;

            string nesFontAdi;
            float nesFont, nesX, nesY, nesGen, nesYuk;
            int fontBuyuk;

            foreach (Control nesne in this.Controls)
            {
                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)(nesX / genislikOrani), (int)(nesY / yukseklikOrani));
                nesne.Size = new Size((int)(nesGen / genislikOrani), (int)(nesYuk / yukseklikOrani));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                this.Size = new Size((int)((forGen / genislikOrani)), (int)(forYuk / yukseklikOrani));
            }

            foreach (Control nesne in DataGridView1.Controls)
            {
                float x = bizimPcGenislik / dt1_g; // bu groupbox1 genişlik oranı
                float y = bizimPcYukseklik / dt1_y; // bu groupbox1 yükseklik oranı

                float lx = bizimPcGenislik / dt1_lx;
                float ly = bizimPcYukseklik / dt1_ly;

                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)(nesX / genislikOrani), (int)(nesY / yukseklikOrani));
                nesne.Size = new Size((int)(nesGen / genislikOrani), (int)(nesYuk / yukseklikOrani));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                DataGridView1.Size = new Size((int)((kullanilanPcGenislik / x)), (int)(kullanilanPcYukseklik / y));
                DataGridView1.Location = new Point((int)((kullanilanPcGenislik / lx)), (int)(kullanilanPcYukseklik / ly));
            }

            foreach (Control nesne in panel1.Controls)
            {
                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)(nesX / genislikOrani), (int)(nesY / yukseklikOrani));
                nesne.Size = new Size((int)(nesGen / genislikOrani), (int)(nesYuk / yukseklikOrani));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
            }
        }
        void metin()
        {
            DataGridView1.Columns[0].HeaderText = Localization.frmekle_header1;
            DataGridView1.Columns[0].Width = 800;
            DataGridView1.Columns[1].HeaderText = Localization.frmekle_header2;
            DataGridView1.Columns[1].Width = 200;
            DataGridView1.Columns[3].HeaderText = Localization.frmekle_header4;
            DataGridView1.Columns[3].Width = 100;
            DataGridView1.Columns[4].HeaderText = Localization.frmekle_header5;
            DataGridView1.Columns[4].Width = 150;
            DataGridView1.Columns[5].HeaderText = Localization.frmekle_header6;
            DataGridView1.Columns[5].Width = 150;
            DataGridView1.Columns[2].Visible = false;
            DataGridView1.Columns[6].Visible = false;
            DataGridView1.Columns[7].Visible = false;
            DataGridView1.ClearSelection();

            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                object o = DataGridView1.Rows[i].Cells[Localization.frmekle_kisi].Value.ToString();
                string x = Convert.ToString(o);
                if (string.IsNullOrEmpty(x) == false)
                {
                    renk.BackColor = Color.Red;
                }
                DataGridView1.Rows[i].DefaultCellStyle = renk;
            }

            label1.Text = Localization.frmkitapara_label1;
            label2.Text = Localization.frmkitapara_label2;
            label3.Text = Localization.frmkitapara_label3;
            label4.Text = Localization.frmkitapara_label4;
            linkLabel2.Text = Localization.frmkitapara_linklabel2;
            btn_kitapsec.Text = Localization.frmkitapara_btnkitapsec_text;
        }
        void engduzelt()
        {
            btn_kitapsec.Size = new Size(198,49);
            btn_kitapsec.Location = new Point(500,451);
            label2.Location = new Point(714, 439);
        }
        void japanduzelt()
        {

        }
        private void frmkitapara_Load(object sender, EventArgs e)
        {
            Griddoldur();
            txt_ad.Text = ad;
            txt_telno.Text = telno;
            lbl_onay.Text = onay;
            txt_id.Text = id;
            txt_tarih.Text = tarih;
            txt_xy.Text = x;
            txt_email.Text = email_frmara;
            textBox2.Text = kontrol5;
            textBox3.Text = xyz;
            txt_sifr.Text = sifr;
            textBox4.Text = kayit1_1;
            textBox5.Text = kayit2_2;
            textBox6.Text = kayit3_3;
            textBox7.Text = kayit4_4;
            textBox8.Text = kayit5_5;
            textBox9.Text = kayit6_6;
            txt_selected.Text = cmb;

            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                cozunurluk();
                metin();
                engduzelt();
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                cozunurluk();
                metin();
                japanduzelt();
            }
            else
            {
                cozunurluk();
                metin();
            }
        }
        private void txt_kitapyaz_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "Kitabinİsmi Like '%" + txt_kitapyaz.Text.ToString().Replace("'", "’") + "%' or KitabinYazari Like '%" + txt_kitapyaz.Text.ToString().Replace("'", "’") + "%'";
            DataGridView1.DataSource = dv;

            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                try
                {
                    Application.DoEvents();
                    DataGridViewCellStyle renk = new DataGridViewCellStyle();
                    object o = DataGridView1.Rows[i].Cells[Localization.frmekle_kisi].Value.ToString();
                    string x = Convert.ToString(o);
                    if (string.IsNullOrEmpty(x) == false)
                    {
                        renk.BackColor = Color.Red;
                    }
                    DataGridView1.Rows[i].DefaultCellStyle = renk;
                }
                catch
                {
                    MessageBox.Show(txt_kitapyaz.Text.ToString() + Localization.frmekle_uyaristring, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        void geridön()
        {
            string x = txt_gizli.Text;
            if (string.IsNullOrEmpty(x) == false)
            {
                MessageBox.Show(Localization.frmkitapara_bilg, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm7 frm = new Frm7
                {
                    kitapismi = txt_gizli.Text,
                    ad = txt_ad.Text,
                    telno = txt_telno.Text,
                    onay = lbl_onay.Text,
                    id = txt_id.Text,
                    kitapid = txt_kitapid.Text,
                    tarih = txt_tarih.Text,
                    y = txt_xy.Text,
                    email = txt_email.Text,
                    kontrol = textBox2.Text,
                    isimkontrolkak = textBox3.Text,
                    alinansifre = txt_sifr.Text,
                    kayit1 = textBox4.Text,
                    kayit2 = textBox5.Text,
                    kayit3 = textBox6.Text,
                    kayit4 = textBox7.Text,
                    kayit5 = textBox8.Text,
                    kontrolid = textBox9.Text,
                    x = txt_selected.Text
                };

                this.Hide();
                frm.ShowDialog();
                //this.Hide();
                txt_gizli.Text = null;
            }
            else
            {
                MessageBox.Show(Localization.frmkitapara_uyari, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_kitapsec_Click(object sender, EventArgs e)
        {
            string x = txt_gizlikisi.Text;
            if (string.IsNullOrEmpty(x) == false)
            {
                txt_kitapyaz.Clear();
                txt_kitapid.Clear();
                txt_gizlikisi.Clear();
                MessageBox.Show(Localization.frmkitapara_uyarı2, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (textBox1.Text != txt_kitapyaz.Text)
                {
                    MessageBox.Show(Localization.frmkitapara_uyari, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    geridön();
                }
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_gizli.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kitapyaz.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kitapid.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_gizlikisi.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formarama x = new Formarama();
            x.Show();
        }
        private void btn_geridön_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show(Localization.frmkitapara_soru, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Frm7 frm = new Frm7
                {
                    kitapismi = txt_gizli.Text,
                    ad = txt_ad.Text,
                    telno = txt_telno.Text,
                    onay = lbl_onay.Text,
                    id = txt_id.Text,
                    kitapid = txt_kitapid.Text,
                    tarih = txt_tarih.Text,
                    y = txt_xy.Text,
                    email = txt_email.Text,
                    kontrol = textBox2.Text,
                    isimkontrolkak = textBox3.Text,
                    alinansifre = txt_sifr.Text,
                    kayit1 = textBox4.Text,
                    kayit2 = textBox5.Text,
                    kayit3 = textBox6.Text,
                    kayit4 = textBox7.Text,
                    kayit5 = textBox8.Text,
                    kontrolid = textBox9.Text,
                    x = txt_selected.Text
                };
                frm.Show();
                this.Close();
            }
        }
        private void btn_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move1 = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move1 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move1 = 0;
        }
        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Move1 = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move1 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            Move1 = 0;
        }
        private void btn_kitapsec_MouseEnter(object sender, EventArgs e)
        {
            btn_kitapsec.ForeColor = Color.Red;
        }
        private void btn_kitapsec_MouseLeave(object sender, EventArgs e)
        {
            btn_kitapsec.ForeColor = Color.Black;
        }
    }
}
