using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace AccesoDatos.Models
{
    public class ConexionBD
    {
        string conexion = "Server=bhn4ewostzvof1oztxji-mysql.services.clever-cloud.com;Database=bhn4ewostzvof1oztxji;User=uqvyhe0lpjlo73ut;Password=pMuTAFVcNaIoSB1ncum8;";
        MySqlConnection conn;

        public MySqlConnection establecerConexion()
        {
            conn = new MySqlConnection(conexion);

            try
            {
                conn.Open();
                return conn;

            }catch(MySqlException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }
        public void cerrarConexion()
        {
            if(conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }


    }
}
