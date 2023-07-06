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
    public partial class TipoEvento : Form
    {
        private DataTable dataTable;

        public TipoEvento()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        ClsConexion conexion = new ClsConexion();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TipoEvento_Load(object sender, EventArgs e)
        {
            conexion.Grids("exec SelectTipoEvn", dgvTipEvn);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec GuardarTipoEventos '" + txtID.Text + "', '" + NomEvn.Text + "'");
            MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();//Limpiar esos campos
            NomEvn.Clear();

            // Actualizar el DataGridView con los datos más recientes
            conexion.Grids("exec SelectTipoEventos", dgvTipEvn);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el IdNvl del registro seleccionado en el DataGridView
            int idEvn = Convert.ToInt32(dgvTipEvn.CurrentRow.Cells["IdEvn"].Value);

            // Obtener el nuevo nombre del nivel desde un cuadro de texto o cualquier otro control de entrada
            string nuevoNombre = NomEvn.Text;

            // Llamar al método de actualización en la clase ClsConexion
            conexion.Modificaciones("EXEC UpdateTipoEvn '" + idEvn + "', '" + nuevoNombre + "'");

            // Actualizar el DataGridView con los datos más recientes
            conexion.Grids("EXEC SelectTipoEvn", dgvTipEvn);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el IdNvl del registro seleccionado en el DataGridView
            int idEvn = Convert.ToInt32(dgvTipEvn.CurrentRow.Cells["IdEvn"].Value);

            // Confirmar la eliminación con el usuario antes de proceder
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este Evento?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // Llamar al método de eliminación en la clase ClsConexion
                conexion.Modificaciones("EXEC DeleteTipoEvn '" + idEvn + "'");

                // Actualizar el DataGridView con los datos más recientes
                conexion.Grids("EXEC SelectTipoEvn", dgvTipEvn);
            }
        }
    }
}
