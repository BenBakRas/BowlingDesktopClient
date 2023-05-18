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

        /*public async Task<int> SaveBooking(int hoursToPlay, int noOfPlayers, Customer? cutomer)
        {
            Booking newBooking = new(hoursToPlay, noOfPlayers, cutomer);
            int insertedId = await _bAccess.SaveBooking(newBooking);
            return insertedId;
        }*/
    }
}
