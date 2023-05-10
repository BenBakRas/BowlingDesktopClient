using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    internal class BowlingLaneApiService : ILaneService
    {
        private readonly HttpClient httpClient;

        public BowlingLaneApiService()
        {
            httpClient = HttpClientHelper.GetHttpClient();
        }

        // Metode til at hente en liste over baner
        public async Task<ApiResponse<List<Lane>>> GetLanesAsync()
        {
            ApiResponse<List<Lane>> response = new ApiResponse<List<Lane>>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync("api/lanes");

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<List<Lane>>();
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

        // Create metode for Lane
        public async Task<ApiResponse<Lane>> CreateLaneAsync(Lane lane)
        {
            ApiResponse<Lane> response = new ApiResponse<Lane>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsJsonAsync("api/lanes", lane);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Lane>();
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

        // Update metode for Lane
        public async Task<ApiResponse<Lane>> UpdateLaneAsync(int id, Lane lane)
        {
            ApiResponse<Lane> response = new ApiResponse<Lane>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PutAsJsonAsync($"api/lanes/{id}", lane);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Lane>();
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

        // Delete metode for Lane
        public async Task<ApiResponse<bool>> DeleteLaneAsync(int id)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.DeleteAsync($"api/lanes/{id}");

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

