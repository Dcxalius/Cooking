using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    class PlayArea
    {
        Tile[,] tiles;
        WorldEntrance entrence; //Make tile?
        WorldExit exit; 

        public WorldEntrance Entrance
        {
            get => entrence;
        }
        public WorldExit Exit
        {
            get => exit;
        }
    
        public PlayArea(Point p)
        {
            tiles = new Tile[p.X, p.Y];
            Road r = CreateRoad(new Point(0, RandomManager.RandomRange(3, 5)));
            entrence = new WorldEntrance(new Vector2(0));
            r.AddStation(entrence);
            Road r2 = CreateRoad(new Point(p.X - 1, RandomManager.RandomRange(3, 5)));
            exit = new WorldExit(p.ToVector2());
            r.AddStation(exit);

            //Make snake from entrance to exit

            //Make all tiles that is above or to the left of snake Ground if angle between r1 and r2 is value
                //If that angle is bellow or above a threshold make all tiles above and to the right
            //Make all tiles opposite that floor



            //for (int i = 0; i < tiles.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tiles.GetLength(1); j++)
            //    {
            //        tiles[i, j] = new Ground(new Vector2(64*i, 64*j));

            //    }
            //}

            for (int i = 0; i < tiles.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j].AddNeighbour(tiles[i + 1, j]);
                }
            }

            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1) - 1; j++)
                {
                    tiles[i, j].AddNeighbour(tiles[i, j + 1]);
                }
            }
        }

        public Road CreateRoad(Point p)
        {
            tiles[p.X, p.Y] = new Road(p.ToVector2() * 64);
            return (Road)tiles[p.X, p.Y];
        }

        public void Update()
        {
            foreach (Tile tile in tiles)
            {
                tile.Update();
            }
        }

        public void Draw(SpriteBatch batch)
        {
            foreach (Tile tile in tiles)
            {
                tile.Draw(batch);
            }
        }
    }
}
