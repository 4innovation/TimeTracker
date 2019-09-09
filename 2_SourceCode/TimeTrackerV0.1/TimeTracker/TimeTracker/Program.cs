using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Log_In LogIn = new Log_In();
            LogIn.ShowDialog();
            //Application.Run(LogIn);
 

            if (LogIn.HandleVariable())
            {
                TimeTrackerGUI GUI = new TimeTrackerGUI();
                Application.Run(GUI);
            }
             
            // if(LogIn.PW)
        }
    }
}
