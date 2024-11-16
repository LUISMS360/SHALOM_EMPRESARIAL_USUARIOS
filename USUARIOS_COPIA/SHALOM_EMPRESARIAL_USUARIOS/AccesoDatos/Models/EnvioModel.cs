using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class EnvioModel
    {
        public int nroEnvio;
        public int cliente;
        public string servicio;
        public string tipoPaquete;
        public int destinatario;
        public string origen;
        public string destino;
        public double totalPagar;
        public string estadoEnvio;
        public string estadoPago;
        
        public EnvioModel(int nroEnvio,int cliente,string servicio,string tipoPaquete,int destinatario,string origen,string destino,double totalPagar,string estadoEnvio,string estadoPago)
        {
            this.nroEnvio = nroEnvio;
            this.cliente = cliente;
            this.servicio = servicio;
            this.tipoPaquete = tipoPaquete;
            this.destinatario = destinatario;
            this.origen = origen;
            this.destino = destino;
            this.totalPagar = totalPagar;
            this.estadoEnvio = estadoEnvio;
            this.estadoPago = estadoPago;
        }

        public int getNroEnvio()
        {
            return this.nroEnvio;
        }

        public int getCliente()
        {
            return this.cliente;
        }

        public string getServicio()
        {
            return this.servicio;
        }

        public string getTipoPaquete()
        {
            return this.tipoPaquete;
        }

        public int getDestinatario()
        {
            return this.destinatario;
        }

        public string getOrigen()
        {
            return this.origen;
        }

        public string getDestino()
        {
            return this.destino;
        }

        public double getTotalPagar()
        {
            return this.totalPagar;
        }

        public string getEstadoEnvio()
        {
            return this.estadoEnvio;
        }

        public string getEstadoPago()
        {
            return this.estadoPago;
        }

        // Métodos Set
        public void setNroEnvio(int nroEnvio)
        {
            this.nroEnvio = nroEnvio;
        }

        public void setCliente(int cliente)
        {
            this.cliente = cliente;
        }

        public void setServicio(string servicio)
        {
            this.servicio = servicio;
        }

        public void setTipoPaquete(string tipoPaquete)
        {
            this.tipoPaquete = tipoPaquete;
        }

        public void setDestinatario(int destinatario)
        {
            this.destinatario = destinatario;
        }

        public void setOrigen(string origen)
        {
            this.origen = origen;
        }

        public void setDestino(string destino)
        {
            this.destino = destino;
        }

        public void setTotalPagar(double totalPagar)
        {
            this.totalPagar = totalPagar;
        }

        public void setEstadoEnvio(string estadoEnvio)
        {
            this.estadoEnvio = estadoEnvio;
        }

        public void setEstadoPago(string estadoPago)
        {
            this.estadoPago = estadoPago;
        }
    }

}
