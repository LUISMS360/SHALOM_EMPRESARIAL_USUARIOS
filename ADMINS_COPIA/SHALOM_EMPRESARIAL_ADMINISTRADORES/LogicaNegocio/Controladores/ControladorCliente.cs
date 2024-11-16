using AccesoDatos.Modelos;
using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Controladores
{
    public class ControladorCliente
    {
        private ServicioCliente controlador; 

        public ControladorCliente()
        {
            this.controlador = new ServicioCliente();
        }
        public DataTable listarClientes()
        {
            return this.controlador.listarClientes();
        }
        public DataTable verCliente(int dni)
        {
            return this.controlador.verCliente(dni);
        }
        public bool actualizarCliente(string nombre,string apellido, int dni)
        {
            ClientesModel cliente = new ClientesModel();
            cliente.setNombresCliente(nombre);
            cliente.setApellidosCliente(apellido); 

            return this.controlador.actualizarCliente(cliente,dni);
        }
        public ClientesModel verClienteBuscado(int dni)
        {
            return this.controlador.clienteBuscado(dni); 
        }
    }
}
