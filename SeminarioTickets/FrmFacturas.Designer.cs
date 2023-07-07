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
            this.button1 = new System.Windows.Forms.Button();
            this.DgvFactura = new System.Windows.Forms.DataGridView();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.CmbEmpleado = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblNumero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seminarioTicketsDataSet = new SeminarioTickets.SeminarioTicketsDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.EmpleadosTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(36, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DgvFactura
            // 
            this.DgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.DgvFactura.Location = new System.Drawing.Point(36, 110);
            this.DgvFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvFactura.Name = "DgvFactura";
            this.DgvFactura.Size = new System.Drawing.Size(904, 320);
            this.DgvFactura.TabIndex = 28;
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
            // CmbCliente
            // 
            this.CmbCliente.DataSource = this.clientesBindingSource;
            this.CmbCliente.DisplayMember = "NomCli";
            this.CmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(557, 62);
            this.CmbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(180, 25);
            this.CmbCliente.TabIndex = 27;
            this.CmbCliente.ValueMember = "idCli";
            // 
            // CmbEmpleado
            // 
            this.CmbEmpleado.DataSource = this.empleadosBindingSource;
            this.CmbEmpleado.DisplayMember = "NomEmp";
            this.CmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpleado.FormattingEnabled = true;
            this.CmbEmpleado.Location = new System.Drawing.Point(366, 62);
            this.CmbEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbEmpleado.Name = "CmbEmpleado";
            this.CmbEmpleado.Size = new System.Drawing.Size(180, 25);
            this.CmbEmpleado.TabIndex = 26;
            this.CmbEmpleado.ValueMember = "IdEmp";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(211, 62);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(132, 25);
            this.DtpFecha.TabIndex = 25;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNumero.Location = new System.Drawing.Point(146, 68);
            this.LblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(17, 17);
            this.LblNumero.TabIndex = 24;
            this.LblNumero.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(618, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(416, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(251, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número";
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
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(42)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(975, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvFactura);
            this.Controls.Add(this.CmbCliente);
            this.Controls.Add(this.CmbEmpleado);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.ComboBox CmbEmpleado;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SeminarioTicketsDataSet seminarioTicketsDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private SeminarioTicketsDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SeminarioTicketsDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
    }
}