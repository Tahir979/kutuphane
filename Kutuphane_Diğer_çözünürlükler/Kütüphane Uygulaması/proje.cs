using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class proje : Form
    {
        public proje()
        {
            InitializeComponent();
        }
        void yapildi_1()
        {
            label14.Visible = false;

            label15.Visible = true;
            label15.Location = new Point(1058, 53);

            label8.ForeColor = Color.FromArgb(0,192,0) ;
        }
        void yapilmadi_1()
        {
            label14.Visible = true;
            label14.Location = new Point(1058, 53);

            label15.Visible = false;

            label8.ForeColor = Color.Red;
        }
        void yapildi_2()
        {
            label25.Visible = false;

            label24.Visible = true;
            label24.Location = new Point(643, 108);

            label9.ForeColor = Color.FromArgb(0, 192, 0);
        }
        void yapilmadi_2()
        {
            label25.Visible = true;
            label25.Location = new Point(643, 108);

            label24.Visible = false;

            label9.ForeColor = Color.Red;
        }
        void yapildi_3()
        {
            label17.Visible = false;

            label16.Visible = true;
            label16.Location = new Point(201, 218);

            label10.ForeColor = Color.FromArgb(0, 192, 0);
        }
        void yapilmadi_3()
        {
            label17.Visible = true;
            label17.Location = new Point(201, 218);

            label16.Visible = false;

            label10.ForeColor = Color.Red;
        }
        void yapildi_4()
        {
            label23.Visible = false;

            label22.Visible = true;
            label22.Location = new Point(1181, 272);

            label11.ForeColor = Color.FromArgb(0,192,0);
        }
        void yapilmadi_4()
        {
            label23.Visible = true;
            label23.Location = new Point(1181, 272);

            label22.Visible = false;

            label11.ForeColor = Color.Red;
        }
        void yapildi_5()
        {
            label19.Visible = false;

            label18.Visible = true;
            label18.Location = new Point(664, 384);

            label12.ForeColor = Color.FromArgb(0,192,0);
        }
        void yapilmadi_5()
        {
            label19.Visible = true;
            label19.Location = new Point(664, 384);

            label18.Visible = false;

            label12.ForeColor = Color.Red;
        }
        void yapildi_6()
        {
            label21.Visible = false;

            label20.Visible = true;
            label20.Location = new Point(1134, 521);

            label13.ForeColor = Color.FromArgb(0,192,0);
        }
        void yapilmadi_6()
        {
            label21.Visible = true;
            label21.Location = new Point(1134, 521);

            label20.Visible = false;

            label13.ForeColor = Color.Red;
        }
        void yapildi_7()
        {
            label38.Visible = false;

            label39.Visible = true;
            label39.Location = new Point(975, 650);

            label1.ForeColor = Color.FromArgb(0,192,0);
        }
        void yapilmadi_7()
        {
            label38.Visible = true;
            label38.Location = new Point(975, 650);

            label39.Visible = false;

            label1.ForeColor = Color.Red;
        }
        void yapildi_8()
        {
            label40.Visible = false;

            label41.Visible = true;
            label41.Location = new Point(778, 932);

            label28.ForeColor = Color.FromArgb(0,192,0);
        }
        void yapilmadi_8()
        {
            label40.Visible = true;
            label40.Location = new Point(778, 932);

            label41.Visible = false;

            label28.ForeColor = Color.Red;
        }
        private void Yapıldı_1_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_1 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_1 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_1();
        }
        private void Yapılmadı_1_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_1 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_1 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_1();
        }
        private void Yapıldı_2_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_2 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_2 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_2();
        }
        private void Yapılmadı_2_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_2 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_2 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_2();
        }
        private void Yapıldı_3_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_3 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_3 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_3();
        }
        private void Yapılmadı_3_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_3 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_3 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_3();
        }
        private void Yapıldı_4_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_4 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_4 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_4();
        }
        private void Yapılmadı_4_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_4 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_4 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_4();
        }
        private void Yapıldı_5_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_5 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_5 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_5();
        }
        private void Yapılmadı_5_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_5 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_5 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_5();
        }
        private void Yapıldı_6_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_6 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_6 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_6();
        }
        private void Yapılmadı_6_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_6 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_6 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_6();
        }
        private void Yapıldı_7_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_7 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_7 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_7();
        }
        private void Yapılmadı_7_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_7 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_7 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_7();
        }
        private void Yapıldı_8_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_8 = Localization.yapıldı;
            Settings1.Default.Yapılmadı_8 = Localization.bosdeger;
            Settings1.Default.Save();
            yapildi_8();
        }
        private void Yapılmadı_8_Click(object sender, EventArgs e)
        {
            Settings1.Default.Yapıldı_8 = Localization.bosdeger;
            Settings1.Default.Yapılmadı_8 = Localization.yapılmadı;
            Settings1.Default.Save();
            yapilmadi_8();
        }
        private void proje_Load(object sender, EventArgs e)
        {
            if(Settings1.Default.Yapılmadı_1 == Localization.yapılmadı)
            {
                yapilmadi_1();
            }
            else
            {
                yapildi_1();
            }

            if (Settings1.Default.Yapılmadı_2 == Localization.yapılmadı)
            {
                yapilmadi_2();
            }
            else
            {
                yapildi_2();
            }

            if (Settings1.Default.Yapılmadı_3 == Localization.yapılmadı)
            {
                yapilmadi_3();
            }
            else
            {
                yapildi_3();
            }

            if (Settings1.Default.Yapılmadı_4 == Localization.yapılmadı)
            {
                yapilmadi_4();
            }
            else
            {
                yapildi_4();
            }

            if (Settings1.Default.Yapılmadı_5 == Localization.yapılmadı)
            {
                yapilmadi_5();
            }
            else
            {
                yapildi_5();
            }

            if (Settings1.Default.Yapılmadı_6 == Localization.yapılmadı)
            {
                yapilmadi_6();
            }
            else
            {
                yapildi_6();
            }

            if (Settings1.Default.Yapılmadı_7 == Localization.yapılmadı)
            {
                yapilmadi_7();
            }
            else
            {
                yapildi_7();
            }

            if (Settings1.Default.Yapılmadı_8 == Localization.yapılmadı)
            {
                yapilmadi_8();
            }
            else
            {
                yapildi_8();
            }
        }
        private void Yapıldı_1_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_1.ForeColor = Color.FromArgb(0,192,0);
        }
        private void Yapıldı_1_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_1.ForeColor = Color.Black;
        }
        private void Yapılmadı_1_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_1.ForeColor = Color.Red;
        }
        private void Yapılmadı_1_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_1.ForeColor = Color.Black;
        }
        private void Yapıldı_2_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_2.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_2_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_2.ForeColor = Color.Black;
        }
        private void Yapılmadı_2_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_2.ForeColor = Color.Red;
        }
        private void Yapılmadı_2_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_2.ForeColor = Color.Black;
        }
        private void Yapıldı_3_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_3.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_3_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_3.ForeColor = Color.Black;
        }
        private void Yapılmadı_3_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_3.ForeColor = Color.Red;
        }
        private void Yapılmadı_3_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_3.ForeColor = Color.Black;
        }
        private void Yapıldı_4_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_4.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_4_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_4.ForeColor = Color.Black;
        }
        private void Yapılmadı_4_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_4.ForeColor = Color.Red;
        }
        private void Yapılmadı_4_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_4.ForeColor = Color.Black;
        }
        private void Yapıldı_5_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_5.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_5_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_5.ForeColor = Color.Black;
        }
        private void Yapılmadı_5_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_5.ForeColor = Color.Red;
        }
        private void Yapılmadı_5_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_5.ForeColor = Color.Black;
        }
        private void Yapıldı_6_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_6.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_6_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_6.ForeColor = Color.Black;
        }
        private void Yapılmadı_6_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_6.ForeColor = Color.Red;
        }
        private void Yapılmadı_6_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_6.ForeColor = Color.Black;
        }
        private void Yapıldı_7_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_7.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_7_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_7.ForeColor = Color.Black;
        }
        private void Yapılmadı_7_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_7.ForeColor = Color.Red;
        }
        private void Yapılmadı_7_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_7.ForeColor = Color.Black;
        }
        private void Yapıldı_8_MouseEnter(object sender, EventArgs e)
        {
            Yapıldı_8.ForeColor = Color.FromArgb(0, 192, 0);
        }
        private void Yapıldı_8_MouseLeave(object sender, EventArgs e)
        {
            Yapıldı_8.ForeColor = Color.Black;
        }
        private void Yapılmadı_8_MouseEnter(object sender, EventArgs e)
        {
            Yapılmadı_8.ForeColor = Color.Red;
        }
        private void Yapılmadı_8_MouseLeave(object sender, EventArgs e)
        {
            Yapılmadı_8.ForeColor = Color.Black;
        }
    }
}
