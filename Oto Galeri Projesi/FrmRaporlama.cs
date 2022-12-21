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
    public partial class FrmRaporlama : Form
    {
        public FrmRaporlama()
        {
            InitializeComponent();
        }

        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        private void PctMusteriSirala_Click(object sender, EventArgs e)
        {
            List<TBLMUSTERI> liste = db.TBLMUSTERI.OrderBy(x => x.Musteri_AdiSoyadi).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctSon3MusteriKayit_Click(object sender, EventArgs e)
        {
            List<TBLMUSTERI> liste = db.TBLMUSTERI.OrderByDescending(x => x.Musteri_ID).Take(3).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctToplamMusteriSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Müşteri Sayısı: " + db.TBLMUSTERI.Count().ToString());
        }

        private void PctToplamAracSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Araç Sayısı: " + db.TBLARAC.Count().ToString());
        }

        private void PctEnPahaliArac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Pahalı Aracın Fiyatı: " + db.TBLARAC.Max(x=>x.Arac_Fiyat).ToString());
        }

        private void PctEnUcuzArac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Ucuz Aracın Fiyatı: " + db.TBLARAC.Min(x => x.Arac_Fiyat).ToString());
        }

        private void PctEnFazlaMarka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En Fazla Markaya Sahip Olan Araç: " + db.MARKAGETIR().FirstOrDefault());
        }

        private void PctToplamSubeSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Şube Sayısı: " + db.TBLSUBE.Count().ToString());
        }

        private void PctPersonelSirala_Click(object sender, EventArgs e)
        {
            List<TBLPERSONEL> liste = db.TBLPERSONEL.OrderBy(x => x.Personel_AdiSoyadi).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctSon3PersonelKayit_Click(object sender, EventArgs e)
        {
            List<TBLPERSONEL> liste = db.TBLPERSONEL.OrderByDescending(x => x.Personel_ID).Take(3).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PcToplamPersonelSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Personel Sayısı: " + db.TBLPERSONEL.Count().ToString());
        }

        private void PctSubeleriSirala_Click(object sender, EventArgs e)
        {
            List<TBLSUBE> liste = db.TBLSUBE.OrderBy(x => x.Sube_Adi).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctAraclariSirala_Click(object sender, EventArgs e)
        {
            List<TBLARAC> liste = db.TBLARAC.OrderBy(x => x.Arac_Plaka).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctGeri_Click(object sender, EventArgs e)
        {
            FrmOtoGaleri fr = new FrmOtoGaleri();
            fr.Show();
            this.Hide();
        }

        private void PctSon3SubeKayit_Click(object sender, EventArgs e)
        {
            List<TBLSUBE> liste = db.TBLSUBE.OrderByDescending(x => x.Sube_ID).Take(3).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctSon3AracKayit_Click(object sender, EventArgs e)
        {
            List<TBLARAC> liste = db.TBLARAC.OrderByDescending(x => x.Arac_ID).Take(3).ToList();
            DtGrdRaporlar.DataSource = liste;
        }

        private void PctYakitDizel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakıtı Dizel Olanların Sayısı: " + db.TBLARAC.Count(x => x.Arac_Yakit == "Dizel").ToString());
        }

        private void PctYakitBenzin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakıtı Benzin Olanların Sayısı: " + db.TBLARAC.Count(x => x.Arac_Yakit == "Benzin").ToString());
        }

        private void PctYakitBenzinLPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakıtı Benzin+LPG Olanların Sayısı: " + db.TBLARAC.Count(x => x.Arac_Yakit == "Benzin+LPG").ToString());
        }

        private void PctFarkliMarkaSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Farklı Marka Sayısı: " + (from x in db.TBLARAC select x.Arac_Marka).Distinct().Count().ToString());
        }

        private void FrmRaporlama_Load(object sender, EventArgs e)
        {

        }

        private void PctKiralananAraclar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kiralanan Araç Sayısı: " + db.TBLARAC.Count(x => x.Arac_Durum == "DOLU").ToString());
        }
    }
}
