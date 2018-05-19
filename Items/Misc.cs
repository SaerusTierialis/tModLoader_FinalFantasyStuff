using Terraria.ModLoader;

namespace FinalFantasyStuff.Items
{
    //leave this class as BlackChocoboFeather to convert old feathers to the new greens
    public class BlackChocoboFeather : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sylkis Greens");
            Tooltip.SetDefault("Used to obtain a Black Chocobo");
        }
        public override void SetDefaults()
        {
            item.width = 29;
            item.height = 29;
            item.maxStack = 9999999;
            item.value = 25000;
            item.rare = 11;
        }
    }

    public class ZeioNut : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zeio Nut");
            Tooltip.SetDefault("Used to obtain a Gold Chocobo");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 27;
            item.maxStack = 9999999;
            item.value = 2500000;
            item.rare = 11;
            item.expert = true;
        }
    }
}