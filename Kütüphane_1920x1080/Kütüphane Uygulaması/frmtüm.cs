using System;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class frmtüm : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public frmtüm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        void Griddoldur()
        {
            con = new OleDbConnection(Localization.oledbcon);
            da = new OleDbDataAdapter("SElect *from tüm Order By ID DESC", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, Localization.frmkisi_tüm);
            dataGridView1.DataSource = ds.Tables[Localization.frmkisi_tüm];
            con.Close();
        }
        void ikilik()
        {
            if (Settings1.Default.dil == Localization.formload_toolstripmenu_ingilizce)
            {
                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns[1].Width = 75;
                dataGridView1.Columns[2].Width = 382;
                dataGridView1.Columns[3].Width = 165;
                dataGridView1.Columns[4].Width = 210;
                dataGridView1.Columns[5].Width = 155;
                dataGridView1.Columns[6].Width = 50;
                dataGridView1.Columns[7].Width = 210;
                dataGridView1.Columns[8].Width = 200;

                dataGridView1.Columns[6].DisplayIndex = 7;

                dataGridView1.Columns[4].Visible = false;
            }
            else if (Settings1.Default.dil == Localization.formload_toolstripmenu_turkce)
            {
                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns[1].Width = 75;
                dataGridView1.Columns[2].Width = 382;
                dataGridView1.Columns[3].Width = 165;
                dataGridView1.Columns[4].Width = 210;
                dataGridView1.Columns[5].Width = 155;
                dataGridView1.Columns[6].Width = 50;
                dataGridView1.Columns[7].Width = 210;
                dataGridView1.Columns[8].Width = 200;

                dataGridView1.Columns[6].DisplayIndex = 7;

                dataGridView1.Columns[7].Visible = false;
            }
        }
        void metin()
        {
            dataGridView1.Columns[0].HeaderText = Localization.frmtüm_headertextsifir;
            dataGridView1.Columns[1].HeaderText = Localization.frmtüm_headertextbir;
            dataGridView1.Columns[2].HeaderText = Localization.frmtüm_headertextiki;
            dataGridView1.Columns[3].HeaderText = Localization.frmtüm_headertextuc;
            dataGridView1.Columns[4].HeaderText = Localization.frmtüm_headertextdort;
            dataGridView1.Columns[5].HeaderText = Localization.frmtüm_headertextbes;
            dataGridView1.Columns[7].HeaderText = Localization.frmtüm_headertextdort;
            dataGridView1.Columns[8].HeaderText = Localization.qqqqqq;

            label1.Text = Localization.frmtüm_label1;
            this.Text = Localization.frmtüm_formisim;

            dataGridView1.DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 10);
            dataGridView1.Columns[0].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[4].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[5].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[6].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[7].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.Columns[8].DefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(Localization.frmkisi_tahoma, 11);

            label2.Text = Localization.label2_frmtüm;
            button1.Text = Localization.btn_frmtüm;
            ikilik();
        }
        void engduzelt()
        {
            textBox1.Location = new Point(230, 450);
            textBox1.Size = new Size(190,22);

            button1.Location = new Point(1310, 431);
            button1.Size = new Size(200, 70);
        }
        void japanduzelt()
        {

        }
        private void frmtüm_Load(object sender, EventArgs e)
        {
            Griddoldur();
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Griddoldur();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "İsim Like '%" + textBox1.Text.ToString().Replace("'", "’") + "%' or AldigiKitabinİsmi Like '%" + textBox1.Text.ToString().Replace("'", "’") + "%'";
            dataGridView1.DataSource = dv;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ikilik();
        }
        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
