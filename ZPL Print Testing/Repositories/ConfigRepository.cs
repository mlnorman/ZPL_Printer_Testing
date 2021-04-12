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
        //<summary>
        // Returns all app config data 
        //</summary>
        public AppConfig GetAppConfig()
        {
            using (var conn = new SqliteConnection("Data Source=" +System.Environment.CurrentDirectory + "/zpl.db"))
            {
                var sql = "SELECT * FROM AppConfig " +
                          "left join LabelFormats on AppConfig.id = LabelFormats.AppConfigId;";

                var appConfig = conn.Query<AppConfig, LabelFormat, AppConfig>(sql, (appConfig, labelFormat) =>
                {
                    if (labelFormat != null)
                    {
                        labelFormat.AppConfigId = appConfig.Id;
                        appConfig.LabelFormats.Add(labelFormat);
                    }

                    return appConfig;
                });

                return appConfig.FirstOrDefault();
            }

        }

        //<summary>
        // Save or update app config data.  
        //</summary>
        public void SaveOrUpdateAppConfig(AppConfig appConfig)
        {
            throw new NotImplementedException();
        }
    }
}
