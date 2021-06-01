using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class dergi : Form
    {
        public dergi()
        {
            InitializeComponent();
        }
        private void dergi_Load(object sender, EventArgs e)
        {
            this.Text = Localization.msg3;
            label1.Text = Localization.msg4;
        }
    }
}
