using Models;

namespace Data
{
    public static class FakeDatabase
    {
        public static List<User> Users = new()
        {
            new User {Id = 1, Name = "Иван", Email = "ivan@mail.ru"},
            new User {Id = 1, Name = "Анна", Email = "anna@mail.ru"},
        };
    }
}
