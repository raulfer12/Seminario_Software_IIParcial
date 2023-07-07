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

            if (TxtId.Text == "")
            {
                MessageBox.Show("¡Debe de llenar todos los campos!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtId.Focus();
                return;
            }

            if (TxtNombre.Text == "")
            {
                MessageBox.Show("¡Debe de llenar todos los campos!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
                return;
            }

            if (TxtCapacidad.Text == "")
            {
                MessageBox.Show("¡Debe de llenar todos los campos!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCapacidad .Focus();
                return;
            }
            else
            {
                if ((MessageBox.Show("¿Está seguro de agregar un nuevo lugar?", "SEMINARIO DE SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    try
                    {
                        conexion.Modificaciones("exec InsercionLugares '" + TxtId.Text + "', '" + TxtNombre.Text + "', '" + TxtCapacidad.Text + "'");
                        MessageBox.Show("¡Datos Guardados Correctamente!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexion.Grids("exec SelectLugares", DgvLugares);

                        TxtId.Clear();
                        TxtCapacidad.Clear();
                        TxtNombre.Clear();
                        TxtId.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }           
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            conexion.Grids("exec SelectLugares", DgvLugares);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "" && TxtNombre.Text == "" && TxtCapacidad.Text == "")
            {
                MessageBox.Show("¡No se ha seleccionado un Lugar!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtId.Focus();
                return;
            }

            if (TxtId.Text == "")
            {
                MessageBox.Show("¡El ID no puede estar vacío!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtId.Focus();
                return;
            }

            if (TxtNombre.Text == "")
            {
                MessageBox.Show("¡El Nombre no puede estar vacío!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
                return;
            }

            if (TxtCapacidad.Text == "")
            {
                MessageBox.Show("¡La Capacidad no puede estar vacía!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCapacidad.Focus();
                return;
            }



            if ((MessageBox.Show("¿Está seguro de actualizar el lugar?", "SEMINARIO DE SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                try
                {
                    conexion.Modificaciones("exec ActLugares '" + TxtId.Text + "', '" + TxtNombre.Text + "', '" + TxtCapacidad.Text + "'");
                    MessageBox.Show("¡Datos Actualizados Correctamente!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Grids("exec SelectLugares", DgvLugares);
                    TxtId.Clear();
                    TxtNombre.Clear();
                    TxtCapacidad.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "" && TxtNombre.Text == "" && TxtCapacidad.Text == "")
            {
                MessageBox.Show("¡No se ha seleccionado un Lugar!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtId.Focus();
                return;
            }

            if ((MessageBox.Show("¿Está seguro de eliminar el lugar?", "SEMINARIO DE SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                try
                {
                    conexion.Modificaciones("exec DelLugares '" + TxtId.Text + "'");
                    MessageBox.Show("¡Lugar Eliminado Correctamente!", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Grids("exec SelectLugares", DgvLugares);
                    TxtId.Clear();
                    TxtNombre.Clear();
                    TxtCapacidad.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void DgvLugares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DgvLugares.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text = DgvLugares.CurrentRow.Cells[1].Value.ToString();
            TxtCapacidad.Text = DgvLugares.CurrentRow.Cells[2].Value.ToString();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtBuscar.TextLength == 0)
                {
                    conexion.Grids("exec SelectLugares", DgvLugares);
                }
                else
                {
                    conexion.Grids("exec BusLugares '" + TxtBuscar.Text + "'", DgvLugares);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
           
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
