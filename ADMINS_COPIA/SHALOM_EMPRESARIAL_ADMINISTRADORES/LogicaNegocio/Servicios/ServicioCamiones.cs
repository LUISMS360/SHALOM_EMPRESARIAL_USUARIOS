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
    public  class ServicioCamiones:ICamiones
    {
        private ConexionBD conexion;
        public ServicioCamiones()
        {
            this.conexion = new ConexionBD();
        }
        public DataTable verCamiones()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_camiones();"; 
                    using(MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.ToString());
            }
            return tabla;
        }
        public DataTable verCamion(string placa)
        {
            DataTable tabla = new DataTable();
            try
            {
                using(MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_camion(@placa);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@placa", placa);
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
        public bool registrarCamion(CamionesModel camion)
        {
            string placa = camion.getPlaca();
            int conductor = camion.getConductorID();
            string info = camion.getInformacion();
            int origen = camion.getProvinciaIdOrigen();
            int destino = camion.getProvinciaIdDestino();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL registrar_camion(@placa,@conductor,@info,@origen,@destino);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@placa",placa);
                        comando.Parameters.AddWithValue("@conductor",conductor);
                        comando.Parameters.AddWithValue("@info",info);
                        comando.Parameters.AddWithValue("@origen", origen);
                        comando.Parameters.AddWithValue("@destino", destino);
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
        public bool actualizarCamion(CamionesModel camion, string placa)
        {
            string nuevaPlaca = camion.getPlaca();
            int nuevoConductor = camion.getConductorID();
            string info = camion.getInformacion();
            string placaAntigua = placa;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL actualizar_camion(@nuevaPlaca,@nuevoConductor,@info,@placaAntigua);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nuevaPlaca",nuevaPlaca);
                        comando.Parameters.AddWithValue("@nuevoConductor",nuevoConductor);
                        comando.Parameters.AddWithValue("@info",info);
                        comando.Parameters.AddWithValue("@placaAntigua",placaAntigua);
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
        public bool eliminarCamion(string placa)
        {
            try
            {
                using(MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL eliminar_camion(@placa);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@placa", placa);
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
        public CamionesModel verCamionBuscado(string placa)
        {
            CamionesModel camion = new CamionesModel();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_camion(@placa);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@placa", placa);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                camion.setCamionID(lector.GetInt32(0));
                                camion.setPlaca(lector.GetString(1));
                                camion.setApellidosConductor(lector.GetString(2));
                                camion.setInformacion(lector.GetString(3));
                                camion.setEstado(lector.GetString(4));
                                camion.setFechaInscripcion(lector.GetDateTime(5).ToString("yyyy-MM-dd HH:mm:ss"));
                                camion.setProvinciaOrigenNom(lector.GetString(6));
                                camion.setProvinciaDestinoNom(lector.GetString(7));
                            }
                            return camion;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return camion;
        }
        public int obtenerIdProvincia(string nombreProvincia)
        {
            int provinciaId = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_provincia(@nombre);";
                    using(MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreProvincia);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                provinciaId = lector.GetInt32(0);
                            }
                            return provinciaId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return provinciaId;
        }
        public List<string> obtenerConductores()
        {
            List<string> conductores = new List<string>();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_conductores_sin_carro();";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                conductores.Add(lector.GetString("Conductor"));
                            }
                            return conductores;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return conductores;
        }
        public int obtenerIdConductor(string usuario)
        {
            int id = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtenerNombreID(@usuario);";
                    using(MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);

                        using(MySqlDataReader lector = comando.ExecuteReader()){

                            while (lector.Read())
                            {
                                id = lector.GetInt32(0);
                            }
                            return id;
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return id; 
        }
    }
}
