using AccesoDatos.Modelos;
using LogicaNegocio.Servicios;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Controladores
{
    public class ControladorCamiones
    {
        private ServicioCamiones controlador; 

        public ControladorCamiones()
        {
            this.controlador = new ServicioCamiones();
        }

        public DataTable verTodosCamiones()
        {
            return this.controlador.verCamiones();
        }
        public DataTable verCamionEspc(string placa)
        {
            return this.controlador.verCamion(placa);
        }
        public bool registrarCamion(string placa,int conductor,string info,int origen,int destino)
        {
            CamionesModel camion = new CamionesModel();
            camion.setPlaca(placa);
            camion.setConductorID(conductor);
            camion.setInformacion(info);
            camion.setProvinciaIdOrigen(origen);
            camion.setProvinciaIdDestino(destino);
            return this.controlador.registrarCamion(camion);
        }
        public bool actualizarCamion(string nuevaPlaca,int nuevoConductor, string info,string placa)
        {
            CamionesModel camionActualizado = new CamionesModel();
            camionActualizado.setPlaca(nuevaPlaca);
            camionActualizado.setConductorID(nuevoConductor);
            camionActualizado.setInformacion(info);            
            return this.controlador.actualizarCamion(camionActualizado,placa);
        }
        public bool eliminarCamion(string placa)
        {
            return this.controlador.eliminarCamion(placa);
        }
        public CamionesModel verCamionBuscado(string placa)
        {
            return this.controlador.verCamionBuscado(placa);
        }
        public int obtenerIdProvincia(string nombreProvincia)
        {
            return this.controlador.obtenerIdProvincia(nombreProvincia);
        }
        public List<string> obtenerConductores()
        {
            return this.controlador.obtenerConductores();
        }
        public int obtenerIdConductor(string usuario)
        {
            return this.controlador.obtenerIdConductor(usuario);
        }
    }
}
