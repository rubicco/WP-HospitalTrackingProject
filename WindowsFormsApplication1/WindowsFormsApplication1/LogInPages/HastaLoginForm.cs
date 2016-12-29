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
    public partial class HastaLoginForm : Form
    {
        public HastaLoginForm()
        {
            InitializeComponent();
        }

        private void HastaLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.globalForm.Show();
            Dispose();
        }

        private void sorgulaButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PatientPages.hastaBilgiPage hbp = new PatientPages.hastaBilgiPage(tcTextBox.Text);
            hbp.ShowDialog();       
        }
    }
}
