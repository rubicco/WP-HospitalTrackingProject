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
    public partial class DoktorDuzenle : Form
    {
        public DoktorDuzenle()
        {
            InitializeComponent();
        }

        private void DoktorDuzenle_Load(object sender, EventArgs e)
        {
            
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            string tcKimlik = TCinputMaskedTextBox.Text;
            DbConnection.execQuery("select * from doktor where tc_kimlik='" + tcKimlik + "'");
            if (DbConnection.dr.HasRows == false)
                MessageBox.Show(tcKimlik + " kimliğine sahip doktor bulunmamakta.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                saveToolStripButton.Enabled = true;
                adTextBox.Enabled = true;
                soyadTextBox.Enabled = true;
                cepTelTextBox.Enabled = true;
                isTelTextBox.Enabled = true;
                adresTextBox.Enabled = true;
                unvanTextBox.Enabled = true;

                adTextBox.Text = DbConnection.dr["fname"].ToString();
                soyadTextBox.Text = DbConnection.dr["lname"].ToString();
                if (DbConnection.dr["cinsiyet"].ToString() == "E")
                    erkekRadioButton.Checked = true;
                else
                    kadinRadioButton.Checked = true;
                TCKimlikNoTextBox.Text = DbConnection.dr["tc_kimlik"].ToString();
                cepTelTextBox.Text = DbConnection.dr["cep_tel"].ToString();
                isTelTextBox.Text = DbConnection.dr["is_tel"].ToString();
                adresTextBox.Text = DbConnection.dr["adres"].ToString();
                bransTextBox.Text = DbConnection.dr["brans"].ToString();
                unvanTextBox.Text = DbConnection.dr["unvan"].ToString();
                DbConnection.execAdditionalQueryN("select pol_name from poliklinik where pol_id=" + Convert.ToInt32(DbConnection.dr["pol_id"].ToString()), 0);
                poliklinikComboBox.Text = DbConnection.additionalDreaders[0]["pol_name"].ToString();
                string dTarihi = DbConnection.dr["dogum_tarihi"].ToString();
                DateTime date = DateTime.ParseExact(dTarihi, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                doktorDogumTarihiDateTimePicker.Value = date;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (adresTextBox.Text == "")
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılmamalıdır!");
                return;
            }

            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string cepTel = cepTelTextBox.Text;
            string isTel = isTelTextBox.Text;
            string adres = adresTextBox.Text;
            string brans = bransTextBox.Text;
            string unvan = unvanTextBox.Text;

            DbConnection.execQuery("UPDATE DOKTOR SET fname='" + ad + "',"
                                                 + "lname='" + soyad + "',"
                                                 + "cep_tel='" + cepTel + "',"
                                                 + "is_tel='" + isTel + "',"
                                                 + "adres='" + adres + "',"
                                                 + "brans='" + brans + "',"
                                                 + "unvan='" + unvan + "' "
                                                 + "where tc_kimlik='" + TCKimlikNoTextBox.Text + "'");
            MessageBox.Show("Doktor bilgileri başarıyla güncellendi!");
            Dispose();
        }
    }
}
