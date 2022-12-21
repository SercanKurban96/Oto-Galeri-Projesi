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
    public partial class FrmKullaniciGirisi : Form
    {
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }

        EF_DbAutoGalleryEntities db = new EF_DbAutoGalleryEntities();

        private void LnkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKullaniciKayit fr = new FrmKullaniciKayit();
            fr.Show();
            this.Hide();
        }

        private void LnkLblGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var query = from x in db.TBLKULLANICI
                        where x.Kullanici_Adi == TxtKullaniciAdi.Text &
                        x.Sifre == TxtSifre.Text
                        select x;
            if (query.Any())
            {
                MessageBox.Show("Giriş başarılı, Oto Galeri'ye yönlendiriliyorsunuz.", "Hoş geldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmOtoGaleri fr = new FrmOtoGaleri();
                fr.Show();
                this.Hide();
            }
            else if (TxtKullaniciAdi.Text == "" || TxtSifre.Text == "")
            {
                MessageBox.Show("Alanlar boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkLblTemizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TxtKullaniciAdi.Clear();
            TxtSifre.Clear();
            TxtKullaniciAdi.Focus();
        }

        private void PctCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PctCikis_MouseHover(object sender, EventArgs e)
        {
            PctCikis.BackColor = Color.Red;
        }

        private void PctCikis_MouseLeave(object sender, EventArgs e)
        {
            PctCikis.BackColor = Color.Transparent;
        }

        private void FrmKullaniciGirisi_Load(object sender, EventArgs e)
        {
            TxtKullaniciAdi.Focus();
        }

        private void ChkSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar)
            {
                TxtSifre.UseSystemPasswordChar = false;
                ChkSifre.Text = "Şifreyi Gizle";
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
                ChkSifre.Text = "Şifreyi Göster";
            }
        }
    }
}
