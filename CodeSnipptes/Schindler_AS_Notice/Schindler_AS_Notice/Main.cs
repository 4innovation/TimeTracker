﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.IO;
using DataGridViewRichTextBox;
using FTP;
using Schindler_AS_Notice_Customer;

namespace Schindler_AS_Notice
{
    public partial class Main : Form
    {
        private String connectionString = null;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
        private string _headertext = string.Empty;
        private bool triggered = false;


        FileSystemWatcher FSW;

        public Main()
        {
            InitializeComponent();
            //SetColumWidth();
            this.StartPosition = FormStartPosition.CenterScreen;
            //FSW_Initialisieren();
        }

        #region Database
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //this.Icon = new System.Drawing.Icon("user_admin.ico");
                connectionString =
                    Encryption.DecryptString(ConfigurationManager.AppSettings["connectionString"].ToString(),
                        "g%_i3hw%&73)_Tr80?1");
                sqlConnection = new SqlConnection(connectionString);
                selectQueryString =
                    "SELECT * FROM Notice where Status not like 'Erledigt' and Status not like 'Abgelehnt'";

                sqlConnection.Open();

                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    createComboBox(dataGridView1, column, "Status",
                        new string[] {"kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info"});

                    createDateTimePicker(dataGridView1, column, "Datum");

                    createDateTimePicker(dataGridView1, column, "Termin");

                    createRichtextBox(dataGridView1, column, "Bemerkung_Einzelfrage_Problem");

                    createRichtextBox(dataGridView1, column, "Korrekturmaßnahme_Vorschlag");

                    createRichtextBox(dataGridView1, column, "Rückfragen_an_Autor");

                    createRichtextBox(dataGridView1, column, "Antwort_von_Autor");
                }

                setPrioColor(dataGridView1.Rows);

                SetColumWidth(dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FSW_Initialisieren();
        }

