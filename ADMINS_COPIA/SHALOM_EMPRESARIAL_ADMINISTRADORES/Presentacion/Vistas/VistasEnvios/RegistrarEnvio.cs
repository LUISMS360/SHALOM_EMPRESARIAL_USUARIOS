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
    public partial class RegistrarEnvio : Form
    {
        private ControladorEnvio conector;
        private int agenciaOrigen;
        private int agenciaDestino;
        private int camionID;
        private int administrador;
        private ControlExcepciones verificador;

        public RegistrarEnvio()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            ApplyRoundedCornersToAllPanels(this);
            this.conector = new ControladorEnvio();
            this.agenciaOrigen = 0;
            this.agenciaDestino = 0;
            this.camionID = 0;
            this.administrador = 0;
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
        private void ApplyRoundedCornersToPanel(Panel panel)
        {
            int borderRadius = 20;
            Rectangle newRect = new Rectangle(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseFigure();
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
        public void limpiarCuadros()
        {
            txtDniEmisor.Text = "";
            txtNombreEmisor.Text = "";
            txtApellidosEmisor.Text = "";
            txtDniReceptor.Text = "";
            txtNombresReceptor.Text = "";
            txtApellidosEmisor.Text = "";
            cmbServicio.Text = "";
            cmbTipoPaquete.Text = "";
            txtPeso.Text = "";
            txtContenido.Text = "";
            txtTotalPagart.Text = "";
            cmbProvinciaOrigen.Text = "";
            cmbProvinciaDestino.Text = "";
            cmbAgenciaDestino.Text = "";
            cmbAgenciaOrigen.Text = "";
            cmbAdministrador.Text = "";
            cmbCamion.Text = "";
        }
        private void btnRegistrarEnvio_Click(object sender, EventArgs e)
        {

            //Pasando los valores a variables: 

            if (!this.verificador.verificarInt(txtDniEmisor.Text) || !this.verificador.verificarInt(txtDniReceptor.Text) || !this.verificador.verificarDouble(txtPeso.Text)
                || !this.verificador.verificarDouble(txtTotalPagart.Text))
            {
                MessageBox.Show("Ha Ingresado uno o mas datos incorrectos!");
                MessageBox.Show("Intentelo de nuevo!");
            }
            else
            {
                int dniEmisor = int.Parse(txtDniEmisor.Text);
                string nombreEmisor = txtNombreEmisor.Text;
                string apellidosEmisor = txtApellidosEmisor.Text;
                string servicio = cmbServicio.Text;
                string tipoPaquete = cmbTipoPaquete.Text;
                double peso = double.Parse(txtPeso.Text);
                string contenido = txtContenido.Text;
                int dniReceptor = int.Parse(txtDniReceptor.Text);
                string nombreReceptor = txtNombresReceptor.Text;
                string apellidosReceptor = txtApellidosEmisor.Text;
                int agenciaOrigen = this.agenciaOrigen;
                int agenciaDestino = this.agenciaDestino;
                int camionID = this.camionID;
                double totalPagar = double.Parse(txtTotalPagart.Text);
                int admin = this.administrador;

                if (this.conector.registrarEnvio(dniEmisor, nombreEmisor, apellidosEmisor, servicio, tipoPaquete, peso,
                    contenido, dniReceptor, nombreReceptor, apellidosReceptor, agenciaOrigen, agenciaDestino, camionID,
                    totalPagar, admin))
                {
                    MessageBox.Show("Se ha registrado el envio!");

                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                    MessageBox.Show("Intentelo de nuevo");

                }
            }
        }

        private void cmbProvinciaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbAgenciaOrigen.DataSource = this.conector.obtenerAgencias(cmbProvinciaOrigen.Text);
                        
        }

        private void cmbProvinciaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServicio.SelectedIndex == 0)
            {
                
                cmbAgenciaDestino.DataSource = this.conector.obtenerAgencias(cmbProvinciaDestino.Text);
                cmbCamion.DataSource = this.conector.obtenerCamion(cmbProvinciaOrigen.Text, cmbProvinciaDestino.Text);
            }
            else if(cmbServicio.SelectedIndex == 1)
            {
                cmbAgenciaDestino.DataSource = this.conector.obtenerAgencias(cmbProvinciaDestino.Text);
                cmbCamion.DataSource = this.conector.obtenerAviones(cmbProvinciaOrigen.Text, cmbProvinciaDestino.Text);
                
            }
            
        }

        private void cmbAgenciaOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            this.agenciaOrigen = this.conector.obtenerIdAgencia(cmbAgenciaOrigen.Text);
        }

        private void cmbAgenciaDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            this.agenciaDestino = this.conector.obtenerIdAgencia(cmbAgenciaDestino.Text);
        }

        private void cmbAdministrador_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbAdministrador.Text.Equals("Luis Enrrique"))
            {
                this.administrador = 1;
            }
        }

        private void cmbCamion_SelectedValueChanged(object sender, EventArgs e)
        {
           
            this.camionID = this.conector.obtenerIdCamion(cmbCamion.Text);
        }

        private void cmbProvinciaOrigen_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDniEmisor_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDniEmisor.Text))
            { labelErrorEmisor.Visible = true; }
            else
            { labelErrorEmisor.Visible = false; }
        }

        private void txtDniReceptor_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDniReceptor.Text))
            { lblErrorReceptor.Visible = true; }
            else
            { lblErrorReceptor.Visible = false; }
        }
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarDouble(txtPeso.Text))
            { lblErroPeso.Visible = true; }
            else
            { lblErroPeso.Visible = false; }
        }
        private void txtTotalPagart_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarDouble(txtTotalPagart.Text))
            { labelErrorPagar.Visible = true; }
            else
            { labelErrorPagar.Visible = false; }
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServicio.SelectedIndex == 1)
            {
                cmbProvinciaOrigen.DataSource = this.conector.obtenerProvinciasAereo();
                cmbProvinciaDestino.DataSource = this.conector.obtenerProvinciasAereo();
            }
            
        }

        private void cmbAgenciaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
