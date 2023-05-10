using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    internal class BowlingPriceApiService : IPriceService
    {
        private readonly HttpClient httpClient;

        public BowlingPriceApiService()
        {
            httpClient = HttpClientHelper.GetHttpClient();
        }

        // Metode til at hente en liste over priser
        public async Task<ApiResponse<List<Price>>> GetPricesAsync()
        {
            ApiResponse<List<Price>> response = new ApiResponse<List<Price>>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync("api/prices");

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<List<Price>>();
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

        // Create metode for Price
        public async Task<ApiResponse<Price>> CreatePriceAsync(Price price)
        {
            ApiResponse<Price> response = new ApiResponse<Price>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsJsonAsync("api/prices", price);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Price>();
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

        // Update metode for Price
        public async Task<ApiResponse<Price>> UpdatePriceAsync(int id, Price price)
        {
            ApiResponse<Price> response = new ApiResponse<Price>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PutAsJsonAsync($"api/prices/{id}", price);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Price>();
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

        // Delete metode for Price
        public async Task<ApiResponse<bool>> DeletePriceAsync(int id)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.DeleteAsync($"api/prices/{id}");

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

