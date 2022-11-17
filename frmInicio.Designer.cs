namespace pryBaldovinoIEFI
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeClientesPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gimnasioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ssInicio = new System.Windows.Forms.StatusStrip();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.gimnasioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.toolStripSeparator2,
            this.consultaDeUnClienteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.listadoDeClientesPorBarrioToolStripMenuItem,
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem,
            this.listadoDeSaldosToolStripMenuItem,
            this.listadoDeTodosLosClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Registrar clientes...";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // consultaDeUnClienteToolStripMenuItem
            // 
            this.consultaDeUnClienteToolStripMenuItem.Name = "consultaDeUnClienteToolStripMenuItem";
            this.consultaDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.consultaDeUnClienteToolStripMenuItem.Text = "Consulta de un cliente";
            this.consultaDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(261, 22);
            this.toolStripMenuItem2.Text = "Modificar/ eliminar cliente";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // listadoDeClientesPorBarrioToolStripMenuItem
            // 
            this.listadoDeClientesPorBarrioToolStripMenuItem.Name = "listadoDeClientesPorBarrioToolStripMenuItem";
            this.listadoDeClientesPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeClientesPorBarrioToolStripMenuItem.Text = "Listado de clientes por barrio";
            this.listadoDeClientesPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesPorBarrioToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeUnaCiudadToolStripMenuItem
            // 
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Name = "listadoDeClientesDeUnaCiudadToolStripMenuItem";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Text = "Listado de clientes de una actividad";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeUnaCiudadToolStripMenuItem_Click);
            // 
            // listadoDeSaldosToolStripMenuItem
            // 
            this.listadoDeSaldosToolStripMenuItem.Name = "listadoDeSaldosToolStripMenuItem";
            this.listadoDeSaldosToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeSaldosToolStripMenuItem.Text = "Listado de saldos";
            this.listadoDeSaldosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSaldosToolStripMenuItem_Click);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // gimnasioToolStripMenuItem
            // 
            this.gimnasioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horariosToolStripMenuItem,
            this.agregarDatosToolStripMenuItem});
            this.gimnasioToolStripMenuItem.Name = "gimnasioToolStripMenuItem";
            this.gimnasioToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gimnasioToolStripMenuItem.Text = "Gimnasio";
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.horariosToolStripMenuItem.Text = "Horarios";
            this.horariosToolStripMenuItem.Click += new System.EventHandler(this.horariosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ssInicio
            // 
            this.ssInicio.Location = new System.Drawing.Point(0, 300);
            this.ssInicio.Name = "ssInicio";
            this.ssInicio.Size = new System.Drawing.Size(500, 22);
            this.ssInicio.TabIndex = 1;
            this.ssInicio.Text = "statusStrip1";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarDatosToolStripMenuItem.Text = "Agregar datos a base";
            this.agregarDatosToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 322);
            this.Controls.Add(this.ssInicio);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeUnaCiudadToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip ssInicio;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gimnasioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
    }
}