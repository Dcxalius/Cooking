using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class WorldExit : Station, CustomerTarget
    {
        public WorldExit(Vector2 pos) : base(pos)
        {
            identity = Object.WorldExit;
        }

        public override bool CustomerInteract(Customer c)
        {
            if (Target.InRange(pos, c.GetPos()))
            {
                //Kill customer
                return true;
            }

            return false;
        }
    }
}
