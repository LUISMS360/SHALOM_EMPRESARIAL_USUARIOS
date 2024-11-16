using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Models;
using LogicaNegocio.Controladores;

namespace Presentacion
{
    public partial class PagoYape : Form
    {
        private EnviosController conector;
        private int envio_id;

        private Panel panel;
        public PagoYape(int id,Panel panelPas)
        {
            panel = panelPas;
            envio_id = id;
            InitializeComponent();
            conector = new EnviosController();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {            
            EnvioModel envio = conector.rastrearEnvio(envio_id);
            if (envio.getTotalPagar() == double.Parse(txtTotalPagar.Text))
            {
                conector.pagar_envio(envio_id);
                MessageBox.Show("Se ha completado el pago");
                panel.Visible = false;
                panel.Location = new Point(478, 293);
            }
            else if(envio.getTotalPagar() > double.Parse(txtTotalPagar.Text)){
                MessageBox.Show("El monto no es suficiente");                
                panel.Visible = false;
                panel.Location = new Point(478, 293);

            }
            
        }
    }
}
