using System.Collections.Generic;

namespace RooMate.Core.Contracts
{
    public interface IRoomSchedule
    {
        IList<IRoomScheduleItem> ScheduleItems { get; set; }
    }
}