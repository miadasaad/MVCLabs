using Microsoft.EntityFrameworkCore;

namespace MVCLabSeven.Models
{
    public class ITIContext:DbContext
    {
        public ITIContext(DbContextOptions options) : base(options)
        {
        }
        public ITIContext()
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LabMvc;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
