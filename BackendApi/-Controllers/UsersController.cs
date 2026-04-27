using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Controller
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _db; //Это доступ к базе.

        public UsersController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<List<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }
     

        [HttpPost] //Этот метод работает только на POST(передаёшь информацию на сервер) запросах
        public async Task<ActionResult<User>> Create (User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }
    }
}