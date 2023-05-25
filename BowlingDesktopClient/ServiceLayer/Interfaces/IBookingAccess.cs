using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface IBookingAccess
    {
        Task<List<Booking>?>? GetBookings(int id = -1);
        Task<int> SaveBooking(Booking bookingToSave);
        Task<List<Booking>?> FindBookingsByCustomerPhone(string phone);
        Task<Booking?> FindBookingById(int id);
    }
}
