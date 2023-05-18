using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    internal class PriceServiceAccess : IPriceAccess
    {
        readonly IServiceConnection _priceService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/customers";
        public PriceServiceAccess()
        {
            _priceService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Price>?>? GetPrices(int id = -1)
        {
            List<Price>? pricesFromService = null;

            _priceService.UseUrl = _priceService.BaseUrl;
            bool hasValidId = (id > 0);
            if (hasValidId)
            {
                _priceService.UseUrl += id.ToString();
            }
            if (_priceService != null)
            {
                try
                {
                    var serviceResponse = await _priceService.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        if (hasValidId)
                        {
                            Price? foundPrice = JsonConvert.DeserializeObject<Price>(content);
                            if (foundPrice != null)
                            {
                                pricesFromService = new List<Price>() { foundPrice };
                            }
                        }
                        else
                        {
                            pricesFromService = JsonConvert.DeserializeObject<List<Price>>(content);
                        }
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            pricesFromService = new List<Price>();
                        }
                        else
                        {
                            pricesFromService = null;
                        }
                    }
                }
                catch
                {
                    pricesFromService = null;
                }
            }
            return pricesFromService;
        }
        public async Task<int> SavePrice(Price priceToSave)
        {
            int insertedPriceId = -1;
            //
            _priceService.UseUrl = _priceService.BaseUrl;
            try
            {
                var json = JsonConvert.SerializeObject(priceToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _priceService.CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse.IsSuccessStatusCode)
                {
                    if (serviceResponse.IsSuccessStatusCode)
                    {
                        string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                        Int32.TryParse(resIdString, out insertedPriceId);
                    }
                    else
                    {
                        insertedPriceId = -2;
                    }
                }
            }
            catch
            {
                insertedPriceId = -3;
            }
            return insertedPriceId;
        }
    }
}
