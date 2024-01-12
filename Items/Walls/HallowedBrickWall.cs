﻿using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Walls;

namespace CalValEX.Items.Walls
{
    public class HallowedBrickWall : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Hallowed Brick Wall");
            Item.ResearchUnlockCount = 400;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.White;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 7;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createWall = ModContent.WallType<HallowedBrickWallPlaced>();
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<HallowedBrick>());
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }*/
    }
}