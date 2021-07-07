using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.DoctorPages
{
    public partial class MuayeneKarsilastirmaMDI : Form
    {
        List<int> muayeneNoArr;
        List<int> muayeneNoSelectedArr;
        public MuayeneKarsilastirmaMDI(List<int> arr, List<int> arr2)
        {
            InitializeComponent();
            muayeneNoArr = arr;
            muayeneNoSelectedArr = arr2;
        }

        private void MuayeneKarsilastirmaMDI_Load(object sender, EventArgs e)
        {
            for(int i=0; i< muayeneNoArr.Count; i++)
            {
                muayenelerComboBox.Items.Add(muayeneNoArr.ElementAt(i));
            }

            for(int i = 0; i < muayeneNoSelectedArr.Count; i++)
            {
                int muayeneno = muayeneNoSelectedArr.ElementAt(i);                
                MuayeneBilgiPage mbp = new MuayeneBilgiPage(muayeneno);
                mbp.Text = muayeneno.ToString();
                mbp.MdiParent = this;
                mbp.Show();
            }
        }

        private void muayenelerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MuayeneBilgiPage mbp = new MuayeneBilgiPage(muayeneNoArr.ElementAt(muayenelerComboBox.SelectedIndex));
            mbp.Text = muayeneNoArr.ElementAt(muayenelerComboBox.SelectedIndex).ToString();
            mbp.MdiParent = this;
            mbp.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
