using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//
//using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace TimeTracker
{
    public partial class UserManagment : Form
    {
        string _userDB = string.Empty;


        public UserManagment(string UserDataBaseString)
        {
            _userDB = UserDataBaseString;
            InitializeComponent();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            GlobalFun _global = new GlobalFun();






            _global.SetArray2DataGridView(dataGridViewUser, LArray);

           //taTable dtbl = new DataTable();


            ////// nur als test später in Databasemanager klasse bauen
            // SQLiteConnection _connection = new SQLiteConnection();


            //_connection = new SQLiteConnection(@"C:\Users\Nicolas Wolf\Desktop\Nicos_Repos\TimeTracker\2_SourceCode\GUI\ac.db");

            //_connection.Open();

            //SQLiteCommand command = new SQLiteCommand(_connection);
            //command.CommandText = "select * from Users";

            //SQLiteDataReader reader = command.ExecuteReader();

            //dtbl = reader




        }
    }
}
