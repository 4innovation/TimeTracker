using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// remove when it works
using System.IO.Ports;

namespace TimeTracker
{
    public partial class TimeTrackerGUI : Form
    {
        SerialPortManager _PortManager = new SerialPortManager();
        string _UserRole = string.Empty;
        string _UserName = string.Empty;


        // Konstruktor
        public TimeTrackerGUI(string Role, string Username)
        {
            this._UserName = Username;
            this._UserRole = Role;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_PortManager.Intialize())
            {
                while (true)
                {
                    string ruck = _PortManager.Run();
                    if (!String.IsNullOrEmpty(ruck))
                    {
                        listBox1.Items.Add(ruck);
                    }

                }
                //var msg =
            }

        }

        private void TimeTrackerGUI_Load(object sender, EventArgs e)
        {
            SerialPort port;
            foreach (string s in SerialPort.GetPortNames())
            {
                comPort.Items.Add(s);
            }
        }

        private void benutzerverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Neue Form
        }

    }
}
