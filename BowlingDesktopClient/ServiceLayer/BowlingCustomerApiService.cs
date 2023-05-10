using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    internal class BowlingCustomerApiService : ICustomerService
    {
        private readonly HttpClient httpClient;

        public BowlingCustomerApiService()
        {
            httpClient = HttpClientHelper.GetHttpClient();
        }

        // Metode til at hente en liste over kunder
        public async Task<ApiResponse<List<Customer>>> GetCustomersAsync()
        {
            ApiResponse<List<Customer>> response = new ApiResponse<List<Customer>>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync("api/customers");

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<List<Customer>>();
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

        // Create metode for Customer
        public async Task<ApiResponse<Customer>> CreateCustomerAsync(Customer customer)
        {
            ApiResponse<Customer> response = new ApiResponse<Customer>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsJsonAsync("api/customers", customer);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Customer>();
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

        // Update metode for Customer
        public async Task<ApiResponse<Customer>> UpdateCustomerAsync(int id, Customer customer)
        {
            ApiResponse<Customer> response = new ApiResponse<Customer>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PutAsJsonAsync($"api/customers/{id}", customer);

                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Data = await httpResponse.Content.ReadAsAsync<Customer>();
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

        // Delete metode for Customer
        public async Task<ApiResponse<bool>> DeleteCustomerAsync(int id)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            try
            {
                HttpResponseMessage httpResponse = await httpClient.DeleteAsync($"api/customers/{id}");

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

