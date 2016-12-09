using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void hastaneButton_Click(object sender, EventArgs e)
        {
            LogInPages.HospitalLoginForm loginPage = new LogInPages.HospitalLoginForm();
            loginPage.Show();
            Program.globalForm = this;
            this.Hide();
        }

        private void doktorButton_Click(object sender, EventArgs e)
        {
            LogInPages.DoctorLoginForm loginPage = new LogInPages.DoctorLoginForm();
            loginPage.Show();
            Program.globalForm = this;
            this.Hide();
        }

        private void hastaButton_Click(object sender, EventArgs e)
        {
            LogInPages.HastaLoginForm loginPage = new LogInPages.HastaLoginForm();
            loginPage.Show();
            Program.globalForm = this;
            this.Hide();
        }
    }
}
