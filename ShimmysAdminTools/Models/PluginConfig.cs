﻿using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShimmysAdminTools.Models
{
    public class PluginConfig : IRocketPluginConfiguration
    {
        public int MaxGlobalFlySpeed;
        public PointToolSettings PointToolSettings;

        public void LoadDefaults()
        {
            MaxGlobalFlySpeed = 10;
            PointToolSettings = new PointToolSettings()
            {
                DestroyToolEnabled = true,
                JumpToolEnabled = true,
                UtilityToolEnabled = true
            };
        }
    }
    public class PointToolSettings
    {
        public bool DestroyToolEnabled;
        public bool JumpToolEnabled;
        public bool UtilityToolEnabled;
    }
}