
using AccesoDatos.Modelos;
using LogicaNegocio.Interfacez;
using MySql.Data.MySqlClient;
namespace LogicaNegocio.Servicios
{
    public class ServicioConexion:IConexion
    {
        private ConexionBD conexion; 
        public ServicioConexion()
        {
            this.conexion = new ConexionBD();
        }
        public bool conectar()
        {
            try
            {
                using (MySqlConnection conn = this.conexion.getConexion())
                {
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
