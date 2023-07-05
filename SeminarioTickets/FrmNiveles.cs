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
    public partial class FrmNiveles : Form
    {
        private DataTable dataTable;

        public FrmNiveles()
        {
            InitializeComponent();
            dataTable = new DataTable();
    }

        ClsConexion conexion = new ClsConexion();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec InsercionNiveles '" + txtId.Text + "', '" + txtNombre.Text + "'");
            MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();//Limpiar esos campos
            txtNombre.Clear();

            // Actualizar el DataGridView con los datos más recientes
            conexion.Grids("exec SelectNiveles", dgvNiveles);
        }

        private void FrmNiveles_Load(object sender, EventArgs e)
        {
            conexion.Grids("exec SelectNiveles", dgvNiveles); //Para ver los datos agregados en el DGV
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el IdNvl del registro seleccionado en el DataGridView
            int idNivel = Convert.ToInt32(dgvNiveles.CurrentRow.Cells["IdNvl"].Value);

            // Obtener el nuevo nombre del nivel desde un cuadro de texto o cualquier otro control de entrada
            string nuevoNombre = txtNombre.Text;

            // Llamar al método de actualización en la clase ClsConexion
            conexion.Modificaciones("EXEC UpdateNiveles '" + idNivel + "', '" + nuevoNombre + "'");

            // Actualizar el DataGridView con los datos más recientes
            conexion.Grids("EXEC SelectNiveles", dgvNiveles);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el IdNvl del registro seleccionado en el DataGridView
            int idNivel = Convert.ToInt32(dgvNiveles.CurrentRow.Cells["IdNvl"].Value);

            // Confirmar la eliminación con el usuario antes de proceder
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este nivel?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // Llamar al método de eliminación en la clase ClsConexion
                conexion.Modificaciones("EXEC DeleteNiveles '" + idNivel + "'");

                // Actualizar el DataGridView con los datos más recientes
                conexion.Grids("EXEC SelectNiveles", dgvNiveles);
            }
        }
    }
}
