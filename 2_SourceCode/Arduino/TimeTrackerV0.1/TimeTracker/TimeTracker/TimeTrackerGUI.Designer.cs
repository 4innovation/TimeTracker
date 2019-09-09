namespace TimeTracker
{
    partial class TimeTrackerGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(724, 242);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(121, 21);
            this.comPort.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(643, 495);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(574, 160);
            this.listBox1.TabIndex = 2;
            // 
            // TimeTrackerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 715);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.button1);
            this.Name = "TimeTrackerGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TimeTrackerGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.ListBox listBox1;
    }
}

