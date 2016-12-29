using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PatientPages
{
    public partial class hastaBilgiPage : Form
    {
        public string tcKimlik;
        public int hastaNo;
        public hastaBilgiPage(string tcKimlik)
        {
            InitializeComponent();
            this.tcKimlik = tcKimlik;
        }

        private void hastaBilgiPage_Load(object sender, EventArgs e)
        {
            DbConnection.execQuery("select * from hasta where tc_kimlik='" + tcKimlik + "'");
            adLabel.Text = DbConnection.dr["ad"].ToString();
            soyadLabel.Text = DbConnection.dr["soyad"].ToString();
            tcLabel.Text = DbConnection.dr["tc_kimlik"].ToString();
            cinsiyetLabel.Text = DbConnection.dr["cinsiyet"].ToString();
            dogumTarihiLabel.Text = DbConnection.dr["dogum_tarihi"].ToString();
            cepTelLabel.Text = DbConnection.dr["cep_no"].ToString();
            isTelLabel.Text = DbConnection.dr["is_no"].ToString();
            mailLabel.Text = DbConnection.dr["email"].ToString();
            adresLabel.Text = DbConnection.dr["adres"].ToString();
            sosyalguvLabel.Text = DbConnection.dr["sosyalguvence"].ToString();
            hastaNoLabel.Text = DbConnection.dr["hasta_id"].ToString();
            hastaNo = Convert.ToInt32(hastaNoLabel.Text);

            muayenelerListView.View = View.Details;
            muayenelerListView.Columns.Add("M.No", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("M.Tarihi", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("Şikayet", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("Bulgu", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("Teşhis", 100, HorizontalAlignment.Left);

            int count = 0;
            DbConnection.execQuery("select M_NO, SIKAYET, BULGU, TESHIS, M_TARIHI FROM MUAYENE WHERE HASTA_NO=" + hastaNoLabel.Text);
            do
            {
                muayenelerListView.Items.Add(DbConnection.dr["M_no"].ToString());
                muayenelerListView.Items[count].SubItems.Add(DbConnection.dr["M_TARIHI"].ToString());
                muayenelerListView.Items[count].SubItems.Add(DbConnection.dr["SIKAYET"].ToString());
                muayenelerListView.Items[count].SubItems.Add(DbConnection.dr["BULGU"].ToString());
                muayenelerListView.Items[count++].SubItems.Add(DbConnection.dr["TESHIS"].ToString());
            } while (DbConnection.dr.Read());
        }

        private void hastaBilgiPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.globalForm.Show();
            Dispose();
        }

        private void muayenelerListView_DoubleClick(object sender, EventArgs e)
        {
            if (muayenelerListView.SelectedItems.Count == 1)
            {
                string mno = muayenelerListView.SelectedItems[0].SubItems[0].Text;
                DoctorPages.MuayeneBilgiPage mbp = new DoctorPages.MuayeneBilgiPage(Convert.ToInt32(mno));
                mbp.Show();
            }
        }
    }
}
