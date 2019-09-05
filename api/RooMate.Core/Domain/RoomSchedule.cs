using System.Collections.Generic;
using System.Linq;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Core.Domain
{
    public class RoomSchedule : IRoomSchedule
    {
        public IList<IRoomScheduleItem> ScheduleItems { get; set; }

        public static IRoomSchedule Create(IGraphSchedule sched)
        {
            var roomSched =  new RoomSchedule
            {
                ScheduleItems = new List<IRoomScheduleItem>()
            };
            roomSched.ScheduleItems = sched.scheduleItems.Select(RoomScheduleItem.Create).ToList();
            return roomSched; 
        }
    }
}