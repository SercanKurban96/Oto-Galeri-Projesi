namespace Oto_Galeri_Projesi
{
    partial class FrmKullaniciKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciKayit));
            this.LnkLblIptal = new System.Windows.Forms.LinkLabel();
            this.LnkLblKayitOl = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSifreTekrar = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LnkLblIptal
            // 
            this.LnkLblIptal.AutoSize = true;
            this.LnkLblIptal.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblIptal.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblIptal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblIptal.LinkColor = System.Drawing.Color.Black;
            this.LnkLblIptal.Location = new System.Drawing.Point(350, 307);
            this.LnkLblIptal.Name = "LnkLblIptal";
            this.LnkLblIptal.Size = new System.Drawing.Size(63, 29);
            this.LnkLblIptal.TabIndex = 37;
            this.LnkLblIptal.TabStop = true;
            this.LnkLblIptal.Text = "İptal";
            this.LnkLblIptal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblIptal_LinkClicked);
            this.LnkLblIptal.MouseLeave += new System.EventHandler(this.LnkLblIptal_MouseLeave);
            this.LnkLblIptal.MouseHover += new System.EventHandler(this.LnkLblIptal_MouseHover);
            // 
            // LnkLblKayitOl
            // 
            this.LnkLblKayitOl.AutoSize = true;
            this.LnkLblKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblKayitOl.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblKayitOl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblKayitOl.LinkColor = System.Drawing.Color.Black;
            this.LnkLblKayitOl.Location = new System.Drawing.Point(158, 307);
            this.LnkLblKayitOl.Name = "LnkLblKayitOl";
            this.LnkLblKayitOl.Size = new System.Drawing.Size(100, 29);
            this.LnkLblKayitOl.TabIndex = 36;
            this.LnkLblKayitOl.TabStop = true;
            this.LnkLblKayitOl.Text = "Kayıt Ol";
            this.LnkLblKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblKayitOl_LinkClicked);
            this.LnkLblKayitOl.MouseLeave += new System.EventHandler(this.LnkLblKayitOl_MouseLeave);
            this.LnkLblKayitOl.MouseHover += new System.EventHandler(this.LnkLblKayitOl_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(130, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // TxtSifreTekrar
            // 
            this.TxtSifreTekrar.BackColor = System.Drawing.Color.MistyRose;
            this.TxtSifreTekrar.Location = new System.Drawing.Point(226, 224);
            this.TxtSifreTekrar.MaxLength = 20;
            this.TxtSifreTekrar.Name = "TxtSifreTekrar";
            this.TxtSifreTekrar.Size = new System.Drawing.Size(197, 26);
            this.TxtSifreTekrar.TabIndex = 28;
            this.TxtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.MistyRose;
            this.TxtSifre.Location = new System.Drawing.Point(226, 186);
            this.TxtSifre.MaxLength = 20;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(198, 26);
            this.TxtSifre.TabIndex = 27;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.MistyRose;
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(226, 146);
            this.TxtKullaniciAdi.MaxLength = 20;
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(198, 26);
            this.TxtKullaniciAdi.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 53);
            this.label1.TabIndex = 25;
            this.label1.Text = "KULLANICI KAYIT FORMU";
            // 
            // FrmKullaniciKayit
            // 
            this.AcceptButton = this.LnkLblKayitOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 384);
            this.Controls.Add(this.LnkLblIptal);
            this.Controls.Add(this.LnkLblKayitOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSifreTekrar);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKullaniciKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKullaniciKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LnkLblIptal;
        private System.Windows.Forms.LinkLabel LnkLblKayitOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSifreTekrar;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Label label1;
    }
}