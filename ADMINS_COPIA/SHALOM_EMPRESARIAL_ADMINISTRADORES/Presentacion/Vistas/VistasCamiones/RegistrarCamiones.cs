using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using LogicaNegocio.Controladores;

namespace Presentacion.Vistas.VistasCamiones
{
    public partial class RegistrarCamiones : Form
    {
        private ControladorCamiones conector;
        private int conductorID;
        private int origen;
        private int destino;
        private int id;
        public RegistrarCamiones()
        {
            this.conector = new ControladorCamiones();
            InitializeComponent();
            // Aplica bordes redondeados a todos los botones y paneles al iniciar el formulario
            ApplyRoundedCornersToAllButtons(this);
            ApplyRoundedCornersToAllPanels(this);
            this.conductorID = 0;
            this.origen = 0;
            this.destino = 0;
            this.id = 0;
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

        private void btnRegistrarCamion_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Equals("") && txtInfo.Text.Equals(""))
            {
                MessageBox.Show("Los Datos estan vacios!");
                MessageBox.Show("Intentelo de nuevo!");
            }
            else
            {
                if (this.conector.registrarCamion(txtPlaca.Text, this.id, txtInfo.Text, this.origen, this.destino))
                {
                    MessageBox.Show("Se ha registrador el camion!");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al registrar!");
                    MessageBox.Show("Intentelo de nuevo!");

                }
            }

        }

        private void cmbConducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            this.origen = this.conector.obtenerIdProvincia(cmbOrigen.Text);
        }

        private void cmbDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            this.destino = this.conector.obtenerIdProvincia(cmbDestino.Text);
        }

        private void RegistrarCamiones_Load(object sender, EventArgs e)
        {
            cmbConductores.DataSource = this.conector.obtenerConductores();
        }

        private void cmbConductores_SelectedValueChanged(object sender, EventArgs e)
        {
            this.id = this.conector.obtenerIdConductor(cmbConductores.Text);
        }
    }
}
