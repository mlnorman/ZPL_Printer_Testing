using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPL_Print_Testing.Models
{
    public class Printer
    {

        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public int AppConfigId { get; set; }

        public string Name { get; set; }

        public string IpAddress { get; set; }

        public int Port { get; set; }

        public bool IsDefault { get; set; }
    }
}
