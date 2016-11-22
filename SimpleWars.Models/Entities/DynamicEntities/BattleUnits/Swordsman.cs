﻿namespace SimpleWars.Models.Entities.DynamicEntities.BattleUnits
{
    using System.Collections.Generic;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    using SimpleWars.Assets;
    using SimpleWars.Utils;

    public class Swordsman : Unit
    {
        private const string Dir = "Models3D";
        private const string FileName = "swordsman";

        private const int BaseHealth = 100;
        private const int BaseDamage = 25;
        private const int BaseArmor = 10;

        protected Swordsman()
        {
        }

        public Swordsman(Vector3 position, float scale = 1) : base(BaseHealth, BaseDamage, BaseArmor, position, scale)
        {
        }

        public Swordsman(Vector3 position, Vector3 rotation, float scale = 1) : base(BaseHealth, BaseDamage, BaseArmor, position, rotation, scale)
        {
        }

        public Swordsman(Vector3 position, Vector3 rotation, float weight = 1, float scale = 1) : base(BaseHealth, BaseDamage, BaseArmor, position, rotation, weight, scale)
        {
        }

        public override void LoadModel()
        {
            this.Model = ModelsManager.Instance.GetModel(Dir, FileName);
        }
    }
}