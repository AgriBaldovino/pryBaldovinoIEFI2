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
    public partial class frmBusquedaPorBarrio : Form
    {
        public frmBusquedaPorBarrio()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBusquedaPorBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio CompletarLstAct = new clsBarrio();
            CompletarLstAct.llenarLst(lstBarrio);
        }
        private void verificacionBoton()
        {
            if (lstBarrio.SelectedIndex >= 0)
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBoton();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 codBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            clsClientes ConsultaBarrio = new clsClientes();
            ConsultaBarrio.ListarGrillaBarrio(dgvConsultaCliente, codBarrio);
        }
    }
}
