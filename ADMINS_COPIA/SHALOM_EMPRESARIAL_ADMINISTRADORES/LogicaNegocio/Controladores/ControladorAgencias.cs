using AccesoDatos.Modelos;
using LogicaNegocio.Interfacez;
using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Controladores
{
    public class ControladorAgencias
    {
        private ServicioAgencias controlador;
        public ControladorAgencias()
        {
            this.controlador = new ServicioAgencias();
        }

        
        public DataTable verTodasAgencias()
        {
            return this.controlador.verAgencias();
        }
        public DataTable verAgenciaEspce(string nombre)
        {
            return this.controlador.verAgencia(nombre); 
        }
        public DataTable verAgenciaProvincia(string provincia)
        {
            return this.controlador.verAgenciaProvincia(provincia);
        }
        public bool registrarAgencia(string nombreAgencia,int provincia,string direccion,string distrito)
        {
            AgenciaModel agencia = new AgenciaModel();
            agencia.setNombreAgencia(nombreAgencia);
            agencia.setProvinciaID(provincia);
            agencia.setDireccion(direccion);
            agencia.setDistrito(distrito);
            return this.controlador.registrarAgencia(agencia);
        }
        public bool actualizarAgencia(string distrito,string direccion, string nombre)
        {
            AgenciaModel agencia = new AgenciaModel();
            agencia.setDistrito(distrito);
            agencia.setDireccion(direccion);
            return this.controlador.actualizarAgencia(agencia, nombre);
        }
        public bool eliminarAgencia(string nombreAgencia)
        {
            return this.controlador.eliminarAgencia(nombreAgencia);
        }
        public AgenciaModel verAgenciaBuscada(string nombreAgencia)
        {
            return this.controlador.verAgenciaBuscada(nombreAgencia);
        }
    }
}
