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
    public partial class FrmKiraSozlesmesi : Form
    {
        public FrmKiraSozlesmesi()
        {
            InitializeComponent();
        }
        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        public void PersonelListele()
        {
            var query = from x1 in db.TBLPERSONEL
                        join x2 in db.TBLSUBE
                        on x1.Sube_ID equals x2.Sube_ID
                        select new
                        {
                            Personel_ID = x1.Personel_ID,
                            TC = x1.Personel_TCNO,
                            AdıSoyadı = x1.Personel_AdiSoyadi,
                            ŞubeAdı = x2.Sube_Adi,
                        };
            DtGrdPersoneller.DataSource = query.ToList();
            using (EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities())
            {
                CmbSubeNo.DataSource = db.TBLSUBE.ToList();
                CmbSubeNo.ValueMember = "Sube_ID";
                CmbSubeNo.DisplayMember = "Sube_Adi";
            }
        }

        public void MusteriListele()
        {
            var query = from x in db.TBLMUSTERI
                        select new
                        {
                            Müşteri_ID = x.Musteri_ID,
                            TC = x.Musteri_TCNO,
                            AdıSoyadı = x.Musteri_AdiSoyadi,
                            EhliyetNo = x.Musteri_EhliyetNo,
                            EhliyetTarihi = x.Musteri_EhliyetTarihi,
                        };
            DtGrdMusteriler.DataSource = query.ToList();
        }

        public void BosAracListele()
        {
            var query = from x in db.TBLARAC where x.Arac_Durum == "BOŞ"
                        select new
                        {
                            Araç_ID = x.Arac_ID,
                            Plaka = x.Arac_Plaka,
                            Marka = x.Arac_Marka,
                            Model = x.Arac_Model,
                            Renk = x.Arac_Renk,
                            Üretim_Yılı = x.Arac_UretimYili,
                            Vites = x.Arac_Vites,
                            Yakıt = x.Arac_Yakit,
                            Fiyat = x.Arac_Fiyat,
                        };
            DtGrdAraclar.DataSource = query.ToList();
        }
        
        private void FrmSatisSozlesmesi_Load(object sender, EventArgs e)
        {
            PersonelListele();
            MusteriListele();
            BosAracListele();
        }

        private void PctSatis_Click(object sender, EventArgs e)
        {
            DateTime alinacak = new DateTime();
            DateTime verilecek = new DateTime();
            int personelNo = 0, musteriNo = 0, aracNo = 0, tutar = 0;

            alinacak = DtpCikisTarihi.Value;
            verilecek = DtpDonusTarihi.Value;

            try
            {
                tutar = int.Parse(TxtTutar.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Tutar Alanına Geçerli Bir Değer Girin");
            }

            if (alinacak >= verilecek)
            {
                MessageBox.Show("Verilecek Tarih Alınan Tarihten Daha İleri Olmalıdır");
            }
            else
            {
                try
                {
                    personelNo = int.Parse(DtGrdPersoneller.CurrentRow.Cells[0].Value.ToString());
                    musteriNo = int.Parse(DtGrdMusteriler.CurrentRow.Cells[0].Value.ToString());
                    aracNo = int.Parse(DtGrdAraclar.CurrentRow.Cells[0].Value.ToString());

                    TBLKIRA kira = new TBLKIRA();
                    kira.Personel_ID = personelNo;
                    kira.Arac_ID = aracNo;
                    kira.Musteri_ID = musteriNo;
                    kira.Kira_Ucreti = decimal.Parse(TxtKiraUcreti.Text);
                    kira.Kira_Gun = int.Parse(TxtGun.Text);
                    kira.Kira_AlimTarihi = alinacak;
                    kira.Kira_TeslimTarihi = verilecek;
                    kira.Kira_Tutar = decimal.Parse(TxtTutar.Text);
                    db.TBLKIRA.Add(kira);
                    db.SaveChanges();

                    var sonuc = (from x in db.TBLARAC
                                 where x.Arac_Durum == "BOŞ"
                                 select x).FirstOrDefault();
                    sonuc.Arac_Durum = "DOLU";
                    db.SaveChanges();
                    MessageBox.Show("Araç Kiralandı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    BosAracListele();
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen seçim yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void DtGrdMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMusteriID.Text = DtGrdMusteriler.CurrentRow.Cells[0].Value.ToString();
            MskTxtTCNO.Text = DtGrdMusteriler.CurrentRow.Cells[1].Value.ToString();
            TxtMusteriAdiSoyadi.Text = DtGrdMusteriler.CurrentRow.Cells[2].Value.ToString();
            TxtEhliyetNo.Text = DtGrdMusteriler.CurrentRow.Cells[3].Value.ToString();
            DtpEhliyetTarihi.Text = DtGrdMusteriler.CurrentRow.Cells[4].Value.ToString();
        }

        private void DtGrdAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAracID.Text = DtGrdAraclar.CurrentRow.Cells[0].Value.ToString();
            TxtPlaka.Text = DtGrdAraclar.CurrentRow.Cells[1].Value.ToString();
            CmbMarka.Text = DtGrdAraclar.CurrentRow.Cells[2].Value.ToString();
            TxtModel.Text = DtGrdAraclar.CurrentRow.Cells[3].Value.ToString();
            TxtRenk.Text = DtGrdAraclar.CurrentRow.Cells[4].Value.ToString();
            TxtUretimYili.Text = DtGrdAraclar.CurrentRow.Cells[5].Value.ToString();
            CmbVites.Text = DtGrdAraclar.CurrentRow.Cells[6].Value.ToString();
            CmbYakit.Text = DtGrdAraclar.CurrentRow.Cells[7].Value.ToString();
            TxtFiyat.Text = DtGrdAraclar.CurrentRow.Cells[8].Value.ToString();
        }

        private void PctGeri_Click(object sender, EventArgs e)
        {
            FrmOtoGaleri fr = new FrmOtoGaleri();
            fr.Show();
            this.Hide();
        }

        private void DtGrdPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtPersonelID.Text = DtGrdPersoneller.CurrentRow.Cells[0].Value.ToString();
            MskTxtPersonelTCNO.Text = DtGrdPersoneller.CurrentRow.Cells[1].Value.ToString();
            TxtPersonelAdiSoyadi.Text = DtGrdPersoneller.CurrentRow.Cells[2].Value.ToString();
            CmbSubeNo.Text = DtGrdPersoneller.CurrentRow.Cells[3].Value.ToString();
        }

        private void PctHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan gunfarki = DtpDonusTarihi.Value - DtpCikisTarihi.Value;
                int gunfarki2 = gunfarki.Days;
                TxtGun.Text = gunfarki2.ToString();
                TxtTutar.Text = (gunfarki2 * int.Parse(TxtKiraUcreti.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void PctTemizle_Click(object sender, EventArgs e)
        {
            DtpCikisTarihi.Text = DateTime.Now.ToShortDateString();
            DtpDonusTarihi.Text = DateTime.Now.ToShortDateString();
            TxtKiraUcreti.Clear();
            TxtGun.Clear();
            TxtTutar.Clear();
        }
    }
}
