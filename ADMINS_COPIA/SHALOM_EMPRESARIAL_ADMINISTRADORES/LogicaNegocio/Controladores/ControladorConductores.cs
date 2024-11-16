using AccesoDatos.Modelos;
using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Controladores
{
    public class ControladorConductores
    {
        private ServicioConductores controlador; 

        public ControladorConductores()
        {
            this.controlador = new ServicioConductores(); 
        }
        public DataTable verTodosConductores()
        {
            return this.controlador.verConductores();
        }
        public DataTable verConductorEspec(string apellidos)
        {
            return this.controlador.verConductor(apellidos);
        }
        public bool agregarConductor(string usuario,string contra,string nombres,string apellidos)
        {
            ConductoresModel conductor = new ConductoresModel();
            conductor.setUsuarioConductor(usuario);
            conductor.setContraseniaConductor(contra);
            conductor.setNombresConductor(nombres);
            conductor.setApellidosConductor(apellidos);
            return this.controlador.agregarConductor(conductor);
        }

        public bool actualizarConductor(string usuario,string contra, string estado,string apellidos)
        {
            ConductoresModel conductor = new ConductoresModel();
            conductor.setUsuarioConductor(usuario);
            conductor.setContraseniaConductor(contra);
            conductor.setEstadoConductor(estado);

            return this.controlador.actualizarConductor(conductor,apellidos);
        }

        //Tiene una fuerte dependencia para camiones
        public bool eliminarConductor(string usuario)
        {
            return this.controlador.eliminarConductor(usuario);
        }
        public ConductoresModel verConductoBuscado(string apellidos)
        {
            return this.controlador.conductorBuscado(apellidos);
        }
        
    }
}
