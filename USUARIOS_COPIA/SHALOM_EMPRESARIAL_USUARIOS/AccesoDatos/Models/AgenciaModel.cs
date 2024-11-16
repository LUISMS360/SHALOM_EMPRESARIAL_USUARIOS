using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREACION DE LA ENTIDAD AGENCIA

namespace AccesoDatos.Models
{
    public class AgenciaModel
    {
        private string provincia;
        private string nombreAgencia;
        private string direccion;
        private string distrito;
        private string foto;
        public AgenciaModel(string nombreProvincia,string nombreAgencia,string direccion,string distrito,string foto)
        {
            this.provincia = nombreProvincia;
            this.nombreAgencia = nombreAgencia;
            this.direccion = direccion;
            this.distrito = distrito;
            this.foto = foto; 
        }

        public void setProvincia(string provincia)
        {
            this.provincia = provincia; 
        }

        public string getProvincia()
        {
            return this.provincia;
        }

        public void setNombreAgencia(string nombreAgencia)
        {
            this.nombreAgencia = nombreAgencia;
        }
        public string getNombreAgencia()
        {
            return this.nombreAgencia;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getDireccion()
        {
            return this.direccion;
        }
        public void setDistrito(string distrito)
        {
            this.distrito = distrito;
        }
        public string getDistrito()
        {
            return this.distrito;
        }
        public void setFoto(string foto)
        {
            this.foto = foto; 
        }
        public string getFoto()
        {
            return this.foto;
        }
    }
}
