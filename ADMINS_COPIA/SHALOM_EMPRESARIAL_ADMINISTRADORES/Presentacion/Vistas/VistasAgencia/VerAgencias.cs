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
    public partial class VerAgencias : Form
    {
        private ControladorAgencias conector;
        public VerAgencias()
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

        private void cmbFiltroBusquedaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroBusquedaClientes.SelectedIndex == 0)
            {
                btnBuscar.Visible = false;
                resultadoBusqueda.DataSource = this.conector.verTodasAgencias();

            }
            else if (cmbFiltroBusquedaClientes.SelectedIndex == 1)
            {
                //Modidificando las posiciones de los txt 
                lblAgenica.Location = new Point(12, 81);
                txtAgencia.Location = new Point(12, 110);

                lblAgenica.Visible = true;
                txtAgencia.Visible = true;

                lblProvincia.Location = new Point(509, 90);
                cmbProvincia.Location = new Point(500, 120);

                lblProvincia.Visible = false;
                cmbProvincia.Visible = false;
                btnBuscar.Visible = true;

            }
            else if (cmbFiltroBusquedaClientes.SelectedIndex == 2)
            {
                lblProvincia.Location = new Point(18, 80);
                cmbProvincia.Location = new Point(12, 110);

                lblProvincia.Visible = true;
                cmbProvincia.Visible = true;

                //Modidificando las posiciones de los txt 
                lblAgenica.Location = new Point(331, 90);
                txtAgencia.Location = new Point(331, 117);

                lblAgenica.Visible = false;
                txtAgencia.Visible = false;
                btnBuscar.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbFiltroBusquedaClientes.SelectedIndex == 1)
            {
                resultadoBusqueda.DataSource = this.conector.verAgenciaEspce(txtAgencia.Text);
                if (resultadoBusqueda.Rows.Count == 0) { MessageBox.Show("No se ha encontrado ninguna Agencia por el Nombre!"); }

            }else if (cmbFiltroBusquedaClientes.SelectedIndex == 2)
            {
                resultadoBusqueda.DataSource = this.conector.verAgenciaProvincia(cmbProvincia.Text);
                if (resultadoBusqueda.Rows.Count == 0) { MessageBox.Show("No se ha encontrado ninguna Agencia por la Provincia!"); }
            }
        }
    }
}
