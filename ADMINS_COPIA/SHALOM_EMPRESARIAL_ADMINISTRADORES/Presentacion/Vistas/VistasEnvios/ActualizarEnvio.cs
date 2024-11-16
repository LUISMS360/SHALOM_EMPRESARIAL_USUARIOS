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
    public partial class ActualizarEnvio : Form
    {
        private ControladorEnvio conector;
        private int agenciaDestino;
        private int camion;
        private ControlExcepciones verificador;
        public ActualizarEnvio()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            this.conector = new ControladorEnvio();
            agenciaDestino = 0;
            camion = 0;
            this.verificador = new ControlExcepciones();

        }
        private void ApplyRoundedCorners(Button btn)
        {
            int borderRadius = 20;
            Rectangle newRect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            path.AddArc(new Rectangle(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
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
        public void limpiar()
        {
            txtNuevoDestinatario.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cmbProvinciaOrigen.Text = "";
            cmbProvinciasDestino.Text = "";
            cmbAgenciaDestino.Text = "";
            cmbNuevoCamion.Text = "";
            cmbNuevoEstadoEnvio.Text = "";
            cmbNuevoEstadoPago.Text = "";
            txtNuevoTotalPagar.Text = "";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EnviosModel envioEncontrado = this.conector.verEnvioBuscado(int.Parse(txtDniEmisor.Text),int.Parse(txtNroEnvio.Text));

            if (!this.verificador.verificarInt(txtDniEmisor.Text) || !this.verificador.verificarInt(txtNroEnvio.Text)) 
            { MessageBox.Show("Los valores introducidos no son validos!"); MessageBox.Show("Intentelo de nuevo"); }
            if (envioEncontrado.getNroenvio() == 0)
            {
                MessageBox.Show("No existe el envio");
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
        private void btnActaulizar_Click(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtNuevoDestinatario.Text) || !this.verificador.verificarInt(txtDniEmisor.Text) || !this.verificador.verificarDouble(txtNuevoTotalPagar.Text) )
            {
                MessageBox.Show("Ha introducifo uno o mas datos incorrectos!"); MessageBox.Show("Intentelo de nuevo");
            }
            else
            {
                int dniReceptor = int.Parse(txtNuevoDestinatario.Text);
                string nombresReceptor = txtNombres.Text;
                string apellidosReceptor = txtApellidos.Text;
                int agenciaDestino = this.agenciaDestino;
                int camion = this.camion;
                double total = double.Parse(txtNuevoTotalPagar.Text);
                string estadoPago = cmbNuevoEstadoPago.Text;
                string estadoEnvio = cmbNuevoEstadoEnvio.Text;
                if (this.conector.actualizarEnvio(dniReceptor, nombresReceptor, apellidosReceptor, agenciaDestino,
                    camion, total, estadoPago, estadoEnvio, int.Parse(txtNroEnvio.Text)))
                { MessageBox.Show("Se ha actualizado el envio!"); limpiar(); }
                else
                { MessageBox.Show("No se ha podido actualizar el envio!"); MessageBox.Show("Intentelo de Nuevo"); limpiar(); }
            }
        }

        private void cmbProvinciasDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAgenciaDestino.DataSource = this.conector.obtenerAgencias(cmbProvinciasDestino.Text);
        }

        private void cmbProvinciaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAgenciaDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            this.agenciaDestino = this.conector.obtenerIdAgencia(cmbAgenciaDestino.Text);
            cmbNuevoCamion.DataSource = this.conector.obtenerCamion(cmbProvinciaOrigen.Text, cmbProvinciasDestino.Text);
        }

        private void cmbNuevoCamion_SelectedValueChanged(object sender, EventArgs e)
        {
            this.camion = this.conector.obtenerIdCamion(cmbNuevoCamion.Text);
        }
        private void txtDniEmisor_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDniEmisor.Text))
            { lblErrorEmisor.Visible = true; }
            else { lblErrorEmisor.Visible = false; }
        }

        private void txtNuevoTotalPagar_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarDouble(txtNuevoTotalPagar.Text))
            { lblErrorTotal.Visible = true; }
            else { lblErrorTotal.Visible = false; }
        }

        private void txtNuevoDestinatario_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtNuevoDestinatario.Text))
            { lblErrorDestinatario.Visible = true; }
            else { lblErrorDestinatario.Visible = false; }
        }

        private void txtNroEnvio_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtNroEnvio.Text))
            { lblErroNroEnvio.Visible = true; }
            else { lblErroNroEnvio.Visible = false; }
        }
    }
}
