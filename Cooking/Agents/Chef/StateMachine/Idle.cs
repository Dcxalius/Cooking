using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Idle : StateMachine
    {
        public override void OnEnter()
        {
            chefTarget = myChef; 
        }

        public override void Update(Chef c)
        {
            //If a customer wants to order
            //Start cooking proccess
            //E) If there is dirty plates
            //Start cleaning proccess
            //E) If there are rats
            //start rat removal
            //E)

            base.Update(c);
        }
    }
}
