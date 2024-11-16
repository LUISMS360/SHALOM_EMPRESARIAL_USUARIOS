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
using LogicaNegocio.Controladores;
using LogicaNegocio.MenejoExpeciones;
namespace Presentacion.Vistas.VistasEnvios
{
    public partial class VerEnvios : Form
    {
        private ControlExcepciones verificador;
        private ControladorEnvio conector;
        private int origen;
        private int destino;
        public VerEnvios()
        {
            InitializeComponent();
            this.conector = new ControladorEnvio();
            ApplyRoundedCornersToAllButtons(this);
            this.verificador = new ControlExcepciones();
            this.origen = 0;
            this.destino = 0;
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
        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeleccion.SelectedIndex == 0 && cmbSeleccion.Text.Equals("Todos"))
            {
                resultadoBusqueda.DataSource = this.conector.listarTodosEnvios();
            }
            else if (cmbSeleccion.SelectedIndex == 1)
            {
                

                //Activado
                txtCliente.Location = new Point(104, 106);
                lblCliente.Location = new Point(12, 114);
                txtCliente.Visible = true;
                lblCliente.Visible = true;
                btnBuscar.Visible = true;

                //Desactivar el resto
                //txtCliente.Visible = false;
                //lblCliente.Visible = false;
                panelFecha.Visible = false;
                lblOrigen.Visible = false;
                cmbOrigen.Visible = false;
                lblDestino.Visible = false;
                cmbDestino.Visible = false;
                panelFecha.Location = new Point(514, 81);
                lblOrigen.Location = new Point(716, 12);
                cmbOrigen.Location = new Point(716, 42);
                lblDestino.Location = new Point(583, 11);
                cmbDestino.Location = new Point(576, 42);
                //lblCliente.Location = new Point(453, 12);
                //txtCliente.Location = new Point(444, 42);


            }
            else if (cmbSeleccion.SelectedIndex == 2)
            {
                //Activado
                panelFecha.Location = new Point(12, 98);
                panelFecha.Visible = true;
                btnBuscar.Visible = true;

                //Desactivar el resto

                txtCliente.Visible = false;
                lblCliente.Visible = false;
                //panelFecha.Visible = false;
                lblOrigen.Visible = false;
                cmbOrigen.Visible = false;
                lblDestino.Visible = false;
                cmbDestino.Visible = false;
                //panelFecha.Location = new Point(512, 96);
                lblOrigen.Location = new Point(716, 12);
                cmbOrigen.Location = new Point(716, 42);
                lblDestino.Location = new Point(583, 11);
                cmbDestino.Location = new Point(576, 42);
                lblCliente.Location = new Point(453, 12);
                txtCliente.Location = new Point(444, 42);

            }
            else if (cmbSeleccion.SelectedIndex == 3)
            {
                //Activado
                lblOrigen.Location = new Point(45, 115);
                cmbOrigen.Location = new Point(121, 107);
                lblOrigen.Visible = true;
                cmbOrigen.Visible = true;
                btnBuscar.Visible = true;

                //Desactivar el resto

                txtCliente.Visible = false;
                lblCliente.Visible = false;
                panelFecha.Visible = false;
                //lblOrigen.Visible = false;
                //txtOrigen.Visible = false;
                lblDestino.Visible = false;
                cmbDestino.Visible = false;
                panelFecha.Location = new Point(514, 81);
                //lblOrigen.Location = new Point(716, 12);
                //txtOrigen.Location = new Point(716, 42);
                lblDestino.Location = new Point(583, 11);
                cmbDestino.Location = new Point(576, 42);
                lblCliente.Location = new Point(453, 12);
                txtCliente.Location = new Point(444, 42);

            }
            else if (cmbSeleccion.SelectedIndex == 4)
            {
                //Activado
                lblDestino.Location = new Point(26, 116);
                cmbDestino.Location = new Point(110, 107);
                lblDestino.Visible = true;
                cmbDestino.Visible = true;
                btnBuscar.Visible = true;

                //Desactivar el resto

                txtCliente.Visible = false;
                lblCliente.Visible = false;
                panelFecha.Visible = false;
                lblOrigen.Visible = false;
                cmbOrigen.Visible = false;
                //lblDestino.Visible = false;
                //txtDestino.Visible = false;
                panelFecha.Location = new Point(514, 81);
                lblOrigen.Location = new Point(716, 12);
                cmbOrigen.Location = new Point(716, 42);
                //lblDestino.Location = new Point(583, 11);
                //txtDestino.Location = new Point(576, 42);
                lblCliente.Location = new Point(453, 12);
                txtCliente.Location = new Point(444, 42);

            }else if (cmbSeleccion.SelectedIndex==5)
            {
                resultadoBusqueda.DataSource = this.conector.enviosRecaudadoPagados();
            }
            else if (cmbSeleccion.SelectedIndex == 6)
            {
                resultadoBusqueda.DataSource = this.conector.enviosRecaudadoNoPagados();
            }
            else if (cmbSeleccion.SelectedIndex == 7)
            {
                resultadoBusqueda.DataSource = this.conector.enviosEntragados();
            }
            else if (cmbSeleccion.SelectedIndex == 8)
            {
                resultadoBusqueda.DataSource = this.conector.enviosRegistrados();
            }
            else if (cmbSeleccion.SelectedIndex == 9)
            {
                resultadoBusqueda.DataSource = this.conector.enviosCamino();
            }else if(cmbSeleccion.SelectedIndex == 10)
            {

                resultadoBusqueda.DataSource = this.conector.enviosAereo();

            }else if(cmbSeleccion.SelectedIndex ==11)
            {
                resultadoBusqueda.DataSource = this.conector.enviosTerrestre();
            }

        }

    

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           if(cmbSeleccion.SelectedIndex == 1)
            {
                if (!this.verificador.verificarInt(txtCliente.Text))
                {
                    MessageBox.Show("El valor introducido no es valido!");
                }
                else
                {
                    resultadoBusqueda.DataSource = this.conector.verEnvio(int.Parse(txtCliente.Text));
                }                                                             
            }
            else if (cmbSeleccion.SelectedIndex == 2)
            {                
                  string fechaIncio = cmbAnioIncio.Text + "-" + cmbMesIncio.Text + "-" + cmbDiaIncio.Text;
                  string fechaFin = cmbAnioFin.Text + "-" + cmbMesFin.Text + "-" + cmbDiaFin.Text;
                  resultadoBusqueda.DataSource = this.conector.verEnvioFecha(fechaIncio, fechaFin);                
                                
            }
            else if (cmbSeleccion.SelectedIndex == 3)
            {
                try
                {
                    this.origen = this.conector.obtenerIdAgencia(cmbOrigen.Text);                    
                    resultadoBusqueda.DataSource = this.conector.verEnvioOrigen(this.origen);
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor introducido no es valido!");
                }                
            }
            else if (cmbSeleccion.SelectedIndex == 4)
            {
                try
                {
                    this.destino = this.conector.obtenerIdAgencia(cmbDestino.Text);
                    resultadoBusqueda.DataSource = this.conector.verEnvioDestino(this.destino);
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor introducido no es valido!");
                }                
            }
        }
    }
}
