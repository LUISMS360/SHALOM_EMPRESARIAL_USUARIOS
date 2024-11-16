using AccesoDatos.Modelos;
using LogicaNegocio.Controladores;
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

namespace Presentacion.Vistas.VistasConductores
{
    public partial class ActualizarConductor : Form
    {
        private ControladorConductores conector;
        public ActualizarConductor()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            ApplyRoundedCornersToAllPanels(this);
            this.conector = new ControladorConductores();
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
            ConductoresModel conductor = this.conector.verConductoBuscado(txtApellidosConductor.Text);
            if (conductor.getConductorID() == 0)
            {
                MessageBox.Show("El conductor buscado no existe");
                MessageBox.Show("Intentelo de nuevo!");
            }
            else
            {
                lblNroConductor.Text = conductor.getConductorID().ToString();
                lblUsuario.Text = conductor.getUsuarioConductor();
                lblNombres.Text = conductor.getNombresConductor();
                lblApellidos.Text = conductor.getApellidosConductor();
                lblEstado.Text = conductor.getEstadoConductor();
                lblFecha.Text = conductor.getFechaRegistro();

                lblNroConductor.Visible = true;
                lblUsuario.Visible = true;
                lblNombres.Visible = true;
                lblApellidos.Visible = true;
                lblEstado.Visible = true;
                lblFecha.Visible = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lblNroConductor.Visible == false)
            {
                MessageBox.Show("No ha ingresado el conductor a buscar!");
            }
            else
            {
                if (this.conector.actualizarConductor(txtNuevoUsuario.Text,txtNuevaContrasena.Text,txtNuevoEstado.Text,txtApellidosConductor.Text))
                {
                    MessageBox.Show("Se ha actualizado la informacion del conductor");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error no se pudo actulizar la informacion!!");
                    MessageBox.Show("Intentelo de nuevo");
                }
            }
        }
    }
}
