namespace SeminarioTickets
{
    partial class FrmLugares
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvLugares = new System.Windows.Forms.DataGridView();
            this.TxtCapacidad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGuardar.Location = new System.Drawing.Point(52, 143);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 32);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgvLugares
            // 
            this.DgvLugares.AllowUserToAddRows = false;
            this.DgvLugares.AllowUserToDeleteRows = false;
            this.DgvLugares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLugares.Location = new System.Drawing.Point(53, 370);
            this.DgvLugares.Name = "DgvLugares";
            this.DgvLugares.ReadOnly = true;
            this.DgvLugares.Size = new System.Drawing.Size(681, 343);
            this.DgvLugares.TabIndex = 18;
            this.DgvLugares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLugares_CellDoubleClick);
            // 
            // TxtCapacidad
            // 
            this.TxtCapacidad.BackColor = System.Drawing.Color.DarkRed;
            this.TxtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCapacidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCapacidad.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCapacidad.Location = new System.Drawing.Point(482, 107);
            this.TxtCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCapacidad.MaxLength = 8;
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.Size = new System.Drawing.Size(248, 16);
            this.TxtCapacidad.TabIndex = 16;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.DarkRed;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.Location = new System.Drawing.Point(205, 108);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.MaxLength = 70;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(269, 16);
            this.TxtNombre.TabIndex = 14;
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.DarkRed;
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtId.Location = new System.Drawing.Point(49, 108);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.MaxLength = 13;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(148, 16);
            this.TxtId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(482, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cápacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(205, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnActualizar.Location = new System.Drawing.Point(171, 143);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(100, 32);
            this.BtnActualizar.TabIndex = 28;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEliminar.Location = new System.Drawing.Point(295, 143);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 32);
            this.BtnEliminar.TabIndex = 37;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.DarkRed;
            this.TxtBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtBuscar.Location = new System.Drawing.Point(551, 148);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.MaxLength = 13;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(179, 23);
            this.TxtBuscar.TabIndex = 38;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(435, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Buscar por Id";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel2.Location = new System.Drawing.Point(49, 126);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(148, 1);
            this.Panel2.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(205, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(482, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 1);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FrmLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(834, 667);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DgvLugares);
            this.Controls.Add(this.TxtCapacidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLugares";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lugares";
            this.Load += new System.EventHandler(this.FrmLugares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgvLugares;
        private System.Windows.Forms.TextBox TxtCapacidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panel3;
    }
}