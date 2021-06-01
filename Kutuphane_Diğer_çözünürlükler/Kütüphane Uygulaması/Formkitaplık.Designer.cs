namespace Kütüphane_Uygulaması
{
    partial class Formkitaplık
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formkitaplık));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kitaplıkismiekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_kitaplıkismiekle = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Image = global::Kütüphane_Uygulaması.Properties.Resources.eraser;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Location = new System.Drawing.Point(189, 72);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 48);
            this.btn_sil.TabIndex = 55;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btn_sil, "Hangi kitaplık ismini silmek istiyorsanız onun üstüne tıklayın ve ardından bu but" +
        "ona tıklayın, kitaplık ismi silinecektir.");
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            this.btn_sil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_sil_KeyPress);
            this.btn_sil.MouseEnter += new System.EventHandler(this.Btn_sil_MouseEnter);
            this.btn_sil.MouseLeave += new System.EventHandler(this.Btn_sil_MouseLeave);
            // 
            // btn_kitaplıkismiekle
            // 
            this.btn_kitaplıkismiekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_kitaplıkismiekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitaplıkismiekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitaplıkismiekle.Image = global::Kütüphane_Uygulaması.Properties.Resources.plus;
            this.btn_kitaplıkismiekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitaplıkismiekle.Location = new System.Drawing.Point(189, 14);
            this.btn_kitaplıkismiekle.Margin = new System.Windows.Forms.Padding(5);
            this.btn_kitaplıkismiekle.Name = "btn_kitaplıkismiekle";
            this.btn_kitaplıkismiekle.Size = new System.Drawing.Size(121, 48);
            this.btn_kitaplıkismiekle.TabIndex = 53;
            this.btn_kitaplıkismiekle.Text = "Ekle";
            this.btn_kitaplıkismiekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btn_kitaplıkismiekle, "Kitaplık ismi eklemek için ismi yan taraftaki kutucuğa yazınız ve bu butona basın" +
        "ız.");
            this.btn_kitaplıkismiekle.UseVisualStyleBackColor = false;
            this.btn_kitaplıkismiekle.Click += new System.EventHandler(this.btn_kitaplıkismiekle_Click);
            this.btn_kitaplıkismiekle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_kitaplıkismiekle_KeyPress);
            this.btn_kitaplıkismiekle.MouseEnter += new System.EventHandler(this.Btn_kitaplıkismiekle_MouseEnter);
            this.btn_kitaplıkismiekle.MouseLeave += new System.EventHandler(this.Btn_kitaplıkismiekle_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(58, 10);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.Visible = false;
            // 
            // cmb_kitaplıkismiekle
            // 
            this.cmb_kitaplıkismiekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_kitaplıkismiekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kitaplıkismiekle.FormattingEnabled = true;
            this.cmb_kitaplıkismiekle.Location = new System.Drawing.Point(14, 80);
            this.cmb_kitaplıkismiekle.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_kitaplıkismiekle.Name = "cmb_kitaplıkismiekle";
            this.cmb_kitaplıkismiekle.Size = new System.Drawing.Size(165, 33);
            this.cmb_kitaplıkismiekle.Sorted = true;
            this.cmb_kitaplıkismiekle.TabIndex = 57;
            this.cmb_kitaplıkismiekle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_kitaplıkismiekle_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(14, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 33);
            this.textBox1.TabIndex = 58;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bilgilendirme";
            // 
            // Formkitaplık
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 128);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_kitaplıkismiekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kitaplıkismiekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Formkitaplık";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplık Düzenle";
            this.Load += new System.EventHandler(this.Formkitaplık_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formkitaplık_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kitaplıkismiekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_kitaplıkismiekle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}