using Comun.Cache;
using LogicaNegocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion.Vistas.Vistas_Principales
{
    public partial class IncioCarga : Form
    {
        private ServicioAdmin conector; 
        public IncioCarga()
        {
            InitializeComponent();
            this.conector = new ServicioAdmin();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private async void IncioCarga_Load(object sender, EventArgs e)
        {
            DatosApp.estado = this.conector.obtenerEstadoApp();

            progreBarCargar.Minimum = 0;
            progreBarCargar.Maximum = 100;  // Establecer el máximo correctamente
            progreBarCargar.Step = 1;

            // Simular la carga
            await Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        progreBarCargar.Value = i;
                        labelCarga.Text = $"Cargando: {i}%";
                    }));
                    System.Threading.Thread.Sleep(50); // Simular trabajo
                }
            });

           
            // Abrir el segundo formulario
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IncioCarga_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
