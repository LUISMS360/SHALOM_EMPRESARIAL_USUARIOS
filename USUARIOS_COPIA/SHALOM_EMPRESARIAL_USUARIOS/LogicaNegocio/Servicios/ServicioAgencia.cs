using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Models;
using LogicaNegocio.Interfaces;
using MySql.Data.MySqlClient;
namespace LogicaNegocio.Servicios
{
    public class ServicioAgencia:InterfazAgencia
    {        
        private ConexionBD conexion;

        public ServicioAgencia()
        {
            conexion = new ConexionBD();

        }
        public List<AgenciaModel> verAgencias(string provinciaIn)
        {
            List<AgenciaModel> agencias = new List<AgenciaModel>();
            try
            {
                using (MySqlConnection conn = conexion.establecerConexion())
                {                    
                    string query = "CALL listarAgencia(@provincia);";
                    using (MySqlCommand comand = new MySqlCommand(query, conn))
                    {
                        comand.Parameters.AddWithValue("@provincia", provinciaIn);
                        using (MySqlDataReader lector = comand.ExecuteReader())
                        {
                            string provincia="";
                            string agencia_nombre="";
                            string direccion="";
                            string distrito = "";
                            string foto = "";
                            while (lector.Read())
                            {
                                agencia_nombre = lector["nombre_agencia"].ToString();
                                provincia = lector["nombre_provincia"].ToString();                                
                                direccion = lector["direccion"].ToString();
                                distrito = lector["distrito"].ToString();
                                foto = lector["foto"].ToString();
                                AgenciaModel agencia = new AgenciaModel(provincia, agencia_nombre, direccion, distrito, foto);
                                agencias.Add(agencia);
                            }
                            return agencias;

                        }
                    }

                }                
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);                
            }
            return agencias;
        }
    }
}
