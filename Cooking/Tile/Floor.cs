using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Floor : Tile 
    {
        Floor(Vector2 pos) : base(pos)
        {
            identity = Object.Floor;
            walkable = true;
        }
    }
}
