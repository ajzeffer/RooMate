using System;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Core.Domain
{
    
    public class Room: IRoom
    {
        #region // PROPS // 
        public string RoomName { get; private set; }
        public string RoomId { get; private set; }
        public int Capacity { get; private set; }
        public DateTime NextAvailableTime { get; private set; }
        public IRoomSchedule Schedule { get; private set; }
        #endregion 

        public static Room Create(IGraphSchedule schedule)
        {
            // build up the room with validation and addtl fields 
            return new Room
            {
                RoomName = GetRoomName(schedule.scheduleId),
                RoomId = schedule.scheduleId,
                Schedule = RoomSchedule.Create(schedule)
            };
        }
        public bool IsAvailable(DateTime start, double length )
        {
            var end = start.AddHours(length); 
            for (var i = 0; i < Schedule.ScheduleItems.Count; i++)
            {
                var schedItem = Schedule.ScheduleItems[i];
                if (!isTimeBlockAvailable(schedItem,start,end))
                    return false;
            }

            return true; 
        }

        public static bool isTimeBlockAvailable(IRoomScheduleItem scheduleItem, DateTime start, DateTime end)
        {
            var schedStart = DateTime.Parse(scheduleItem.start.dateTime);
            var schedEnd = DateTime.Parse(scheduleItem.end.dateTime);
            
            return !(isTimeBetween(schedStart, schedEnd,start)
                     || isTimeBetween(schedStart, schedEnd,end));
        }
        
        public static bool isTimeBetween(DateTime start, DateTime end, DateTime toCheck) =>
            toCheck >= start && toCheck <= end;

        public static string GetRoomName(string roomId)
        {
            var indexOfAt = roomId.IndexOf("@");
            return indexOfAt > 0 ? roomId.Substring(0, indexOfAt) : roomId;
        }
    }
}