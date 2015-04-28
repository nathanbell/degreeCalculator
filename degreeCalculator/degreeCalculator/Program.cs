using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degreeCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MainView mainView = new MainView();
            //MVController generalController = new MVController();
            //AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            //generalController.setView(mainView);
            //mainView.setController(generalController);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Console.WriteLine("Saving data.");
        }
    }
}
