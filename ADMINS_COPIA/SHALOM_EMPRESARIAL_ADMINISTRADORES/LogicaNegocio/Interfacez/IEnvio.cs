using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace LogicaNegocio.Interfacez
{
    public interface IEnvio
    {
        public DataTable listarTodosEnvios();
        public bool registrarEnvio(EnviosModel envio);
        public bool eliminarEnvio(int dni,int envio_id);
        public bool actualizarEnvio(EnviosModel envio, int envioID);
        public DataTable verEnvio(int dniCliente);
        public DataTable verEnvioFecha(string fechaInicio,string fechaFin);
        public DataTable verEnvioOrigen(int origen);
        public DataTable verEnvioDestino(int destino);

        public EnviosModel verEnvioBuscado(int dniCliente,int id);

        public List<string> obtenerAgencias(string provincia);

        public int obtenerIdAgencia(string nombreAgencia);

        public List<string> obtenerCamion(string origen,string destino);

        public int obtenerIdCamion(string placa);

        public DataTable enviosRecaudadoPagados();

        public DataTable enviosRecaudadoNoPagados();

        public DataTable enviosEntragados();
        public DataTable enviosRegistrados();
        public DataTable enviosCamino();

        public List<string> obtenerProvinciasAereo();

        public List<string> obtenerAviones(string origen, string destino);

        public int obtenerIDCamion(string placa);

        public DataTable enviosAereo();

        public DataTable enviosTerrestre();
        
    }
}
