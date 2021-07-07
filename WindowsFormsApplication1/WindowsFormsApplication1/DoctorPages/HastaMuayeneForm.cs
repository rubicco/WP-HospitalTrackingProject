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
    public partial class HastaMuayeneForm : Form
    {
        public int hastaNo;
        public int doktorNo;
        public int muayeneNo;
        public int polID;
        public HastaMuayeneForm(int hno,int dno, int mno,int pid)
        {
            InitializeComponent();
            hastaNo = hno;
            doktorNo = dno;
            muayeneNo = mno;
            polID = pid;
        }

        private void HastaMuayeneForm_Load(object sender, EventArgs e)
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
            mNoLabel.Text = muayeneNo.ToString();
            DbConnection.execQuery("select m_tarihi,sikayet from muayene where m_no=" + muayeneNo);
            tarihLabel.Text = DbConnection.dr["m_tarihi"].ToString();
            sikayetTextBox.Text = DbConnection.dr["sikayet"].ToString();
            DbConnection.execQuery("select * from tahliller where pol_id=" + polID + " or pol_id=-1 order by tahlil_no");
            do
            {
                string tetkikNo = DbConnection.dr["tahlil_no"].ToString();
                string minVal = DbConnection.dr["min_val"].ToString();
                string maxVal = DbConnection.dr["max_val"].ToString();
                string tetkikName = DbConnection.dr["tahlil_adi"].ToString();
                if(minVal!="" || maxVal!="")
                    tetkiklerCheckedListBox.Items.Add(tetkikNo + ". " + tetkikName + " (" + minVal + "-" + maxVal + ")");
                else
                    tetkiklerCheckedListBox.Items.Add(tetkikNo + ". " + tetkikName);
            } while (DbConnection.dr.Read());

            DbConnection.execQuery("select * from tani where pol_no=" + polID + " order by icd_no");
            do
            {
                string icdNo = DbConnection.dr["icd_no"].ToString();
                string icdName = DbConnection.dr["icd_adi"].ToString();
                teshisListBox.Items.Add(icdNo + ". " + icdName);
            } while (DbConnection.dr.Read());

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            string sikayet = sikayetTextBox.Text;
            string bulgu = bulguTextBox.Text;
            string teshis = teshisListBox.SelectedItem.ToString();
            teshis = teshis.Substring(3, teshis.Length-3);


            DbConnection.execQuery("update muayene set bulgu='" + bulgu + "', teshis='" + teshis + "', sikayet='" + sikayet + "' where m_no=" + muayeneNo);

            for (int i=0; i< tetkiklerCheckedListBox.CheckedItems.Count; i++)
            {
                string tahlil = tetkiklerCheckedListBox.CheckedItems[i].ToString();
                int tahlilNo = Convert.ToInt32(tahlil.ElementAt(0))-48;
                DbConnection.execQuery("insert into yapilan_tahliller(m_no,tahlil_no) values(" + muayeneNo + "," + tahlilNo + ")");
            }
            MessageBox.Show("Muayene bilgileri başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }
    }
}
