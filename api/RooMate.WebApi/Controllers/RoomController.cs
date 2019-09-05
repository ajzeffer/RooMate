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
    public class RoomController : ApiBaseController
    {
        private readonly IRoomService _roomService; 
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService; 
        }
        [HttpGet]
        public ActionResult<RoomDto> Get(string roomId) => RoomDto.Create(_roomService.GetRoom(roomId));
       
        [HttpPost]
        public ActionResult<RoomScheduleDto> CheckAvailability(string roomId, DateTime targetMeetingTime, int meetingLength) => RoomScheduleDto.Create(_roomService.GetRoom(roomId ),targetMeetingTime, meetingLength);
        
    }
}