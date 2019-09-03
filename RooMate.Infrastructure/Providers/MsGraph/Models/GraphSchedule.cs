using System.Collections.Generic;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Infrastructure.Providers.MsGraph.Models
{
    public class GraphSchedule : IGraphSchedule
    {
        public string scheduleId { get; set; }
        public string availabilityView { get; set; }
        public IList<IGraphScheduleItem> scheduleItems { get; set; }
    }
}