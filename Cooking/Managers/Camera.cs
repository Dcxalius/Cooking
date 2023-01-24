using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    static class Camera
    {
        static Vector2 pos;
        static RenderTarget2D rt;
        static GraphicsDeviceManager gdm;
        static GraphicsDevice gd;

        static SpriteBatch batch;

        public static void Init(GraphicsDeviceManager aGdm)
        {
            gdm = aGdm;
            gd = aGdm.GraphicsDevice;
            batch = new SpriteBatch(gd);
            pos = new Vector2(0, 0);
            rt = new RenderTarget2D(gdm.GraphicsDevice, 1000, 700);
        }

        public static void DrawToRenderTarget()
        {
            gd.SetRenderTarget(rt);
            gd.Clear(Color.White);
            batch.Begin();

            GameManager.Draw(batch);

            batch.End();
            gd.SetRenderTarget(null);
        }

        public static void Render()
        {
            gd.Clear(Color.Black);
            batch.Begin();
            batch.Draw(rt, pos, Color.White);
            batch.End();
        }
    }
}
