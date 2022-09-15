using BookingApp.Models.Bookings.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.Repositories
{
    public class BookingRepository : IRepository<IBooking>
    {
        private readonly List<IBooking> booking;
        public BookingRepository()
        {
            booking = new List<IBooking>();
        }
        public void AddNew(IBooking model)
        {
            booking.Add(model);
        }

        public IReadOnlyCollection<IBooking> All()
        {
            return booking.AsReadOnly();
        }

        public IBooking Select(string criteria)
        {
            return booking.FirstOrDefault(b => b.BookingNumber.ToString() == criteria);
        }
    }
}
