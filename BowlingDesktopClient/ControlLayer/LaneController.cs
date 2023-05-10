using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ControlLayer
{
    internal class LaneController
    {
        private readonly ILaneService _apiService;

        public LaneController(ILaneService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<Lane>> GetAllLanesAsync()
        {
            ApiResponse<List<Lane>> response = await _apiService.GetLanesAsync();
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Lane> CreateLaneAsync(Lane lane)
        {
            ApiResponse<Lane> response = await _apiService.CreateLaneAsync(lane);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<Lane> UpdateLaneAsync(int id, Lane lane)
        {
            ApiResponse<Lane> response = await _apiService.UpdateLaneAsync(id, lane);
            if (response.IsSuccess)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        public async Task<bool> DeleteLaneAsync(int id)
        {
            ApiResponse<bool> response = await _apiService.DeleteLaneAsync(id);
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
