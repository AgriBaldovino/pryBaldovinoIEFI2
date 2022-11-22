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
    public partial class frmBusquedaPorActividad : Form
    {
        public frmBusquedaPorActividad()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBusquedaPorActividad_Load(object sender, EventArgs e)
        {
            clsActividad CompletarLstAct = new clsActividad();
            CompletarLstAct.llenarLst(lstActividad);
        }
        private void verificacionBoton()
        {
            if (lstActividad.SelectedIndex >= 0)
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBoton();
        }

        private void dgvConsultaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 codActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsClientes ConsultaAct = new clsClientes();
            ConsultaAct.ListarGrillaAct(dgvConsultaCliente, codActividad);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
