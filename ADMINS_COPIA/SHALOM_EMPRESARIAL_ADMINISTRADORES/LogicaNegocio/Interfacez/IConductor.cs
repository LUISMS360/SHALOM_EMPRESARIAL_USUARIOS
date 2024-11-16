using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfacez
{
    public interface IConductor
    {
        public DataTable verConductores();
        public DataTable verConductor(string apellidos);
        public bool agregarConductor(ConductoresModel conductor);

        public bool actualizarConductor(ConductoresModel conductor,string apellidos);

        //Tiene una fuerte dependencia para camiones
        public bool eliminarConductor(string usuario);
        public ConductoresModel conductorBuscado(string apellidos);        

       

    }
}
