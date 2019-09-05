using System;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Core.Domain
{
    public class RoomScheduleTime : IRoomScheduleTime
    {
        public string dateTime { get; set; }
        public string timeZone { get; set; }

        public static IRoomScheduleTime Create(IGraphScheduleTime scheduleTime)
        {
            return new RoomScheduleTime
            {
                dateTime = scheduleTime?.datetime ?? "",
                timeZone = scheduleTime?.timeZone ?? ""
            };
        }
        public static IRoomScheduleTime Create(DateTime dateTime, string timeZone)
        {
            return new RoomScheduleTime
            {
                dateTime = dateTime.ToString(),
                timeZone = timeZone
            };
        }
    }
}