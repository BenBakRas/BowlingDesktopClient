using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ControlLayer
{
    internal class CustomerController
    {
        private readonly ICustomerService _apiService;

        public CustomerController(ICustomerService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            ApiResponse<List<Customer>> response = await _apiService.GetCustomersAsync();
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Customer> CreateCustomerAsync(Customer customer)
        {
            ApiResponse<Customer> response = await _apiService.CreateCustomerAsync(customer);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Customer> UpdateCustomerAsync(int id, Customer customer)
        {
            ApiResponse<Customer> response = await _apiService.UpdateCustomerAsync(id, customer);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            ApiResponse<bool> response = await _apiService.DeleteCustomerAsync(id);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }
    }
}
