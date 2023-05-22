using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using BowlingDesktopClient.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ControlLayer
{
    public class PriceControl
    {
        readonly IPriceAccess _pAccess;

        public PriceControl()
        {
            _pAccess = new PriceServiceAccess();
        }

        public async Task<List<Price>?> GetAllPrices()
        {
            List<Price>? foundPrices = null;
            if (_pAccess != null)
            {
                foundPrices = await _pAccess.GetPrices();
            }
            return foundPrices;
        }

        public async Task<int> SavePrice(double? normalPrice, double? specialPrice, string? weekday)
        {
            Price newPrice = new(normalPrice, specialPrice, weekday);
            int insertedId = await _pAccess.SavePrice(newPrice);
            return insertedId;
        }

        public async Task<Price?> FindPriceById(int priceId)
        {
            Price? foundPrice = null;

            if (_pAccess != null)
            {
                foundPrice = await _pAccess.FindPriceById(priceId);
            }

            return foundPrice;
        }
        public async Task<bool> UpdatePrice(int id, Price priceToUpdate)
        {
            bool isUpdated = false;

            if (_pAccess != null)
            {
                isUpdated = await _pAccess.UpdatePrice(id, priceToUpdate);
            }

            return isUpdated;
        }

        public async Task<bool> DeletePrice(int id)
        {
            bool isDeleted = false;

            if (_pAccess != null)
            {
                isDeleted = await _pAccess.DeletePrice(id);
            }

            return isDeleted;
        }
    }
}
