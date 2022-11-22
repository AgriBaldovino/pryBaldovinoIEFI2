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
    public partial class frmConsultarCliente : Form
    {
        public OleDbConnection Conexion = new OleDbConnection();
        public OleDbCommand Comando = new OleDbCommand();
        public OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        public string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BaseGimnasioIEFI.accdb";
        public string Tabla = "Gimnasio";

        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {

        }
        private void verificacionBoton()
        {
            if (mskDNI.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        private void mskDNI_TextChanged(object sender, EventArgs e)
        {
            verificacionBoton();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 dni = Convert.ToInt32(mskDNI.Text);
            clsClientes BuscarC = new clsClientes();
            BuscarC.ListarGrillaConsultaCliente(dgvConsultarCliente, dni);



        }
    }
}
