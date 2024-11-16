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

namespace Presentacion.Vistas.VistasCamiones
{
    public partial class EliminarCamion : Form
    {
        private ControladorCamiones conector;
        public EliminarCamion()
        {
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
            this.conector = new ControladorCamiones();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CamionesModel camion = this.conector.verCamionBuscado(txtCamionBuscar.Text);
            if (camion.getCamionID() == 0)
            {
                MessageBox.Show("El camion no existe!");
            }
            else
            {
                lblNroCamion.Text = camion.getCamionID().ToString();
                lblPlaca.Text = camion.getPlaca();
                lblConductor.Text = camion.getApellidosConductor();
                lblInfo.Text = camion.getInformacion();
                lblEstado.Text = camion.getEstado();
                lblFecha.Text = camion.getFechaInscripcion();
                lblOrigen.Text = camion.getProvinciaOrigenNom();
                lblDestino.Text = camion.getProvinciaDestinoNom();

                lblNroCamion.Visible = true;
                lblPlaca.Visible = true;
                lblConductor.Visible = true;
                lblInfo.Visible = true;
                lblEstado.Visible = true;
                lblFecha.Visible = true;
                lblOrigen.Visible = true;
                lblDestino.Visible = true;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(lblNroCamion.Visible == false)
            {
                MessageBox.Show("El camion a eliminar no existe!");
            }
            else
            {
                if (this.conector.eliminarCamion(lblPlaca.Text))
                {
                    MessageBox.Show("Se ha elimando el camion correctamente!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!");
                    MessageBox.Show("Verifique que el camion tenga ningun envio pendiente");
                }
            }

        }
    }
}
