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

namespace Presentacion.Vistas.VistasCamiones
{
    public partial class ActualizarCamion : Form
    {
        private ControlExcepciones verificador;
        private ControladorCamiones conector;
        public ActualizarCamion()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            ApplyRoundedCornersToAllPanels(this);
            this.conector = new ControladorCamiones();
            this.verificador = new ControlExcepciones();
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

        private void ApplyRoundedCornersToPanel(Panel panel)
        {
            // Define el radio de los bordes redondeados
            int borderRadius = 20;

            // Define el área del panel
            Rectangle newRect = new Rectangle(0, 0, panel.Width, panel.Height);

            // Crear el GraphicsPath con bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseFigure();

            // Establecer la ruta como la región del panel
            panel.Region = new Region(path);
        }

        private void ApplyRoundedCornersToAllPanels(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Panel)
                {
                    ApplyRoundedCornersToPanel((Panel)control);
                }
                else if (control.HasChildren)
                {
                    ApplyRoundedCornersToAllPanels(control);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CamionesModel camion = this.conector.verCamionBuscado(txtPlacaCamion.Text);
            if (camion.getCamionID() == 0)
            {
                MessageBox.Show("El camion no existe");
            }
            else
            {
                lblNroCamion.Text = camion.getCamionID().ToString();
                lblPlaca.Text = camion.getPlaca();
                lblNroConductor.Text = camion.getApellidosConductor();
                lblInfo.Text = camion.getInformacion();
                lblEstado.Text = camion.getEstado();
                lblFecha.Text = camion.getFechaInscripcion();
                lblOrigen.Text = camion.getProvinciaOrigenNom();
                lblDestino.Text = camion.getProvinciaDestinoNom();

                lblNroCamion.Visible = true;
                lblPlaca.Visible = true;
                lblNroConductor.Visible = true;
                lblInfo.Visible = true;
                lblEstado.Visible = true;
                lblFecha.Visible = true;
                lblOrigen.Visible = true;
                lblDestino.Visible = true;
                
            }

        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            if(lblNroCamion.Visible == false)
            {
                MessageBox.Show("Error!");
                MessageBox.Show("No hay ingreado el Camion a modificar!");
            }
            else
            {
             
                if (this.conector.actualizarCamion(txtNuevoPlaca.Text, int.Parse(txtNuevonroConducto.Text), txtNuevoInfo.Text, lblPlaca.Text))
                {
                    MessageBox.Show("Se ha actualizado la informacion del camion");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error intentenlo de nuevo!");
                }
            }
        }
    }
}
