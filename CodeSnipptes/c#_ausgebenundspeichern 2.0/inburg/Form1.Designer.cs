namespace InBURG
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartWerte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.buttonSchliessen = new System.Windows.Forms.Button();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVerbinden = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.listBoxReceive = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxtimetoDisplay = new System.Windows.Forms.TextBox();
            this.textBoxMaxWert = new System.Windows.Forms.TextBox();
            this.buttonUpdateChart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMinWert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEmpfangeneDaten = new System.Windows.Forms.Label();
            this.pictureBoxOnline = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxAufnahme = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGespeicherte = new System.Windows.Forms.Label();
            this.radioButtonEchtzeitAn = new System.Windows.Forms.RadioButton();
            this.radioButtonRealtimeoff = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonRTOn = new System.Windows.Forms.RadioButton();
            this.radioButtonRTOff = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_Senden = new System.Windows.Forms.Button();
            this.radioButtonMessungAn = new System.Windows.Forms.RadioButton();
            this.radioButtonMessungAus = new System.Windows.Forms.RadioButton();
            this.groupBoxSenden = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chartWerteStoff = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartWerte)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAufnahme)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxSenden.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWerteStoff)).BeginInit();
            this.SuspendLayout();
            // 
            // chartWerte
            // 
            chartArea1.AxisX2.Maximum = 200D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = -6D;
            chartArea1.Name = "ChartArea1";
            this.chartWerte.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWerte.Legends.Add(legend1);
            this.chartWerte.Location = new System.Drawing.Point(281, 90);
            this.chartWerte.Name = "chartWerte";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWerte.Series.Add(series1);
            this.chartWerte.Size = new System.Drawing.Size(899, 226);
            this.chartWerte.TabIndex = 45;
            this.chartWerte.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSuchen);
            this.groupBox2.Controls.Add(this.buttonSchliessen);
            this.groupBox2.Controls.Add(this.comPort);
            this.groupBox2.Controls.Add(this.baudRate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonVerbinden);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verbinden";
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(13, 132);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(89, 33);
            this.buttonSuchen.TabIndex = 8;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // buttonSchliessen
            // 
            this.buttonSchliessen.Enabled = false;
            this.buttonSchliessen.Location = new System.Drawing.Point(120, 93);
            this.buttonSchliessen.Name = "buttonSchliessen";
            this.buttonSchliessen.Size = new System.Drawing.Size(89, 33);
            this.buttonSchliessen.TabIndex = 7;
            this.buttonSchliessen.Text = "Beenden";
            this.buttonSchliessen.UseVisualStyleBackColor = true;
            this.buttonSchliessen.Click += new System.EventHandler(this.buttonSchliessen_Click);
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(88, 23);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(121, 24);
            this.comPort.TabIndex = 6;
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(88, 56);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(121, 24);
            this.baudRate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM:";
            // 
            // buttonVerbinden
            // 
            this.buttonVerbinden.Location = new System.Drawing.Point(13, 93);
            this.buttonVerbinden.Name = "buttonVerbinden";
            this.buttonVerbinden.Size = new System.Drawing.Size(89, 33);
            this.buttonVerbinden.TabIndex = 1;
            this.buttonVerbinden.Text = "Verbinden";
            this.buttonVerbinden.UseVisualStyleBackColor = true;
            this.buttonVerbinden.Click += new System.EventHandler(this.buttonVerbinden_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.receiveText);
            this.groupBox4.Controls.Add(this.listBoxReceive);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(31, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 429);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEBUG";
            // 
            // receiveText
            // 
            this.receiveText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveText.Location = new System.Drawing.Point(12, 32);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveText.Size = new System.Drawing.Size(195, 44);
            this.receiveText.TabIndex = 0;
            // 
            // listBoxReceive
            // 
            this.listBoxReceive.FormattingEnabled = true;
            this.listBoxReceive.ItemHeight = 16;
            this.listBoxReceive.Location = new System.Drawing.Point(0, 100);
            this.listBoxReceive.Name = "listBoxReceive";
            this.listBoxReceive.ScrollAlwaysVisible = true;
            this.listBoxReceive.Size = new System.Drawing.Size(207, 292);
            this.listBoxReceive.TabIndex = 34;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(326, 34);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 42);
            this.buttonSpeichern.TabIndex = 46;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Anzal Messwerte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Max Wert:";
            // 
            // textBoxtimetoDisplay
            // 
            this.textBoxtimetoDisplay.Location = new System.Drawing.Point(108, 20);
            this.textBoxtimetoDisplay.Name = "textBoxtimetoDisplay";
            this.textBoxtimetoDisplay.Size = new System.Drawing.Size(100, 20);
            this.textBoxtimetoDisplay.TabIndex = 49;
            this.textBoxtimetoDisplay.Text = "20000";
            // 
            // textBoxMaxWert
            // 
            this.textBoxMaxWert.Location = new System.Drawing.Point(194, 45);
            this.textBoxMaxWert.Name = "textBoxMaxWert";
            this.textBoxMaxWert.Size = new System.Drawing.Size(37, 20);
            this.textBoxMaxWert.TabIndex = 50;
            this.textBoxMaxWert.Text = "1024";
            // 
            // buttonUpdateChart
            // 
            this.buttonUpdateChart.Location = new System.Drawing.Point(62, 86);
            this.buttonUpdateChart.Name = "buttonUpdateChart";
            this.buttonUpdateChart.Size = new System.Drawing.Size(83, 23);
            this.buttonUpdateChart.TabIndex = 51;
            this.buttonUpdateChart.Text = "Übernehmen";
            this.buttonUpdateChart.UseVisualStyleBackColor = true;
            this.buttonUpdateChart.Click += new System.EventHandler(this.buttonUpdateChart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMinWert);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonUpdateChart);
            this.groupBox1.Controls.Add(this.textBoxMaxWert);
            this.groupBox1.Controls.Add(this.textBoxtimetoDisplay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(281, 534);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 123);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagramm";
            // 
            // textBoxMinWert
            // 
            this.textBoxMinWert.Location = new System.Drawing.Point(70, 45);
            this.textBoxMinWert.Name = "textBoxMinWert";
            this.textBoxMinWert.Size = new System.Drawing.Size(37, 20);
            this.textBoxMinWert.TabIndex = 53;
            this.textBoxMinWert.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "min Wert:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(407, 34);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 42);
            this.buttonReset.TabIndex = 53;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Gesamt Empfangene Werte:";
            // 
            // labelEmpfangeneDaten
            // 
            this.labelEmpfangeneDaten.AutoSize = true;
            this.labelEmpfangeneDaten.Location = new System.Drawing.Point(174, 20);
            this.labelEmpfangeneDaten.Name = "labelEmpfangeneDaten";
            this.labelEmpfangeneDaten.Size = new System.Drawing.Size(13, 13);
            this.labelEmpfangeneDaten.TabIndex = 55;
            this.labelEmpfangeneDaten.Text = "0";
            // 
            // pictureBoxOnline
            // 
            this.pictureBoxOnline.Image = global::InBURG.Properties.Resources._3814714_The_Online_green_button_with_highlight_isolated_Stock_Photo;
            this.pictureBoxOnline.Location = new System.Drawing.Point(596, 18);
            this.pictureBoxOnline.Name = "pictureBoxOnline";
            this.pictureBoxOnline.Size = new System.Drawing.Size(57, 63);
            this.pictureBoxOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOnline.TabIndex = 56;
            this.pictureBoxOnline.TabStop = false;
            this.pictureBoxOnline.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(488, 34);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(81, 42);
            this.buttonStart.TabIndex = 57;
            this.buttonStart.Text = "Aufzeichnung Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxAufnahme
            // 
            this.pictureBoxAufnahme.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAufnahme.Image")));
            this.pictureBoxAufnahme.Location = new System.Drawing.Point(659, 18);
            this.pictureBoxAufnahme.Name = "pictureBoxAufnahme";
            this.pictureBoxAufnahme.Size = new System.Drawing.Size(57, 63);
            this.pictureBoxAufnahme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAufnahme.TabIndex = 58;
            this.pictureBoxAufnahme.TabStop = false;
            this.pictureBoxAufnahme.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Gespeicherte Messungen:";
            // 
            // labelGespeicherte
            // 
            this.labelGespeicherte.AutoSize = true;
            this.labelGespeicherte.Location = new System.Drawing.Point(174, 54);
            this.labelGespeicherte.Name = "labelGespeicherte";
            this.labelGespeicherte.Size = new System.Drawing.Size(13, 13);
            this.labelGespeicherte.TabIndex = 60;
            this.labelGespeicherte.Text = "0";
            // 
            // radioButtonEchtzeitAn
            // 
            this.radioButtonEchtzeitAn.AutoSize = true;
            this.radioButtonEchtzeitAn.Location = new System.Drawing.Point(33, 29);
            this.radioButtonEchtzeitAn.Name = "radioButtonEchtzeitAn";
            this.radioButtonEchtzeitAn.Size = new System.Drawing.Size(38, 17);
            this.radioButtonEchtzeitAn.TabIndex = 61;
            this.radioButtonEchtzeitAn.Text = "An";
            this.radioButtonEchtzeitAn.UseVisualStyleBackColor = true;
            this.radioButtonEchtzeitAn.CheckedChanged += new System.EventHandler(this.radioButtonEchtzeitAn_CheckedChanged);
            // 
            // radioButtonRealtimeoff
            // 
            this.radioButtonRealtimeoff.AutoSize = true;
            this.radioButtonRealtimeoff.Checked = true;
            this.radioButtonRealtimeoff.Location = new System.Drawing.Point(33, 52);
            this.radioButtonRealtimeoff.Name = "radioButtonRealtimeoff";
            this.radioButtonRealtimeoff.Size = new System.Drawing.Size(43, 17);
            this.radioButtonRealtimeoff.TabIndex = 62;
            this.radioButtonRealtimeoff.TabStop = true;
            this.radioButtonRealtimeoff.Text = "Aus";
            this.radioButtonRealtimeoff.UseVisualStyleBackColor = true;
            this.radioButtonRealtimeoff.CheckedChanged += new System.EventHandler(this.radioButtonRealtimeoff_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonRealtimeoff);
            this.groupBox3.Controls.Add(this.radioButtonEchtzeitAn);
            this.groupBox3.Location = new System.Drawing.Point(736, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 123);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Echtzeit";
            // 
            // radioButtonRTOn
            // 
            this.radioButtonRTOn.AutoSize = true;
            this.radioButtonRTOn.Checked = true;
            this.radioButtonRTOn.Location = new System.Drawing.Point(23, 29);
            this.radioButtonRTOn.Name = "radioButtonRTOn";
            this.radioButtonRTOn.Size = new System.Drawing.Size(38, 17);
            this.radioButtonRTOn.TabIndex = 64;
            this.radioButtonRTOn.TabStop = true;
            this.radioButtonRTOn.Text = "An";
            this.radioButtonRTOn.UseVisualStyleBackColor = true;
            this.radioButtonRTOn.CheckedChanged += new System.EventHandler(this.radioButtonRTOn_CheckedChanged);
            // 
            // radioButtonRTOff
            // 
            this.radioButtonRTOff.AutoSize = true;
            this.radioButtonRTOff.Location = new System.Drawing.Point(23, 59);
            this.radioButtonRTOff.Name = "radioButtonRTOff";
            this.radioButtonRTOff.Size = new System.Drawing.Size(43, 17);
            this.radioButtonRTOff.TabIndex = 65;
            this.radioButtonRTOff.Text = "Aus";
            this.radioButtonRTOff.UseVisualStyleBackColor = true;
            this.radioButtonRTOff.CheckedChanged += new System.EventHandler(this.radioButtonRTOff_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonRTOff);
            this.groupBox5.Controls.Add(this.radioButtonRTOn);
            this.groupBox5.Location = new System.Drawing.Point(1015, 534);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(124, 123);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Anzeige in Echtzeit";
            // 
            // button_Senden
            // 
            this.button_Senden.Location = new System.Drawing.Point(31, 87);
            this.button_Senden.Name = "button_Senden";
            this.button_Senden.Size = new System.Drawing.Size(75, 23);
            this.button_Senden.TabIndex = 68;
            this.button_Senden.Text = "Senden";
            this.button_Senden.UseVisualStyleBackColor = true;
            this.button_Senden.Click += new System.EventHandler(this.button_Senden_Click_1);
            // 
            // radioButtonMessungAn
            // 
            this.radioButtonMessungAn.AutoSize = true;
            this.radioButtonMessungAn.Location = new System.Drawing.Point(22, 29);
            this.radioButtonMessungAn.Name = "radioButtonMessungAn";
            this.radioButtonMessungAn.Size = new System.Drawing.Size(84, 17);
            this.radioButtonMessungAn.TabIndex = 69;
            this.radioButtonMessungAn.TabStop = true;
            this.radioButtonMessungAn.Text = "Messung An";
            this.radioButtonMessungAn.UseVisualStyleBackColor = true;
            this.radioButtonMessungAn.CheckedChanged += new System.EventHandler(this.radioButtonMessungAn_CheckedChanged);
            // 
            // radioButtonMessungAus
            // 
            this.radioButtonMessungAus.AutoSize = true;
            this.radioButtonMessungAus.Location = new System.Drawing.Point(22, 64);
            this.radioButtonMessungAus.Name = "radioButtonMessungAus";
            this.radioButtonMessungAus.Size = new System.Drawing.Size(89, 17);
            this.radioButtonMessungAus.TabIndex = 70;
            this.radioButtonMessungAus.TabStop = true;
            this.radioButtonMessungAus.Text = "Messung Aus";
            this.radioButtonMessungAus.UseVisualStyleBackColor = true;
            this.radioButtonMessungAus.CheckedChanged += new System.EventHandler(this.radioButtonMessungAus_CheckedChanged);
            // 
            // groupBoxSenden
            // 
            this.groupBoxSenden.Controls.Add(this.radioButtonMessungAus);
            this.groupBoxSenden.Controls.Add(this.radioButtonMessungAn);
            this.groupBoxSenden.Controls.Add(this.button_Senden);
            this.groupBoxSenden.Location = new System.Drawing.Point(853, 534);
            this.groupBoxSenden.Name = "groupBoxSenden";
            this.groupBoxSenden.Size = new System.Drawing.Size(156, 123);
            this.groupBoxSenden.TabIndex = 71;
            this.groupBoxSenden.TabStop = false;
            this.groupBoxSenden.Text = "String: 1,0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelGespeicherte);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.labelEmpfangeneDaten);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(524, 534);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 123);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            // 
            // chartWerteStoff
            // 
            chartArea2.AxisX2.Maximum = 200D;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.Maximum = 6D;
            chartArea2.AxisY.Minimum = -6D;
            chartArea2.Name = "ChartArea1";
            this.chartWerteStoff.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWerteStoff.Legends.Add(legend2);
            this.chartWerteStoff.Location = new System.Drawing.Point(281, 322);
            this.chartWerteStoff.Name = "chartWerteStoff";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartWerteStoff.Series.Add(series2);
            this.chartWerteStoff.Size = new System.Drawing.Size(899, 203);
            this.chartWerteStoff.TabIndex = 73;
            this.chartWerteStoff.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 683);
            this.Controls.Add(this.chartWerteStoff);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBoxSenden);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBoxAufnahme);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxOnline);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.chartWerte);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Arduino Com-Port Auslesen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartWerte)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAufnahme)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxSenden.ResumeLayout(false);
            this.groupBoxSenden.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWerteStoff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSchliessen;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVerbinden;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox receiveText;
        private System.Windows.Forms.ListBox listBoxReceive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonSpeichern;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartWerte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxtimetoDisplay;
        private System.Windows.Forms.TextBox textBoxMaxWert;
        private System.Windows.Forms.Button buttonUpdateChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEmpfangeneDaten;
        private System.Windows.Forms.PictureBox pictureBoxOnline;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxAufnahme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGespeicherte;
        private System.Windows.Forms.RadioButton radioButtonEchtzeitAn;
        private System.Windows.Forms.RadioButton radioButtonRealtimeoff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonRTOn;
        private System.Windows.Forms.RadioButton radioButtonRTOff;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_Senden;
        private System.Windows.Forms.RadioButton radioButtonMessungAn;
        private System.Windows.Forms.RadioButton radioButtonMessungAus;
        private System.Windows.Forms.GroupBox groupBoxSenden;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartWerteStoff;
        private System.Windows.Forms.TextBox textBoxMinWert;
        private System.Windows.Forms.Label label7;
    }
}

