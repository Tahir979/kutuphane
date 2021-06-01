using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class FormKural : Form
    {
        public FormKural()
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
            label5.Text = Localization.frmkural_label5;
            label6.Text = Localization.frmkural_label6;
            this.Text = Localization.frmkural_formtext;
            groupBox1.Text = Localization.frmkural_groupbox_Text;
        }
        void engduzelt()
        {

        }
        void japanduzelt()
        {

        }
        private void FormKural_Load(object sender, EventArgs e)
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
        private void FormKural_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
