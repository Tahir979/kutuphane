using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class Formarama : Form
    {
        public Formarama()
        {
            InitializeComponent();
        }
        void metin()
        {
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_en);
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                Localization.Culture = new System.Globalization.CultureInfo(Localization.formload_jp);
            }

            label1.Text = Localization.frmarama_label1;
            label3.Text = Localization.frmarama_label3;
            label4.Text = Localization.frmarama_label4;
            label5.Text = Localization.frmarama_label5;
            label6.Text = Localization.frmarama_label6;
            label7.Text = Localization.frmarama_label7;
            this.Text = Localization.frmarama_text;
            groupBox1.Text = Localization.frmarama_groupbox;
        }
        void engduzelt()
        {

        }
        void japanduzelt()
        {

        }
        private void Formarama_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                metin();
                engduzelt();
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_japonca)
            {
                metin();
                japanduzelt();
            }
            else
            {
                metin();
            }
        }
        private void Formarama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
