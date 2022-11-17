namespace pryBaldovinoIEFI
{
    partial class frmAgregarDatos
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
            this.cmdAgregarBarrio = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDetalleBarrio = new System.Windows.Forms.TextBox();
            this.cmdAgregarActividad = new System.Windows.Forms.Button();
            this.mrcActividad = new System.Windows.Forms.GroupBox();
            this.lblCodAct = new System.Windows.Forms.Label();
            this.txtDetalleAct = new System.Windows.Forms.TextBox();
            this.lblDetalleAct = new System.Windows.Forms.Label();
            this.mrcBarrio = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mskCodBarrio = new System.Windows.Forms.MaskedTextBox();
            this.mskCodAct = new System.Windows.Forms.MaskedTextBox();
            this.mrcActividad.SuspendLayout();
            this.mrcBarrio.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAgregarBarrio
            // 
            this.cmdAgregarBarrio.Location = new System.Drawing.Point(105, 84);
            this.cmdAgregarBarrio.Name = "cmdAgregarBarrio";
            this.cmdAgregarBarrio.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregarBarrio.TabIndex = 8;
            this.cmdAgregarBarrio.Text = "Agregar";
            this.cmdAgregarBarrio.UseVisualStyleBackColor = true;
            this.cmdAgregarBarrio.Click += new System.EventHandler(this.cmdAgregarBarrio_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(17, 32);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle";
            // 
            // txtDetalleBarrio
            // 
            this.txtDetalleBarrio.Location = new System.Drawing.Point(72, 29);
            this.txtDetalleBarrio.Name = "txtDetalleBarrio";
            this.txtDetalleBarrio.Size = new System.Drawing.Size(108, 20);
            this.txtDetalleBarrio.TabIndex = 6;
            // 
            // cmdAgregarActividad
            // 
            this.cmdAgregarActividad.Location = new System.Drawing.Point(105, 84);
            this.cmdAgregarActividad.Name = "cmdAgregarActividad";
            this.cmdAgregarActividad.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregarActividad.TabIndex = 4;
            this.cmdAgregarActividad.Text = "Agregar";
            this.cmdAgregarActividad.UseVisualStyleBackColor = true;
            this.cmdAgregarActividad.Click += new System.EventHandler(this.cmdAgregarActividad_Click);
            // 
            // mrcActividad
            // 
            this.mrcActividad.Controls.Add(this.mskCodAct);
            this.mrcActividad.Controls.Add(this.lblCodAct);
            this.mrcActividad.Controls.Add(this.txtDetalleAct);
            this.mrcActividad.Controls.Add(this.lblDetalleAct);
            this.mrcActividad.Controls.Add(this.cmdAgregarActividad);
            this.mrcActividad.Location = new System.Drawing.Point(12, 21);
            this.mrcActividad.Name = "mrcActividad";
            this.mrcActividad.Size = new System.Drawing.Size(206, 122);
            this.mrcActividad.TabIndex = 1;
            this.mrcActividad.TabStop = false;
            this.mrcActividad.Text = "Nueva actividad";
            // 
            // lblCodAct
            // 
            this.lblCodAct.AutoSize = true;
            this.lblCodAct.Location = new System.Drawing.Point(16, 61);
            this.lblCodAct.Name = "lblCodAct";
            this.lblCodAct.Size = new System.Drawing.Size(40, 13);
            this.lblCodAct.TabIndex = 12;
            this.lblCodAct.Text = "Codigo";
            // 
            // txtDetalleAct
            // 
            this.txtDetalleAct.Location = new System.Drawing.Point(72, 29);
            this.txtDetalleAct.Name = "txtDetalleAct";
            this.txtDetalleAct.Size = new System.Drawing.Size(108, 20);
            this.txtDetalleAct.TabIndex = 2;
            // 
            // lblDetalleAct
            // 
            this.lblDetalleAct.AutoSize = true;
            this.lblDetalleAct.Location = new System.Drawing.Point(16, 32);
            this.lblDetalleAct.Name = "lblDetalleAct";
            this.lblDetalleAct.Size = new System.Drawing.Size(40, 13);
            this.lblDetalleAct.TabIndex = 10;
            this.lblDetalleAct.Text = "Detalle";
            // 
            // mrcBarrio
            // 
            this.mrcBarrio.Controls.Add(this.mskCodBarrio);
            this.mrcBarrio.Controls.Add(this.cmdAgregarBarrio);
            this.mrcBarrio.Controls.Add(this.txtDetalleBarrio);
            this.mrcBarrio.Controls.Add(this.lblDetalle);
            this.mrcBarrio.Controls.Add(this.lblCodigo);
            this.mrcBarrio.Location = new System.Drawing.Point(253, 21);
            this.mrcBarrio.Name = "mrcBarrio";
            this.mrcBarrio.Size = new System.Drawing.Size(206, 122);
            this.mrcBarrio.TabIndex = 5;
            this.mrcBarrio.TabStop = false;
            this.mrcBarrio.Text = "Nuevo barrio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 61);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(384, 149);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // mskCodBarrio
            // 
            this.mskCodBarrio.Location = new System.Drawing.Point(72, 58);
            this.mskCodBarrio.Mask = "99999";
            this.mskCodBarrio.Name = "mskCodBarrio";
            this.mskCodBarrio.Size = new System.Drawing.Size(108, 20);
            this.mskCodBarrio.TabIndex = 7;
            this.mskCodBarrio.ValidatingType = typeof(int);
            // 
            // mskCodAct
            // 
            this.mskCodAct.Location = new System.Drawing.Point(72, 58);
            this.mskCodAct.Mask = "99999";
            this.mskCodAct.Name = "mskCodAct";
            this.mskCodAct.Size = new System.Drawing.Size(108, 20);
            this.mskCodAct.TabIndex = 3;
            this.mskCodAct.ValidatingType = typeof(int);
            // 
            // frmAgregarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 182);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.mrcBarrio);
            this.Controls.Add(this.mrcActividad);
            this.Name = "frmAgregarDatos";
            this.Text = "Agregar barrio";
            this.Load += new System.EventHandler(this.frmAgregarDatos_Load);
            this.mrcActividad.ResumeLayout(false);
            this.mrcActividad.PerformLayout();
            this.mrcBarrio.ResumeLayout(false);
            this.mrcBarrio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAgregarBarrio;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtDetalleBarrio;
        private System.Windows.Forms.Button cmdAgregarActividad;
        private System.Windows.Forms.GroupBox mrcActividad;
        private System.Windows.Forms.GroupBox mrcBarrio;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodAct;
        private System.Windows.Forms.TextBox txtDetalleAct;
        private System.Windows.Forms.Label lblDetalleAct;
        private System.Windows.Forms.MaskedTextBox mskCodAct;
        private System.Windows.Forms.MaskedTextBox mskCodBarrio;
    }
}