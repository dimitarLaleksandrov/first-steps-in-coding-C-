using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.Repositories
{
    public class BookingRepository : IRepository<IBooking>
    {
       
        private readonly List<IBooking> bookings = new List<IBooking>();

        public void AddNew(IBooking model)
        {
            this.bookings.Add(model);
        }

        public IReadOnlyCollection<IBooking> All()
        {
            return this.bookings.AsReadOnly();
        }

        public IBooking Select(string criteria)
        {
            return this.bookings.FirstOrDefault(x => x.BookingNumber.ToString() == criteria);
        }
    }
}
