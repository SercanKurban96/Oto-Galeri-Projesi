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
    public partial class FrmAraclar : Form
    {
        public FrmAraclar()
        {
            InitializeComponent();
        }
        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        bool durum;
        void ayniKayitEngelleme()
        {
            var query = from x in db.TBLARAC
                        where x.Arac_Plaka == TxtPlaka.Text
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

        void Listele()
        {
            var query = from x1 in db.TBLSUBE
                        join x2 in db.TBLARAC
                        on x1.Sube_ID equals x2.Sube_ID
                        select new
                        {
                            Araç_ID = x2.Arac_ID,
                            Plaka = x2.Arac_Plaka,
                            Marka = x2.Arac_Marka,
                            Model = x2.Arac_Model,
                            Renk = x2.Arac_Renk,
                            Üretim_Yılı = x2.Arac_UretimYili,
                            Vites = x2.Arac_Vites,
                            Yakıt = x2.Arac_Yakit,
                            Fiyat = x2.Arac_Fiyat,
                            Fotoğraf = x2.Arac_Fotograf,
                            Durum = x2.Arac_Durum,
                            Şube_Adı = x1.Sube_Adi,
                        };
            DtgrdAraclar.DataSource = query.ToList();

            using (EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities())
            {
                CmbSubeNo.DataSource = db.TBLSUBE.ToList();
                CmbSubeNo.ValueMember = "Sube_ID";
                CmbSubeNo.DisplayMember = "Sube_Adi";
            }
        }

        void Temizle()
        {
            TxtAracNo.Clear();
            TxtPlaka.Clear();
            CmbMarka.ResetText();
            TxtModel.Clear();
            TxtRenk.Clear();
            TxtUretimYili.Clear();
            CmbYakit.ResetText();
            CmbVites.ResetText();
            TxtFiyat.Clear();
            TxtResim.Clear();
            PctResim.ImageLocation = "";
        }

        private void PctGeri_Click(object sender, EventArgs e)
        {
            FrmOtoGaleri fr = new FrmOtoGaleri();
            fr.Show();
            this.Hide();
        }

        private void FrmAraclar_Load(object sender, EventArgs e)
        {
            TxtPlaka.Focus();
            Listele();
        }

        private void PctAracKaydet_Click(object sender, EventArgs e)
        {
            TBLARAC arac = new TBLARAC();
            if (TxtPlaka.Text == "" || CmbMarka.Text == "" || TxtModel.Text == "" || TxtRenk.Text == ""
                || TxtUretimYili.Text == "" || CmbYakit.Text == "" || CmbVites.Text == ""
                || TxtFiyat.Text == "" || TxtResim.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CmbSubeNo.Text == "")
            {
                MessageBox.Show("Lütfen Şubeler bölümünden bir şube ekleyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ayniKayitEngelleme();
                if (durum == true)
                {
                    arac.Arac_Plaka = TxtPlaka.Text;
                    arac.Arac_Marka = CmbMarka.Text;
                    arac.Arac_Model = TxtModel.Text;
                    arac.Arac_Renk = TxtRenk.Text;
                    arac.Arac_UretimYili = int.Parse(TxtUretimYili.Text);
                    arac.Arac_Yakit = CmbYakit.Text;
                    arac.Arac_Vites = CmbVites.Text;
                    arac.Arac_Fiyat = decimal.Parse(TxtFiyat.Text);
                    arac.Arac_Fotograf = TxtResim.Text;
                    arac.Arac_Durum = "BOŞ";
                    arac.Sube_ID = Convert.ToInt32(CmbSubeNo.SelectedValue);
                    db.TBLARAC.Add(arac);
                    db.SaveChanges();
                    MessageBox.Show("Araç Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show(TxtPlaka.Text + " adında bir plaka zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        string musaitMi;
        private void PctAracSil_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtAracNo.Text != "")
            {
                id = Convert.ToInt32(TxtAracNo.Text);
                var sil = db.TBLARAC.Find(id);

                musaitMi = DtgrdAraclar.CurrentRow.Cells[10].Value.ToString();
                if (musaitMi == "DOLU")
                {
                    MessageBox.Show("Araba kiralama işleminde olduğu için silinemez.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Seçilen aracı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        db.TBLARAC.Remove(sil);
                        db.SaveChanges();
                        MessageBox.Show("Araç silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        Temizle();
                        PctResim.ImageLocation = "";
                        TxtPlaka.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir araç seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnResimYolu_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctResim.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }

        private void CmbSubeNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPlakaAra_TextChanged(object sender, EventArgs e)
        {
            var query = (from x1 in db.TBLARAC
                         join x2 in db.TBLSUBE
                         on x1.Sube_ID equals x2.Sube_ID

                         select new
                         {
                             Araç_ID = x1.Arac_ID,
                             Plaka = x1.Arac_Plaka,
                             Marka = x1.Arac_Marka,
                             Model = x1.Arac_Model,
                             Renk = x1.Arac_Renk,
                             Üretim_Yılı = x1.Arac_UretimYili,
                             Vites = x1.Arac_Vites,
                             Yakıt = x1.Arac_Yakit,
                             Fiyat = x1.Arac_Fiyat,
                             Fotoğraf = x1.Arac_Fotograf,
                             Durum = x1.Arac_Durum,
                             Şube_Adı = x2.Sube_Adi,
                         }).Where(x => x.Plaka.Contains(TxtPlakaAra.Text)).ToList();
            DtgrdAraclar.DataSource = query;

            using (EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities())
            {
                CmbSubeNo.DataSource = db.TBLSUBE.ToList();
                CmbSubeNo.ValueMember = "Sube_ID";
                CmbSubeNo.DisplayMember = "Sube_Adi";
            }
        }

        private void DtgrdAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAracNo.Text = DtgrdAraclar.CurrentRow.Cells[0].Value.ToString();
            TxtPlaka.Text = DtgrdAraclar.CurrentRow.Cells[1].Value.ToString();
            CmbMarka.Text = DtgrdAraclar.CurrentRow.Cells[2].Value.ToString();
            TxtModel.Text = DtgrdAraclar.CurrentRow.Cells[3].Value.ToString();
            TxtRenk.Text = DtgrdAraclar.CurrentRow.Cells[4].Value.ToString();
            TxtUretimYili.Text = DtgrdAraclar.CurrentRow.Cells[5].Value.ToString();
            CmbVites.Text = DtgrdAraclar.CurrentRow.Cells[6].Value.ToString();
            CmbYakit.Text = DtgrdAraclar.CurrentRow.Cells[7].Value.ToString();
            TxtFiyat.Text = DtgrdAraclar.CurrentRow.Cells[8].Value.ToString();
            TxtResim.Text = DtgrdAraclar.CurrentRow.Cells[9].Value.ToString();
            CmbSubeNo.Text = DtgrdAraclar.CurrentRow.Cells[11].Value.ToString();

            PctResim.ImageLocation = DtgrdAraclar.CurrentRow.Cells[9].Value.ToString();
        }

        private void PctAracGuncelle_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtAracNo.Text != "")
            {
                id = Convert.ToInt32(TxtAracNo.Text);
                var guncelle = db.TBLARAC.Find(id);

                guncelle.Arac_Plaka = TxtPlaka.Text;
                guncelle.Arac_Marka = CmbMarka.Text;
                guncelle.Arac_Model = TxtModel.Text;
                guncelle.Arac_Renk = TxtRenk.Text;
                guncelle.Arac_UretimYili = int.Parse(TxtUretimYili.Text);
                guncelle.Arac_Vites = CmbVites.Text;
                guncelle.Arac_Yakit = CmbYakit.Text;
                guncelle.Arac_Fiyat = decimal.Parse(TxtFiyat.Text);
                guncelle.Arac_Fotograf = TxtResim.Text;
                guncelle.Sube_ID = int.Parse(CmbSubeNo.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Araç düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
                PctResim.ImageLocation = "";
                TxtPlaka.Focus();
            }
        }

        private void PctTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PctAracKaydet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("KAYDET", PctAracKaydet);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctAracSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("SİL", PctAracSil);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctAracGuncelle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("DÜZENLE", PctAracGuncelle);
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

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void CmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbAraclar.SelectedIndex == 0)
            {
                Listele();
            }
            else if (CmbAraclar.SelectedIndex == 1)
            {
                var query = from x1 in db.TBLARAC
                            join x2 in db.TBLSUBE
                            on x1.Sube_ID equals x2.Sube_ID
                            where x1.Arac_Durum == "BOŞ"
                            select new
                            {
                                Araç_ID = x1.Arac_ID,
                                Plaka = x1.Arac_Plaka,
                                Marka = x1.Arac_Marka,
                                Model = x1.Arac_Model,
                                Renk = x1.Arac_Renk,
                                Üretim_Yılı = x1.Arac_UretimYili,
                                Vites = x1.Arac_Vites,
                                Yakıt = x1.Arac_Yakit,
                                Fiyat = x1.Arac_Fiyat,
                                Fotoğraf = x1.Arac_Fotograf,
                                Durum = x1.Arac_Durum,
                                Şube_Adı = x2.Sube_Adi,
                            };
                DtgrdAraclar.DataSource = query.ToList();
            }
            else if (CmbAraclar.SelectedIndex == 2)
            {
                var query = from x1 in db.TBLARAC
                            join x2 in db.TBLSUBE
                            on x1.Sube_ID equals x2.Sube_ID
                            where x1.Arac_Durum == "DOLU"
                            select new
                            {
                                Araç_ID = x1.Arac_ID,
                                Plaka = x1.Arac_Plaka,
                                Marka = x1.Arac_Marka,
                                Model = x1.Arac_Model,
                                Renk = x1.Arac_Renk,
                                Üretim_Yılı = x1.Arac_UretimYili,
                                Vites = x1.Arac_Vites,
                                Yakıt = x1.Arac_Yakit,
                                Fiyat = x1.Arac_Fiyat,
                                Fotoğraf = x1.Arac_Fotograf,
                                Durum = x1.Arac_Durum,
                                Şube_Adı = x2.Sube_Adi,
                            };
                DtgrdAraclar.DataSource = query.ToList();
            }
        }
    }
}
