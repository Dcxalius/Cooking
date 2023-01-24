using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Salad : Recepie
    {
        Salad()
        {
            name = "Salad";

            ingredientsToGet.Add(new ChoppedLettuce(new Microsoft.Xna.Framework.Vector2(0))) ;
        }
    }
}
