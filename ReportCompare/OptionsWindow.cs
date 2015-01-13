using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportCompare
{
    public partial class OptionsWindow : Form
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathToCompareTextBox.Text = Properties.Settings.Default.ComparePdfFile;
            pathToDiffTextBox.Text = Properties.Settings.Default.DiffPdfFile;
        }

        private void setPathToDiff_Click(object sender, EventArgs e)
        {
            string s = Program.selectFile();
            if (s != "" && s != null)
            {
            pathToDiffTextBox.Text = s;
            Properties.Settings.Default.DiffPdfFile = s;
            Properties.Settings.Default.Save();
            }
        }

        private void setPathToCompare_Click(object sender, EventArgs e)
        {
            string s = Program.selectFile();
            if (s != "" && s != null)
            {
                pathToCompareTextBox.Text = s;
                Properties.Settings.Default.ComparePdfFile = s;
                Properties.Settings.Default.Save();
            }
        }
    }
}
