using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface IBookingService
    {
        // CRUD metoder for Booking
        Task<ApiResponse<List<Booking>>> GetBookingerAsync();
        Task<ApiResponse<Booking>> CreateBookingAsync(Booking booking);
        Task<ApiResponse<Booking>> UpdateBookingAsync(int id, Booking booking);
        Task<ApiResponse<bool>> DeleteBookingAsync(int id);

     
    }
}
