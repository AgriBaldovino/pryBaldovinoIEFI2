namespace pryBaldovinoIEFI
{
    partial class frmModificarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCliente));
            this.mrcModificacionDeDatos = new System.Windows.Forms.GroupBox();
            this.mskSaldo = new System.Windows.Forms.MaskedTextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtNombreYApellido = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.lblIngreseDNI = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.mrcModificacionDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcModificacionDeDatos
            // 
            this.mrcModificacionDeDatos.Controls.Add(this.mskSaldo);
            this.mrcModificacionDeDatos.Controls.Add(this.lstActividad);
            this.mrcModificacionDeDatos.Controls.Add(this.lblActividad);
            this.mrcModificacionDeDatos.Controls.Add(this.lstBarrio);
            this.mrcModificacionDeDatos.Controls.Add(this.lblBarrio);
            this.mrcModificacionDeDatos.Controls.Add(this.txtNombreYApellido);
            this.mrcModificacionDeDatos.Controls.Add(this.lblSaldo);
            this.mrcModificacionDeDatos.Controls.Add(this.lblNombreYApellido);
            this.mrcModificacionDeDatos.Location = new System.Drawing.Point(15, 81);
            this.mrcModificacionDeDatos.Name = "mrcModificacionDeDatos";
            this.mrcModificacionDeDatos.Size = new System.Drawing.Size(436, 99);
            this.mrcModificacionDeDatos.TabIndex = 4;
            this.mrcModificacionDeDatos.TabStop = false;
            this.mrcModificacionDeDatos.Text = "Modificacion de datos";
            // 
            // mskSaldo
            // 
            this.mskSaldo.Location = new System.Drawing.Point(284, 28);
            this.mskSaldo.Mask = "99999";
            this.mskSaldo.Name = "mskSaldo";
            this.mskSaldo.ReadOnly = true;
            this.mskSaldo.Size = new System.Drawing.Size(74, 20);
            this.mskSaldo.TabIndex = 11;
            this.mskSaldo.ValidatingType = typeof(int);
            this.mskSaldo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSaldo_MaskInputRejected);
            this.mskSaldo.ReadOnlyChanged += new System.EventHandler(this.mskSaldo_ReadOnlyChanged);
            this.mskSaldo.TextChanged += new System.EventHandler(this.mskSaldo_TextChanged);
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
            this.lstActividad.Location = new System.Drawing.Point(118, 60);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(120, 21);
            this.lstActividad.TabIndex = 6;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(20, 63);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 10;
            this.lblActividad.Text = "Actividad";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Items.AddRange(new object[] {
            "Nueva Cordoba",
            "Centro",
            "General Paz",
            "Zona Norte",
            "Zona Sur"});
            this.lstBarrio.Location = new System.Drawing.Point(284, 60);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(129, 21);
            this.lstBarrio.TabIndex = 8;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(244, 63);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 8;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtNombreYApellido
            // 
            this.txtNombreYApellido.Location = new System.Drawing.Point(118, 28);
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.ReadOnly = true;
            this.txtNombreYApellido.Size = new System.Drawing.Size(120, 20);
            this.txtNombreYApellido.TabIndex = 5;
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
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Location = new System.Drawing.Point(20, 31);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(92, 13);
            this.lblNombreYApellido.TabIndex = 0;
            this.lblNombreYApellido.Text = "Nombre y Apellido";
            // 
            // lblIngreseDNI
            // 
            this.lblIngreseDNI.AutoSize = true;
            this.lblIngreseDNI.Location = new System.Drawing.Point(12, 23);
            this.lblIngreseDNI.Name = "lblIngreseDNI";
            this.lblIngreseDNI.Size = new System.Drawing.Size(64, 13);
            this.lblIngreseDNI.TabIndex = 10;
            this.lblIngreseDNI.Text = "Ingrese DNI";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(380, 186);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(71, 23);
            this.cmdModificar.TabIndex = 9;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(149, 186);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(71, 23);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(82, 20);
            this.mskDNI.Mask = "99999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(100, 20);
            this.mskDNI.TabIndex = 1;
            this.mskDNI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDNI_MaskInputRejected);
            this.mskDNI.TextChanged += new System.EventHandler(this.mskDNI_TextChanged);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(107, 46);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 13;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(226, 186);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(71, 23);
            this.cmdEliminar.TabIndex = 14;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(303, 186);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(71, 23);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 213);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblIngreseDNI);
            this.Controls.Add(this.mrcModificacionDeDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar datos de cliente";
            this.Load += new System.EventHandler(this.frmModificarCliente_Load);
            this.mrcModificacionDeDatos.ResumeLayout(false);
            this.mrcModificacionDeDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcModificacionDeDatos;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtNombreYApellido;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.Label lblIngreseDNI;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.MaskedTextBox mskSaldo;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdGuardar;
    }
}