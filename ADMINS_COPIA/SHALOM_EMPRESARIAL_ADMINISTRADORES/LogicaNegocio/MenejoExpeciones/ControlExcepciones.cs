using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.MenejoExpeciones
{
    public class ControlExcepciones
    {

        public bool verificarInt(string valor)
        {
            try
            {
                int.Parse(valor);                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool verificarDouble(string valor)
        {
            try
            {
                double.Parse(valor);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
}
