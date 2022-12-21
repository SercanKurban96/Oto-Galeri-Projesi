namespace Oto_Galeri_Projesi
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMusteriNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PctResim = new System.Windows.Forms.PictureBox();
            this.BtnResimYolu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtResim = new System.Windows.Forms.TextBox();
            this.RchTxtAdres = new System.Windows.Forms.RichTextBox();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtTCNO = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMusteriAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PctMusteriKaydet = new System.Windows.Forms.PictureBox();
            this.PctGeri = new System.Windows.Forms.PictureBox();
            this.TxtEhliyetNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpEhliyetTarihi = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.MskTCNOAra = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PctMusteriSil = new System.Windows.Forms.PictureBox();
            this.PctTemizle = new System.Windows.Forms.PictureBox();
            this.PctMusteriGuncelle = new System.Windows.Forms.PictureBox();
            this.DtGrdMusteriler = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PctResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusteriKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusteriSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusteriGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(331, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 51);
            this.label10.TabIndex = 120;
            this.label10.Text = "MÜŞTERİLER";
            // 
            // TxtMusteriNo
            // 
            this.TxtMusteriNo.BackColor = System.Drawing.Color.MistyRose;
            this.TxtMusteriNo.Enabled = false;
            this.TxtMusteriNo.Location = new System.Drawing.Point(80, 26);
            this.TxtMusteriNo.MaxLength = 4;
            this.TxtMusteriNo.Name = "TxtMusteriNo";
            this.TxtMusteriNo.Size = new System.Drawing.Size(197, 26);
            this.TxtMusteriNo.TabIndex = 102;
            this.TxtMusteriNo.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(-19, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 119;
            this.label9.Text = "Müşteri No:";
            this.label9.Visible = false;
            // 
            // PctResim
            // 
            this.PctResim.BackColor = System.Drawing.Color.Transparent;
            this.PctResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctResim.Location = new System.Drawing.Point(373, 72);
            this.PctResim.Name = "PctResim";
            this.PctResim.Size = new System.Drawing.Size(183, 220);
            this.PctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctResim.TabIndex = 118;
            this.PctResim.TabStop = false;
            // 
            // BtnResimYolu
            // 
            this.BtnResimYolu.Location = new System.Drawing.Point(170, 400);
            this.BtnResimYolu.Name = "BtnResimYolu";
            this.BtnResimYolu.Size = new System.Drawing.Size(49, 27);
            this.BtnResimYolu.TabIndex = 7;
            this.BtnResimYolu.Text = "...";
            this.BtnResimYolu.UseVisualStyleBackColor = true;
            this.BtnResimYolu.Click += new System.EventHandler(this.BtnResimYolu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(63, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 117;
            this.label8.Text = "Fotoğraf Seç:";
            // 
            // TxtResim
            // 
            this.TxtResim.BackColor = System.Drawing.Color.MistyRose;
            this.TxtResim.Location = new System.Drawing.Point(225, 400);
            this.TxtResim.Name = "TxtResim";
            this.TxtResim.Size = new System.Drawing.Size(195, 26);
            this.TxtResim.TabIndex = 116;
            this.TxtResim.Visible = false;
            // 
            // RchTxtAdres
            // 
            this.RchTxtAdres.BackColor = System.Drawing.Color.MistyRose;
            this.RchTxtAdres.Location = new System.Drawing.Point(170, 298);
            this.RchTxtAdres.MaxLength = 200;
            this.RchTxtAdres.Name = "RchTxtAdres";
            this.RchTxtAdres.Size = new System.Drawing.Size(386, 96);
            this.RchTxtAdres.TabIndex = 6;
            this.RchTxtAdres.Text = "";
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.Color.MistyRose;
            this.MskTxtTelefon.Location = new System.Drawing.Point(170, 202);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(197, 26);
            this.MskTxtTelefon.TabIndex = 3;
            // 
            // MskTxtTCNO
            // 
            this.MskTxtTCNO.BackColor = System.Drawing.Color.MistyRose;
            this.MskTxtTCNO.Location = new System.Drawing.Point(170, 72);
            this.MskTxtTCNO.Mask = "00000000000";
            this.MskTxtTCNO.Name = "MskTxtTCNO";
            this.MskTxtTCNO.Size = new System.Drawing.Size(197, 26);
            this.MskTxtTCNO.TabIndex = 0;
            this.MskTxtTCNO.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(109, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 115;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(98, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 114;
            this.label6.Text = "Telefon:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.MistyRose;
            this.TxtMail.Location = new System.Drawing.Point(170, 170);
            this.TxtMail.MaxLength = 120;
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(197, 26);
            this.TxtMail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(70, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 113;
            this.label5.Text = "Mail Adresi:";
            // 
            // TxtMusteriAdiSoyadi
            // 
            this.TxtMusteriAdiSoyadi.BackColor = System.Drawing.Color.MistyRose;
            this.TxtMusteriAdiSoyadi.Location = new System.Drawing.Point(170, 104);
            this.TxtMusteriAdiSoyadi.MaxLength = 30;
            this.TxtMusteriAdiSoyadi.Name = "TxtMusteriAdiSoyadi";
            this.TxtMusteriAdiSoyadi.Size = new System.Drawing.Size(197, 26);
            this.TxtMusteriAdiSoyadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 110;
            this.label3.Text = "Müşteri Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(102, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 108;
            this.label2.Text = "TC NO:";
            // 
            // PctMusteriKaydet
            // 
            this.PctMusteriKaydet.BackColor = System.Drawing.Color.Transparent;
            this.PctMusteriKaydet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctMusteriKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMusteriKaydet.Image = ((System.Drawing.Image)(resources.GetObject("PctMusteriKaydet.Image")));
            this.PctMusteriKaydet.Location = new System.Drawing.Point(612, 104);
            this.PctMusteriKaydet.Name = "PctMusteriKaydet";
            this.PctMusteriKaydet.Size = new System.Drawing.Size(104, 92);
            this.PctMusteriKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMusteriKaydet.TabIndex = 121;
            this.PctMusteriKaydet.TabStop = false;
            this.toolTip1.SetToolTip(this.PctMusteriKaydet, "KAYDET");
            this.PctMusteriKaydet.Click += new System.EventHandler(this.PctMusteriKaydet_Click);
            this.PctMusteriKaydet.MouseLeave += new System.EventHandler(this.PctMusteriKaydet_MouseLeave);
            this.PctMusteriKaydet.MouseHover += new System.EventHandler(this.PctMusteriKaydet_MouseHover);
            // 
            // PctGeri
            // 
            this.PctGeri.BackColor = System.Drawing.Color.Transparent;
            this.PctGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctGeri.Image = ((System.Drawing.Image)(resources.GetObject("PctGeri.Image")));
            this.PctGeri.Location = new System.Drawing.Point(913, 0);
            this.PctGeri.Name = "PctGeri";
            this.PctGeri.Size = new System.Drawing.Size(58, 53);
            this.PctGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctGeri.TabIndex = 123;
            this.PctGeri.TabStop = false;
            this.PctGeri.Click += new System.EventHandler(this.PctGeri_Click);
            // 
            // TxtEhliyetNo
            // 
            this.TxtEhliyetNo.BackColor = System.Drawing.Color.MistyRose;
            this.TxtEhliyetNo.Location = new System.Drawing.Point(170, 234);
            this.TxtEhliyetNo.MaxLength = 120;
            this.TxtEhliyetNo.Name = "TxtEhliyetNo";
            this.TxtEhliyetNo.Size = new System.Drawing.Size(197, 26);
            this.TxtEhliyetNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(77, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 128;
            this.label1.Text = "Ehliyet No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(54, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 130;
            this.label4.Text = "Ehliyet Tarihi:";
            // 
            // DtpEhliyetTarihi
            // 
            this.DtpEhliyetTarihi.Location = new System.Drawing.Point(170, 266);
            this.DtpEhliyetTarihi.Name = "DtpEhliyetTarihi";
            this.DtpEhliyetTarihi.Size = new System.Drawing.Size(197, 26);
            this.DtpEhliyetTarihi.TabIndex = 131;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DtpDogumTarihi
            // 
            this.DtpDogumTarihi.Location = new System.Drawing.Point(170, 136);
            this.DtpDogumTarihi.Name = "DtpDogumTarihi";
            this.DtpDogumTarihi.Size = new System.Drawing.Size(197, 26);
            this.DtpDogumTarihi.TabIndex = 133;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(54, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 18);
            this.label12.TabIndex = 132;
            this.label12.Text = "Doğum Tarihi:";
            // 
            // MskTCNOAra
            // 
            this.MskTCNOAra.BackColor = System.Drawing.Color.MistyRose;
            this.MskTCNOAra.Location = new System.Drawing.Point(755, 405);
            this.MskTCNOAra.Mask = "00000000000";
            this.MskTCNOAra.Name = "MskTCNOAra";
            this.MskTCNOAra.Size = new System.Drawing.Size(197, 26);
            this.MskTCNOAra.TabIndex = 156;
            this.MskTCNOAra.ValidatingType = typeof(int);
            this.MskTCNOAra.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTCNOAra_MaskInputRejected);
            this.MskTCNOAra.TextChanged += new System.EventHandler(this.MskTCNOAra_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(600, 408);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 18);
            this.label16.TabIndex = 155;
            this.label16.Text = "TC NO\'ya Göre Ara:";
            // 
            // PctMusteriSil
            // 
            this.PctMusteriSil.BackColor = System.Drawing.Color.Transparent;
            this.PctMusteriSil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctMusteriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMusteriSil.Image = ((System.Drawing.Image)(resources.GetObject("PctMusteriSil.Image")));
            this.PctMusteriSil.Location = new System.Drawing.Point(810, 104);
            this.PctMusteriSil.Name = "PctMusteriSil";
            this.PctMusteriSil.Size = new System.Drawing.Size(104, 92);
            this.PctMusteriSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMusteriSil.TabIndex = 153;
            this.PctMusteriSil.TabStop = false;
            this.PctMusteriSil.Click += new System.EventHandler(this.PctMusteriSil_Click);
            this.PctMusteriSil.MouseHover += new System.EventHandler(this.PctMusteriSil_MouseHover);
            // 
            // PctTemizle
            // 
            this.PctTemizle.BackColor = System.Drawing.Color.Transparent;
            this.PctTemizle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctTemizle.Image = ((System.Drawing.Image)(resources.GetObject("PctTemizle.Image")));
            this.PctTemizle.Location = new System.Drawing.Point(810, 256);
            this.PctTemizle.Name = "PctTemizle";
            this.PctTemizle.Size = new System.Drawing.Size(104, 92);
            this.PctTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctTemizle.TabIndex = 150;
            this.PctTemizle.TabStop = false;
            this.PctTemizle.Click += new System.EventHandler(this.PctTemizle_Click);
            this.PctTemizle.MouseHover += new System.EventHandler(this.PctTemizle_MouseHover);
            // 
            // PctMusteriGuncelle
            // 
            this.PctMusteriGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.PctMusteriGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctMusteriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMusteriGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PctMusteriGuncelle.Image")));
            this.PctMusteriGuncelle.Location = new System.Drawing.Point(612, 256);
            this.PctMusteriGuncelle.Name = "PctMusteriGuncelle";
            this.PctMusteriGuncelle.Size = new System.Drawing.Size(104, 92);
            this.PctMusteriGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctMusteriGuncelle.TabIndex = 149;
            this.PctMusteriGuncelle.TabStop = false;
            this.PctMusteriGuncelle.Click += new System.EventHandler(this.PctMusteriGuncelle_Click);
            this.PctMusteriGuncelle.MouseHover += new System.EventHandler(this.PctMusteriGuncelle_MouseHover);
            // 
            // DtGrdMusteriler
            // 
            this.DtGrdMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdMusteriler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtGrdMusteriler.Location = new System.Drawing.Point(0, 466);
            this.DtGrdMusteriler.Name = "DtGrdMusteriler";
            this.DtGrdMusteriler.Size = new System.Drawing.Size(971, 182);
            this.DtGrdMusteriler.TabIndex = 157;
            this.DtGrdMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrdMusteriler_CellClick);
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 648);
            this.Controls.Add(this.DtGrdMusteriler);
            this.Controls.Add(this.MskTCNOAra);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PctMusteriSil);
            this.Controls.Add(this.PctTemizle);
            this.Controls.Add(this.PctMusteriGuncelle);
            this.Controls.Add(this.DtpDogumTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtpEhliyetTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEhliyetNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctGeri);
            this.Controls.Add(this.PctMusteriKaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtMusteriNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PctResim);
            this.Controls.Add(this.BtnResimYolu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtResim);
            this.Controls.Add(this.RchTxtAdres);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.MskTxtTCNO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtMusteriAdiSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteriEkle";
            this.Load += new System.EventHandler(this.FrmMusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusteriKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusteriSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMusteriGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMusteriNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PctResim;
        private System.Windows.Forms.Button BtnResimYolu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtResim;
        private System.Windows.Forms.RichTextBox RchTxtAdres;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.MaskedTextBox MskTxtTCNO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMusteriAdiSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PctMusteriKaydet;
        private System.Windows.Forms.PictureBox PctGeri;
        private System.Windows.Forms.TextBox TxtEhliyetNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpEhliyetTarihi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker DtpDogumTarihi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MskTCNOAra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox PctMusteriSil;
        private System.Windows.Forms.PictureBox PctTemizle;
        private System.Windows.Forms.PictureBox PctMusteriGuncelle;
        private System.Windows.Forms.DataGridView DtGrdMusteriler;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}