﻿using System;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'seminarioTicketsDataSet.Niveles' Puede moverla o quitarla según sea necesario.
            this.nivelesTableAdapter.Fill(this.seminarioTicketsDataSet.Niveles);
            conexion.Grids("SELECT EmUsu AS Email, ConUsu AS Password, CodEnvUsu AS Codigo, IdNvl AS Nivel, CASE WHEN  EstUsu=1 THEN 'Actvio' ELSE 'Inactivo' END AS Estado FROM Usuarios", dgvUsuarios);

        }
        ClsConexion conexion = new ClsConexion();

        private void button1_Click(object sender, EventArgs e)
        {
            int estado;
            if (cmbEstado.Text == "Activo")
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            conexion.Modificaciones("exec InsercionUsuarios '" + txtEmail.Text + "','" + txtPass.Text + "', '" + txtCodigo.Text + "', '" + cmbNivel.SelectedValue + "', '" + estado + "'");
            MessageBox.Show("Datos fueron guardados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtEmail.Clear();
            txtPass.Clear();
            txtCodigo.Clear();
            txtEmail.Focus();

            conexion.Grids("SELECT EmUsu AS Email, ConUsu AS Password, CodEnvUsu AS Codigo, IdNvl AS Nivel, CASE WHEN  EstUsu=1 THEN 'Actvio' ELSE 'Inactivo' END AS Estado FROM Usuarios", dgvUsuarios);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conexion.Grids("SELECT EmUsu AS Email, ConUsu AS Password, CodEnvUsu AS Codigo, IdNvl AS Nivel, CASE WHEN  EstUsu=1 THEN 'Actvio' ELSE 'Inactivo' END AS Estado FROM Usuarios", dgvUsuarios);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string EmUsua = txtEmail.Text;
            string ConUsua = txtPass.Text;
            string CodEnvUsua = txtCodigo.Text;
            int IdNivel = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdNvl"].Value);
            bool EstUsua = (bool)cmbEstado.SelectedValue;
            
            conexion.Modificaciones("EXEC UpdateUsuarios '" + EmUsua + "', '" + ConUsua + "', '"+CodEnvUsua+"','"+IdNivel+"','"+EstUsua+"'");

            conexion.Grids("EXEC SelectUsuarios", dgvUsuarios);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string EmUsu = txtEmail.Text;

            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                conexion.Modificaciones("EXEC DeleteUsuarios '" + EmUsu + "'");
                conexion.Grids("EXEC SelectUsuarios", dgvUsuarios);
            }
        }
    }
}
