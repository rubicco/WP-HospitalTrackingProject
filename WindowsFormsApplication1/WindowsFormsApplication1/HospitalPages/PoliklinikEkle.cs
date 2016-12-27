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
    public partial class PoliklinikEkle : Form
    {
        public PoliklinikEkle()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(poliklinikAdiTextBox.Text=="")
            {
                MessageBox.Show("Poliklinik Adını Boş Bırakmayınız!");
                return;
            }
            DbConnection.connect();
            DbConnection.execQuery("select pol_no from system_table");
            int pol_ID = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            String query = String.Format("insert into poliklinik(pol_id, pol_name) values({0}, '{1}')", pol_ID, poliklinikAdiTextBox.Text);
            DbConnection.execQuery(query);
            pol_ID++;
            DbConnection.execQuery("update system_table set pol_no=" + pol_ID);
            Dispose();
        }
    }
}
