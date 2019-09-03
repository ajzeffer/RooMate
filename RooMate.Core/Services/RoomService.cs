using System.Collections.Generic;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;
using RooMate.Core.Domain;

namespace RooMate.Core.Services
{
    
    public class RoomService : IRoomService
    {
        
       // public IRoom GetRoom(IGraphSchedule schedule) =>  Room.Create(schedule);
        public IRoom GetRoom(IGraphSchedule schedule) =>  Room.Create(schedule);

        public IList<IRoom> GetRooms()
        {
            return new List<IRoom>
            {
                Room.Create(null)
            };
        }
    }
}