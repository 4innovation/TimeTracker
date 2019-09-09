using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;



namespace InBURG
{

    public partial class Form1 : Form
    {
        // Variablen

        bool saving = false;
        SerialPort port;
        int MaxValue = 1024;
        int MinValue = 0;
        int timeToDisplay = 20000;

        int GespeicherteMessungen = 0;
        bool saved = false;
        bool realtime = false;
        bool PlotRealtime = true;
        //String[] Werte = new String[1000];

        string datenSenden = "abcd";

        public Form1()
        {
            InitializeComponent();

            port = new SerialPort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comPort.Items.Add(s);
            }
            if (comPort.Items.Count > 0)
                comPort.SelectedIndex = comPort.Items.Count - 1;
            else
                comPort.SelectedIndex = 0;

            baudRate.Items.Add("2400");
            baudRate.Items.Add("4800");
            baudRate.Items.Add("9600");
            baudRate.Items.Add("14400");
            baudRate.Items.Add("19200");
            baudRate.Items.Add("250000");
            baudRate.Items.Add("28800");
            baudRate.Items.Add("38400");
            baudRate.Items.Add("57600");
            baudRate.Items.Add("115200");
            baudRate.Items.Add("2000000");
            
            baudRate.SelectedIndex = 2;

            PrepareChart();
            buttonReset.Enabled = false;
            buttonSpeichern.Enabled = false;
            buttonStart.Enabled = false;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                port.Close();
            }
            catch (NullReferenceException)
            {
            }


        }

        private async void buttonVerbinden_Click(object sender, EventArgs e)
        {
            System.ComponentModel.IContainer components =
                new System.ComponentModel.Container();
            port = new System.IO.Ports.SerialPort(components);
            port.PortName = comPort.SelectedItem.ToString();
            port.BaudRate = Int32.Parse(baudRate.SelectedItem.ToString());
            port.DtrEnable = true;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 500;
            pictureBoxOnline.Visible = true;
            buttonStart.Enabled = true;

            port.Open();

            buttonVerbinden.Text = "Verbunden";

            buttonVerbinden.Enabled = false;
            buttonSchliessen.Enabled = true;
            comPort.Enabled = false;
            //buttonVerbinden.Enabled = true;

            Thread.Sleep(3000);

            while (port.IsOpen)
            {
                try
                {
                    var msg = await Task.Run((Func<string>)port.ReadLine);
                    SetText(msg);
                }
                catch { }
            }
        }

        private void SetText(string text) // @ Nico geändert
        {

            this.receiveText.Text = "Text: ";
            this.receiveText.Text += text;
            //aktuelleDaten = text;
            ExtrahiereSensorDaten(text);
        }

        private void ExtrahiereSensorDaten(string input)      //@NIco geändert
        {
            double SensorA;
            double SensorB;
            double SensorC;
            double SensorD;
            double SensorE;
            if (saving == true)
             {
                try
                {
                    //input = "1000,123,0.12,0.13,0.14";
                    string[] ausgabe = input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    SensorA = Double.Parse(ausgabe[0]); // Zeit
                    SensorB = Double.Parse(ausgabe[1]); // Stoff
                    SensorC = Double.Parse(ausgabe[2]); // IMU X
                    SensorD = Double.Parse(ausgabe[3]); // IMU Y
                    SensorE = Double.Parse(ausgabe[4]); // IMU Z

                    UpdatePlot(SensorB, SensorC, SensorD);
                    if (realtime == false)
                    {
                        /*int k = 0;
                        while (k < 999)
                        {
                            Werte[k] = input;
                            k++;
                        } */
                        listBoxReceive.Items.Add(input);
                     }
                    else if (realtime == true)
                    {
                        listBoxReceive.Items.Add(System.DateTime.Now.ToString() + ";" + input);
                    }
                    
                    labelEmpfangeneDaten.Text = listBoxReceive.Items.Count.ToString();
                }
                catch
                {
                }
              }
        }


         public void UpdatePlot(double A, double B, double C)
        {
           // A = A / 100;
            B = B / 100;
            C = C +500;
            
            if (PlotRealtime == true)
            {
                if (chartWerte.Series[0].Points.Count > timeToDisplay)
                {
                  //  chartWerteStoff.Series[0].Points.Clear();
                    chartWerte.Series[0].Points.Clear();
                    chartWerte.Series[1].Points.Clear();
                }
            //    chartWerteStoff.Series[0].Points.AddY(A);
                chartWerte.Series[0].Points.AddY(A);
                chartWerte.Series[1].Points.AddY(C);

            }
        } 



        private void buttonSchliessen_Click(object sender, EventArgs e)
        {
            buttonVerbinden.Text = "Verbinden";
            buttonVerbinden.Enabled = true;
            pictureBoxOnline.Visible = false;
            try
            {
                port.Close();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string[] exportDaten = new string[listBoxReceive.Items.Count];
            int ende = listBoxReceive.Items.Count;
            for (int i = 0; i < ende; i++)
            {
                exportDaten[i] = (string)listBoxReceive.Items[i];
            }
            //Speichern unter Dialog instanziieren
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfd.FilterIndex = 0;
            sfd.FileName = "Messung" + System.DateTime.Now.Year + System.DateTime.Now.Month + System.DateTime.Now.Day +
                System.DateTime.Now.Hour + System.DateTime.Now.Minute;

            //Dialog anzeigen und auf Rückgabewert OK reagieren.
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Wenn Datei bereits vorhanden, soll diese gelöscht werden.
                if (File.Exists(sfd.FileName))
                    File.Delete(sfd.FileName);

                FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
                StreamWriter w = new StreamWriter(fs);
                w.WriteLine("Datum und Uhrzeit der Messung " + System.DateTime.Now);
                GespeicherteMessungen++;
                w.WriteLine("MessungNr " + GespeicherteMessungen.ToString());
                

                for (int i = 0; i < exportDaten.GetLength(0); i++)
                    w.WriteLine(exportDaten[i]);

                //Datei schließen
                //GespeicherteMessungen++;
                labelGespeicherte.Text = GespeicherteMessungen.ToString();
                w.Close();
                fs.Close();
                saved = true;
                pictureBoxAufnahme.Visible = false;
                buttonReset.PerformClick();
                buttonUpdateChart.Enabled = true;
            }
        }
        private void PrepareChart()
        {
            if (PlotRealtime == true)
            {
                chartWerte.Series.Clear();
                chartWerte.ChartAreas.Clear();

                // Wert 1
                Series series_I = new Series();
                series_I.ChartType = SeriesChartType.FastLine;
                series_I.Color = Color.Green;
                series_I.XAxisType = AxisType.Primary;
                series_I.LegendText = "Wert 1";
                chartWerte.Series.Add(series_I);
                // Wert 2
                Series series_II = new Series();
                series_II.ChartType = SeriesChartType.FastLine;
                series_II.Color = Color.Blue;
                series_II.XAxisType = AxisType.Primary;
                series_II.LegendText = "Wert 2";
                chartWerte.Series.Add(series_II);

                ChartArea chartArea = new ChartArea();

                chartWerte.ChartAreas.Add(chartArea);

                chartArea.BackColor = Color.Black;
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = timeToDisplay;
                chartArea.AxisY.Maximum = MaxValue;
                chartArea.AxisY.Minimum = MinValue;
                chartArea.AlignmentStyle = AreaAlignmentStyles.All;
                chartArea.RecalculateAxesScale();

                //// Stoff  /*
                //chartWerteStoff.Series.Clear();
                //chartWerteStoff.ChartAreas.Clear();

                //Series series_4 = new Series();
                //series_4.ChartType = SeriesChartType.FastLine;
                //series_4.Color = Color.Green;
                //series_4.XAxisType = AxisType.Primary;
                //series_4.LegendText = "Wert 1";
                //chartWerteStoff.Series.Add(series_4);

                //ChartArea chartArea2 = new ChartArea();

                //chartWerteStoff.ChartAreas.Add(chartArea2);

                //chartArea2.BackColor = Color.Black;
                //chartArea2.AxisX.Minimum = 0;
                //chartArea2.AxisX.Maximum = timeToDisplay;
                //chartArea2.AxisY.Maximum = 1023;
                //chartArea2.AxisY.Minimum = 0;
                //chartArea2.AlignmentStyle = AreaAlignmentStyles.All;
                //chartArea2.RecalculateAxesScale();  */
            }
        }

        private void buttonUpdateChart_Click(object sender, EventArgs e)
        {
            timeToDisplay = Convert.ToInt32(textBoxtimetoDisplay.Text);
            MaxValue = Convert.ToInt32(textBoxMaxWert.Text);
            MinValue = Convert.ToInt32(textBoxMinWert.Text);
            PrepareChart();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            PrepareChart();
            listBoxReceive.Items.Clear();
            pictureBoxAufnahme.Visible = false;
            saving = false;
            buttonUpdateChart.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonUpdateChart.Enabled = false;
            saving = true;
            saved = false;
            buttonSpeichern.Enabled = true;
            buttonReset.Enabled = true;
            pictureBoxAufnahme.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonSchliessen.PerformClick();
            if(saved == false)
            {
                DialogResult result = MessageBox.Show("Sind Sie sicher? \n Die Anwendung wird ohne Speichern geschlosen \n Vorhandene Messdaten werden gelöscht" +
                  "  \n Beim Drücken der Taste 'Ja' gehen vorhandene Daten verloren \n Beim Drücken von 'Nein'  können Sie die Daten speichern   ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;

                    DialogResult save = MessageBox.Show("Möchten Sie die momentane Messung speichern?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (save == DialogResult.Yes)
                    {
                        buttonSpeichern.PerformClick();
                    }
                }
            }
        }

        private void radioButtonEchtzeitAn_CheckedChanged(object sender, EventArgs e)
        {
            realtime = true;
        }

        private void radioButtonRealtimeoff_CheckedChanged(object sender, EventArgs e)
        {
            realtime = false;
        }

        private void radioButtonRTOff_CheckedChanged(object sender, EventArgs e)
        {
            PlotRealtime = false;
        }

        private void radioButtonRTOn_CheckedChanged(object sender, EventArgs e)
        {
            PlotRealtime = true;
        }

        private void radioButtonMessungAn_CheckedChanged(object sender, EventArgs e)
        {
            datenSenden = "1,1";
            groupBoxSenden.Text = "Senden: 1,1";
        }

        private void button_Senden_Click_1(object sender, EventArgs e)
        {
            port.Write(datenSenden);
        }

        private void radioButtonMessungAus_CheckedChanged(object sender, EventArgs e)
        {
            datenSenden = "1,0";
            groupBoxSenden.Text = "Senden: 1,0";
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            comPort.Items.Clear();
            baudRate.Items.Clear();
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    comPort.Items.Add(s);
                }
                if (comPort.Items.Count > 0)
                    comPort.SelectedIndex = comPort.Items.Count - 1;
                else
                    comPort.SelectedIndex = 0;

                baudRate.Items.Add("2400");
                baudRate.Items.Add("4800");
                baudRate.Items.Add("9600");
                baudRate.Items.Add("14400");
                baudRate.Items.Add("19200");
                baudRate.Items.Add("250000");
                baudRate.Items.Add("28800");
                baudRate.Items.Add("38400");
                baudRate.Items.Add("57600");
                baudRate.Items.Add("115200");
                baudRate.Items.Add("2000000");



                baudRate.SelectedIndex = 2;

                PrepareChart();
                buttonReset.Enabled = false;
                buttonSpeichern.Enabled = false;
                buttonStart.Enabled = false;

            }
        }


    }
}
