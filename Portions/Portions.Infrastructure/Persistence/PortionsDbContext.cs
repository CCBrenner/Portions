using Microsoft.EntityFrameworkCore;
using Portions.Domain.Entities;
using Portions.Infrastructure.Persistence.DbInititialize;

namespace Portions.Infrastructure.Persistence;

public class PortionsDbContext : DbContext
{
    public PortionsDbContext(DbContextOptions<PortionsDbContext> options) : base(options) { }

    public DbSet<Portion> Portions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DbInit dbInit = DbInitFactory.DbOne();

        modelBuilder.Entity<Portion>().HasData(dbInit.PortionsList);
    }
}