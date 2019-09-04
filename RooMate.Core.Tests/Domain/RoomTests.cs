using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using RooMate.Core.Contracts.Graph;
using RooMate.Core.Domain;
using RooMate.Infrastructure.Providers.MsGraph.Models;
using Xunit;
using Xunit.Sdk;

namespace RooMate.Core.Tests.Domain
{
    public class RoomTests
    {
        private string _mountainStandardTz = "Mountain Standard Time"; 
        #region // IsTimeBetween // 
        [Fact]
        public void RoomService_IsTimeBetween_True()
        {
            var startMeeting = DateTime.Parse("2019-09-03 13:00:00");
            var endMeeting = DateTime.Parse("2019-09-03 14:00:00");
            var newMeetingStartTime = DateTime.Parse("2019-09-03 13:30:00");
            Assert.True(Room.isTimeBetween(startMeeting, endMeeting, newMeetingStartTime));
        }
        
        [Fact]
        public void RoomService_IsTimeBetween_False()
        {
            var startMeeting = DateTime.Parse("2019-09-03 13:00:00");
            var endMeeting = DateTime.Parse("2019-09-03 14:00:00");
            var newMeetingStartTime = DateTime.Parse("2019-09-03 15:00:00");
            Assert.False(Room.isTimeBetween(startMeeting, endMeeting, newMeetingStartTime));
        }
        #endregion 
        
        
        #region // IsAvailable // 

        [Fact]
        public void Room_IsAvailable_True()
        {
            var room = Room.Create(buildGraphSchedule(new List<Tuple<DateTime, DateTime>>
            {
                Tuple.Create(DateTime.Parse("2019-09-03 13:00:00"), DateTime.Parse("2019-09-03 14:00:00")),
                Tuple.Create(DateTime.Parse("2019-09-03 16:00:00"), DateTime.Parse("2019-09-03 17:00:00"))
            }));
            
            Assert.True(room.IsAvailable(DateTime.Parse("2019-09-03 11:00:00"),1));
        }
        
        [Fact]
        public void Room_IsAvailable_False()
        {
            var room = Room.Create(buildGraphSchedule(new List<Tuple<DateTime, DateTime>>
            {
                Tuple.Create(DateTime.Parse("2019-09-03 13:00:00"), DateTime.Parse("2019-09-03 14:00:00")),
                Tuple.Create(DateTime.Parse("2019-09-03 16:00:00"), DateTime.Parse("2019-09-03 17:00:00"))
            }));
            
            Assert.False(room.IsAvailable(DateTime.Parse("2019-09-03 13:00:00"),1));
        }
        #endregion


        private GraphSchedule buildGraphSchedule(List<Tuple<DateTime,DateTime>> meetingTimes)
        {
            var meetings = new List<IGraphScheduleItem>();
             meetings.AddRange( meetingTimes.Select(x => addMeetingToSchedule(x.Item1, x.Item2, _mountainStandardTz)));
           
            return new GraphSchedule
            {
                availabilityView = "",
                scheduleId = "",
                scheduleItems = meetings
            };
        }

        private GraphScheduleItem addMeetingToSchedule(DateTime start, DateTime end, string timeZone)
        {
            return new GraphScheduleItem
            {
                start = new GraphScheduleTime
                {
                    datetime = start.ToString("G"), timeZone = timeZone
                },
                end = new GraphScheduleTime
                {
                    datetime = end.ToString("G"), timeZone = timeZone
                }
            };
        }
    }
}