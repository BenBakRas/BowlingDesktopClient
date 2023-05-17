using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    public class BowlingBookingService : IBookingService
    {
        private readonly HttpClient httpClient;

        public BowlingBookingService()
        {
            httpClient = HttpClientHelper.GetHttpClient();
        }

        // Metode til at hente en liste over bookinger
        public async Task<ApiResponse<List<Booking>>> GetBookingerAsync()
        {
            ApiResponse<List<Booking>> response = new ApiResponse<List<Booking>>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync("api/bookings");

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<List<Booking>>();
                    response.IsSuccess = true;
                }
                else
                {
                    response.ErrorMessage = $"Error: {httpResponse.StatusCode}";
                }
            }
            catch (Exception e)
            {
                response.ErrorMessage = $"Error: {e.Message}";
            }

            return response;
        }
        // Create metode for Booking
        public async Task<ApiResponse<Booking>> CreateBookingAsync(Booking booking)
        {
            ApiResponse<Booking> response = new ApiResponse<Booking>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsJsonAsync("api/bookings", booking);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Booking>();
                    response.IsSuccess = true;
                }
                else
                {
                    response.ErrorMessage = $"Error: {httpResponse.StatusCode}";
                }
            }
            catch (Exception e)
            {
                response.ErrorMessage = $"Error: {e.Message}";
            }

            return response;
        }

        // Update metode for Booking
        public async Task<ApiResponse<Booking>> UpdateBookingAsync(int id, Booking booking)
        {
            ApiResponse<Booking> response = new ApiResponse<Booking>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PutAsJsonAsync($"api/bookings/{id}", booking);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Booking>();
                    response.IsSuccess = true;
                }
                else
                {
                    response.ErrorMessage = $"Error: {httpResponse.StatusCode}";
                }
            }
            catch (Exception e)
            {
                response.ErrorMessage = $"Error: {e.Message}";
            }

            return response;
        }

        // Delete metode for Booking
        public async Task<ApiResponse<bool>> DeleteBookingAsync(int id)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.DeleteAsync($"api/bookings/{id}");

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = true;
                    response.IsSuccess = true;
                }
                else
                {
                    response.ErrorMessage = $"Error: {httpResponse.StatusCode}";
                }
            }
            catch (Exception e)
            {
                response.ErrorMessage = $"Error: {e.Message}";
            }

            return response;
        }
    }
}
