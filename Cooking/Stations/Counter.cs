using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Counter : Station, CustomerTarget
    {
        Counter(Vector2 pos) : base(pos)
        {
            identity = Object.Counter;
        }


        public Action Interact()
        {
            Action returnAction = () =>
            {

            };

            return returnAction;
        }
        public override bool Interact(Agent a, PickUp pickUp)
        {
            if (base.Interact(a, pickUp))
            {
                return true;
            }
            


            if (storedPickedUp.GetType() == typeof(Plate) && pickUp.GetType().IsSubclassOf(typeof(Ingredient)))
            {
                return ((Plate)storedPickedUp).Interact(a, (Ingredient)pickUp);
            }

            return false;
        }
    }
}
