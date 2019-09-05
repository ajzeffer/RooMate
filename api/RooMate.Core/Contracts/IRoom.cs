using System;

namespace RooMate.Core.Contracts
{
    public interface IRoom
    {
        string RoomName { get; }
        string RoomId { get;  }
        int Capacity { get;  }
        DateTime NextAvailableTime { get;  }
        bool IsAvailable(DateTime start, double length);
        IRoomSchedule Schedule { get; }
        
    }
}