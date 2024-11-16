using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.Models;
using LogicaNegocio.Controladores;

namespace Presentacion
{
    public partial class Rastrear : Form
    {
        private EnviosController conector;
        public Rastrear()
        {
            InitializeComponent();
            conector = new EnviosController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                EnvioModel envio = conector.rastrearEnvio(int.Parse(txtenvio_id.Text));

                if (envio.getNroEnvio()==0) 
                {
                    MessageBox.Show("No hay informacion con el Nro de Envio ingresado!");
                }
                else
                {
                    lblNroEnvio.Text = envio.getNroEnvio().ToString();
                    lblCliente.Text = envio.getCliente().ToString();
                    lblServicio.Text = envio.getServicio();
                    lblTipoPaquete.Text = envio.getTipoPaquete();
                    lblDestinatario.Text = envio.getDestinatario().ToString();
                    lblOrigen.Text = envio.getOrigen();
                    lblDestino.Text = envio.getDestino();
                    lblTotal.Text = envio.getTotalPagar() + ".00 S/";
                    lblEstadoEnvio.Text = envio.getEstadoEnvio();
                    lblEstadoPago.Text = envio.getEstadoPago();

                    panelInformacion.Visible = true;
                    panel1.Visible = true;

                    lblError.Visible = false;

                }

            }
            catch(Exception ex)
            {
                lblError.Visible = true;
            }
            
        }
    }
}
