using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Chef : Agent, ChefTarget
    {
        StateMachine sm = new Idle(); 

        public Chef(Vector2 pos) : base(pos)
        {
            identity = Object.Chef;
        }

        public void Interact()
        {

        }




        public override void Update()
        {
            //heldPickUp.MoveBy();
            sm.Update(this);
            base.Update();
        }
    }
}
