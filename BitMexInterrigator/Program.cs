using BitMexInterrigator.BitMex.Controllers;
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
            ApplicationConfiguration.Initialize();
            Application.Run(new InstrumentForm());
        }
    }
}