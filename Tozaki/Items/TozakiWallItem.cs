using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tozaki.Items
{
    public class TozakiWallItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tozaki: Wall");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;

            item.createWall = mod.WallType("TozakiWall");
        }
    }
}