using Microsoft.EntityFrameworkCore;
using MySampleWeb.Models;

namespace MySampleWeb.Data
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext(DbContextOptions<NorthWindContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}