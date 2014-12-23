using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReportCompare
{
    class PropertiesLoader
    {
        public static string getComparePath()
        {
            return ConfigurationManager.AppSettings[@"ComparePdfFile"];
        }

        public static string getDiffPath()
        {
            return ConfigurationManager.AppSettings[@""];
        }
    }
}
