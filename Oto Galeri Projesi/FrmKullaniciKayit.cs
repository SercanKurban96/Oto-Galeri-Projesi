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
    public partial class FrmKullaniciKayit : Form
    {
        public FrmKullaniciKayit()
        {
            InitializeComponent();
        }

        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        bool durum;
        void ayniKayitEngelleme()
        {
            var query = from x in db.TBLKULLANICI
                        where x.Kullanici_Adi == TxtKullaniciAdi.Text
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

        private void LnkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TBLKULLANICI kullanici = new TBLKULLANICI();
            if (TxtKullaniciAdi.Text == "" || TxtSifre.Text == "" || TxtSifreTekrar.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtSifre.Text != TxtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ayniKayitEngelleme();
                if (durum == true)
                {
                    kullanici.Kullanici_Adi = TxtKullaniciAdi.Text;
                    kullanici.Sifre = TxtSifre.Text;
                    kullanici.Sifre_Tekrar = TxtSifreTekrar.Text;
                    db.TBLKULLANICI.Add(kullanici);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt oluşturuldu, giriş ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmKullaniciGirisi fr = new FrmKullaniciGirisi();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(TxtKullaniciAdi.Text + " adında bir kullanıcı zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LnkLblIptal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullaniciGirisi fr = new FrmKullaniciGirisi();
            fr.Show();
            this.Hide();
        }

        private void LnkLblKayitOl_MouseHover(object sender, EventArgs e)
        {
            LnkLblKayitOl.LinkColor = Color.Lime;
        }

        private void LnkLblKayitOl_MouseLeave(object sender, EventArgs e)
        {
            LnkLblKayitOl.LinkColor = Color.Black;
        }

        private void LnkLblIptal_MouseHover(object sender, EventArgs e)
        {
            LnkLblIptal.LinkColor = Color.Red;
        }

        private void LnkLblIptal_MouseLeave(object sender, EventArgs e)
        {
            LnkLblIptal.LinkColor = Color.Black;
        }
    }
}
