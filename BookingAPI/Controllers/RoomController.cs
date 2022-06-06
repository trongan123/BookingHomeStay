using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.IService;

namespace BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService accountService;

        public RoomController(IRoomService account)
        {
            this.accountService = account;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetAccount() => accountService.GetRooms();




    }
}
