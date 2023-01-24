using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    enum State
    {
        Idle,
        OrderGetting,
        Cooking,
        Chopping,
        Cleaning,
        RatChasing,
        Count
    }
    abstract class StateMachine
    {
        protected ChefTarget chefTarget;
        protected Chef myChef;
        protected bool first = true;
        public abstract void OnEnter();
        public virtual void OnLeave()
        {
            first = true;
        }

        public virtual void Update(Chef c)
        {
            if (first)
            {
                myChef = c;
                first = false;
                OnEnter();
            }
        }
    }
}
