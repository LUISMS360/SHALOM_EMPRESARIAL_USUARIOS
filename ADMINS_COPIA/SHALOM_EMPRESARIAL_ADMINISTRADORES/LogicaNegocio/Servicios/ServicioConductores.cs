using AccesoDatos.Modelos;
using LogicaNegocio.Interfacez;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class ServicioConductores:IConductor
    {
        private ConexionBD conexion; 

        public ServicioConductores()
        {
            this.conexion = new ConexionBD();
        }
        public DataTable verConductores()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_conductores();";
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
        public DataTable verConductor(string apellidos)
        {

            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_conductor_por_apellidos(@apellidos);";
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query,conn))
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue("@apellidos", apellidos);
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
        public bool agregarConductor(ConductoresModel conductor)
        {
            string usuario = conductor.getUsuarioConductor();
            string contra = conductor.getContraseniaConductor();
            string nombres = conductor.getNombresConductor();
            string apellidos = conductor.getApellidosConductor();
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL registrar_conductor(@usuario,@contra,@nombres,@apellidos);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@usuario",usuario);
                        comando.Parameters.AddWithValue("@contra",contra);
                        comando.Parameters.AddWithValue("@nombres",nombres);
                        comando.Parameters.AddWithValue("@apellidos",apellidos);
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

        public bool actualizarConductor(ConductoresModel conductor, string apellidos)
        {
            string usuario = conductor.getUsuarioConductor();
            string contra = conductor.getContraseniaConductor();
            string estado = conductor.getEstadoConductor();            
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL actualizar_conductor(@usuario,@contra,@estado,@apellidos);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@usuario",usuario);
                        comando.Parameters.AddWithValue("@contra",contra);
                        comando.Parameters.AddWithValue("@estado",estado);
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
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

        //Tiene una fuerte dependencia para camiones
        public bool eliminarConductor(string usuario)
        {
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL eliminar_conductor(@usuario);";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
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
        public ConductoresModel conductorBuscado(string apellidos)
        {
            ConductoresModel conductor = new ConductoresModel(); 
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "CALL ver_conductor_por_apellidos(@apellidos);";
                    using (MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                conductor.setConductorID(lector.GetInt32(0));
                                conductor.setUsuarioConductor(lector.GetString(1));
                                conductor.setNombresConductor(lector.GetString(2));
                                conductor.setApellidosConductor(lector.GetString(3));
                                conductor.setEstadoConductor(lector.GetString(4));
                                conductor.setFechaRegistro(lector.GetDateTime(5).ToString("yyyy-MM-dd HH:mm:ss"));
                            }
                            return conductor;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return conductor;
        }
     
    }
}
