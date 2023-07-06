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
        private const string ConnectionString = "Data Source=DESKTOP-914MB8I;Initial Catalog=SeminarioTickets;Integrated Security=True";

        public DataSet Consultas( string Comando)
        {
            DataSet dsa = new DataSet();
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-914MB8I;Initial Catalog=SeminarioTickets;Integrated Security=True");
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
            DataSet dsa = new DataSet();
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-914MB8I;Initial Catalog=SeminarioTickets;Integrated Security=True");
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);
            sqlDA.Fill(dsa, "Tabla");

            dgv.DataSource = dsa.Tables[0];

            dsa.Dispose();
            sqlCon.Dispose();
            sqlDA.Dispose();
        }

        public bool Modificaciones(string Comando)
        {
            SqlConnection sqlCon = new SqlConnection(ConnectionString);
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
