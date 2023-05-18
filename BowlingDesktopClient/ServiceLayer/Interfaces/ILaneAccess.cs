﻿using BowlingDesktopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingDesktopClient.ServiceLayer.Interfaces
{
    public interface ILaneAccess
    {
        Task<List<Lane>?>? GetLanes(int id = -1);
        Task<int> SaveLane(Lane LaneToSave);
    }
}
