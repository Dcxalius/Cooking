using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Agent : GameObject
    {
        enum States
        {
            Idle,
            Moving,
            Working
        }

        float speed = 3;

        PickUp heldPickUp;

        States myState = States.Idle;
        CustomerTarget target;
        public Agent(Vector2 pos) : base(pos)
        {
            artType = ArtType.Agent;

        }

        public override void Update()
        {
            Decision();
            base.Update();
        }

        void Decision()
        {
            //Set target
            //Move to target
            //Interact with target
        }

        void PickUp(PickUp thingToPickUp)
        {
            heldPickUp = thingToPickUp;
        }


        public void MoveTowards(Vector2 aPos)
        {
            Vector2 ang = aPos - pos;
            ang.Normalize();
            MoveTo(ang * speed * (float)GameManager.GetGameTime.ElapsedGameTime.TotalMilliseconds);
        }

        public void MoveTo(Vector2 aPos)
        {
            pos = aPos;
        }
    }
}
