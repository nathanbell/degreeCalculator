using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degreeCalculator
{
    static class Program
    {        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);


            
            mainForm mainView = new mainForm();
            modelViewController generalController = new modelViewController();
            generalController.setView(mainView);
            mainView.setController(generalController);
            
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.Run(mainView);
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Console.WriteLine("Saving data.");
        }
    }
}
