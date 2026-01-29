using System;
using System.Windows.Forms;

namespace Tłumacz
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicjalizacja ustawień WinForms
            ApplicationConfiguration.Initialize();

            // Uruchom właściwy formularz
            Application.Run(new Form1());
        }
    }
}