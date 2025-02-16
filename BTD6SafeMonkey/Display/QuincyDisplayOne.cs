﻿using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Models.Towers;
using MelonLoader;
using Assets.Scripts.Unity.UI_New.InGame;
using BTD_Mod_Helper.Api;
using Assets.Scripts.Unity.Bridge;

namespace BTD6SafeMonkey.Display
{
    class QuincyDisplayOne : ModTowerDisplay<SafeMonkey>
    {
        public override string BaseDisplay => "3db6fc68b301c6d48aac832f6894c384";
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
        }

        public override bool UseForTower(int[] tiers)
        {
            return tiers[0] == 0 || tiers[1] == 0 || tiers[2] == 0 ||
                   tiers[0] == 1 || tiers[1] == 1 || tiers[2] == 1;
        }
    }
}