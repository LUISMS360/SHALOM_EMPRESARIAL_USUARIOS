using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfacez
{
    public interface IClientes
    {
        public DataTable listarClientes();
        public DataTable verCliente(int dni);
        public bool actualizarCliente(ClientesModel cliente, int dni);

        public ClientesModel clienteBuscado(int dni);        

    }
}
