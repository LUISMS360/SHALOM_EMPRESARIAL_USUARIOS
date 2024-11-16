using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class AgenciaModel
    {
        private int agenciaID;
        private string nombreAgencia;
        private int provinciaID;
        private string nombreProvincia;
        private string direccion;
        private string distrito;

        /*
        public AgenciaModel(int agenciaID, string nombreAgencia, int provinciaID, string direccion, string distrito)
        {
            this.agenciaID = agenciaID;
            this.nombreAgencia = nombreAgencia;
            this.provinciaID = provinciaID;
            this.direccion = direccion;
            this.distrito = distrito;
        }

        */
        // Getter y Setter para agenciaID
        public int getAgenciaID()
        {
            return agenciaID;
        }

        public void setAgenciaID(int agenciaID)
        {
            this.agenciaID = agenciaID;
        }

        // Getter y Setter para nombreAgencia
        public string getNombreAgencia()
        {
            return nombreAgencia;
        }

        public void setNombreAgencia(string nombreAgencia)
        {
            this.nombreAgencia = nombreAgencia;
        }

        // Getter y Setter para provinciaID
        public int getProvinciaID()
        {
            return provinciaID;
        }

        public void setProvinciaID(int provinciaID)
        {
            this.provinciaID = provinciaID;
        }

        // Getter y Setter para direccion
        public string getDireccion()
        {
            return direccion;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        // Getter y Setter para distrito
        public string getDistrito()
        {
            return distrito;
        }

        public void setDistrito(string distrito)
        {
            this.distrito = distrito;
        }
        public void setNombrePrivincia(string provincia)
        {
            this.nombreProvincia = provincia;
        }
        public string getNombreProvinicia()
        {
            return this.nombreProvincia;
        }

    }
}
