namespace Schindler_AS_Notice
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_processSchindler = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonXUpdate = new DevComponents.DotNetBar.ButtonX();
            this.notifyIconChange = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonXSave = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonClose = new DevComponents.DotNetBar.ButtonX();
            this.buttonMinimize = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(432, 446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btn_processSchindler
            // 
            this.btn_processSchindler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_processSchindler.Location = new System.Drawing.Point(13, 453);
            this.btn_processSchindler.Name = "btn_processSchindler";
            this.btn_processSchindler.Size = new System.Drawing.Size(165, 36);
            this.btn_processSchindler.TabIndex = 28;
            this.btn_processSchindler.Text = "Ablauf/ Prozess Schindler AS";
            this.btn_processSchindler.UseVisualStyleBackColor = true;
            this.btn_processSchindler.Click += new System.EventHandler(this.btn_processSchindler_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 417);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1111, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Offene Punkte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1105, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave_1);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove_1);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dataGridView1_PreviewKeyDown_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1111, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Erledigte Punkte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1105, 384);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView2_CellPainting);
            this.dataGridView2.Sorted += new System.EventHandler(this.dataGridView2_Sorted);
            this.dataGridView2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dataGridView2_PreviewKeyDown);
            // 
            // buttonXUpdate
            // 
            this.buttonXUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonXUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonXUpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXUpdate.Location = new System.Drawing.Point(831, 453);
            this.buttonXUpdate.Name = "buttonXUpdate";
            this.buttonXUpdate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.buttonXUpdate.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonXUpdate.Size = new System.Drawing.Size(96, 36);
            this.buttonXUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.buttonXUpdate.Symbol = "";
            this.buttonXUpdate.SymbolColor = System.Drawing.Color.Black;
            this.buttonXUpdate.TabIndex = 30;
            this.buttonXUpdate.Text = "Akutalisieren";
            this.buttonXUpdate.Click += new System.EventHandler(this.buttonXUpdate_Click);
            // 
            // notifyIconChange
            // 
            this.notifyIconChange.Visible = true;
            this.notifyIconChange.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconChange_MouseDoubleClick);
            // 
            // buttonXSave
            // 
            this.buttonXSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXSave.BackColor = System.Drawing.Color.DarkGray;
            this.buttonXSave.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonXSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXSave.Location = new System.Drawing.Point(933, 453);
            this.buttonXSave.Name = "buttonXSave";
            this.buttonXSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.buttonXSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonXSave.Size = new System.Drawing.Size(96, 36);
            this.buttonXSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.buttonXSave.Symbol = "";
            this.buttonXSave.SymbolColor = System.Drawing.Color.Black;
            this.buttonXSave.TabIndex = 31;
            this.buttonXSave.Text = "Speichern";
            this.buttonXSave.Click += new System.EventHandler(this.buttonXSave_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(1035, 453);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.buttonX1.Size = new System.Drawing.Size(96, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Black;
            this.buttonX1.TabIndex = 32;
            this.buttonX1.Text = "Löschen";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonClose.Location = new System.Drawing.Point(1107, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonClose.Size = new System.Drawing.Size(24, 23);
            this.buttonClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonClose.Symbol = "";
            this.buttonClose.SymbolColor = System.Drawing.Color.Black;
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonMinimize.Location = new System.Drawing.Point(1077, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonMinimize.Size = new System.Drawing.Size(24, 23);
            this.buttonMinimize.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.buttonMinimize.Symbol = "";
            this.buttonMinimize.SymbolColor = System.Drawing.Color.Black;
            this.buttonMinimize.TabIndex = 33;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 501);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonXSave);
            this.Controls.Add(this.buttonXUpdate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_processSchindler);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(690, 465);
            this.Name = "Main";
            this.Text = "Projekt Schindler / AS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_processSchindler;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.ButtonX buttonXUpdate;
        private System.Windows.Forms.NotifyIcon notifyIconChange;
        private DevComponents.DotNetBar.ButtonX buttonXSave;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonClose;
        private DevComponents.DotNetBar.ButtonX buttonMinimize;
    }
}

