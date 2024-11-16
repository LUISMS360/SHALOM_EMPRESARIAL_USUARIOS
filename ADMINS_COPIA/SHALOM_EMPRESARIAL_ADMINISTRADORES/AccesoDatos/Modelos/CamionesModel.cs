using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class CamionesModel
    {

        private int camionID;
        private string placa;
        private int conductorID;
        private string apellidosConductor;
        private string informacion;
        private string estado;
        private string fechaInscripcion;
        private int provinciaIdOrigen;
        private int provinciaIdDestino;
        private string provinciaDestinoNom;
        private string provinciaOrigenNom;
        /*
        public CamionesModel(int camionID, string placa, int conductorID, string estado)
        {
            this.camionID = camionID;
            this.placa = placa;
            this.conductorID = conductorID;
            this.estado = estado;
        }*/

        // Getter y Setter para camionID
        public int getCamionID()
        {
            return camionID;
        }

        public void setCamionID(int camionID)
        {
            this.camionID = camionID;
        }

        // Getter y Setter para placa
        public string getPlaca()
        {
            return placa;
        }

        public void setPlaca(string placa)
        {
            this.placa = placa;
        }

        // Getter y Setter para conductorID
        public int getConductorID()
        {
            return conductorID;
        }

        public void setConductorID(int conductorID)
        {
            this.conductorID = conductorID;
        }

        // Getter y Setter para estado
        public string getEstado()
        {
            return estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public void setApellidosConductor(string apellidosCoduc)
        {
            this.apellidosConductor = apellidosCoduc;
        }
        public string getApellidosConductor()
        {
            return this.apellidosConductor;
        }
        public void setInformacion(string informacion)
        {
            this.informacion = informacion;
        }
        public string getInformacion()
        {
            return this.informacion;
        }
        public void setFechaInscripcion(string fecha)
        {
            this.fechaInscripcion = fecha;
        }
        public string getFechaInscripcion()
        {
            return this.fechaInscripcion;
        }
        public void setProvinciaIdOrigen(int origen)
        {
            this.provinciaIdOrigen = origen;
        }
        public int getProvinciaIdOrigen()
        {
            return this.provinciaIdOrigen;
        }
        public void setProvinciaIdDestino(int destino)
        {
            this.provinciaIdDestino = destino;
        }
        public int getProvinciaIdDestino()
        {
            return this.provinciaIdDestino;
        }
        public string getProvinciaOrigenNom()
        {
            return this.provinciaOrigenNom;
        }
        public string getProvinciaDestinoNom()
        {
            return this.provinciaDestinoNom;
        }
        public void setProvinciaOrigenNom(string orige)
        {
            this.provinciaOrigenNom = orige; 
        }
        public void setProvinciaDestinoNom(string destino)
        {
            this.provinciaDestinoNom = destino;
        }
    }
}
