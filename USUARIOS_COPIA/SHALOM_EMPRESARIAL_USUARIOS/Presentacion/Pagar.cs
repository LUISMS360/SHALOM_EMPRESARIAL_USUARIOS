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
    public partial class Pagar : Form
    {
        private EnviosController conector;
        public int id;
        public Panel panel;
     
        public Pagar()
        {
            id = 0;
            InitializeComponent();
            panel = panelPago;
            conector = new EnviosController();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelMetodoPago.Controls.Count > 0)
                this.panelMetodoPago.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMetodoPago.Controls.Add(fh);
            this.panelMetodoPago.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnvioModel envio = conector.rastrearEnvio(int.Parse(txtEnvioID.Text));
            this.id = int.Parse(txtEnvioID.Text);
            if (envio.getNroEnvio() == 0)
            {
                MessageBox.Show("No hay informacion con el Nro Envio Ingresado");
            }
            else
            {
                if (envio.getEstadoPago().Equals("Pagado"))
                {
                    int x = 441, y = 124;
                    panelPagado.Location = new Point(x, y);
                    panelPagado.Visible = true;
                }
                else if (envio.getEstadoPago().Equals("No Pagado"))
                {
                    int x = 465, y = 129;
                    panelPago.Location = new Point(x, y);
                    panelPago.Visible = true;
                }
            }            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {


        }

        private void picYape_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PagoYape(this.id,this.panel));
        }

        private void picPlin_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PagoPlin(this.id,this.panel));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            panelPagado.Visible = false;
            int x = 778, y = 301;
            panelPagado.Location = new Point(x, y);
        }

      

     
    }
}
