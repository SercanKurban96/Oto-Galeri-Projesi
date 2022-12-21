using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oto_Galeri_Projesi
{
    public partial class FrmSubeler : Form
    {
        public FrmSubeler()
        {
            InitializeComponent();
        }

        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        bool durum;
        void ayniKayitEngelleme()
        {
            var query = from x in db.TBLSUBE
                        where x.Sube_Adi == TxtSubeAdi.Text
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

        void Temizle()
        {
            TxtSubeNo.Clear();
            TxtSubeAdi.Clear();
            RchTxtSubeAdresi.Clear();
        }

        void Listele()
        {
            var query = from x in db.TBLSUBE
                        select new
                        {
                            Şube_ID = x.Sube_ID,
                            Şube_Adı = x.Sube_Adi,
                            Şube_Adresi = x.Sube_Adresi,
                        };
            DtgrdSubeler.DataSource = query.ToList();
        }

        private void PctGeri_Click(object sender, EventArgs e)
        {
            FrmOtoGaleri fr = new FrmOtoGaleri();
            fr.Show();
            this.Hide();
        }

        private void PctMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (TxtSubeAdi.Text == "" || RchTxtSubeAdresi.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ayniKayitEngelleme();
                if (durum == true)
                {
                    TBLSUBE sube = new TBLSUBE();
                    sube.Sube_Adi = TxtSubeAdi.Text;
                    sube.Sube_Adresi = RchTxtSubeAdresi.Text;
                    db.TBLSUBE.Add(sube);
                    db.SaveChanges();
                    MessageBox.Show("Şube Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show(TxtSubeAdi.Text + " adında bir Şube Adı zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PctMusteriSil_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtSubeNo.Text != "")
            {
                id = Convert.ToInt32(TxtSubeNo.Text);
                var sil = db.TBLSUBE.Find(id);

                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Seçilen şubeyi silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    db.TBLSUBE.Remove(sil);
                    db.SaveChanges();
                    MessageBox.Show("Şube silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                    TxtSubeAdi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir şube seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PctSubeGuncelle_Click(object sender, EventArgs e)
        {
            int id;
            if (TxtSubeNo.Text != "")
            {
                id = Convert.ToInt32(TxtSubeNo.Text);
                var guncelle = db.TBLSUBE.Find(id);

                guncelle.Sube_Adi = TxtSubeAdi.Text;
                guncelle.Sube_Adresi = RchTxtSubeAdresi.Text;
                db.SaveChanges();
                MessageBox.Show("Şube düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
                TxtSubeAdi.Focus();
            }
        }

        private void PctTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void TxtSubeAra_TextChanged(object sender, EventArgs e)
        {
            var query = (from x in db.TBLSUBE
                         select new
                         {
                             Şube_ID = x.Sube_ID,
                             Şube_Adı = x.Sube_Adi,
                             Şube_Adresi = x.Sube_Adresi,
                         }).Where(x => x.Şube_Adı.Contains(TxtSubeAra.Text)).ToList(); ;
            DtgrdSubeler.DataSource = query;
        }

        private void FrmSubeler_Load(object sender, EventArgs e)
        {
            TxtSubeAdi.Focus();
            Listele();
        }

        private void DtgrdSubeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtSubeNo.Text = DtgrdSubeler.CurrentRow.Cells[0].Value.ToString();
            TxtSubeAdi.Text = DtgrdSubeler.CurrentRow.Cells[1].Value.ToString();
            RchTxtSubeAdresi.Text = DtgrdSubeler.CurrentRow.Cells[2].Value.ToString();
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void PctSubeKaydet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("KAYDET", PctSubeKaydet);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctSubeSil_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("SİL", PctSubeSil);
            toolTip1.OwnerDraw = true;
            toolTip1.ForeColor = Color.Yellow;
            toolTip1.BackColor = Color.Blue;
        }

        private void PctSubeGuncelle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("DÜZENLE", PctSubeGuncelle);
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
