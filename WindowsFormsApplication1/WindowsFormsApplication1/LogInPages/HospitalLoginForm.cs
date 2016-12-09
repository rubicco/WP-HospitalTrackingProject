using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.LogInPages
{
    public partial class HospitalLoginForm : Form
    {
        public HospitalLoginForm()
        {
            InitializeComponent();
        }

        private void HospitalLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.globalForm.Show();
            Dispose();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiTextBox.Text == "")
            {
                MessageBox.Show("Kullanıcı adı sahası boş bırakılamaz!", "Eksik Saha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            if (parolaTextBox.Text == "")
                MessageBox.Show("Şifre sahası boş bırakılamaz!", "Eksik Saha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
