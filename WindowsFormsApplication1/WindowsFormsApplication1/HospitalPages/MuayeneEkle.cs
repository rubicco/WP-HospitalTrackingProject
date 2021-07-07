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
    public partial class MuayeneEkle : Form
    {
        public MuayeneEkle()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(muayeneEkleTCKimlikTextBox.Text == "" || muayeneEklePoliklinikComboBox.Text == "" || muayeneDoktorListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
                return;
            }
            string tcKimlik = muayeneEkleTCKimlikTextBox.Text;         
            DateTime date = muayeneTarihiDateTimePicker.Value;
            string muayeneTarihi = date.ToString("dd/MM/yyyy");
            string poliklinik = muayeneEklePoliklinikComboBox.Text;
            string doktor = muayeneDoktorListBox.SelectedItem.ToString();
            string sikayet = muayeneSikayetTextBox.Text;
            string bos = "-";

            DbConnection.execQuery("select hasta_id from hasta where tc_kimlik='" + tcKimlik + "'");
            if (DbConnection.dr.HasRows == false)
            {
                MessageBox.Show(tcKimlik + " kimliğine sahip hasta bulunmamakta.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
                return;
            }                
            int hasta_no = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            DbConnection.execQuery("select muayene_no from system_table");
            int muayene_no = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());            
            DbConnection.execQuery("select pol_id from poliklinik where pol_name='" + poliklinik + "'");
            int polID = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            string[] adSoyad = doktor.Split(' ');
            DbConnection.execQuery("select doktor_id from doktor where fname='" + adSoyad[0] + "' and lname='" + adSoyad[1] + "'");
            int doktor_no = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            String query = String.Format("insert into muayene(M_NO, HASTA_NO, DOKTOR_NO, SIKAYET, BULGU, POL_NO, TESHIS, M_TARIHI) values({0}, {1}, {2}, '{3}', '{4}', {5}, '{6}', '{7}')", muayene_no, hasta_no, doktor_no, sikayet, bos, polID, bos, muayeneTarihi);
            
            DbConnection.execQuery(query);
            muayene_no++;
            DbConnection.execQuery("update system_table set muayene_no=" + muayene_no);
            Dispose();
        }

        private void MuayeneEkle_Load(object sender, EventArgs e)
        {
            //DbConnection.connect();
            DbConnection.execQuery("select pol_no from system_table");
            int polSayisi = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            DbConnection.execQuery("select pol_name from poliklinik");
            for (int i = 0; i < polSayisi-1; i++)
            {
                muayeneEklePoliklinikComboBox.Items.Add(DbConnection.dr["pol_name"].ToString());
                DbConnection.dr.Read();
            }           
        }

        private void muayeneEklePoliklinikComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            muayeneDoktorListBox.Items.Clear();
            //DbConnection.connect();
            DbConnection.execQuery("select pol_id from poliklinik where pol_name='" + muayeneEklePoliklinikComboBox.SelectedItem.ToString() + "'");
            int polID = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            DbConnection.execQuery("select count(*) from doktor where pol_id = " + polID);
            int doktorSayisi = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            DbConnection.execQuery("select fname, lname from doktor where pol_id = " + polID);
            for(int i = 0; i < doktorSayisi; i++)
            {
                string adSoyad = DbConnection.dr["fname"].ToString() + " " + DbConnection.dr["lname"].ToString();
                muayeneDoktorListBox.Items.Add(adSoyad);
                DbConnection.dr.Read();
            }
        }
    }
}
