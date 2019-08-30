using System.Collections.Generic;

namespace RooMate.Core.Contracts
{
    public interface IRoomSchedule
    {
        IList<IRoomScheduleTime> ScheduleItems { get; set; }
    }
}