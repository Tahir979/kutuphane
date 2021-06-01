using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class nedenadmin : Form
    {
        public nedenadmin()
        {
            InitializeComponent();
        }
        private void nedenadmin_Load(object sender, EventArgs e)
        {
            label1.Text = Localization.msg;
            this.Text = Localization.msg2;
        }
    }
}
