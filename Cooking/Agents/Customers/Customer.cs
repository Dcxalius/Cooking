using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class Customer : Agent
    {
        Node LogicNode = Tree.StartNode;
        CustomerTarget target;
        bool hasOrdered;
        bool hasEaten;

        public bool HasOrdered
        {
            get => hasOrdered;
        }
        public CustomerTarget GetTarget
        {
            get => target;
        }
        public bool HasEaten
        {
            get => hasEaten;
        }
        public Customer() : base(GameManager.ActiveArea.Entrance.GetPos())
        {
            identity = Object.Customer;
        }

        public override void Update()
        {
            base.Update();

            LogicNode = LogicNode.Update(this, out target);
            
            if (Target.InRange(pos, target.GetPos()))
            {
                if (LogicNode.GetType() == typeof(WaitingNode))
                {
                    hasOrdered = target.CustomerInteract(this);
                }
                if (LogicNode.GetType() == typeof(EatingNode))
                {
                    hasEaten = target.CustomerInteract(this);
                }
            }
            else
            {
                MoveTowards(target.GetPos());
            }
        }
    }
}
