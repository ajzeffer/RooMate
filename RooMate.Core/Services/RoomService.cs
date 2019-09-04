using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;
using RooMate.Core.Domain;

namespace RooMate.Core.Services
{
    
    public class RoomService : IRoomService
    {
        private IGraphClient _graphClient; 
        public RoomService(IGraphClient graphClient)
        {
            _graphClient = graphClient; 
        }
       // public IRoom GetRoom(IGraphSchedule schedule) =>  Room.Create(schedule);
        public IRoom GetRoom(string roomId)
        {
            var graphSched = _graphClient.GetRoomSchedule(roomId);
            return Room.Create(graphSched); 
        }
        public IEnumerable<IRoom> GetRooms()
        {
            var rooms = _graphClient.GetRoomSchedules();
            return rooms.value.Select(room => Room.Create(room));
        }
    }
}