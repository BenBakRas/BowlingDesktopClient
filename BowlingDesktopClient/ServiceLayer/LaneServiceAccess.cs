using BowlingDesktopClient.Models;
using BowlingDesktopClient.ServiceLayer.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer
{
    public class LaneServiceAccess : ILaneAccess
    {
        readonly IServiceConnection _LaneService;
        readonly String _serviceBaseUrl = "https://localhost:7197/api/customers";
        public LaneServiceAccess()
        {
            _LaneService = new ServiceConnection(_serviceBaseUrl);
        }

        public async Task<List<Lane>?>? GetLanes(int id = -1)
        {
            List<Lane>? lanesFromService = null;

            _LaneService.UseUrl = _LaneService.BaseUrl;
            bool hasValidId = (id > 0);
            if (hasValidId)
            {
                _LaneService.UseUrl += id.ToString();
            }
            if (_LaneService != null)
            {
                try
                {
                    var serviceResponse = await _LaneService.CallServiceGet();
                    bool wasResponse = (serviceResponse != null);
                    if (wasResponse && serviceResponse.IsSuccessStatusCode)
                    {
                        var content = await serviceResponse.Content.ReadAsStringAsync();
                        if (hasValidId)
                        {
                            Lane? foundLane = JsonConvert.DeserializeObject<Lane>(content);
                            if (foundLane != null)
                            {
                                lanesFromService = new List<Lane>() { foundLane };
                            }
                        }
                        else
                        {
                            lanesFromService = JsonConvert.DeserializeObject<List<Lane>>(content);
                        }
                    }
                    else
                    {
                        if (wasResponse && serviceResponse.StatusCode == System.Net.HttpStatusCode.NoContent)
                        {
                            lanesFromService = new List<Lane>();
                        }
                        else
                        {
                            lanesFromService = null;
                        }
                    }
                }
                catch
                {
                    lanesFromService = null;
                }
            }
            return lanesFromService;
        }
        public async Task<int> SaveLane(Lane laneToSave)
        {
            int insertedLaneId = -1;
            //
            _LaneService.UseUrl = _LaneService.BaseUrl;
            try
            {
                var json = JsonConvert.SerializeObject(laneToSave);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var serviceResponse = await _LaneService.CallServicePost(content);
                bool wasResponse = (serviceResponse != null);
                if (wasResponse && serviceResponse.IsSuccessStatusCode)
                {
                    if (serviceResponse.IsSuccessStatusCode)
                    {
                        string resIdString = await serviceResponse.Content.ReadAsStringAsync();
                        Int32.TryParse(resIdString, out insertedLaneId);
                    }
                    else
                    {
                        insertedLaneId = -2;
                    }
                }
            }
            catch
            {
                insertedLaneId = -3;
            }
            return insertedLaneId;
        }
    }
}
