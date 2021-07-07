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
    public partial class HastaKabul : Form
    {
        public HastaKabul()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (adresTextBox.Text == "" || soyadTextBox.Text == "" || adTextBox.Text == "" || soyadTextBox.Text == "" || TCKimlikNoTextBox.Text == "" || sosyalGuvenceComboBox.Text == "" || hastaDogumTarihiDateTimePicker.Text == "")
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılmamalıdır!");
                return;
            }
            if(!erkekRadioButton.Checked && !kadinRadioButton.Checked)
            {
                MessageBox.Show("Lütfen Cinsiyet Alanını Seçiniz!");
                return;
            }
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string cinsiyet="";
            if (erkekRadioButton.Checked)
                cinsiyet = "E";
            if (kadinRadioButton.Checked)
                cinsiyet = "K";
            string TCkimlik = TCKimlikNoTextBox.Text;
            DbConnection.execQuery("select ad from hasta where tc_kimlik='" + TCkimlik + "'");
            if (DbConnection.dr.HasRows == true)
            {
                MessageBox.Show(TCkimlik + " kimliğine sahip hasta zaten var.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            string cepTel = cepTelTextBox.Text;
            string isTel = isTelTextBox.Text;
            string meslek = meslekTextBox.Text;
            string adres = adresTextBox.Text;
            string email = emailTextBox.Text;
            string sosyalGuvence = sosyalGuvenceComboBox.Text;
            DateTime date = hastaDogumTarihiDateTimePicker.Value;
            string dTarihi = date.ToString("dd/MM/yyyy"); //19/12/2016

            DbConnection.execQuery("select hasta_no from system_table");
            //DbConnection.dr.Read();
            int hasta_no = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());           
            String query = String.Format("insert into HASTA(HASTA_ID, AD, SOYAD, TC_KIMLIK,CINSIYET,DOGUM_TARIHI,CEP_NO,IS_NO,MESLEK,ADRES,EMAIL,SOSYALGUVENCE) VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", hasta_no, ad, soyad, TCkimlik, cinsiyet, dTarihi, cepTel, isTel, meslek, adres, email,sosyalGuvence);
            DbConnection.execQuery(query);
            hasta_no++;
            DbConnection.execQuery("UPDATE SYSTEM_TABLE SET HASTA_NO=" + hasta_no);
            Dispose();
        }
    }
}
