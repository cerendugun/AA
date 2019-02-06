namespace MaasBordrosu
{
    partial class Form1
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
            this.lblBrütUcret = new System.Windows.Forms.Label();
            this.lblMedeniDurum = new System.Windows.Forms.Label();
            this.lblEsCalısmaDurumu = new System.Windows.Forms.Label();
            this.lblCocukSayisi = new System.Windows.Forms.Label();
            this.lblDönem = new System.Windows.Forms.Label();
            this.txtBrütUcret = new System.Windows.Forms.TextBox();
            this.cmbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.cmbEsCalısmaDurum = new System.Windows.Forms.ComboBox();
            this.cmbCocukSayisi = new System.Windows.Forms.ComboBox();
            this.DtDönem = new System.Windows.Forms.DateTimePicker();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dataBordro = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliKullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataBordro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrütUcret
            // 
            this.lblBrütUcret.AutoSize = true;
            this.lblBrütUcret.Location = new System.Drawing.Point(35, 33);
            this.lblBrütUcret.Name = "lblBrütUcret";
            this.lblBrütUcret.Size = new System.Drawing.Size(55, 13);
            this.lblBrütUcret.TabIndex = 0;
            this.lblBrütUcret.Text = "Brüt Ücret";
            // 
            // lblMedeniDurum
            // 
            this.lblMedeniDurum.AutoSize = true;
            this.lblMedeniDurum.Location = new System.Drawing.Point(35, 63);
            this.lblMedeniDurum.Name = "lblMedeniDurum";
            this.lblMedeniDurum.Size = new System.Drawing.Size(76, 13);
            this.lblMedeniDurum.TabIndex = 1;
            this.lblMedeniDurum.Text = "Medeni Durum";
            // 
            // lblEsCalısmaDurumu
            // 
            this.lblEsCalısmaDurumu.AutoSize = true;
            this.lblEsCalısmaDurumu.Location = new System.Drawing.Point(35, 88);
            this.lblEsCalısmaDurumu.Name = "lblEsCalısmaDurumu";
            this.lblEsCalısmaDurumu.Size = new System.Drawing.Size(98, 13);
            this.lblEsCalısmaDurumu.TabIndex = 2;
            this.lblEsCalısmaDurumu.Text = "Eş Çalışma Durumu";
            // 
            // lblCocukSayisi
            // 
            this.lblCocukSayisi.AutoSize = true;
            this.lblCocukSayisi.Location = new System.Drawing.Point(35, 114);
            this.lblCocukSayisi.Name = "lblCocukSayisi";
            this.lblCocukSayisi.Size = new System.Drawing.Size(68, 13);
            this.lblCocukSayisi.TabIndex = 3;
            this.lblCocukSayisi.Text = "Çocuk Sayısı";
            // 
            // lblDönem
            // 
            this.lblDönem.AutoSize = true;
            this.lblDönem.Location = new System.Drawing.Point(51, 139);
            this.lblDönem.Name = "lblDönem";
            this.lblDönem.Size = new System.Drawing.Size(41, 13);
            this.lblDönem.TabIndex = 4;
            this.lblDönem.Text = "Dönem";
            // 
            // txtBrütUcret
            // 
            this.txtBrütUcret.Location = new System.Drawing.Point(133, 26);
            this.txtBrütUcret.Name = "txtBrütUcret";
            this.txtBrütUcret.Size = new System.Drawing.Size(100, 20);
            this.txtBrütUcret.TabIndex = 5;
            // 
            // cmbMedeniDurum
            // 
            this.cmbMedeniDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniDurum.FormattingEnabled = true;
            this.cmbMedeniDurum.Items.AddRange(new object[] {
            "Evli",
            "Bekar",
            "Dul ",
            "Boşanmış"});
            this.cmbMedeniDurum.Location = new System.Drawing.Point(133, 55);
            this.cmbMedeniDurum.Name = "cmbMedeniDurum";
            this.cmbMedeniDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbMedeniDurum.TabIndex = 6;
            // 
            // cmbEsCalısmaDurum
            // 
            this.cmbEsCalısmaDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEsCalısmaDurum.FormattingEnabled = true;
            this.cmbEsCalısmaDurum.Location = new System.Drawing.Point(134, 80);
            this.cmbEsCalısmaDurum.Name = "cmbEsCalısmaDurum";
            this.cmbEsCalısmaDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbEsCalısmaDurum.TabIndex = 7;
            // 
            // cmbCocukSayisi
            // 
            this.cmbCocukSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCocukSayisi.FormattingEnabled = true;
            this.cmbCocukSayisi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5 ve üzeri"});
            this.cmbCocukSayisi.Location = new System.Drawing.Point(133, 107);
            this.cmbCocukSayisi.Name = "cmbCocukSayisi";
            this.cmbCocukSayisi.Size = new System.Drawing.Size(121, 21);
            this.cmbCocukSayisi.TabIndex = 8;
            // 
            // DtDönem
            // 
            this.DtDönem.Location = new System.Drawing.Point(133, 134);
            this.DtDönem.Name = "DtDönem";
            this.DtDönem.Size = new System.Drawing.Size(188, 20);
            this.DtDönem.TabIndex = 9;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(343, 129);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dataBordro
            // 
            this.dataBordro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBordro.Location = new System.Drawing.Point(38, 170);
            this.dataBordro.Name = "dataBordro";
            this.dataBordro.Size = new System.Drawing.Size(527, 268);
            this.dataBordro.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliKullanıcıToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // yetkiliKullanıcıToolStripMenuItem
            // 
            this.yetkiliKullanıcıToolStripMenuItem.Name = "yetkiliKullanıcıToolStripMenuItem";
            this.yetkiliKullanıcıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yetkiliKullanıcıToolStripMenuItem.Text = "Yetkili Kullanıcı";
            this.yetkiliKullanıcıToolStripMenuItem.Click += new System.EventHandler(this.yetkiliKullanıcıToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataBordro);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.DtDönem);
            this.Controls.Add(this.cmbCocukSayisi);
            this.Controls.Add(this.cmbEsCalısmaDurum);
            this.Controls.Add(this.cmbMedeniDurum);
            this.Controls.Add(this.txtBrütUcret);
            this.Controls.Add(this.lblDönem);
            this.Controls.Add(this.lblCocukSayisi);
            this.Controls.Add(this.lblEsCalısmaDurumu);
            this.Controls.Add(this.lblMedeniDurum);
            this.Controls.Add(this.lblBrütUcret);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBordro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrütUcret;
        private System.Windows.Forms.Label lblMedeniDurum;
        private System.Windows.Forms.Label lblEsCalısmaDurumu;
        private System.Windows.Forms.Label lblCocukSayisi;
        private System.Windows.Forms.Label lblDönem;
        private System.Windows.Forms.TextBox txtBrütUcret;
        private System.Windows.Forms.ComboBox cmbMedeniDurum;
        private System.Windows.Forms.ComboBox cmbEsCalısmaDurum;
        private System.Windows.Forms.ComboBox cmbCocukSayisi;
        private System.Windows.Forms.DateTimePicker DtDönem;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dataBordro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliKullanıcıToolStripMenuItem;
    }
}

