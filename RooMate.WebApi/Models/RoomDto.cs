using System;
using System.Collections.Generic;
using RooMate.Core.Contracts;

namespace RooMate.WebApi.Models
{
    public class RoomDto : RoomBaseDto
    {

        public IList<SimpleSchedule> SimpleSchedule { get;  private set; }

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
    }
}