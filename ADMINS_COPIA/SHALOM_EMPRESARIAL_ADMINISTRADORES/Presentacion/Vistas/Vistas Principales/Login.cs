using LogicaNegocio.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Drawing.Drawing2D;
using Comun.Cache;

namespace Presentacion.Vistas
{
    public partial class Login : Form
    {
        private ControladorAdmin conector;
        public Login()
        {
            this.conector = new ControladorAdmin();
            InitializeComponent();
            ApplyRoundedCornersToAllButtons(this);
        }
        private void ApplyRoundedCorners(Button btn)
        {
            // Define el radio de los bordes redondeados
            int borderRadius = 20;
            // Define el área del botón
            Rectangle newRect = new Rectangle(0, 0, btn.Width, btn.Height);
            // Crear el GraphicsPath con bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(btn.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            path.AddArc(new Rectangle(btn.Width - borderRadius, btn.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, btn.Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseFigure();

            // Establecer la ruta como la región del botón
            btn.Region = new Region(path);

            // Suscribirse al evento Paint del botón para dibujar el borde           

            // Establecer otras propiedades del botón si es necesario
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void button1_Click(object sender, EventArgs e)
        {
            
            if (this.conector.verificarLoguin(txtUsuario.Text, txtContra.Text) > 0)
            {
                lblError.Visible = false;
                if (DatosUser.estado_admin.Equals("Desabilitado"))
                {
                    MessageBox.Show("Usuario Inactivo Comunquese con el Adiministrador");
                }
                else
                {
                    InicioAdmin formulario = new InicioAdmin();
                    formulario.Show();
                    this.Hide();
                }                
              }
            else
            {
                lblError.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (DatosApp.estado.Equals("Mantenimiento"))
            {
                MessageBox.Show("LA APLICACION SE ENCUENTRA EN MANETENIMINETO\n" +
                    "ESPERE LA ACTUALIZACION 2.0");

                Application.Exit();
            }

        }
    }
}
