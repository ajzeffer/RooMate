using System;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Core.Domain
{
    
    public class Room: IRoom
    {
        public static Room Create(IGraphSchedule schedule)
        {
            // build up the room with validation and addtl fields 
            return new Room();
        }

        public string RoomName { get; private set; }
        public string RoomId { get; private set; }
        public int Capacity { get; private set; }
        public DateTime NextAvailableTime { get; private set; }
        public bool IsAvailable { get; private set; }
        public IRoomSchedule Schedule { get; private set; }
    }
}