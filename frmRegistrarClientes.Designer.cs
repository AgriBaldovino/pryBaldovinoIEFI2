namespace pryBaldovinoIEFI
{
    partial class frmRegistrarClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarClientes));
            this.mrcCargaDeDatos = new System.Windows.Forms.GroupBox();
            this.mskSaldo = new System.Windows.Forms.MaskedTextBox();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtNombreYApellido = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcCargaDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCargaDeDatos
            // 
            this.mrcCargaDeDatos.Controls.Add(this.mskSaldo);
            this.mrcCargaDeDatos.Controls.Add(this.mskDNI);
            this.mrcCargaDeDatos.Controls.Add(this.lstBarrio);
            this.mrcCargaDeDatos.Controls.Add(this.lblBarrio);
            this.mrcCargaDeDatos.Controls.Add(this.txtNombreYApellido);
            this.mrcCargaDeDatos.Controls.Add(this.lblSaldo);
            this.mrcCargaDeDatos.Controls.Add(this.lstActividad);
            this.mrcCargaDeDatos.Controls.Add(this.lblActividad);
            this.mrcCargaDeDatos.Controls.Add(this.lblDNI);
            this.mrcCargaDeDatos.Controls.Add(this.lblNombreYApellido);
            this.mrcCargaDeDatos.Location = new System.Drawing.Point(12, 12);
            this.mrcCargaDeDatos.Name = "mrcCargaDeDatos";
            this.mrcCargaDeDatos.Size = new System.Drawing.Size(421, 118);
            this.mrcCargaDeDatos.TabIndex = 1;
            this.mrcCargaDeDatos.TabStop = false;
            this.mrcCargaDeDatos.Text = "Carga de datos";
            // 
            // mskSaldo
            // 
            this.mskSaldo.Location = new System.Drawing.Point(284, 28);
            this.mskSaldo.Mask = "99999";
            this.mskSaldo.Name = "mskSaldo";
            this.mskSaldo.Size = new System.Drawing.Size(74, 20);
            this.mskSaldo.TabIndex = 5;
            this.mskSaldo.ValidatingType = typeof(int);
            this.mskSaldo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSaldo_MaskInputRejected);
            this.mskSaldo.TextChanged += new System.EventHandler(this.mskSaldo_TextChanged);
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(118, 57);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(120, 20);
            this.mskDNI.TabIndex = 3;
            this.mskDNI.ValidatingType = typeof(int);
            this.mskDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDNI_MaskInputRejected);
            this.mskDNI.TextChanged += new System.EventHandler(this.mskDNI_TextChanged);
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(284, 56);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(120, 21);
            this.lstBarrio.TabIndex = 6;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(244, 60);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 8;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtNombreYApellido
            // 
            this.txtNombreYApellido.Location = new System.Drawing.Point(118, 28);
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Size = new System.Drawing.Size(120, 20);
            this.txtNombreYApellido.TabIndex = 2;
            this.txtNombreYApellido.TextChanged += new System.EventHandler(this.txtNombreYApellido_TextChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(244, 31);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo";
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(118, 86);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(120, 21);
            this.lstActividad.TabIndex = 4;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(20, 89);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 2;
            this.lblActividad.Text = "Actividad";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(20, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Location = new System.Drawing.Point(20, 31);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(92, 13);
            this.lblNombreYApellido.TabIndex = 0;
            this.lblNombreYApellido.Text = "Nombre y Apellido";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Enabled = false;
            this.cmdRegistrar.Location = new System.Drawing.Point(436, 136);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 7;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(355, 136);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 164);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcCargaDeDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nuevos clientes";
            this.Load += new System.EventHandler(this.frmRegistrarClientes_Load);
            this.mrcCargaDeDatos.ResumeLayout(false);
            this.mrcCargaDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargaDeDatos;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtNombreYApellido;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.MaskedTextBox mskSaldo;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

