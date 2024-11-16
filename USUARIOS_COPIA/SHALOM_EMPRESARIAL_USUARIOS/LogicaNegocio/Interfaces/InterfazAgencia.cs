using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Models;

namespace LogicaNegocio.Interfaces
{
    public interface InterfazAgencia
    {
        public List<AgenciaModel> verAgencias(string provinciaIn);
    }
}
