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
    public partial class frmConsultarTodosLosClientes : Form
    {
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        public OleDbDataReader Lector;
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BaseGimnasioIEFI.accdb";
        private string Tabla = "Gimnasio";

        public frmConsultarTodosLosClientes()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            clsBarrio Barrio = new clsBarrio();
            clsActividad Actividad = new clsActividad();

            clsClientes Clientes = new clsClientes();

            
        }
    }
}
