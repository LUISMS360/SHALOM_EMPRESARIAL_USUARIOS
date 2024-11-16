using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Models;

namespace LogicaNegocio.Interfaces
{
    public interface InterfaceEnvio
    {
        public EnvioModel rastrearEnvio(int envio_id);
        public int pagarEnvio(int envio_id);

    }
}
