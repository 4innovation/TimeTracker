using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TimeTracker
{


    public partial class Log_In : Form
    {
        bool _PWCorrect = false;

        public Log_In()
        {
            InitializeComponent();

            // ToDo:
            // hier noch die Datenbankverbindung einbringen

            textBox2.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;


            textBox1.Text = "Admin";
            textBox2.Text = "sicher";

            Thread.Sleep(100);
            buttonOK.PerformClick();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "sicher")
            {
                //TimeTrackerGUI main = new TimeTrackerGUI();

                _PWCorrect = true;
                HandleVariable();

                //main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Message", MessageBoxButtons.OKCancel);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool HandleVariable()
        {
            if (_PWCorrect)
            {
                this.Hide();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
