using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPL_Print_Testing.ViewModels
{
    public class MainViewModel
    {
        public string IpAddress { get; set; }

        public int Port { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string PrintDensity { get; set; }

        public string Path { get; set; }

        public bool SaveLabels { get; set; }

        public bool UseBitonal { get; set; }

        public MainViewModel(string ipAddress, int port, int height, int width, string printDensity, bool useBitonal, string path, bool saveLabels)
        {
            IpAddress = ipAddress;
            Port = port;
            Height = height;
            Width = width;
            PrintDensity = printDensity;
            Path = path;
            SaveLabels = saveLabels;
            UseBitonal = useBitonal;
        }
    }
}
