using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    internal class ClsConexion
    {


        public DataSet Consultas( string Comando)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security= true");
            DataSet dsa = new DataSet();
            sqlCon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);
            sqlDA.Fill(dsa, "Tabla");

            dsa.Dispose();
            sqlCon.Dispose();
            sqlDA.Dispose();

            return dsa;
        }

        public void Grids (string Comando, DataGridView dgv)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security= true");
            DataSet dsa = new DataSet();            
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);
            sqlDA.Fill(dsa, "Tabla");

            dgv.DataSource = dsa.Tables[0];

            dsa.Dispose();
            sqlCon.Dispose();
            sqlDA.Dispose();
        }

        public bool Modificaciones(string Comando)
          {
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security= true");
   
            SqlCommand sqlCmd = new SqlCommand(Comando, sqlCon);

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            sqlCmd.Dispose();
            sqlCon.Dispose();

            return true;

        }

    }
}
