﻿using System;
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
    public partial class DoctorLoginForm : Form
    {
        public DoctorLoginForm()
        {
            InitializeComponent();
        }

        private void DoctorLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.globalForm.Show();
            this.Close();
        }
    }
}
