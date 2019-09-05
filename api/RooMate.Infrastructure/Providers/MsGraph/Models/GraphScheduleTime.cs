using RooMate.Core.Contracts.Graph;

namespace RooMate.Infrastructure.Providers.MsGraph.Models
{
    public class GraphScheduleTime : IGraphScheduleTime
    {
        public string datetime { get; set; }
        public string timeZone { get; set; }
    }
}