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
    public partial class FrmOtoGaleri : Form
    {
        public FrmOtoGaleri()
        {
            InitializeComponent();
        }
        void NotifyIcon()
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Oto Galeri Projesi";
            notifyIcon1.BalloonTipTitle = "Oto Galeri Projesi arka planda çalışıyor";
            notifyIcon1.BalloonTipText = "Program sağ alt köşede konumlandı.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);
            //notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
        }

        private void PctMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
            this.Hide();
        }

        private void PctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();

            NotifyIcon();
        }

        private void PctMinimize_MouseHover(object sender, EventArgs e)
        {
            PctMinimize.BackColor = Color.Blue;
        }

        private void PctMinimize_MouseLeave(object sender, EventArgs e)
        {
            PctMinimize.BackColor = Color.Transparent;
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            NotifyIcon();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz.", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void PctCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Programdan çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz.", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PctAraclar_Click(object sender, EventArgs e)
        {
            FrmAraclar fr = new FrmAraclar();
            fr.Show();
            this.Hide();
        }

        private void PctSubeler_Click(object sender, EventArgs e)
        {
            FrmSubeler fr = new FrmSubeler();
            fr.Show();
            this.Hide();
        }

        private void PctPersoneller_Click(object sender, EventArgs e)
        {
            FrmPersoneller fr = new FrmPersoneller();
            fr.Show();
            this.Hide();
        }

        private void PctRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlama fr = new FrmRaporlama();
            fr.Show();
            this.Hide();
        }

        private void PctSozlesme_Click(object sender, EventArgs e)
        {
            FrmKiraSozlesmesi fr = new FrmKiraSozlesmesi();
            fr.Show();
            this.Hide();
        }
    }
}
