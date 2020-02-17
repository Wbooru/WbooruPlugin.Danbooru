﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wbooru.Settings;

namespace WbooruPlugin.Danbooru
{
    [Export(typeof(SettingBase))]
    public class DanbooruSetting : SettingBase
    {
        public bool QuestionableIsNSFW { get; internal set; }
    }
}
