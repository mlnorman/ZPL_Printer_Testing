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
                var sql = "SELECT * FROM AppConfig a" +
                          "left join LabelFormats l on a.id = l.appConfigId;";

                var appConfig = conn.Query<AppConfig, LabelFormat, AppConfig>(sql, (appConfig, labelFormat) =>
                {
                    if (labelFormat != null)
                    {
                        appConfig.LabelFormats.Add(labelFormat);
                    }
                });

                return appConfig.FirstOrDefault();
            }

        }

        public void SaveOrUpdateAppConfig(AppConfig appConfig)
        {
            throw new NotImplementedException();
        }
    }
}