        private void createRichtextBox(DataGridView datagridView, DataGridViewColumn column, string columnName)
        {
            try
            {
                if (column.HeaderText == columnName)
                {
                    column.MinimumWidth = 200;
                }

                if (column.DataPropertyName == columnName && !(column is DataGridViewRichTextBoxColumn))
                {
                    foreach (DataGridViewRow row in datagridView.Rows)
                    {
                        row.MinimumHeight = 60;
                        DataGridViewRichTextBoxColumn ComboBoxCell1 = new DataGridViewRichTextBoxColumn(datagridView);
                        datagridView[column.Index, row.Index] = ComboBoxCell1.CellTemplate;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void createComboBox(DataGridView datagridView, DataGridViewColumn column, string columnName, object[] cbxValues)
        {
            try
            {


                if (column.DataPropertyName == columnName && !(column is DataGridViewComboBoxColumn))
                {
                    column.MinimumWidth = 50;
                    foreach (DataGridViewRow row in datagridView.Rows)
                    {
                        DataGridViewComboBoxCell ComboBoxCell1 = new DataGridViewComboBoxCell();
                        ComboBoxCell1.Items.AddRange(cbxValues);
                        datagridView[column.Index, row.Index] = ComboBoxCell1;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void createDateTimePicker(DataGridView datagridView, DataGridViewColumn column, string columnName)
        {
            try
            {


                if (column.DataPropertyName == columnName && !(column is CalendarColumn))
                {
                    column.MinimumWidth = 40;
                    foreach (DataGridViewRow row in datagridView.Rows)
                    {
                        CalendarColumn col = new CalendarColumn();
                        datagridView[column.Index, row.Index] = col.CellTemplate;
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
            Application.Exit();
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Update();
            SetColumWidth(dataGridView1);
        }

        private void Update()
        {
            try
            {
                switch (this.tabControl1.SelectedTab.TabIndex)
                {
                    case 0:
                        {
                            sqlConnection.Close();

                            connectionString = Encryption.DecryptString(ConfigurationManager.AppSettings["connectionString"].ToString(), "g%_i3hw%&73)_Tr80?1");
                            sqlConnection = new SqlConnection(connectionString);
                            selectQueryString = "SELECT * FROM Notice where Status not like 'Erledigt' and Status not like 'Abgelehnt'";

                            sqlConnection.Open();

                            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                            dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            bindingSource = new BindingSource();
                            bindingSource.DataSource = dataTable;

                            dataGridView1.DataSource = bindingSource;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                                //if (column.Name == "Id")
                                //{
                                //    column.Width = 15;
                                //}

                                createComboBox(dataGridView1, column, "Status", new string[] { "kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info" });

                                createDateTimePicker(dataGridView1, column, "Datum");

                                createDateTimePicker(dataGridView1, column, "Termin");

                                createRichtextBox(dataGridView1, column, "Bemerkung_Einzelfrage_Problem");

                                createRichtextBox(dataGridView1, column, "Korrekturmaßnahme_Vorschlag");

                                createRichtextBox(dataGridView1, column, "Rückfragen_an_Autor");

                                createRichtextBox(dataGridView1, column, "Antwort_von_Autor");
                            }
                            SetColumWidth(dataGridView1);
                            setPrioColor(dataGridView1.Rows);
                        }
                        break;
                    case 1:
                        {
                            {
                                sqlConnection.Close();

                                connectionString = Encryption.DecryptString(
                                    ConfigurationManager.AppSettings["connectionString"].ToString(), "g%_i3hw%&73)_Tr80?1");
                                sqlConnection = new SqlConnection(connectionString);
                                selectQueryString =
                                    "SELECT * FROM Notice where Status like 'Erledigt' or Status like 'Abgelehnt'";

                                sqlConnection.Open();

                                sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                                dataTable = new DataTable();
                                sqlDataAdapter.Fill(dataTable);
                                bindingSource = new BindingSource();
                                bindingSource.DataSource = dataTable;

                                dataGridView2.DataSource = bindingSource;

                                foreach (DataGridViewColumn column in dataGridView2.Columns)
                                {
                                    //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                                    createComboBox(dataGridView2, column, "Status",
                                        new string[]
                                            {"kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info"});

                                    createDateTimePicker(dataGridView2, column, "Datum");

                                    createDateTimePicker(dataGridView2, column, "Termin");

                                    createRichtextBox(dataGridView2, column, "Bemerkung_Einzelfrage_Problem");

                                    createRichtextBox(dataGridView2, column, "Korrekturmaßnahme_Vorschlag");

                                    createRichtextBox(dataGridView2, column, "Rückfragen_an_Autor");

                                    createRichtextBox(dataGridView2, column, "Antwort_von_Autor");

                                    if (column.HeaderText != "Status")
                                    {
                                        dataGridView2.Columns[column.HeaderText].ReadOnly = true;
                                    }
                                }

                                SetColumWidth(dataGridView2);

                                //setPrioColor(dataGridView2.Rows);
                            }
                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_processSchindler_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ConfigurationManager.AppSettings["Prozess"].ToString());
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.tabControl1.SelectedTab.TabIndex)
                {
                    case 0:
                        {
                            connectionString = Encryption.DecryptString(ConfigurationManager.AppSettings["connectionString"].ToString(), "g%_i3hw%&73)_Tr80?1");
                            sqlConnection = new SqlConnection(connectionString);
                            selectQueryString = "SELECT * FROM Notice where Status not like 'Erledigt' and Status not like 'Abgelehnt'";

                            sqlConnection.Open();

                            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                            dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            bindingSource = new BindingSource();
                            bindingSource.DataSource = dataTable;

                            dataGridView1.DataSource = bindingSource;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                                createComboBox(dataGridView1, column, "Status", new string[] { "kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info" });

                                createDateTimePicker(dataGridView1, column, "Datum");

                                createDateTimePicker(dataGridView1, column, "Termin");

                                createRichtextBox(dataGridView1, column, "Bemerkung_Einzelfrage_Problem");

                                createRichtextBox(dataGridView1, column, "Korrekturmaßnahme_Vorschlag");

                                createRichtextBox(dataGridView1, column, "Rückfragen_an_Autor");

                                createRichtextBox(dataGridView1, column, "Antwort_von_Autor");
                            }

                            setPrioColor(dataGridView1.Rows);
                            SetColumWidth(dataGridView1);
                        }
                        break;
                    case 1:
                        {
                            connectionString = Encryption.DecryptString(ConfigurationManager.AppSettings["connectionString"].ToString(), "g%_i3hw%&73)_Tr80?1");
                            sqlConnection = new SqlConnection(connectionString);
                            selectQueryString = "SELECT * FROM Notice where Status like 'Erledigt' or Status like 'Abgelehnt'";

                            sqlConnection.Open();

                            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
                            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                            dataTable = new DataTable();
                            sqlDataAdapter.Fill(dataTable);
                            bindingSource = new BindingSource();
                            bindingSource.DataSource = dataTable;

                            dataGridView2.DataSource = bindingSource;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {

                                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                                createComboBox(dataGridView2, column, "Status", new string[] { "kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info" });

                                createDateTimePicker(dataGridView2, column, "Datum");

                                createDateTimePicker(dataGridView2, column, "Termin");

                                createRichtextBox(dataGridView2, column, "Bemerkung_Einzelfrage_Problem");

                                createRichtextBox(dataGridView2, column, "Korrekturmaßnahme_Vorschlag");

                                createRichtextBox(dataGridView2, column, "Rückfragen_an_Autor");

                                createRichtextBox(dataGridView2, column, "Antwort_von_Autor");

                                if (column.HeaderText != "Status")
                                {
                                    dataGridView2.Columns[column.HeaderText].ReadOnly = true;
                                }
                            }

                            SetColumWidth(dataGridView2);

                            //setPrioColor(dataGridView2.Rows);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setPrioColor(DataGridViewRowCollection dataGridViewRowCollection)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewRowCollection)
                {
                    if (row.Cells["Datum"] != null && row.Cells["Termin"] != null)
                    {
                        if (row.Cells["Datum"].Value != null && row.Cells["Termin"].Value != null)
                        {
                            DateTime date = DateTime.Parse(row.Cells["Datum"].Value.ToString());
                            DateTime termin = new DateTime();
                            try
                            {
                                termin = DateTime.Parse(row.Cells["Termin"].Value.ToString());

                                if (DateTime.Now > termin)
                                {
                                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //    foreach (DataGridViewColumn column in dataGridView1.Columns)
            //    {
            //        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //        createComboBox(dataGridView1, column, "Status", new string[] { "kein", "In Klärung", "In Bearbeitung", "Erledigt" });

            //        createDateTimePicker(dataGridView1, column, "Datum");

            //        createDateTimePicker(dataGridView1, column, "Termin");

            //        createRichtextBox(dataGridView1, column, "Bemerkung_Einzelfrage_Problem");

            //        createRichtextBox(dataGridView1, column, "Korrekturmaßnahme_Vorschlag");

            //        createRichtextBox(dataGridView1, column, "Rückfragen_an_Autor");

            //        createRichtextBox(dataGridView1, column, "Antwort_von_Autor");
            //    }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Verknüpfte_Dokumente")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                {
                    if (File.Exists(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) || Directory.Exists(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        Question question = new Question(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);

                        question.ShowDialog();
                    }
                }
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            if (e.ColumnIndex != 9)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dataGridView1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F3)
            {
                if (_headertext == "Verknüpfte_Dokumente")
                {
                    // Show the dialog and get result.
                    DialogResult result = openFileDialog1.ShowDialog();
                    if (result == DialogResult.OK) // Test result.
                    {
                        dataGridView1.CurrentCell.Value = openFileDialog1.FileName;
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText != "Verknüpfte_Dokumente")
                {
                    this.Cursor = Cursors.Default;
                }
                _headertext = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_CellMouseMove_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Verknüpfte_Dokumente")
                {
                    this.Cursor = Cursors.Hand;
                }
                _headertext = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                createComboBox(dataGridView1, column, "Status", new string[] { "kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info" });

                createDateTimePicker(dataGridView1, column, "Datum");

                createDateTimePicker(dataGridView1, column, "Termin");

                createRichtextBox(dataGridView1, column, "Bemerkung_Einzelfrage_Problem");

                createRichtextBox(dataGridView1, column, "Korrekturmaßnahme_Vorschlag");

                createRichtextBox(dataGridView1, column, "Rückfragen_an_Autor");

                createRichtextBox(dataGridView1, column, "Antwort_von_Autor");
            }

            setPrioColor(dataGridView1.Rows);
            SetColumWidth(dataGridView1);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.CellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dataGridView2_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                createComboBox(dataGridView2, column, "Status", new string[] { "kein", "In Klärung", "In Bearbeitung", "Erledigt", "Abgelehnt", "Zur Info" });

                createDateTimePicker(dataGridView2, column, "Datum");

                createDateTimePicker(dataGridView2, column, "Termin");

                createRichtextBox(dataGridView2, column, "Bemerkung_Einzelfrage_Problem");

                createRichtextBox(dataGridView2, column, "Korrekturmaßnahme_Vorschlag");

                createRichtextBox(dataGridView2, column, "Rückfragen_an_Autor");

                createRichtextBox(dataGridView2, column, "Antwort_von_Autor");
            }

            SetColumWidth(dataGridView2);

            //setPrioColor(dataGridView2.Rows);
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.CellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dataGridView2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F3)
            {
                if (_headertext == "Verknüpfte_Dokumente")
                {
                    // Show the dialog and get result.
                    DialogResult result = openFileDialog1.ShowDialog();
                    if (result == DialogResult.OK) // Test result.
                    {
                        dataGridView2.CurrentCell.Value = openFileDialog1.FileName;
                    }
                }
            }
        }


        private void SetColumWidth(DataGridView CurrentDataGrid)
        {
            CurrentDataGrid.Columns[0].Width = 20; // ID
            CurrentDataGrid.Columns[0].MinimumWidth = 15;

            CurrentDataGrid.Columns[1].Width = 65; // Datum
            CurrentDataGrid.Columns[1].MinimumWidth = 50; // Datum

            CurrentDataGrid.Columns[5].Width = 50; // Verantwortlicher
            CurrentDataGrid.Columns[5].MinimumWidth = 45; // Verantwortlicher

            CurrentDataGrid.Columns[9].Width = 50; // Autor
            CurrentDataGrid.Columns[9].MinimumWidth = 45; // Autor

            //ataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        private void buttonXUpdate_Click(object sender, EventArgs e)
        {
            Update();
            // triggered = false; 
        }

        private void notifyIconChange_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.Show();
            this.Refresh();
            this.Visible = true;
        }

        private void buttonXSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        object value = row[column.HeaderText];
                        if (value == DBNull.Value)
                        {
                            try
                            {
                                if (column.HeaderText == "Status")
                                {
                                    row[column.HeaderText] = "kein";
                                }
                                else
                                {
                                    row[column.HeaderText] = "";
                                }
                            }
                            catch (Exception exception)
                            {
                            }
                        }
                    }
                }


                sqlDataAdapter.Update(dataTable);

                btnUpdate_Click_1(sender, e);

                try
                {
                    File.Create(@"\\laiz.ws-schaefer.de\desig\WSTAB\DatenWSTAB\Wstab\Notification\note.txt").Close();
                }
                catch (Exception)
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Der Datensatz den Sie anpassen wollen, wurde bereits geändert, bitte führen Sie ein Update durch.", "Hinweis");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        #endregion

        #region FSW

        private void FSW_Initialisieren()
        {
            try
            {
                // Filesystemwatcher anlegen
                FSW = new FileSystemWatcher();

                // Pfad und Filter festlegen
                FSW.Path = @"\\laiz.ws-schaefer.de\desig\WSTAB\DatenWSTAB\Wstab\Notification";
                FSW.Filter = "*.txt";

                // Events definieren
                FSW.Changed += new FileSystemEventHandler(FSW_Changed);
                //FSW.Created += new FileSystemEventHandler(FSW_Created);
                //FSW.Deleted += new FileSystemEventHandler(FSW_Deleted);
                //FSW.Renamed += new RenamedEventHandler(FSW_Renamed);

                // Filesystemwatcher aktivieren
                FSW.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void FSW_Changed(object sender, FileSystemEventArgs e)
        {
            // nur 1x Ausführen
            if (triggered)
            {
                triggered = false;
                return; 
            }


            Notification note = new Notification();
            note.ShowDialog();
           // MessageBox.Show("Test");
            
            // Nach Ausgabe der Notificiation gleich Updaten
            //Update();
            //this.Icon = new System.Drawing.Icon("Message.ico");
            notifyIconChange.Icon = new System.Drawing.Icon("Message.ico");
            notifyIconChange.BalloonTipText = "Neue Nachricht hinzugefügt...";
            notifyIconChange.ShowBalloonTip(1000);
            triggered = true; 
        }

        void FSW_Created(object sender, FileSystemEventArgs e)
        {
            //Notification note = new Notification();
            //note.ShowDialog();
        }

        void FSW_Deleted(object sender, FileSystemEventArgs e)
        {
            //Notification note = new Notification();
            //note.ShowDialog();
        }

        void FSW_Renamed(object sender, RenamedEventArgs e)
        {
            //Notification note = new Notification();
            //note.ShowDialog();
        }






        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sind Sie sicher? Sie erhalten keine weiteren Benarichtigungen mehr! \n Programm dennoch beenden?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    } // Ende
}
