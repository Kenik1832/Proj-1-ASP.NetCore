using Microsoft.EntityFrameworkCore;
using Models;


namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) 
            : base(options)  // Это “мост” между API и БД.
        {
            
        }
        
        public DbSet<User> Users { get; set;}  // Это будущая таблица: Users
    }
}