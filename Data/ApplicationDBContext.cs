using CRUDCodeFirst.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CRUDCodeFirst.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
                
        }
        public DbSet<Student> Students { get; set; }
    }
}
