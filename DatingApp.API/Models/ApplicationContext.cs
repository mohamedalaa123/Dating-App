using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Models
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> op):base(op)
        {
            
        }

        public DbSet<Users> Users { get; set; }
    }
}