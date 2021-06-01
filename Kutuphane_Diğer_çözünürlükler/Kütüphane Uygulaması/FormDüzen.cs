using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class FormDüzen : Form
    {
        public FormDüzen()
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

            label13.Text = Localization.frmduzen_label13_Text;
            label14.Text = Localization.frmduzen_label14_Text;
            label15.Text = Localization.frmduzen_label15_Text;
            label16.Text = Localization.frmduzen_label16_Text;
            groupBox1.Text = Localization.frmduzen_groupboxtext;
            this.Text = Localization.frmduzen_formisim;
            label6.Text = Localization.frmduzen_label6_Text;
            label5.Text = Localization.frmduzen_label5_Text;
            label4.Text = Localization.frmduzen_label4_Text;
            label3.Text = Localization.frmduzen_label3_Text;
            label2.Text = Localization.frmduzen_label2_Text;
            label1.Text = Localization.frmduzen_label1_Text;
        }
        void engduzelt()
        {

        }
        void japanduzelt()
        {

        }
        private void FormDüzen_Load(object sender, EventArgs e)
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
        private void FormDüzen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
