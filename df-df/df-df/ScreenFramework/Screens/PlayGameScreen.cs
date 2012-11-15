using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using df_df.ScreenFramework.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using df_df.World;

namespace df_df.ScreenFramework.Screens
{
    class PlayGameScreen : GameScreen
    {
        private GraphicsDevice Graphics;
        private SpriteBatch Batch;
        private SpriteFont Font;

        Vector2 cam1_position = Vector2.Zero, cam2_position = Vector2.Zero;
        Vector2 cam_velocity = new Vector2(-1, 0);

        Level level;

        public PlayGameScreen()
        {
            level = new Level();
        }

        public override void LoadContent()
        {
            Graphics = ScreenManager.GraphicsDevice;
            Batch = ScreenManager.SpriteBatch;
            Font = ScreenManager.Font;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void HandleInput(InputState input)
        {
            if (input.IsNewKeyPress(Keys.A, 150)) // fire weapon
            {
                //levelManager.Fire(input.GetMousePosition());
            }
        }

        public override void Draw(GameTime gameTime)
        {
            Graphics.Clear(Color.Black);

            // draw ground
            Batch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, null, Matrix.CreateTranslation(new Vector3(cam1_position * 4f, 0)));
            //Batch.Draw(GameUtil.spriteDictionary["ground"], Vector2.Zero, GameUtil.spriteDictionary["ground"].Bounds, Color.White, 0f, Vector2.Zero, 1, SpriteEffects.None, 0);
            Batch.End();

            // draw everything else
            Batch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, null);

            for (int x = 0; x < level.floor.Length; x++)
            {
                for (int y = 0; y < level.floor[x].Length; y++)
                {
                    Batch.DrawString(Font,"(" + x + " " + y + ")", new Vector2(20 + (x * 50), 40 + (y * 40)), Color.White, 0, Vector2.Zero, GameUtil.fontScale, SpriteEffects.None, 0);
                }
            }
            Batch.DrawString(Font, "Runner Prototype " + GameUtil.VERSION, new Vector2(20, 20), Color.White, 0, Vector2.Zero, GameUtil.fontScale, SpriteEffects.None, 0);
            Batch.End();

            base.Draw(gameTime);
        }
    }
}
