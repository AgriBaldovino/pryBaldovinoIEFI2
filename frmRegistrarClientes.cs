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
    public partial class frmRegistrarClientes : Form
    {
        public OleDbConnection Conexion;
        public OleDbCommand Comando;
        public OleDbDataReader Lector;

        public string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BaseGimnasioIEFI.accdb";

        public frmRegistrarClientes()
        {
            InitializeComponent();
        }

        private void frmAgregarClientes_Load(object sender, EventArgs e)
        {

        }

        private void frmRegistrarClientes_Load(object sender, EventArgs e)
        {
            clsBarrio CompletarLstBarrio = new clsBarrio();
            CompletarLstBarrio.llenarLst(lstBarrio);
            clsActividad CompletarLstAct = new clsActividad();
            CompletarLstAct.llenarLst(lstActividad);
        }
        private void verificacionBotones()
        {
            if (txtNombreYApellido.Text != "" && mskDNI.Text != "" && mskSaldo.Text != "" && lstBarrio.SelectedIndex >= 0 && lstActividad.SelectedIndex >= 0)
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;
            }
        }

        private void txtNombreYApellido_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void mskDNI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacionBotones();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void mskSaldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskSaldo_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void mskDNI_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            clsClientes AgregarCliente = new clsClientes();

            AgregarCliente.DniCliente = Convert.ToInt32(mskDNI.Text);
            AgregarCliente.Nombre = txtNombreYApellido.Text;
            AgregarCliente.SaldoCliente = Convert.ToInt32(mskSaldo.Text);
            AgregarCliente.ActividadCliente = Convert.ToInt32(lstActividad.SelectedValue);
            AgregarCliente.BarrioCliente = Convert.ToInt32(lstBarrio.SelectedValue);
            
            AgregarCliente.Agregar();

            MessageBox.Show("Datos cargados con exito");
            
            //Limpiar();

        }

        private void ToInt32(object selectedItem)
        {
            throw new NotImplementedException();
        }
    }
}
