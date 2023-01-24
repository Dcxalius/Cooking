using System;
using System.Collections.Generic;
using System.Text;

namespace Cooking
{
    static class CustomerSeating
    {
        static List<Station> availableSeats;
        static List<Station> waitingSeats;

        public static Station AvailableSeat()
        {
            if (availableSeats.Count == 0)
            {
                return null;
            }

            Station s = availableSeats[0];
            availableSeats.RemoveAt(0);
            return s;
        }

        public static Station AvailableWaitingSeat()
        {
            if (waitingSeats.Count == 0)
            {
                return null;
            }

            Station s = availableSeats[0];
            availableSeats.RemoveAt(0);
            return s;
        }

        public static void AddSeat(Station s)
        {
            availableSeats.Add(s);
        }

        public static void AddWaitingSeat(Station s)
        {
            waitingSeats.Add(s);
        }

        public static void Update()
        {
            for (int i = 0; i < availableSeats.Count; i++)
            {
                availableSeats[i].Update();
            }

            for (int i = 0; i < waitingSeats.Count; i++)
            {
                waitingSeats[i].Update();
            }
        }

        public static void Draw()
        {
            for (int i = 0; i < availableSeats.Count; i++)
            {
                availableSeats[i].Update();
            }
            for (int i = 0; i < waitingSeats.Count; i++)
            {
                waitingSeats[i].Update();
            }
        }
    }
}
