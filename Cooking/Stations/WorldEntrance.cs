using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class WorldEntrance : Station
    {

        public WorldEntrance(Vector2 pos) : base(pos)
        {
            identity = Object.WorldEntrance;
        }
    }
}
