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
    public partial class FrmTicket : Form
    {
        public FrmTicket()
        {
            InitializeComponent();
        }

        ClsConexion conexion = new ClsConexion();

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.seminarioTicketsDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Ubicaciones' Puede moverla o quitarla según sea necesario.
            this.ubicacionesTableAdapter.Fill(this.seminarioTicketsDataSet.Ubicaciones);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet1.Eventos' Puede moverla o quitarla según sea necesario.
            this.eventosTableAdapter1.Fill(this.seminarioTicketsDataSet1.Eventos);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Tickets' Puede moverla o quitarla según sea necesario.
            this.ticketsTableAdapter.Fill(this.seminarioTicketsDataSet.Tickets);
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Eventos' Puede moverla o quitarla según sea necesario.
            this.eventosTableAdapter.Fill(this.seminarioTicketsDataSet.Eventos);
            conexion.Grids("SELECT * FROM Tickets", dgvticket);


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec InsercionTickets ' " + txtID.Text + " ',' " + dtpFecha.Value.ToString("yyyy-MM-dd") + " ', '" + cmbIdEvt.SelectedValue + "',' " + cmbIdCli.SelectedValue + " ',' " + cmbIdUbi.SelectedValue + " ',' " + txtUbic.Text + " ','" + txtprecioticket.Text + "' ");

            MessageBox.Show("Datos Guardados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtUbic.Clear();
            txtprecioticket.Clear();    

            txtID.Focus();

            conexion.Grids("SELECT Idtct AS Id, FchTct as Fecha, IdEvt as IdEvento, IdCli as IdCliente, IdUbc as IdUbicacion, NumUbc as NumeroUbicacion, PrcTct as PrecioTicket FROM Tickets", dgvticket);
        }

        private void dgvticket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion.Grids("SELECT * FROM Tickets", dgvticket);
        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarTickets ' " + txtID.Text + " ' ");

            MessageBox.Show("Datos Eliminados Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtID.Focus();

            conexion.Grids("SELECT Idtct AS Id, FchTct as Fecha, IdEvt as IdEvento, IdCli as IdCliente, IdUbc as IdUbicacion, NumUbc as NumeroUbicacion, PrcTct as PrecioTicket FROM Tickets", dgvticket);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec ModificarTicket ' " + txtID.Text + " ',' " + dtpFecha.Value.ToString("yyyy-MM-dd") + " ', '" + cmbIdEvt.SelectedValue + "',' " + cmbIdCli.SelectedValue + " ',' " + cmbIdUbi.SelectedValue + " ',' " + txtUbic.Text + " ','" + txtprecioticket.Text + "' ");

            MessageBox.Show("Datos ACTUALIZADOS Correctamente", "Seminario de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
        
            txtUbic.Clear();
            txtprecioticket.Clear();

            txtID.Focus();

            conexion.Grids("SELECT Idtct AS Id, FchTct as Fecha, IdEvt as IdEvento, IdCli as IdCliente, IdUbc as IdUbicacion, NumUbc as NumeroUbicacion, PrcTct as PrecioTicket FROM Tickets", dgvticket);

        }

        private void cmbIdEvt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    