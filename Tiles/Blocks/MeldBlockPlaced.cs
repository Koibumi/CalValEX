﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalValEX.Tiles.Blocks
{
    public class MeldBlockPlaced : ModTile {
        public override void SetStaticDefaults() {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            //ItemDrop = ModContent.ItemType<MeldBlock>();
            DustType = 173;
            AddMapEntry(new Color(19, 24, 27));
            Main.tileBlendAll[this.Type] = true;
            HitSound = SoundID.Item154;
        }
    }
}