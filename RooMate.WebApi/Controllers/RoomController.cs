using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Mvc;
using RooMate.Core.Contracts;
using RooMate.WebApi.Models;

namespace RooMate.WebApi.Controllers
{
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoomService _roomService; 
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService; 
        }
        
        public ActionResult<RoomDto> Get(string roomId) => RoomDto.Create(_roomService.GetRoom(roomId));
        public ActionResult<RoomDto> Get(string roomId, DateTime targetMeetingTime, int meetingLength) => RoomDto.Create(_roomService.GetRoom(roomId ),targetMeetingTime, meetingLength);
        public ActionResult<List<RoomListDto>> List()
        {
            var list =  new List<RoomListDto>();
            var rooms = _roomService.GetRooms();
            list.AddRange(rooms.Select(RoomListDto.Create));
            return list;
        }
        
    }
}