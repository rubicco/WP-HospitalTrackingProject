using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void hastaneButton_Click(object sender, EventArgs e)
        {
            
            LogInPages.HospitalLoginForm loginPage = new LogInPages.HospitalLoginForm();
            loginPage.Show();
            Program.globalForm = this;
            this.Hide();           
            
            /*
            DbConnection.connect();
            DbConnection.execQuery("select POL_ID,POL_NAME FROM POLIKLINIK");
            DbConnection.execQuery("insert into POLIKLINIK(POL_ID,POL_NAME) VALUES(4,'asd')");
            DbConnection.dr.Read();
            //OracleDataReader dr1 = DbConnection.dr;
            
            MessageBox.Show( DbConnection.dr.GetValue(0).ToString(), "asdasd");
            
            MessageBox.Show(DbConnection.dr.GetString(1), "asdasd");
            DbConnection.dr.Read();
            MessageBox.Show(DbConnection.dr.GetValue(0).ToString(), "asdasd");
            MessageBox.Show(DbConnection.dr.GetString(1), "asdasd");

            /*
            string oradb = "Data Source=localhost:1521/XE;User Id=HOSP;Password=1234qwer;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select POL_NAME FROM POLIKLINIK WHERE POL_ID=1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show(dr.GetString(0), "asd");            
            conn.Dispose();
            */
        }

        private void doktorButton_Click(object sender, EventArgs e)
        {
            LogInPages.DoctorLoginForm loginPage = new LogInPages.DoctorLoginForm();
            loginPage.Show();
            Program.globalForm = this;
            this.Hide();
        }

        private void hastaButton_Click(object sender, EventArgs e)
        {
            LogInPages.HastaLoginForm loginPage = new LogInPages.HastaLoginForm();
            loginPage.Show();
            Program.globalForm = this;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
