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
    public partial class RegistrarAgencias : Form
    {
        private ControladorAgencias conector;
        private int provincia;
        public RegistrarAgencias()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            ApplyRoundedCornersToAllPanels(this);
            this.conector = new ControladorAgencias();
            this.provincia = 0;
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

        private void btnRegistrarAgencia_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtDistrito.Text == "" || cmbProvincia.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Uno o mas campos estan vacios!");
                MessageBox.Show("Intentelo de nuevo");
            }
            else
            {
                if (this.conector.registrarAgencia(txtNombre.Text, this.provincia, txtDistrito.Text, txtDireccion.Text))
                {
                    MessageBox.Show("Se ha registrado la agencia exitosamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al registrar la agencia!");
                    MessageBox.Show("Intentelo de nuevo");
                }
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedIndex == 0)
            {
                this.provincia = 1;
            }else if(cmbProvincia.SelectedIndex == 1)
            {
                this.provincia = 2;
            }
            else if (cmbProvincia.SelectedIndex == 2)
            {
                this.provincia = 5;
            }
            else if (cmbProvincia.SelectedIndex == 3)
            {
                this.provincia = 6;
            }
            else if (cmbProvincia.SelectedIndex == 4)
            {
                this.provincia = 7;
            }
            else if (cmbProvincia.SelectedIndex == 5)
            {
                this.provincia = 8;
            }
            else if (cmbProvincia.SelectedIndex == 6)
            {
                this.provincia = 9;
            }
        }
    }
}
