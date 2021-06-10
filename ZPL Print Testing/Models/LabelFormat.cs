using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPL_Print_Testing.Models
{
    public class LabelFormat
    {

        [Browsable(false)]
        public int Id { get; set; }
        
        [Browsable(false)]
        public int AppConfigId { get; set; }

        public string Name { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string PrintDensity { get; set; }

        public bool IsDefault { get; set; }

    }
}
