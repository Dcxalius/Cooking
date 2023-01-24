using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Ground : Tile 
    {
        public Ground(Vector2 pos) : base(pos)
        {
            identity = Object.Ground;
            walkable = true;
        }
    }
}
