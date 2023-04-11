using Microsoft.EntityFrameworkCore;
using ReadingRoom.Models;

namespace ReadingRoom.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; } 

    }
}
