using AccesoDatos.Modelos;
using LogicaNegocio.Controladores;
using LogicaNegocio.MenejoExpeciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas.VistasEnvios
{
    public partial class EliminarEnvio : Form
    {
        private ControladorEnvio conector;
        private ControlExcepciones verificador;
        public EliminarEnvio()
        {
            this.conector = new ControladorEnvio();
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            verificador = new ControlExcepciones();
        }
        private void ApplyRoundedCorners(Button btn)
        {
            // Define el radio de los bordes redondeados
            int borderRadius = 20;
            // Define el área del botón
            Rectangle newRect = new Rectangle(0, 0, btn.Width, btn.Height);
            // Crear el GraphicsPath con bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            path.AddArc(new Rectangle(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseFigure();

            // Establecer la ruta como la región del botón
            btn.Region = new Region(path);

            // Suscribirse al evento Paint del botón para dibujar el borde           

            // Establecer otras propiedades del botón si es necesario
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void ApplyRoundedCornersToAllButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button)
                {
                    ApplyRoundedCorners((Button)control);
                }
                else if (control.HasChildren)
                {
                    ApplyRoundedCornersToAllButtons(control);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDniEmisor.Text)|| !this.verificador.verificarInt(txtNroEnvio.Text))
            {
                MessageBox.Show("Los datos ingresados no son validos!");
            }
            else
            {
                EnviosModel envioEncontrado = this.conector.verEnvioBuscado(int.Parse(txtDniEmisor.Text), int.Parse(txtNroEnvio.Text));
                if (envioEncontrado.getNroenvio() == 0)
                {
                    MessageBox.Show("No existe envio con el DNI ingresado!");
                }
                else
                {
                    lblNroEnvio.Text = envioEncontrado.getNroenvio().ToString();
                    lblCliente.Text = envioEncontrado.getDniEmisor().ToString();
                    lblServicio.Text = envioEncontrado.getServicio();
                    lblTipoPaquete.Text = envioEncontrado.getTipoPaquete();
                    lblPeso.Text = envioEncontrado.getPeso().ToString();
                    lblContenido.Text = envioEncontrado.getContenido();
                    lblDestinatario.Text = envioEncontrado.getDniReceptor().ToString();
                    lblOrigen.Text = envioEncontrado.getAgenciaOrigen();
                    lblDestino.Text = envioEncontrado.getAgenciaDestino();
                    lblCamion.Text = envioEncontrado.getCamion();
                    lblTotal.Text = envioEncontrado.getTotal().ToString();
                    lblEstadoEnvio.Text = envioEncontrado.getEstadoEnvio();
                    lblAdministrador.Text = envioEncontrado.getAdministrador();
                    lblEstadoPago.Text = envioEncontrado.getEstadoPago();
                    lblFecha.Text = envioEncontrado.getFechaEnvio();


                    lblNroEnvio.Visible = true;
                    lblCliente.Visible = true;
                    lblServicio.Visible = true;
                    lblTipoPaquete.Visible = true;
                    lblPeso.Visible = true;
                    lblContenido.Visible = true;
                    lblDestinatario.Visible = true;
                    lblOrigen.Visible = true;
                    lblDestino.Visible = true;
                    lblCamion.Visible = true;
                    lblTotal.Visible = true;
                    lblEstadoEnvio.Visible = true;
                    lblEstadoPago.Visible = true;
                    lblAdministrador.Visible = true;
                    lblFecha.Visible = true;
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.conector.eliminarEnvio(int.Parse(txtDniEmisor.Text), int.Parse(txtNroEnvio.Text)))
            {
                MessageBox.Show("Se ha elimando el envio correctamente!");
            }
            else
            {
                MessageBox.Show("No se ha podido elimanr el envio!");
            }
        }

        private void txtDniEmisor_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDniEmisor.Text))
            { labelErrorEmisor.Visible = true; }
            else
            { labelErrorEmisor.Visible = false; }
        }

        private void txtNroEnvio_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtNroEnvio.Text))
                { lblErrorNroEnvio.Visible = true; }
            else { lblErrorNroEnvio.Visible = false; }
        }
    }
}
