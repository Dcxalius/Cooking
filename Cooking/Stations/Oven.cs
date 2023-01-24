using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Oven : Station
    {
        Oven(Vector2 pos) : base(pos)
        {
            identity = Object.Oven;
        }
    }
}
