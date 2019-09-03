using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Core.Domain
{
    public class RoomScheduleItem : IRoomScheduleItem
    {
        public string status { get; set; }
        public IRoomScheduleTime start { get; set; }
        public IRoomScheduleTime end { get; set; }

        public static  IRoomScheduleItem Create(IGraphScheduleItem scheduleItem)
        {
            return new RoomScheduleItem
            {
                status = scheduleItem.status,
                start = RoomScheduleTime.Create(scheduleItem.start),
                end = RoomScheduleTime.Create(scheduleItem.end)
            };
        }
    }
}