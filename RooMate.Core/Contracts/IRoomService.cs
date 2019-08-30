using System.Collections.Generic;

namespace RooMate.Core.Contracts
{
    public interface IRoomService
    {
        IRoom GetRoom();
        IList<IRoom> GetRooms(); 
    }
}