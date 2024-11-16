using LogicaNegocio.Controladores;
using LogicaNegocio.MenejoExpeciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas.VistasCamiones
{
    public partial class VerCamiones : Form
    {
        private ControlExcepciones verificador;
        private ControladorCamiones conector;
        public VerCamiones()
        {
            this.conector = new ControladorCamiones();
            InitializeComponent();
            this.verificador = new ControlExcepciones();
        }

        private void cmbFiltroBusquedaClonductores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroBusquedaClonductores.SelectedIndex == 0)
            {
                lblPlaca.Visible = false;
                txtPlaca.Visible = false;
                btnBuscar.Visible = false;

                resultadoBusqueda.DataSource = this.conector.verTodosCamiones();


            }
            else if (cmbFiltroBusquedaClonductores.SelectedIndex == 1)
            {
                lblPlaca.Visible = true;
                txtPlaca.Visible = true;
                btnBuscar.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbFiltroBusquedaClonductores.SelectedIndex == 1)
            {
                resultadoBusqueda.DataSource = this.conector.verCamionEspc(txtPlaca.Text);
                if (resultadoBusqueda.Rows.Count == 0) { MessageBox.Show("No hay informacion con la placa buscada!"); }
            }
        }

        private void resultadoBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
