﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPL_Print_Testing.Models
{
    public class LabelFormat
    {

        public string Name { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string PrintDensity { get; set; }

        public bool IsDefault { get; set; }
    }
}
