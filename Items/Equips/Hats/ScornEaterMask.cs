using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalValEX.Items.Equips.Hats
{
    [AutoloadEquip(EquipType.Head)]
    public class ScornEaterMask : ModItem
    {
        public override void SetStaticDefaults() => Item.ResearchUnlockCount = 1;

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.rare = ItemRarityID.Purple;
            Item.vanity = true;
            Item.value = Item.sellPrice(0, 3, 0, 0);
            Terraria.ID.ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
        }
    }
}