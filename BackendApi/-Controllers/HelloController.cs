using Microsoft.AspNetCore.Mvc;
// Подключаем всё, что нужно для API:
// -ControllerBase
// -HttpGet
// -Route


namespace Controllers
{
    [ApiController] //это API-контроллер
    [Route ("api/hello")] //https://localhost:5101/api/hello
    public class HelloController : ControllerBase
    {
        [HttpGet] //Метод отвечает на GET-запрос
        public string Get()
        {
            return "Ты подня backendApi, и это круто!";
        }
        [HttpGet("time")]
        public string GetTime()
        {
            return DateTime.Now.ToString();
        }
    }
}