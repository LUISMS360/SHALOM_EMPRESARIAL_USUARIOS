using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class EnviosModel
    {
        private int nroEnvio;
        private int dniEmisor;
        private string nombreEmisor;
        private string apellidosEmisor;
        private string servicio;
        private string tipoPaquete;
        private double peso;
        private string contenido;
        private int dniReceptor;
        private string nombresReceptor;
        private string apellidosReceptor;
        private int agenciaIDorigen;
        private int agenciaIDdestino;
        private string agenciaOrigen;
        private string agenciaDestino;
        private int camionId;
        private string camion;
        private double total;
        private int administradorId;
        private string administrador;
        private string estadoPago;
        private string estadoEnvio;
        private string fechaEnvio;

        // Constructor de la clase
        /*public EnviosModel(int dniEmisor, string nombreEmisor, string apellidosEmisor, string servicio, string tipoPaquete,
                     double peso, string contenido, int dniReceptor, string nombresReceptor, string apellidosReceptor,
                     int agenciaOrigen, int agenciaDestino, int camionId, double total, int administrador)
        {
            this.dniEmisor = dniEmisor;
            this.nombreEmisor = nombreEmisor;
            this.apellidosEmisor = apellidosEmisor;
            this.servicio = servicio;
            this.tipoPaquete = tipoPaquete;
            this.peso = peso;
            this.contenido = contenido;
            this.dniReceptor = dniReceptor;
            this.nombresReceptor = nombresReceptor;
            this.apellidosReceptor = apellidosReceptor;
            this.agenciaOrigen = agenciaOrigen;
            this.agenciaDestino = agenciaDestino;
            this.camionId = camionId;
            this.total = total;
            this.administrador = administrador;
        }*/

        // Getters y Setters

        // DNI Emisor
        public int getNroenvio()
        {
            return this.nroEnvio;
        }
        public void setNroenvio(int nroEnvio)
        {
            this.nroEnvio = nroEnvio;
        }
        public int getDniEmisor()
        {
            return dniEmisor;
        }
        public void setDniEmisor(int dniEmisor)
        {
            this.dniEmisor = dniEmisor;
        }

        // Nombre Emisor
        public string getNombreEmisor()
        {
            return nombreEmisor;
        }
        public void setNombreEmisor(string nombreEmisor)
        {
            this.nombreEmisor = nombreEmisor;
        }

        // Apellidos Emisor
        public string getApellidosEmisor()
        {
            return apellidosEmisor;
        }
        public void setApellidosEmisor(string apellidosEmisor)
        {
            this.apellidosEmisor = apellidosEmisor;
        }

        // Servicio
        public string getServicio()
        {
            return servicio;
        }
        public void setServicio(string servicio)
        {
            this.servicio = servicio;
        }

        // Tipo Paquete
        public string getTipoPaquete()
        {
            return tipoPaquete;
        }
        public void setTipoPaquete(string tipoPaquete)
        {
            this.tipoPaquete = tipoPaquete;
        }

        // Peso
        public double getPeso()
        {
            return peso;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        // Contenido
        public string getContenido()
        {
            return contenido;
        }
        public void setContenido(string contenido)
        {
            this.contenido = contenido;
        }

        // DNI Receptor
        public int getDniReceptor()
        {
            return dniReceptor;
        }
        public void setDniReceptor(int dniReceptor)
        {
            this.dniReceptor = dniReceptor;
        }

        // Nombres Receptor
        public string getNombresReceptor()
        {
            return nombresReceptor;
        }
        public void setNombresReceptor(string nombresReceptor)
        {
            this.nombresReceptor = nombresReceptor;
        }

        // Apellidos Receptor
        public string getApellidosReceptor()
        {
            return apellidosReceptor;
        }
        public void setApellidosReceptor(string apellidosReceptor)
        {
            this.apellidosReceptor = apellidosReceptor;
        }

        // Agencia Origen
        public string  getAgenciaOrigen()
        {
            return agenciaOrigen;
        }
        public void setAgenciaOrigenID(int agenciaOrigen)
        {
            this.agenciaIDorigen = agenciaOrigen;
        }
        public int getAgenciaOrigenID()
        {
            return agenciaIDorigen;
        }
        public int getAgenciaDestinoID()
        {
            return agenciaIDdestino;
        }

        // Agencia Destino
        public string getAgenciaDestino()
        {
            return agenciaDestino;
        }
        public void setAgenciaDestinoID(int agenciaDestino)
        {
            this.agenciaIDdestino = agenciaDestino;
        }

        // Camión ID
        public int getCamionId()
        {
            return camionId;
        }
        public void setCamionId(int camionId)
        {
            this.camionId = camionId;
        }

        // Total
        public double getTotal()
        {
            return total;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }

        // Administrador
        public string getAdministrador()
        {
            return administrador;
        }
        public void setAdministradorNom(string administrador)
        {
            this.administrador = administrador;
        }
        public void setAdministrador(int administrador)
        {
            this.administradorId = administrador;
        }
        public int getAdministradorID()
        {
            return administradorId;
        }

        public void setEstadoPago(string estadoPago)
        {
            this.estadoPago = estadoPago;
        }
        public string getEstadoPago()
        {
            return estadoPago;
        }
        public void setEstadoEnvio(string estadoEnvio)
        {
            this.estadoEnvio = estadoEnvio;
        }
        public string getEstadoEnvio()
        {
            return estadoEnvio;
        }
        public string getFechaEnvio()
        {
            return this.fechaEnvio;
        }
        public void setFechaEnvio(string fechaEnvio)
        {
            this.fechaEnvio = fechaEnvio;
        }
        public void setAgenciaOrigen(string origen)
        {
            this.agenciaOrigen = origen;
        }
        public void setAgenciaDestino(string destino)
        {
            this.agenciaDestino = destino;
        }
        public string getCamion() { 
            return this.camion;
        }
        public void setCamion(string camion)
        {
            this.camion = camion;
        }
    }
}
