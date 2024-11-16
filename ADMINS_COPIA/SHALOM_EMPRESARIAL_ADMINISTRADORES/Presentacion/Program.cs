using Presentacion.Vistas;
using Presentacion.Vistas.Vistas_Principales;
using Presentacion.Vistas.VistasAgencia;
using Presentacion.Vistas.VistasCamiones;
using Presentacion.Vistas.VistasCliente;
using Presentacion.Vistas.VistasConductores;
using Presentacion.Vistas.VistasEnvios;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new IncioCarga());
        }
    }
}