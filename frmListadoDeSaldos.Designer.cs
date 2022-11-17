namespace pryBaldovinoIEFI
{
    partial class frmListadoDeSaldos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeSaldos));
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotaldSaldos = new System.Windows.Forms.Label();
            this.lblCantInscriptos = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.lblPromedioDeSaldos = new System.Windows.Forms.Label();
            this.lblCantidadDeInscriptos = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this.dgvConsultaCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.ReadOnly = true;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(343, 259);
            this.dgvConsultaCliente.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y apellido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblTotaldSaldos
            // 
            this.lblTotaldSaldos.AutoSize = true;
            this.lblTotaldSaldos.Location = new System.Drawing.Point(19, 325);
            this.lblTotaldSaldos.Name = "lblTotaldSaldos";
            this.lblTotaldSaldos.Size = new System.Drawing.Size(95, 13);
            this.lblTotaldSaldos.TabIndex = 23;
            this.lblTotaldSaldos.Text = "Total de los saldos";
            // 
            // lblCantInscriptos
            // 
            this.lblCantInscriptos.AutoSize = true;
            this.lblCantInscriptos.Location = new System.Drawing.Point(19, 361);
            this.lblCantInscriptos.Name = "lblCantInscriptos";
            this.lblCantInscriptos.Size = new System.Drawing.Size(111, 13);
            this.lblCantInscriptos.TabIndex = 24;
            this.lblCantInscriptos.Text = "Cantidad de inscriptos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(19, 400);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(99, 13);
            this.lblPromedio.TabIndex = 25;
            this.lblPromedio.Text = "Promedio de saldos";
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSaldos.Location = new System.Drawing.Point(136, 324);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(100, 17);
            this.lblTotalSaldos.TabIndex = 26;
            // 
            // lblPromedioDeSaldos
            // 
            this.lblPromedioDeSaldos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPromedioDeSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeSaldos.Location = new System.Drawing.Point(136, 399);
            this.lblPromedioDeSaldos.Name = "lblPromedioDeSaldos";
            this.lblPromedioDeSaldos.Size = new System.Drawing.Size(100, 17);
            this.lblPromedioDeSaldos.TabIndex = 27;
            // 
            // lblCantidadDeInscriptos
            // 
            this.lblCantidadDeInscriptos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidadDeInscriptos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadDeInscriptos.Location = new System.Drawing.Point(136, 360);
            this.lblCantidadDeInscriptos.Name = "lblCantidadDeInscriptos";
            this.lblCantidadDeInscriptos.Size = new System.Drawing.Size(100, 17);
            this.lblCantidadDeInscriptos.TabIndex = 28;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(199, 441);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(280, 441);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 3;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(280, 277);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 2;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmListadoDeSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 476);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblCantidadDeInscriptos);
            this.Controls.Add(this.lblPromedioDeSaldos);
            this.Controls.Add(this.lblTotalSaldos);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantInscriptos);
            this.Controls.Add(this.lblTotaldSaldos);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldos";
            this.Load += new System.EventHandler(this.frmListadoDeSaldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblTotaldSaldos;
        private System.Windows.Forms.Label lblCantInscriptos;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Label lblPromedioDeSaldos;
        private System.Windows.Forms.Label lblCantidadDeInscriptos;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button cmdConsultar;
    }
}