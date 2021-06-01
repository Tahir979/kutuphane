using System;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class sifreformu : Form
    {
        Frm3 frm;
        public sifreformu(Frm3 _frm3)
        {
            InitializeComponent();
            frm = _frm3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == textBox2.Text)
            {
                MessageBox.Show(Localization.dgfaahfha, Localization.Bilgilendirme,MessageBoxButtons.OK,MessageBoxIcon.Information);
                if(txt_durum.Text == Localization.ekle)
                {
                    frm.button6.PerformClick();
                    this.Close();
                    
                }
                else if(txt_durum.Text == Localization.güncelle)
                {
                    frm.button9.PerformClick();
                    this.Close();
                }
                else if(txt_durum.Text == Localization.sil)
                {
                    frm.button10.PerformClick();
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
