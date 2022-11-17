namespace pryBaldovinoIEFI
{
    partial class frmBusquedaPorActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaPorActividad));
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblActividad = new System.Windows.Forms.Label();
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblMenorSaldo = new System.Windows.Forms.Label();
            this.lblPromedioDeSaldos = new System.Windows.Forms.Label();
            this.lblMayorSaldo = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenorSald = new System.Windows.Forms.Label();
            this.lblMayorSal = new System.Windows.Forms.Label();
            this.mrcInformacion = new System.Windows.Forms.GroupBox();
            this.lblTotalDeSaldos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.mrcInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Location = new System.Drawing.Point(188, 232);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(71, 23);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(93, 232);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(71, 23);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(12, 18);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 16;
            this.lblActividad.Text = "Actividad";
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgvConsultaCliente.Location = new System.Drawing.Point(15, 50);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.ReadOnly = true;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(244, 176);
            this.dgvConsultaCliente.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y apellido";
            this.Column1.Name = "Column1";
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Musculación",
            "Zumba",
            "Spinning",
            "Pilates",
            "Funcional",
            "Yoga",
            "Minitramp",
            "Boxing"});
            this.lstActividad.Location = new System.Drawing.Point(69, 15);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(121, 21);
            this.lstActividad.TabIndex = 1;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // lblMenorSaldo
            // 
            this.lblMenorSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenorSaldo.Location = new System.Drawing.Point(103, 62);
            this.lblMenorSaldo.Name = "lblMenorSaldo";
            this.lblMenorSaldo.Size = new System.Drawing.Size(100, 17);
            this.lblMenorSaldo.TabIndex = 34;
            // 
            // lblPromedioDeSaldos
            // 
            this.lblPromedioDeSaldos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPromedioDeSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeSaldos.Location = new System.Drawing.Point(103, 98);
            this.lblPromedioDeSaldos.Name = "lblPromedioDeSaldos";
            this.lblPromedioDeSaldos.Size = new System.Drawing.Size(100, 17);
            this.lblPromedioDeSaldos.TabIndex = 33;
            // 
            // lblMayorSaldo
            // 
            this.lblMayorSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMayorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayorSaldo.Location = new System.Drawing.Point(103, 27);
            this.lblMayorSaldo.Name = "lblMayorSaldo";
            this.lblMayorSaldo.Size = new System.Drawing.Size(100, 17);
            this.lblMayorSaldo.TabIndex = 32;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(18, 99);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 31;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblMenorSald
            // 
            this.lblMenorSald.AutoSize = true;
            this.lblMenorSald.Location = new System.Drawing.Point(18, 63);
            this.lblMenorSald.Name = "lblMenorSald";
            this.lblMenorSald.Size = new System.Drawing.Size(67, 13);
            this.lblMenorSald.TabIndex = 30;
            this.lblMenorSald.Text = "Menos saldo";
            // 
            // lblMayorSal
            // 
            this.lblMayorSal.AutoSize = true;
            this.lblMayorSal.Location = new System.Drawing.Point(18, 27);
            this.lblMayorSal.Name = "lblMayorSal";
            this.lblMayorSal.Size = new System.Drawing.Size(64, 13);
            this.lblMayorSal.TabIndex = 29;
            this.lblMayorSal.Text = "Mayor saldo";
            // 
            // mrcInformacion
            // 
            this.mrcInformacion.Controls.Add(this.lblTotalDeSaldos);
            this.mrcInformacion.Controls.Add(this.lblTotal);
            this.mrcInformacion.Controls.Add(this.lblPromedioDeSaldos);
            this.mrcInformacion.Controls.Add(this.lblMenorSaldo);
            this.mrcInformacion.Controls.Add(this.lblMayorSal);
            this.mrcInformacion.Controls.Add(this.lblMenorSald);
            this.mrcInformacion.Controls.Add(this.lblMayorSaldo);
            this.mrcInformacion.Controls.Add(this.lblPromedio);
            this.mrcInformacion.Location = new System.Drawing.Point(282, 50);
            this.mrcInformacion.Name = "mrcInformacion";
            this.mrcInformacion.Size = new System.Drawing.Size(236, 176);
            this.mrcInformacion.TabIndex = 4;
            this.mrcInformacion.TabStop = false;
            this.mrcInformacion.Text = "Informacion";
            // 
            // lblTotalDeSaldos
            // 
            this.lblTotalDeSaldos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalDeSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeSaldos.Location = new System.Drawing.Point(103, 134);
            this.lblTotalDeSaldos.Name = "lblTotalDeSaldos";
            this.lblTotalDeSaldos.Size = new System.Drawing.Size(100, 17);
            this.lblTotalDeSaldos.TabIndex = 36;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 13);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "Total de saldos";
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(447, 232);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(71, 23);
            this.cmdMostrar.TabIndex = 5;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmBusquedaPorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.mrcInformacion);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaPorActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda por actividad";
            this.Load += new System.EventHandler(this.frmBusquedaPorActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.mrcInformacion.ResumeLayout(false);
            this.mrcInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblMenorSaldo;
        private System.Windows.Forms.Label lblPromedioDeSaldos;
        private System.Windows.Forms.Label lblMayorSaldo;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenorSald;
        private System.Windows.Forms.Label lblMayorSal;
        private System.Windows.Forms.GroupBox mrcInformacion;
        private System.Windows.Forms.Label lblTotalDeSaldos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}