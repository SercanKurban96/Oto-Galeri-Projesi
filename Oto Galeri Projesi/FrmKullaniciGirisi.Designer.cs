namespace Oto_Galeri_Projesi
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            this.PctCikis = new System.Windows.Forms.PictureBox();
            this.LnkLblKayitOl = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LnkLblTemizle = new System.Windows.Forms.LinkLabel();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.LnkLblGirisYap = new System.Windows.Forms.LinkLabel();
            this.ChkSifre = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // PctCikis
            // 
            this.PctCikis.BackColor = System.Drawing.Color.Transparent;
            this.PctCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctCikis.Image = ((System.Drawing.Image)(resources.GetObject("PctCikis.Image")));
            this.PctCikis.Location = new System.Drawing.Point(571, -1);
            this.PctCikis.Name = "PctCikis";
            this.PctCikis.Size = new System.Drawing.Size(58, 53);
            this.PctCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctCikis.TabIndex = 19;
            this.PctCikis.TabStop = false;
            this.PctCikis.Click += new System.EventHandler(this.PctCikis_Click);
            this.PctCikis.MouseLeave += new System.EventHandler(this.PctCikis_MouseLeave);
            this.PctCikis.MouseHover += new System.EventHandler(this.PctCikis_MouseHover);
            // 
            // LnkLblKayitOl
            // 
            this.LnkLblKayitOl.AutoSize = true;
            this.LnkLblKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.LnkLblKayitOl.ForeColor = System.Drawing.Color.Black;
            this.LnkLblKayitOl.LinkColor = System.Drawing.Color.Blue;
            this.LnkLblKayitOl.Location = new System.Drawing.Point(343, 419);
            this.LnkLblKayitOl.Name = "LnkLblKayitOl";
            this.LnkLblKayitOl.Size = new System.Drawing.Size(66, 18);
            this.LnkLblKayitOl.TabIndex = 16;
            this.LnkLblKayitOl.TabStop = true;
            this.LnkLblKayitOl.Text = "Kayıt Ol";
            this.LnkLblKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblKayitOl_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(207, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hesabın yok mu?";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.MistyRose;
            this.TxtSifre.Location = new System.Drawing.Point(288, 236);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(158, 26);
            this.TxtSifre.TabIndex = 13;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // LnkLblTemizle
            // 
            this.LnkLblTemizle.AutoSize = true;
            this.LnkLblTemizle.BackColor = System.Drawing.Color.Black;
            this.LnkLblTemizle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblTemizle.ForeColor = System.Drawing.Color.Black;
            this.LnkLblTemizle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblTemizle.LinkColor = System.Drawing.Color.Red;
            this.LnkLblTemizle.Location = new System.Drawing.Point(350, 298);
            this.LnkLblTemizle.Name = "LnkLblTemizle";
            this.LnkLblTemizle.Size = new System.Drawing.Size(135, 31);
            this.LnkLblTemizle.TabIndex = 15;
            this.LnkLblTemizle.TabStop = true;
            this.LnkLblTemizle.Text = "TEMİZLE";
            this.LnkLblTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblTemizle_LinkClicked);
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.MistyRose;
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(288, 204);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(158, 26);
            this.TxtKullaniciAdi.TabIndex = 12;
            // 
            // LnkLblGirisYap
            // 
            this.LnkLblGirisYap.AutoSize = true;
            this.LnkLblGirisYap.BackColor = System.Drawing.Color.Black;
            this.LnkLblGirisYap.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLblGirisYap.ForeColor = System.Drawing.Color.Black;
            this.LnkLblGirisYap.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LnkLblGirisYap.LinkColor = System.Drawing.Color.Red;
            this.LnkLblGirisYap.Location = new System.Drawing.Point(143, 298);
            this.LnkLblGirisYap.Name = "LnkLblGirisYap";
            this.LnkLblGirisYap.Size = new System.Drawing.Size(148, 31);
            this.LnkLblGirisYap.TabIndex = 14;
            this.LnkLblGirisYap.TabStop = true;
            this.LnkLblGirisYap.Text = "GİRİŞ YAP";
            this.LnkLblGirisYap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblGirisYap_LinkClicked);
            // 
            // ChkSifre
            // 
            this.ChkSifre.AutoSize = true;
            this.ChkSifre.Location = new System.Drawing.Point(321, 268);
            this.ChkSifre.Name = "ChkSifre";
            this.ChkSifre.Size = new System.Drawing.Size(125, 22);
            this.ChkSifre.TabIndex = 22;
            this.ChkSifre.Text = "Şifreyi Göster";
            this.ChkSifre.UseVisualStyleBackColor = true;
            this.ChkSifre.CheckedChanged += new System.EventHandler(this.ChkSifre_CheckedChanged);
            // 
            // FrmKullaniciGirisi
            // 
            this.AcceptButton = this.LnkLblGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 461);
            this.Controls.Add(this.ChkSifre);
            this.Controls.Add(this.PctCikis);
            this.Controls.Add(this.LnkLblKayitOl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LnkLblTemizle);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.LnkLblGirisYap);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmKullaniciGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctCikis;
        private System.Windows.Forms.LinkLabel LnkLblKayitOl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LnkLblTemizle;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.LinkLabel LnkLblGirisYap;
        private System.Windows.Forms.CheckBox ChkSifre;
    }
}

