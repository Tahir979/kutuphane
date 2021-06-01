using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Kütüphane_Uygulaması
{
    public partial class Frm7 : Form
    {
        int Move1;
        int Mouse_X;
        int Mouse_Y;

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbDataAdapter da2;
        OleDbDataAdapter da3;
        OleDbDataAdapter da4;
        OleDbCommand cmd;
        OleDbCommand cmd2;
        OleDbCommand cmd3;
        OleDbCommand cmd4;
        OleDbCommand cmd7;
        DataSet ds;
        DataSet ds2;
        DataSet ds3;
        DataSet ds4;
        readonly DateTime Tarih1 = DateTime.Today;

        public Frm7()
        {
            InitializeComponent();
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.MultiSelect = false;
        }
        public string kitapismi { get; set; }
        public string ad { get; set; }
        public string telno { get; set; }
        public string onay { get; set; }
        public string kitapid { get; set; }
        public string id { get; set; }
        public string tarih { get; set; }
        public string tel { get; set; }
        public string sembol { get; set; }
        public string y { get; set; }
        public string email { get; set; }
        public string kontrol { get; set; }
        public string isimkontrolkak { get; set; }
        public string alinansifre { get; set; }
        public string kayit1 { get; set; }
        public string kayit2 { get; set; }
        public string kayit3 { get; set; }
        public string kayit4 { get; set; }
        public string kayit5 { get; set; }
        public string kontrolid { get; set; }
        public string x { get; set; }
        void cozunurluk()
        {
            int bizimPcGenislik = 1920;
            int bizimPcYukseklik = 1080;

            float kullanilanPcGenislik = SystemInformation.PrimaryMonitorSize.Width;
            float kullanilanPcYukseklik = SystemInformation.PrimaryMonitorSize.Height;

            float genislikOrani = (bizimPcGenislik / kullanilanPcGenislik);
            float yukseklikOrani = (bizimPcYukseklik / kullanilanPcYukseklik);

            float forGen = this.Size.Width;
            float forYuk = this.Size.Height;


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

            foreach (Control nesne in Panel3.Controls)
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
                nesne.Location = new Point((int)(nesX / genislikOrani), (int)(nesY / yukseklikOrani));
                nesne.Size = new Size((int)(nesGen / genislikOrani), (int)(nesYuk / yukseklikOrani));
                fontBuyuk = (int)(nesFont / yukseklikOrani);
                if (fontBuyuk < 8) fontBuyuk = 8;
                nesne.Font = new Font(Localization.frmanasayfa_font, fontBuyuk);
                DataGridView1.Size = new Size((int)((kullanilanPcGenislik / x)), (int)(kullanilanPcYukseklik / y));
                DataGridView1.Location = new Point((int)((kullanilanPcGenislik / lx)), (int)(kullanilanPcYukseklik / ly));
            }
        } //panel1 çözünürlüğünü ayarla
        void Textboxtemizle()
        {
            txt_isim.Clear();
            Txt_telno.Clear();
            txt_kitapismi.Clear();
            textBox12.Clear();
            txt_tarih.Clear();
            txt_ID1.Clear();
            txt_control.Clear();
            Txt_ara.Clear();
            txt_selectedindex.Text = Localization.eksibir;
            cmb_sinif.Items.Clear();
            cmb_sinif.Items.Add(Localization.Hazırlık);
            cmb_sinif.Items.Add(Localization.a1Sınıf);
            cmb_sinif.Items.Add(Localization.a2Sınıf);
            cmb_sinif.Items.Add(Localization.a3Sınıf);
            cmb_sinif.Items.Add(Localization.a4Sınıf);
        }
        void kisiismitekraralt()
        {
            if(string.IsNullOrEmpty(txt_isim.Text) == true)
            {
                errorProvider9.Clear();
                errorProvider1.SetError(this.txt_isim, Localization.frmadmin_ktc);
                errorProvider5.Clear();
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                if(txt_isim.Text == txt_kayıtlıisim.Text)
                {
                    errorProvider1.Clear();
                    errorProvider5.Clear();
                    errorProvider9.SetError(this.txt_isim, Localization.yuj);
                    txt_error_1.Text = Localization.frm_sifir;
                }
                else
                {
                    errorProvider9.Clear();
                    errorProvider5.SetError(this.txt_isim, Localization.suitable);
                    errorProvider1.Clear();
                    txt_error_1.Text = Localization.frm_sifir;
                }
            }
        }
        void kisiismitekrarüst()
        {
            if(string.IsNullOrEmpty(txt_isim.Text) == true)
            {
                errorProvider9.Clear();
                errorProvider1.SetError(this.txt_isim, Localization.frmadmin_ktc);
                errorProvider5.Clear();
                txt_error_1.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider9.Clear();
                errorProvider5.SetError(this.txt_isim, Localization.suitable);
                errorProvider1.Clear();
                txt_error_1.Text = Localization.frm_sifir;
            }
        }
        void cmbsiniftrtekrarüst()
        {
            if (string.IsNullOrEmpty(cmb_sinif.Text) == true)
            {
                errorProvider10.Clear();
                errorProvider6.Clear();
                errorProvider2.SetError(this.cmb_sinif, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider10.Clear();
                errorProvider6.SetError(this.cmb_sinif, Localization.suitable);
                errorProvider2.Clear();
                txt_error_2.Text = Localization.frm_sifir;
            }
        }
        void cmbsiniftrtekraralt()
        {
            if(string.IsNullOrEmpty(cmb_sinif.Text) == true)
            {
                errorProvider10.Clear();
                errorProvider6.Clear();
                errorProvider2.SetError(this.cmb_sinif, Localization.frmadmin_ktc);
                txt_error_2.Text = Localization.frm_bir;
            }
            else
            {
                if(cmb_sinif.Text == txt_kayıtlısinif.Text)
                {
                    errorProvider10.SetError(this.cmb_sinif, Localization.ghyı);
                    errorProvider6.Clear();
                    errorProvider2.Clear();
                    txt_error_2.Text = Localization.frm_sifir;
                }
                else
                {
                    errorProvider10.Clear();
                    errorProvider6.SetError(this.cmb_sinif, Localization.suitable);
                    errorProvider2.Clear();
                    txt_error_2.Text = Localization.frm_sifir;
                }
            }
        }
        void txttelnotekrarüst()
        {
            if (Txt_telno.MaskCompleted == false)
            {
                errorProvider11.Clear();
                errorProvider7.Clear();
                errorProvider3.SetError(this.Txt_telno, Localization.gfddsa);
                txt_error_3.Text = Localization.frm_bir;
            }
            else if(Txt_telno.MaskCompleted == true)
            {
                errorProvider11.Clear();
                errorProvider3.Clear();
                errorProvider7.SetError(this.Txt_telno, Localization.suitable);
                txt_error_3.Text = Localization.frm_sifir;
            }
        }
        void txttelnotekraralt()
        {
            if(Txt_telno.MaskCompleted == false)
            {
                errorProvider11.Clear();
                errorProvider7.Clear();
                errorProvider3.SetError(this.Txt_telno, Localization.gfddsa);
                txt_error_3.Text = Localization.frm_bir;
            }
            else if(Txt_telno.MaskCompleted == true)
            {
                if(Txt_telno.Text == txt_kayitlitelno.Text)
                {
                    errorProvider7.Clear();
                    errorProvider3.Clear();
                    errorProvider11.SetError(this.Txt_telno, Localization.bnmök);
                    txt_error_3.Text = Localization.frm_sifir;
                }
                else
                {
                    errorProvider11.Clear();
                    errorProvider3.Clear();
                    errorProvider7.SetError(this.Txt_telno, Localization.suitable);
                    txt_error_3.Text = Localization.frm_sifir;
                }
            }
        }
        void txt12tekrarust()
        {
            if(string.IsNullOrEmpty(textBox12.Text) == true)
            {
                errorProvider12.Clear();
                errorProvider8.Clear();
                errorProvider4.SetError(this.textBox12, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider12.Clear();
                errorProvider8.SetError(this.textBox12, Localization.suitable);
                errorProvider4.Clear();
                txt_error_4.Text = Localization.frm_sifir;
            }
        }
        void txt12tekraralt()
        {
            if(string.IsNullOrEmpty(textBox12.Text) == true)
            {
                errorProvider12.Clear();
                errorProvider8.Clear();
                errorProvider4.SetError(this.textBox12, Localization.frmadmin_ktc);
                txt_error_4.Text = Localization.frm_bir;
            }
            else
            {
                if(textBox12.Text == txt_kayitliemail.Text)
                {
                    errorProvider8.Clear();
                    errorProvider12.SetError(this.textBox12, Localization.trfhtr);
                    errorProvider4.Clear();
                    txt_error_4.Text = Localization.frm_sifir;
                }
                else
                {
                    errorProvider12.Clear();
                    errorProvider8.SetError(this.textBox12, Localization.suitable);
                    errorProvider4.Clear();
                    txt_error_4.Text = Localization.frm_sifir;
                }
            }
        }
        void txtkitapismiust() 
        {
            if(string.IsNullOrEmpty(txt_kitapismi.Text) == true)
            {
                errorProvider13.Clear();
                errorProvider17.Clear();
                errorProvider18.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);
                txt_error_5.Text = Localization.frm_bir;
            }
            else
            {
                errorProvider13.Clear();
                errorProvider17.SetError(this.txt_kitapismi, Localization.suitable);
                errorProvider18.Clear();
                txt_error_5.Text = Localization.frm_sifir;
            }
        }
        void txtkitapismialt()
        {
            if(string.IsNullOrEmpty(txt_kitapismi.Text) == true)
            {
                errorProvider13.Clear();
                errorProvider17.Clear();
                errorProvider18.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);
                txt_error_5.Text = Localization.frm_bir;
            }
            else
            {
                if (txt_kitapismi.Text == txt_kayitlikitapismi.Text)
                {
                    errorProvider17.Clear();
                    errorProvider13.SetError(this.textBox12, Localization.hgfhgf);
                    errorProvider18.Clear();
                    txt_error_5.Text = Localization.frm_sifir;
                }
                else
                {
                    errorProvider13.Clear();
                    errorProvider17.SetError(this.txt_kitapismi, Localization.suitable);
                    errorProvider18.Clear();
                    txt_error_5.Text = Localization.frm_sifir;
                }
            }
        }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect *from kisiler Order By ID DESC", con);
            da2 = new OleDbDataAdapter("SElect *from tüm Order By ID DESC", con);
            da3 = new OleDbDataAdapter("SElect *from kitap Order By ID DESC", con);
            da4 = new OleDbDataAdapter("Select * from islemdokum", con);
            ds = new DataSet();
            ds2 = new DataSet();
            ds3 = new DataSet();
            ds4 = new DataSet();
            con.Open();
            da.Fill(ds, Localization.frmkisi_kisiler);
            da2.Fill(ds2, Localization.frmkisi_tüm);
            da3.Fill(ds3, Localization.frmkisi_kitap);
            da4.Fill(ds4, Localization.islemdokum);
            DataGridView1.DataSource = ds.Tables[Localization.frmkisi_kisiler];
            dataGridView2.DataSource = ds2.Tables[Localization.frmkisi_tüm];
            dt_kitap.DataSource = ds3.Tables[Localization.frmkisi_kitap];
            dataGridView3.DataSource = ds4.Tables[Localization.islemdokum];
            con.Close();
        }
        void Zaman()
        {
            txt_gun.Text = Tarih1.Day.ToString();
            txt_ay.Text = Tarih1.Month.ToString();
            txt_yil.Text = Tarih1.Year.ToString();

            string gunstring = txt_gun.Text;
            string aystring = txt_ay.Text;
            string yilstring = txt_yil.Text;
            int gun = Convert.ToInt32(gunstring);
            int ay = Convert.ToInt32(aystring);
            int yil = Convert.ToInt32(yilstring);

            if (gun < 10 && ay < 10)
            {
                txt_gunceltarih.Text = Localization.sifir + gun + Localization.nokta + Localization.sifir + ay + Localization.nokta + yil + Localization.bosluk + DateTime.Now.ToString(Localization.frmkisi_datetime_hhmm);
            }
            else if (gun < 10 && ay >= 10)
            {
                txt_gunceltarih.Text = Localization.sifir + gun + Localization.nokta + ay + Localization.nokta + yil + Localization.bosluk + DateTime.Now.ToString(Localization.frmkisi_datetime_hhmm);
            }
            else if (gun >= 10 && ay < 10)
            {
                txt_gunceltarih.Text = gun + Localization.nokta + Localization.sifir + ay + Localization.nokta + yil + Localization.bosluk + DateTime.Now.ToString(Localization.frmkisi_datetime_hhmm);
            }
            else
            {
                txt_gunceltarih.Text = gun + Localization.nokta + ay + Localization.nokta + yil + Localization.bosluk + DateTime.Now.ToString(Localization.frmkisi_datetime_hhmm);
            }
        }
        void ekle()
        {
            string vtyolu = Localization.oledbcon;
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string ekle = "insert into kisiler(İsim,Sinif,TelefonNumarasi,AldigiKitabinİsmi,AldigiGununTarihi,kitapid, mail) values (@İsim,@Sinif,@TelefonNumarasi,@AldigiKitabinİsmi,@AldigiGununTarihi,@kitapid,@mail)";
            string ekle2 = "insert into tüm(İsim, Sinif, AldigiKitabinİsmi, AldigiGununTarihi, TeslimTarihi, TelefonNumarasi, TeslimTarihieng, mail) values (@İsim,@Sinif,@AldigiKitabinİsmi,@AldigiGununTarihi,@TeslimTarihi,@TelefonNumarasi,@TeslimTarihieng,@mail)";
            string ekle3 = "update kitap set kisi=@kisi where ID=@ID";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            OleDbCommand komut2 = new OleDbCommand(ekle2, baglanti);
            OleDbCommand komut3 = new OleDbCommand(ekle3, baglanti);

            komut.Parameters.AddWithValue(Localization.frmkisi_isim, txt_isim.Text.ToString().Replace("'", "’"));
            komut.Parameters.AddWithValue(Localization.frmkisi_sinif, cmb_sinif.Text);
            komut.Parameters.AddWithValue(Localization.frmkisi_telno, Txt_telno.Text);
            komut.Parameters.AddWithValue(Localization.frmkisi_aldigikitabinismi, txt_kitapismi.Text);
            komut.Parameters.AddWithValue(Localization.frmkisi_aldigigununtarihi, txt_gunceltarih.Text);
            komut.Parameters.AddWithValue(Localization.frmkisi_kitapid, txt_gizlikitapid.Text);
            komut.Parameters.AddWithValue(Localization.mail, textBox12.Text);

            komut.ExecuteNonQuery();

            komut2.Parameters.AddWithValue(Localization.frmkisi_isim, txt_isim.Text.ToString().Replace("'", "’"));
            komut2.Parameters.AddWithValue(Localization.frmkisi_sinif, cmb_sinif.Text);
            komut2.Parameters.AddWithValue(Localization.frmkisi_aldigikitabinismi, txt_kitapismi.Text);
            komut2.Parameters.AddWithValue(Localization.frmkisi_aldigigununtarihi, txt_gunceltarih.Text);
            komut2.Parameters.AddWithValue(Localization.frmkisi_teslimtarihi, Localization.string_fe);
            komut2.Parameters.AddWithValue(Localization.frmkisi_telno, Txt_telno.Text);
            komut2.Parameters.AddWithValue(Localization.frmkisi_teslimtarihieng, Localization.string_fe2);
            komut2.Parameters.AddWithValue(Localization.mail, textBox12.Text);

            komut3.Parameters.AddWithValue(Localization.frmkisi_kisi, txt_isim.Text);
            komut3.Parameters.AddWithValue(Localization.frmkisi_ID, txt_gizlikitapid.Text);


            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();

            DataGridView1.ClearSelection();
            DataGridView1.Sort(DataGridView1.Columns[5], ListSortDirection.Ascending);
            Griddoldur();

            textBox11.Text = DataGridView1.Rows[0].Cells[5].Value.ToString();
            string cumle = textBox11.Text + " ID numaralı " + txt_isim.Text + " adlı yeni bir kişi eklendi.\n\nSınıfı: " + cmb_sinif.Text + "\nTelefon numarası: " + Txt_telno.Text + "\nMail adresi: " + textBox12.Text + "\nAldığı kitabın ismi: " + txt_kitapismi.Text;
            string ekle4 = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
            OleDbCommand komut4 = new OleDbCommand(ekle4, baglanti);

            komut4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
            komut4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
            komut4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(Localization.frmkisi_ekle_mb_part1, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(textBox11.Text + Localization.hgf,Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);

            Textboxtemizle();
            error();
        }
        void guncellebilgi()
        {
            if(txt_isim.Text != txt_kayıtlıisim.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = txt_ID1.Text + " ID numaralı kişinin isminde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayıtlıisim.Text + " \nYeni kayıt: " + txt_isim.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (cmb_sinif.Text != txt_kayıtlısinif.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = txt_ID1.Text + " ID numaralı kişinin sınıfında değişiklik yapılmıştır\n" + " \nEski kayıt: " + txt_kayıtlısinif.Text + " \nYeni kayıt: " + cmb_sinif.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if (Txt_telno.Text != txt_kayitlitelno.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = txt_ID1.Text + " ID numaralı kişinin telefon numarasında değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlitelno.Text + " \nYeni kayıt: " + Txt_telno.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if(textBox12.Text != txt_kayitliemail.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = txt_ID1.Text + " ID numaralı kişinin e-mailinde değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitliemail.Text + " \nYeni kayıt: " + textBox12.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
            if(txt_kitapismi.Text != txt_kayitlikitapismi.Text)
            {
                cmd4 = new OleDbCommand();
                con.Open();
                cmd4.Connection = con;

                string cumle = txt_ID1.Text + " ID numaralı kişinin aldığı kitapta bir değişiklik yapılmıştır.\n" + " \nEski kayıt: " + txt_kayitlikitapismi.Text + " \nYeni kayıt: " + txt_kitapismi.Text;

                cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
                cmd4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
                cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
                cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
                cmd4.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show(txt_ID1.Text + Localization.hfgd,Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void guncelle()
        {
            cmd = new OleDbCommand();
            cmd2 = new OleDbCommand();
            cmd3 = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd3.Connection = con;
            cmd.CommandText = "update kisiler set İsim=@İsim, Sinif=@Sinif, TelefonNumarasi=@TelefonNumarasi, AldigiKitabinİsmi=@AldigiKitabinİsmi, AldigiGununTarihi=@AldigiGununTarihi, kitapid=@kitapid, mail=@mail where ID=@ID";
            cmd2.CommandText = "update tüm set İsim=@İsim, Sinif=@Sinif, AldigiKitabinİsmi=@AldigiKitabinİsmi, AldigiGununTarihi=@AldigiGununTarihi, TelefonNumarasi=@TelefonNumarasi, mail=@mail where ID=@ID";
            cmd3.CommandText = "update kitap set kisi=@kisi where ID=@ID";

            if (string.IsNullOrEmpty(txt_gizlikitapid.Text) == true)
            {
                cmd.Parameters.AddWithValue(Localization.frmkisi_isim, txt_isim.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_sinif, cmb_sinif.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_telno, Txt_telno.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_aldigikitabinismi, txt_kitapismi.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_aldigigununtarihi, txt_tarih.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_kitapid, txt_kitabınidsi.Text);
                cmd.Parameters.AddWithValue(Localization.mail, textBox12.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_ID, txt_ID1.Text);

                cmd3.Parameters.AddWithValue(Localization.frmkisi_kisi, txt_isim.Text);
                cmd3.Parameters.AddWithValue(Localization.frmkisi_ID, txt_kitabınidsi.Text);
            }
            else
            {
                cmd7 = new OleDbCommand
                {
                    Connection = con,
                    CommandText = "update kitap set kisi=@kisi where ID=@ID"
                };

                cmd.Parameters.AddWithValue(Localization.frmkisi_isim, txt_isim.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_sinif, cmb_sinif.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_telno, Txt_telno.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_aldigikitabinismi, txt_kitapismi.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_aldigigununtarihi, txt_tarih.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_kitapid, txt_gizlikitapid.Text);
                cmd.Parameters.AddWithValue(Localization.mail, textBox12.Text);
                cmd.Parameters.AddWithValue(Localization.frmkisi_ID, txt_ID1.Text);

                cmd3.Parameters.AddWithValue(Localization.frmkisi_kisi, txt_isim.Text);
                cmd3.Parameters.AddWithValue(Localization.frmkisi_ID, txt_gizlikitapid.Text);

                cmd7.Parameters.AddWithValue(Localization.frmkisi_kisi, Localization.bosdeger);
                cmd7.Parameters.AddWithValue(Localization.frmkisi_ID, txt_kitabınidsi.Text);

                cmd7.ExecuteNonQuery();

                //burdaki olay şu: eğer kişi kitabını güncellemeyi düşünmüşse ya da yanlış kaydedilmişse kitap önce ilk bağlantı ile kişinin ismi aynen yeni kitaba aktarılacak 
                //peki ya değiştirdiği kitaba ne olacak, o önceki kitaptı dolayısıyla ıd si belli zaten onun ve o kitabın kimsede olmadığını belirtmek adına boş değer atayacağız
                //bu yüzden cmd7 diye bir şey tanımlamışım
            }

            cmd2.Parameters.AddWithValue(Localization.frmkisi_isim, txt_isim.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_sinif, cmb_sinif.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_aldigikitabinismi, txt_kitapismi.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_aldigigununtarihi, txt_tarih.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_telno, Txt_telno.Text);
            cmd2.Parameters.AddWithValue(Localization.mail, textBox12.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_ID, txt_ID1.Text);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            con.Close();
            DataGridView1.ClearSelection();
            DataGridView1.Sort(DataGridView1.Columns[5], ListSortDirection.Descending);
            Griddoldur();
            MessageBox.Show(Localization.frmkisi_guncelle_mb_part1, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
            guncellebilgi();
            Textboxtemizle();
            error();
        }
        void sil()
        {
            string cumle = textBox11.Text + " ID numaralı " + txt_isim.Text + " adlı bir kişi silindi.\n\nSınıfı: " + cmb_sinif.Text + "\nTelefon numarası: " + Txt_telno.Text + "\nMail adresi: " + textBox12.Text + "\nAldığı kitabın ismi: " + txt_kitapismi.Text;

            cmd = new OleDbCommand();
            cmd2 = new OleDbCommand();
            cmd3 = new OleDbCommand();
            cmd4 = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;
            cmd3.Connection = con;
            cmd4.Connection = con;
            cmd.CommandText = "delete from kisiler where ID=@ID";
            cmd2.CommandText = "update tüm set TeslimTarihi=@TeslimTarihi, TeslimTarihieng=@TeslimTarihieng where ID=@ID";
            cmd3.CommandText = "update kitap set kisi=@kisi where ID=@ID";
            cmd4.CommandText = "insert into islemdokum (kullaniciadi,yapilanislem,tarihvesaat) values (@kullaniciadi, @yapilanislem, @tarihvesaat)";
            cmd.Parameters.AddWithValue(Localization.frmkisi_ID, txt_ID1.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_teslimtarihi, txt_gunceltarih.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_teslimtarihieng, txt_gunceltarih.Text);
            cmd2.Parameters.AddWithValue(Localization.frmkisi_ID, txt_ID1.Text);
            cmd3.Parameters.AddWithValue(Localization.frmkisi_kisi, textBox10.Text);
            cmd3.Parameters.AddWithValue(Localization.frmkisi_ID, txt_kitabınidsi.Text);
            cmd4.Parameters.AddWithValue(Localization.dsgas, textBox14.Text);
            cmd4.Parameters.AddWithValue(Localization.gfdbsfd, cumle);
            cmd4.Parameters.AddWithValue(Localization.frgr, txt_tarih_data.Text);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();

            con.Close();
            DataGridView1.ClearSelection();
            Textboxtemizle();
            DataGridView1.Sort(DataGridView1.Columns[5], ListSortDirection.Descending);
            Griddoldur();
            error();

            MessageBox.Show(Localization.frmkisi_sil_mb_part1, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(textBox11.Text + Localization.dvs);
        }
        void frmkontrol()
        {
            txt_isim.Focus();
            txt_onayla.Text = kontrol;
            textBox14.Text = isimkontrolkak;
            txt_sifre_alinan.Text = alinansifre;
            txt_gizlikitapid.Text = kitapid;
            txt_kitapismi.Text = kitapismi;
            txt_isim.Text = ad;
            Txt_telno.Text = telno;
            txt_ID1.Text = id;
            txt_tarih.Text = tarih;
            label7.Text = tel;
            label8.Text = sembol;
            txt_kitabınidsi.Text = y;
            textBox12.Text = email;
            txt_kayıtlıisim.Text = kayit1;
            txt_kayıtlısinif.Text = kayit2;
            txt_kayitlitelno.Text = kayit3;
            txt_kayitliemail.Text = kayit4;
            txt_kayitlikitapismi.Text = kayit5;
            txt_ID1.Text = kontrolid;
            txt_selectedindex.Text = x;
            toolTip1.Active = true;
            Griddoldur();
            Zaman();
            DataGridView1.ClearSelection();
            DataGridView1.Columns[7].Visible = false;
            DataGridView1.Columns[6].Visible = false;
            DataGridView1.Columns[4].Visible = false;

            int h = -1;
            cmb_sinif.SelectedIndex = h;

            if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();
                errorProvider8.Clear();
                errorProvider16.Clear();

                if (txt_isim.Text == txt_kayıtlıisim.Text)
                {
                    errorProvider9.SetError(txt_isim,Localization.yuj);
                }
                else
                {
                    errorProvider5.SetError(txt_isim, Localization.suitable);
                }
                if(cmb_sinif.Text == txt_kayıtlısinif.Text)
                {
                    errorProvider10.SetError(cmb_sinif, Localization.ghyı);
                }
                else
                {
                    errorProvider6.SetError(cmb_sinif, Localization.suitable);
                }
                if (Txt_telno.Text == txt_kayitlitelno.Text)
                {
                    errorProvider11.SetError(Txt_telno, Localization.bnmök);
                }
                else
                {
                    errorProvider7.SetError(Txt_telno, Localization.suitable);
                }
                if (textBox12.Text == txt_kayitliemail.Text)
                {
                    errorProvider12.SetError(textBox12, Localization.trfhtr);
                }
                else
                {
                    errorProvider8.SetError(textBox12, Localization.suitable);
                }
                if (txt_kitapismi.Text == txt_kayitlikitapismi.Text)
                {
                    errorProvider13.SetError(txt_kitapismi, Localization.hgfhgf);
                }
                else
                {
                    errorProvider17.SetError(txt_kitapismi, Localization.suitable);
                }

                int y = Convert.ToInt32(txt_selectedindex.Text.ToString());
                cmb_sinif.SelectedIndex = y;
            }
            else if(string.IsNullOrEmpty(txt_isim.Text) == false)
            {
                errorProvider5.SetError(txt_isim, Localization.suitable);

                int y = Convert.ToInt32(txt_selectedindex.Text.ToString());
                cmb_sinif.SelectedIndex = y;
            }

            label12.Text = Localization.label2_frmtüm;

            if(txt_onayla.Text == Localization.kapalii || string.IsNullOrEmpty(txt_onayla.Text) == true)
            {
                panel1.Enabled = false;
            }
            else if(txt_onayla.Text == Localization.acikk)
            {
               panel1.Enabled = true;
                if(string.IsNullOrEmpty(txt_isim.Text) == true && string.IsNullOrEmpty(cmb_sinif.Text) == true && string.IsNullOrEmpty(Txt_telno.Text) == true && string.IsNullOrEmpty(textBox12.Text) == true)
                {
                    error();
                }
            }
        }
        void ikilik()
        {
            DataGridView1.Columns[0].HeaderText = Localization.frmkisi_load_isimsoyisim;
            DataGridView1.Columns[0].Width = 164;
            DataGridView1.Columns[1].HeaderText = Localization.frmkisi_load_sinif;
            DataGridView1.Columns[1].Width = 73;
            DataGridView1.Columns[2].Visible = false;
            DataGridView1.Columns[3].HeaderText = Localization.frmkisi_load_aldigikitabinismi;
            DataGridView1.Columns[3].Width = 642;
            DataGridView1.Columns[5].Width = 52;
        }
        void error()
        {
            errorProvider1.SetError(this.txt_isim, Localization.frmadmin_ktc);
            errorProvider2.SetError(this.cmb_sinif, Localization.frmadmin_ktc);
            errorProvider3.SetError(this.Txt_telno, Localization.frmadmin_ktc);
            errorProvider4.SetError(this.textBox12, Localization.fsdads);
            errorProvider18.SetError(this.txt_kitapismi, Localization.frmadmin_ktc);


            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider9.Clear();
            errorProvider10.Clear();
            errorProvider11.Clear();
            errorProvider12.Clear();
            errorProvider14.Clear();
            errorProvider15.Clear();
        }
        void metin()
        {
            ikilik();
            DataGridView1.DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 10);
            DataGridView1.Columns[0].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[1].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[2].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[3].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.Columns[5].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);

            btn_eklemek.Text = Localization.frmkisi_btnekle_text;
            Btn_sil.Text = Localization.frmkisi_btnsil_text;
            Btn_guncelle.Text = Localization.frmkisi_btnguncelle_text;
            button4.Text = Localization.button4_fadf;

            label1.Text = Localization.frmkisi_label1;
            label3.Text = Localization.frmkisi_label3;
            label4.Text = Localization.frmkisi_label4;
            label5.Text = Localization.frmkisi_label5;
            Label6.Text = Localization.frmkisi_label6;
            lbl_kitapsec.Text = Localization.frmkisi_linklabel2;
            label13.Text = Localization.frmkisi_label21_acik;
            label22.Text = Localization.frmkisi_label22;

            Regex rgx = new Regex("(.{50}\\s)");
            string WrappedMessage3 = rgx.Replace(Localization.frmkisi_btnguncelle_tooltiptext, "$1\n");
            string WrappedMessage4 = rgx.Replace(Localization.frmkisi_btnsil_tooltiptext, "$1\n");


            toolTip1.SetToolTip(this.btn_eklemek, Localization.frmkisi_btnekle_tooltiptext);
            toolTip1.SetToolTip(this.Btn_guncelle, WrappedMessage3);
            toolTip1.SetToolTip(this.Btn_sil, WrappedMessage4);
            toolTip1.SetToolTip(this.button4, Localization.frmkisi_button4_tooltiptext);
            toolTip1.SetToolTip(this.Button3, Localization.btn_minimize);
            toolTip1.SetToolTip(this.Btn_geri, Localization.btn_geri_kitapvekisi_tooltip);
            toolTip1.ToolTipTitle = Localization.Bilgilendirme;

            label1.Location = new Point(80, 15);
            label3.Location = new Point(172, 55);
            label4.Location = new Point(58, 93);
            label5.Location = new Point(125, 165);
            label22.Location = new Point(145, 340);

            float kullanilanPcGenislik = SystemInformation.PrimaryMonitorSize.Width;
            float kullanilanPcYukseklik = SystemInformation.PrimaryMonitorSize.Height;

            if (kullanilanPcGenislik == 1366 && kullanilanPcYukseklik == 768)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\kapama.png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\açma.png");

                pictureBox1.Location = new Point(50,-1);
                pictureBox2.Location = new Point(50,-1);

                Btn_geri.Location = new Point(-1,-1);
                Button3.Location = new Point(763, -1);
                label10.Location = new Point(-24, 34);
                cmb_sinif.Location = new Point(171, 45);

                label1.Location = new Point(89,20);
                label3.Location = new Point(138,49);
                label4.Location = new Point(77,75);
                label5.Location = new Point(114,103);
                label22.Location = new Point(124,234);

                DataGridView1.Columns[0].HeaderText = Localization.frmkisi_load_isimsoyisim;
                DataGridView1.Columns[0].Width = 164;
                DataGridView1.Columns[1].HeaderText = Localization.frmkisi_load_sinif;
                DataGridView1.Columns[1].Width = 35;
                DataGridView1.Columns[2].Visible = false;
                DataGridView1.Columns[3].HeaderText = Localization.frmkisi_load_aldigikitabinismi;
                DataGridView1.Columns[3].Width = 185;
                DataGridView1.Columns[5].Width = 52;
                DataGridView1.DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 10);
                DataGridView1.Columns[0].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[1].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[2].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[3].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[5].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);

                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        void engduzelt()
        {
            label1.Location = new Point(38, 17);
            label3.Location = new Point(163, 56);
            label4.Location = new Point(80, 95);
            label5.Location = new Point(110, 167);
            label22.Location = new Point(82, 342);
            Btn_guncelle.TextAlign = ContentAlignment.MiddleCenter;
            button4.Font = new Font(Localization.frmanasayfa_font, 12);

            float kullanilanPcGenislik = SystemInformation.PrimaryMonitorSize.Width;
            float kullanilanPcYukseklik = SystemInformation.PrimaryMonitorSize.Height;

            if (kullanilanPcGenislik == 1366 && kullanilanPcYukseklik == 768)
            {
                label1.Location = new Point(66, 20);
                label3.Location = new Point(134, 49);
                label4.Location = new Point(89, 75);
                label5.Location = new Point(104, 103);
                label22.Location = new Point(89, 234);
                lbl_kitapsec.Location = new Point(300, 104);

                DataGridView1.Columns[0].HeaderText = Localization.frmkisi_load_isimsoyisim;
                DataGridView1.Columns[0].Width = 164;
                DataGridView1.Columns[1].HeaderText = Localization.frmkisi_load_sinif;
                DataGridView1.Columns[1].Width = 25;
                DataGridView1.Columns[2].Visible = false;
                DataGridView1.Columns[3].HeaderText = Localization.frmkisi_load_aldigikitabinismi;
                DataGridView1.Columns[3].Width = 150;
                DataGridView1.Columns[5].Width = 52;
                DataGridView1.DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 10);
                DataGridView1.Columns[0].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[1].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[2].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[3].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.Columns[5].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
                DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);

                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        void japanduzelt()
        {

        }
        private void Frm7_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                cozunurluk();
                frmkontrol();
                metin();
                engduzelt();
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                cozunurluk();
                frmkontrol();
                metin();
                japanduzelt();
            }
            else
            {
                cozunurluk();
                frmkontrol();
                metin();
            }
        }
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_isim.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kayıtlıisim.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kayıtlısinif.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();

            if(txt_kayıtlısinif.Text == "Hazırlık")
            {
                cmb_sinif.Text = "Hazırlık";
            }
            if(txt_kayıtlısinif.Text == "1.Sınıf")
            {
                cmb_sinif.Text = "1.Sınıf";
            }
            if(txt_kayıtlısinif.Text == "2.Sınıf")
            {
                cmb_sinif.Text = "2.Sınıf";
            }
            if(txt_kayıtlısinif.Text == "3.Sınıf")
            {
                cmb_sinif.Text = "3.Sınıf";
            }
            if(txt_kayıtlısinif.Text == "4.Sınıf")
            {
                cmb_sinif.Text = "4.Sınıf";
            }

            Txt_telno.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_kayitlitelno.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox12.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_kayitliemail.Text = DataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_kitapismi.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kayitlikitapismi.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();

            txt_tarih.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_ID1.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kitabınidsi.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            textBox11.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();

            errorProvider9.SetError(txt_isim, Localization.yuj);
            errorProvider10.SetError(cmb_sinif, Localization.ghyı);
            errorProvider11.SetError(Txt_telno, Localization.bnmök);
            errorProvider12.SetError(textBox12, Localization.trfhtr);
            errorProvider13.SetError(txt_kitapismi, Localization.hgfhgf);

            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider16.Clear();
            errorProvider15.Clear();
            errorProvider17.Clear();
            errorProvider18.Clear();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btn_geri_Click(object sender, EventArgs e)
        {
            if (txt_onayla.Text == Localization.acikk)
            {
                DialogResult x = MessageBox.Show(Localization.sdsgsd, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                    DialogResult y = MessageBox.Show(Localization.fdads, Localization.Soru, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (y == DialogResult.Yes)
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
                        frm.label12.Text = textBox14.Text;
                        frm.txt_alinansifre.Text = txt_sifre_alinan.Text;
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
            else if (txt_onayla.Text == Localization.kapalii || string.IsNullOrEmpty(txt_onayla.Text) == true)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label13.Text = Localization.frmkisi_label21_acik;
            toolTip1.Active = true;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            label13.Text = Localization.frmkisi_label21_kapali;
            toolTip1.Active = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Zaman();
            txt_gun.Text = Tarih1.Day.ToString();
            txt_ay.Text = Tarih1.Month.ToString();
            string gun1 = txt_gun.Text;
            string ay1 = txt_ay.Text;    //tam tahmin ettigim gibi cuk diye oturdu bu buraya, artık textlerin başında hep "0" oluyor sürekli güncelledigi için
            int gun = Convert.ToInt32(gun1);
            if (gun < 10)
            {
                txt_gun.Text = Localization.sifir + gun;
            }
            int ay = Convert.ToInt32(ay1); //içinde bulundugumuz ay
            if (ay < 10)
            {
                txt_ay.Text = Localization.sifir + ay; //bunu timer 1 sürekli yineliyor ya ondan dolayı geri eski haline dönüyor, çünkü bu sadece girişte "05" şeklinde yazdırıyor sonra geri normal "5" haline dönüyor
            }
        }
        private void DataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            txt_tarih_data.Text = DateTime.Now.ToString();
        }
        private void Btn_sil_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) == true || string.IsNullOrEmpty(cmb_sinif.Text) == true || string.IsNullOrEmpty(Txt_telno.Text) == true || string.IsNullOrEmpty(txt_kitapismi.Text) == true || string.IsNullOrEmpty(textBox12.Text))
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_sil_yanlisislem_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sifreformu2 x = new sifreformu2(this);
                x.textBox2.Text = txt_sifre_alinan.Text;
                x.txt_durum.Text = Localization.sil;
                x.ShowDialog();
            }
        }
        private void btn_eklemek_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) == true || string.IsNullOrEmpty(cmb_sinif.Text) == true || string.IsNullOrEmpty(txt_kitapismi.Text) == true || string.IsNullOrEmpty(Txt_telno.Text) == true || string.IsNullOrEmpty(textBox12.Text))
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                MessageBox.Show(Localization.frmkisi_ekle_yanlisislem_mb_part1, Localization.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sifreformu2 x = new sifreformu2(this);
                x.textBox2.Text = txt_sifre_alinan.Text;
                x.txt_durum.Text = Localization.ekle;
                x.ShowDialog();
            }
        }
        private void Btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) == true || string.IsNullOrEmpty(cmb_sinif.Text) == true || string.IsNullOrEmpty(txt_kitapismi.Text) == true || string.IsNullOrEmpty(Txt_telno.Text) == true || string.IsNullOrEmpty(textBox12.Text) || txt_error_1.Text == "1" || txt_error_3.Text == "1" || txt_error_4.Text == "1")
            {
                MessageBox.Show(Localization.frmkisi_boskutucuk_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                MessageBox.Show(Localization.frmkisi_guncelle_yanlisislem_mb_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_isim.Text == txt_kayıtlıisim.Text && cmb_sinif.Text == txt_kayıtlısinif.Text && Txt_telno.Text == txt_kayitlitelno.Text && textBox12.Text == txt_kayitliemail.Text && txt_kitapismi.Text == txt_kayitlikitapismi.Text)
            {
                MessageBox.Show(Localization.gfhfd, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sifreformu2 x = new sifreformu2(this);
                x.textBox2.Text = txt_sifre_alinan.Text;
                x.txt_durum.Text = Localization.güncelle;
                x.ShowDialog();
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Textboxtemizle();
            error();
        }
        private void Txt_ara_TextChanged_1(object sender, EventArgs e)
        {
            Griddoldur();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "İsim Like '%" + Txt_ara.Text + "%'";
            DataGridView1.DataSource = dv;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ikilik();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ekle();
            }
            catch (Exception)
            {
                MessageBox.Show(Localization.frmkisi_cokbuyukdeger_part1, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
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
        private void button8_Click_1(object sender, EventArgs e)
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
        private void lbl_kitapsec_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txt_isim.Text == string.Empty || cmb_sinif.Text == string.Empty || Txt_telno.Text == string.Empty || textBox12.Text == string.Empty)
            {
                MessageBox.Show(Localization.hddhfdhd,Localization.Uyarı,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (txt_error_1.Text == Localization.frm_bir || txt_error_2.Text == Localization.frm_bir || txt_error_3.Text == Localization.frm_bir || txt_error_4.Text == Localization.frm_bir)
            {
                MessageBox.Show(Localization.hddfh,Localization.Uyarı,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                frmkitapara frm = new frmkitapara
                {
                    ad = txt_isim.Text,
                    telno = Txt_telno.Text,
                    id = txt_ID1.Text,
                    kitapid = txt_gizlikitapid.Text,
                    tarih = txt_tarih.Text,
                    x = txt_kitabınidsi.Text,
                    email_frmara = textBox12.Text,
                    kontrol5 = txt_onayla.Text,
                    xyz = textBox14.Text,
                    sifr = txt_sifre_alinan.Text,
                    kayit1_1 = txt_kayıtlıisim.Text,
                    kayit2_2 = txt_kayıtlısinif.Text,
                    kayit3_3 = txt_kayitlitelno.Text,
                    kayit4_4 = txt_kayitliemail.Text,
                    kayit5_5 = txt_kayitlikitapismi.Text,
                    kayit6_6 = txt_ID1.Text,
                    cmb = txt_selectedindex.Text
                };
                this.Hide();
                frm.ShowDialog();
            }
        }
        private void cmb_sinif_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txt_selectedindex.Text = cmb_sinif.SelectedIndex.ToString();
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                cmbsiniftrtekrarüst();
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                cmbsiniftrtekraralt();
            }
        }
        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(hotmail\\.)+com)$";
            string pattern2 = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@(gmail\\.)+com)$";
            if (Regex.IsMatch(textBox12.Text, pattern) || Regex.IsMatch(textBox12.Text, pattern2))
            {
                if (string.IsNullOrEmpty(txt_ID1.Text) == true)
                {
                    txt12tekrarust();
                }
                else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
                {
                    txt12tekraralt();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBox12.Text) == true)
                {
                    errorProvider12.Clear();
                    errorProvider8.Clear();
                    errorProvider4.SetError(this.textBox12, Localization.fsdads);
                    txt_error_4.Text = Localization.frm_bir;
                }
                else
                {
                    errorProvider12.Clear();
                    errorProvider8.Clear();
                    errorProvider4.SetError(this.textBox12, Localization.frmadmin_gty);
                    txt_error_4.Text = Localization.frm_bir;
                }
            }
        }
        private void txt_isim_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                if (string.IsNullOrEmpty(txt_isim.Text) == true)
                {
                    errorProvider9.Clear();
                    errorProvider1.SetError(this.txt_isim, Localization.frmadmin_ktc);
                    errorProvider5.Clear();
                    txt_error_1.Text = Localization.frm_bir;
                }
                else
                {
                    errorProvider9.Clear();
                    errorProvider5.Clear();
                    errorProvider1.Clear();
                    txt_error_1.Text = Localization.frm_sifir;
                }
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                kisiismitekraralt();
            }
        }
        private void Txt_telno_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                txttelnotekrarüst();
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                txttelnotekraralt();
            }
        }
        private void txt_isim_MouseLeave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                kisiismitekrarüst();
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                kisiismitekraralt();
            }
        }
        private void txt_isim_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    kisiismitekrarüst();
                }
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    kisiismitekraralt();
                }
            }
        }
        private void cmb_sinif_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    cmbsiniftrtekrarüst();
                }
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    cmbsiniftrtekraralt();
                }
            }
        }
        private void Txt_telno_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txttelnotekrarüst();
                }
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txttelnotekraralt();
                }
            }
        }
        private void textBox12_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txt12tekrarust();
                }
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txt12tekraralt();
                }
            }
        }
        private void textBox12_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void txt_isim_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void txt_kitapismi_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                txtkitapismiust();
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                txtkitapismialt();
            }
        }
        private void txt_kitapismi_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID1.Text) == true)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txtkitapismiust();
                }
            }
            else if (string.IsNullOrEmpty(txt_ID1.Text) == false)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    txtkitapismialt();
                }
            }
        }
        private void Panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Move1 = 0;
        }
        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move1 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Move1 = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void Label6_MouseUp(object sender, MouseEventArgs e)
        {
            Move1 = 0;
        }
        private void Label6_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move1 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }
        private void Label6_MouseDown(object sender, MouseEventArgs e)
        {
            Move1 = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void btn_eklemek_MouseEnter_1(object sender, EventArgs e)
        {
            btn_eklemek.ForeColor = Color.Red;
        }
        private void btn_eklemek_MouseLeave_1(object sender, EventArgs e)
        {
            btn_eklemek.ForeColor = Color.Black;
        }
        private void Btn_guncelle_MouseEnter_1(object sender, EventArgs e)
        {
            Btn_guncelle.ForeColor = Color.Red;
        }
        private void Btn_guncelle_MouseLeave_1(object sender, EventArgs e)
        {
            Btn_guncelle.ForeColor = Color.Black;
        }
        private void Btn_sil_MouseEnter_1(object sender, EventArgs e)
        {
            Btn_sil.ForeColor = Color.Red;
        }
        private void Btn_sil_MouseLeave_1(object sender, EventArgs e)
        {
            Btn_sil.ForeColor = Color.Black;
        }
        private void button4_MouseEnter_1(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }
        private void button4_MouseLeave_1(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
    }
}

