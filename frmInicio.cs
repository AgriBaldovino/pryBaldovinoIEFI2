using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoIEFI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarClientes objvent = new frmRegistrarClientes();
            objvent.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                //Con esto indico que la base de datos se conecto de manera exitosa
                ssInicio.BackColor = Color.Green;
            }
            catch (Exception Indicador)
            {
                //Con esto indico que no se pudo conectar con la base de datos
                ssInicio.BackColor = Color.Red;
            }
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCliente objvent = new frmConsultarCliente();
            objvent.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificarCliente objvent = new frmModificarCliente();
            objvent.ShowDialog();
        }

        private void listadoDeClientesPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaPorBarrio objvent = new frmBusquedaPorBarrio();
            objvent.ShowDialog();
        }

        private void listadoDeClientesDeUnaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaPorActividad objvent = new frmBusquedaPorActividad();
            objvent.ShowDialog();
        }

        private void listadoDeSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeSaldos objvent = new frmListadoDeSaldos();
            objvent.ShowDialog();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarTodosLosClientes objvent = new frmConsultarTodosLosClientes();
            objvent.ShowDialog();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno objvent = new frmAlumno();
            objvent.ShowDialog();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorarios objvent = new frmHorarios();
            objvent.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarDatos objvent = new frmAgregarDatos();
            objvent.ShowDialog();
        }
    }
}
