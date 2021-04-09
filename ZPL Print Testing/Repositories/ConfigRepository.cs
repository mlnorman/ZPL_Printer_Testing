using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;
using ZPL_Print_Testing.Models;

namespace ZPL_Print_Testing.Repositories
{
    public class ConfigRepository : IConfigRepository
    {
        public AppConfig GetAppConfig()
        {
            using (var conn = new SqliteConnection("Date Source=" +System.Environment.CurrentDirectory + "/zpl.db"))
            {
                var sql = "SELECT * FROM AppConfig;";

                var appConfig = conn.Query(sql).FirstOrDefault();

                return appConfig;
            }

        }

        public void SaveOrUpdateAppConfig(AppConfig appConfig)
        {
            throw new NotImplementedException();
        }
    }
}
