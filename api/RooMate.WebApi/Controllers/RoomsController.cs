using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RooMate.Core.Contracts;
using RooMate.WebApi.Models;

namespace RooMate.WebApi.Controllers
{
    [Route("/api/rooms")]
    [ApiController]
    public class RoomsController : ApiBaseController
    {
        private readonly IRoomService _roomService; 
        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService; 
        }
        
        [HttpGet]
        public ActionResult<List<RoomListDto>> List()
        {
            var list =  new List<RoomListDto>();
            var rooms = _roomService.GetRooms();
            list.AddRange(rooms.Select(RoomListDto.Create));
            return list;
        }
    }
}