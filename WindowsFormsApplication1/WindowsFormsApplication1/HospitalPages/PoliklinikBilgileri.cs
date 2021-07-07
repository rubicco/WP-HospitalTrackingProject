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
    public partial class PoliklinikBilgileri : Form
    {
        public PoliklinikBilgileri()
        {
            InitializeComponent();
        }
        
        private void PoliklinikBilgileri_Load(object sender, EventArgs e)
        {
            List<HospitalClass.Poliklinik> poliklinikler = new List<HospitalClass.Poliklinik>();
            List<HospitalClass.Patient> hastalar = new List<HospitalClass.Patient>();
            List<HospitalClass.Doctor> doktorlar = new List<HospitalClass.Doctor>();
            int docIndex = 0;
            int polIndex = 0;
            DbConnection.execQuery("SELECT * FROM POLIKLINIK ORDER BY POL_ID");
            do
            {
                HospitalClass.Poliklinik newPoliklinik = new HospitalClass.Poliklinik(Convert.ToInt32(DbConnection.dr["pol_id"].ToString()), DbConnection.dr["pol_name"].ToString());
                hastaneTreeView.Nodes.Add(newPoliklinik.poliklinikID.ToString() + "-" + newPoliklinik.poliklinikAdi);
                DbConnection.execAdditionalQueryN("SELECT doktor_id,fname,lname,pol_id FROM DOKTOR where pol_id="+newPoliklinik.poliklinikID+" ORDER BY doktor_id",0);
                if(DbConnection.additionalDreaders[0].HasRows==true)
                {
                    do
                    {
                        HospitalClass.Doctor newDoktor = new HospitalClass.Doctor(Convert.ToInt32(DbConnection.additionalDreaders[0]["doktor_id"].ToString()), DbConnection.additionalDreaders[0]["fname"].ToString(), DbConnection.additionalDreaders[0]["lname"].ToString(), Convert.ToInt32(DbConnection.additionalDreaders[0]["pol_id"].ToString()));
                        hastaneTreeView.Nodes[polIndex].Nodes.Add(newDoktor.doktorNo.ToString() + "-" + newDoktor.ad + " " + newDoktor.soyad);
                        DbConnection.execAdditionalQueryN("SELECT hasta_id,ad,soyad from hasta,muayene where doktor_no=" + newDoktor.doktorNo + " AND hasta_id=hasta_no", 1);
                        do
                        {
                            if (DbConnection.additionalDreaders[1].HasRows == true)
                            {
                                HospitalClass.Patient newHasta = new HospitalClass.Patient(Convert.ToInt32(DbConnection.additionalDreaders[1]["hasta_id"].ToString()), DbConnection.additionalDreaders[1]["ad"].ToString(), DbConnection.additionalDreaders[1]["soyad"].ToString());
                                hastaneTreeView.Nodes[polIndex].Nodes[docIndex].Nodes.Add(newHasta.hastaNo.ToString() + "-" + newHasta.ad + " " + newHasta.soyad);
                            }
                        } while (DbConnection.additionalDreaders[1].Read());
                        doktorlar.Add(newDoktor);
                        docIndex++;
                    } while (DbConnection.additionalDreaders[0].Read());
                }
                poliklinikler.Add(newPoliklinik);
                polIndex++;
                docIndex = 0;
            } while (DbConnection.dr.Read());

            DbConnection.execQuery("select count(*) from poliklinik");
            int poliklinikSayisi = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());

            DbConnection.execQuery("select count(*) from doktor");
            int doktorSayisi = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());

            DbConnection.execQuery("select count(*) from hasta");
            int hastaSayisi = Convert.ToInt32(DbConnection.dr.GetValue(0).ToString());

            poliklinikSayisiLabel.Text = "Poliklinik Sayısı: " + poliklinikSayisi;
            doktorSayisiLabel.Text = "Doktor Sayısı: " + doktorSayisi;
            hastaSayisiLabel.Text = "Hasta Sayısı: " + hastaSayisi;
        }

    }
}
