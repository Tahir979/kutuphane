using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Kütüphane_Uygulaması
{
    public partial class Frm3 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbDataAdapter da2;
        OleDbDataAdapter da4;
        OleDbDataAdapter da5;
        OleDbCommand cmd;
        OleDbCommand cmd2;
        OleDbCommand cmd3;
        OleDbCommand cmd4;
        DataSet ds;
        DataSet ds2;
        DataSet ds4;
        DataSet ds5;

        public string kontrol2 { get; set; }
        public string isimkontrol2 { get; set; }
        public string sifre2 { get; set; }

        public Frm3()
        {
            InitializeComponent();
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.MultiSelect = false;
        }
        void cozunurluk()
        {
            float ölcek = 120;

            float dpiX;
            Graphics graphics = this.CreateGraphics();
            dpiX = graphics.DpiX;

            float altinoran = ölcek / dpiX; // 120/ 96 = 1,25 eğer nesnelerin boyutunun büyümesini istiyorsak yüzde yüz ölçekte şuan çarpım yapmalıyız nesne boyutlarını bu altınoranla
            //yüzde yüz ölçeklendirmede mükemmel çalıştı bu sistem, peki yüzde 125 de filan neden işlemedi acaba
            //çünkü oran 1 oldu ve ben önceden nasıl gördüysem yine aynısı kaldı onda nasıl harekete geçirebilirim ki

            int bizimPcGenislik = 1920;
            int bizimPcYukseklik = 1080;

            float kullanilanPcGenislik = SystemInformation.PrimaryMonitorSize.Width;
            float kullanilanPcYukseklik = SystemInformation.PrimaryMonitorSize.Height;

            float genislikOrani = (bizimPcGenislik / kullanilanPcGenislik);
            float yukseklikOrani = (bizimPcYukseklik / kullanilanPcYukseklik);

            float groupbox1_g = groupBox1.Width;
            float groupbox1_y = groupBox1.Height;

            float groupbox1_lx = groupBox1.Location.X;
            float groupbox1_ly = groupBox1.Location.Y;


            float groupbox2_g = groupBox2.Width;
            float groupbox2_y = groupBox2.Height;

            float groupbox2_lx = groupBox2.Location.X;
            float groupbox2_ly = groupBox2.Location.Y;


            float groupbox3_g = groupBox3.Width;
            float groupbox3_y = groupBox3.Height;

            float groupbox3_lx = groupBox3.Location.X;
            float groupbox3_ly = groupBox3.Location.Y;


            float dt1_g = DataGridView1.Width;
            float dt1_y = DataGridView1.Height;

            float dt1_lx = DataGridView1.Location.X;
            float dt1_ly = DataGridView1.Location.Y;

            string nesFontAdi;
            float nesFont, nesX, nesY, nesGen, nesYuk;
            int fontBuyuk;

            foreach (Control nesne in Controls)
            {
                nesFontAdi = nesne.Font.SystemFontName; //demek sorun bu nesne locationlarının yanlış ayarlanmasıymış form içinde
                nesFont = nesne.Font.Size;
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                this.Size = new Size((int)((bizimPcGenislik / genislikOrani)), (int)(bizimPcYukseklik / yukseklikOrani));
                this.Location = new Point(0, 0);
                this.WindowState = FormWindowState.Maximized;
            }

            foreach (Control nesne in groupBox1.Controls)
            {
                float x = bizimPcGenislik / groupbox1_g; // 1920 / 466 = 4,12
                float y = bizimPcYukseklik / groupbox1_y;

                float lx = bizimPcGenislik / groupbox1_lx;
                float ly = bizimPcYukseklik / groupbox1_ly;

                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                groupBox1.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                groupBox1.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
            }

            foreach (Control nesne in groupBox2.Controls)
            {
                float x = bizimPcGenislik / groupbox2_g;
                float y = bizimPcYukseklik / groupbox2_y;

                float lx = bizimPcGenislik / groupbox2_lx;
                float ly = bizimPcYukseklik / groupbox2_ly;

                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                groupBox2.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                groupBox2.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
            }

            foreach (Control nesne in groupBox3.Controls)
            {
                float x = bizimPcGenislik / groupbox3_g;
                float y = bizimPcYukseklik / groupbox3_y;

                float lx = bizimPcGenislik / groupbox3_lx;
                float ly = bizimPcYukseklik / groupbox3_ly;

                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                groupBox3.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                groupBox3.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
            }

            foreach (Control nesne in Panel3.Controls)
            {
                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
            }

            foreach (Control nesne in DataGridView1.Controls)
            {
                float x = bizimPcGenislik / dt1_g;
                float y = bizimPcYukseklik / dt1_y;

                float lx = bizimPcGenislik / dt1_lx;
                float ly = bizimPcYukseklik / dt1_ly;

                nesFontAdi = nesne.Font.SystemFontName;
                nesFont = nesne.Font.Size;
                nesX = nesne.Location.X;
                nesY = nesne.Location.Y;
                nesGen = nesne.Size.Width;
                nesYuk = nesne.Size.Height;
                nesne.Location = new Point((int)((nesX / genislikOrani) * altinoran), (int)((nesY / yukseklikOrani) * altinoran));
                nesne.Size = new Size((int)((nesGen / genislikOrani) * altinoran), (int)((nesYuk / yukseklikOrani) * altinoran));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                DataGridView1.Size = new Size((int)((kullanilanPcGenislik / x) * altinoran), (int)((kullanilanPcYukseklik / y) * altinoran));
                DataGridView1.Location = new Point((int)((kullanilanPcGenislik / lx) * altinoran), (int)((kullanilanPcYukseklik / ly) * altinoran));
            }
        }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect *from kitap Order By ID DESC", con);
            da2 = new OleDbDataAdapter("SElect *from kitaplik", con);
            da4 = new OleDbDataAdapter("Select * from tüm", con);
            da5 = new OleDbDataAdapter("Select * from islemdokum",con);
            ds = new DataSet();
            ds2 = new DataSet();
            ds4 = new DataSet();
            ds5 = new DataSet();
            con.Open();
            da.Fill(ds,Localization.frmkisi_kitap);
            da2.Fill(ds2, Localization.frmekle_kitaplik);
            da4.Fill(ds4, Localization.frmkisi_tüm);
            da5.Fill(ds5, Localization.islemdokum);
            DataGridView1.DataSource = ds.Tables[Localization.frmkisi_kitap];
            dataGridView2.DataSource = ds2.Tables[Localization.frmekle_kitaplik];
            dataGridView4.DataSource = ds4.Tables[Localization.frmkisi_tüm];
            dataGridView5.DataSource = ds5.Tables[Localization.islemdokum];
            con.Close();
        }
        void Xyz()
        {
            OleDbConnection baglan = new OleDbConnection(Localization.oledbcon);
            baglan.Open();
            OleDbCommand command = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from kitaplik"
            };
            OleDbCommand command2 = new OleDbCommand
            {
                Connection = baglan,
                CommandText = "select* from kitap"
            };

            OleDbDataReader reader = command.ExecuteReader();
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader.Read())
            {
                cmb_kitaplık.Items.Add(reader[Localization.frmekle_ad]);
                comboBox1.Items.Add(reader[Localization.frmekle_ad]);
            }
            while(reader2.Read())
            {
                comboBox3.Items.Add(reader2[Localization.nasiyok]);
                comboBox2.Items.Add(reader2[Localization.nasiyok]);
            }
        }
        void ikilik()
        {
            DataGridView1.Columns[0].HeaderText = Localization.frmekle_header1;
            DataGridView1.Columns[0].Width = 1022;
            DataGridView1.Columns[1].HeaderText = Localization.frmekle_header2;
            DataGridView1.Columns[1].Width = 225;
            DataGridView1.Columns[2].HeaderText = Localization.frmekle_header3;
            DataGridView1.Columns[2].Width = 75;
            DataGridView1.Columns[3].HeaderText = Localization.frmekle_header4;
            DataGridView1.Columns[3].Width = 210;
            DataGridView1.Columns[4].HeaderText = Localization.frmekle_header5;
            DataGridView1.Columns[4].Width = 60;
            DataGridView1.Columns[5].HeaderText = Localization.frmekle_header6;
            DataGridView1.Columns[5].Width = 100;
            DataGridView1.Columns[6].HeaderText = Localization.düzID;
            DataGridView1.Columns[6].Width = 75;
            DataGridView1.Columns[8].HeaderText = Localization.frmekle_header7;
            DataGridView1.Columns[8].Width = 130;
        }
        void siralama()
        {
            string[] arr = new string[comboBox3.Items.Count];
            comboBox3.Items.CopyTo(arr, 0);
            comboBox2.Items.CopyTo(arr, 0);

            var arr2 = arr.Distinct();

            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            foreach (string s in arr2)
            {
                comboBox3.Items.Add(s);
                comboBox2.Items.Add(s);
            }

            ArrayList list = new ArrayList();
            foreach (object o in comboBox3.Items)
            {
                list.Add(o);
            }
            list.Sort();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            foreach (object o in list)
            {
                comboBox3.Items.Add(o);
                comboBox2.Items.Add(o);
            }
        }
        void temizle()
        {
            DataGridView1.ClearSelection();
            txt_kitapismi.Focus();
            textBox1.Clear();
            txt_basımyili.Clear();
            txt_kitapismi.Clear();
            txt_rafnumarasi.Clear();
            txt_yazar.Clear();
            txt_sıra.Clear();
            textBox6.Clear();
            txt_kitapara_dil.Clear();
            cmb_kitaplık.Items.Clear();
            cmb_rafkatı.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.frmekle_toolstripmenu0;

            menuStrip1.Enabled = true;

            Xyz();
            rafkati();
        }
        void rafkati()
        {
            cmb_rafkatı.Items.Add(Localization.frmekle_0);
            cmb_rafkatı.Items.Add(Localization.frmekle_1);
            cmb_rafkatı.Items.Add(Localization.frmekle_2);
            cmb_rafkatı.Items.Add(Localization.frmekle_3);
            cmb_rafkatı.Items.Add(Localization.frmekle_4);
            cmb_rafkatı.Items.Add(Localization.frmekle_5);
        }
        void renk()
        {
            dt_dt1_void();
        }
        void guncellebilgi()
        {
            if (txt_kitapismi.Text != txt_kayitlikitapismi.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın isminde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlikitapismi.Text + " \nYeni kayıt: " + txt_kitapismi.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (txt_yazar.Text != txt_kayitliyazar.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın yazarında değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitliyazar.Text + " \nYeni kayıt: " + txt_yazar.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (txt_basımyili.Text != txt_kayitlibasimyili.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın basım yılında değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlibasimyili.Text + " \nYeni kayıt: " + txt_basımyili.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (txt_rafnumarasi.Text != txt_kayitlinumara.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın raf numarasında değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlinumara.Text + " \nYeni kayıt: " + txt_rafnumarasi.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (textBox6.Text != txt_kayitlidil.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın dilinde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlidil.Text + " \nYeni kayıt: " + textBox6.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (cmb_kitaplık.Text != txt_kayitlikitaplik.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın kitaplık kategorisinde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlikitaplik.Text + " \nYeni kayıt: " + cmb_kitaplık.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (cmb_rafkatı.Text != txt_kayitlirafkati.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = textBox2.Text + " ID numaralı kitabın raf katında değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlirafkati.Text + " \nYeni kayıt: " + cmb_rafkatı.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show(textBox2.Text.ToString() + Localization.bnhjk, Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void guncelle()
        {
            if (string.IsNullOrEmpty(textBox4.Text) == false)
            {
                cmd = new OleDbCommand();
                cmd2 = new OleDbCommand();
                cmd3 = new OleDbCommand();

                con.Open();
                cmd.Connection = con;
                cmd2.Connection = con;
                cmd3.Connection = con;

                cmd.CommandText = "update kitap set Kitabinİsmi=@Kitabinİsmi, KitabinYazari=@KitabinYazari, KitabınBasımYılı=@KitabınBasımYılı, KitabınRafınınİsmi=@KitabınRafınınİsmi, KitabınRafKatı=@KitabınRafKatı, KitabınRafNumarası=@KitabınRafNumarası, dil=@dil where ID=@ID";
                cmd.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_kitapismi.Text.ToString().Replace("'", "’"));
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, txt_yazar.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, txt_basımyili.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplık.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_rafkatı.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_rafnumarasi.Text);
                cmd.Parameters.AddWithValue(Localization.dil_et, textBox6.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_ID, txt_sıra.Text);

                cmd2.CommandText = "update kisiler set AldigiKitabinİsmi=@AldigiKitabinİsmi where kitapid=@kitapid";
                cmd2.Parameters.AddWithValue(Localization.frmekle_AldigiKitabinİsmi, txt_kitapismi.Text.ToString().Replace("'", "’"));
                cmd2.Parameters.AddWithValue(Localization.frmekle_kitapid, textBox2.Text);

                cmd3.CommandText = "update tüm set AldigiKitabinİsmi=@AldigiKitabinİsmi where ID=@ID";
                cmd3.Parameters.AddWithValue(Localization.frmekle_AldigiKitabinİsmi, txt_kitapismi.Text.ToString().Replace("'", "’"));
                cmd3.Parameters.AddWithValue(Localization.frmekle_ID, textBox5.Text);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                con.Close();
                DataGridView1.ClearSelection();
                temizle();
                cmb_kitaplık.Text = Localization.bosdeger;
                cmb_rafkatı.Text = Localization.bosdeger;
                Xyz();
                label9.Visible = true;
                label11.Visible = true;
                rafkati();
                siralama();
                Griddoldur();
                MessageBox.Show(Localization.frmekle_guncelle_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                guncellebilgi();
                temizle();
                error();
            }
            else
            {
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "update kitap set Kitabinİsmi=@Kitabinİsmi, KitabinYazari=@KitabinYazari, KitabınBasımYılı=@KitabınBasımYılı, KitabınRafınınİsmi=@KitabınRafınınİsmi, KitabınRafKatı=@KitabınRafKatı, KitabınRafNumarası=@KitabınRafNumarası, dil=@dil where ID=@ID";

                cmd.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_kitapismi.Text.ToString().Replace("'", "’"));
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, txt_yazar.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, txt_basımyili.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplık.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_rafkatı.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_rafnumarasi.Text);
                cmd.Parameters.AddWithValue(Localization.dil_et, textBox6.Text);
                cmd.Parameters.AddWithValue(Localization.frmekle_ID, txt_sıra.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                DataGridView1.ClearSelection();
                cmb_kitaplık.Text = Localization.bosdeger;
                cmb_rafkatı.Text = Localization.bosdeger;
                Xyz();
                label9.Visible = true;
                label11.Visible = true;
                rafkati();
                siralama();
                Griddoldur();
                MessageBox.Show(Localization.frmekle_guncelle_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                guncellebilgi();
                temizle();
                error();
            }
            renk();
        }
        void sayi()
        {
            int x;
            x = DataGridView1.RowCount;
            string y = x.ToString();
            label10.Text = y;
        }
        void sayi_tüm()
        {
            int x;
            x = DataGridView1.RowCount;
            string y = x.ToString();
            label27.Text = y;
        }
        void kaydet()
        {
            string y1 = Localization.oledbcon;
            OleDbConnection baglanti1 = new OleDbConnection(y1);
            baglanti1.Open();
            string ekle1 = "insert into kitap (Kitabinİsmi,KitabinYazari,KitabınBasımYılı,KitabınRafınınİsmi,KitabınRafKatı,KitabınRafNumarası,dil) values (@Kitabinİsmi,@KitabinYazari,@KitabınBasımYılı,@KitabınRafınınİsmi,@KitabınRafKatı,@KitabınRafNumarası,@dil)";
            OleDbCommand komut1 = new OleDbCommand(ekle1, baglanti1);

            komut1.Parameters.AddWithValue(Localization.frmekle_Kitabinİsmi, txt_kitapismi.Text.ToString().Replace("'", "’"));
            komut1.Parameters.AddWithValue(Localization.frmekle_KitabinYazari, txt_yazar.Text);
            komut1.Parameters.AddWithValue(Localization.frmekle_KitabınBasımYılı, txt_basımyili.Text);
            komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafınınİsmi, cmb_kitaplık.Text);
            komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafKatı, cmb_rafkatı.Text);
            komut1.Parameters.AddWithValue(Localization.frmekle_KitabınRafNumarası, txt_rafnumarasi.Text);
            komut1.Parameters.AddWithValue(Localization.dil_et, textBox6.Text);
            komut1.ExecuteNonQuery();

            DataGridView1.ClearSelection();
            cmb_kitaplık.Text = Localization.bosdeger;
            cmb_rafkatı.Text = Localization.bosdeger;
            Xyz();
            label9.Visible = true;
            label11.Visible = true;
            rafkati();
            siralama();
            Griddoldur();
            sayi();
            sayi_tüm();
            error();
            renk();

            textBox2.Text = DataGridView1.Rows[0].Cells[6].Value.ToString();
            string cumle = textBox2.Text + " ID numaralı " + txt_kitapismi.Text.ToString() + " adlı yeni bir kitap eklendi.\n\nYazar: " +txt_yazar.Text + "\nBasım yılı: " + txt_basımyili.Text + "\nNumarası: " +txt_rafnumarasi.Text + "\nDili: " + textBox6.Text + "\nKitaplığının ismi: " + cmb_kitaplık.Text + "\nRaf katı: " + cmb_rafkatı.Text;
            string ekle2 = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
            OleDbCommand komut2 = new OleDbCommand(ekle2, baglanti1);
            komut2.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
            komut2.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
            komut2.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
            komut2.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show(Localization.frmekle_ekle_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(textBox2.Text + Localization.tyytjh);

            temizle();
        }
        void sil()
        {
            string cumle = textBox2.Text + " ID numaralı " + txt_kitapismi.Text.ToString() + " adlı adlı kitap silindi..\n\nEn son kayıtlı olan Yazar: " + txt_yazar.Text + "\nEn son kayıtlı olan Basım yılı: " + txt_basımyili.Text + "\nEn son kayıtlı olan Numarası: " + txt_rafnumarasi.Text + "\nEn son kayıtlı olan Dili: " + textBox6.Text + "\nEn son kayıtlı olan Kitaplığının ismi: " + cmb_kitaplık.Text + "\nEn son kayıtlı olan Raf katı: " + cmb_rafkatı.Text;

            cmd = new OleDbCommand();
            cmd2 = new OleDbCommand();

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM kitap WHERE ID=@ID";
            cmd.Parameters.AddWithValue(Localization.frmekle_ID, txt_sıra.Text);
            cmd2.Connection = con;
            cmd2.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
            cmd2.Parameters.AddWithValue(Localization.dsgas, textBox9.Text);
            cmd2.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
            cmd2.Parameters.AddWithValue(Localization.frgr, txt_tarih.Text);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            Griddoldur();
            DataGridView1.ClearSelection();
            MessageBox.Show(Localization.frmekle_sil_basari, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            cmb_kitaplık.Text = Localization.bosdeger;
            cmb_rafkatı.Text = Localization.bosdeger;
            Xyz();
            label9.Visible = true;
            label11.Visible = true;
            rafkati();
            siralama();
            sayi();
            sayi_tüm();
            error();
            renk();

            MessageBox.Show(textBox2.Text + Localization.ghgf);
        }
        void error()
        {
            errorProvider1.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);
            errorProvider2.SetError(this.txt_yazar, Localization.frmadmin_ktc);
            errorProvider3.SetError(this.txt_basımyili, Localization.frmadmin_ktc);
            errorProvider4.SetError(this.txt_rafnumarasi, Localization.frmadmin_ktc);
            errorProvider5.SetError(this.cmb_kitaplık, Localization.frmadmin_ktc);
            errorProvider6.SetError(this.cmb_rafkatı, Localization.frmadmin_ktc);
            errorProvider7.SetError(this.menuStrip1, Localization.frmadmin_ktc);

            errorProvider8.Clear();
            errorProvider9.Clear();
            errorProvider10.Clear();
            errorProvider11.Clear();
            errorProvider12.Clear();
            errorProvider13.Clear();
            errorProvider14.Clear();
            errorProvider15.Clear();
            errorProvider16.Clear();
            errorProvider17.Clear();
            errorProvider18.Clear();
            errorProvider19.Clear();
            errorProvider20.Clear();
            errorProvider21.Clear();
        }
        void kitapismitekraralt()
        {
            if (txt_kitapismi.Text == Localization.bosdeger)
            {
                errorProvider8.Clear();
                errorProvider15.Clear();
                errorProvider1.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                if (txt_kitapismi.Text == txt_kayitlikitapismi.Text)
                {
                    errorProvider1.Clear();
                    errorProvider8.Clear();
                    errorProvider15.SetError(this.txt_kitapismi, Localization.hgfhgf);
                    txt_error_1.Text = Localization.frm_sifir;
                }

                else if (txt_kitapismi.Text != txt_kayitlikitapismi.Text)
                {
                    errorProvider1.Clear();
                    errorProvider15.Clear();
                    errorProvider8.SetError(this.txt_kitapismi, Localization.suitable);
                    txt_error_1.Text = Localization.frm_sifir;
                }
            }
        }
        void kitapismitekrarüst()
        {
            if (txt_kitapismi.Text == Localization.bosdeger)
            {
                errorProvider15.Clear();
                errorProvider1.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);
                errorProvider8.Clear();
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider15.Clear();
                errorProvider8.SetError(this.txt_kitapismi, Localization.suitable);
                txt_error_1.Text = Localization.frm_sifir;
            }
        }
        void yazarismitekraralt()
        {
            if (txt_yazar.Text == Localization.bosdeger)
            {
                errorProvider9.Clear();
                errorProvider16.Clear();
                errorProvider2.SetError(this.txt_yazar, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                if (txt_yazar.Text == txt_kayitliyazar.Text)
                {
                    errorProvider2.Clear();
                    errorProvider9.Clear();
                    errorProvider16.SetError(this.txt_yazar, Localization.rewrer);
                    txt_error_2.Text = Localization.frm_sifir;
                }

                else if (txt_yazar.Text != txt_kayitliyazar.Text)
                {
                    errorProvider2.Clear();
                    errorProvider16.Clear();
                    errorProvider9.SetError(this.txt_yazar, Localization.suitable);
                    txt_error_2.Text = Localization.frm_sifir;
                }
            }
        }
        void yazarismitekrarüst()
        {
            if (txt_yazar.Text == Localization.bosdeger)
            {
                errorProvider16.Clear();
                errorProvider9.Clear();
                errorProvider2.SetError(this.txt_yazar, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider16.Clear();
                errorProvider2.Clear();
                errorProvider9.SetError(this.txt_yazar, Localization.suitable);
                txt_error_2.Text = Localization.frm_sifir;
            }
        }
        void basımyilitekraralt()
        {
            if (txt_basımyili.Text == Localization.bosdeger)
            {
                errorProvider10.Clear();
                errorProvider17.Clear();
                errorProvider3.SetError(this.txt_basımyili, Localization.frmadmin_ktc);
                txt_error_3.Text = Localization.frm_bir;
            }
            else
            {
                if (txt_basımyili.Text == txt_kayitlibasimyili.Text)
                {
                    errorProvider3.Clear();
                    errorProvider10.Clear();
                    errorProvider17.SetError(this.txt_basımyili, Localization.hrtrhyh);
                    txt_error_3.Text = Localization.frm_sifir;
                }

                else if (txt_basımyili.Text != txt_kayitlibasimyili.Text)
                {
                    errorProvider3.Clear();
                    errorProvider17.Clear();
                    errorProvider10.SetError(this.txt_basımyili, Localization.suitable);
                    txt_error_3.Text = Localization.frm_sifir;
                }
            }
        }
        void basimyilitekrarüst()
        {
            if (string.IsNullOrEmpty(txt_basımyili.Text) == true)
            {
                label9.Visible = true;
                errorProvider10.Clear();
                errorProvider17.Clear();
                errorProvider3.SetError(this.txt_basımyili, Localization.frmadmin_ktc);
                txt_error_3.Text = Localization.frm_bir;
            }
            else
            {
                label9.Visible = false;
                errorProvider10.Clear();
                errorProvider17.Clear();
                errorProvider3.Clear();
                errorProvider10.SetError(this.txt_basımyili, Localization.suitable);
                txt_error_3.Text = Localization.frm_sifir;
            }
        }
        void rafnumarasialt()
        {
            if (txt_rafnumarasi.Text == Localization.bosdeger)
            {
                errorProvider11.Clear();
                errorProvider18.Clear();
                errorProvider4.SetError(this.txt_rafnumarasi, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                if (txt_rafnumarasi.Text == txt_kayitlinumara.Text)
                {
                    errorProvider4.Clear();
                    errorProvider11.Clear();
                    errorProvider18.SetError(this.txt_rafnumarasi, Localization.vfdbfd);
                    txt_error_4.Text = Localization.frm_sifir;
                }

                else if (txt_rafnumarasi.Text != txt_kayitlinumara.Text)
                {
                    errorProvider4.Clear();
                    errorProvider18.Clear();
                    errorProvider11.SetError(this.txt_rafnumarasi, Localization.suitable);
                    txt_error_4.Text = Localization.frm_sifir;
                }
            }
        }
        void rafnumarasiüst()
        {
            if (string.IsNullOrEmpty(txt_rafnumarasi.Text) == true)
            {
                label11.Visible = true;
                errorProvider11.Clear();
                errorProvider18.Clear();
                errorProvider4.SetError(this.txt_rafnumarasi, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                label11.Visible = false;
                errorProvider11.Clear();
                errorProvider18.Clear();
                errorProvider4.Clear();
                errorProvider11.SetError(this.txt_rafnumarasi, Localization.suitable);
                txt_error_4.Text = Localization.frm_sifir;
            }
        }
        void cmbkitapliktekraralt()
        {
            if (cmb_kitaplık.Text == Localization.bosdeger)
            {
                errorProvider12.Clear();
                errorProvider19.Clear();
                errorProvider5.SetError(this.cmb_kitaplık, Localization.frmadmin_ktc);
                txt_error_5.Text = Localization.frm_bir;
            }
            else
            {
                if (cmb_kitaplık.Text == txt_kayitlikitaplik.Text)
                {
                    errorProvider5.Clear();
                    errorProvider12.Clear();
                    errorProvider19.SetError(this.cmb_kitaplık, Localization.fdsd);
                    txt_error_5.Text = Localization.frm_sifir;
                }

                else if (cmb_kitaplık.Text != txt_kayitlikitaplik.Text)
                {
                    errorProvider5.Clear();
                    errorProvider19.Clear();
                    errorProvider12.SetError(this.cmb_kitaplık, Localization.suitable);
                    txt_error_5.Text = Localization.frm_sifir;
                }
            }
        }
        void cmb_kitapliktekrarüst()
        {
            if (cmb_kitaplık.Text == Localization.bosdeger)
            {
                errorProvider19.Clear();
                errorProvider12.Clear();
                errorProvider5.SetError(this.cmb_kitaplık, Localization.frmadmin_ktc);
                txt_error_5.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider19.Clear();
                errorProvider12.SetError(this.cmb_kitaplık, Localization.suitable);
                errorProvider5.Clear();
                txt_error_5.Text = Localization.frm_sifir;
            }
        }
        void cmbrafkatitekraralt()
        {
            if (cmb_rafkatı.Text == Localization.bosdeger)
            {
                errorProvider13.Clear();
                errorProvider20.Clear();
                errorProvider6.SetError(this.cmb_rafkatı, Localization.frmadmin_ktc);
                txt_error_6.Text = Localization.frm_bir;
            }
            else
            {
                if (cmb_rafkatı.Text == txt_kayitlirafkati.Text)
                {
                    errorProvider6.Clear();
                    errorProvider13.Clear();
                    errorProvider20.SetError(this.cmb_rafkatı, Localization.bsgfg);
                    txt_error_6.Text = Localization.frm_sifir;
                }

                else if (cmb_rafkatı.Text != txt_kayitlirafkati.Text)
                {
                    errorProvider6.Clear();
                    errorProvider20.Clear();
                    errorProvider13.SetError(this.cmb_rafkatı, Localization.suitable);
                    txt_error_6.Text = Localization.frm_sifir;
                }
            }
        }
        void cmbrafkatitekrarüst()
        {
            if (cmb_rafkatı.SelectedIndex.ToString() == Localization.bosdeger)
            {
                errorProvider20.Clear();
                errorProvider13.Clear();
                errorProvider6.SetError(this.cmb_rafkatı, Localization.frmadmin_ktc);
                txt_error_6.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider20.Clear();
                errorProvider13.SetError(this.cmb_rafkatı, Localization.suitable);
                errorProvider6.Clear();
                txt_error_6.Text = Localization.frm_sifir;
            }
        }
        void form()
        {
            rafkati();
            toolTip1.Active = true;
            label15.Text = Localization.frmkisi_label21_acik;
            Griddoldur();
            Xyz();
            siralama();

            DataGridView1.ClearSelection();
            DataGridView1.Columns[7].Visible = false;

            groupBox1.TabStop = false;
            groupBox2.TabStop = false;
            groupBox3.TabStop = false;

            btn_istemiyorum.Enabled = false;
            label29.Visible = false;
            label30.Text = Localization.label2_frmtüm_2;
            comboBox2.Visible = false;

            textBox8.Text = kontrol2;
            textBox9.Text = isimkontrol2;
            textBox10.Text = sifre2;

            renk();
            sayi();
            sayi_tüm();

            if(textBox8.Text == Localization.acikk)
            {
                error();
            }
            else if(textBox8.Text == Localization.bosdeger ||textBox8.Text == Localization.kapalii)
            {
                groupBox1.Enabled = false;
            }
        }
        void metin()
        {
            DataGridView1.Columns[3].DisplayIndex = 5;
            DataGridView1.Columns[4].DisplayIndex = 6;
            DataGridView1.Columns[5].DisplayIndex = 3;
            DataGridView1.Columns[8].DisplayIndex = 4;
            DataGridView1.Columns[6].DisplayIndex = 7;

            ikilik();

            DataGridView1.Columns[0].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[1].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[2].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[3].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[4].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[5].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[6].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[8].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);

            groupBox1.Text = Localization.frmekle_groupBox1;
            groupBox2.Text = Localization.frmekle_groupBox2;
            groupBox3.Text = Localization.frmekle_groupBox3;

            türkçeToolStripMenuItem.Text = Localization.frmekle_toolmenustrip1;
            englishToolStripMenuItem.Text = Localization.frmekle_toolmenustrip2;
            diğerOtherToolStripMenuItem.Text = Localization.frmekle_toolmenustrip3;
            dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.frmekle_toolstripmenu0;

            Regex rgx = new Regex("(.{50}\\s)");
            string WrappedMessage1 = rgx.Replace(Localization.frmkisi_button4_tooltiptext, "$1\n");
            string WrappedMessage3 = rgx.Replace(Localization.frmkisi_btnguncelle_tooltiptext, "$1\n");
            string WrappedMessage4 = rgx.Replace(Localization.frmkisi_btnsil_tooltiptext, "$1\n");


            toolTip1.SetToolTip(this.Btn_kaydet, Localization.frmkisi_btnekle_tooltiptext1);//
            toolTip1.SetToolTip(this.Btn_guncelle, WrappedMessage3);//
            toolTip1.SetToolTip(this.Btn_sil, WrappedMessage4);//
            toolTip1.SetToolTip(this.Btn_temizle, WrappedMessage1);//
            toolTip1.SetToolTip(this.Button2, Localization.btn_minimize);
            toolTip1.SetToolTip(this.Btn_anasayfa, Localization.btn_geri_kitapvekisi_tooltip);
            toolTip1.ToolTipTitle = Localization.Bilgilendirme;

            label1.Text = Localization.frmekle_label1;
            label2.Text = Localization.frmekle_label2;
            label3.Text = Localization.frmekle_label3;
            label6.Text = Localization.frmekle_label4;
            label7.Text = Localization.frmekle_label5;
            label4.Text = Localization.frmekle_label6;
            label19.Text = Localization.frmekle_label19;
            label9.Text = Localization.frmekle_label9;
            label11.Text = Localization.frmekle_label11;
            linkLabel3.Text = Localization.frmekle_linklabel3;
            linkLabel1.Text = Localization.frmekle_linklabel1;
            label14.Text = Localization.frmekle_label14;
            label99.Text = Localization.frmekle_label7;
            label18.Text = Localization.frmekle_label18;
            label13.Text = Localization.frmekle_label13;
            Label12.Text = Localization.frmekle_label12;
            label5.Text = Localization.frm_dil;
            label23.Text = Localization.frmekle_label23;
            label24.Text = Localization.frmekle_label24;
            label25.Text = Localization.frm_dil_2;
            label20.Text = Localization.frm_dil_label20;
            label26.Text = Localization.kitapsayisi;
            label28.Text = Localization.label28;

            Btn_kaydet.Text = Localization.frmekle_btnkaydet_text;
            Btn_guncelle.Text = Localization.frmekle_btnguncelle_text;
            Btn_sil.Text = Localization.frmekle_btnsil_text;
            Btn_temizle.Text = Localization.frmekle_btntemizle_text;
        }
        void engduzelt()
        {
            DataGridView1.Columns[0].Width = 997;
            DataGridView1.Columns[2].Width = 100;

            textBox1.Size = new Size(248, 30);
            textBox1.Location = new Point(300, 25);

            label1.Location = new Point(105,32);
            label2.Location = new Point(160,69);
            label3.Location = new Point(105,113);
            label4.Location = new Point(149,153);
            label5.Location = new Point(130,193);
            label6.Location = new Point(64,233);
            label7.Location = new Point(131, 272);
            linkLabel3.Location = new Point(1, 234);
            lbl_kitapsahibi.Location = new Point(280,50);
            label14.Location = new Point(6,26);
            label99.Location = new Point(6,108);
            label10.Location = new Point(320, 234);
            label18.Location = new Point(6,24);
            label13.Location = new Point(6,50);
            label99.Location = new Point(6, 232);
            comboBox1.Location = new Point(110, 63);
            comboBox3.Location = new Point(134, 109); //30
            label29.Location = new Point(310, 111);
            label25.Location = new Point(6, 190);
            flowLayoutPanel1.Location = new Point(116, 190); //50
            linkLabel1.Location = new Point(337, 193);
            comboBox2.Location = new Point(344, 109);
            //label19.Size = new Size(113,127);
            label22.Location = new Point(240, 123);
            label27.Location = new Point(170, 268);
            Btn_temizle.Font = new Font(Localization.frmanasayfa_font, 13);
            Btn_sil.Font = new Font(Localization.frmanasayfa_font, 14);
            dilSeçmekİçinTıklayınızToolStripMenuItem1.Text = Localization.dilSeçmekİçinTıklayınızToolStripMenuItem1;

            btn_istiyorum.Location = new Point(390,148);
            btn_istemiyorum.Location = new Point(450, 148);
        }
        void japanduzelt()
        {

        }
        void dt_dt1_void()
        {
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
                catch (ArgumentOutOfRangeException)
                {

                }
            }
            sayi();
        }
        void dt1_if()
        {
            if (label10.Text == Localization.frmekle_0)
            {
                if (txt_kitapara_dil.Text == string.Empty)
                {
                    MessageBox.Show(textBox1.Text.ToString() + Localization.frmekle_uyaristring_2, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(textBox1.Text.ToString() + Localization.frmekle_uyaristring, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        void dt_dt1_void2()
        {
            if (comboBox1.Text == string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//1
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "Kitabinİsmi Like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or KitabinYazari Like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//2
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//3
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or " +
                    "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//4
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or " +
                    "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//5
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%' or " +
                    "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//6
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%' or " +
                    "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//7
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%' or " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text != string.Empty && comboBox2.Text == string.Empty)//8
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%' or " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//9
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//10
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//11
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//12
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//13
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//14
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "KitabınBasımYılı Like '%" + comboBox3.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//15
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = "dil Like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text == string.Empty && comboBox2.Text != string.Empty)//16
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text != string.Empty && comboBox2.Text != string.Empty)//17
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "Kitabinİsmi Like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or KitabinYazari Like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text == string.Empty && comboBox2.Text != string.Empty)//18
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "dil Like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text == string.Empty && comboBox2.Text != string.Empty)//19
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text == string.Empty && comboBox2.Text != string.Empty)//20
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text != string.Empty && comboBox2.Text != string.Empty)//21
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text != string.Empty && comboBox2.Text != string.Empty)//22
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%' or " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text != string.Empty && comboBox3.Text != string.Empty && txt_kitapara_dil.Text != string.Empty && textBox1.Text != string.Empty && comboBox2.Text != string.Empty)//23
            {
                con.Open();
                string sql = "SELECT * FROM kitap Where KitabınBasımYılı BETWEEN @tar1 and @tar2";
                DataTable dt_cmb2 = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", comboBox3.Text.ToString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", comboBox2.Text.ToString());
                adp.Fill(dt_cmb2);
                con.Close();
                DataGridView1.DataSource = dt_cmb2;
                dt_dt1_void();
                dt1_if();

                DataView dv = dt_cmb2.AsDataView();
                dv.RowFilter = "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "Kitabinİsmi like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%' or " +
                    "KitabınRafınınİsmi Like '%" + comboBox1.Text + "%' and " +
                    "KitabinYazari like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' and " +
                    "dil like '%" + txt_kitapara_dil.Text + "%'";
                DataGridView1.DataSource = dv;
                dt_dt1_void();
                dt1_if();
            }
            else if (comboBox1.Text == string.Empty && comboBox3.Text == string.Empty && txt_kitapara_dil.Text == string.Empty && textBox1.Text == string.Empty && comboBox2.Text == string.Empty)//24
            {
                Griddoldur();
                dt_dt1_void();
                dt1_if();
            }
        }
        private void Frm3_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                form();
                metin();
                engduzelt();
                button11.Visible = true;
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                form();
                metin();
                japanduzelt();
                button11.Visible = true;
            }
            else
            {
                form();
                metin();
                button11.Visible = true;
            }
            cozunurluk();
        }
        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            if (TXT_İMDAT.Text == Localization.frm_bir)
            {
                guncelle();
            }
            else if (string.IsNullOrEmpty(txt_kitapismi.Text) == true || string.IsNullOrEmpty(cmb_kitaplık.Text) == true || string.IsNullOrEmpty(cmb_rafkatı.Text) == true || string.IsNullOrEmpty(txt_rafnumarasi.Text) == true || string.IsNullOrEmpty(txt_yazar.Text) == true || string.IsNullOrEmpty(textBox6.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_sıra.Text) == true)
            {
                MessageBox.Show(Localization.frmekle_guncelle_uyari, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_kitapismi.Text == txt_kayitlikitapismi.Text && txt_yazar.Text == txt_kayitliyazar.Text && txt_basımyili.Text == txt_kayitlibasimyili.Text && txt_rafnumarasi.Text == txt_kayitlinumara.Text && textBox6.Text == txt_kayitlidil.Text && cmb_kitaplık.Text == txt_kayitlikitaplik.Text && cmb_rafkatı.Text == txt_kayitlirafkati.Text)
            {
                MessageBox.Show(Localization.gfhfd, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sifreformu x = new sifreformu(this);
                x.textBox2.Text = textBox10.Text;
                x.txt_durum.Text = Localization.güncelle;
                x.ShowDialog();
            }
        }
        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            if (TXT_İMDAT.Text == Localization.frm_bir)
            {
                kaydet();
            }
            else if (string.IsNullOrEmpty(txt_kitapismi.Text) == true || string.IsNullOrEmpty(cmb_kitaplık.Text) == true || string.IsNullOrEmpty(cmb_rafkatı.Text) == true || string.IsNullOrEmpty(txt_rafnumarasi.Text) == true || string.IsNullOrEmpty(txt_yazar.Text) == true || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_sıra.Text) == false)
            {
                MessageBox.Show(Localization.frmekle_ekle_uyari, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sifreformu x = new sifreformu(this);
                x.textBox2.Text = textBox10.Text;
                x.txt_durum.Text = Localization.ekle;
                x.ShowDialog();
            }
        }
        private void Btn_sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == false)
            {
                MessageBox.Show(Localization.frmekle_sil_uyari3, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (TXT_İMDAT.Text == Localization.frm_bir)
                {
                    sil();
                }
                else if (string.IsNullOrEmpty(txt_kitapismi.Text) == true || string.IsNullOrEmpty(cmb_kitaplık.Text) == true || string.IsNullOrEmpty(cmb_rafkatı.Text) == true || string.IsNullOrEmpty(txt_rafnumarasi.Text) == true || string.IsNullOrEmpty(txt_yazar.Text) == true || string.IsNullOrEmpty(textBox6.Text) == true)
                {
                    MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_sıra.Text) == true)
                {
                    MessageBox.Show(Localization.frmekle_sil_uyari2, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    sifreformu x = new sifreformu(this);
                    x.textBox2.Text = textBox10.Text;
                    x.txt_durum.Text = Localization.sil;
                    x.ShowDialog();
                }
            }
        }
        private void Btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
            Xyz();
            siralama();
            rafkati();
            error();
        }
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_kitapismi.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kayitlikitapismi.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_yazar.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_kayitliyazar.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_basımyili.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_kayitlibasimyili.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmb_kitaplık.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kayitlikitaplik.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb_rafkatı.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_kayitlirafkati.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_rafnumarasi.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kayitlinumara.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_kayitlidil.Text = DataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_sıra.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox2.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            lbl_kitapsahibi.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            label22.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (string.IsNullOrEmpty(lbl_kitapsahibi.Text) == true)
            {
                lbl_kitapsahibi.Text = Localization.frmekle_sahipyok;
            }
            if (textBox6.Text == Localization.Türkçe)
            {
                dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.Türkçe;
            }
            else if (textBox6.Text == Localization.English)
            {
                dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.English;
            }
            else if (textBox6.Text == Localization.Other)
            {
                dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.Other;
            }

            errorProvider15.SetError(this.txt_kitapismi, Localization.hgfhgf);
            errorProvider16.SetError(this.txt_yazar, Localization.rewrer);
            errorProvider17.SetError(this.txt_basımyili, Localization.hrtrhyh);
            errorProvider18.SetError(this.txt_rafnumarasi, Localization.vfdbfd);
            errorProvider19.SetError(this.cmb_kitaplık, Localization.fdsd);
            errorProvider20.SetError(this.cmb_rafkatı, Localization.bsgfg);
            errorProvider21.SetError(this.menuStrip1, Localization.rtertte);

            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider9.Clear();
            errorProvider10.Clear();
            errorProvider11.Clear();
            errorProvider12.Clear();
            errorProvider13.Clear();
            errorProvider14.Clear();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formarama x = new Formarama();
            x.Show();
        }
        private void linkLabel3_Click(object sender, EventArgs e)
        {
            Formkitaplık x = new Formkitaplık();
            x.Show();
        }
        private void Btn_anasayfa_Click(object sender, EventArgs e)
        {
            if(textBox8.Text == Localization.acikk)
            {
                DialogResult x = MessageBox.Show(Localization.sdsgsd, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    DialogResult y = MessageBox.Show(Localization.fdads, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(y == DialogResult.Yes)
                    {
                        Frm2 frm = new Frm2
                        {
                            kontrolana = Localization.acikk
                        };
                        this.Hide();
                        frm.label9.Visible = true;
                        frm.label8.Visible = false;
                        frm.textBox1.Text = frm.kontrolana;
                        frm.pictureBox1.Visible = false;
                        frm.pictureBox2.Visible = true;
                        frm.label11.Visible = false;
                        frm.label12.Text = textBox9.Text;
                        frm.txt_alinansifre.Text = textBox10.Text;
                        frm.Show();
                    }
                    else
                    {
                        Frm2 frm = new Frm2
                        {
                            kontrolana = Localization.kapalii
                        };
                        this.Hide();
                        frm.label9.Visible = false;
                        frm.label8.Visible = true;
                        frm.textBox1.Text = frm.kontrolana;
                        frm.pictureBox1.Visible = true;
                        frm.pictureBox2.Visible = false;
                        frm.label11.Visible = true;
                        frm.label12.Text = string.Empty;
                        frm.Show();
                    }
                }
            }
            else if(textBox8.Text == Localization.kapalii || textBox8.Text == Localization.bosdeger)
            {
                DialogResult x = MessageBox.Show(Localization.sdsgsd, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    Frm2 frm = new Frm2
                    {
                        kontrolana = Localization.kapalii
                    };
                    this.Hide();
                    frm.label9.Visible = false;
                    frm.label8.Visible = true;
                    frm.textBox1.Text = frm.kontrolana;
                    frm.pictureBox1.Visible = true;
                    frm.pictureBox2.Visible = false;
                    frm.label11.Visible = true;
                    frm.label12.Text = string.Empty;
                    frm.Show();
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btn_kaydet_MouseEnter(object sender, EventArgs e)
        {
            Btn_kaydet.ForeColor = Color.Red;
        }
        private void Btn_kaydet_MouseLeave(object sender, EventArgs e)
        {
            Btn_kaydet.ForeColor = Color.Black;
        }
        private void Btn_guncelle_MouseEnter(object sender, EventArgs e)
        {
            Btn_guncelle.ForeColor = Color.Red;
        }
        private void Btn_guncelle_MouseLeave(object sender, EventArgs e)
        {
            Btn_guncelle.ForeColor = Color.Black;
        }
        private void btn_istiyorum_MouseEnter(object sender, EventArgs e)
        {
            btn_istiyorum.ForeColor = Color.Red;
        }
        private void btn_istiyorum_MouseLeave(object sender, EventArgs e)
        {
            btn_istiyorum.ForeColor = Color.Black;
        }
        private void btn_istemiyorum_MouseEnter(object sender, EventArgs e)
        {
            btn_istemiyorum.ForeColor = Color.Red;
        }
        private void btn_istemiyorum_MouseLeave(object sender, EventArgs e)
        {
            btn_istemiyorum.ForeColor = Color.Black;
        }
        private void Btn_sil_MouseEnter(object sender, EventArgs e)
        {
            Btn_sil.ForeColor = Color.Red;
        }
        private void Btn_sil_MouseLeave(object sender, EventArgs e)
        {
            Btn_sil.ForeColor = Color.Black;
        }
        private void Btn_temizle_MouseEnter(object sender, EventArgs e)
        {
            Btn_temizle.ForeColor = Color.Red;
        }
        private void Btn_temizle_MouseLeave(object sender, EventArgs e)
        {
            Btn_temizle.ForeColor = Color.Black;
        }
        private void txt_basımyili_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_rafnumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_basımyili_TextChanged(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                if (txt_basımyili.Text == Localization.bosdeger)
                {
                    label9.Visible = true;
                    errorProvider17.Clear();
                    errorProvider10.Clear();
                    errorProvider3.SetError(this.txt_basımyili, Localization.frmadmin_ktc);
                    txt_error_3.Text = Localization.frm_bir;
                }
                else
                {
                    label9.Visible = false;
                    errorProvider17.Clear();
                    errorProvider10.Clear();
                    errorProvider3.Clear();
                    txt_error_3.Text = Localization.frm_sifir;
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                basımyilitekraralt();
            }
        }
        private void txt_rafnumarasi_TextChanged(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                if (string.IsNullOrEmpty(txt_rafnumarasi.Text) == true)
                {
                    label11.Visible = true;
                    errorProvider11.Clear();
                    errorProvider18.Clear();
                    errorProvider4.SetError(this.txt_rafnumarasi, Localization.frmadmin_ktc);
                    txt_error_4.Text = Localization.frm_bir;
                }
                else
                {
                    label11.Visible = false;
                    errorProvider11.Clear();
                    errorProvider18.Clear();
                    errorProvider4.Clear();
                    txt_error_4.Text = Localization.frm_sifir;
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                rafnumarasialt();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            DataGridView1.ClearSelection();
            lbl_kitapsahibi.Text = string.Empty;
            label22.Text = string.Empty;
        }
        private void türkçeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox6.Text = Localization.Türkçe;
            dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.frmekle_toolmenustrip1;
        }
        private void englishToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox6.Text = Localization.English;
            dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.frmekle_toolmenustrip2;
        }
        private void diğerOtherToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox6.Text = Localization.Other;
            dilSeçmekİçinTıklayınızToolStripMenuItem.Text = Localization.frmekle_toolmenustrip3;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            DataGridView1.ClearSelection();
            lbl_kitapsahibi.Text = string.Empty;
            label22.Text = string.Empty;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            dt_dt1_void2();
            DataGridView1.ClearSelection();
            lbl_kitapsahibi.Text = string.Empty;
            label22.Text = string.Empty;
        }
        private void türkçeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_kitapara_dil.Text = Localization.Türkçe;
            dilSeçmekİçinTıklayınızToolStripMenuItem1.Text = Localization.frmekle_toolmenustrip1;
        }
        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_kitapara_dil.Text = Localization.English;
            dilSeçmekİçinTıklayınızToolStripMenuItem1.Text = Localization.frmekle_toolmenustrip2;
        }
        private void diğerOtherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt_kitapara_dil.Text = Localization.Other;
            dilSeçmekİçinTıklayınızToolStripMenuItem1.Text = Localization.frmekle_toolmenustrip3;
        }
        private void btn_istiyorum_Click(object sender, EventArgs e)
        {
            btn_istemiyorum.Enabled = true;
            label29.Visible = true;
            comboBox2.Visible = true;
            comboBox2.Enabled = true;
            btn_istiyorum.Enabled = false;
        }
        private void btn_istemiyorum_Click(object sender, EventArgs e)
        {
            btn_istemiyorum.Enabled = false;
            label29.Visible = false;
            comboBox2.Visible = false;
            comboBox2.Enabled = false;
            btn_istiyorum.Enabled = true;
            temizle();
            Xyz();
            siralama();
            rafkati();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            DataGridView1.ClearSelection();
            lbl_kitapsahibi.Text = Localization.bosdeger;
            label22.Text = Localization.bosdeger;
        }
        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label15.Text = Localization.frmkisi_label21_acik;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            toolTip1.Active = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label15.Text = Localization.frmkisi_label21_kapali;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            toolTip1.Active = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ikilik();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
        private void txt_kitapismi_TextChanged(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                if (txt_kitapismi.Text == Localization.bosdeger)
                {
                    errorProvider15.Clear();
                    errorProvider8.Clear();
                    errorProvider1.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);
                    txt_error_1.Text = Localization.frm_bir;
                }
                else
                {
                    errorProvider15.Clear();
                    errorProvider8.Clear();
                    errorProvider1.Clear();
                    txt_error_1.Text = Localization.frm_sifir;
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                kitapismitekraralt();
            }
        }
        private void txt_yazar_TextChanged(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                if (txt_yazar.Text == Localization.bosdeger)
                {
                    errorProvider16.Clear();
                    errorProvider9.Clear();
                    errorProvider2.SetError(this.txt_yazar, Localization.frmadmin_ktc);
                    txt_error_2.Text = Localization.frm_bir;
                }
                else
                {
                    errorProvider16.Clear();
                    errorProvider9.Clear();
                    errorProvider2.Clear();
                    txt_error_2.Text = Localization.frm_sifir;
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                yazarismitekraralt();
            }
        }
        private void dilSeçmekİçinTıklayınızToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            if(textBox12.Text == "1")
            {
                errorProvider7.Clear();
            }
            else if(txt_sıra.Text == Localization.bosdeger)
            {
                if (dilSeçmekİçinTıklayınızToolStripMenuItem.Text == Localization.dlscm || dilSeçmekİçinTıklayınızToolStripMenuItem.Text == Localization.gfdafd)
                {
                    errorProvider21.Clear();
                    errorProvider14.Clear();
                    errorProvider7.SetError(this.menuStrip1, Localization.frmadmin_ktc);
                    txt_error_7.Text = Localization.frm_bir;
                }
                else
                {
                    errorProvider21.Clear();
                    errorProvider14.SetError(this.menuStrip1, Localization.suitable);
                    errorProvider7.Clear();
                    txt_error_7.Text = Localization.frm_sifir;
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                if (dilSeçmekİçinTıklayınızToolStripMenuItem.Text == Localization.bosdeger)
                {
                    errorProvider14.Clear();
                    errorProvider21.Clear();
                    errorProvider7.SetError(this.menuStrip1, Localization.frmadmin_ktc);
                    txt_error_7.Text = Localization.frm_bir;
                }
                else
                {
                    if (dilSeçmekİçinTıklayınızToolStripMenuItem.Text == txt_kayitlidil.Text)
                    {
                        errorProvider7.Clear();
                        errorProvider14.Clear();
                        errorProvider21.SetError(this.menuStrip1, "Kayıtlı olan dil");
                        txt_error_7.Text = Localization.frm_sifir;
                    }

                    else if (dilSeçmekİçinTıklayınızToolStripMenuItem.Text != txt_kayitlidil.Text)
                    {
                        errorProvider7.Clear();
                        errorProvider21.Clear();
                        errorProvider14.SetError(this.menuStrip1, Localization.suitable);
                        txt_error_7.Text = Localization.frm_sifir;
                    }
                }
            }
        }
        private void cmb_rafkatı_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                cmbrafkatitekrarüst();
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                cmbrafkatitekraralt();
            }
        }
        private void cmb_kitaplık_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                cmb_kitapliktekrarüst();
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                cmbkitapliktekraralt();
            }
        }
        private void txt_kitapismi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    kitapismitekrarüst();
                }
            }
            else if (txt_sıra.Text != Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    kitapismitekraralt();
                }
            }
        }
        private void txt_yazar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    yazarismitekrarüst();
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    yazarismitekraralt();
                }
            }
        }
        private void txt_basımyili_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    basimyilitekrarüst();
                }
            }
            else if (txt_sıra.Text != Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    basımyilitekraralt();
                }
            }
        }
        private void txt_rafnumarasi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    rafnumarasiüst();
                }
            }
            else if (txt_sıra.Text != Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    rafnumarasialt();
                }
            }
        }
        private void cmb_kitaplık_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                if(e.KeyCode == Keys.Tab)
                {
                    cmb_kitapliktekrarüst();
                }
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    cmbkitapliktekraralt();
                }
            }
        }
        private void cmb_rafkatı_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    cmbrafkatitekrarüst();
                }
            }
            else if (txt_sıra.Text != Localization.bosdeger)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    cmbrafkatitekraralt();
                }
            }
        }
        private void txt_kitapismi_MouseLeave(object sender, EventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                kitapismitekrarüst();
            }
            else if (txt_sıra.Text != Localization.bosdeger)
            {
                kitapismitekraralt();
            }
        }
        private void txt_yazar_MouseLeave(object sender, EventArgs e)
        {
            if(txt_sıra.Text == Localization.bosdeger)
            {
                yazarismitekrarüst();
            }
            else if(txt_sıra.Text != Localization.bosdeger)
            {
                yazarismitekraralt();
            }
        }
        private void txt_basımyili_MouseLeave(object sender, EventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                basimyilitekrarüst();
            }
            else
            {
                basımyilitekraralt();
            }
        }
        private void txt_rafnumarasi_MouseLeave(object sender, EventArgs e)
        {
            if (txt_sıra.Text == Localization.bosdeger)
            {
                rafnumarasiüst();
            }
            else
            {
                rafnumarasialt();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void txt_kitapara_dil_TextChanged(object sender, EventArgs e)
        {
            dt_dt1_void2();
            DataGridView1.ClearSelection();
            lbl_kitapsahibi.Text = string.Empty;
            label22.Text = string.Empty;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_basımyili.Text) == true)
            {
                txt_basımyili.Text = Localization.frmekle_0;
                try
                {
                    kaydet();
                }
                catch (Exception)
                {
                    MessageBox.Show(Localization.frmkisi_cokbuyukdeger_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    kaydet();
                }
                catch (Exception)
                {
                    MessageBox.Show(Localization.frmkisi_cokbuyukdeger_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                guncelle();
            }
            catch (Exception)
            {
                MessageBox.Show(Localization.frmkisi_cokbuyukdeger_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                sil();
            }
            catch (Exception)
            {
                MessageBox.Show(Localization.frmkisi_cokbuyukdeger_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dergi x = new dergi();
            x.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_tarih.Text = DateTime.Now.ToString();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            TXT_İMDAT.Text = Localization.frm_bir;
            MessageBox.Show(Localization.fddsa, Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);
            groupBox1.Enabled = true;
            error();
        }
        private void Frm3_MouseMove(object sender, MouseEventArgs e)
        {
            textBox12.Text = "0";
        }
    }
}
