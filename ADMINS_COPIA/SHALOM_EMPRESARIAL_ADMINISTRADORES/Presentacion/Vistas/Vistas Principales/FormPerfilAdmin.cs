using Comun.Cache;
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

namespace Presentacion.Vistas.Vistas_Principales
{
    public partial class FormPerfilAdmin : Form
    {
        public FormPerfilAdmin()
        {
            InitializeComponent();
            

        }                

        public void cargarDatos()
        {
            if (DatosUser.usuario_admin == "Emperador2005")
            {
                lblImagen.ImageIndex = 0;
            }
            lblUsuario.Text = DatosUser.usuario_admin;
            lblNombres.Text = DatosUser.nombres_admin; 
            lblApellidos.Text = DatosUser.apellidos_admin;
            lblEstado.Text = DatosUser.estado_admin;
           
        }

        private void FormPerfilAdmin_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
