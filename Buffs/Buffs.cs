using Terraria;
using Terraria.ModLoader;

namespace FinalFantasyStuff.Buffs
{
    /* Template and Chocobo */
    public class ChocoboMount : ModBuff
    {
        public string name = "Chocobo";
        public string tooltip = "KWEH!";

        public override void SetDefaults()
        {
            DisplayName.SetDefault(name);
            Description.SetDefault(tooltip);
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (name == "Chocobo") player.mount.SetMount(mod.MountType<Mounts.Chocobo>(), player);
            player.buffTime[buffIndex] = 10;
            player.noFallDmg = true;
        }
    }

    /* Black Chocobo */
    public class BlackChocoboMount : ChocoboMount
    {
        public BlackChocoboMount()
        {
            name = "Black Chocobo";
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType<Mounts.BlackChocobo>(), player);
            player.waterWalk2 = true;
            player.doubleJumpSandstorm = true;
            base.Update(player, ref buffIndex);
        }
    }

    /* Gold Chocobo */
    public class GoldChocoboMount : ChocoboMount
    {
        public GoldChocoboMount()
        {
            name = "Gold Chocobo";
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType<Mounts.GoldChocobo>(), player);
            player.waterWalk2 = true;
            base.Update(player, ref buffIndex);
        }
    }
}
