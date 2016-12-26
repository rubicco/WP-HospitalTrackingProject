using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;
using System.Data;

namespace WindowsFormsApplication1
{
    public class DbConnection
    {
        public static OracleConnection conn;
        public static string oradb = "Data Source=localhost:1521/XE;User Id=hosp;Password=1234qwer;";
        public static OracleDataReader dr;

        public static void connect()
        {
            conn = new OracleConnection(oradb);  // C#
            conn.Open();
        }

        public static void execQuery(String query)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            dr.Read();
        }

        public void connection()
        {            
            conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select department_name from departments where department_id = 10";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //label1.Text = dr.GetString(0);
            conn.Dispose();
        }

    }
}
