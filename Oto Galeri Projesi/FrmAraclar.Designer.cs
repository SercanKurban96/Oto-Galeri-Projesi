namespace Oto_Galeri_Projesi
{
    partial class FrmAraclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAraclar));
            this.PctGeri = new System.Windows.Forms.PictureBox();
            this.CmbSubeNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PctResim = new System.Windows.Forms.PictureBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.CmbYakit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtResim = new System.Windows.Forms.TextBox();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.CmbVites = new System.Windows.Forms.ComboBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnResimYolu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAracNo = new System.Windows.Forms.TextBox();
            this.TxtUretimYili = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PctAracSil = new System.Windows.Forms.PictureBox();
            this.PctTemizle = new System.Windows.Forms.PictureBox();
            this.PctAracGuncelle = new System.Windows.Forms.PictureBox();
            this.PctAracKaydet = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DtgrdAraclar = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtPlakaAra = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CmbAraclar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAracSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAracGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAracKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // PctGeri
            // 
            this.PctGeri.BackColor = System.Drawing.Color.Transparent;
            this.PctGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctGeri.Image = ((System.Drawing.Image)(resources.GetObject("PctGeri.Image")));
            this.PctGeri.Location = new System.Drawing.Point(740, 0);
            this.PctGeri.Name = "PctGeri";
            this.PctGeri.Size = new System.Drawing.Size(58, 53);
            this.PctGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctGeri.TabIndex = 125;
            this.PctGeri.TabStop = false;
            this.PctGeri.Click += new System.EventHandler(this.PctGeri_Click);
            // 
            // CmbSubeNo
            // 
            this.CmbSubeNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSubeNo.FormattingEnabled = true;
            this.CmbSubeNo.Location = new System.Drawing.Point(129, 355);
            this.CmbSubeNo.Name = "CmbSubeNo";
            this.CmbSubeNo.Size = new System.Drawing.Size(197, 26);
            this.CmbSubeNo.TabIndex = 9;
            this.CmbSubeNo.SelectedIndexChanged += new System.EventHandler(this.CmbSubeNo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 150;
            this.label7.Text = "Şube Adı:";
            // 
            // PctResim
            // 
            this.PctResim.BackColor = System.Drawing.Color.Transparent;
            this.PctResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctResim.Location = new System.Drawing.Point(332, 63);
            this.PctResim.Name = "PctResim";
            this.PctResim.Size = new System.Drawing.Size(454, 188);
            this.PctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctResim.TabIndex = 149;
            this.PctResim.TabStop = false;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.BackColor = System.Drawing.Color.MistyRose;
            this.TxtPlaka.Location = new System.Drawing.Point(129, 63);
            this.TxtPlaka.MaxLength = 50;
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(197, 26);
            this.TxtPlaka.TabIndex = 0;
            // 
            // CmbYakit
            // 
            this.CmbYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbYakit.FormattingEnabled = true;
            this.CmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.CmbYakit.Location = new System.Drawing.Point(129, 224);
            this.CmbYakit.Name = "CmbYakit";
            this.CmbYakit.Size = new System.Drawing.Size(197, 26);
            this.CmbYakit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 148;
            this.label5.Text = "Plaka:";
            // 
            // TxtResim
            // 
            this.TxtResim.BackColor = System.Drawing.Color.MistyRose;
            this.TxtResim.Location = new System.Drawing.Point(184, 323);
            this.TxtResim.MaxLength = 500;
            this.TxtResim.Name = "TxtResim";
            this.TxtResim.Size = new System.Drawing.Size(142, 26);
            this.TxtResim.TabIndex = 135;
            this.TxtResim.Visible = false;
            // 
            // CmbMarka
            // 
            this.CmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Cadillac",
            "Chevrolet",
            "Citroen",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "Hyundai",
            "Koenigsegg"});
            this.CmbMarka.Location = new System.Drawing.Point(129, 95);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(197, 26);
            this.CmbMarka.TabIndex = 1;
            this.CmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // CmbVites
            // 
            this.CmbVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVites.FormattingEnabled = true;
            this.CmbVites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.CmbVites.Location = new System.Drawing.Point(129, 256);
            this.CmbVites.Name = "CmbVites";
            this.CmbVites.Size = new System.Drawing.Size(197, 26);
            this.CmbVites.TabIndex = 6;
            // 
            // TxtRenk
            // 
            this.TxtRenk.BackColor = System.Drawing.Color.MistyRose;
            this.TxtRenk.Location = new System.Drawing.Point(129, 160);
            this.TxtRenk.MaxLength = 50;
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(197, 26);
            this.TxtRenk.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(75, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 18);
            this.label14.TabIndex = 143;
            this.label14.Text = "Vites:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(73, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 142;
            this.label13.Text = "Yakıt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 132;
            this.label3.Text = "Renk:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.BackColor = System.Drawing.Color.MistyRose;
            this.TxtFiyat.Location = new System.Drawing.Point(129, 289);
            this.TxtFiyat.MaxLength = 50;
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(197, 26);
            this.TxtFiyat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 139;
            this.label4.Text = "Fiyat:";
            // 
            // BtnResimYolu
            // 
            this.BtnResimYolu.Location = new System.Drawing.Point(129, 322);
            this.BtnResimYolu.Name = "BtnResimYolu";
            this.BtnResimYolu.Size = new System.Drawing.Size(49, 27);
            this.BtnResimYolu.TabIndex = 8;
            this.BtnResimYolu.Text = "...";
            this.BtnResimYolu.UseVisualStyleBackColor = true;
            this.BtnResimYolu.Click += new System.EventHandler(this.BtnResimYolu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 130;
            this.label2.Text = "Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 136;
            this.label11.Text = "Fotoğraf Seç:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 128;
            this.label1.Text = "Marka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 134;
            this.label6.Text = "Üretim Yılı:";
            // 
            // TxtAracNo
            // 
            this.TxtAracNo.BackColor = System.Drawing.Color.MistyRose;
            this.TxtAracNo.Enabled = false;
            this.TxtAracNo.Location = new System.Drawing.Point(32, 0);
            this.TxtAracNo.MaxLength = 50;
            this.TxtAracNo.Name = "TxtAracNo";
            this.TxtAracNo.Size = new System.Drawing.Size(197, 26);
            this.TxtAracNo.TabIndex = 126;
            this.TxtAracNo.Visible = false;
            // 
            // TxtUretimYili
            // 
            this.TxtUretimYili.BackColor = System.Drawing.Color.MistyRose;
            this.TxtUretimYili.Location = new System.Drawing.Point(129, 192);
            this.TxtUretimYili.MaxLength = 4;
            this.TxtUretimYili.Name = "TxtUretimYili";
            this.TxtUretimYili.Size = new System.Drawing.Size(197, 26);
            this.TxtUretimYili.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-43, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 127;
            this.label9.Text = "Araç No:";
            this.label9.Visible = false;
            // 
            // PctAracSil
            // 
            this.PctAracSil.BackColor = System.Drawing.Color.White;
            this.PctAracSil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAracSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctAracSil.Image = ((System.Drawing.Image)(resources.GetObject("PctAracSil.Image")));
            this.PctAracSil.Location = new System.Drawing.Point(589, 271);
            this.PctAracSil.Name = "PctAracSil";
            this.PctAracSil.Size = new System.Drawing.Size(113, 55);
            this.PctAracSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAracSil.TabIndex = 161;
            this.PctAracSil.TabStop = false;
            this.PctAracSil.Click += new System.EventHandler(this.PctAracSil_Click);
            this.PctAracSil.MouseHover += new System.EventHandler(this.PctAracSil_MouseHover);
            // 
            // PctTemizle
            // 
            this.PctTemizle.BackColor = System.Drawing.Color.Transparent;
            this.PctTemizle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctTemizle.Image = ((System.Drawing.Image)(resources.GetObject("PctTemizle.Image")));
            this.PctTemizle.Location = new System.Drawing.Point(589, 391);
            this.PctTemizle.Name = "PctTemizle";
            this.PctTemizle.Size = new System.Drawing.Size(113, 55);
            this.PctTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctTemizle.TabIndex = 158;
            this.PctTemizle.TabStop = false;
            this.PctTemizle.Click += new System.EventHandler(this.PctTemizle_Click);
            this.PctTemizle.MouseHover += new System.EventHandler(this.PctTemizle_MouseHover);
            // 
            // PctAracGuncelle
            // 
            this.PctAracGuncelle.BackColor = System.Drawing.Color.White;
            this.PctAracGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAracGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctAracGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PctAracGuncelle.Image")));
            this.PctAracGuncelle.Location = new System.Drawing.Point(391, 391);
            this.PctAracGuncelle.Name = "PctAracGuncelle";
            this.PctAracGuncelle.Size = new System.Drawing.Size(113, 55);
            this.PctAracGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAracGuncelle.TabIndex = 157;
            this.PctAracGuncelle.TabStop = false;
            this.PctAracGuncelle.Click += new System.EventHandler(this.PctAracGuncelle_Click);
            this.PctAracGuncelle.MouseHover += new System.EventHandler(this.PctAracGuncelle_MouseHover);
            // 
            // PctAracKaydet
            // 
            this.PctAracKaydet.BackColor = System.Drawing.Color.White;
            this.PctAracKaydet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctAracKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctAracKaydet.Image = ((System.Drawing.Image)(resources.GetObject("PctAracKaydet.Image")));
            this.PctAracKaydet.Location = new System.Drawing.Point(391, 271);
            this.PctAracKaydet.Name = "PctAracKaydet";
            this.PctAracKaydet.Size = new System.Drawing.Size(113, 55);
            this.PctAracKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctAracKaydet.TabIndex = 155;
            this.PctAracKaydet.TabStop = false;
            this.PctAracKaydet.Click += new System.EventHandler(this.PctAracKaydet_Click);
            this.PctAracKaydet.MouseHover += new System.EventHandler(this.PctAracKaydet_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DtgrdAraclar
            // 
            this.DtgrdAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdAraclar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgrdAraclar.Location = new System.Drawing.Point(0, 517);
            this.DtgrdAraclar.Name = "DtgrdAraclar";
            this.DtgrdAraclar.Size = new System.Drawing.Size(798, 150);
            this.DtgrdAraclar.TabIndex = 163;
            this.DtgrdAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdAraclar_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(299, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 51);
            this.label12.TabIndex = 164;
            this.label12.Text = "ARAÇLAR";
            // 
            // TxtPlakaAra
            // 
            this.TxtPlakaAra.BackColor = System.Drawing.Color.MistyRose;
            this.TxtPlakaAra.Location = new System.Drawing.Point(156, 439);
            this.TxtPlakaAra.MaxLength = 50;
            this.TxtPlakaAra.Name = "TxtPlakaAra";
            this.TxtPlakaAra.Size = new System.Drawing.Size(197, 26);
            this.TxtPlakaAra.TabIndex = 165;
            this.TxtPlakaAra.TextChanged += new System.EventHandler(this.TxtPlakaAra_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 442);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 18);
            this.label16.TabIndex = 166;
            this.label16.Text = "Plakaya Göre Ara:";
            // 
            // TxtModel
            // 
            this.TxtModel.BackColor = System.Drawing.Color.MistyRose;
            this.TxtModel.Location = new System.Drawing.Point(129, 127);
            this.TxtModel.MaxLength = 50;
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(197, 26);
            this.TxtModel.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // CmbAraclar
            // 
            this.CmbAraclar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAraclar.FormattingEnabled = true;
            this.CmbAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.CmbAraclar.Location = new System.Drawing.Point(589, 474);
            this.CmbAraclar.Name = "CmbAraclar";
            this.CmbAraclar.Size = new System.Drawing.Size(197, 26);
            this.CmbAraclar.TabIndex = 169;
            this.CmbAraclar.SelectedIndexChanged += new System.EventHandler(this.CmbAraclar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(518, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 170;
            this.label8.Text = "Araçlar:";
            // 
            // FrmAraclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 667);
            this.Controls.Add(this.CmbAraclar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.TxtPlakaAra);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DtgrdAraclar);
            this.Controls.Add(this.PctAracSil);
            this.Controls.Add(this.PctTemizle);
            this.Controls.Add(this.PctAracGuncelle);
            this.Controls.Add(this.PctAracKaydet);
            this.Controls.Add(this.CmbSubeNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PctResim);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.CmbYakit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtResim);
            this.Controls.Add(this.CmbMarka);
            this.Controls.Add(this.CmbVites);
            this.Controls.Add(this.TxtRenk);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnResimYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAracNo);
            this.Controls.Add(this.TxtUretimYili);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PctGeri);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAraclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAraclar";
            this.Load += new System.EventHandler(this.FrmAraclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAracSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAracGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctAracKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PctGeri;
        private System.Windows.Forms.ComboBox CmbSubeNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PctResim;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.ComboBox CmbYakit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtResim;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.ComboBox CmbVites;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnResimYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAracNo;
        private System.Windows.Forms.TextBox TxtUretimYili;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PctAracSil;
        private System.Windows.Forms.PictureBox PctTemizle;
        private System.Windows.Forms.PictureBox PctAracGuncelle;
        private System.Windows.Forms.PictureBox PctAracKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView DtgrdAraclar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtPlakaAra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CmbAraclar;
        private System.Windows.Forms.Label label8;
    }
}