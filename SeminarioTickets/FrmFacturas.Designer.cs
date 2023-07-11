namespace SeminarioTickets
{
    partial class FrmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.cmbCli = new System.Windows.Forms.ComboBox();
            this.seminarioTicketsDataSet = new SeminarioTickets.SeminarioTicketsDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.EmpleadosTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.ClientesTableAdapter();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.facturasEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasEncabezadoTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.FacturasEncabezadoTableAdapter();
            this.fKFacturaDetalleFacturasEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDetalleTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.FacturaDetalleTableAdapter();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasEncabezadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaDetalleFacturasEncabezadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clientes";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(161, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(29, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Num";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(164, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // cmbEmp
            // 
            this.cmbEmp.DataSource = this.empleadosBindingSource;
            this.cmbEmp.DisplayMember = "NomEmp";
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(164, 132);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbEmp.TabIndex = 6;
            this.cmbEmp.ValueMember = "IdEmp";
            // 
            // cmbCli
            // 
            this.cmbCli.DataSource = this.clientesBindingSource;
            this.cmbCli.DisplayMember = "NomCli";
            this.cmbCli.FormattingEnabled = true;
            this.cmbCli.Location = new System.Drawing.Point(164, 163);
            this.cmbCli.Name = "cmbCli";
            this.cmbCli.Size = new System.Drawing.Size(121, 21);
            this.cmbCli.TabIndex = 7;
            this.cmbCli.ValueMember = "idCli";
            // 
            // seminarioTicketsDataSet
            // 
            this.seminarioTicketsDataSet.DataSetName = "SeminarioTicketsDataSet";
            this.seminarioTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.dgvFactura.Location = new System.Drawing.Point(325, 39);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(240, 150);
            this.dgvFactura.TabIndex = 8;
            this.dgvFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellEndEdit);
            // 
            // facturasEncabezadoBindingSource
            // 
            this.facturasEncabezadoBindingSource.DataMember = "FacturasEncabezado";
            this.facturasEncabezadoBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // facturasEncabezadoTableAdapter
            // 
            this.facturasEncabezadoTableAdapter.ClearBeforeFill = true;
            // 
            // fKFacturaDetalleFacturasEncabezadoBindingSource
            // 
            this.fKFacturaDetalleFacturasEncabezadoBindingSource.DataMember = "FK_FacturaDetalle_FacturasEncabezado";
            this.fKFacturaDetalleFacturasEncabezadoBindingSource.DataSource = this.facturasEncabezadoBindingSource;
            // 
            // facturaDetalleTableAdapter
            // 
            this.facturaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Ticket";
            this.Ticket.Name = "Ticket";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnGuardad
            // 
            this.btnGuardad.Location = new System.Drawing.Point(128, 230);
            this.btnGuardad.Name = "btnGuardad";
            this.btnGuardad.Size = new System.Drawing.Size(75, 23);
            this.btnGuardad.TabIndex = 9;
            this.btnGuardad.Text = "Guardar";
            this.btnGuardad.UseVisualStyleBackColor = true;
            this.btnGuardad.Click += new System.EventHandler(this.btnGuardad_Click);
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardad);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.cmbCli);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasEncabezadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaDetalleFacturasEncabezadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.ComboBox cmbCli;
        private SeminarioTicketsDataSet seminarioTicketsDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private SeminarioTicketsDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SeminarioTicketsDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.BindingSource facturasEncabezadoBindingSource;
        private SeminarioTicketsDataSetTableAdapters.FacturasEncabezadoTableAdapter facturasEncabezadoTableAdapter;
        private System.Windows.Forms.BindingSource fKFacturaDetalleFacturasEncabezadoBindingSource;
        private SeminarioTicketsDataSetTableAdapters.FacturaDetalleTableAdapter facturaDetalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnGuardad;
    }
}