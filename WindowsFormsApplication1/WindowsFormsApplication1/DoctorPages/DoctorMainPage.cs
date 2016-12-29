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
    public partial class DoctorMainPage : Form
    {
        private string tckimlik;
        public int doktorID;
        public int polID;
        public DoctorMainPage(string tckimlik)
        {
            InitializeComponent();
            this.tckimlik = tckimlik;
        }

        private void DoctorMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.globalForm.Show();
            Dispose();
        }

        private void DoctorMainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HASTA' table. You can move, or remove it, as needed.
            loadForm();
        }

        private void loadForm()
        {
            this.hASTATableAdapter.Fill(this.dataSet1.HASTA);
            DbConnection.execQuery("select * from doktor where tc_kimlik='" + tckimlik + "'");
            doktorID = Convert.ToInt32(DbConnection.dr["doktor_id"].ToString());
            adLabel.Text = DbConnection.dr["fname"].ToString();
            soyadLabel.Text = DbConnection.dr["lname"].ToString();
            tcLabel.Text = DbConnection.dr["tc_kimlik"].ToString();
            cinsiyetLabel.Text = DbConnection.dr["cinsiyet"].ToString();
            dogumTarihiLabel.Text = DbConnection.dr["dogum_tarihi"].ToString();
            cepTelLabel.Text = DbConnection.dr["cep_tel"].ToString();
            isTelLabel.Text = DbConnection.dr["is_tel"].ToString();
            adresLabel.Text = DbConnection.dr["adres"].ToString();
            bransLabel.Text = DbConnection.dr["brans"].ToString();
            unvanLabel.Text = DbConnection.dr["unvan"].ToString();
            polID = Convert.ToInt32(DbConnection.dr["pol_id"].ToString());
            DbConnection.execAdditionalQueryN("select pol_name from poliklinik where pol_id=" + Convert.ToInt32(DbConnection.dr["pol_id"].ToString()), 0);
            poliklinikLabel.Text = DbConnection.additionalDreaders[0]["pol_name"].ToString();

            string query = "SELECT DISTINCT HASTA_ID Hno, AD, SOYAD, TC_KIMLIK TCNo, CINSIYET Cinsiyet, SOSYALGUVENCE FROM HASTA,MUAYENE WHERE MUAYENE.DOKTOR_NO =" + doktorID + " AND MUAYENE.HASTA_NO = HASTA.HASTA_ID";
            DbConnection.createTable(query);
            DataTable table = new DataTable();
            table.Load(DbConnection.dr);
            hastalarDataGridView.DataSource = table;

            query = "select distinct m.m_no Mno, h.Hasta_id hno, h.ad, h.soyad, h.cinsiyet, h.sosyalguvence from hasta h, muayene m where m.doktor_no=" + doktorID + " AND m.teshis='-' AND h.hasta_id=m.hasta_no";
            DbConnection.createTable(query);
            DataTable table2 = new DataTable();
            table2.Load(DbConnection.dr);
            muayeneBekleyenHastalarDataGridView.DataSource = table2;
        }

        private void hastalarDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (hastalarDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = hastalarDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = hastalarDataGridView.Rows[selectedrowindex];
                int hastaNo = Convert.ToInt32(selectedRow.Cells["Hno"].Value);
                DoktorHastaBilgiPage bilgiPage = new DoktorHastaBilgiPage(hastaNo,doktorID);
                bilgiPage.ShowDialog();
            }

        }

        private void muayeneBekleyenHastalarDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (muayeneBekleyenHastalarDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = muayeneBekleyenHastalarDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = muayeneBekleyenHastalarDataGridView.Rows[selectedrowindex];
                int hastaNo = Convert.ToInt32(selectedRow.Cells["Hno"].Value);
                int Mno = Convert.ToInt32(selectedRow.Cells["Mno"].Value);
                HastaMuayeneForm muayeneForm = new HastaMuayeneForm(hastaNo, doktorID, Mno, polID);
                muayeneForm.ShowDialog();
            }
        }

        private void DoctorMainPage_Activated(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
