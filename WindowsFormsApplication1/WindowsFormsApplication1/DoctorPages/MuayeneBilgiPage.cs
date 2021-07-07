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
    public partial class MuayeneBilgiPage : Form
    {
        public int muayeneNo;
        public int hastaNo;
        public int doktorNo;
        public MuayeneBilgiPage(int mno)
        {
            InitializeComponent();
            muayeneNo = mno;
        }

        private void MuayeneBilgiPage_Load(object sender, EventArgs e)
        {
            DbConnection.execQuery("select * from muayene where M_NO=" + muayeneNo);
            hastaNo = Convert.ToInt32(DbConnection.dr["hasta_no"].ToString());
            doktorNo = Convert.ToInt32(DbConnection.dr["doktor_no"].ToString());
            mNoLabel.Text = muayeneNo.ToString();
            tarihLabel.Text = DbConnection.dr["m_tarihi"].ToString();
            bulgularLabel.Text = DbConnection.dr["bulgu"].ToString();
            teshislerLabel.Text = DbConnection.dr["teshis"].ToString();
            sikayetLabel.Text = DbConnection.dr["sikayet"].ToString();

            DbConnection.execQuery("select * from yapilan_tahliller where M_NO=" + muayeneNo);
            if (DbConnection.dr.HasRows == true)
            {
                do
                {
                    int tahlilNo = Convert.ToInt32(DbConnection.dr["tahlil_no"].ToString());
                    int currVal = Convert.ToInt32(DbConnection.dr["curr_val"].ToString());
                    DbConnection.execAdditionalQueryN("select tahlil_adi from tahliller where tahlil_no=" + tahlilNo, 0);
                    string tahlilAdi = DbConnection.additionalDreaders[0]["tahlil_adi"].ToString();
                    tetkiklerListBox.Items.Add(tahlilAdi + " - Değer: " + currVal);
                } while (DbConnection.dr.Read());
            }            

            DbConnection.execQuery("select * from hasta where hasta_id=" + hastaNo);
            adLabel.Text = DbConnection.dr["ad"].ToString();
            soyadLabel.Text = DbConnection.dr["soyad"].ToString();
            tcLabel.Text = DbConnection.dr["tc_kimlik"].ToString();
            cinsiyetLabel.Text = DbConnection.dr["cinsiyet"].ToString();

            DbConnection.execQuery("select * from doktor where doktor_id=" + doktorNo);
            doktorAdLabel.Text = DbConnection.dr["fname"].ToString();
            doktorSoyadLabel.Text = DbConnection.dr["lname"].ToString();
            bransLabel.Text = DbConnection.dr["brans"].ToString();
            unvanLabel.Text = DbConnection.dr["unvan"].ToString();
            int polID = Convert.ToInt32(DbConnection.dr["pol_id"].ToString());
            DbConnection.execQuery("select pol_name from poliklinik where pol_id=" + polID);
            poliklinikLabel.Text = DbConnection.dr["pol_name"].ToString();
        }
    }
}
