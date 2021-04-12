using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using ZPL_Print_Testing.Models;
using ZPL_Print_Testing.Repositories;

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
                CreateDb();
            }
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        //<summary>
        // Method to create the initial database file.
        // Should only be called on the initial run of the application.
        //</summary>
        private static void CreateDb()
        {

            try
            {
                SQLiteConnection.CreateFile(Environment.CurrentDirectory + "/zpl.db");

                // create the sqlite db file and create the table.  Nothing fancy,
                // since its just holding a small amount of user config data.

                using (var conn = new SqliteConnection("Data Source=" + System.Environment.CurrentDirectory + "/zpl.db"))
                {

                    conn.Open();

                    var sql = "CREATE TABLE AppConfig (" +
                              "'Id' INTEGER NOT NULL," +
                              "'IpAddress' TEXT," +
                              "'Port' INTEGER," +
                              "'SaveLabels' INTEGER," +
                              "'SaveLabelPath' TEXT," +
                              "PRIMARY KEY('Id' AUTOINCREMENT)" +
                              ");" +
                              "" +
                              "CREATE TABLE LabelFormats (" +
                              "'Id' INTEGER NOT NULL," +
                              "'AppConfigId' INTEGER," +
                              "'Name' TEXT," +
                              "'Height' INTEGER," +
                              "'Width' INTEGER," +
                              "'PrintDensity' TEXT," +
                              "'IsDefault' INTEGER," +
                              "PRIMARY KEY('id' AUTOINCREMENT)" +
                              ")";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                //todo:mln -- Handle this, probably logging.

                // delete the db file that was created.
                if (!File.Exists(Environment.CurrentDirectory + "/zpl.db"))
                {
                    File.Delete(Environment.CurrentDirectory + "/zpl.db");
                }
            }
           
        }
    }
}
