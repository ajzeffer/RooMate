using System.Collections.Generic;
using RooMate.Core.Contracts.Graph;

namespace RooMate.Infrastructure.Providers.MsGraph.Models
{
    public class  GraphRoomSchedules : IGraphRoomSchedules
    {
        public IList<IGraphSchedule> value { get; set; }
    }
}