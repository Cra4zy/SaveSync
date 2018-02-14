using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System;

namespace SaveSync
{
    public partial class Form1 : Form
    {
        public string sourceDir = @Environment.ExpandEnvironmentVariables("%USERPROFILE%");
        public string backupDir = @"c:\archives\2008";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = sourceDir;
        }
    }
}
