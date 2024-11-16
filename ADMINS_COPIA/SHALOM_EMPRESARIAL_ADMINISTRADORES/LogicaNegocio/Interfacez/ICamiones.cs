using AccesoDatos.Modelos;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfacez
{
    public  interface ICamiones
    {
        public DataTable verCamiones();
        public DataTable verCamion(string placa);
        public bool registrarCamion(CamionesModel camion);        
        public bool actualizarCamion(CamionesModel camion, string placa);        
        public bool eliminarCamion(string placa);        
        public CamionesModel verCamionBuscado(string placa);

        public int obtenerIdProvincia(string nombreProvincia);
        public List<string> obtenerConductores();
        public int obtenerIdConductor(string usuario);
    }
}
