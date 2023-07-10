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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.seminarioTicketsDataSet.Puestos);

        }
        ClsConexion conexion = new ClsConexion();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int genero;
            if(cmbGenero.Text=="Femenino")
            {
                genero = 1;
            }else
            {
                genero = 0;
            }
            conexion.Modificaciones("exec InsercionEmpleados '"+txtID.Text+"','"+txtNombre.Text+"', '"+dtpFecha.Value.ToString("yyyy-MM-dd")+"', '"+txtEmail.Text+"', '"+txtDireccion.Text+"', '"+txtTelefono.Text+"', '"+genero+"', '"+cmbPuesto.SelectedValue+"'");
            MessageBox.Show("Datos fueron guardados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtID.Focus();

            conexion.Grids("SELECT * FROM Empleados",dgvEmpleados);
        }
    }
}
