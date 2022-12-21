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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();
        public void Temizle()
        {
            TxtPersonelNo.Clear();
            MskTxtTCNO.Clear();
            TxtPersonelAdiSoyadi.Clear();
            TxtMail.Clear();
            MskTxtTelefon.Clear();
            RchTxtAdres.Clear();
            TxtResim.Clear();
            PctResim.ImageLocation = "";
        }
        public void Listele()
        {
            var query = from x1 in db.TBLPERSONEL
                        join x2 in db.TBLSUBE
                        on x1.Sube_ID equals x2.Sube_ID
                        select new
                        {
                            Personel_ID = x1.Personel_ID,
                            TC = x1.Personel_TCNO,
                            AdıSoyadı = x1.Personel_AdiSoyadi,
                            DogumTarihi = x1.Personel_DogumTarihi,
                            Mail = x1.Personel_Mail,
                            Telefon = x1.Personel_Telefon,
                            Adresi = x1.Personel_Adresi,
                            Fotoğraf = x1.Personel_Fotograf,
                            Şube_Adı = x2.Sube_Adi,
                        };
            DtGrdPersoneller.DataSource = query.ToList();

            using (EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities())
            {
                CmbSubeNo.DataSource = db.TBLSUBE.ToList();
                CmbSubeNo.ValueMember = "Sube_ID";
                CmbSubeNo.DisplayMember = "Sube_Adi";
            }

            //CmbSubeNo.DataSource = db.TBLSUBE.ToList();
            //CmbSubeNo.DisplayMember = "Sube_Adi";
            //CmbSubeNo.Invalidate();
        }

        bool durum;
        void ayniKayitEngelleme()
        {
            var query = from x in db.TBLPERSONEL
                        where x.Personel_TCNO == MskTxtTCNO.Text
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

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void PctPersonelKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL personel = new TBLPERSONEL();
            if (MskTxtTCNO.Text == "" || TxtPersonelAdiSoyadi.Text == "" ||
                TxtMail.Text == "" || MskTxtTelefon.Text == "" ||
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
                        personel.Personel_TCNO = MskTxtTCNO.Text;
                        personel.Personel_AdiSoyadi = TxtPersonelAdiSoyadi.Text;
                        personel.Personel_DogumTarihi = DtpDogumTarihi.Value;
                        personel.Personel_Mail = TxtMail.Text;
                        personel.Personel_Telefon = MskTxtTelefon.Text;                       
                        personel.Personel_Adresi = RchTxtAdres.Text;
                        personel.Personel_Fotograf = TxtResim.Text;
                        personel.Sube_ID = Convert.ToInt32(CmbSubeNo.SelectedValue);
                        db.TBLPERSONEL.Add(personel);
                        db.SaveChanges();
                        MessageBox.Show("Personel Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PctPersonelSil_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtPersonelNo.Text != "")
            {
                id = Convert.ToInt32(TxtPersonelNo.Text);
                var sil = db.TBLPERSONEL.Find(id);

                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.TBLPERSONEL.Remove(sil);
                    db.SaveChanges();
                    MessageBox.Show("Personel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                    PctResim.ImageLocation = "";
                    MskTxtTCNO.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir personel seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PctPersonelGuncelle_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtPersonelNo.Text != "")
            {
                id = Convert.ToInt32(TxtPersonelNo.Text);
                var guncelle = db.TBLPERSONEL.Find(id);

                guncelle.Personel_AdiSoyadi = TxtPersonelAdiSoyadi.Text;
                guncelle.Personel_DogumTarihi = DtpDogumTarihi.Value;
                guncelle.Personel_Mail = TxtMail.Text;
                guncelle.Personel_Telefon = MskTxtTelefon.Text;
                guncelle.Personel_Adresi = RchTxtAdres.Text;
                guncelle.Personel_Fotograf = TxtResim.Text;
                guncelle.Sube_ID = int.Parse(CmbSubeNo.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Personel düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
                PctResim.ImageLocation = "";
                MskTxtTCNO.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz bir personel seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PctTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void MskTCNOAra_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void CmbSubeNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnResimYolu_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctResim.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }

        private void DtGrdPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtPersonelNo.Text = DtGrdPersoneller.CurrentRow.Cells[0].Value.ToString();
            MskTxtTCNO.Text = DtGrdPersoneller.CurrentRow.Cells[1].Value.ToString();
            TxtPersonelAdiSoyadi.Text = DtGrdPersoneller.CurrentRow.Cells[2].Value.ToString();
            DtpDogumTarihi.Text = DtGrdPersoneller.CurrentRow.Cells[3].Value.ToString();
            TxtMail.Text = DtGrdPersoneller.CurrentRow.Cells[4].Value.ToString();
            MskTxtTelefon.Text = DtGrdPersoneller.CurrentRow.Cells[5].Value.ToString();
            RchTxtAdres.Text = DtGrdPersoneller.CurrentRow.Cells[6].Value.ToString();
            TxtResim.Text = DtGrdPersoneller.CurrentRow.Cells[7].Value.ToString();
            CmbSubeNo.Text = DtGrdPersoneller.CurrentRow.Cells[8].Value.ToString();

            PctResim.ImageLocation = DtGrdPersoneller.CurrentRow.Cells[7].Value.ToString();
        }

        private void MskTCNOAra_TextChanged(object sender, EventArgs e)
        {
            var query = (from x1 in db.TBLPERSONEL
                        join x2 in db.TBLSUBE
                        on x1.Sube_ID equals x2.Sube_ID
                        select new
                        {
                            Personel_ID = x1.Personel_ID,
                            TC = x1.Personel_TCNO,
                            AdıSoyadı = x1.Personel_AdiSoyadi,
                            DogumTarihi = x1.Personel_DogumTarihi,
                            Mail = x1.Personel_Mail,
                            Telefon = x1.Personel_Telefon,
                            Adresi = x1.Personel_Adresi,
                            Fotoğraf = x1.Personel_Fotograf,
                            Şube_Adı = x2.Sube_Adi,
                        }).Where(x => x.TC.Contains(MskTCNOAra.Text)).ToList();
            DtGrdPersoneller.DataSource = query.ToList();
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void PctPersonelKaydet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("KAYDET", PctPersonelKaydet);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctPersonelSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("SİL", PctPersonelSil);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctPersonelGuncelle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("DÜZENLE", PctPersonelGuncelle);
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
