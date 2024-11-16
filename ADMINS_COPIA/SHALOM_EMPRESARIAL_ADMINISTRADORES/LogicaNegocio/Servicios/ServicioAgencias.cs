using AccesoDatos.Modelos;
using LogicaNegocio.Interfacez;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class ServicioAgencias:IAgencia
    {
        private ConexionBD conexion; 
        public ServicioAgencias()
        {
            this.conexion = new ConexionBD();
        }

        public DataTable verAgencias()
        {
            DataTable tabla = new DataTable();
            try
            {
                using(MySqlConnection conn= this.conexion.getConexion())
                {
                    string query = "CALL ver_agencias();";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query,conn))
                    {
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return tabla;

        }
        public DataTable verAgencia(string nombre)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_agencia_por_nombre(@nombre);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@nombre",nombre);
                        adaptador.Fill(tabla);
                        return tabla;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return tabla;

        }
        public DataTable verAgenciaProvincia(string provincia)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_agencia_por_provincia(@provincia);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query,conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@provincia", provincia);
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return tabla;
        }
        public bool registrarAgencia(AgenciaModel agencia)
        {
            string nombreAgencia = agencia.getNombreAgencia();
            int provinciaID = agencia.getProvinciaID();
            string direccion = agencia.getDireccion();
            string distrito = agencia.getDistrito();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL registrar_agencia(@nombre,@provincia,@direccion,@distrito);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@nombre",nombreAgencia);
                        comando.Parameters.AddWithValue("@provincia",provinciaID);
                        comando.Parameters.AddWithValue("@direccion",direccion);
                        comando.Parameters.AddWithValue("@distrito",direccion);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public bool actualizarAgencia(AgenciaModel agencia, string nombre)
        {
            string direccion = agencia.getDireccion();
            string distrito = agencia.getDistrito();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL actualizar_agencia(@distrito,@direccion,@nombre);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {                        
                        comando.Parameters.AddWithValue("@distrito", distrito);
                        comando.Parameters.AddWithValue("@direccion",direccion);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public bool eliminarAgencia(string nombreAgencia)
        {
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL eliminar_agencia(@nombre);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreAgencia);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public AgenciaModel verAgenciaBuscada(string nombreAgencia)
        {
            AgenciaModel agencia = new AgenciaModel();

            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_agencia_por_nombre(@nombre);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreAgencia);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                agencia.setAgenciaID(lector.GetInt32(0));
                                agencia.setNombreAgencia(lector.GetString(1));
                                agencia.setNombrePrivincia(lector.GetString(2));
                                agencia.setDireccion(lector.GetString(3));
                                agencia.setDistrito(lector.GetString(4));
                            }
                            return agencia;
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return agencia;
        }
    }
}
