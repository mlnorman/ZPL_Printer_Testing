using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
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

            // check db exists
            // if not, create it
            if (!File.Exists(Environment.CurrentDirectory + "/zpl.db"))
            {
                
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
