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
    public class SlimeInABottle : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases Summon damage by 25% \nIncreases Max Life by 35 \nIncreases Your Max Nuber of Minions by 1");
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
            recipe.AddIngredient(ItemID.FallenStar, 6);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.noKnockback = false;
            player.minionDamage += 0.25f;
            player.statLifeMax2 += 35;
            player.maxMinions += 1;
        }
    }
}