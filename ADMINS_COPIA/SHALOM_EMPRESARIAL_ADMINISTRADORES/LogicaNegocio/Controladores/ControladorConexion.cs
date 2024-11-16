using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicaNegocio.Controladores
{
    public  class ControladorConexion
    {
        private ServicioConexion controlador;

        public ControladorConexion()
        {
            this.controlador = new ServicioConexion();
        }

        public bool devolverConexion()
        {
            return this.controlador.conectar();
        }
    }
}
