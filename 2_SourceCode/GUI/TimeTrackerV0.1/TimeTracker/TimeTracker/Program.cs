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
            string[,] _LogInValues = new string[3, 2];



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Log_In LogIn = new Log_In();
            LogIn.ShowDialog();
            //Application.Run(LogIn);



            _LogInValues = LogIn.HandleVariable();

            if (_LogInValues[2,1] == "true")
            {
                TimeTrackerGUI GUI = new TimeTrackerGUI(_LogInValues[1,1], _LogInValues[0,1]);
                Application.Run(GUI);
            }
             
            // if(LogIn.PW)
        }
    }
}
