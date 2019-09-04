using System;
using System.Collections.Generic;
using RooMate.Core.Domain;

namespace RooMate.Core.Contracts.Graph
{
    public interface IGraphClient
    {
        IGraphRoomSchedules GetRoomSchedules();
        IGraphSchedule GetRoomSchedule(string roomid);
    }
    public interface IGraphRoomSchedules {
        IList<IGraphSchedule>  value { get; set; }
    }

    public interface  IGraphSchedule {
        string scheduleId { get; set; }
        string availabilityView { get; set; }
        IList<IGraphScheduleItem> scheduleItems { get; set; }
    }

    public interface IGraphScheduleItem
    {
         string    status { get; set; }
         IGraphScheduleTime  start { get; set; }
         IGraphScheduleTime  end { get; set; }
    }
    public interface IGraphScheduleTime {
        string datetime { get; set; }
        string timeZone { get; set; }
    }

    
}