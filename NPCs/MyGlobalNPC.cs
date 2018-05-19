using System;
using Terraria;
using Terraria.ModLoader;

namespace FinalFantasyStuff.NPCs
{
    class MyGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.netMode != 1 && !npc.friendly && npc.lifeMax > 5 && !npc.SpawnedFromStatue)
            {
                //Chocobo Whistle
                if (Main.rand.Next(500)==0) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType<Items.ChocoboWhistle>());

                //Sylkis Greens (formerly black chocobo feather)
                if (Main.rand.Next(100) == 0) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType<Items.BlackChocoboFeather>());

                //Zeio Nut
                if (npc.boss && Main.rand.Next(50)==0) Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType<Items.ZeioNut>());
            }
        }
    }
}
