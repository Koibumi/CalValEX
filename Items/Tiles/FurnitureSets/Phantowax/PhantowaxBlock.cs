using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Items.Tiles;
using CalValEX.Items.Tiles.FurnitureSets.Phantowax;

namespace CalValEX.Items.Tiles.FurnitureSets.Phantowax
{
	public class PhantowaxBlock : ModItem
	{
		public override void SetStaticDefaults() {
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
            item.rare = 0;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<PhantowaxBlockPlaced>();
		}

		public override void AddRecipes() {
			Mod CalValEX = ModLoader.GetMod("CalamityMod");
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient((ItemID.ClayBlock), 50);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Phantoplasm"), 1);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(this, 50);
				recipe.AddRecipe();
				/*ModRecipe recipe2 = new ModRecipe(mod);
				recipe2.AddIngredient(ModContent.ItemType<WulfrumPanelWall>(), 4);
				recipe2.AddTile(TileID.WorkBenches);
				recipe2.SetResult(this, 1);
				recipe2.AddRecipe();*/
		}
	}
}