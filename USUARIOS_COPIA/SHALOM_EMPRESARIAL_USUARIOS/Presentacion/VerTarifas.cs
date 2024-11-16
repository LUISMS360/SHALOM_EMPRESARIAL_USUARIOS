using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VerTarifas : Form
    {
        private int indice; // Declarar la variable de instancia
        private int monto;
        private int tipo;

        public VerTarifas()
        {
            InitializeComponent();
            indice = 0;
            tipo = 1;
            monto = 8; // Inicializar la variable monto
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl.ImageIndex = 0;
            monto = 8;
            indice = 0;
            tipo = 1; // Restablecer el tipo también
            lblTipo.Text = "A " + tipo.ToString();
            lblMonto.Text = monto.ToString() + ".00 S/";
        }

        private void btnAvanzar_Click_1(object sender, EventArgs e)
        {
            // Asumimos que hay más de 3 imágenes disponibles en la lista
            if (indice < 2) // Cambiado de 3 a 2 porque los índices son 0, 1, 2
            {
                lbl.ImageIndex = indice;
                monto += 8;
                tipo += 1;
                lblTipo.Text = "A " + tipo.ToString();
                lblMonto.Text = monto.ToString() + ".00 S/";
                indice++;
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lbl.ImageIndex = indice;
                monto -= 8;
                tipo -= 1;
                lblTipo.Text = "A " + tipo.ToString();
                lblMonto.Text = monto.ToString() + ".00 S/";
            }
        }
    }
}
