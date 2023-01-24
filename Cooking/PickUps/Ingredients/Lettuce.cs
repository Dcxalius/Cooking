using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Lettuce : Ingredient
    {
        public Lettuce(Vector2 pos) : base(pos)
        {
            identity = Object.Lettuce;
        }
    }
}
