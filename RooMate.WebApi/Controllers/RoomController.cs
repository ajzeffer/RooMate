using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.AspNetCore.Mvc;
using RooMate.Core.Contracts;
using RooMate.WebApi.Models;

namespace RooMate.WebApi.Controllers
{
    [Route("/api/room")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService; 
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService; 
        }
        [HttpGet]
        public ActionResult<RoomDto> Find(string roomId) => RoomDto.Create(_roomService.GetRoom(roomId));
       
        [HttpPost]
        public ActionResult<RoomDto> Find(string roomId, DateTime targetMeetingTime, int meetingLength) => RoomDto.Create(_roomService.GetRoom(roomId ),targetMeetingTime, meetingLength);
        
        
    }
}