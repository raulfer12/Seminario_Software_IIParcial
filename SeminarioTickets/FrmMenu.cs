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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();

        }

        private void configuracioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();
            frmBitacora.Show();
        }

        private void actToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos= new FrmPuestos();
            frmPuestos.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

 ramaRaul
        private void nuevoToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaDetalle f = new FacturaDetalle();
            f.Show();
            this.Hide();
 master
        }
    }
}
