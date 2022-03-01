using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPL_Print_Testing.Models
{
    public class FormProperties
    {
        public String IpAddress { get; set; }

        public int Port { get; set; }

        public double LabelHeight { get; set; }

        public double LabelWidth { get; set; }

        public string PrintDensity { get; set; }

        public bool IsSavingLabel { get; set; }

        public string LabelPath { get; set; }

        public bool UseBitonal { get; set; }

        public FormProperties()
        {
        }
    }
}
