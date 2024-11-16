using AccesoDatos.Modelos;
using LogicaNegocio.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas.VistasConductores
{
    public partial class EliminarConductor : Form
    {
        private ControladorConductores conector;
        public EliminarConductor()
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

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            ConductoresModel conductor = this.conector.verConductoBuscado(txtUsuario.Text);
            if (conductor.getConductorID() == 0)
            {
                MessageBox.Show("El conductor buscado no existe!");
            }
            else
            {
                lblNroConducto.Text = conductor.getConductorID().ToString();
                lblUsuario.Text = conductor.getUsuarioConductor();
                lblNombres.Text = conductor.getNombresConductor();
                lblApellidos.Text = conductor.getApellidosConductor();
                lblEstado.Text = conductor.getEstadoConductor();
                lblFecha.Text = conductor.getFechaRegistro();

                lblNroConducto.Visible = true;
                lblUsuario.Visible = true;
                lblNombres.Visible = true;
                lblApellidos.Visible = true;
                lblEstado.Visible = true;
                lblFecha.Visible = true;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lblNroConducto.Visible == false)
            {
                MessageBox.Show("No ha selecionado el conductor a buscar!");
                MessageBox.Show("intentelo de nuevo!!");
            }
            else
            {
                if (this.conector.eliminarConductor(lblUsuario.Text))
                {
                    MessageBox.Show("Se ha elimando el conductor exitosamente!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar al conductor");
                    MessageBox.Show("Verifique que este no este a cargo de ningun camion");
                }
            }
        }
    }
}
