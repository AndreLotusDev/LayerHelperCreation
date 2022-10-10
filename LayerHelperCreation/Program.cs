using Autofac;
using LayerHelperCreation.Factory;
using LayerHelperCreation.Shared;

namespace LayerHelperCreation
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
            InstanceFactory.Start();

            Application.Run(new Main());
        }
    }
}