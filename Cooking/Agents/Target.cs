using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    interface Target
    {
        Vector2 GetPos();
        static public bool InRange(Vector2 aPos, Vector2 bPos)
        {

            if ((aPos - bPos).Length() <= 5f)
            {
                return true;
            }
            return false;
        }
    }
}
