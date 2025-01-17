using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace kursovaya
{
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool islog = false;
            int id = 0;
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(islog, id));
        }
    }
}