using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.seminarioTicketsDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.seminarioTicketsDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.seminarioTicketsDataSet.Empleados);

            CmbEmpleado.SelectedIndex = -1;
            CmbCliente.SelectedIndex = -1;

            string connectionString = "Data Source = PC-GUEVARA\\SQLEXPRESS; Initial Catalog = SeminarioTickets; Integrated Security= true";

            // Consulta SQL para obtener el nuevo_id
            string query = "SELECT ISNULL(MAX(NumFac), 0) + 1 AS nuevo_id FROM FacturasEncabezado";

            // Crear la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ejecutar la consulta y obtener el resultado
                    int nuevo_id = Convert.ToInt32(command.ExecuteScalar());

                    // Mostrar el resultado en el Label
                    LblNumero.Text = nuevo_id.ToString();
                }
            }
        }
    }
}
