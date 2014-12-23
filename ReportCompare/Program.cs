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

        // Загружаем путь к программам из конфигурационного файла
        private static string pathToCompareEXE = PropertiesLoader.getComparePath();
        private static string pathToDiffEXE = ConfigurationManager.AppSettings[@"DiffPdfFile"];


        static void Main()
        {

            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
        }

       public static void start()
        {
            string[] sourceFolder = getFilesFromPath("c:/1/report/12_12_14/");
            string[] targetFolder = getFilesFromPath("c:/1/report/15_12_14/");
            compare(sourceFolder, targetFolder);
        }


        static void compare(string[] path1, string[] path2)
        {
            int count = 0;
            foreach (string source in path1)
            {
                foreach (string target in path2)
                {
                    if (Path.GetFileName(source) == Path.GetFileName(target))
                    {
                        count++;
                        int exitCode = runCmd(source, target);
                        Console.WriteLine("Programm Exit Code: " + exitCode);
                    }
                }
            }
        }


        static int runCmd(string arg1, string arg2)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = pathToCompareEXE; // Путь к файлу
            startInfo.Arguments = arg1 + " " +  arg2; //агрумент 
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        static string[] getFilesFromPath(String path)
        {
            return Directory.GetFiles(@path, "*.pdf");
        }

    }
}
