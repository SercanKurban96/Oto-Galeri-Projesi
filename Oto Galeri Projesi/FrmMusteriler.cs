using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri_Projesi
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        public void Temizle()
        {
            TxtMusteriNo.Clear();
            MskTxtTCNO.Clear();
            TxtMusteriAdiSoyadi.Clear();
            TxtMail.Clear();
            MskTxtTelefon.Clear();
            TxtEhliyetNo.Clear();
            RchTxtAdres.Clear();
            TxtResim.Clear();
            PctResim.ImageLocation = "";
        }
        public void Listele()
        {
            var query = from x in db.TBLMUSTERI
                        select new
                        {
                            Müşteri_ID = x.Musteri_ID,
                            TC = x.Musteri_TCNO,
                            AdıSoyadı = x.Musteri_AdiSoyadi,
                            DogumTarihi = x.Musteri_DogumTarihi,
                            Mail = x.Musteri_Mail,
                            Telefon = x.Musteri_Telefon,
                            EhliyetNo = x.Musteri_EhliyetNo,
                            EhliyetTarihi = x.Musteri_EhliyetTarihi,
                            Adresi = x.Musteri_Adresi,
                            Fotoğraf = x.Musteri_Fotograf
                        };
            DtGrdMusteriler.DataSource = query.ToList();
        }

        bool durum;
        void ayniKayitEngelleme()
        {
            var query = from x in db.TBLMUSTERI
                        where x.Musteri_TCNO == MskTxtTCNO.Text
                        select x;
            if (query.Any())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }

        public static bool TcDogrula(string tcKimlikNo)
        {
            bool returnvalue = false;
            if (tcKimlikNo.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcKimlikNo);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
            return returnvalue;
        }
        private void PctGeri_Click(object sender, EventArgs e)
        {
            FrmOtoGaleri fr = new FrmOtoGaleri();
            fr.Show();
            this.Hide();
        }

        private void PctMusteriKaydet_Click(object sender, EventArgs e)
        {
            TBLMUSTERI musteri = new TBLMUSTERI();
            if (MskTxtTCNO.Text == "" || TxtMusteriAdiSoyadi.Text == "" ||
                TxtMail.Text == "" || MskTxtTelefon.Text == "" || TxtEhliyetNo.Text == "" ||
                RchTxtAdres.Text == "" || TxtResim.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ayniKayitEngelleme();
                if (durum == true)
                {
                    if (TcDogrula(MskTxtTCNO.Text))
                    {
                        musteri.Musteri_TCNO = MskTxtTCNO.Text;
                        musteri.Musteri_AdiSoyadi = TxtMusteriAdiSoyadi.Text;
                        musteri.Musteri_DogumTarihi = DtpDogumTarihi.Value;
                        musteri.Musteri_Mail = TxtMail.Text;
                        musteri.Musteri_Telefon = MskTxtTelefon.Text;
                        musteri.Musteri_EhliyetNo = TxtEhliyetNo.Text;
                        musteri.Musteri_EhliyetTarihi = DtpEhliyetTarihi.Value;
                        musteri.Musteri_Adresi = RchTxtAdres.Text;
                        musteri.Musteri_Fotograf = TxtResim.Text;
                        db.TBLMUSTERI.Add(musteri);
                        db.SaveChanges();
                        MessageBox.Show("Müşteri Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        Listele();
                        PctResim.ImageLocation = "";
                        MskTxtTCNO.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir TC NO bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(MskTxtTCNO.Text + " adında bir TC no zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnResimYolu_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctResim.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }

        private void PctMusteriSil_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtMusteriNo.Text != "")
            {
                id = Convert.ToInt32(TxtMusteriNo.Text);
                var sil = db.TBLMUSTERI.Find(id);

                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.TBLMUSTERI.Remove(sil);
                    db.SaveChanges();
                    MessageBox.Show("Müşteri silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                    PctResim.ImageLocation = "";
                    MskTxtTCNO.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PctMusteriGuncelle_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtMusteriNo.Text != "")
            {
                id = Convert.ToInt32(TxtMusteriNo.Text);
                var guncelle = db.TBLMUSTERI.Find(id);
                
                guncelle.Musteri_AdiSoyadi = TxtMusteriAdiSoyadi.Text;
                guncelle.Musteri_DogumTarihi = DtpDogumTarihi.Value;
                guncelle.Musteri_Mail = TxtMail.Text;
                guncelle.Musteri_Telefon = MskTxtTelefon.Text;
                guncelle.Musteri_EhliyetNo = TxtEhliyetNo.Text;
                guncelle.Musteri_EhliyetTarihi = DtpEhliyetTarihi.Value;
                guncelle.Musteri_Adresi = RchTxtAdres.Text;
                guncelle.Musteri_Fotograf = TxtResim.Text;
                db.SaveChanges();
                MessageBox.Show("Müşteri düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
                PctResim.ImageLocation = "";
                MskTxtTCNO.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir müşteri seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PctTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void DtGrdMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMusteriNo.Text = DtGrdMusteriler.CurrentRow.Cells[0].Value.ToString();
            MskTxtTCNO.Text = DtGrdMusteriler.CurrentRow.Cells[1].Value.ToString();
            TxtMusteriAdiSoyadi.Text = DtGrdMusteriler.CurrentRow.Cells[2].Value.ToString();
            DtpDogumTarihi.Text = DtGrdMusteriler.CurrentRow.Cells[3].Value.ToString();
            TxtMail.Text = DtGrdMusteriler.CurrentRow.Cells[4].Value.ToString();
            MskTxtTelefon.Text = DtGrdMusteriler.CurrentRow.Cells[5].Value.ToString();
            TxtEhliyetNo.Text = DtGrdMusteriler.CurrentRow.Cells[6].Value.ToString();
            DtpEhliyetTarihi.Text = DtGrdMusteriler.CurrentRow.Cells[7].Value.ToString();
            RchTxtAdres.Text = DtGrdMusteriler.CurrentRow.Cells[8].Value.ToString();
            TxtResim.Text = DtGrdMusteriler.CurrentRow.Cells[9].Value.ToString();

            PctResim.ImageLocation = DtGrdMusteriler.CurrentRow.Cells[9].Value.ToString();
        }

        private void MskTCNOAra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MskTCNOAra_TextChanged(object sender, EventArgs e)
        {
            var query = (from x in db.TBLMUSTERI
                        select new
                        {
                            Müşteri_ID = x.Musteri_ID,
                            TC = x.Musteri_TCNO,
                            AdıSoyadı = x.Musteri_AdiSoyadi,
                            DogumTarihi = x.Musteri_DogumTarihi,
                            Mail = x.Musteri_Mail,
                            Telefon = x.Musteri_Telefon,
                            EhliyetNo = x.Musteri_EhliyetNo,
                            EhliyetTarihi = x.Musteri_EhliyetTarihi,
                            Adresi = x.Musteri_Adresi,
                            Fotoğraf = x.Musteri_Fotograf
                        }).Where(x => x.TC.Contains(MskTCNOAra.Text)).ToList();
            DtGrdMusteriler.DataSource = query;
        }

        private void PctMusteriKaydet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("KAYDET",PctMusteriKaydet);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;    
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText(); 
        }

        private void PctMusteriKaydet_MouseLeave(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void PctMusteriSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("SİL", PctMusteriSil);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctMusteriGuncelle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("DÜZENLE", PctMusteriGuncelle);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctTemizle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("TEMİZLE", PctTemizle);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }
    }
}
