using AccesoDatos.Modelos;
using LogicaNegocio.Interfacez;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class ServicioCliente:IClientes
    {
        private ConexionBD conexion; 

        public ServicioCliente()
        {
            this.conexion = new ConexionBD();
        }
        public DataTable listarClientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                using(MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL listar_clientes_todos();";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
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
        public DataTable verCliente(int dni)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL listar_clientes(@dni);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@dni", dni);
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
        public bool actualizarCliente(ClientesModel clienteNuevo, int dni)
        {
            
            string nombres = clienteNuevo.getNombresCliente();
            string apellidos = clienteNuevo.getApellidosCliente();

            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL actualizar_cliente(@nombres,@apellidos,@dni);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nombres",nombres);
                        comando.Parameters.AddWithValue("@apellidos",apellidos);
                        comando.Parameters.AddWithValue("@dni",dni);
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
        public ClientesModel clienteBuscado(int dni)
        {
            ClientesModel clienteEncontrado = new ClientesModel();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL listar_clientes(@dni);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@dni",dni);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                clienteEncontrado.setClienteID(lector.GetInt32(0));
                                clienteEncontrado.setDniCliente(lector.GetInt32(1));
                                clienteEncontrado.setNombresCliente(lector.GetString(2));
                                clienteEncontrado.setApellidosCliente(lector.GetString(3));
                                clienteEncontrado.setFechaRegistro(lector.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss"));
                            }
                            return clienteEncontrado;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return clienteEncontrado; 
        }
    }
}
