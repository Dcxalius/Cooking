using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Road : Tile
    {
        public Road(Vector2 pos) : base(pos)
        {
            identity = Object.Road;
            walkable = true;
        }
    }
}
