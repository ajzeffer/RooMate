using System;
using System.Collections.Generic;
using Moq;
using RooMate.Core.Contracts;
using RooMate.Core.Contracts.Graph;
using RooMate.Core.Domain;
using RooMate.Core.Services;
using RooMate.Infrastructure.Providers.MsGraph.Models;
using Xunit;

namespace RooMate.Core.Tests.Services
{
    public class RoomServiceTests
    {
        [Fact]
        public void RoomService_GetRoom_RoomIsNotNull()
        {
            var moqRoomService = new Mock<IRoomService>();
            var graphSchedule = new GraphSchedule
            {
                scheduleItems = new List<IGraphScheduleItem>
                {
                    new GraphScheduleItem
                    {
                        start = new GraphScheduleTime
                        {
                            datetime = "",
                            timeZone = ""
                        }, end = new GraphScheduleTime
                        {
                            datetime = "",
                            timeZone = ""
                        }, status = ""
                    }
                }
            };
            moqRoomService.Setup(x => x.GetRoom(It.IsAny<GraphSchedule>())).Returns(Room.Create(graphSchedule));
            var roomService = moqRoomService.Object;
            var room = roomService.GetRoom(new GraphSchedule());
            Assert.True(room != null);
        }
        
        
        [Fact]
        public void RoomService_GetRooms_Success()
        {
            var roomService = new RoomService();
            var rooms = roomService.GetRooms();
            Assert.True(rooms != null);
        }
    }
}