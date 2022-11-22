using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace pryBaldovinoIEFI
{
    internal class clsClientes
    {
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BaseGimnasioIEFI.accdb";
        private string Tabla = "Gimnasio";

        private Int32 DNI;
        private string NombreYApellido;
        private Int32 Barrio;
        private Int32 Actividad;
        private Int32 Saldo;

        public Int32 DniCliente
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public string Nombre
        {
            get { return NombreYApellido; }
            set { NombreYApellido = value; }
        }
        public Int32 BarrioCliente
        {
            get { return Barrio; }
            set { Barrio = value; }
        }
        public Int32 ActividadCliente
        {
            get { return Actividad; }
            set { Actividad = value; }
        }
        public Int32 SaldoCliente
        {
            get { return Saldo; }
            set { Saldo = value; }
        }

        public void Buscar(Int32 dni)
        {
            try
            {
                //Conecto la base de datos
                Conexion.ConnectionString = CadenaConexion;
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
                        if (Lector.GetInt32(0) == dni)
                        {
                            DniCliente = Lector.GetInt32(0);
                            NombreYApellido = Lector.GetString(1);
                            Barrio = Lector.GetInt32(2);
                            Actividad = Lector.GetInt32(3);
                            Saldo = Lector.GetInt32(4);
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

        internal bool Read()
        {
            throw new NotImplementedException();
        }

        public void Modificar(Int32 dniModificar)
        {
            try
            {
                string Sql = "UPDATE Gimnasio SET [DNI]= " + DniCliente + ", [NombreYApellido]= '" + Nombre + "', [Barrio]= " + BarrioCliente + ", [Actividad]= " + ActividadCliente + ", [Saldo]= " + SaldoCliente + " WHERE " + dniModificar + "= [DNI]";

                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();

                Comando.Connection = Conexion;

                Comando.CommandType = CommandType.Text;

                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public void Eliminar(Int32 DNIeliminar)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();

                string Sql = "DELETE FROM Gimnasio WHERE (" + DNIeliminar + "= [DNI])";

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar cliente");
            }
            Conexion.Close();
        }

        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO Gimnasio ([DNI], [NombreYApellido], [Barrio], [Actividad], [Saldo])" +
                    "VALUES ('" + DniCliente + "','" + Nombre + "','" + BarrioCliente + "','" + ActividadCliente + "','" + SaldoCliente + "')";
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido registrar el dato");
            }
            Conexion.Close();
        }

        public void ListarClientes(DataGridView dgvConsultaClientes)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader DR = Comando.ExecuteReader();
                clsBarrio Barrio = new clsBarrio();
                String DetalleBarrio = "";
                clsActividad Actividad = new clsActividad();
                String DetalleActividad = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        DetalleBarrio = Barrio.Buscar(DR.GetInt32(2));
                        DetalleActividad = Actividad.Buscar(DR.GetInt32(3));
                        dgvConsultaClientes.Rows.Add(DR.GetInt32(0), DR.GetString(1), DetalleBarrio, DetalleActividad, DR.GetInt32(4));
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        public void ListarGrillaAct(DataGridView dgvConsultaCliente, Int32 CodActividad)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                dgvConsultaCliente.Rows.Clear();
                OleDbDataReader Lector = Comando.ExecuteReader();
                
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(3) == CodActividad)
                        {
                            //cambia los codigos de act y barrio por sus respectivos detalles

                            Int32 codBarrio = Lector.GetInt32(2);
                            Int32 codAct = Lector.GetInt32(3);

                            clsBarrio BarrioConsulta = new clsBarrio();
                            BarrioConsulta.Buscar(codBarrio);
                            clsActividad ActConsulta = new clsActividad();
                            ActConsulta.Buscar(codAct);

                            dgvConsultaCliente.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), BarrioConsulta.CodigoBarrio, ActConsulta.CodigoActividad, Lector.GetInt32(4));

                        }


                    }
                    
                    
                    //MessageBox.Show("No hay clientes que realicen esa actividad");
                    
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la informacion");
            }
        }

        public void ListarGrillaBarrio(DataGridView dgvConsultaCliente, Int32 CodBarrio)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                dgvConsultaCliente.Rows.Clear();
                OleDbDataReader Lector = Comando.ExecuteReader();

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(2) == CodBarrio)
                        {
                            //cambia los codigos de act y barrio por sus respectivos detalles

                            Int32 codBarrio = Lector.GetInt32(2);
                            Int32 codAct = Lector.GetInt32(3);

                            clsBarrio BarrioConsulta = new clsBarrio();
                            BarrioConsulta.Buscar(codBarrio);
                            clsActividad ActConsulta = new clsActividad();
                            ActConsulta.Buscar(codAct);

                            dgvConsultaCliente.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), BarrioConsulta.CodigoBarrio, ActConsulta.CodigoActividad, Lector.GetInt32(4));

                        }


                    }


                    //MessageBox.Show("No hay clientes que realicen esa actividad");

                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la informacion");
            }
        }

        public void ListarGrillaConsultaCliente(DataGridView dgvConsultarCliente, Int32 dni)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader DR = Comando.ExecuteReader();
                clsBarrio Barrio = new clsBarrio();
                String DetalleBarrio = "";
                clsActividad Actividad = new clsActividad();
                String DetalleActividad = "";

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == dni)
                        {

                            DetalleBarrio = Barrio.Buscar(DR.GetInt32(2));
                            DetalleActividad = Actividad.Buscar(DR.GetInt32(3));
                            dgvConsultarCliente.Rows.Add(DR.GetInt32(0), DR.GetString(1), DetalleBarrio, DetalleActividad, DR.GetInt32(4));

                        }
                    }
                    //MessageBox.Show("No hay clientes que realicen esa actividad");

                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la informacion");
            }

        }

        public void ExportarClientesSaldos()
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader Lector = Comando.ExecuteReader();

                //Creo el excel para enviar datos
                StreamWriter ExportarDatos = new StreamWriter("ExportarSaldosClientes.csv", false, Encoding.UTF8);
                ExportarDatos.WriteLine("Listado de Socios");
                ExportarDatos.WriteLine("DNI;Nombre y Apellido;Saldo");

                //VarCantCliente = 0;
                //VarTotalIngreso = 0;
                //VarPromedio = 0;
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        Int32 codBarrio = Lector.GetInt32(2);
                        Int32 codAct = Lector.GetInt32(3);
                            
                        clsBarrio BarrioConsulta = new clsBarrio();
                        BarrioConsulta.Buscar(codBarrio);
                        clsActividad ActConsulta = new clsActividad();
                        ActConsulta.Buscar(codAct);
                            
                        ExportarDatos.Write(Lector.GetInt32(0));
                        ExportarDatos.Write(";");
                        ExportarDatos.Write(Lector.GetString(1));
                        ExportarDatos.Write(";");
                        ExportarDatos.Write(Lector.GetInt32(4));
                        ExportarDatos.Write(";");
                        ExportarDatos.Write("\n");
                        
                    }
                    ExportarDatos.Write("Cantidad de socios:");
                    //ExportarDatos.WriteLine(VarCantCliente);
                    ExportarDatos.Write("\n");
                    ExportarDatos.Write("Total de saldo:");
                    //ExportarDatos.WriteLine(VarTotalIngreso);
                    ExportarDatos.Write("\n");
                    ExportarDatos.Write("Promedio:");
                    //ExportarDatos.WriteLine(VarPromedio);
                    ExportarDatos.Write("\n");
                }
                Conexion.Close();
                ExportarDatos.Close();
                MessageBox.Show("Tus datos han sido exportados correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al exportar los datos");

            }
        }



















    }
}
