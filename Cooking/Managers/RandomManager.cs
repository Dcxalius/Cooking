using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    static class RandomManager
    {
        static Random random = new Random();

        public static double RandomDouble
        {
            get
            {
                return random.NextDouble();
            }
        }

        public static int RandomRange(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
