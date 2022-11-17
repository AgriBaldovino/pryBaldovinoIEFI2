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
    public partial class frmListadoDeSaldos : Form
    {
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        public OleDbDataReader Lector;
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BaseGimnasioIEFI.accdb";
        private string Tabla = "Gimnasio";

        decimal TotalSaldos;
        decimal cantInscriptos;
        decimal promedio;

        public frmListadoDeSaldos()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoDeSaldos_Load(object sender, EventArgs e)
        {

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            cantInscriptos = 0;
            TotalSaldos = 0;
            promedio = 0;

            dgvConsultaCliente.Rows.Clear();
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();

                Comando = new OleDbCommand();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "Gimnasio";

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    dgvConsultaCliente.Rows.Add(Lector[0], Lector[1], Lector[4]);
                    cantInscriptos++;
                    TotalSaldos = TotalSaldos + Lector.GetInt32(4);
                    promedio = TotalSaldos / cantInscriptos;
                }
                Lector.Close();
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            lblCantidadDeInscriptos.Text = Convert.ToString(cantInscriptos);
            lblTotalSaldos.Text = Convert.ToString(TotalSaldos);
            lblPromedioDeSaldos.Text = Convert.ToString(promedio);
        }

        private void bloqueoBoton()
        {
            //Si la dgv tiene registros entonces desbloquear boton "Mostrar"
            //if ()
            //{
               



            //}

        }


    }
}
