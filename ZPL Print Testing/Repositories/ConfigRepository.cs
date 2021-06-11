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
                          "left join LabelFormats on AppConfig.id = LabelFormats.AppConfigId " +
                          "left join Printers on AppConfig.id = Printers.AppConfigId " +
                          "ORDER BY LabelFormats.Id, Printers.Id;";

                var appConfigs = new List<AppConfig>();

                var appConfig = conn.Query<AppConfig, LabelFormat, Printer, AppConfig>(sql, (appConfig, labelFormat, printer) =>
                {

                    var existingConfig = appConfigs.FirstOrDefault(x => x.Id == appConfig.Id);


                    if (existingConfig == null)
                    {
                        if (labelFormat != null)
                        {
                            appConfig.LabelFormats.Add(labelFormat);
                        }

                        if (printer != null)
                        {
                            appConfig.Printers.Add(printer);
                        }
                        appConfigs.Add(appConfig);
                    }
                    else
                    {
                        if (labelFormat != null)
                        {
                            existingConfig.LabelFormats.Add(labelFormat);
                        }

                        if (printer != null)
                        {
                            existingConfig.Printers.Add(printer);
                        }
                    }

                    //if (labelFormat != null)
                    //{
                    //    if (existingConfig == null)
                    //    {
                    //        labelFormat.AppConfigId = appConfig.Id;
                    //        appConfig.LabelFormats.Add(labelFormat);
                    //        appConfigs.Add(appConfig);
                    //    }
                    //    else
                    //    {
                    //        existingConfig.LabelFormats.Add(labelFormat);
                    //    }
                    //}

                    //if (printer != null)
                    //{
                    //    if (existingConfig == null)
                    //    {
                    //        printer.AppConfigId = appConfig.Id;
                    //        appConfig.Printers.Add(printer);
                    //        appConfigs.Add(appConfig);
                    //    }
                    //    else
                    //    {
                    //        existingConfig.Printers.Add(printer);
                    //    }
                    //}

                    return appConfig;
                });

                return appConfigs.FirstOrDefault();
            }

        }

        //<summary>
        // Save or update app config data.  
        //</summary>
        public void SaveAppConfig(AppConfig appConfig)
        {
            using (var conn = new SqliteConnection("Data Source=" + System.Environment.CurrentDirectory + "/zpl.db"))
            {
                var sql =
                    "UPDATE AppConfig SET IpAddress = @IpAddress, Port = @Port, SaveLabels = @SaveLabels, SaveLabelPath = @SaveLabelPath WHERE Id = @Id ";

                var result = conn.Execute(sql, new
                {
                    appConfig.IpAddress,
                    appConfig.Port,
                    SaveLabels = appConfig.SaveLabels ? 1 : 0,
                    appConfig.SaveLabelPath,
                    appConfig.Id
                });

            }
        }

        public void SaveLabelFormat(LabelFormat labelFormat)
        {
            using (var conn = new SqliteConnection("Data Source=" + System.Environment.CurrentDirectory + "/zpl.db"))
            {
                if (labelFormat.Id > 0)
                {
                    var sql =
                        "UPDATE LabelFormats SET Name = @Name, Height = @Height, Width = @Width, PrintDensity = @PrintDensity, IsDefault = @IsDefault WHERE Id = @Id ";

                    var result = conn.Execute(sql, new
                    {
                        labelFormat.Name,
                        labelFormat.Height,
                        labelFormat.Width,
                        labelFormat.PrintDensity,
                        labelFormat.IsDefault,
                        labelFormat.Id
                    });
                }
                else
                {
                    var sql =
                        "insert into LabelFormats (AppConfigId, Name, Height, Width, PrintDensity, IsDefault) VALUES" +
                        "(@AppConfigId, @Name, @Height, @Width, @PrintDensity, @IsDefault)";
                    
                    var result = conn.Execute(sql, new
                    {
                        labelFormat.AppConfigId,
                        labelFormat.Name,
                        labelFormat.Height,
                        labelFormat.Width,
                        labelFormat.PrintDensity,
                        labelFormat.IsDefault
                    });
                }
            }
        }

        public void DeleteLabelFormat(int id)
        {
            using (var conn = new SqliteConnection("Data Source=" + System.Environment.CurrentDirectory + "/zpl.db"))
            {
                var sql =
                    "DELETE FROM LabelFormats WHERE Id = @id ";

                var result = conn.Execute(sql, new
                {
                    id
                });

            }
        }

        public void SavePrinter(Printer printer)
        {
            using (var conn = new SqliteConnection("Data Source=" + System.Environment.CurrentDirectory + "/zpl.db"))
            {
                if (printer.Id > 0)
                {
                    var sql =
                        "UPDATE Printers SET Name = @Name, IpAddress = @IpAddress, Port = @Port, IsDefault = @IsDefault WHERE Id = @Id ";

                    var result = conn.Execute(sql, new
                    {
                        printer.Name,
                        printer.IpAddress,
                        printer.Port,
                        printer.IsDefault,
                        printer.Id
                    });
                }
                else
                {
                    var sql =
                        "insert into Printers (AppConfigId, Name, IpAddress, Port, IsDefault) VALUES" +
                        "(@AppConfigId, @Name, @IpAddress, @Port, @IsDefault)";

                    var result = conn.Execute(sql, new
                    {
                        printer.AppConfigId,
                        printer.Name,
                        printer.IpAddress,
                        printer.Port,
                        printer.IsDefault
                    });
                }
            }
        }

        public void DeletePrinter(int id)
        {
            using (var conn = new SqliteConnection("Data Source=" + System.Environment.CurrentDirectory + "/zpl.db"))
            {
                var sql =
                    "DELETE FROM Printers WHERE Id = @id ";

                var result = conn.Execute(sql, new
                {
                    id
                });

            }
        }
    }
}
