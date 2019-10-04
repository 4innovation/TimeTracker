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
using System.Configuration;

namespace TimeTracker
{


    public partial class Log_In : Form
    {
        bool _PWCorrect = false;

        string _DatabaseConnection = string.Empty;
        DatabaseManager UserDB = null;
        string _User = string.Empty;
        string _PW = string.Empty;


        public Log_In()
        {
            InitializeComponent();

            // ToDo:
            // hier noch die Datenbankverbindung einbringen

            textBox2.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;


            _DatabaseConnection = ConfigurationManager.AppSettings["DatabaseConnection"];
            UserDB = new DatabaseManager(_DatabaseConnection);


            //public string getValue(string spalteSelect, string spalteWhere, string vLike, string table)
            //{
            //    string value = "";
            //    string select = "select " + spalteSelect + " from " + table + " where " + spalteWhere + " like " + "'" + vLike + "'";


                textBox1.Text = "Benutzer";
                textBox2.Text = "Passwort";

            // Thread.Sleep(100);
           // buttonOK.PerformClick();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _User = textBox1.Text;
            _PW = textBox2.Text;

            string DBPW = UserDB.getValue("Password", "Name", _User, "Users");


            if (DBPW == _PW )
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

        public string[,] HandleVariable()
        {
            string[,] ReturnValue = new string[3, 2];


            ReturnValue[0, 0] = "User";
            ReturnValue[0, 1] = _User;
            ReturnValue[1, 0] = "Role";
            ReturnValue[1, 1] = UserDB.getValue("Role", "Name", _User, "Users");
            ReturnValue[2, 0] = "DataCorrect";
            


            if (_PWCorrect)
            {
                ReturnValue[2, 1] = "true";
                this.Hide();
                return ReturnValue;
            }
            else
            {
                return null;
            }
        }

    }
}
