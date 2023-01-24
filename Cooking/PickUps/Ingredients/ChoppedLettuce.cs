using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class ChoppedLettuce : Ingredient
    {

        public ChoppedLettuce(Vector2 pos) : base(pos)
        {
            identity = Object.ChoppedLettuce;
        }

    }
}
