using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    abstract class CookingState : StateMachine
    {
        public abstract override void OnEnter();

        public override void Update(Chef c)
        {
            base.Update(c);
        }
    }
}
