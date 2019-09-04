using RooMate.Core.Contracts;

namespace RooMate.WebApi.Models
{
    public class RoomListDto : RoomBaseDto
    {
        private RoomListDto(IRoom room) : base(room)
        {
        }
        public static RoomListDto Create(IRoom room) => new RoomListDto(room);
    }
}