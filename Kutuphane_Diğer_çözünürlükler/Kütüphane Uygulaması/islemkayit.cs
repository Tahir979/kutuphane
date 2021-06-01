using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kütüphane_Uygulaması
{
    public partial class islemkayit : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public islemkayit()
        {
            InitializeComponent();
        }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("Select * from islemdokum Order BY tarihvesaat DESC", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.islemdokum);
            dataGridView1.DataSource = ds.Tables[Localization.islemdokum];
            con.Close();
        }
        private void islemkayit_Load(object sender, EventArgs e)
        {
            Griddoldur();

            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);

            dataGridView1.Columns[0].HeaderText = Localization.ooooo;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = Localization.aaaaa;
            dataGridView1.Columns[1].Width = 857;
            dataGridView1.Columns[2].HeaderText = Localization.ggggg;
            dataGridView1.Columns[2].Width = 185;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "kullaniciadi Like '%" + textBox1.Text.ToString() + "%' or yapilanislem Like '%" + textBox1.Text.ToString() + "%' or tarihvesaat Like '%" + textBox1.Text.ToString() + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
