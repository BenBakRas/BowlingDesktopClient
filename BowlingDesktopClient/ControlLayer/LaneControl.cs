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
    public class LaneControl
    {
        readonly ILaneAccess _lAccess;

        public LaneControl()
        {
            _lAccess = new LaneServiceAccess();
        }

        public async Task<List<Lane>?> GetAllLanes()
        {
            List<Lane>? foundLanes = null;
            if (_lAccess != null)
            {
                foundLanes = await _lAccess.GetLanes();
            }
            return foundLanes;
        }

        public async Task<int> SaveLane(int LaneNumber)
        {
            Lane newLane = new(LaneNumber);
            int insertedId = await _lAccess.SaveLane(newLane);
            return insertedId;
        }
    }
}
