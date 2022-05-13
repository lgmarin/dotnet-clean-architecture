using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcCleanArch.Domain.Entities;
using mvcCleanArch.Infra.Data.EntityConfiguration;

namespace mvcCleanArch.Infra.Data.Context;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products {get; set;}

    // Define Fluent API
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ProductConfiguration());
    }
}
