using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class sifreformu2 : Form
    {
        Frm7 frm;
        public sifreformu2(Frm7 _frm7)
        {
            InitializeComponent();
            frm = _frm7;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show(Localization.dgfaahfha, Localization.Bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txt_durum.Text == Localization.ekle)
                {
                    frm.button2.PerformClick();
                    this.Close();

                }
                else if (txt_durum.Text == Localization.güncelle)
                {
                    frm.button7.PerformClick();
                    this.Close();
                }
                else if (txt_durum.Text == Localization.sil)
                {
                    frm.button8.PerformClick();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(Localization.dhsddh, Localization.Hata, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
