using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ControlLayer
{
    internal class BookingController
    {
        private readonly IBookingService _apiService;

        public BookingController(IBookingService apiService)
        {
            _apiService = apiService;
        }

        /*public async Task<List<Booking>> GetAllBookingsAsync()
        {
            ApiResponse<List<Booking>> response = await _apiService.GetBookingerAsync();
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }   */

        public async Task<Booking> CreateBookingAsync(Booking booking)
        {
            ApiResponse<Booking> response = await _apiService.CreateBookingAsync(booking);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Booking> UpdateBookingAsync(int id, Booking booking)
        {
            ApiResponse<Booking> response = await _apiService.UpdateBookingAsync(id, booking);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<bool> DeleteBookingAsync(int id)
        {
            ApiResponse<bool> response = await _apiService.DeleteBookingAsync(id);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        internal Task<List<Booking>?> GetAllBookingsAsync()
        {
            throw new NotImplementedException();
        }
    }
}

