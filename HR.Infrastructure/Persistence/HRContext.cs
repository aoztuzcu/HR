using HR.Domain.Base;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using HR.Domain.Concrete.User.Role;
using HR.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HR.Infrastructure.Persistence;

public class HRContext : IdentityDbContext<Person, PersonRole, Guid>
{
    public HRContext(DbContextOptions<HRContext> options) : base(options) { }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Job> Jobs { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    break;

                case EntityState.Modified:
                    if (entry.Entity.IsActive == false)
                    {
                        entry.Entity.DeletedDate = DateTime.Now;
                        break;
                    }
                    entry.Entity.UpdatedDate = DateTime.Now;
                    break;
                default: break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("No connection string");
        }
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfiguration())
                .ApplyConfiguration(new DepartmentConfiguration())
                .ApplyConfiguration(new JobConfiguration());
        modelBuilder.Seed();
        base.OnModelCreating(modelBuilder);
    }
}
