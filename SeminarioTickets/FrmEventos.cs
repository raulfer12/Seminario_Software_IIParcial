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
    public partial class FrmEventos : Form
    {
        private DataTable dataTable;
        public FrmEventos()
        {
            InitializeComponent();
            dataTable = new DataTable();

        }
        ClsConexion conexion = new ClsConexion();
        private void FrmEventos_Load(object sender, EventArgs e)
        {
            conexion.Grids("exec SelectEventos", dgvEventos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec GuardarEventos '" + txtIDEvt.Text + "', '" + txtNomEvent.Text + "', '" + txtIDEvn.Text + "', '" + txtfchEvent.Text + "', '" + txtHrEvent.Text + "', '" + txtIDlugar.Text + "', '" + txtcapEvent.Text + "', '" + txtResEvent.Text + "'");
            MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*
            txtIDEvt.Clear();//Limpiar esos campos
            txtNomEvent.Clear();
            */

            // Actualizar el DataGridView con los datos más recientes
            conexion.Grids("exec SelectTipoEventos", dgvEventos);
        }

        private void lblDEventos_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el IdNvl del registro seleccionado en el DataGridView
            int IdEvn = Convert.ToInt32(dgvEventos.CurrentRow.Cells["IdEvt"].Value);

            // Obtener el nuevo nombre del nivel desde un cuadro de texto o cualquier otro control de entrada
            string nuevoNombre = txtNomEvent.Text;

            // Llamar al método de actualización en la clase ClsConexion
            conexion.Modificaciones("EXEC UpdateEventos '" + IdEvn + "', '" + nuevoNombre + "'");

            // Actualizar el DataGridView con los datos más recientes
            conexion.Grids("EXEC SelectEventos", dgvEventos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el IdNvl del registro seleccionado en el DataGridView
            int IdEvt = Convert.ToInt32(dgvEventos.CurrentRow.Cells["IdEvt"].Value);

            // Confirmar la eliminación con el usuario antes de proceder
            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este Evento?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // Llamar al método de eliminación en la clase ClsConexion
                conexion.Modificaciones("EXEC DeleteEventos '" + IdEvt + "'");

                // Actualizar el DataGridView con los datos más recientes
                conexion.Grids("EXEC SelectEventos", dgvEventos);
            }
        }
    }
}
