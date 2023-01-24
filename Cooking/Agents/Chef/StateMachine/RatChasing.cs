using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class RatChasing : StateMachine
    {
        RatChasingState state;

        public override void OnEnter()
        {
            state = new RatChasingState();
        }

        public override void Update(Chef c)
        {

            base.Update(c);
        }
    }
}
