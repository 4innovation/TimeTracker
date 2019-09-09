using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schindler_AS_Notice
{
    public partial class Question : Form
    {
        private string _pfad;

        public Question(string pfad)
        {
            InitializeComponent();
            _pfad = pfad;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_pfad);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
