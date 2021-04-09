using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPL_Print_Testing.Models;

namespace ZPL_Print_Testing.Repositories
{
    public interface IConfigRepository
    {
        AppConfig GetAppConfig();

        void SaveOrUpdateAppConfig(AppConfig appConfig);

    }
}
