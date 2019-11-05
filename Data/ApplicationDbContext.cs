using Microsoft.EntityFrameworkCore;

namespace ExamMvcLogin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
    }
}