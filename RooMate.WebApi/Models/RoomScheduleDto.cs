using System;
using RooMate.Core.Contracts;

namespace RooMate.WebApi.Models
{
    public class RoomScheduleDto : RoomBaseDto
    {
        public bool IsAvailableAtTime { get; private set; }
        public DateTime RequestedTime { get; private set; }
        internal RoomScheduleDto(IRoom room) : base(room)
        {
        }

        public static RoomScheduleDto Create(IRoom room, DateTime requestedTime, int meetingLength)
        {
            return new RoomScheduleDto(room)
            {
                RequestedTime = requestedTime,
                IsAvailableAtTime = room.IsAvailable(requestedTime, meetingLength),
            };
        }
    }
}