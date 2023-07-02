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
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec InsercionLugares '" + TxtId.Text + "', '" + TxtNombre.Text + "', '" + TxtCapacidad.Text + "'");
            MessageBox.Show("¡Datos Guardados Correctamente!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Grids("exec SelectLugares", DgvLugares);

            TxtId.Clear();
            TxtCapacidad.Clear();
            TxtNombre.Clear();
            TxtId.Focus();
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            conexion.Grids("exec SelectLugares", DgvLugares);
        }
    }
}
