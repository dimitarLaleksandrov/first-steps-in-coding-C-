using BookingApp.Core.Contracts;
using BookingApp.Models.Bookings;
using BookingApp.Models.Hotels;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        private HotelRepository hotels;
        public Controller()
        {
            hotels = new HotelRepository();
        }

        public string AddHotel(string hotelName, int category)
        {
            var hotel = new Hotel(hotelName, category);
            var hotelIsExist = hotels.Select(hotelName);
            if (hotelIsExist != null)
            {
                return $"Hotel {hotelName} is already registered in our platform.";
            }
            hotels.AddNew(hotel);
            return $"{category} stars hotel {hotelName} is registered in our platform and expects room availability to be uploaded.";
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            if (!hotels.All().Any(h => h.Category == category))
            {
                return "{category} star hotel is not available in our platform.";
            }
            var bedsNeeded = adults + children;
            var allRooms = hotels.All().Select(r => r.Rooms.All().AsEnumerable()).Aggregate((c, n) => c.Concat(n));
            var room = allRooms
                .OrderBy(x => x.BedCapacity)
                .FirstOrDefault(r => r.BedCapacity >= bedsNeeded && r.PricePerNight > 0);
            if (room == null)
            {
                return "We cannot offer appropriate room for your request.";
            }

            var hotel = hotels.All().OrderBy(x => x.FullName).First(x => x.Rooms.Select(room.GetType().Name) != null);
            var bookingNumber = hotel.Bookings.All().Count() + 1;
            var booking = new Booking(room, duration, adults, children, bookingNumber);
            hotel.Bookings.AddNew(booking);

            return $"Booking number {bookingNumber} for {hotel.FullName} hotel is successful!";
        }

        public string HotelReport(string hotelName)
        {
            var hotel = hotels.Select(hotelName);
            if (hotel == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            var sb = new StringBuilder();
            sb.AppendLine($"Hotel name: {hotelName}");
            sb.AppendLine($"--{hotel.Category} star hotel");
            sb.AppendLine($"--Turnover: {hotel.Turnover:F2} $");
            sb.AppendLine($"--Bookings:");
            sb.AppendLine();
            var books = hotel.Bookings.All();
            if (books != null && books.Count > 0)
            {
                foreach (var book in books)
                {
                    sb.AppendLine(book.BookingSummary());
                }
            }
            else
            {
                sb.AppendLine($"none");
            }
            return sb.ToString();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            var hotelIsExist = hotels.Select(hotelName);
            var roomType = hotels.Select(hotelName).Rooms.GetType().Name == roomTypeName;
            var roomPriceSet = hotelIsExist.Rooms.Select(roomTypeName).PricePerNight == price;
            if (hotelIsExist == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            if (roomTypeName != "Apartment" && roomTypeName != "DoubleBed" && roomTypeName != "Studio")
            {
                throw new ArgumentException($"Incorrect room type!");
            }
            if (roomType)
            {
                return $"Room type is not created yet!";
            }
            if (roomPriceSet)
            {
                throw new InvalidOperationException($"Price is already set!");
            }
            hotelIsExist.Rooms.Select(roomTypeName).SetPrice(price);
            return $"Price of {roomTypeName} room type in {hotelName} hotel is set!";
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            if (roomTypeName != "Apartment" && roomTypeName != "DoubleBed" && roomTypeName != "Studio")
            {
                throw new ArgumentException($"Incorrect room type!");
            }
            var hotelIsExist = hotels.Select(hotelName);
            var roomType = hotels.Select(hotelName).Rooms.GetType().Name == roomTypeName;
            if (hotelIsExist == null)
            {
                return $"Profile {hotelName} doesn’t exist!";
            }
            if (roomType)
            {
                return $"Room type is already created!";
            }
            
            Room room = null;
            switch (roomTypeName)
            {
                case "Apartment":
                    room = new Apartment();
                    break;
                case "DoubleBed":
                    room = new DoubleBed();
                    break;
                case "Studio":
                    room = new Studio(); 
                    break;
                default:
                    break;
            }
            hotelIsExist.Rooms.AddNew(room);
            return $"Successfully added {roomTypeName} room type in {hotelName} hotel!";
        }
    }
}
