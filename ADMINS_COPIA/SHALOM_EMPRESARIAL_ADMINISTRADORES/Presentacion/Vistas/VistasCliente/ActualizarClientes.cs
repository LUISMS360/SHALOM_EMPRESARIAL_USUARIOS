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

namespace Presentacion.Vistas.VistasCliente
{
    public partial class ActualizarClientes : Form
    {
        private ControladorCliente conector;
        private ControlExcepciones verificador;
        public ActualizarClientes()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            this.conector = new ControladorCliente();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDni.Text))
            {

            }
            ClientesModel cliente = this.conector.verClienteBuscado(int.Parse(txtDni.Text));

            lblNroCliente.Text = cliente.getClienteID().ToString();
            lblDni.Text = cliente.getDniCliente().ToString();
            lblNombres.Text = cliente.getNombresCliente();
            lblApellidos.Text = cliente.getApellidosCliente();
            lblFecha.Text = cliente.getFechaRegistro();

            lblNroCliente.Visible = true;
            lblDni.Visible = true;
            lblNombres.Visible = true;
            lblApellidos.Visible = true;
            lblFecha.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDni.Text))
            {
                MessageBox.Show("El numero de DNI ingresado no es valido!");
            }
            else
            {
                if (this.conector.actualizarCliente(txtNuevosNombres.Text, txtNuevoApellido.Text, int.Parse(txtDni.Text)))
                {
                    MessageBox.Show("Se ha actulizado la informacion del cliente correctamente!");
                }
                else
                {
                    MessageBox.Show("No se ha podido actualizar la informacion del cliente!");
                }
            }
            
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (!this.verificador.verificarInt(txtDni.Text))
                { lblErrorDni.Visible = true; }
            else
                { lblErrorDni.Visible = false; }
        }

        private void txtNuevosNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevoApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
