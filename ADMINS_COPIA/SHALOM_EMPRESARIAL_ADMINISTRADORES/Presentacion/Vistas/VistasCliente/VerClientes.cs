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
    public partial class VerClientes : Form
    {
        private ControlExcepciones verificador;
        private ControladorCliente conector;
        public VerClientes()
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
        private void cmbFiltroBusquedaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroBusquedaClientes.SelectedIndex == 0)
            {
                resultadoBusqueda.DataSource = this.conector.listarClientes();
                lblDni.Visible = false; txtDni.Visible =false; btnBuscar.Visible = false;
            }
            else if (cmbFiltroBusquedaClientes.SelectedIndex == 1)
            {
                lblDni.Visible = true; txtDni.Visible = true; btnBuscar.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {            
                if (!this.verificador.verificarInt(txtDni.Text))
                { lblErrorDni.Visible = true; }
                else
                {
                    resultadoBusqueda.DataSource = this.conector.verCliente(int.Parse(txtDni.Text));
                }
                lblErrorDni.Visible = false;         
        }
    }
}
