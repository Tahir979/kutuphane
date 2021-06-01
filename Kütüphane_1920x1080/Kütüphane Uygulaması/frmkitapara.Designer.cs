namespace Kütüphane_Uygulaması
{
    partial class frmkitapara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkitapara));
            this.txt_kitapyaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gizli = new System.Windows.Forms.TextBox();
            this.btn_kitapsec = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_onay = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_tarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btn_geridön = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kucult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.txt_gizlikisi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_xy = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_sifr = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txt_selected = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_kitapyaz
            // 
            this.txt_kitapyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapyaz.Location = new System.Drawing.Point(241, 461);
            this.txt_kitapyaz.Name = "txt_kitapyaz";
            this.txt_kitapyaz.Size = new System.Drawing.Size(237, 30);
            this.txt_kitapyaz.TabIndex = 1;
            this.txt_kitapyaz.TextChanged += new System.EventHandler(this.txt_kitapyaz_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen Kitabın ya da Yazarın İsmini Yazınız: ";
            // 
            // txt_gizli
            // 
            this.txt_gizli.Location = new System.Drawing.Point(1140, 325);
            this.txt_gizli.Name = "txt_gizli";
            this.txt_gizli.Size = new System.Drawing.Size(56, 22);
            this.txt_gizli.TabIndex = 3;
            this.txt_gizli.Visible = false;
            // 
            // btn_kitapsec
            // 
            this.btn_kitapsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapsec.Image = global::Kütüphane_Uygulaması.Properties.Resources.tick;
            this.btn_kitapsec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kitapsec.Location = new System.Drawing.Point(535, 451);
            this.btn_kitapsec.Name = "btn_kitapsec";
            this.btn_kitapsec.Size = new System.Drawing.Size(173, 49);
            this.btn_kitapsec.TabIndex = 5;
            this.btn_kitapsec.Text = "Kitabı Seç";
            this.btn_kitapsec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitapsec.UseVisualStyleBackColor = true;
            this.btn_kitapsec.Click += new System.EventHandler(this.btn_kitapsec_Click);
            this.btn_kitapsec.MouseEnter += new System.EventHandler(this.btn_kitapsec_MouseEnter);
            this.btn_kitapsec.MouseLeave += new System.EventHandler(this.btn_kitapsec_MouseLeave);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(925, 303);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(16, 22);
            this.txt_ad.TabIndex = 6;
            this.txt_ad.Visible = false;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(881, 303);
            this.txt_telno.Mask = "0(999) 000-0000";
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(16, 22);
            this.txt_telno.TabIndex = 9;
            this.txt_telno.Visible = false;
            // 
            // lbl_onay
            // 
            this.lbl_onay.Location = new System.Drawing.Point(947, 309);
            this.lbl_onay.Name = "lbl_onay";
            this.lbl_onay.Size = new System.Drawing.Size(25, 11);
            this.lbl_onay.TabIndex = 10;
            this.lbl_onay.Text = "label2";
            this.lbl_onay.Visible = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeight = 29;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Location = new System.Drawing.Point(-1, 56);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 30;
            this.DataGridView1.Size = new System.Drawing.Size(1424, 376);
            this.DataGridView1.TabIndex = 11;
            this.DataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(916, 210);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(56, 22);
            this.txt_id.TabIndex = 13;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(1008, 306);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(29, 22);
            this.txt_tarih.TabIndex = 14;
            this.txt_tarih.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(714, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Doğru kitabı seçtiğinizden emin olmak için tüm bilgilerin doğru olmasına özen gös" +
    "teriniz";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(273, 502);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(176, 18);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Kitap Arama Nasıl Yapılır?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btn_geridön
            // 
            this.btn_geridön.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geridön.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geridön.ForeColor = System.Drawing.Color.White;
            this.btn_geridön.Image = global::Kütüphane_Uygulaması.Properties.Resources.back;
            this.btn_geridön.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_geridön.Location = new System.Drawing.Point(1371, -1);
            this.btn_geridön.Name = "btn_geridön";
            this.btn_geridön.Size = new System.Drawing.Size(52, 52);
            this.btn_geridön.TabIndex = 17;
            this.btn_geridön.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_geridön.UseVisualStyleBackColor = true;
            this.btn_geridön.Click += new System.EventHandler(this.btn_geridön_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_kucult);
            this.panel1.Controls.Add(this.btn_geridön);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 50);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_kucult
            // 
            this.btn_kucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kucult.ForeColor = System.Drawing.Color.Black;
            this.btn_kucult.Image = global::Kütüphane_Uygulaması.Properties.Resources.remove_circular_button;
            this.btn_kucult.Location = new System.Drawing.Point(1319, -1);
            this.btn_kucult.Name = "btn_kucult";
            this.btn_kucult.Size = new System.Drawing.Size(52, 52);
            this.btn_kucult.TabIndex = 19;
            this.btn_kucult.UseVisualStyleBackColor = true;
            this.btn_kucult.Click += new System.EventHandler(this.btn_kucult_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1422, 50);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kitap Seçme Menüsü";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label3_MouseUp);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(715, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(707, 43);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kırmızı renkli kitaplar şuan başka bir arkadaşımızda, rengi olmayan kitaplar kütü" +
    "phanemizde demektir.";
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(1238, 325);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(52, 22);
            this.txt_kitapid.TabIndex = 20;
            this.txt_kitapid.Visible = false;
            // 
            // txt_gizlikisi
            // 
            this.txt_gizlikisi.Location = new System.Drawing.Point(959, 309);
            this.txt_gizlikisi.Name = "txt_gizlikisi";
            this.txt_gizlikisi.Size = new System.Drawing.Size(43, 22);
            this.txt_gizlikisi.TabIndex = 21;
            this.txt_gizlikisi.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1008, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 22);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // txt_xy
            // 
            this.txt_xy.Location = new System.Drawing.Point(1099, 309);
            this.txt_xy.Name = "txt_xy";
            this.txt_xy.Size = new System.Drawing.Size(35, 22);
            this.txt_xy.TabIndex = 23;
            this.txt_xy.Visible = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(840, 355);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 25;
            this.txt_email.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(936, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 374);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 27;
            // 
            // txt_sifr
            // 
            this.txt_sifr.Location = new System.Drawing.Point(743, 386);
            this.txt_sifr.Name = "txt_sifr";
            this.txt_sifr.Size = new System.Drawing.Size(100, 22);
            this.txt_sifr.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 311);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 31;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(135, 339);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 32;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(135, 367);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 33;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(135, 396);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 34;
            // 
            // txt_selected
            // 
            this.txt_selected.Location = new System.Drawing.Point(819, 306);
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.Size = new System.Drawing.Size(100, 22);
            this.txt_selected.TabIndex = 35;
            // 
            // frmkitapara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1422, 527);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_selected);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_sifr);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_xy);
            this.Controls.Add(this.txt_gizli);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_gizlikisi);
            this.Controls.Add(this.txt_kitapid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btn_kitapsec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kitapyaz);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.lbl_onay);
            this.Controls.Add(this.txt_telno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmkitapara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Arama";
            this.Load += new System.EventHandler(this.frmkitapara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_kitapyaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gizli;
        private System.Windows.Forms.Button btn_kitapsec;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox txt_telno;
        private System.Windows.Forms.Label lbl_onay;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btn_geridön;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kucult;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.TextBox txt_gizlikisi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_xy;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_sifr;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.TextBox txt_selected;
    }
}