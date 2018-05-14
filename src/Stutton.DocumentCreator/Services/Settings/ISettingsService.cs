﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stutton.DocumentCreator.Models.Settings;

namespace Stutton.DocumentCreator.Services.Settings
{
    public interface ISettingsService
    {
        Task<IResponse> SaveSettings(SettingsModel settings);
        Task<IResponse<SettingsModel>> GetSettings();
    }
}
