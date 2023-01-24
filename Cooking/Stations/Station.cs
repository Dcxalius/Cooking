using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Station : GameObject , CustomerTarget
    {
        protected PickUp storedPickedUp = null;

        protected PickUp[,] transform;

        public Station(Vector2 pos) : base(pos)
        {
            artType = ArtType.Station;
        }

        public Station(PickUp thingToSpawnWith, Vector2 pos) : base(pos)
        {
            artType = ArtType.Station;

        }

        void PlacePickUpOnMe(PickUp pickedUp)
        {
            storedPickedUp = pickedUp;
        }

       

        public virtual bool Interact(Agent a, PickUp pickUp)
        {
            if (storedPickedUp == null)
            {
                storedPickedUp = pickUp;
                return true;
            }


            return false;
        }

        public override void Update()
        {
            base.Update();

            storedPickedUp.Update();
        }

        public override void Draw(SpriteBatch aBatch)
        {
            base.Draw(aBatch);

            storedPickedUp.Draw(aBatch);
        }


        public virtual bool CustomerInteract(Customer c)
        {
            throw new NotImplementedException();
        }
    }
}
