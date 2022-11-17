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
    internal class clsActividad
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();

        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BaseGimnasioIEFI.accdb";
        private string Tabla = "Actividad";

        //Declaro de manera local las variables 
        private Int32 varCodigoActividad;
        private string varActividad;
        public Int32 CodigoActividad
        {
            get { return varCodigoActividad; }
            set { varCodigoActividad = value; }
        }
        public string DetalleActividad
        {
            get { return varActividad; }
            set { varActividad = value; }
        }
        public void llenarLst(ComboBox lstActividad)
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
            lstActividad.DataSource = DataConsulta.Tables[0];

            //Los datos que queremos que se vean en la lst
            lstActividad.DisplayMember = "Detalle";

            //Dato que no se veria
            lstActividad.ValueMember = "CodigoActividad";
            Conexion.Close();
        }

        public void Buscar()
        {
            try
            {
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();

                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                Comando.CommandText = Tabla;
                //Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay registros ingresa
                if (Lector.HasRows)
                {
                    //Mientras tenga datos en la tabla, lo va a leer
                    while (Lector.Read())
                    {
                        //if (Lector.GetInt32(0) == dni)
                        {
                            //DniCliente = Lector.GetInt32(0);
                            //NombreYApellido = Lector.GetString(1);
                            //Barrio = Lector.GetInt32(2);
                            //Actividad = Lector.GetInt32(3);
                            //Saldo = Lector.GetInt32(4);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El cliente no esta registrado en la base de datos");
            }
            Conexion.Close();
        }
        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO Actividad ([CodigoActividad], [Detalle]) " + "VALUES (" + CodigoActividad + ",'" + DetalleActividad + "')";
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

        public String Buscar(Int32 CodigoActividad)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader DR = Comando.ExecuteReader();
                string Resultado2 = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == CodigoActividad)
                        {
                            Resultado2 = DR.GetString(1);
                        }

                    }
                }
                Conexion.Close();
                return Resultado2;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
