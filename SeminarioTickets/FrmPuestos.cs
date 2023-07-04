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
    public partial class FrmPuestos : Form
    {
        public FrmPuestos()
        {
            InitializeComponent();
        }
        ClsConexion conexion = new ClsConexion();

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT  IdPst AS ID, NomPst AS Puesto FROM Puestos", dgvPuestos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec InsercionesPuestos '" + txtID.Text + "' ,'" + txtNombre.Text + "'");
            MessageBox.Show("Datos guardados correctamente","Unicah", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtNombre.Clear();
            txtID.Focus();

            conexion.Grids("SELECT IdPst AS ID, NomPst AS Puesto FROM Puestos", dgvPuestos);

        }

    }
}
