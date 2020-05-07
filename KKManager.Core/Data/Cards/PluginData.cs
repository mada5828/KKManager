﻿using System.Collections.Generic;
using MessagePack;

namespace KKManager.Data.Cards
{
    [MessagePackObject]
    public class PluginData
    {
        [Key(0)]
        public int version;
        [Key(1)]
        public Dictionary<string, object> data = new Dictionary<string, object>();
    }
}