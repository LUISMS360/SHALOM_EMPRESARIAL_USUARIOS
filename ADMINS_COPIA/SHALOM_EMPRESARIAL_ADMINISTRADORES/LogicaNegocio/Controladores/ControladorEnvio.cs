using AccesoDatos.Modelos;
using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Controladores
{
    public class ControladorEnvio
    {
        private ServicioEnvios controlador; 

        public ControladorEnvio()
        {
            this.controlador = new ServicioEnvios();
        }
        public DataTable listarTodosEnvios()
        {
           return  this.controlador.listarTodosEnvios();
        }
        public bool registrarEnvio(int dniEmisor,string nombresEmisor,
            string apellidosEmisor,string servicio,string tipoPaquete,
            double peso,string contenido,int dniRecpetor,string nombreRecp,
            string apellidoRecep,int agenciaOrigen,int agenciaDest,int camionID,
            double totalPagar,int admin)
        {
            EnviosModel envio = new EnviosModel();
            envio.setDniEmisor(dniEmisor);
            envio.setNombreEmisor(nombresEmisor);
            envio.setApellidosEmisor(apellidosEmisor);
            envio.setServicio(servicio);
            envio.setTipoPaquete(tipoPaquete);
            envio.setPeso(peso);
            envio.setContenido(contenido);
            envio.setDniReceptor(dniRecpetor);
            envio.setNombresReceptor(nombreRecp);
            envio.setApellidosReceptor(apellidoRecep);
            envio.setAgenciaOrigenID(agenciaOrigen);
            envio.setAgenciaDestinoID(agenciaDest);
            envio.setCamionId(camionID);
            envio.setTotal(totalPagar);
            envio.setAdministrador(admin);
            return this.controlador.registrarEnvio(envio);
        }
        public bool eliminarEnvio(int dni,int id)
        {
            return this.controlador.eliminarEnvio(dni,id);
        }
        public bool actualizarEnvio(int dniReceptor, string nombresReceptor,
            string apellidosReceptor, int agenciaDestino, int camion, double total,
            string estadoPago, string estadoEnvio, int envioID)
        {
            EnviosModel envioActualizar = new EnviosModel();
            envioActualizar.setDniReceptor(dniReceptor);
            envioActualizar.setNombresReceptor(nombresReceptor);
            envioActualizar.setApellidosReceptor(apellidosReceptor);
            envioActualizar.setAgenciaDestinoID(agenciaDestino);
            envioActualizar.setCamionId(camion);
            envioActualizar.setTotal(total);
            envioActualizar.setEstadoPago(estadoPago);
            envioActualizar.setEstadoEnvio(estadoEnvio);

            return this.controlador.actualizarEnvio(envioActualizar, envioID);

        }
        public DataTable verEnvio(int dniCliente)
        {
            return this.controlador.verEnvio(dniCliente);
        }
        public DataTable verEnvioFecha(string fechaInicio, string fechaFin)
        {
            return this.controlador.verEnvioFecha(fechaInicio, fechaFin);
        }
        public DataTable verEnvioOrigen(int origen)
        {
            return this.controlador.verEnvioOrigen(origen);
        }
        public DataTable verEnvioDestino(int destino)
        {
            return this.controlador.verEnvioDestino(destino);
        }
        public EnviosModel verEnvioBuscado(int dniEmisor,int id)
        {
            return this.controlador.verEnvioBuscado(dniEmisor,id);
        }
        public List<string> obtenerAgencias(string provincia)
        {
            return this.controlador.obtenerAgencias(provincia);
        }
        public int obtenerIdAgencia(string nombreAgencia)
        {
            return this.controlador.obtenerIdAgencia(nombreAgencia);
        }
        public List<string> obtenerCamion(string origen, string destino)
        {
            return this.controlador.obtenerCamion(origen,destino);
        }
        public int obtenerIdCamion(string placa)
        {
            return this.controlador.obtenerIdCamion(placa);
        }
        public DataTable enviosRecaudadoPagados()
        {
            return this.controlador.enviosRecaudadoPagados();
        }

        public DataTable enviosRecaudadoNoPagados()
        {
            return this.controlador.enviosRecaudadoNoPagados();
        }

        public DataTable enviosEntragados()
        {
            return this.controlador.enviosEntragados();
        }
        public DataTable enviosRegistrados()
        {
            return this.controlador.enviosRegistrados();
        }
        public DataTable enviosCamino()
        {
            return this.controlador.enviosCamino();
        }
        public List<string> obtenerProvinciasAereo()
        {
            return this.controlador.obtenerProvinciasAereo();
        }

        public List<string> obtenerAviones(string origen, string destino)
        {
            return this.controlador.obtenerAviones(origen, destino);
        }

        public int obtenerIDCamion(string placa)
        {
            return this.controlador.obtenerIDCamion(placa);
        }
        public DataTable enviosAereo()
        {
            return this.controlador.enviosAereo();
        }

        public DataTable enviosTerrestre()
        {
            return this.controlador.enviosTerrestre();
        }
    }
}
