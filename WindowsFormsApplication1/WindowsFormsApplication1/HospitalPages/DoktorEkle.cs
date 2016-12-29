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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (adresTextBox.Text == "" || soyadTextBox.Text == "" || adTextBox.Text == "" || soyadTextBox.Text == "" || TCKimlikNoTextBox.Text == "" || poliklinikComboBox.Text == "" || bransTextBox.Text == "" || unvanTextBox.Text == "")
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılmamalıdır!");
                return;
            }
            if (!erkekRadioButton.Checked && !kadinRadioButton.Checked)
            {
                MessageBox.Show("Lütfen Cinsiyet Alanını Seçiniz!");
                return;
            }
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string cinsiyet = "";
            if (erkekRadioButton.Checked)
                cinsiyet = "E";
            if (kadinRadioButton.Checked)
                cinsiyet = "K";
            string TCkimlik = TCKimlikNoTextBox.Text;
            string cepTel = cepTelTextBox.Text;
            string isTel = isTelTextBox.Text;
            string adres = adresTextBox.Text;
            string email = emailTextBox.Text;
            DateTime date = doktorDogumTarihiDateTimePicker.Value;
            string dTarihi = date.ToString("dd/MM/yyy");
            string poliklinik = poliklinikComboBox.Text;
            string brans = bransTextBox.Text;
            string unvan = unvanTextBox.Text;
            
            DbConnection.execQuery("SELECT POL_ID FROM POLIKLINIK WHERE POL_NAME='" + poliklinik + "'");
            int polID = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            DbConnection.execQuery("select doktor_no from system_table");
            int doktor_no = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            String query = String.Format("insert into DOKTOR(DOKTOR_ID, TC_KIMLIK, FNAME, LNAME, CINSIYET, CEP_TEL, IS_TEL, ADRES, BRANS, UNVAN, POL_ID, DOGUM_TARIHI) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10},'{11}')", doktor_no, TCkimlik, ad, soyad, cinsiyet, cepTel, isTel, adres, brans, unvan, polID, dTarihi);
            DbConnection.execQuery(query);
            doktor_no++;
            DbConnection.execQuery("UPDATE SYSTEM_TABLE SET DOKTOR_NO=" + doktor_no);
            Dispose();
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            //DbConnection.connect();
            DbConnection.execQuery("select pol_no from system_table");
            int polSayisi = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());
            DbConnection.execQuery("select pol_name from poliklinik");
            for (int i = 0; i < polSayisi - 1; i++)
            {
                poliklinikComboBox.Items.Add(DbConnection.dr["pol_name"].ToString());
                DbConnection.dr.Read();
            }
        }
    }
}
