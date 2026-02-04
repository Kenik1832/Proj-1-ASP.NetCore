using Microsoft.AspNetCore.Mvc;
using Data;
using Models;

namespace Controllers
{
    [ApiController]
    [Route ("users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return FakeDatabase.Users;
        }
    }
}