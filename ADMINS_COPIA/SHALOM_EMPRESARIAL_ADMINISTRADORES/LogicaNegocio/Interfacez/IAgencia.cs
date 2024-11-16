using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfacez
{
    public interface IAgencia
    {
        public DataTable verAgencias();
        public DataTable verAgencia(string nombre);
        public DataTable verAgenciaProvincia(string provincia);
        public bool registrarAgencia(AgenciaModel agencia);
        public bool actualizarAgencia(AgenciaModel agencia,string nombre);
        public bool eliminarAgencia(string nombreAgencia);
        public AgenciaModel verAgenciaBuscada(string nombreAgencia);
    }
}
