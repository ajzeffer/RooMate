using System.Collections.Generic;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Core.Contracts
{
    public interface     IRoomService
    {
        IRoom GetRoom(IGraphSchedule schedule);
        IList<IRoom> GetRooms(); 
    }
}