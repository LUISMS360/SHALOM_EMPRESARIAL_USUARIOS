using AccesoDatos.Modelos;
using Comun.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class ServicioAdmin
    {
        private ConexionBD conexion;
         public ServicioAdmin()
        {
            this.conexion = new ConexionBD();
        }
        public string obtenerEstadoApp()
        {
            string app = "SHALOM EMPRESARIAL ADMINISTRADORES";
            string estado = "";
            try
            {
                using(MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "SELECT app_estado FROM aplicaciones WHERE app_nombre = @app;";
                    using(MySqlCommand comando = new MySqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@app", app);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                estado = lector.GetString(0);
                            }
                            return estado;
                        }
                    }
                }

            }catch(Exception ex){
                Console.WriteLine(ex.ToString());
            }
            return estado;
        }
        public int loguear(string usuario,string contra)
        {
            int i = 0;
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    string query = "SELECT * FROM administradores WHERE usuario_admin = @usuario AND contrasenia_admin = @contra;";
                    using (MySqlCommand comando = new MySqlCommand(query,conn))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contra", contra);
                        comando.ExecuteNonQuery();
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            //Verifica si hay filas registros para leer
                            if (lector.HasRows)
                            {
                               
                                //Almacena los valores de las celdas en la cache
                                while (lector.Read())
                                {
                                    
                                    DatosUser.administrador_id = lector.GetInt32(0);
                                    DatosUser.usuario_admin = lector.GetString(1);
                                    DatosUser.contrasenia_admin = lector.GetString(2);
                                    DatosUser.nombres_admin = lector.GetString(3);
                                    DatosUser.apellidos_admin = lector.GetString(4);
                                    DatosUser.estado_admin = lector.GetString(5);
                                }
                                i++;
                                return i;
                            }
                            return i;
                        
                            
                        }
                       
                    }
                    
                }
            }catch(Exception ex)
            {
                return i;
            }            
        }
    }
}
