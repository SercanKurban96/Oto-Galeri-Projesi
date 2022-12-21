namespace Oto_Galeri_Projesi
{
    partial class FrmSubeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubeler));
            this.DtgrdSubeler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSubeNo = new System.Windows.Forms.TextBox();
            this.RchTxtSubeAdresi = new System.Windows.Forms.RichTextBox();
            this.TxtSubeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PctSubeSil = new System.Windows.Forms.PictureBox();
            this.PctTemizle = new System.Windows.Forms.PictureBox();
            this.PctSubeGuncelle = new System.Windows.Forms.PictureBox();
            this.PctSubeKaydet = new System.Windows.Forms.PictureBox();
            this.PctGeri = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtSubeAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdSubeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSubeSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSubeGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSubeKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgrdSubeler
            // 
            this.DtgrdSubeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgrdSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgrdSubeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgrdSubeler.Location = new System.Drawing.Point(0, 376);
            this.DtgrdSubeler.Name = "DtgrdSubeler";
            this.DtgrdSubeler.Size = new System.Drawing.Size(804, 150);
            this.DtgrdSubeler.TabIndex = 3;
            this.DtgrdSubeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrdSubeler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-127, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şube No:";
            this.label1.Visible = false;
            // 
            // TxtSubeNo
            // 
            this.TxtSubeNo.BackColor = System.Drawing.Color.MistyRose;
            this.TxtSubeNo.Enabled = false;
            this.TxtSubeNo.Location = new System.Drawing.Point(-49, 9);
            this.TxtSubeNo.Name = "TxtSubeNo";
            this.TxtSubeNo.Size = new System.Drawing.Size(234, 26);
            this.TxtSubeNo.TabIndex = 2;
            this.TxtSubeNo.Visible = false;
            // 
            // RchTxtSubeAdresi
            // 
            this.RchTxtSubeAdresi.BackColor = System.Drawing.Color.MistyRose;
            this.RchTxtSubeAdresi.Location = new System.Drawing.Point(130, 120);
            this.RchTxtSubeAdresi.Name = "RchTxtSubeAdresi";
            this.RchTxtSubeAdresi.Size = new System.Drawing.Size(234, 142);
            this.RchTxtSubeAdresi.TabIndex = 1;
            this.RchTxtSubeAdresi.Text = "";
            // 
            // TxtSubeAdi
            // 
            this.TxtSubeAdi.BackColor = System.Drawing.Color.MistyRose;
            this.TxtSubeAdi.Location = new System.Drawing.Point(130, 88);
            this.TxtSubeAdi.Name = "TxtSubeAdi";
            this.TxtSubeAdi.Size = new System.Drawing.Size(234, 26);
            this.TxtSubeAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şube Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şube Adresi:";
            // 
            // PctSubeSil
            // 
            this.PctSubeSil.BackColor = System.Drawing.Color.Transparent;
            this.PctSubeSil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctSubeSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctSubeSil.Image = ((System.Drawing.Image)(resources.GetObject("PctSubeSil.Image")));
            this.PctSubeSil.Location = new System.Drawing.Point(628, 87);
            this.PctSubeSil.Name = "PctSubeSil";
            this.PctSubeSil.Size = new System.Drawing.Size(113, 55);
            this.PctSubeSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSubeSil.TabIndex = 161;
            this.PctSubeSil.TabStop = false;
            this.PctSubeSil.Click += new System.EventHandler(this.PctMusteriSil_Click);
            this.PctSubeSil.MouseHover += new System.EventHandler(this.PctSubeSil_MouseHover);
            // 
            // PctTemizle
            // 
            this.PctTemizle.BackColor = System.Drawing.Color.Transparent;
            this.PctTemizle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctTemizle.Image = ((System.Drawing.Image)(resources.GetObject("PctTemizle.Image")));
            this.PctTemizle.Location = new System.Drawing.Point(628, 207);
            this.PctTemizle.Name = "PctTemizle";
            this.PctTemizle.Size = new System.Drawing.Size(113, 55);
            this.PctTemizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctTemizle.TabIndex = 158;
            this.PctTemizle.TabStop = false;
            this.PctTemizle.Click += new System.EventHandler(this.PctTemizle_Click);
            this.PctTemizle.MouseHover += new System.EventHandler(this.PctTemizle_MouseHover);
            // 
            // PctSubeGuncelle
            // 
            this.PctSubeGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.PctSubeGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctSubeGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctSubeGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("PctSubeGuncelle.Image")));
            this.PctSubeGuncelle.Location = new System.Drawing.Point(430, 207);
            this.PctSubeGuncelle.Name = "PctSubeGuncelle";
            this.PctSubeGuncelle.Size = new System.Drawing.Size(113, 55);
            this.PctSubeGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSubeGuncelle.TabIndex = 157;
            this.PctSubeGuncelle.TabStop = false;
            this.PctSubeGuncelle.Click += new System.EventHandler(this.PctSubeGuncelle_Click);
            this.PctSubeGuncelle.MouseHover += new System.EventHandler(this.PctSubeGuncelle_MouseHover);
            // 
            // PctSubeKaydet
            // 
            this.PctSubeKaydet.BackColor = System.Drawing.Color.Transparent;
            this.PctSubeKaydet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctSubeKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctSubeKaydet.Image = ((System.Drawing.Image)(resources.GetObject("PctSubeKaydet.Image")));
            this.PctSubeKaydet.Location = new System.Drawing.Point(430, 87);
            this.PctSubeKaydet.Name = "PctSubeKaydet";
            this.PctSubeKaydet.Size = new System.Drawing.Size(113, 55);
            this.PctSubeKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSubeKaydet.TabIndex = 155;
            this.PctSubeKaydet.TabStop = false;
            this.PctSubeKaydet.Click += new System.EventHandler(this.PctMusteriKaydet_Click);
            this.PctSubeKaydet.MouseHover += new System.EventHandler(this.PctSubeKaydet_MouseHover);
            // 
            // PctGeri
            // 
            this.PctGeri.BackColor = System.Drawing.Color.Transparent;
            this.PctGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctGeri.Image = ((System.Drawing.Image)(resources.GetObject("PctGeri.Image")));
            this.PctGeri.Location = new System.Drawing.Point(746, 0);
            this.PctGeri.Name = "PctGeri";
            this.PctGeri.Size = new System.Drawing.Size(58, 53);
            this.PctGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctGeri.TabIndex = 163;
            this.PctGeri.TabStop = false;
            this.PctGeri.Click += new System.EventHandler(this.PctGeri_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(398, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 18);
            this.label16.TabIndex = 164;
            this.label16.Text = "Şube Adına Göre Ara:";
            // 
            // TxtSubeAra
            // 
            this.TxtSubeAra.BackColor = System.Drawing.Color.MistyRose;
            this.TxtSubeAra.Location = new System.Drawing.Point(566, 320);
            this.TxtSubeAra.Name = "TxtSubeAra";
            this.TxtSubeAra.Size = new System.Drawing.Size(234, 26);
            this.TxtSubeAra.TabIndex = 2;
            this.TxtSubeAra.TextChanged += new System.EventHandler(this.TxtSubeAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(295, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 51);
            this.label10.TabIndex = 166;
            this.label10.Text = "ŞUBELER";
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // FrmSubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 526);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtSubeAra);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PctGeri);
            this.Controls.Add(this.PctSubeSil);
            this.Controls.Add(this.PctTemizle);
            this.Controls.Add(this.PctSubeGuncelle);
            this.Controls.Add(this.PctSubeKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSubeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RchTxtSubeAdresi);
            this.Controls.Add(this.TxtSubeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgrdSubeler);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSubeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSubeler";
            this.Load += new System.EventHandler(this.FrmSubeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgrdSubeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSubeSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTemizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSubeGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctSubeKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctGeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgrdSubeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSubeNo;
        private System.Windows.Forms.RichTextBox RchTxtSubeAdresi;
        private System.Windows.Forms.TextBox TxtSubeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PctSubeSil;
        private System.Windows.Forms.PictureBox PctTemizle;
        private System.Windows.Forms.PictureBox PctSubeGuncelle;
        private System.Windows.Forms.PictureBox PctSubeKaydet;
        private System.Windows.Forms.PictureBox PctGeri;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtSubeAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}