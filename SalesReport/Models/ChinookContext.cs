using Microsoft.EntityFrameworkCore;

namespace SalesReport.Models;

public class ChinookContext : DbContext
{
    public ChinookContext(DbContextOptions<ChinookContext> options) : base(options) {}

    public DbSet<Customer> Customer { get; set; }

    public DbSet<Invoice> Invoice { get; set; }
}
