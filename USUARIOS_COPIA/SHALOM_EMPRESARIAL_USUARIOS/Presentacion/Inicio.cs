using LogicaNegocio.Controladores;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {


        }

        private void btnShalomInforma_Click(object sender, EventArgs e)
        {

        }

        private void btnComunicate_Click(object sender, EventArgs e)
        {


        }

        private void btnServicios_Click(object sender, EventArgs e)
        {


        }

        private void btnComunicate_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnServicios_MouseHover(object sender, EventArgs e)
        {
            btnAyuda.Location = new Point(12, 364);
            btnShalomInforma.Location = new Point(12, 421);
            btnComunicate.Location = new Point(12, 479);
            btnTerrestre.Location = new Point(12, 264);
            btnAreo.Location = new Point(12, 314);
            btnTerrestre.Visible = true;
            btnAreo.Visible = true;



        }



        private void btnAyuda_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAyuda_MouseHover_1(object sender, EventArgs e)
        {
            btnServicios.Location = new Point(12, 209);
            btnAyuda.Location = new Point(12, 264);
            btnShalomInforma.Location = new Point(12, 421);
            btnComunicate.Location = new Point(12, 479);
            btnPreguntasFrecuentes.Location = new Point(12, 321);
            btnRestricciones.Location = new Point(12, 371);
            btnPreguntasFrecuentes.Visible = true;
            btnRestricciones.Visible = true;
            btnTerrestre.Location = new Point(391, 187);
            btnAreo.Location = new Point(391, 252);
            btnTerrestre.Visible = false;
            btnAreo.Visible = false;

        }

        private void btnComunicate_MouseHover(object sender, EventArgs e)
        {
            btnServicios.Location = new Point(12, 209);
            btnAyuda.Location = new Point(12, 264);
            btnShalomInforma.Location = new Point(12, 321);
            btnComunicate.Location = new Point(12, 379);
            btnContactanos.Location = new Point(12, 437);
            btnTrabaja.Location = new Point(12, 487);
            btnContactanos.Visible = true;
            btnTrabaja.Visible = true;

        }


        private void btnIn_MouseHover(object sender, EventArgs e)
        {
            panelIn.Visible = true;
            panelRas.Visible = false;
            panelPag.Visible = false;
            panelAgen.Visible = false;
            panelTar.Visible = false;
        }



        private void btnRas_MouseHover(object sender, EventArgs e)
        {
            panelIn.Visible = false;
            panelRas.Visible = true;
            panelPag.Visible = false;
            panelAgen.Visible = false;
            panelTar.Visible = false;

        }

        private void btnPag_MouseHover(object sender, EventArgs e)
        {
            panelIn.Visible = false;
            panelRas.Visible = false;
            panelPag.Visible = true;
            panelAgen.Visible = false;
            panelTar.Visible = false;
        }

        private void btnAgen_MouseHover(object sender, EventArgs e)
        {
            panelIn.Visible = false;
            panelRas.Visible = false;
            panelPag.Visible = false;
            panelAgen.Visible = true;
            panelTar.Visible = false;
        }

        private void btnTarifas_MouseHover(object sender, EventArgs e)
        {
            panelIn.Visible = false;
            panelRas.Visible = false;
            panelPag.Visible = false;
            panelAgen.Visible = false;
            panelTar.Visible = true;
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new FormInicioHija());
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormInicioHija());
        }

        private void btnRas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Rastrear());
        }

        private void btnPag_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Pagar());
        }

        private void btnAgen_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new VerAgencias());
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new VerTarifas());
        }
    }
}
