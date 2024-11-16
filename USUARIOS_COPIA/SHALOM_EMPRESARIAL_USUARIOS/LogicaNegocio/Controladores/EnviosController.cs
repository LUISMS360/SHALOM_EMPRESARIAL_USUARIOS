using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.Models;
using LogicaNegocio.Servicios;
namespace LogicaNegocio.Controladores
{
    public  class EnviosController
    {
        private ServicioEnvios conector; 

        public EnviosController()
        {
            conector = new ServicioEnvios();
        }

        public EnvioModel rastrearEnvio(int id)
        {
            return conector.rastrearEnvio(id);
        }

        public double pagar_envio(int id)
        {
            return conector.pagarEnvio(id);
        }
    }
}
