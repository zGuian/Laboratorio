using Lab_Application.Interfaces;
using Lab_Application.Services;
using Lab_PresentationDesktop.FormularioViews;

namespace Lab_PresentationDesktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Frm_Principal());
        }
    }
}