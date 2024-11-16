using LogicaNegocio.Controladores;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private ControladorConexion conector;
        public Form1()
        {
            this.conector = new ControladorConexion();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.conector.devolverConexion())
            {
                MessageBox.Show("Se ha establecido la conexion!");
            }
            else
            {
                MessageBox.Show("No se ha podido establecer la conexion!");
            }
        }
    }
}
