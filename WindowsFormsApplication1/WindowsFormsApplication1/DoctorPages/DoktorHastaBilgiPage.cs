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
    public partial class DoktorHastaBilgiPage : Form
    {
        public int hastaNo;
        public int doktorNo;
        public List<int> muayeneNoArr;
                
        public DoktorHastaBilgiPage(int hastaNo,int doktorNo)
        {
            InitializeComponent();
            this.hastaNo = hastaNo;
            this.doktorNo = doktorNo;
            muayeneNoArr = new List<int>();
        }

        private void DoktorHastaBilgiPage_Load(object sender, EventArgs e)
        {
            DbConnection.execQuery("select * from hasta where hasta_id=" + hastaNo);
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
            muayenelerListView.View = View.Details;
            muayenelerListView.Columns.Add("M.No", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("M.Tarihi", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("Şikayet", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("Bulgu", 100, HorizontalAlignment.Left);
            muayenelerListView.Columns.Add("Teşhis", 100, HorizontalAlignment.Left);

            int count = 0;
            DbConnection.execQuery("select M_NO, SIKAYET, BULGU, TESHIS, M_TARIHI FROM MUAYENE WHERE HASTA_NO=" + hastaNo + " and doktor_no=" + doktorNo);
            do
            {
                muayeneNoArr.Add(Convert.ToInt32(DbConnection.dr["M_no"].ToString()));
                muayenelerListView.Items.Add(DbConnection.dr["M_no"].ToString());
                muayenelerListView.Items[count].SubItems.Add(DbConnection.dr["M_TARIHI"].ToString());
                muayenelerListView.Items[count].SubItems.Add(DbConnection.dr["SIKAYET"].ToString());
                muayenelerListView.Items[count].SubItems.Add(DbConnection.dr["BULGU"].ToString());
                muayenelerListView.Items[count++].SubItems.Add(DbConnection.dr["TESHIS"].ToString());
            } while (DbConnection.dr.Read());

            DbConnection.execQuery("select text from hasta_dosyasi where hasta_no=" + hastaNo);
            if (DbConnection.dr.HasRows != false)
                hastaDosyaTextBox.Text = DbConnection.dr["text"].ToString();


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            hastaDosyaTextBox.Text = "";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DbConnection.execQuery("select text from hasta_dosyasi where hasta_no=" + hastaNo);
            if (DbConnection.dr.HasRows != false)
                DbConnection.execQuery("update hasta_dosyasi set text='" + hastaDosyaTextBox.Text + "' where hasta_no=" + hastaNo);
            else
            {
                String query = String.Format("insert into hasta_dosyasi(hasta_no, text) values({0}, '{1}')", hastaNo, hastaDosyaTextBox.Text);
                DbConnection.execQuery(query);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yazdırma kuyruğuna gönderildi!", "YAZDIRILDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear Butonu metni siler.\nKaydet butonu eğer hasta dosyası varsa günceller, yoksa yeni yaratır.\nYazdır butonu texti yazdırma kuyruğuna gönderir.", "YAZDIRILDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seciliMuayeneKarsilastirButton_Click(object sender, EventArgs e)
        {
            
            List<int> muayeneNoSelectedArr = new List<int>();
            for(int i =0; i < muayenelerListView.SelectedItems.Count; i++)
            {
                muayeneNoSelectedArr.Add(Convert.ToInt32(muayenelerListView.SelectedItems[i].SubItems[0].Text));
            }
            MuayeneKarsilastirmaMDI mdi = new MuayeneKarsilastirmaMDI(muayeneNoArr, muayeneNoSelectedArr);
            mdi.Show();
        }
    }
}
