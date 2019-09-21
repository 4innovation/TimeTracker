using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace TimeTracker
{
    class SerialPortManager
    {
        SerialPort port;

        public bool Intialize()
        {
            try
            {
                
                port = new SerialPort();

                System.ComponentModel.IContainer components =
                    new System.ComponentModel.Container();
                port = new System.IO.Ports.SerialPort(components);
                port.PortName = "COM8";
                //    comPort.SelectedItem.ToString();
                port.BaudRate = (9600);
                port.DtrEnable = true;
                port.ReadTimeout = 5000;
                port.WriteTimeout = 500;
                
                port.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return false;
        }



        public string Run()
        {
            //port.Open();
            return port.ReadExisting();
        }
    }
}
