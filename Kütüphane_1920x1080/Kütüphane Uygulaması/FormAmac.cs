using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class FormAmac : Form
    {
        public FormAmac()
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
            label1.Text = Localization.frmamac_label1_Text;
            this.Text = Localization.frmamac_formname;
        }
        void engduzelt()
        {

        }
        void japanduzelt()
        {

        }
        private void FormAmac_Load(object sender, EventArgs e)
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
        private void FormAmac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
