using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT * FROM Clientes",dgvClientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int genero;


            if (cmbgenero.Text == "Femenino")
            {
                genero = 1;
            } else
            {
                genero = 0;
            }

            conexion.Modificaciones("exec InsercionClientes ' " + txtID.Text + " ',' " + txtnombre.Text + " ', '" + txttelefono + "',' " + txtcorreo.Text + " ',' " + txtdir.Text + " ',' " + txtrtn.Text + " ','" + genero + "' ");

            MessageBox.Show("Datos Guardados Correctamente","Seminario de Software", MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtID.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtdir.Clear();
            txtrtn.Clear();

            txtID.Focus();

            conexion.Grids("SELECT IdCli AS Identidad, NomCli as Nombre, TelCli as Telefono, EmCli as Correo, DirCli as Direccion, RtnCli as RTN,CASE WHEN  GenCli=0 THEN 'Femenino' ELSE 'Masculino' as Genero FROM Clientes", dgvClientes);

        }
    }
}
