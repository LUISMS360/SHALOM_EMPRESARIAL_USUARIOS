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

namespace Presentacion.Vistas.VistasAgencia
{

    public partial class ActualizarAgencia : Form
    {
        private ControladorAgencias conector;
        public ActualizarAgencia()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            ApplyRoundedCornersToAllPanels(this);
            this.conector = new ControladorAgencias();
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
            AgenciaModel agencia = this.conector.verAgenciaBuscada(txtNombreAgencia.Text);
            if (agencia.getAgenciaID() == 0)
            {
                MessageBox.Show("No se ha a encontrado niguna agencia!");
            }
            else
            {
                lblNroAgencia.Text = agencia.getAgenciaID().ToString();
                lblNombreAgencia.Text = agencia.getNombreAgencia();
                lblProvincia.Text = agencia.getNombreProvinicia();
                lblDistrito.Text = agencia.getDistrito();
                lblDireccion.Text = agencia.getDireccion();

                lblNroAgencia.Visible = true;
                lblNombreAgencia.Visible = true;
                lblProvincia.Visible = true;                
                lblDistrito.Visible = true;
                lblDireccion.Visible = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(lblNroAgencia.Visible == false)
            {
                MessageBox.Show("No ha selecionado la agencia a modificar!");
                MessageBox.Show("Intentelo de nuevo");
            }
            else
            {
                if (this.conector.actualizarAgencia(txtNuevoDestrito.Text,txtNuevaDireccion.Text,lblNombreAgencia.Text))
                {
                    MessageBox.Show("Se ha actualizado correctamente la agencia!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                    MessageBox.Show("Intentelo de nuevo");
                }
            }
        }
    }
}
