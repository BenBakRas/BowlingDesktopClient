using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ControlLayer
{
    internal class PriceController
    {
        private readonly IPriceService _apiService;

        public PriceController(IPriceService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<Price>> GetAllPricesAsync()
        {
            ApiResponse<List<Price>> response = await _apiService.GetPricesAsync();
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Price> CreatePriceAsync(Price price)
        {
            ApiResponse<Price> response = await _apiService.CreatePriceAsync(price);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Price> UpdatePriceAsync(int id, Price price)
        {
            ApiResponse<Price> response = await _apiService.UpdatePriceAsync(id, price);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<bool> DeletePriceAsync(int id)
        {
            ApiResponse<bool> response = await _apiService.DeletePriceAsync(id);
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
