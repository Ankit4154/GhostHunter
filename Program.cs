using System;
using System.Windows.Forms;


namespace GhostHunter
{
    // Program class definition
    static class Program
    {
        // The main entry point for the application.
        // Runs application by providing object of 
        // basic game form - GhostHunterForm
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new GhostHunterForm();
            Application.Run(form);
            form.Dispose();

        }
    }
}
