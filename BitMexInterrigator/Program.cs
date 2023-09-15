using System.Diagnostics;

namespace BitMexInterrigator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine("Hello");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}