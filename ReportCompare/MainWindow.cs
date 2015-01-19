using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ReportCompare
{
    public partial class MainWindow : Form
    {
        TextWriter _writer = null;
        
        public MainWindow()
        {
            InitializeComponent();

        }

        public void resetProgressBar(int max)
        {
            progressBar.Maximum = max;
            progressBar.Step = 1;
            progressBar.Value = 0;
        }

        public void updateProgressBar()
        {
            progressBar.PerformStep();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          //  backgroundWorker.ReportProgress(10);
            
          Program.start();
        }

       // public static string textBox1 { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
  
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);

            Program.log("Ready to work");

            sourcePath.Text = Properties.Settings.Default.SourcePath;
            targetPath.Text = Properties.Settings.Default.TargetPath;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            var optionsForm = new OptionsWindow();
            optionsForm.ShowDialog();
        }

        private void setSourcePathButton_Click(object sender, EventArgs e)
        {
            string s = Program.selectFolder();
            if (s != "" && s != null)
            {
                sourcePath.Text = s;
                Properties.Settings.Default.SourcePath = s;
                Properties.Settings.Default.Save();
            }
        }

        private void setTargetPathButton_Click(object sender, EventArgs e)
        {
            string s = Program.selectFolder();
            if (s != "" && s != null)
            {
                targetPath.Text = s;
                Properties.Settings.Default.TargetPath = s;
                Properties.Settings.Default.Save();
            }
        }
    }
}
