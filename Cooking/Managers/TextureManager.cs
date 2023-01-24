using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Cooking
{
    static class TextureManager
    {

        static private Texture2D[] textures = new Texture2D[(int)Object.Count];

        public static void SetTextures(ContentManager cm)
        {
            string s = "";
            for (int i = 0; i < (int)Object.Count; i++)
            {
                switch ((Object)i)
                {
                    case Object.Chef:
                        s = "Agent/"; //TODO: Make sure this is right syntax
                        break;
                    case Object.Counter:
                        s = "Station/";
                        break;
                    case Object.Lettuce:
                        s = "PickUp/";
                        break;
                    case Object.Ground:
                        s = "Tile/";
                        break;
                    default:
                        break;
                }
                textures[i] = cm.Load<Texture2D>((s + (Object)i).ToString());
            }
        }

        static public Texture2D GetTexture(Object texture)
        {
            return textures[(int)texture];
        }
    }
}
