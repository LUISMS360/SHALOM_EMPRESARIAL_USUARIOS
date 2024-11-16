
using MySql.Data.MySqlClient;
namespace AccesoDatos.Modelos
{
    public class ConexionBD
    {

        private string cadena = "server=bhn4ewostzvof1oztxji-mysql.services.clever-cloud.com ;database=bhn4ewostzvof1oztxji;user=uqvyhe0lpjlo73ut;password=pMuTAFVcNaIoSB1ncum8;";

        public MySqlConnection getConexion()
        {
            MySqlConnection conn=null;
            try
            {
                conn = new MySqlConnection(cadena);
                conn.Open();
                return conn; 
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return conn;
        }

    }
}
