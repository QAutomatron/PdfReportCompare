using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCompare
{
    class ReportFile
    {
        public string Filename { get; set; }
        public string Status { get; set; }


        public ReportFile(string filename, string status)
        {
            Filename = filename;
            Status = status;
        }
    }
}
