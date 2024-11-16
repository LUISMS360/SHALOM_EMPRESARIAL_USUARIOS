using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class ConductoresModel
    {
        private int conductorID;
        private string usuarioConductor;
        private string contraseniaConductor;
        private string nombresConductor;
        private string apellidosConductor;
        private string estadoConductor;
        private string fechaRegistro;
 
        /*
        public ConductoresModel(int conductorID, string usuarioConductor, string contraseniaConductor,
                                 string nombresConductor, string apellidosConductor, string estadoConductor)
        {
            this.conductorID = conductorID;
            this.usuarioConductor = usuarioConductor;
            this.contraseniaConductor = contraseniaConductor;
            this.nombresConductor = nombresConductor;
            this.apellidosConductor = apellidosConductor;
            this.estadoConductor = estadoConductor;
        }

        */
        // Getter y Setter para conductorID
        public int getConductorID()
        {
            return conductorID;
        }

        public void setConductorID(int conductorID)
        {
            this.conductorID = conductorID;
        }

        // Getter y Setter para usuarioConductor
        public string getUsuarioConductor()
        {
            return usuarioConductor;
        }

        public void setUsuarioConductor(string usuarioConductor)
        {
            this.usuarioConductor = usuarioConductor;
        }

        // Getter y Setter para contraseniaConductor
        public string getContraseniaConductor()
        {
            return contraseniaConductor;
        }

        public void setContraseniaConductor(string contraseniaConductor)
        {
            this.contraseniaConductor = contraseniaConductor;
        }

        // Getter y Setter para nombresConductor
        public string getNombresConductor()
        {
            return nombresConductor;
        }

        public void setNombresConductor(string nombresConductor)
        {
            this.nombresConductor = nombresConductor;
        }

        // Getter y Setter para apellidosConductor
        public string getApellidosConductor()
        {
            return apellidosConductor;
        }

        public void setApellidosConductor(string apellidosConductor)
        {
            this.apellidosConductor = apellidosConductor;
        }

        // Getter y Setter para estadoConductor
        public string getEstadoConductor()
        {
            return estadoConductor;
        }

        public void setEstadoConductor(string estadoConductor)
        {
            this.estadoConductor = estadoConductor;
        }
        public void setFechaRegistro(string fecha)
        {
            this.fechaRegistro = fecha;
        }
        public string getFechaRegistro()
        {
            return this.fechaRegistro;
        }
       
    }
}
