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
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }
        ClsConexion conexion = new ClsConexion();

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.FacturaDetalle' Puede moverla o quitarla según sea necesario.
            this.facturaDetalleTableAdapter.Fill(this.seminarioTicketsDataSet.FacturaDetalle);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.FacturasEncabezado' Puede moverla o quitarla según sea necesario.
            this.facturasEncabezadoTableAdapter.Fill(this.seminarioTicketsDataSet.FacturasEncabezado);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.seminarioTicketsDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.seminarioTicketsDataSet.Empleados);

        }

        private void dgvFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvFactura.CurrentRow.Cells[3].Value = Convert.ToInt32(dgvFactura.CurrentRow.Cells[1].Value) * Convert.ToInt32(dgvFactura.CurrentRow.Cells[2].Value);
        }

        private void btnGuardad_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvFactura.Rows)
            {
                conexion.Modificaciones
            }
        }
    }
}
