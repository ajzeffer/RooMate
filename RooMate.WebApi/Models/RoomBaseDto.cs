using System;
using System.Collections.Generic;
using System.Linq;
using RooMate.Core.Contracts;

namespace RooMate.WebApi.Models
{
    public class RoomBaseDto
    {
        public string RoomName { get;   }
        public string RoomId { get;   }
        public bool IsAvailableNow { get; private set; }

        internal  RoomBaseDto(IRoom room )
        {
            RoomName = room.RoomName;
            RoomId = room.RoomId;
            IsAvailableNow = CheckAvailableNow(room);
        }

        protected static IList<SimpleSchedule> ConvertToSimpleSchedule(IEnumerable<IRoomScheduleItem> roomSched) =>
            roomSched.Select(x => new SimpleSchedule(x.start.dateTime, x.end.dateTime)).ToList();

        protected static bool CheckAvailableNow(IRoom room) => room.IsAvailable(DateTime.Now, .5);
    }

    public class SimpleSchedule
    {
        public string start { get;   }
        public string end { get;  }

        public SimpleSchedule(string startDateTime, string endDateTime )
        {
            start = startDateTime;
            end = endDateTime;
        }
    }
}