using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class ClientesModel
    {
        private int clienteID;
        private int dniCliente;
        private string nombresCliente;
        private string apellidosCliente;
        private string fechaRegistro;
        
        /*public ClientesModel(int clienteID, int dniCliente, string nombresCliente, string apellidosCliente)
        {
            this.clienteID = clienteID;
            this.dniCliente = dniCliente;
            this.nombresCliente = nombresCliente;
            this.apellidosCliente = apellidosCliente;
        }*/

        // Getter y Setter para clienteID
        public int getClienteID()
        {
            return clienteID;
        }

        public void setClienteID(int clienteID)
        {
            this.clienteID = clienteID;
        }

        // Getter y Setter para dniCliente
        public int getDniCliente()
        {
            return dniCliente;
        }

        public void setDniCliente(int dniCliente)
        {
            this.dniCliente = dniCliente;
        }

        // Getter y Setter para nombresCliente
        public string getNombresCliente()
        {
            return nombresCliente;
        }

        public void setNombresCliente(string nombresCliente)
        {
            this.nombresCliente = nombresCliente;
        }

        // Getter y Setter para apellidosCliente
        public string getApellidosCliente()
        {
            return apellidosCliente;
        }

        public void setApellidosCliente(string apellidosCliente)
        {
            this.apellidosCliente = apellidosCliente;
        }

        public string getFechaRegistro()
        {
            return this.fechaRegistro;
        }
        public void setFechaRegistro(string fechaRegistro)
        {
            this.fechaRegistro = fechaRegistro;
        }
    }
}
