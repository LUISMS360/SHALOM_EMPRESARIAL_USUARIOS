using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Controladores
{
    public class ControladorAdmin
    {
        private ServicioAdmin controlador; 
        public ControladorAdmin()
        {
            this.controlador = new ServicioAdmin();
        }
        public int verificarLoguin(string usuario,string contra)
        {
            return this.controlador.loguear(usuario, contra);
        }
    }
}
