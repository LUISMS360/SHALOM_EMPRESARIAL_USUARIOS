using Comun.Cache;
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
using Presentacion.Vistas.VistasAgencia;
using Presentacion.Vistas.VistasEnvios;
using Presentacion.Vistas.VistasCliente;
using Presentacion.Vistas.VistasCamiones;
using Presentacion.Vistas.VistasConductores;
using Presentacion.Vistas.Vistas_Principales;

namespace Presentacion.Vistas
{
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void abrirFormHija(object formhija)
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
        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            abrirFormHija(new FormPerfilAdmin());

        }

        private void InicioAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelOpciones_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login formulario = new Login();
            formulario.Show();
            this.Hide();
            this.Close();
        }



        private void btnGestionarEnvios1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormEnvios());
        }

        private void btnGestionarEnvios2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormEnvios());
        }

        private void btnGestionarClientes1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormClientes());
        }

        private void btnGestionarClientes3_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormClientes());
        }

        private void btnGestionarCamiones2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormCamiones());
        }



        private void bntGestionarCamiones3_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormCamiones());
        }



        private void btnGestionarConductores2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormConductores());
        }

        private void btnGestionarConductores3_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormConductores());
        }



        private void btnGestionarAgencias2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormAgencia());
        }

        private void btnGestionarAgencias3_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormAgencia());
        }



        private void btnGestinarEnvios_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormEnvios());
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormClientes());
        }

        private void btnGestionarConductores_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormConductores());
        }

        private void btnGestionarAgencias_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormAgencia());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormPerfilAdmin());
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormPerfilAdmin());
        }
    }
}
