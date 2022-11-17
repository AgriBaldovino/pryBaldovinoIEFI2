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

            dgvConsultaClientes.Rows.Clear();
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                
                
                clsBarrio Barrio = new clsBarrio();
                String NombreBarrio = "";
                clsActividad Actividad = new clsActividad();
                String NombreActividad = "";
                OleDbDataReader DR = Comando.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        NombreBarrio = Barrio.Buscar(DR.GetInt32(2));
                        NombreActividad = Actividad.Buscar(DR.GetInt32(3));
                        dgvConsultaClientes.Rows.Add(DR.GetInt32(0), DR.GetString(1), NombreBarrio, NombreActividad, DR.GetString(4));
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No");
            }



        }
    }
}
