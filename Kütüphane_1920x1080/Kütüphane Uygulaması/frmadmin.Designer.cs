namespace Kütüphane_Uygulaması
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.btn_adminol = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_gecicisifre = new System.Windows.Forms.TextBox();
            this.txt_email_2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_adsoyad_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kod = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_kontrol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_error_1 = new System.Windows.Forms.TextBox();
            this.txt_error_2 = new System.Windows.Forms.TextBox();
            this.txt_error_3 = new System.Windows.Forms.TextBox();
            this.txt_error_4 = new System.Windows.Forms.TextBox();
            this.txt_error_5 = new System.Windows.Forms.TextBox();
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adminol
            // 
            this.btn_adminol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminol.Location = new System.Drawing.Point(167, 242);
            this.btn_adminol.Name = "btn_adminol";
            this.btn_adminol.Size = new System.Drawing.Size(164, 66);
            this.btn_adminol.TabIndex = 5;
            this.btn_adminol.Text = "Adminlik yetkisi almak istiyorum";
            this.btn_adminol.UseVisualStyleBackColor = true;
            this.btn_adminol.Click += new System.EventHandler(this.btn_adminol_Click);
            this.btn_adminol.MouseEnter += new System.EventHandler(this.btn_adminol_MouseEnter);
            this.btn_adminol.MouseLeave += new System.EventHandler(this.btn_adminol_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(68, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Password:";
            // 
            // txt_gecicisifre
            // 
            this.txt_gecicisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gecicisifre.Location = new System.Drawing.Point(175, 94);
            this.txt_gecicisifre.Name = "txt_gecicisifre";
            this.txt_gecicisifre.PasswordChar = '*';
            this.txt_gecicisifre.Size = new System.Drawing.Size(274, 30);
            this.txt_gecicisifre.TabIndex = 1;
            this.txt_gecicisifre.TextChanged += new System.EventHandler(this.txt_gecicisifre_TextChanged);
            this.txt_gecicisifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_gecicisifre_KeyDown);
            this.txt_gecicisifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gecicisifre_KeyPress);
            this.txt_gecicisifre.MouseLeave += new System.EventHandler(this.txt_gecicisifre_MouseLeave);
            this.txt_gecicisifre.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_gecicisifre_PreviewKeyDown);
            // 
            // txt_email_2
            // 
            this.txt_email_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email_2.Location = new System.Drawing.Point(175, 130);
            this.txt_email_2.Name = "txt_email_2";
            this.txt_email_2.Size = new System.Drawing.Size(274, 30);
            this.txt_email_2.TabIndex = 2;
            this.txt_email_2.TextChanged += new System.EventHandler(this.txt_email_2_TextChanged);
            this.txt_email_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_2_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(99, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "E-mail:";
            // 
            // txt_adsoyad_2
            // 
            this.txt_adsoyad_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adsoyad_2.Location = new System.Drawing.Point(175, 58);
            this.txt_adsoyad_2.Name = "txt_adsoyad_2";
            this.txt_adsoyad_2.Size = new System.Drawing.Size(274, 30);
            this.txt_adsoyad_2.TabIndex = 0;
            this.txt_adsoyad_2.TextChanged += new System.EventHandler(this.txt_adsoyad_2_TextChanged);
            this.txt_adsoyad_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_adsoyad_2_KeyDown);
            this.txt_adsoyad_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_adsoyad_2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(64, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username:";
            // 
            // txt_kod
            // 
            this.txt_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kod.Location = new System.Drawing.Point(70, 260);
            this.txt_kod.Name = "txt_kod";
            this.txt_kod.Size = new System.Drawing.Size(58, 30);
            this.txt_kod.TabIndex = 25;
            this.txt_kod.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Kütüphane_Uygulaması.Properties.Resources.back_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(441, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = " ";
            this.toolTip1.SetToolTip(this.button1, "Burayı kapatıp Anamenüye geri dön");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 46);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adminlik Yetkisi Alma Menüsü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "________________________________________________________________________________";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(58, 36);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.Visible = false;
            // 
            // txt_kontrol
            // 
            this.txt_kontrol.Location = new System.Drawing.Point(6, 164);
            this.txt_kontrol.Name = "txt_kontrol";
            this.txt_kontrol.Size = new System.Drawing.Size(58, 22);
            this.txt_kontrol.TabIndex = 31;
            this.txt_kontrol.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Surname:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(175, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(175, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.textBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox2_PreviewKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "1. Özel karakterler(*, -, \", | gibi) kullanılamayacaktır.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(426, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "2. Adminlik yetkisi alırken internetin bağlı olmasına özen gösteriniz.";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(2, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(480, 39);
            this.label8.TabIndex = 42;
            this.label8.Text = "3. Mailinizi seçerken \"gmail\" ya da \"hotmail\" uzantılı olmasına dikkat ediniz, öt" +
    "eki uzantılar program tarafından kabul edilmeyecektir.";
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // errorProvider4
            // 
            this.errorProvider4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider4.Icon")));
            // 
            // errorProvider5
            // 
            this.errorProvider5.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider5.Icon")));
            // 
            // txt_error_1
            // 
            this.txt_error_1.Location = new System.Drawing.Point(455, 167);
            this.txt_error_1.Name = "txt_error_1";
            this.txt_error_1.Size = new System.Drawing.Size(31, 22);
            this.txt_error_1.TabIndex = 43;
            // 
            // txt_error_2
            // 
            this.txt_error_2.Location = new System.Drawing.Point(455, 203);
            this.txt_error_2.Name = "txt_error_2";
            this.txt_error_2.Size = new System.Drawing.Size(27, 22);
            this.txt_error_2.TabIndex = 44;
            this.txt_error_2.Visible = false;
            // 
            // txt_error_3
            // 
            this.txt_error_3.Location = new System.Drawing.Point(455, 130);
            this.txt_error_3.Name = "txt_error_3";
            this.txt_error_3.Size = new System.Drawing.Size(27, 22);
            this.txt_error_3.TabIndex = 45;
            this.txt_error_3.Visible = false;
            // 
            // txt_error_4
            // 
            this.txt_error_4.Location = new System.Drawing.Point(455, 94);
            this.txt_error_4.Name = "txt_error_4";
            this.txt_error_4.Size = new System.Drawing.Size(27, 22);
            this.txt_error_4.TabIndex = 46;
            this.txt_error_4.Visible = false;
            // 
            // txt_error_5
            // 
            this.txt_error_5.Location = new System.Drawing.Point(455, 58);
            this.txt_error_5.Name = "txt_error_5";
            this.txt_error_5.Size = new System.Drawing.Size(27, 22);
            this.txt_error_5.TabIndex = 47;
            this.txt_error_5.Visible = false;
            // 
            // errorProvider6
            // 
            this.errorProvider6.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider6.ContainerControl = this;
            this.errorProvider6.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider6.Icon")));
            // 
            // errorProvider7
            // 
            this.errorProvider7.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider7.ContainerControl = this;
            this.errorProvider7.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider7.Icon")));
            // 
            // errorProvider8
            // 
            this.errorProvider8.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider8.ContainerControl = this;
            this.errorProvider8.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider8.Icon")));
            // 
            // errorProvider9
            // 
            this.errorProvider9.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider9.ContainerControl = this;
            this.errorProvider9.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider9.Icon")));
            // 
            // errorProvider10
            // 
            this.errorProvider10.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider10.ContainerControl = this;
            this.errorProvider10.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider10.Icon")));
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 408);
            this.Controls.Add(this.txt_error_5);
            this.Controls.Add(this.txt_error_4);
            this.Controls.Add(this.txt_error_3);
            this.Controls.Add(this.txt_error_2);
            this.Controls.Add(this.txt_error_1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_kod);
            this.Controls.Add(this.btn_adminol);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_gecicisifre);
            this.Controls.Add(this.txt_adsoyad_2);
            this.Controls.Add(this.txt_email_2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçici Adminlik Alma Formu";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_adminol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_gecicisifre;
        private System.Windows.Forms.TextBox txt_email_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_adsoyad_2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_kod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_kontrol;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.TextBox txt_error_3;
        private System.Windows.Forms.TextBox txt_error_2;
        private System.Windows.Forms.TextBox txt_error_1;
        private System.Windows.Forms.TextBox txt_error_5;
        private System.Windows.Forms.TextBox txt_error_4;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider10;
    }
}