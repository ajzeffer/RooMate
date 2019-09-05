using RooMate.Core.Contracts.Graph;

namespace RooMate.Infrastructure.Providers.MsGraph.Models
{
    public class GraphScheduleItem : IGraphScheduleItem
    {
        public string status { get; set; }
        public IGraphScheduleTime start { get; set; }
        public IGraphScheduleTime end { get; set; }
    }
}