﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPL_Print_Testing.Models;

namespace ZPL_Print_Testing.Services
{
    public interface ILabelService
    {
        void PrintLabel(string zpl, Printer printer);
    }
}
