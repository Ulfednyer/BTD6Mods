﻿using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors.Emissions;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using BTD6SafeMonkey;
using BTD6SafeMonkey.Display;


namespace BTD6_SafeMonkey.Upgrade.MiddlePath
{
    class SafeMonkey0_0_4 : ModUpgrade<SafeMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 4;

        public override int Cost => 56000;

        public override string Description => "Monkey gets additional bomb attack and additional shuriken";

        public override string DisplayName => "Bombing Safemonkey";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = attackModel.weapons[0];
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce += 40;
            weaponModel.Rate *= 0.65f;

            weaponModel.emission = new ArcEmissionModel("EmissionModelThreeShuriken", 8, 0, 40, null, false);

            var bombAttack = Game.instance.model.GetTower(TowerType.BombShooter, 2, 5, 0).GetWeapon().Duplicate();
            bombAttack.projectile.ApplyDisplay<GrenadeDisplay>();

            attackModel.AddWeapon(bombAttack);
        }

        public override string Icon => "ExplosionIcon";
        public override string Portrait => "ExplosionIcon";
    }
}