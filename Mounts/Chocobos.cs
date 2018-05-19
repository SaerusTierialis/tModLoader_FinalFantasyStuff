using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace FinalFantasyStuff.Mounts
{
    /* Template and regular Chocobo */
    public class Chocobo : ModMountData
    {
        public string dustType = "ChocoboDust";
        public string buffType = "ChocoboMount";
        public int heightBoost = 20;
        public float runSpeed = 13f;
        public float dashSpeed = 8f;
        public int flightTimeMax = 0;
        public int fatigueMax = 0;
        public int jumpHeight = 20;
        public float acceleration = 0.19f;
        public float jumpSpeed = 10f;

        public override void SetDefaults()
        {
            //specific
            mountData.spawnDust = mod.DustType(dustType);
            mountData.buff = mod.BuffType(buffType);
            mountData.heightBoost = heightBoost;
            mountData.runSpeed = runSpeed;
            mountData.dashSpeed = dashSpeed;
            mountData.flightTimeMax = flightTimeMax;
            mountData.fatigueMax = fatigueMax;
            mountData.jumpHeight = jumpHeight;
            mountData.acceleration = acceleration;
            mountData.jumpSpeed = jumpSpeed;
            //generic
            mountData.fallDamage = 0f;
            mountData.fatigueMax = 0;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 7;
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++) 
            {
                array[l] = 20;
            }
            mountData.playerYOffsets = array;
            mountData.xOffset = 13;
            mountData.bodyFrame = 3;
            mountData.yOffset = 0;
            mountData.playerHeadOffset = 22;
            mountData.standingFrameCount = 1;
            mountData.standingFrameDelay = 24;
            mountData.standingFrameStart = 0;
            mountData.runningFrameCount = 7;
            mountData.runningFrameDelay = 12;
            mountData.runningFrameStart = 0;
            mountData.flyingFrameCount = 7;
            mountData.flyingFrameDelay = 1;
            mountData.flyingFrameStart = 0;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 24;
            mountData.inAirFrameStart = 1;
            mountData.idleFrameCount = 1;
            mountData.idleFrameDelay = 24;
            mountData.idleFrameStart = 0;
            mountData.idleFrameLoop = true;
            mountData.swimFrameCount = mountData.inAirFrameCount;
            mountData.swimFrameDelay = mountData.inAirFrameDelay;
            mountData.swimFrameStart = mountData.inAirFrameStart;
            if (Main.netMode != 2)
            {
                mountData.textureWidth = mountData.backTexture.Width + 20;
                mountData.textureHeight = mountData.backTexture.Height;
            }
        }

        public override void UpdateEffects(Player player)
        {
            if (Math.Abs(player.velocity.X) > 4f)
            {
                Rectangle rect = player.getRect();
                Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, mod.DustType(dustType));
            }
        }
    }

    /* Black Chocobo */
    public class BlackChocobo : Chocobo
    {
        public BlackChocobo()
        {
            dustType = "BlackChocoboDust";
            buffType = "BlackChocoboMount";
            heightBoost = 20;
            runSpeed = 16f;
            dashSpeed = 9f;
            flightTimeMax = 0;
            fatigueMax = 0;
            jumpHeight = 10;
            acceleration = 0.19f;
            jumpSpeed = 10f;
        }
    }

    /* Gold Chocobo */
    public class GoldChocobo : Chocobo
    {
        public GoldChocobo()
        {
            dustType = "GoldChocoboDust";
            buffType = "GoldChocoboMount";
            heightBoost = 20;
            runSpeed = 19f;
            dashSpeed = 10f;
            flightTimeMax = 50;
            fatigueMax = 0;
            jumpHeight = 10;
            acceleration = 0.19f;
            jumpSpeed = 10f;
        }
    }
}