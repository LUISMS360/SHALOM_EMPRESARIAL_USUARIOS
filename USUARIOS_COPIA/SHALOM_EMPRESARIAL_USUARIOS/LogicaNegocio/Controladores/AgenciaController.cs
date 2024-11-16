using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.Servicios;
using AccesoDatos.Models;
namespace LogicaNegocio.Controladores
{
    public class AgenciaController
    {
        private ServicioAgencia conector;

        public AgenciaController()
        {
            conector = new ServicioAgencia();
        }

        public List<AgenciaModel> verAgencia(string provincia)
        {
            return conector.verAgencias(provincia);
        }
    }
}
