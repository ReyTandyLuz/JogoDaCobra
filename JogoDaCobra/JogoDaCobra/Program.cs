using JogoDaCobra.Entities;

namespace JogoDaCobra
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            await ListaUtilizadores.CarregarDados();

            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}