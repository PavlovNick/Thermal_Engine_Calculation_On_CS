using System;
using System.Windows.Forms;

namespace Thermal_Engine_Calculation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App.WinForm.TermalEngineForm TermalEngineFormobject = new App.WinForm.TermalEngineForm();
            TermalEngineFormobject.Connect_Event_Handler();

            Application.Run(TermalEngineFormobject);
        }
    }
}
