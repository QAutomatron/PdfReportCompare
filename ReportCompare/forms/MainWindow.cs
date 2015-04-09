using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;

namespace ReportCompare
{
    public partial class MainWindow : Form
    {
        TextWriter _writer = null;
        BindingList<ReportFile> reportList = new BindingList<ReportFile>(); // Список файлов
        public bool SilentMode { get { return silentModeCheckBox.Checked; } }
        public string SourceFilesCount { get { return sourceCountValueLabel.Text; } set { sourceCountValueLabel.Text = value; } }
        public string TargetFilesCount { get { return targetCountValueLabel.Text; } set { targetCountValueLabel.Text = value; } }
        public string DiffFilesCount { get { return diffCountTextLabel.Text;} set {diffCountValueLabel.Text = value;} }
        public string ErrorFilesCount { get { return errCountTextLabel.Text; } set { errCountValueLabel.Text = value; } }

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
            // Program.start();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                Program.start();
            }).Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = reportList;
            dataGrid.DataSource = source;
            // dataGrid.AutoResizeColumns();
            // dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridViewColumn column0 = dataGrid.Columns[0];
            column0.Width = 380;
            DataGridViewColumn column1 = dataGrid.Columns[1];
            column1.Width = 100;

            // Instantiate the writer
            _writer = new TextBoxStreamWriter(logTextBox);
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

        // Обновляем статус по имени файла
        public void updateFileStatus(string filename, string newStatus)
        {
            int fileIndex = reportList.IndexOf(reportList.SingleOrDefault(p => p.Filename.Equals(filename)));
            ReportFile fileToChange = reportList[fileIndex];
            fileToChange.Status = newStatus;
            reportList[fileIndex] = fileToChange;
        }


        // Добавляем связку файл-статус в список 
        public void addReportToList(string filename, string status)
        {
            reportList.Add(new ReportFile(filename, status));
          //  dataGrid.FirstDisplayedScrollingRowIndex = dataGrid.Rows.Count-1; //Autoscroll
        }

        // Очищаем список файлов отчетов
        public void clearReportList()
        {
            reportList.Clear();
        }

        private void sourcePath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourcePath = sourcePath.Text;
        }

        private void targetPath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TargetPath = targetPath.Text;
        }

        /// <summary>
        /// По двойному клику на строку предлагает выполнить визуальное сравнение выделенного отчета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_CellCont‌entDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sourceFile = Properties.Settings.Default.SourcePath + "/" + reportList[e.RowIndex].Filename;
            string targetFile = Properties.Settings.Default.TargetPath + "/" + reportList[e.RowIndex].Filename;
            Program.doVisualCompare(sourceFile, targetFile);
        }

        /// <summary>
        /// Меняем цвет строки в зависимости от статуса файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && colIndex >= 0)
            {
                DataGridViewRow theRow = dataGrid.Rows[rowIndex];
                
                if (theRow.Cells[1].Value.ToString() == "Diff") { theRow.DefaultCellStyle.BackColor = Color.LightYellow; }
                if (theRow.Cells[1].Value.ToString() == "Error") { theRow.DefaultCellStyle.BackColor = Color.Red; }

            }
        }
    }
}
