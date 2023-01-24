using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;

namespace Cooking
{
    class Tile : GameObject
    {
        protected bool walkable = false;
        List<Tile> neighbours = new List<Tile>();
        Station station = null;


        public Tile(Vector2 pos) : base(pos)
        {

        }


        public bool AddStation(Station st)
        {
            walkable = false;
            if (station == null)
            {
                station = st;
                return true;
            }

            return false;
        }

        public Station RemoveStation()
        {
            if (station != null)
            {
                Station s = station;
                station = null;
                return s;
            }

            return null;
        }

        public bool Interact(Agent a, PickUp pickUp)
        {
            if (station != null)
            {
                return station.Interact(a, pickUp);

            }
            return false;
        }

        public void AddNeighbour(Tile t)
        {
            neighbours.Add(t);
            t.neighbours.Add(this);
        }

        public void RemoveNeighbour(Tile t)
        {
            if (neighbours.Contains(t))
            {
                neighbours.Remove(t);
                t.neighbours.Remove(this);
            }
        }
    }
}
