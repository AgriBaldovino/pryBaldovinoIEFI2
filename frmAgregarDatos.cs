using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBaldovinoIEFI
{
    public partial class frmAgregarDatos : Form
    {
        public frmAgregarDatos()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAgregarBarrio_Click(object sender, EventArgs e)
        {
            clsBarrio AgregarBarrio = new clsBarrio();

            AgregarBarrio.CodigoBarrio = Convert.ToInt32(mskCodBarrio.Text);
            AgregarBarrio.DetalleBarrio = txtDetalleBarrio.Text;
            
            AgregarBarrio.Agregar();

            MessageBox.Show("Datos cargados con exito");

            LimpiarBarrio();
        }

        private void cmdAgregarActividad_Click(object sender, EventArgs e)
        {
            clsActividad AgregarAct = new clsActividad();

            AgregarAct.CodigoActividad = Convert.ToInt32(mskCodAct.Text);
            AgregarAct.DetalleActividad = txtDetalleAct.Text;

            AgregarAct.Agregar();

            MessageBox.Show("Datos cargados con exito");

            LimpiarAct();
        }

        private void frmAgregarDatos_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarAct()
        {
            txtDetalleAct.Text = "";
            mskCodAct.Text = "";
        }

        private void LimpiarBarrio()
        {
            txtDetalleBarrio.Text = "";
            mskCodBarrio.Text = "";
        }

        private void BloquearBotonAct()
        {
            if (txtDetalleAct.Text != "" && mskCodAct.Text != "")
            {
                cmdAgregarActividad.Enabled = true;
            }
            else
            {
                cmdAgregarActividad.Enabled = false;
            }
        }

        private void BloquearBotonBarrio()
        {
            if (txtDetalleBarrio.Text != "" && mskCodBarrio.Text != "")
            {
                cmdAgregarBarrio.Enabled = true;
            }
            else
            {
                cmdAgregarBarrio.Enabled = false;
            }
        }

        private void txtDetalleAct_TextChanged(object sender, EventArgs e)
        {
            BloquearBotonAct();
        }

        private void mskCodAct_TextChanged(object sender, EventArgs e)
        {
            BloquearBotonAct();
        }

        private void txtDetalleBarrio_TextChanged(object sender, EventArgs e)
        {
            BloquearBotonBarrio();
        }

        private void mskCodBarrio_TextChanged(object sender, EventArgs e)
        {
            BloquearBotonBarrio();
        }
    }
}
