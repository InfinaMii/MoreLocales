﻿using MoreLocales.Core;
using MoreLocales.Utilities;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MoreLocales.Config
{
    public class ClientSideConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("$Mods.MoreLocales.Configs.Headers.Fonts")]
        [DefaultValue(LocalizedFont.None)]
        [DrawTicks]
        public LocalizedFont ForcedFont;

        public override void OnChanged()
        {
            FontHelper.SwitchFont(ForcedFont, true);
        }
    }
}
