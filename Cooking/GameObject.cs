using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;

namespace Cooking
{

    public enum Object
    {
        //Agents
        Chef,
        Customer,

        Counter,//stations
        Oven,
        WorldEntrance,
        WorldExit, 

        Lettuce, //pickups
        ChoppedLettuce,
        Plate,

        Ground, //tile
        Floor,
        Road,

        Count //end
    }

    public enum ArtType
    {
        Agent,
        Station,
        Pickup,
        Tile
    }

    class GameObject
    {
        protected ArtType artType;
        protected Texture2D texture2D;
        protected Vector2 pos;
        protected Object identity;
        protected Rectangle size;
        protected float rotation;
        public Vector2 GetPos()
        {
            return pos;
        }

        public GameObject(Vector2 p)
        {
            texture2D = TextureManager.GetTexture(identity);
            pos = p;
        }

        protected virtual void Init(Texture2D aTexture2D) { }
        
        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch aBatch)
        {
            aBatch.Draw(
                texture2D,
                pos,
                size,
                Color.White,
                rotation,
                new Vector2(size.X / 2f, size.Y / 2f),
                1f,
                SpriteEffects.None,
                1f
                ) ;
            
        }
    }
}
