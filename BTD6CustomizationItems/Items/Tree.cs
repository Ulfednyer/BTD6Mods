﻿using Assets.Scripts.Models.Towers.Behaviors.Attack;
using Assets.Scripts.Models.GenericBehaviors;
using Assets.Scripts.Models.TowerSets;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Map;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using UnhollowerBaseLib;
using System.Collections.Generic;
using System.Linq;

namespace BTD6_Customization_items
{
    class Tree : ModTower<ItemsSet>
    {
        public override string BaseTower => TowerType.CaveMonkey;
        public override string Description => "Tree";

        public override int Cost => 0;
        public override int TopPathUpgrades => 0;
        public override int MiddlePathUpgrades => 0;
        public override int BottomPathUpgrades => 0;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.RemoveBehaviors<AttackModel>();
            towerModel.GetBehavior<DisplayModel>().ignoreRotation = true;
            towerModel.doesntRotate = true;

            var newAreaType = new Il2CppStructArray<AreaType>(5);

            newAreaType[0] = AreaType.unplaceable;
            newAreaType[1] = AreaType.ice;
            newAreaType[2] = AreaType.land;
            newAreaType[3] = AreaType.track;
            newAreaType[4] = AreaType.water;

            towerModel.areaTypes = newAreaType;

            towerModel.radius = 0;
            towerModel.ignoreBlockers = true;
            towerModel.ignoreCoopAreas = true;
        }

        public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
        {
            return towerSet.First(model => model.towerId == TowerType.EngineerMonkey).towerIndex + 1;
        }

        public override string Icon => "TreeImage";
        public override string Portrait => "TreeImage";     
    }
}