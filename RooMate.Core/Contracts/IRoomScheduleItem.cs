namespace RooMate.Core.Contracts
{
    public interface IRoomScheduleItem
    {
        string status { get; set; }
        IRoomScheduleTime start { get; set; }
        IRoomScheduleTime end { get; set; }
    }

    public interface IRoomScheduleTime
    {
        string dateTime { get; set; }
        string timeZone { get; set; }
    }
}