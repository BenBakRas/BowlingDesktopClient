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
        public async Task<List<Booking>?> FindBookingByPhone(string customerPNO)
        {
            List<Booking>? foundBookings = null;

            if (_bAccess != null)
            {
                foundBookings = await _bAccess.FindBookingsByCustomerPhone(customerPNO);
            }

            return foundBookings;
        }
    }
}
