using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface IPriceAccess
    {
        Task<List<Price>?>? GetPrices(int id = -1);
        Task<int> SavePrice(Price priceToSave);
        Task<Price?> FindPriceById(int priceId);
        Task<bool> UpdatePrice(int id, Price priceToUpdate);
        Task<bool> DeletePrice(int id);

    }
}
