using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    static class GameManager
    {
        static List<GameObject> gameObjects = new List<GameObject>();
        static PlayArea playArea;
        static GameTime gt;

        public static GameTime GetGameTime
        {
            get => gt;
        }

        static public PlayArea ActiveArea
        {
            get => playArea;
        }
        static void Init()
        {
            playArea = new PlayArea(new Point(20));
            gameObjects.Add(new Chef(new Vector2(100,100)));
        }

        static void Update(GameTime gameTime)
        {
            gt = gameTime;

            playArea.Update();
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }
        }

        public static void Draw(SpriteBatch aBatch)
        {
            playArea.Draw(aBatch);
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(aBatch);
            }
        }
    }
}
