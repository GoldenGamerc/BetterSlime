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
    public class SlimeCharm : ModItem
    {

        public override void SetStaticDefaults()
        {
        Tooltip.SetDefault("Increases Magic damage by 15% \nIncreases Max Mana by 35");
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
            recipe.AddIngredient(ItemID.ManaCrystal, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {                       
            player.noKnockback = false;
            player.magicDamage += 0.15f;
            player.statManaMax2 += 35;
        }
    }
}