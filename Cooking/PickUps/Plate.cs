using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Plate : PickUp
    {
        Recepie recepie;
        public Plate(Vector2 pos) : base(pos)
        {
            identity = Object.Plate;
        }

        public bool Interact(Agent a, Ingredient ing)
        {
            return recepie.Interact(ing);
        }
    }
}
