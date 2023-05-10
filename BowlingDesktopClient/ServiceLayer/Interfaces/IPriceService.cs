using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    internal interface IPriceService
    {
        // CRUD metoder for Price
        Task<ApiResponse<List<Price>>> GetPricesAsync();
        Task<ApiResponse<Price>> CreatePriceAsync(Price price);
        Task<ApiResponse<Price>> UpdatePriceAsync(int id, Price price);
        Task<ApiResponse<bool>> DeletePriceAsync(int id);

        
    }
}
