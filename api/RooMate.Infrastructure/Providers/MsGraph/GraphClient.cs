﻿using System;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Infrastructure.Providers.MsGraph
{
    public class GraphClient : IGraphClient
    {
        public IGraphRoomSchedules GetRoomSchedules()
        {
            throw new NotImplementedException();
        }

        public IGraphSchedule GetRoomSchedule(string roomid)
        {
            throw new NotImplementedException();
        }
    }
}