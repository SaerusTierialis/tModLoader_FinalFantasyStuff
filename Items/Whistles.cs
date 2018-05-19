using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FinalFantasyStuff.Items
{
    /* Template and Regular Whistle */
    public class ChocoboWhistle : ModItem
    {
        public string name = "Chocobo Whistle";
        public string tooltip = "Summons a Chocobo";
        public string mountType = "Chocobo";
        public int value = 250000;
        public int rare = 8;
        public bool expert = false;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(name);
            Tooltip.SetDefault(tooltip);
        }
        public override void SetDefaults()
        {
            //specific
            item.mountType = mod.MountType(mountType);
            item.rare = rare;
            item.expert = expert;
            item.value = value;
            //generic
            item.width = 30;
            item.height = 24;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.UseSound = SoundID.Item79;
            item.noMelee = true;
        }
    }

    /* Black Chocobo Whistle */
    public class BlackChocoboWhistle : ChocoboWhistle
    {
        public BlackChocoboWhistle()
        {
            name = "Black Chocobo Whistle";
            tooltip = "Summons a Black Chocobo";
            mountType = "BlackChocobo";
            rare = 11;
            value = 5000000;
        }

        public override void AddRecipes()
        {
            Commons.QuckRecipe(mod, new int[,] { { mod.ItemType<Items.ChocoboWhistle>(), 2 }, { mod.ItemType<Items.BlackChocoboFeather>(), 100 } }, this, 1);
        }
    }

    /* Gold Chocobo Whistle */
    public class GoldChocoboWhistle : ChocoboWhistle
    {
        public GoldChocoboWhistle()
        {
            name = "Gold Chocobo Whistle";
            tooltip = "Summons a Gold Chocobo";
            mountType = "GoldChocobo";
            rare = 11;
            expert = true;
            value = 15000000;
        }

        public override void AddRecipes()
        {
            Commons.QuckRecipe(mod, new int[,] { { mod.ItemType<Items.ChocoboWhistle>(), 1 }, { mod.ItemType<Items.BlackChocoboWhistle>(), 1 }, { mod.ItemType<Items.BlackChocoboFeather>(), 100 }, { mod.ItemType<Items.ZeioNut>(), 1 } }, this, 1);
        }
    }

}