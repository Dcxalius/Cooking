using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    static class Tree
    {
        static List<Node> nodes = new List<Node>();

        static AvailableSeatNode availableSeatNode = new AvailableSeatNode(null);
        static OrderingNode orderingNode = new OrderingNode(availableSeatNode);
        static GetWaitingSpotNode getWaitingSpotNode = new GetWaitingSpotNode(availableSeatNode);
        static EatingNode eatingNode = new EatingNode(orderingNode);
        static WaitingNode waitingNode = new WaitingNode(getWaitingSpotNode);
        static LeaveNode leaveNode = new LeaveNode(getWaitingSpotNode);

        public static Node StartNode
        {
            get => availableSeatNode;
        }
        public static void Init()
        {
            availableSeatNode.AddChildren(orderingNode, getWaitingSpotNode);
            getWaitingSpotNode.AddChildren(waitingNode, leaveNode);
            orderingNode.AddChildren(eatingNode, null);
            eatingNode.AddChildren(leaveNode, null);
        }
    }
}
