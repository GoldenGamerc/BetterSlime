using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace BetterSlime.Items
{
    public class SlimeQuiver : ModItem
    {

        public override void SetStaticDefaults()
        {
        Tooltip.SetDefault("Increases Ranged damage by 15% \nIncreases Defense by 2");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 32;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Green;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SlimeBlock, 50);
            recipe.AddIngredient(ItemID.WoodenArrow, 250);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {                       
            player.noKnockback = false;
            player.rangedDamage += 0.15f;
            player.statDefense += 2;
        }
    }
}