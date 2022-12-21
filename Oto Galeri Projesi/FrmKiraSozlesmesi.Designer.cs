namespace Oto_Galeri_Projesi
{
    partial class FrmKiraSozlesmesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKiraSozlesmesi));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtGrdAraclar = new System.Windows.Forms.DataGridView();
            this.DtGrdMusteriler = new System.Windows.Forms.DataGridView();
            this.MskTxtTCNO = new System.Windows.Forms.MaskedTextBox();
            this.TxtMusteriAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpEhliyetTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEhliyetNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.CmbYakit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.CmbVites = new System.Windows.Forms.ComboBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtUretimYili = new System.Windows.Forms.TextBox();
            this.PctSatis = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMusteriID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtAracID = new System.Windows.Forms.TextBox();
            this.PctGeri = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtPersonelID = new System.Windows.Forms.TextBox();
            this.MskTxtPersonelTCNO = new System.Windows.Forms.MaskedTextBox();
            this.TxtPersonelResim = new System.Windows.Forms.TextBox();
            this.CmbSubeNo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtPersonelAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DtGrdPersoneller = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.DtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtGun = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtKiraUcreti = new System.Windows.Forms.TextBox();
            this.PctTemizle = new System.Windows.Forms.PictureBox();
            this.PctHesapla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdMusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSatis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctHesapla)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Araçlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Müşteriler";
            // 
            // DtGrdAraclar
            // 
            this.DtGrdAraclar.AllowUserToAddRows = false;
            this.DtGrdAraclar.AllowUserToDeleteRows = false;
            this.DtGrdAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdAraclar.Location = new System.Drawing.Point(12, 312);
            this.DtGrdAraclar.MultiSelect = false;
            this.DtGrdAraclar.Name = "DtGrdAraclar";
            this.DtGrdAraclar.ReadOnly = true;
            this.DtGrdAraclar.Size = new System.Drawing.Size(1182, 105);
            this.DtGrdAraclar.TabIndex = 18;
            this.DtGrdAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrdAraclar_CellClick);
            // 
            // DtGrdMusteriler
            // 
            this.DtGrdMusteriler.AllowUserToAddRows = false;
            this.DtGrdMusteriler.AllowUserToDeleteRows = false;
            this.DtGrdMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdMusteriler.Location = new System.Drawing.Point(12, 167);
            this.DtGrdMusteriler.MultiSelect = false;
            this.DtGrdMusteriler.Name = "DtGrdMusteriler";
            this.DtGrdMusteriler.ReadOnly = true;
            this.DtGrdMusteriler.Size = new System.Drawing.Size(1182, 105);
            this.DtGrdMusteriler.TabIndex = 17;
            this.DtGrdMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrdMusteriler_CellClick);
            // 
            // MskTxtTCNO
            // 
            this.MskTxtTCNO.BackColor = System.Drawing.Color.MistyRose;
            this.MskTxtTCNO.Enabled = false;
            this.MskTxtTCNO.Location = new System.Drawing.Point(160, 25);
            this.MskTxtTCNO.Mask = "00000000000";
            this.MskTxtTCNO.Name = "MskTxtTCNO";
            this.MskTxtTCNO.Size = new System.Drawing.Size(197, 26);
            this.MskTxtTCNO.TabIndex = 111;
            this.MskTxtTCNO.ValidatingType = typeof(int);
            // 
            // TxtMusteriAdiSoyadi
            // 
            this.TxtMusteriAdiSoyadi.BackColor = System.Drawing.Color.MistyRose;
            this.TxtMusteriAdiSoyadi.Location = new System.Drawing.Point(160, 57);
            this.TxtMusteriAdiSoyadi.MaxLength = 30;
            this.TxtMusteriAdiSoyadi.Name = "TxtMusteriAdiSoyadi";
            this.TxtMusteriAdiSoyadi.Size = new System.Drawing.Size(197, 26);
            this.TxtMusteriAdiSoyadi.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 114;
            this.label3.Text = "Müşteri Adı Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(92, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 113;
            this.label4.Text = "TC NO:";
            // 
            // DtpEhliyetTarihi
            // 
            this.DtpEhliyetTarihi.Location = new System.Drawing.Point(160, 121);
            this.DtpEhliyetTarihi.Name = "DtpEhliyetTarihi";
            this.DtpEhliyetTarihi.Size = new System.Drawing.Size(197, 26);
            this.DtpEhliyetTarihi.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(44, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 134;
            this.label5.Text = "Ehliyet Tarihi:";
            // 
            // TxtEhliyetNo
            // 
            this.TxtEhliyetNo.BackColor = System.Drawing.Color.MistyRose;
            this.TxtEhliyetNo.Location = new System.Drawing.Point(160, 89);
            this.TxtEhliyetNo.MaxLength = 120;
            this.TxtEhliyetNo.Name = "TxtEhliyetNo";
            this.TxtEhliyetNo.Size = new System.Drawing.Size(197, 26);
            this.TxtEhliyetNo.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(67, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 133;
            this.label6.Text = "Ehliyet No:";
            // 
            // TxtModel
            // 
            this.TxtModel.BackColor = System.Drawing.Color.MistyRose;
            this.TxtModel.Location = new System.Drawing.Point(117, 82);
            this.TxtModel.MaxLength = 50;
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(197, 26);
            this.TxtModel.TabIndex = 151;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.BackColor = System.Drawing.Color.MistyRose;
            this.TxtPlaka.Enabled = false;
            this.TxtPlaka.Location = new System.Drawing.Point(117, 18);
            this.TxtPlaka.MaxLength = 50;
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(197, 26);
            this.TxtPlaka.TabIndex = 149;
            // 
            // CmbYakit
            // 
            this.CmbYakit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbYakit.FormattingEnabled = true;
            this.CmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.CmbYakit.Location = new System.Drawing.Point(117, 179);
            this.CmbYakit.Name = "CmbYakit";
            this.CmbYakit.Size = new System.Drawing.Size(197, 26);
            this.CmbYakit.TabIndex = 154;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(60, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 164;
            this.label7.Text = "Plaka:";
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
            this.CmbMarka.Location = new System.Drawing.Point(117, 50);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(197, 26);
            this.CmbMarka.TabIndex = 150;
            // 
            // CmbVites
            // 
            this.CmbVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVites.FormattingEnabled = true;
            this.CmbVites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.CmbVites.Location = new System.Drawing.Point(117, 211);
            this.CmbVites.Name = "CmbVites";
            this.CmbVites.Size = new System.Drawing.Size(197, 26);
            this.CmbVites.TabIndex = 155;
            // 
            // TxtRenk
            // 
            this.TxtRenk.BackColor = System.Drawing.Color.MistyRose;
            this.TxtRenk.Location = new System.Drawing.Point(117, 115);
            this.TxtRenk.MaxLength = 50;
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(197, 26);
            this.TxtRenk.TabIndex = 152;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(63, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 18);
            this.label14.TabIndex = 163;
            this.label14.Text = "Vites:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(61, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 162;
            this.label13.Text = "Yakıt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 159;
            this.label8.Text = "Renk:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.BackColor = System.Drawing.Color.MistyRose;
            this.TxtFiyat.Location = new System.Drawing.Point(117, 242);
            this.TxtFiyat.MaxLength = 50;
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(197, 26);
            this.TxtFiyat.TabIndex = 156;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(62, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 161;
            this.label9.Text = "Fiyat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(55, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 158;
            this.label10.Text = "Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(52, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 157;
            this.label11.Text = "Marka:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 160;
            this.label12.Text = "Üretim Yılı:";
            // 
            // TxtUretimYili
            // 
            this.TxtUretimYili.BackColor = System.Drawing.Color.MistyRose;
            this.TxtUretimYili.Location = new System.Drawing.Point(117, 147);
            this.TxtUretimYili.MaxLength = 50;
            this.TxtUretimYili.Name = "TxtUretimYili";
            this.TxtUretimYili.Size = new System.Drawing.Size(197, 26);
            this.TxtUretimYili.TabIndex = 153;
            // 
            // PctSatis
            // 
            this.PctSatis.BackColor = System.Drawing.Color.Transparent;
            this.PctSatis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctSatis.Image = ((System.Drawing.Image)(resources.GetObject("PctSatis.Image")));
            this.PctSatis.Location = new System.Drawing.Point(1103, 424);
            this.PctSatis.Name = "PctSatis";
            this.PctSatis.Size = new System.Drawing.Size(94, 83);
            this.PctSatis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSatis.TabIndex = 165;
            this.PctSatis.TabStop = false;
            this.PctSatis.Click += new System.EventHandler(this.PctSatis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtMusteriID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMusteriAdiSoyadi);
            this.groupBox1.Controls.Add(this.MskTxtTCNO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtEhliyetNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DtpEhliyetTarihi);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 155);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // TxtMusteriID
            // 
            this.TxtMusteriID.BackColor = System.Drawing.Color.MistyRose;
            this.TxtMusteriID.Location = new System.Drawing.Point(47, 153);
            this.TxtMusteriID.Name = "TxtMusteriID";
            this.TxtMusteriID.Size = new System.Drawing.Size(195, 26);
            this.TxtMusteriID.TabIndex = 173;
            this.TxtMusteriID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TxtAracID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtUretimYili);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtModel);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtPlaka);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CmbYakit);
            this.groupBox2.Controls.Add(this.CmbMarka);
            this.groupBox2.Controls.Add(this.TxtFiyat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CmbVites);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxtRenk);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(389, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 282);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // TxtAracID
            // 
            this.TxtAracID.BackColor = System.Drawing.Color.MistyRose;
            this.TxtAracID.Location = new System.Drawing.Point(-141, 206);
            this.TxtAracID.Name = "TxtAracID";
            this.TxtAracID.Size = new System.Drawing.Size(195, 26);
            this.TxtAracID.TabIndex = 173;
            this.TxtAracID.Visible = false;
            // 
            // PctGeri
            // 
            this.PctGeri.BackColor = System.Drawing.Color.Transparent;
            this.PctGeri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctGeri.Image = ((System.Drawing.Image)(resources.GetObject("PctGeri.Image")));
            this.PctGeri.Location = new System.Drawing.Point(1100, 622);
            this.PctGeri.Name = "PctGeri";
            this.PctGeri.Size = new System.Drawing.Size(94, 83);
            this.PctGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctGeri.TabIndex = 168;
            this.PctGeri.TabStop = false;
            this.PctGeri.Click += new System.EventHandler(this.PctGeri_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.TxtPersonelID);
            this.groupBox3.Controls.Add(this.MskTxtPersonelTCNO);
            this.groupBox3.Controls.Add(this.TxtPersonelResim);
            this.groupBox3.Controls.Add(this.CmbSubeNo);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.TxtPersonelAdiSoyadi);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 126);
            this.groupBox3.TabIndex = 169;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Bilgileri";
            // 
            // TxtPersonelID
            // 
            this.TxtPersonelID.BackColor = System.Drawing.Color.MistyRose;
            this.TxtPersonelID.Location = new System.Drawing.Point(-204, 182);
            this.TxtPersonelID.Name = "TxtPersonelID";
            this.TxtPersonelID.Size = new System.Drawing.Size(195, 26);
            this.TxtPersonelID.TabIndex = 175;
            this.TxtPersonelID.Visible = false;
            // 
            // MskTxtPersonelTCNO
            // 
            this.MskTxtPersonelTCNO.BackColor = System.Drawing.Color.MistyRose;
            this.MskTxtPersonelTCNO.Enabled = false;
            this.MskTxtPersonelTCNO.Location = new System.Drawing.Point(165, 25);
            this.MskTxtPersonelTCNO.Mask = "00000000000";
            this.MskTxtPersonelTCNO.Name = "MskTxtPersonelTCNO";
            this.MskTxtPersonelTCNO.Size = new System.Drawing.Size(197, 26);
            this.MskTxtPersonelTCNO.TabIndex = 174;
            this.MskTxtPersonelTCNO.ValidatingType = typeof(int);
            // 
            // TxtPersonelResim
            // 
            this.TxtPersonelResim.BackColor = System.Drawing.Color.MistyRose;
            this.TxtPersonelResim.Location = new System.Drawing.Point(-204, 226);
            this.TxtPersonelResim.Name = "TxtPersonelResim";
            this.TxtPersonelResim.Size = new System.Drawing.Size(195, 26);
            this.TxtPersonelResim.TabIndex = 172;
            this.TxtPersonelResim.Visible = false;
            // 
            // CmbSubeNo
            // 
            this.CmbSubeNo.DisplayMember = "Sube_Adi";
            this.CmbSubeNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSubeNo.FormattingEnabled = true;
            this.CmbSubeNo.Location = new System.Drawing.Point(165, 89);
            this.CmbSubeNo.Name = "CmbSubeNo";
            this.CmbSubeNo.Size = new System.Drawing.Size(197, 26);
            this.CmbSubeNo.TabIndex = 170;
            this.CmbSubeNo.ValueMember = "Sube_ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.ForeColor = System.Drawing.Color.Yellow;
            this.label17.Location = new System.Drawing.Point(87, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 18);
            this.label17.TabIndex = 171;
            this.label17.Text = "Şube No:";
            // 
            // TxtPersonelAdiSoyadi
            // 
            this.TxtPersonelAdiSoyadi.BackColor = System.Drawing.Color.MistyRose;
            this.TxtPersonelAdiSoyadi.Location = new System.Drawing.Point(165, 57);
            this.TxtPersonelAdiSoyadi.MaxLength = 30;
            this.TxtPersonelAdiSoyadi.Name = "TxtPersonelAdiSoyadi";
            this.TxtPersonelAdiSoyadi.Size = new System.Drawing.Size(197, 26);
            this.TxtPersonelAdiSoyadi.TabIndex = 145;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.ForeColor = System.Drawing.Color.Yellow;
            this.label15.Location = new System.Drawing.Point(6, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 18);
            this.label15.TabIndex = 147;
            this.label15.Text = "Personel Adı Soyadı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(97, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 146;
            this.label16.Text = "TC NO:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 18);
            this.label18.TabIndex = 171;
            this.label18.Text = "Personeller";
            // 
            // DtGrdPersoneller
            // 
            this.DtGrdPersoneller.AllowUserToAddRows = false;
            this.DtGrdPersoneller.AllowUserToDeleteRows = false;
            this.DtGrdPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtGrdPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdPersoneller.Location = new System.Drawing.Point(12, 27);
            this.DtGrdPersoneller.MultiSelect = false;
            this.DtGrdPersoneller.Name = "DtGrdPersoneller";
            this.DtGrdPersoneller.ReadOnly = true;
            this.DtGrdPersoneller.Size = new System.Drawing.Size(1182, 105);
            this.DtGrdPersoneller.TabIndex = 170;
            this.DtGrdPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrdPersoneller_CellClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(742, 506);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 18);
            this.label19.TabIndex = 191;
            this.label19.Text = "Dönüş Tarihi:";
            // 
            // DtpDonusTarihi
            // 
            this.DtpDonusTarihi.Location = new System.Drawing.Point(852, 500);
            this.DtpDonusTarihi.Name = "DtpDonusTarihi";
            this.DtpDonusTarihi.Size = new System.Drawing.Size(195, 26);
            this.DtpDonusTarihi.TabIndex = 190;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(752, 474);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 18);
            this.label20.TabIndex = 189;
            this.label20.Text = "Çıkış Tarihi:";
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(852, 468);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(195, 26);
            this.DtpCikisTarihi.TabIndex = 188;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(792, 567);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 18);
            this.label21.TabIndex = 186;
            this.label21.Text = "Tutar:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.BackColor = System.Drawing.Color.MistyRose;
            this.TxtTutar.Location = new System.Drawing.Point(852, 564);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(195, 26);
            this.TxtTutar.TabIndex = 187;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(803, 535);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 18);
            this.label22.TabIndex = 184;
            this.label22.Text = "Gün:";
            // 
            // TxtGun
            // 
            this.TxtGun.BackColor = System.Drawing.Color.MistyRose;
            this.TxtGun.Location = new System.Drawing.Point(852, 532);
            this.TxtGun.Name = "TxtGun";
            this.TxtGun.Size = new System.Drawing.Size(195, 26);
            this.TxtGun.TabIndex = 185;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(755, 439);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 18);
            this.label23.TabIndex = 182;
            this.label23.Text = "Kira Ücreti:";
            // 
            // TxtKiraUcreti
            // 
            this.TxtKiraUcreti.BackColor = System.Drawing.Color.MistyRose;
            this.TxtKiraUcreti.Location = new System.Drawing.Point(852, 436);
            this.TxtKiraUcreti.Name = "TxtKiraUcreti";
            this.TxtKiraUcreti.Size = new System.Drawing.Size(195, 26);
            this.TxtKiraUcreti.TabIndex = 183;
            // 
            // PctTemizle
            // 
            this.PctTemizle.BackColor = System.Drawing.Color.Transparent;
            this.PctTemizle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctTemizle.Image = ((System.Drawing.Image)(resources.GetObject("PctTemizle.Image")));
            this.PctTemizle.Location = new System.Drawing.Point(953, 603);
            this.PctTemizle.Name = "PctTemizle";
            this.PctTemizle.Size = new System.Drawing.Size(94, 83);
            this.PctTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctTemizle.TabIndex = 193;
            this.PctTemizle.TabStop = false;
            this.PctTemizle.Click += new System.EventHandler(this.PctTemizle_Click);
            // 
            // PctHesapla
            // 
            this.PctHesapla.BackColor = System.Drawing.Color.Transparent;
            this.PctHesapla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctHesapla.Image = ((System.Drawing.Image)(resources.GetObject("PctHesapla.Image")));
            this.PctHesapla.Location = new System.Drawing.Point(835, 603);
            this.PctHesapla.Name = "PctHesapla";
            this.PctHesapla.Size = new System.Drawing.Size(94, 83);
            this.PctHesapla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctHesapla.TabIndex = 192;
            this.PctHesapla.TabStop = false;
            this.PctHesapla.Click += new System.EventHandler(this.PctHesapla_Click);
            // 
            // FrmKiraSozlesmesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 709);
            this.Controls.Add(this.PctTemizle);
            this.Controls.Add(this.PctHesapla);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.DtpDonusTarihi);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TxtTutar);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TxtGun);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TxtKiraUcreti);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DtGrdPersoneller);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PctGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PctSatis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtGrdAraclar);
            this.Controls.Add(this.DtGrdMusteriler);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKiraSozlesmesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKiraSozlesmesi";
            this.Load += new System.EventHandler(this.FrmSatisSozlesmesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdMusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSatis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctHesapla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtGrdAraclar;
        private System.Windows.Forms.DataGridView DtGrdMusteriler;
        private System.Windows.Forms.MaskedTextBox MskTxtTCNO;
        private System.Windows.Forms.TextBox TxtMusteriAdiSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpEhliyetTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEhliyetNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.ComboBox CmbYakit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.ComboBox CmbVites;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtUretimYili;
        private System.Windows.Forms.PictureBox PctSatis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PctGeri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtPersonelAdiSoyadi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbSubeNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtPersonelResim;
        private System.Windows.Forms.MaskedTextBox MskTxtPersonelTCNO;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView DtGrdPersoneller;
        private System.Windows.Forms.TextBox TxtMusteriID;
        private System.Windows.Forms.TextBox TxtAracID;
        private System.Windows.Forms.TextBox TxtPersonelID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker DtpDonusTarihi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtGun;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TxtKiraUcreti;
        private System.Windows.Forms.PictureBox PctTemizle;
        private System.Windows.Forms.PictureBox PctHesapla;
    }
}