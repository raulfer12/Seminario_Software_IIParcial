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
    public partial class FacturaDetalle : Form
    {
        public FacturaDetalle()
        {
            InitializeComponent();
        }
        ClsConexion c = new ClsConexion();
        private void FacturaDetalle_Load(object sender, EventArgs e)
        {
            c.Grids("Select F.NroFact , FchEmp from FacturasEncabezado inner join FacturasDetalle as F on F.NroFact = FacturasEncabezado.NroFact", dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            c.Modificaciones("delete from FacturasDetalle where NroFact = '"+id+"' ");
            c.Modificaciones("delete from FacturasEncabezado where NroFact = '" + id + "' ");


            c.Grids("Select F.NroFact , FchEmp from FacturasEncabezado inner join FacturasDetalle as F on F.NroFact = FacturasEncabezado.NroFact", dataGridView1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu m = new FrmMenu();
            m.Show();
        }
    }
}
