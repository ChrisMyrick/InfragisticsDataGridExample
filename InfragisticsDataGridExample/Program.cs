using System;
using System.Windows.Forms;
using InfragisticsDataGridExample.Presentation;

namespace InfragisticsDataGridExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Presentation.View());
        }
    }
}
