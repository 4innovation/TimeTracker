using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace AS_Template_Tool
{
    public class DatabaseManager
    {
        private string _dbFilePath;
        public SQLiteConnection _connection;
        public List<string> _optionList_DB = new List<string>();


        // Konstrukor
        public DatabaseManager(string dbFile)
        {
            _dbFilePath = dbFile;
        }


        // Zum öffnen der Verbindung
        private bool startConnection()
        {
            if (File.Exists(@_dbFilePath))
            {
                _connection = new SQLiteConnection(string.Format(@"Data Source={0}", _dbFilePath), true);

                _connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Hier werden die Optionen aus der Datenbank anhand des Dateinames zusammengesucht
        public string[,] GetOptions(string FilenameXML)
        {
            string[,] options = new string[20, 20]; // Rückgabewert
            List<string> result = new List<string>();
            if (startConnection())
            {
                // Hier werden alle verfügbaren Optionen überhaupt zurückgeholt
                _optionList_DB = getOptions_DB();
                int i = 0;


                SQLiteCommand command = new SQLiteCommand(_connection);
                string select = string.Empty;

                foreach (string current in _optionList_DB)
                {
                    List<string> optionen = new List<string>();
                    startConnection();
                    if (getValue(current, "Dateiname", FilenameXML, "TableauVorlagen") == "True") // hier wird geschaut welche Werte für das aktuelle Tableau aktiviert sind
                    {
                        options[i, 0] = current;

                        int j = 1;
                        // Jetzt ID von der Optionen Current holen
                        if (startConnection())
                        {
                            //SQLiteCommand command = new SQLiteCommand(_connection);
                            string ID = getValue("ID", "de", current, "Bezeichnung");

                            optionen = getInhaltOfControls("de", ID);
                            foreach (string current2 in optionen)
                            {
                                options[i, j] = current2;
                                j++;
                            }

                        }


                        i++;


                        //result.Add(current);
                    }
                }


                //foreach (string option in _optionList_DB)
                //{
                //    select = "select " + option + " from Tableauvorlagen where Dateiname is  '" + FilenameXML + "'";

                //    command.CommandText = select;
                //    SQLiteDataReader reader = command.ExecuteReader();

                //    while (reader.Read())
                //    {
                //        result.Add(reader[option].ToString());
                //    }
                //}
                ////string select = "select "

                return options;
            }
            else
            {
                return null;
            }
        }

        /*
         * Gibt alle Auswahlmöglichen von der DB zurück
         */
        public List<string> getOptions_DB()
        {
            List<string> options = new List<string>();
            string select = "select de  from Bezeichnung order by de";

            SQLiteCommand command = new SQLiteCommand(_connection);

            command.CommandText = select;

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                options.Add(reader["de"].ToString());
            }

            // Beenden des Readers und Freigabe aller Ressourcen.
            reader.Close();

            reader.Dispose();

            command.Dispose();

            return options;
        }

        /*
        * Gibt einen spezifischen Wert einer Datenbank zurück
         * ist sehr flexibel Verwendbar
         */
        public string getValue(string spalteSelect, string spalteWhere, string vLike, string table)
        {
            string value = "";
            string select = "select " + spalteSelect + " from " + table + " where " + spalteWhere + " like " + "'" + vLike + "'";



            try
            {
                if (startConnection())
                {

                    SQLiteCommand command = new SQLiteCommand(_connection);

                    command.CommandText = select;

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        value = reader[spalteSelect].ToString();
                    }

                    // Beenden des Readers und Freigabe aller Ressourcen.
                    reader.Close();

                    reader.Dispose();

                    command.Dispose();
                }
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);
            }

            _connection.Close();
            _connection.Dispose();

            return value;
        }


        //public List <string> GetOptionsfromOptions(string option)
        //{
        //    List<string> Options = new List<string>();

        //    if (startConnection())
        //    {
        //        SQLiteCommand command = new SQLiteCommand(_connection);
        //        string select = string.Empty;

        //        string ID = getValue("ID", "de", option, "Bezeichnung");

        //    }


        //    return Options;
        //}




        public List<string> getInhaltOfControls(string sprache, string id)
        {
            List<string> optionList;

            optionList = new List<string>();

            string select = "select " + sprache + "  from Tableaudefinition where Bezeichnung like " + id;

            startConnection();

            try
            {
                SQLiteCommand command = new SQLiteCommand(_connection);

                command.CommandText = select;

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    optionList.Add(reader[sprache].ToString());
                }

                // Beenden des Readers und Freigabe aller Ressourcen.
                reader.Close();

                reader.Dispose();

                command.Dispose();

            }
            catch (SqlException e)
            {
                // MessageBox.Show(e.Message);
            }

            _connection.Close();
            _connection.Dispose();

            return optionList;
        }






        public string[,] GetValuefromZeichnugsNrDB(List<string> Eingang)
        {
           // string[,] rueckgabe = new string[20, 50];

            List<string> DatabaseColums = GetColumsFromTable("TableauInformation");

            string[,] rueckgabe = new string[Eingang.Count, DatabaseColums.Count +1];

            int i = 0;
            foreach (string CurrentName in Eingang)
            {
                rueckgabe[i, 0] = CurrentName;
                //int j = 0;
               // foreach (string CurrentColum in DatabaseColums)
                {
                    startConnection();

                    string SelecName = CurrentName.Replace("_", "");

                    string select = "select * from TableauInformation where TableauName like '" + SelecName + "'";

                    try
                    {
                        SQLiteCommand command = new SQLiteCommand(_connection);

                        command.CommandText = select;

                        SQLiteDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for(int j = 0; j < DatabaseColums.Count; j++)
                            {
                                rueckgabe[i, j + 1] = (reader[j].ToString());
                            }
  
                        }

                        // Beenden des Readers und Freigabe aller Ressourcen.
                        reader.Close();

                        reader.Dispose();

                        command.Dispose();

                    }
                    catch (SqlException e)
                    {
                        // MessageBox.Show(e.Message);
                    }

                    _connection.Close();
                    _connection.Dispose();

                   // j++;
                }

                i++;
            }



            return rueckgabe;
        }



        private List<string> GetColumsFromTable(string TableName)
        {
            List<string> Colums = new List<string>();

            string select = "PRAGMA table_info(" + TableName + ")";

            startConnection();

            try
            {
                SQLiteCommand command = new SQLiteCommand(_connection);

                command.CommandText = select;

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Colums.Add(reader[1].ToString());
                }

                // Beenden des Readers und Freigabe aller Ressourcen.
                reader.Close();

                reader.Dispose();

                command.Dispose();

            }
            catch (SqlException e)
            {
                // MessageBox.Show(e.Message);
            }

            _connection.Close();
            _connection.Dispose();

            return Colums;


        }



    }
}
