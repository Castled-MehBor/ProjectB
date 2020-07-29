using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace RobotWorld
{
    public class RobotWorld : ModWorld
    {
        public static float globalSpinSpeed = 1.5f;
        public static int invasionPoints = 0;
        public static int numberOfEnemies = 0;
        public static int waveDelayCountdown = 0;
        //counterType 1 = Enemy Counter. counterType 2 = wave countdown
        public static int counterType = 1;
    }
}