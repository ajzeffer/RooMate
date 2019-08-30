using System;

namespace RooMate.Core.Contracts
{
    public interface IRoom
    {
        string RoomName { get; }
        string RoomId { get;  }
        int Capacity { get;  }
        DateTime NextAvailableTime { get;  }
        bool IsAvailable { get; }
        IRoomSchedule Schedule { get; }
        
    }
}