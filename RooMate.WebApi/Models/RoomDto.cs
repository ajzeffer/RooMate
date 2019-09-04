using System;
using System.Collections.Generic;
using RooMate.Core.Contracts;

namespace RooMate.WebApi.Models
{
    public class RoomDto : RoomBaseDto
    {
        public bool IsAvailableAtTime { get; private set; }
        public DateTime RequestedTime { get; private set; }
        public IList<Tuple<string, string>> SimpleSchedule { get;  private set; }

        private RoomDto(IRoom room) : base(room)
        {
            
        }
       
        public static RoomDto Create(IRoom room)
        {
            return new RoomDto(room)
            {
                SimpleSchedule = ConvertToSimpleSchedule(room.Schedule.ScheduleItems)
            };
        }
        public static RoomDto Create(IRoom room, DateTime requestedTime, int meetingLength)
        {
            return new RoomDto(room)
            {
                RequestedTime = requestedTime,
                IsAvailableAtTime = room.IsAvailable(requestedTime, meetingLength),
                SimpleSchedule = ConvertToSimpleSchedule(room.Schedule.ScheduleItems)
            };
        }
    }
}