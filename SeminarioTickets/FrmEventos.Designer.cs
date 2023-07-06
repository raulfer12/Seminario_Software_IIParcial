namespace SeminarioTickets
{
    partial class FrmEventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.txtIDlugar = new System.Windows.Forms.TextBox();
            this.lblIDlugar = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblResEvent = new System.Windows.Forms.Label();
            this.txtcapEvent = new System.Windows.Forms.TextBox();
            this.lblCapEvent = new System.Windows.Forms.Label();
            this.txtHrEvent = new System.Windows.Forms.TextBox();
            this.lblHrEvent = new System.Windows.Forms.Label();
            this.txtfchEvent = new System.Windows.Forms.TextBox();
            this.lblFechEvent = new System.Windows.Forms.Label();
            this.txtIDEvt = new System.Windows.Forms.TextBox();
            this.lblNombreEvent = new System.Windows.Forms.Label();
            this.txtNomEvent = new System.Windows.Forms.TextBox();
            this.lblDEvt = new System.Windows.Forms.Label();
            this.lblEventos = new System.Windows.Forms.Label();
            this.txtResEvent = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtIDEvn = new System.Windows.Forms.TextBox();
            this.lblIDEvn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventos.Location = new System.Drawing.Point(409, 121);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(349, 244);
            this.dgvEventos.TabIndex = 32;
            // 
            // txtIDlugar
            // 
            this.txtIDlugar.Location = new System.Drawing.Point(212, 257);
            this.txtIDlugar.MaxLength = 500;
            this.txtIDlugar.Name = "txtIDlugar";
            this.txtIDlugar.Size = new System.Drawing.Size(156, 20);
            this.txtIDlugar.TabIndex = 24;
            // 
            // lblIDlugar
            // 
            this.lblIDlugar.AutoSize = true;
            this.lblIDlugar.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDlugar.Location = new System.Drawing.Point(110, 262);
            this.lblIDlugar.Name = "lblIDlugar";
            this.lblIDlugar.Size = new System.Drawing.Size(61, 11);
            this.lblIDlugar.TabIndex = 31;
            this.lblIDlugar.Text = "ID Lugar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(68, 352);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 32);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblResEvent
            // 
            this.lblResEvent.AutoSize = true;
            this.lblResEvent.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResEvent.Location = new System.Drawing.Point(110, 316);
            this.lblResEvent.Name = "lblResEvent";
            this.lblResEvent.Size = new System.Drawing.Size(75, 11);
            this.lblResEvent.TabIndex = 30;
            this.lblResEvent.Text = "Res Evento";
            // 
            // txtcapEvent
            // 
            this.txtcapEvent.Location = new System.Drawing.Point(212, 284);
            this.txtcapEvent.MaxLength = 15;
            this.txtcapEvent.Name = "txtcapEvent";
            this.txtcapEvent.Size = new System.Drawing.Size(156, 20);
            this.txtcapEvent.TabIndex = 25;
            // 
            // lblCapEvent
            // 
            this.lblCapEvent.AutoSize = true;
            this.lblCapEvent.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapEvent.Location = new System.Drawing.Point(110, 289);
            this.lblCapEvent.Name = "lblCapEvent";
            this.lblCapEvent.Size = new System.Drawing.Size(75, 11);
            this.lblCapEvent.TabIndex = 29;
            this.lblCapEvent.Text = "Cap Evento";
            // 
            // txtHrEvent
            // 
            this.txtHrEvent.Location = new System.Drawing.Point(212, 230);
            this.txtHrEvent.MaxLength = 255;
            this.txtHrEvent.Name = "txtHrEvent";
            this.txtHrEvent.Size = new System.Drawing.Size(156, 20);
            this.txtHrEvent.TabIndex = 22;
            // 
            // lblHrEvent
            // 
            this.lblHrEvent.AutoSize = true;
            this.lblHrEvent.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrEvent.Location = new System.Drawing.Point(110, 235);
            this.lblHrEvent.Name = "lblHrEvent";
            this.lblHrEvent.Size = new System.Drawing.Size(82, 11);
            this.lblHrEvent.TabIndex = 27;
            this.lblHrEvent.Text = "Hora Evento";
            // 
            // txtfchEvent
            // 
            this.txtfchEvent.Location = new System.Drawing.Point(212, 203);
            this.txtfchEvent.MaxLength = 8;
            this.txtfchEvent.Name = "txtfchEvent";
            this.txtfchEvent.Size = new System.Drawing.Size(156, 20);
            this.txtfchEvent.TabIndex = 21;
            // 
            // lblFechEvent
            // 
            this.lblFechEvent.AutoSize = true;
            this.lblFechEvent.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechEvent.Location = new System.Drawing.Point(110, 208);
            this.lblFechEvent.Name = "lblFechEvent";
            this.lblFechEvent.Size = new System.Drawing.Size(89, 11);
            this.lblFechEvent.TabIndex = 23;
            this.lblFechEvent.Text = "Fecha Evento";
            // 
            // txtIDEvt
            // 
            this.txtIDEvt.Location = new System.Drawing.Point(212, 108);
            this.txtIDEvt.MaxLength = 70;
            this.txtIDEvt.Name = "txtIDEvt";
            this.txtIDEvt.Size = new System.Drawing.Size(156, 20);
            this.txtIDEvt.TabIndex = 19;
            this.txtIDEvt.TextChanged += new System.EventHandler(this.txtIdEvent_TextChanged);
            // 
            // lblNombreEvent
            // 
            this.lblNombreEvent.AutoSize = true;
            this.lblNombreEvent.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvent.Location = new System.Drawing.Point(110, 134);
            this.lblNombreEvent.Name = "lblNombreEvent";
            this.lblNombreEvent.Size = new System.Drawing.Size(96, 11);
            this.lblNombreEvent.TabIndex = 20;
            this.lblNombreEvent.Text = "Nombre Evento";
            this.lblNombreEvent.Click += new System.EventHandler(this.lblNombreEvent_Click);
            // 
            // txtNomEvent
            // 
            this.txtNomEvent.Location = new System.Drawing.Point(212, 134);
            this.txtNomEvent.MaxLength = 13;
            this.txtNomEvent.Name = "txtNomEvent";
            this.txtNomEvent.Size = new System.Drawing.Size(156, 20);
            this.txtNomEvent.TabIndex = 17;
            this.txtNomEvent.TextChanged += new System.EventHandler(this.txtNombreEvent_TextChanged);
            // 
            // lblDEvt
            // 
            this.lblDEvt.AutoSize = true;
            this.lblDEvt.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDEvt.Location = new System.Drawing.Point(117, 113);
            this.lblDEvt.Name = "lblDEvt";
            this.lblDEvt.Size = new System.Drawing.Size(68, 11);
            this.lblDEvt.TabIndex = 18;
            this.lblDEvt.Text = "ID Evento";
            this.lblDEvt.Click += new System.EventHandler(this.lblDEventos_Click);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.Location = new System.Drawing.Point(251, 74);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(70, 15);
            this.lblEventos.TabIndex = 16;
            this.lblEventos.Text = "Eventos";
            // 
            // txtResEvent
            // 
            this.txtResEvent.Location = new System.Drawing.Point(212, 311);
            this.txtResEvent.MaxLength = 15;
            this.txtResEvent.Name = "txtResEvent";
            this.txtResEvent.Size = new System.Drawing.Size(156, 20);
            this.txtResEvent.TabIndex = 33;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(302, 352);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 32);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(184, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 32);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtIDEvn
            // 
            this.txtIDEvn.Location = new System.Drawing.Point(212, 160);
            this.txtIDEvn.MaxLength = 70;
            this.txtIDEvn.Name = "txtIDEvn";
            this.txtIDEvn.Size = new System.Drawing.Size(156, 20);
            this.txtIDEvn.TabIndex = 37;
            // 
            // lblIDEvn
            // 
            this.lblIDEvn.AutoSize = true;
            this.lblIDEvn.Font = new System.Drawing.Font("MingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEvn.Location = new System.Drawing.Point(124, 165);
            this.lblIDEvn.Name = "lblIDEvn";
            this.lblIDEvn.Size = new System.Drawing.Size(68, 11);
            this.lblIDEvn.TabIndex = 36;
            this.lblIDEvn.Text = "ID Evento";
            // 
            // FrmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(897, 490);
            this.Controls.Add(this.txtIDEvn);
            this.Controls.Add(this.lblIDEvn);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtResEvent);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.txtIDlugar);
            this.Controls.Add(this.lblIDlugar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblResEvent);
            this.Controls.Add(this.txtcapEvent);
            this.Controls.Add(this.lblCapEvent);
            this.Controls.Add(this.txtHrEvent);
            this.Controls.Add(this.lblHrEvent);
            this.Controls.Add(this.txtfchEvent);
            this.Controls.Add(this.lblFechEvent);
            this.Controls.Add(this.txtIDEvt);
            this.Controls.Add(this.lblNombreEvent);
            this.Controls.Add(this.txtNomEvent);
            this.Controls.Add(this.lblDEvt);
            this.Controls.Add(this.lblEventos);
            this.Name = "FrmEventos";
            this.Text = "FrmEventos";
            this.Load += new System.EventHandler(this.FrmEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox txtIDlugar;
        private System.Windows.Forms.Label lblIDlugar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblResEvent;
        private System.Windows.Forms.TextBox txtcapEvent;
        private System.Windows.Forms.Label lblCapEvent;
        private System.Windows.Forms.TextBox txtHrEvent;
        private System.Windows.Forms.Label lblHrEvent;
        private System.Windows.Forms.TextBox txtfchEvent;
        private System.Windows.Forms.Label lblFechEvent;
        private System.Windows.Forms.TextBox txtIDEvt;
        private System.Windows.Forms.Label lblNombreEvent;
        private System.Windows.Forms.TextBox txtNomEvent;
        private System.Windows.Forms.Label lblDEvt;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.TextBox txtResEvent;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtIDEvn;
        private System.Windows.Forms.Label lblIDEvn;
    }
}