using AccesoDatos.Modelos;
using LogicaNegocio.Interfacez;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace LogicaNegocio.Servicios
{
    public class ServicioEnvios:IEnvio
    {
        private ConexionBD conexion;
        public ServicioEnvios() {
            this.conexion = new ConexionBD();
        }

        //Implementamos el metodo para poder listar todos los envios 
        public DataTable listarTodosEnvios()
        {
            DataTable tabla1 = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_envios();";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                       
                        adaptador.Fill(tabla1);                        
                        return tabla1;
                    }
                }
            }
            catch (Exception)
            {
                return tabla1;
            }
        }

        //Implementacion del registrar un envio 
        public bool registrarEnvio(EnviosModel envio)
        {
            int dniEmisor = envio.getDniEmisor();
            string nombresEmisor = envio.getNombreEmisor();
            string apellidosEmisor = envio.getApellidosEmisor();
            string servicio = envio.getServicio();
            string tipoPaquete = envio.getTipoPaquete();
            double peso = envio.getPeso();
            string contenido = envio.getContenido();
            int dniReceptor = envio.getDniReceptor();
            string nombreRecepetor = envio.getNombresReceptor();
            string apellidosReceptor = envio.getApellidosReceptor();
            int agenciaOrigen = envio.getAgenciaOrigenID();
            int agenciaDestino = envio.getAgenciaDestinoID();
            int camion_id = envio.getCamionId();
            double totalPagar = envio.getTotal();
            int admin = envio.getAdministradorID();

            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL registrar_envio(@dniEmisor,@nombresEmisor,@apellidosEmisor" +
                        ",@servicio,@tipoPaquete,@peso,@contenido,@dniReceptor,@nombresReceptor,@apellidosReceptor," +
                        "@id_agenciaOrigen,@id_agenciaDestino,@camionId,@totalPagar,@adminId);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@dniEmisor",dniEmisor);
                        comando.Parameters.AddWithValue("@nombresEmisor",nombresEmisor);
                        comando.Parameters.AddWithValue("@apellidosEmisor",apellidosEmisor);
                        comando.Parameters.AddWithValue("@servicio",servicio);
                        comando.Parameters.AddWithValue("@tipoPaquete",tipoPaquete);
                        comando.Parameters.AddWithValue("@peso",peso);
                        comando.Parameters.AddWithValue("@contenido",contenido);
                        comando.Parameters.AddWithValue("@dniReceptor",dniReceptor);
                        comando.Parameters.AddWithValue("@nombresReceptor",nombreRecepetor);
                        comando.Parameters.AddWithValue("@apellidosReceptor",apellidosReceptor);
                        comando.Parameters.AddWithValue("@id_agenciaOrigen",agenciaOrigen);
                        comando.Parameters.AddWithValue("@id_agenciaDestino",agenciaDestino);
                        comando.Parameters.AddWithValue("@camionId",camion_id);
                        comando.Parameters.AddWithValue("@totalPagar",totalPagar);
                        comando.Parameters.AddWithValue("@adminId",admin);

                        comando.ExecuteNonQuery();
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false; ;
        }

        //Implementacion del metodo para poder eliminar un envio
        public bool eliminarEnvio(int dniEliminar,int id)
        {
            int resultado = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL eliminar_envio(@dni,@id);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@dni", dniEliminar);
                        comando.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                resultado = lector.GetInt32(0);
                            }
                            if (resultado > 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        //Implementacion para poder Actualizar un envio
        public bool actualizarEnvio(EnviosModel envio, int envioID)
        {
            int dniRecpetor = envio.getDniReceptor();
            string nombresReceptor = envio.getNombresReceptor();
            string apellidosReceptor = envio.getApellidosReceptor();
            int agenciaDestino = envio.getAgenciaDestinoID();
            int camion = envio.getCamionId();
            double total = envio.getTotal();
            string estadoPago = envio.getEstadoPago();
            string estadoEnvio = envio.getEstadoEnvio();
            int envio_id = envioID;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL actualizar_envio(@destinatario,@nombres,@apellidos,@destino," +
                        "@camion,@total,@estadoEnvio,@estadoPago,@envio_id);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@destinatario",dniRecpetor);
                        comando.Parameters.AddWithValue("@nombres",nombresReceptor);
                        comando.Parameters.AddWithValue("@apellidos",apellidosReceptor);
                        comando.Parameters.AddWithValue("@destino",agenciaDestino);
                        comando.Parameters.AddWithValue("@camion",camion);
                        comando.Parameters.AddWithValue("@total",total);
                        comando.Parameters.AddWithValue("@estadoEnvio",estadoEnvio);
                        comando.Parameters.AddWithValue("@estadoPago",estadoPago);
                        comando.Parameters.AddWithValue("@envio_id",envio_id);
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
        public DataTable verEnvio(int dniCliente)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL seguir_envio(@dni);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@dni", dniCliente);
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return tabla;
        }

        //Implementacion del metodo para ver un envio de una fecha a otra
        public DataTable verEnvioFecha(string fechaInicio, string fechaFin)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {

                    string query = "CALL ver_envio_fecha(@fechaInicio,@fechaFin);";
                    using (MySqlDataAdapter adaptador = new  MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@fechaInicio",fechaInicio);
                        adaptador.SelectCommand.Parameters.AddWithValue("@fechaFin",fechaFin);
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

        //Implementacion para poder ver los envios de origen
        public DataTable verEnvioOrigen(int origen)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_envios_origen(@agenciaOrigen);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@agenciaOrigen", origen);
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

        //Implementeacion para ver los envios de destino
        public DataTable verEnvioDestino(int destino)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_envios_destino(@destino);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@destino", destino);
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
        public EnviosModel verEnvioBuscado(int dniCliente,int id)
        {
            EnviosModel envioEncontrado = new EnviosModel();
            envioEncontrado.setNroenvio(0);
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL seguir_envio_buscado(@dniCliente,@id);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@dniCliente", dniCliente);
                        comando.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                envioEncontrado.setNroenvio(lector.GetInt32(0));
                                envioEncontrado.setDniEmisor(lector.GetInt32(1));
                                envioEncontrado.setServicio(lector.GetString(2));
                                envioEncontrado.setTipoPaquete(lector.GetString(3));
                                envioEncontrado.setPeso(lector.GetDouble(4));
                                envioEncontrado.setContenido(lector.GetString(5));
                                envioEncontrado.setDniReceptor(lector.GetInt32(6));
                                envioEncontrado.setAgenciaOrigen(lector.GetString(7));
                                envioEncontrado.setAgenciaDestino(lector.GetString(8));
                                envioEncontrado.setCamion(lector.GetString(9));
                                envioEncontrado.setTotal(lector.GetDouble(10));
                                envioEncontrado.setEstadoEnvio(lector.GetString(11));                                
                                envioEncontrado.setAdministradorNom(lector.GetString(12));
                                envioEncontrado.setEstadoPago(lector.GetString(13));
                                envioEncontrado.setFechaEnvio((lector.GetDateTime(14).ToString("yyyy-MM-dd HH:mm:ss")));
                            }
                            return envioEncontrado;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return envioEncontrado;
        }
        public List<string> obtenerAgencias(string provincia)
        {
            List<string> nombresAgencias = new List<string>();

            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {                    
                    string query = "CALL agregar_agencias(@provincia);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@provincia",provincia);

                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                nombresAgencias.Add(lector.GetString("NombreAgencia"));
                            }
                            return nombresAgencias;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return nombresAgencias;
        }
        public int obtenerIdAgencia(string nombreAgencia)
        {
            int agenciaId = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL  obtener_agenciaid(@nombreAgencia);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@nombreAgencia", nombreAgencia);
                        using(MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                agenciaId = lector.GetInt32(0);
                            }
                            return agenciaId; 
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return agenciaId;
        }
        public List<string> obtenerCamion(string origen,string destino)
        {
            List<string> camiones = new List<string>();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtenerCamion(@origen,@destino);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@origen",origen);
                        comando.Parameters.AddWithValue("@destino", destino);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                camiones.Add(lector.GetString("Camion"));
                            }
                            return camiones;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return camiones;
        }
        public int obtenerIdCamion(string placa)
        {
            int camionId = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtenerIdCamion(@placa);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@placa", placa);
                        using(MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                camionId = lector.GetInt32(0);
                            }
                            return camionId;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return camionId;
        }
        public DataTable enviosRecaudadoPagados()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_total_envios_y_recudado_pagados();";
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

        public DataTable enviosRecaudadoNoPagados()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_total_envios_y_recudado_no_pagados();";
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

        public DataTable enviosEntragados()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_envios_entregados();";
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
        public DataTable enviosRegistrados()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_envios_registrados();";
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
        public DataTable enviosCamino()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_envios_en_camino();";
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
        public List<string> obtenerProvinciasAereo()
        {
            List<string> provinciasAero = new List<string>();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtener_provincias_areo();";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                provinciasAero.Add(lector.GetString("nombre_provincia"));
                            }
                            return provinciasAero;
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return provinciasAero;
        }

        public List<string> obtenerAviones(string origen, string destino)
        {
            List<string> placas = new List<string>();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtenerAvion(@origen,@destino);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@origen", origen);
                        comando.Parameters.AddWithValue("@destino", destino);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                placas.Add(lector.GetString("placa"));
                            }
                            return placas;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return placas;
        }

        public int obtenerIDCamion(string placa)
        {
            int idAvion = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL obtenerIdCamion(@placa); ";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@placa", placa);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                idAvion = lector.GetInt32(0);
                            }
                            return idAvion;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return idAvion;
        }
        public DataTable enviosAereo()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL envios_aereo();";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn))
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

        public DataTable enviosTerrestre()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL envios_terrestre();";
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
    }
}
