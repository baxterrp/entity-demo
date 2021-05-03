using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Context
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        // this will be the users table
        public DbSet<LoginModel> Users { get; set; }

        public DbSet<ToDoTask> Tasks { get; set; }
    }
}
