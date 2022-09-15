using FrontDeskApp;
using NUnit.Framework;
using System;
using System.Numerics;
using System.Xml.Linq;

namespace BookigApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4, 50)]
        public void TestRoomConstruktorSet(int bedCapacity, double pricePerNight)
        {
            var room = new Room(bedCapacity, pricePerNight);
            Assert.AreEqual(bedCapacity, room.BedCapacity);
            Assert.AreEqual(pricePerNight, room.PricePerNight);
        }
        [TestCase(0, 50)]
        [TestCase(-4, 30)]
        public void TestRoomBedCapacityShudThrowException(int bedCapacity, double pricePerNight)
        {
            
            Assert.Throws<ArgumentException>(() =>
            {
                var room = new Room(bedCapacity, pricePerNight);
            }
             );
        }
        [TestCase(4, 0)]
        [TestCase(3, -6)]
        public void TestRoomBedPricePerNightShudThrowException(int bedCapacity, double pricePerNight)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var room = new Room(bedCapacity, pricePerNight);
            }
             );
        }

        [TestCase(2, 20)]
        public void TestBookingConstruktorSet(int bookingNumber, int residenceDuration)
        {
            var room = new Room(4, 20);
            var booking = new Booking(bookingNumber, room, residenceDuration);
            Assert.AreEqual(bookingNumber, booking.BookingNumber);
            Assert.AreEqual(room, booking.Room);
            Assert.AreEqual(residenceDuration, booking.ResidenceDuration);
        }
        [TestCase("Osaka", 3)]
        public void TestHotelConstruktorSet(string fullName, int category)
        {
            var hotel = new Hotel(fullName, category);
            Assert.AreEqual(hotel.FullName, fullName);
            Assert.AreEqual(hotel.Category, category);
        }
        [TestCase("  ", 3)]
        [TestCase(null, 2)]
        public void TestHotelFullNameShudThrowException(string fullName, int category)
        {

            Assert.Throws<ArgumentNullException>(() =>
            {
                var hotel = new Hotel(fullName, category);
            }
             );
        }
        [TestCase("Osaka", 0)]
        [TestCase("Osaka", 6)]
        [TestCase("Osaka", -1)]
        public void TestHotelCategoryShudThrowException(string fullName, int category)
        {

            Assert.Throws<ArgumentException>(() =>
            {
                var hotel = new Hotel(fullName, category);
            }
             );
        }
        [TestCase("Osaka", 3)]
        public void TestHotelTurnover(string fullName, int category)
        {
            var hotel = new Hotel(fullName, category);
            var expektedNum = 0;
            Assert.AreEqual(hotel.Turnover, expektedNum);
        }
        [TestCase("Osaka", 3)]
        public void TestHotelRooms(string fullName, int category)
        {
            var hotel = new Hotel(fullName, category);
            var room1 = new Room(3, 20);
            var room2 = new Room(2, 10);
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            var expektedRoomCount = 2;
            Assert.AreEqual(hotel.Rooms.Count, expektedRoomCount);
        }
        [TestCase("Osaka", 3)]
        public void TestHotelBookings(string fullName, int category)
        {
            var hotel = new Hotel(fullName, category);
            var room = new Room(5, 10);
            hotel.AddRoom(room);
            hotel.BookRoom(2, 2, 5, 50);
            hotel.BookRoom(1, 1, 3, 30);
            var expektedBookCount = 2;
            Assert.AreEqual(hotel.Bookings.Count, expektedBookCount);
        }
        [TestCase(0, 2, 5, 50)]
        [TestCase(-1, 1, 5, 50)]
        public void TestHotelBookingsAdultsShudThrowException(int adults, int children, int residenceDuration, double budget)
        {
            var hotel = new Hotel("Osaka", 3);
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, residenceDuration, budget);
            }
            );                 
        }
        [TestCase(2, -1, 5, 50)]
        [TestCase(1, -5, 5, 50)]
        public void TestHotelBookingsChildrenShudThrowException(int adults, int children, int residenceDuration, double budget)
        {
            var hotel = new Hotel("Osaka", 3);
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, residenceDuration, budget);
            }
            );
        }
        [TestCase(2, 2, 0, 50)]
        [TestCase(1, 1, -5, 50)]
        public void TestHotelBookingSresidenceDurationShudThrowException(int adults, int children, int residenceDuration, double budget)
        {
            var hotel = new Hotel("Osaka", 3);
            Assert.Throws<ArgumentException>(() =>
            {
                hotel.BookRoom(adults, children, residenceDuration, budget);
            }
            );
        }
    }
}