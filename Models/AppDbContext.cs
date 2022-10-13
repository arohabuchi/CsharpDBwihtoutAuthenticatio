using Microsoft.EntityFrameworkCore;

namespace EmlpoyeeMgt.Models {
    public class AppDbContext : DbContext {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

       

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee{
                    Id=2,
                    Name="Obi",
                    Department=Dept.HR,
                    Email="obi@gmail.com"

                },
                new Employee{
                    Id=3,
                    Name="ken",
                    Department=Dept.HR,
                    Email="ken@gmail.com"

                }
            );
        }
    }
}