namespace SeminarioTickets
{
    partial class FrmTicket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvticket = new System.Windows.Forms.DataGridView();
            this.Direccion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUbic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecioticket = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbIdEvt = new System.Windows.Forms.ComboBox();
            this.fKTicketsEventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet = new SeminarioTickets.SeminarioTicketsDataSet();
            this.cmbIdCli = new System.Windows.Forms.ComboBox();
            this.cmbIdUbi = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.eventosTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.EventosTableAdapter();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.TicketsTableAdapter();
            this.fKTicketsEventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSet1 = new SeminarioTickets.SeminarioTicketsDataSet1();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter1 = new SeminarioTickets.SeminarioTicketsDataSet1TableAdapters.EventosTableAdapter();
            this.seminarioTicketsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.seminarioTicketsDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.UbicacionesTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new SeminarioTickets.SeminarioTicketsDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTicketsEventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTicketsEventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets";
            // 
            // dgvticket
            // 
            this.dgvticket.AllowUserToAddRows = false;
            this.dgvticket.AllowUserToDeleteRows = false;
            this.dgvticket.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvticket.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvticket.Location = new System.Drawing.Point(308, 94);
            this.dgvticket.Margin = new System.Windows.Forms.Padding(2);
            this.dgvticket.Name = "dgvticket";
            this.dgvticket.ReadOnly = true;
            this.dgvticket.RowHeadersWidth = 51;
            this.dgvticket.Size = new System.Drawing.Size(394, 292);
            this.dgvticket.TabIndex = 16;
            this.dgvticket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvticket_CellContentClick);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(37, 252);
            this.Direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(89, 11);
            this.Direccion.TabIndex = 31;
            this.Direccion.Text = "Id Ubicacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(98, 358);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 26);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 325);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 11);
            this.label7.TabIndex = 30;
            this.label7.Text = "Precio Ticket";
            // 
            // txtUbic
            // 
            this.txtUbic.Location = new System.Drawing.Point(125, 284);
            this.txtUbic.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbic.MaxLength = 15;
            this.txtUbic.Name = "txtUbic";
            this.txtUbic.Size = new System.Drawing.Size(118, 20);
            this.txtUbic.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 11);
            this.label6.TabIndex = 29;
            this.label6.Text = "Numero Ubicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 11);
            this.label5.TabIndex = 27;
            this.label5.Text = "Id Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 11);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 11);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha Ticket";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 114);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.MaxLength = 13;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(118, 20);
            this.txtID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 11);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // txtprecioticket
            // 
            this.txtprecioticket.Location = new System.Drawing.Point(125, 321);
            this.txtprecioticket.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioticket.MaxLength = 15;
            this.txtprecioticket.Name = "txtprecioticket";
            this.txtprecioticket.Size = new System.Drawing.Size(118, 20);
            this.txtprecioticket.TabIndex = 32;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(125, 148);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(118, 20);
            this.dtpFecha.TabIndex = 33;
            // 
            // cmbIdEvt
            // 
            this.cmbIdEvt.DataSource = this.seminarioTicketsDataSet1;
            this.cmbIdEvt.DisplayMember = "Eventos.IdEvt";
            this.cmbIdEvt.FormattingEnabled = true;
            this.cmbIdEvt.Location = new System.Drawing.Point(125, 187);
            this.cmbIdEvt.Name = "cmbIdEvt";
            this.cmbIdEvt.Size = new System.Drawing.Size(121, 21);
            this.cmbIdEvt.TabIndex = 34;
            this.cmbIdEvt.ValueMember = "Eventos.IdEvt";
            this.cmbIdEvt.SelectedIndexChanged += new System.EventHandler(this.cmbIdEvt_SelectedIndexChanged);
            // 
            // fKTicketsEventosBindingSource1
            // 
            this.fKTicketsEventosBindingSource1.DataMember = "FK_Tickets_Eventos";
            this.fKTicketsEventosBindingSource1.DataSource = this.eventosBindingSource;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.seminarioTicketsDataSetBindingSource;
            // 
            // seminarioTicketsDataSetBindingSource
            // 
            this.seminarioTicketsDataSetBindingSource.DataSource = this.seminarioTicketsDataSet;
            this.seminarioTicketsDataSetBindingSource.Position = 0;
            // 
            // seminarioTicketsDataSet
            // 
            this.seminarioTicketsDataSet.DataSetName = "SeminarioTicketsDataSet";
            this.seminarioTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIdCli
            // 
            this.cmbIdCli.DataSource = this.clientesBindingSource;
            this.cmbIdCli.DisplayMember = "idCli";
            this.cmbIdCli.FormattingEnabled = true;
            this.cmbIdCli.Location = new System.Drawing.Point(125, 219);
            this.cmbIdCli.Name = "cmbIdCli";
            this.cmbIdCli.Size = new System.Drawing.Size(121, 21);
            this.cmbIdCli.TabIndex = 35;
            this.cmbIdCli.ValueMember = "idCli";
            // 
            // cmbIdUbi
            // 
            this.cmbIdUbi.DataSource = this.ubicacionesBindingSource;
            this.cmbIdUbi.DisplayMember = "IdUbc";
            this.cmbIdUbi.FormattingEnabled = true;
            this.cmbIdUbi.Location = new System.Drawing.Point(125, 252);
            this.cmbIdUbi.Name = "cmbIdUbi";
            this.cmbIdUbi.Size = new System.Drawing.Size(121, 21);
            this.cmbIdUbi.TabIndex = 36;
            this.cmbIdUbi.ValueMember = "IdUbc";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(99, 388);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 26);
            this.btnActualizar.TabIndex = 37;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(99, 418);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 26);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // fKTicketsEventosBindingSource
            // 
            this.fKTicketsEventosBindingSource.DataMember = "FK_Tickets_Eventos";
            this.fKTicketsEventosBindingSource.DataSource = this.eventosBindingSource;
            // 
            // seminarioTicketsDataSet1
            // 
            this.seminarioTicketsDataSet1.DataSetName = "SeminarioTicketsDataSet1";
            this.seminarioTicketsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataMember = "Eventos";
            this.eventosBindingSource1.DataSource = this.seminarioTicketsDataSet1;
            // 
            // eventosTableAdapter1
            // 
            this.eventosTableAdapter1.ClearBeforeFill = true;
            // 
            // seminarioTicketsDataSetBindingSource1
            // 
            this.seminarioTicketsDataSetBindingSource1.DataSource = this.seminarioTicketsDataSet;
            this.seminarioTicketsDataSetBindingSource1.Position = 0;
            // 
            // seminarioTicketsDataSetBindingSource2
            // 
            this.seminarioTicketsDataSetBindingSource2.DataSource = this.seminarioTicketsDataSet;
            this.seminarioTicketsDataSetBindingSource2.Position = 0;
            // 
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.seminarioTicketsDataSet;
            // 
            // ubicacionesTableAdapter
            // 
            this.ubicacionesTableAdapter.ClearBeforeFill = true;
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
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(740, 469);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbIdUbi);
            this.Controls.Add(this.cmbIdCli);
            this.Controls.Add(this.cmbIdEvt);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtprecioticket);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUbic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvticket);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTicket";
            this.Text = "FrmTicket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTicketsEventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTicketsEventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarioTicketsDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvticket;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUbic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecioticket;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbIdEvt;
        private System.Windows.Forms.ComboBox cmbIdCli;
        private System.Windows.Forms.ComboBox cmbIdUbi;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource seminarioTicketsDataSetBindingSource;
        private SeminarioTicketsDataSet seminarioTicketsDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private SeminarioTicketsDataSetTableAdapters.EventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private SeminarioTicketsDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource fKTicketsEventosBindingSource;
        private SeminarioTicketsDataSet1 seminarioTicketsDataSet1;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private SeminarioTicketsDataSet1TableAdapters.EventosTableAdapter eventosTableAdapter1;
        private System.Windows.Forms.BindingSource fKTicketsEventosBindingSource1;
        private System.Windows.Forms.BindingSource seminarioTicketsDataSetBindingSource2;
        private System.Windows.Forms.BindingSource seminarioTicketsDataSetBindingSource1;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private SeminarioTicketsDataSetTableAdapters.UbicacionesTableAdapter ubicacionesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private SeminarioTicketsDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
    }
}