using BowlingDesktopClient.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    internal interface ILaneService
    {
        // CRUD metoder for Lane
        Task<ApiResponse<List<Lane>>> GetLanesAsync();
        Task<ApiResponse<Lane>> CreateLaneAsync(Lane lane);
        Task<ApiResponse<Lane>> UpdateLaneAsync(int id, Lane lane);
        Task<ApiResponse<bool>> DeleteLaneAsync(int id);

      
    }
}
