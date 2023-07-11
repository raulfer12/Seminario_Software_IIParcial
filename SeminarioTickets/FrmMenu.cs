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

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturas frmFacturas = new FrmFacturas();
            frmFacturas.Show();
        }

        private void lugaresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLugares frmLugares = new FrmLugares();
            frmLugares.Show();
        }
    }
}
