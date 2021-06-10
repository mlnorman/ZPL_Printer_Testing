using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPL_Print_Testing.Models;

namespace ZPL_Print_Testing.Services
{
    public interface IConfigService
    {
        AppConfig GetAppConfig();

        void SaveAppConfig(AppConfig appConfig);

        void SaveLabelFormat(LabelFormat labelFormat);

        void DeleteLabelFormat(int id);

    }
}
