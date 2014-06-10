﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using AppArch.Infrastructure.Interfaces;

namespace AppArch.Infrastructure.Data.Services
{
    public class ConfigService : IConfigService
    {
        public string NorthwindConnection
        {
            get
            {
                string cnString = null;
                var cnSettings = ConfigurationManager.ConnectionStrings["NorthwindConnection"];
                if (cnSettings != null)
                {
                    cnString = cnSettings.ConnectionString;
                }
                return cnString;
            }
        }
    }
}
