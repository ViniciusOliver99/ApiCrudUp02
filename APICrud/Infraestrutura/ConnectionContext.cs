using APICrud.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace APICrud.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql
            (
                "Server=localhost;"           +
                "Port=7777;Database=employee;"+
                "User Id=postgres;"           +
                "Password=2653;"
            );
    }
}
