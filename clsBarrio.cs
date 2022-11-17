using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryBaldovinoIEFI
{
    internal class clsBarrio
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BaseGimnasioIEFI.accdb";
        private string Tabla = "Barrio";

        //Declaro de manera local las variables 
        private Int32 varCodigo;
        private string varBarrio;
        public Int32 CodigoBarrio
        {
            get { return varCodigo; }
            set { varCodigo = value; }
        }
        public string DetalleBarrio
        {
            get { return varBarrio; }
            set { varBarrio = value; }
        }
        public void llenarLst(ComboBox lstBarrio)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = Tabla;

            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);

            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            lstBarrio.DataSource = DataConsulta.Tables[0];

            //Los datos que queremos que se vean en la lst
            lstBarrio.DisplayMember = "Detalle";

            //Dato que no se veria
            lstBarrio.ValueMember = "CodigoBarrio";
            Conexion.Close();
        }

        public string Buscar(Int32 codBarrio)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader DR = Comando.ExecuteReader();
                string Resultado = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == codBarrio)
                        {
                            Resultado = DR.GetString(1);
                        }
                    }
                }
                Conexion.Close();
                return Resultado;
            }
            catch (Exception)
            {
                
            }
        }
        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO Barrio ([CodigoBarrio], [Detalle]) " + "VALUES (" + CodigoBarrio + ",'" + DetalleBarrio + "')";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido registrar el dato");
            }
            
        }
    }
}
