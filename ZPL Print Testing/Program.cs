using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using ZPL_Print_Testing.Models;

namespace ZPL_Print_Testing
{
    static class Program
    {

        public static IConfiguration Configuration;

        public static AppConfig AppConfig;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true);

            Configuration = configBuilder.Build();

            AppConfig = Configuration.GetSection("AppConfig").Get<AppConfig>();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
