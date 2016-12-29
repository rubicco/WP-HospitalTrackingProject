using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.HospitalPages
{
    public partial class HospitalMainPage : Form
    {
        public HospitalMainPage()
        {
            InitializeComponent();
        }

        private void HospitalMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.globalForm.Show();
            Dispose();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişim Bilgileri:\nEmail: myname@domain.com\nTelefon: 0(232)1112233\nAdres: asdasdasdasdasdasdasd","İletişim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hastaKabulButton_Click(object sender, EventArgs e)
        {
            hastaKabulFormAcma();
        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastaKabulFormAcma();
        }

        private void hastaKabulFormAcma()
        {
            HastaKabul hastaKabulForm = new HastaKabul();
            hastaKabulForm.ShowDialog();
        }

        private void hastaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hastaDuzenleFormAcma();
        }
        
        private void hastaDuzenleFormAcma()
        {
            HastaDuzenle hastaDuzenleForm = new HastaDuzenle();
            hastaDuzenleForm.ShowDialog();
        }

        private void hastaDuzenleButton_Click(object sender, EventArgs e)
        {
            hastaDuzenleFormAcma();
        }

        private void doktorEkleButton_Click(object sender, EventArgs e)
        {
            doktorEkleFormAcma();
        }

        private void doktorDuzenleButton_Click(object sender, EventArgs e)
        {
            doktorDuzenleFormAcma();
        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doktorEkleFormAcma();
        }

        private void doktorDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doktorDuzenleFormAcma();
        }

        private void doktorEkleFormAcma()
        {
            DoktorEkle doktorEkleForm = new DoktorEkle();
            doktorEkleForm.ShowDialog();
        }

        private void doktorDuzenleFormAcma()
        {
            DoktorDuzenle doktorDuzenleForm = new DoktorDuzenle();
            doktorDuzenleForm.ShowDialog();
        }

        private void poliklinikEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            poliklinikEkleFormAcma();
        }

        private void poliklinikEkleButton_Click(object sender, EventArgs e)
        {
            poliklinikEkleFormAcma();
        }

        private void poliklinikEkleFormAcma()
        {
            PoliklinikEkle poliklinikEkleForm = new PoliklinikEkle();
            poliklinikEkleForm.ShowDialog();
        }

        private void muayeneEkleButton_Click(object sender, EventArgs e)
        {
            muayeneEkleFormAcma();
        }

        private void muayeneEkleFormAcma()
        {
            MuayeneEkle muayeneEkleForm = new MuayeneEkle();
            muayeneEkleForm.ShowDialog();
        }

        private void muayeneEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muayeneEkleFormAcma();
        }

        private void poliklinikBilgiButton_Click(object sender, EventArgs e)
        {
            poliklinikBilgileriForm();
        }

        private void poliklinikBilgileriForm()
        {
            PoliklinikBilgileri pbForm = new PoliklinikBilgileri();
            pbForm.ShowDialog();
        }

        private void poliklinikBilgisiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poliklinikBilgileriForm();
        }
    }
}
