using BookingApp.Models.Rooms.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.Models.Rooms
{
    public abstract class Room : IRoom
    {
        public Room(int bedCapacity)
        {
            this.BedCapacity = bedCapacity;
            // set PricePerNight = 0;
        }

        public int BedCapacity {get; private set;}

        public double PricePerNight { get; private set;}
        // throw new ArgumentException("Price cannot be negative!");?????
        public void SetPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative!");
            }
            PricePerNight = price;
        }
    }
}
