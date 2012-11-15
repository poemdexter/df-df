using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using df_df.ScreenFramework;
using df_df.ScreenFramework.Screens;

namespace df_df
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private ScreenManager screenManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = GameUtil.windowHeight;
            graphics.PreferredBackBufferWidth = GameUtil.windowWidth;
            this.IsMouseVisible = true;

            screenManager = new ScreenManager(this, graphics);
            Components.Add(screenManager);
            screenManager.AddScreen(new TitleScreen());
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent() {}

        protected override void UnloadContent() {}

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            base.Draw(gameTime);
        }
    }
}
