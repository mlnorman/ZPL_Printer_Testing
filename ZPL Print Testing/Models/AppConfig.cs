using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPL_Print_Testing.Models
{
    public class AppConfig
    {

        public AppConfig()
        {
            LabelFormats = new List<LabelFormat>();
            Printers = new List<Printer>();
        }

        public int Id { get; set; }

        public string IpAddress { get; set; }

        public int Port { get; set; }

        public List<LabelFormat> LabelFormats { get; set; }

        public bool SaveLabels { get; set; }

        public string SaveLabelPath { get; set; }

        public List<Printer> Printers { get; set; }
    }
}
