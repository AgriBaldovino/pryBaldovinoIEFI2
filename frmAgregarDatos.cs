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
        }

        private void cmdAgregarActividad_Click(object sender, EventArgs e)
        {
            clsActividad AgregarAct = new clsActividad();

            AgregarAct.CodigoActividad = Convert.ToInt32(mskCodAct.Text);
            AgregarAct.DetalleActividad = txtDetalleAct.Text;

            AgregarAct.Agregar();

            MessageBox.Show("Datos cargados con exito");
        }

        private void frmAgregarDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
