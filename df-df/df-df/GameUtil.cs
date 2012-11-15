﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace df_df
{
    public static class GameUtil
    {
        public const String VERSION = "0.0.0";

        public static int MenuSelectDelay = 200;

        public static int windowHeight = 720;
        public static int windowWidth = 1280;
        public static float fontScale = 2f;

        public static int playerX = 100;
        public static int playerY = 500;

        public static int groundY = 564;

        public static Random random = new Random();
        //public static IDictionary<String, Texture2D> spriteDictionary = new Dictionary<String, Texture2D>();

        // Time between mob spawns
        public static double level_1_spawnTime = .6 * 1000;

        // Animation Frames for each Image
        public static int bat_frames = 2;
        public static int spider_frames = 2;
        public static int arrow_frames = 1;
        public static int player_frames = 2;
        public static int cultist_frames = 2;

        // HP values
        public static int playerHP = 30;
        public static int batHP = 1;
        public static int spiderHP = 1;
        public static int cultistHP = 2;

        // Weapon dmg
        public static int arrowDmg = 1;

        // Mob dmg
        public static int batDmg = 1;
        public static int spiderDmg = 1;
        public static int cultistDmg = 1;

        // Mob speed
        public static int batSpeed = 6;
        public static int spiderSpeed = 4;
        public static int cultistSpeed = 6;

        // Animation timing
        public static int playerAnimationLength = 200;
        public static int cultistAnimationLength = 200;

        // jump constants
        public static int maxJumpHeight = 100;
        public static int JumpPower = -10;
        public static int FallPower = 10;
        public static float JumpFriction = .6f;

        // weapons
        public static int arrowSpeed = 15;
        public static int arrowDelay = 300;

        // multishot
        public static double multishot_spread = 1;
        public static int multshotDelay = 600;

        //public static void loadSprites(ContentManager Content)
        //{
        //    spriteDictionary.Add("bat", Content.Load<Texture2D>("mobs/bat"));
        //}
    }
}
