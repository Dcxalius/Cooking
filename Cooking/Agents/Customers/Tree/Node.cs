using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    abstract class Node
    {
        Node parentNode;
        Node childTrue;
        Node childFalse;

        public Node(Node parentNode)
        {

        }

        public void AddChildren(Node aTrue, Node aFalse)
        {
            childFalse = aFalse;
            childTrue = aTrue;
        }

        public abstract Node Update(Customer c, out CustomerTarget t);

        public Node GetParent()
        {
            return parentNode;
        }

        public Node GetChildTrue()
        {
            return childTrue;
        }
        public Node GetChildFalse()
        {
            return childFalse;
        }

    }

    class AvailableSeatNode : Node
    {
        public AvailableSeatNode(Node parentNode) : base(parentNode)
        {

        }

        public override Node Update(Customer c, out CustomerTarget t)
        {
            Station s = CustomerSeating.AvailableSeat();
            if (s == null)
            {
                t = null;
                return GetChildFalse();
            }

            t = s;

            if (Target.InRange(c.GetPos(), t.GetPos()))
            {
                return GetChildTrue();

            }

            return this;
        }

       
    }

    class OrderingNode : Node
    {
        public OrderingNode(Node parentNode) : base(parentNode)
        {

        }

        public override Node Update(Customer c, out CustomerTarget t)
        {
            t = c.GetTarget;
            if (c.HasOrdered)
            {
                return GetChildTrue();
            }
            return this;
        }
    }

    class GetWaitingSpotNode : Node
    {
        public GetWaitingSpotNode(Node parentNode) : base(parentNode)
        {

        }
        public override Node Update(Customer c, out CustomerTarget t)
        {
            Station s = CustomerSeating.AvailableWaitingSeat();
            if (s == null)
            {
                t = null;
                return GetChildFalse();
            }

            t = s;

            if (Target.InRange(c.GetPos(), t.GetPos()))
            {
                return GetChildTrue();

            }

            return this;
        }
    }

    class EatingNode : Node
    {
        public EatingNode(Node parentNode) : base(parentNode)
        {

        }
        public override Node Update(Customer c, out CustomerTarget t)
        {
            t = c.GetTarget;
            if (c.HasEaten)
            {
                return GetChildTrue();
            }

            return this;
        }
    }

    class WaitingNode : Node
    {
        public WaitingNode(Node parentNode) : base(parentNode)
        {

        }
        public override Node Update(Customer c, out CustomerTarget t)
        {
            Station s = CustomerSeating.AvailableSeat();
            if (s == null)
            {
                t = null;
                return this;
            }

            t = s;

            if (Target.InRange(c.GetPos(), t.GetPos()))
            {
                return GetChildTrue();

            }

            return this;
        }
    }

    class LeaveNode : Node
    {
        public LeaveNode(Node parentNode) : base(parentNode)
        {

        }

        public override Node Update(Customer c, out CustomerTarget t)
        {
            WorldExit worldExit = GameManager.ActiveArea.Exit; 
            t = worldExit;

            return this;
        }
    }
}
