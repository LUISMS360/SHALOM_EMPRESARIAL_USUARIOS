using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Models;
using LogicaNegocio.Interfaces;
using MySql.Data.MySqlClient;
namespace LogicaNegocio.Servicios
{
    public class ServicioEnvios:InterfaceEnvio
    {
        private ConexionBD conector;

        public ServicioEnvios()
        {
            conector = new ConexionBD();
        }
        public EnvioModel rastrearEnvio(int envio_id)
        {
            int nroEnvio = 0;
            int cliente = 0;
            string servicio = "";
            string tipoPaquete = "";
            int destinatario = 0;
            string origen = "";
            string destino = "";
            double totalPagar = 0;
            string estadoEnvio = "";
            string estadoPago = "";
            EnvioModel envio = new EnvioModel(nroEnvio, cliente, servicio, tipoPaquete, destinatario, origen, destino, totalPagar, estadoEnvio, estadoPago);
            try
            {
                using (MySqlConnection conn = conector.establecerConexion())
                {
                    string query = "CALL seguir_envio_clientes(@id);";
                    using (MySqlCommand command = new MySqlCommand(query,conn))
                    {
                        command.Parameters.AddWithValue("@id", envio_id);

                        using (MySqlDataReader lector = command.ExecuteReader())
                        {                           
                            while (lector.Read())
                            {
                                
                                envio.setNroEnvio(Convert.ToInt32(lector["NroEnvio"])); 
                                envio.setCliente(Convert.ToInt32(lector["Cliente"]));
                                envio.setServicio(lector["Servicio"].ToString());
                                envio.setTipoPaquete(lector["Tipo_Paquete"].ToString());
                                envio.setDestinatario(Convert.ToInt32(lector["Destinatario"]));
                                envio.setOrigen(lector["Origen"].ToString());
                                envio.setDestino(lector["Destino"].ToString());
                                envio.setTotalPagar(Convert.ToDouble(lector["Total"]));
                                envio.setEstadoEnvio(lector["Estado_Envio"].ToString());
                                envio.setEstadoPago(lector["Estado_Pago"].ToString());
                            }                           
                            return envio;
                        }

                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return envio;
            
        }
        public double pagarEnvio(int envio_id)
        {
            int pago = 0;
            try
            {
                using(MySqlConnection conn = conector.establecerConexion())
                {
                    string query = "CALL pagar_envio(@id);";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", envio_id);
                        using(MySqlDataReader lector = command.ExecuteReader())
                        {
                            
                            while (lector.Read())
                            {
                                pago = lector.GetDouble(0);
                            }
                            return pago;                            
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return pago;
        }
    }
}
