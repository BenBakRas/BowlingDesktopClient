using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ControlLayer
{
    public class BookingControl
    {
        readonly IBookingAccess _bAccess;

        public BookingControl()
        {
            _bAccess = new BookingServiceAccess();
        }

        public async Task<List<Booking>?> GetAllBookings()
        {
            List<Booking>? foundBookings = null;
            if (_bAccess != null)
            {
                foundBookings = await _bAccess.GetBookings();

                foreach (Booking booking in foundBookings)
                {
                    Booking? foundByBookingId = await _bAccess.FindBookingById(booking.Id); // Find booking using booking ID

                    if (foundByBookingId != null)
                    {
                        booking.PriceId = foundByBookingId.PriceId; 
                        booking.LaneId = foundByBookingId.LaneId; 
                    }
                }
            }
            return foundBookings;
        }

        public async Task<int> SaveBooking(DateTime StartDateTime, int hoursToPlay, int noOfPlayers, Customer customer)
        {

            if (customer == null)
            {
                // Customer not found, handle the scenario as needed
                return -1;
            }

            Booking newBooking = new Booking(StartDateTime, hoursToPlay, noOfPlayers, customer);
            int insertedId = await _bAccess.SaveBooking(newBooking);
            return insertedId;
        }
        public async Task<List<Booking>?> FindBookingByCustomerPhone(string customerPNO)
        {
            List<Booking>? foundBookings = null;

            if (_bAccess != null)
            {
                foundBookings = await _bAccess.FindBookingsByCustomerPhone(customerPNO);

                foreach (Booking booking in foundBookings)
                {
                    Booking foundByBookingId = await _bAccess.FindBookingById(booking.Id); // Find booking using booking ID

                    if (foundByBookingId != null)
                    {
                        booking.PriceId = foundByBookingId.PriceId; // Update priceId
                        booking.LaneId = foundByBookingId.LaneId; // Update laneId
                    }
                }
            }

            return foundBookings;
        }

        public async Task<Booking?> FindBookingById(int bookingId)
        {
            Booking? foundBooking = null;

            if (_bAccess != null)
            {
                foundBooking = await _bAccess.FindBookingById(bookingId);
            }

            return foundBooking;
        }
        public async Task<bool> DeleteBooking(int bookingId)
        {
            bool isDeleted = false;

            if (_bAccess != null)
            {
                isDeleted = await _bAccess.DeleteBooking(bookingId);
            }

            return isDeleted;
        }
    }
}
