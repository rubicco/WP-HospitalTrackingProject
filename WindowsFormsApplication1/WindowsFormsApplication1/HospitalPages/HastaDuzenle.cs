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
    public partial class HastaDuzenle : Form
    {
        public HastaDuzenle()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (adresTextBox.Text == "" || sosyalGuvenceComboBox.Text == "")
            {
                MessageBox.Show("Yıldızlı Alanlar Boş Bırakılmamalıdır!");
                return;
            }

            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string cepTel = cepTelTextBox.Text;
            string isTel = isTelTextBox.Text;
            string meslek = meslekTextBox.Text;
            string adres = adresTextBox.Text;
            string email = emailTextBox.Text;
            string sosyalGuvence = sosyalGuvenceComboBox.Text;

            DbConnection.execQuery("UPDATE HASTA SET ad='" + ad + "',"
                                                 + "soyad='" + soyad + "',"
                                                 + "cep_no='" + cepTel + "',"
                                                 + "is_no='" + isTel + "',"
                                                 + "meslek='" + meslek + "',"
                                                 + "adres='" + adres + "',"
                                                 + "email='" + email + "',"
                                                 + "sosyalguvence='" + sosyalGuvence + "' "
                                                 + "where tc_kimlik='" + TCKimlikNoTextBox.Text+"'");
            MessageBox.Show("Hasta bilgileri başarıyla güncellendi!");
            Dispose();
        }

        private void guncelleButton_Click_1(object sender, EventArgs e)
        {
            string tcKimlik = TCinputMaskedTextBox.Text;
            DbConnection.execQuery("select * from hasta where tc_kimlik='" + tcKimlik + "'");
            if (DbConnection.dr.HasRows == false)
                MessageBox.Show(tcKimlik + " kimliğine sahip hasta bulunmamakta.", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                saveToolStripButton.Enabled = true;
                adTextBox.Enabled = true;
                soyadTextBox.Enabled = true;
                cepTelTextBox.Enabled = true;
                isTelTextBox.Enabled = true;
                meslekTextBox.Enabled = true;
                sosyalGuvenceComboBox.Enabled = true;
                adresTextBox.Enabled = true;
                emailTextBox.Enabled = true;

                adTextBox.Text = DbConnection.dr["ad"].ToString();
                soyadTextBox.Text = DbConnection.dr["soyad"].ToString();
                if (DbConnection.dr["cinsiyet"].ToString() == "E")
                    erkekRadioButton.Checked = true;
                else
                    kadinRadioButton.Checked = true;
                TCKimlikNoTextBox.Text = DbConnection.dr["tc_kimlik"].ToString();
                cepTelTextBox.Text = DbConnection.dr["cep_no"].ToString();
                isTelTextBox.Text = DbConnection.dr["is_no"].ToString();
                meslekTextBox.Text = DbConnection.dr["meslek"].ToString();
                adresTextBox.Text = DbConnection.dr["adres"].ToString();
                emailTextBox.Text = DbConnection.dr["email"].ToString();
                sosyalGuvenceComboBox.Text = DbConnection.dr["sosyalguvence"].ToString();
                string dTarihi = DbConnection.dr["dogum_tarihi"].ToString();
                DateTime date = DateTime.ParseExact(dTarihi, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                hastaDogumTarihiDateTimePicker.Value = date;
            }
        }
    }
}
