using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class PickUp : GameObject
    {

        string name;

        public string Name
        {
            get => name;

        }

        public PickUp(Vector2 pos) : base(pos)
        {
            artType = ArtType.Pickup;

            name = identity.ToString();
        }

        public void Move(Vector2 aPos)
        {
            pos = aPos;
        }

        public void MoveBy(Vector2 aMove)
        {
            pos += aMove;
        }


    }
}
