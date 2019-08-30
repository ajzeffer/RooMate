using System.Collections.Generic;
using RooMate.Core.Contracts;
using RooMate.Core.Domain;

namespace RooMate.Core.Services
{
    public class RoomService : IRoomService
    {
        public IRoom GetRoom()
        {
            throw new System.NotImplementedException();
        }

        public IList<IRoom> GetRooms()
        {
            return new List<IRoom>
            {
                Room.Create(null)
            };
        }
    }
}