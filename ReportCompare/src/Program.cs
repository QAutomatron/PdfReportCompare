using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;


namespace ReportCompare
{
    class Program
    {
        private static MainWindow mWindow;

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();

            Properties.Settings.Default.DiffPdfFile = AppDomain.CurrentDomain.BaseDirectory + "apps\\diffpdf.exe";
            Properties.Settings.Default.ComparePdfFile = AppDomain.CurrentDomain.BaseDirectory + "apps\\comparepdf.exe";

            Application.Run(mWindow = new MainWindow());
        }

        public static void start()
        {
            string[] sourceFolder = getFilesFromPath(Properties.Settings.Default.SourcePath);
            string[] targetFolder = getFilesFromPath(Properties.Settings.Default.TargetPath);
            if (sourceFolder != null && targetFolder != null) { compare(sourceFolder, targetFolder); }
            else if (sourceFolder == null)
            {
                MessageBox.Show("Папка Source пуста или указан неверный путь",
                    "Path error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else if (targetFolder == null)
            {
                MessageBox.Show("Папка Target пуста или указан неверный путь",
                    "Path error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            };
        }


        static void compare(string[] path1, string[] path2)
        {
            int diffCount = 0;
            int errorCount = 0;
            string comparePdfExec = Properties.Settings.Default.ComparePdfFile;
            string diffPdfExec = Properties.Settings.Default.DiffPdfFile;
            int sourceFilesCount = path1.Length;
            int targetFilesCount = path2.Length;
            mWindow.SourceFilesCount = sourceFilesCount.ToString();
            mWindow.TargetFilesCount = targetFilesCount.ToString();
            log("Найдено файлов в source:" + sourceFilesCount);
            log("Найдено файлов в target:" + targetFilesCount);
            mWindow.resetProgressBar(sourceFilesCount);
            mWindow.clearReportList();
            foreach (string file in path1) { mWindow.addReportToList(Path.GetFileName(file), "Not Checked"); }
            foreach (string source in path1)
            {
                foreach (string target in path2)
                {
                    if (Path.GetFileName(source) == Path.GetFileName(target))
                    {
                        int exitCode = runCmd(comparePdfExec, source, target);
                        mWindow.updateFileStatus(Path.GetFileName(source), "OK");
                        if (exitCode >= 10)
                        {
                            log(string.Format("Найдены различия в файле: {0}", source));
                            mWindow.updateFileStatus(Path.GetFileName(source), "Diff");
                            diffCount++;
                            mWindow.DiffFilesCount = diffCount.ToString();
                            
                            if (mWindow.SilentMode == false)
                            {
                                DialogResult dialogResult = MessageBox.Show("Найдены различия в файле:\n" + source + "\nСравнить их визуально?",
                                 "Внимание",
                                MessageBoxButtons.YesNoCancel);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    runCmd(diffPdfExec, source, target);
                                }
                                else if (dialogResult == DialogResult.Cancel)
                                {
                                    log("Job Canceled");
                                    MessageBox.Show("Выполнение остановлено",
                                                    "Stop",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation,
                                                    MessageBoxDefaultButton.Button1);
                                    mWindow.resetProgressBar(0);
                                    return;
                                }
                            }
                        }
                        else if (exitCode == 1 || exitCode == 2)
                        {
                            log("Ошибка обработки файла " + source);
                            mWindow.updateFileStatus(Path.GetFileName(source), "Error");
                            errorCount++;
                            mWindow.ErrorFilesCount = errorCount.ToString();
                        }
                    }
                }
                mWindow.updateProgressBar();
            }
            log("Job Done");
        }

        // Запускает исполняемый файл с двумя агрументам, ждет завершения, возвращает ExitCode
        static int runCmd(string programm, string arg1, string arg2)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = programm; // Путь к файлу
            startInfo.Arguments = arg1 + " " + arg2; //агрумент 
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            log("Programm Exit Code: " + process.ExitCode);
            return process.ExitCode;
        }

        //Возвращает массив файлов указанного расширения по указанному path
        static string[] getFilesFromPath(String path)
        {
            try
            {
                return Directory.GetFiles(@path, "*.pdf");
            }
            catch (DirectoryNotFoundException)
            {
                return null;
            }
        }

        // Метод для выбора файла
        public static string selectFile()
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Executable|*.exe";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            string fileName = null;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                fileName = choofdlog.FileName;
                //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            return fileName;
        }

        //Метод для выбора пути
        public static string selectFolder()
        {
            string path = null;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "") path = fbd.SelectedPath;
            return path;
        }

        //Вывод в консоль с временем
        public static void log(string s)
        {
            string date = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
            Console.WriteLine(date + s);
        }

        public static void doVisualCompare(string source, string target)
        {
            string diffPdfExec = Properties.Settings.Default.DiffPdfFile;
            DialogResult dialogResult = MessageBox.Show("Найдены различия в файле:\n" + source + "\nСравнить их визуально?",
                                     "Внимание",
                                    MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                runCmd(diffPdfExec, source, target);
            }

        }

    }
}
