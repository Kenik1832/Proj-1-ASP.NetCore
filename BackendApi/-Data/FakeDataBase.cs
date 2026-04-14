using Models;

namespace Data
{
    public static class FakeDataBase
    {
        public static List<User> Users = new()
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" },
            new User { Id = 3, Name = "Bob Johnson", Email = "bob.johnson@example.com" }
        };
    }
}