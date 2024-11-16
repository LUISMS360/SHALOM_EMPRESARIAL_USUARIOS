using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Controladores;
using AccesoDatos.Models;

namespace Presentacion
{
    public partial class VerAgencias : Form
    {
        private AgenciaController conector;
        public VerAgencias()
        {
            conector = new AgenciaController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la lista de agencias para la provincia seleccionada
            List<AgenciaModel> agencias = conector.verAgencia(cmbProvincia.Text);

            // Verificar que la lista tiene al menos 3 elementos
            if (agencias.Count > 0)
            {
                lblProvincia1.Text = agencias[0].getProvincia();
                lblDistrito1.Text = agencias[0].getDistrito();
                lblDireccion1.Text = agencias[0].getDireccion();
                lblNombre1.Text = agencias[0].getNombreAgencia();
            }

            if (agencias.Count > 1)
            {
                lblProvincia2.Text = agencias[1].getProvincia();
                lblDistrito2.Text = agencias[1].getDistrito();
                lblDireccion2.Text = agencias[1].getDireccion();
                lblNombre2.Text = agencias[1].getNombreAgencia();
            }

            if (agencias.Count > 2)
            {
                lblProvincia3.Text = agencias[2].getProvincia();
                lblDistrito3.Text = agencias[2].getDistrito();
                lblDireccion3.Text = agencias[2].getDireccion();
                lblNombre3.Text = agencias[2].getNombreAgencia();
            }

            // Hacer visible el panel solo si hay al menos una agencia
            if (agencias.Count > 0)
            {
                if (lblNombre1.Text == "Shalom_001" && lblNombre2.Text == "Shalom_002" && lblNombre3.Text == "Shalom_003")
                {
                    int a = 0, b = 1, c = 2;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                else if (lblNombre1.Text == "Shalom_004" && lblNombre2.Text == "Shalom_005" && lblNombre3.Text == "Shalom_006")
                {
                    int a = 3, b = 4, c = 5;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                else if (lblNombre1.Text == "Shalom_007" && lblNombre2.Text == "Shalom_008" && lblNombre3.Text == "Shalom_009")
                {
                    int a = 6, b = 7, c = 8;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                else if (lblNombre1.Text == "Shalom_010" && lblNombre2.Text == "Shalom_011" && lblNombre3.Text == "Shalom_012")
                {
                    int a = 9, b = 10, c = 11;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                else if (lblNombre1.Text == "Shalom_013" && lblNombre2.Text == "Shalom_014" && lblNombre3.Text == "Shalom_015")
                {
                    int a = 12, b = 13, c = 14;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                else if (lblNombre1.Text == "Shalom_016" && lblNombre2.Text == "Shalom_017" && lblNombre3.Text == "Shalom_018")
                {
                    int a = 15, b = 16, c = 17;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                else if (lblNombre1.Text == "Shalom_019" && lblNombre2.Text == "Shalom_020" && lblNombre3.Text == "Shalom_021")
                {
                    int a = 18, b = 19, c = 20;
                    btnFoto1.ImageIndex = a;
                    btnFoto2.ImageIndex = b;
                    btnFoto3.ImageIndex = c;
                }
                panelAgencias.Visible = true;
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
