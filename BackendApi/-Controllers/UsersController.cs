using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace UsersController
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public List<User> GetAll()
        {
            return FakeDataBase.Users;
        }

        [HttpGet ("{id}")] //Это параметр в URL: api/users/1
        public User? GerById(int id) // int id Это значение из URL
        {
            return FakeDataBase.Users.FirstOrDefault(u => u.Id == id); // Ищет первого подходящего пользователя
        }

        [HttpPost] //Этот метод работает только на POST(передаёшь информацию на сервер) запросах
        public ActionResult<User> Create(User user) //берёт JSON из запроса и преобразует его в объект User
        {
            user.Id = FakeDataBase.Users.Count + 1; //Присваивает новый Id, который на единицу больше количества пользователей в базе
            FakeDataBase.Users.Add(user);
            return CreatedAtAction(nameof(GerById), new { id = user.Id }, user); //Возвращает статус 201 Created и информацию о новом пользователе
        }
    }
}