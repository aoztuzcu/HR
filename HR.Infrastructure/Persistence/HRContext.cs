using HR.Domain.Base;
using HR.Domain.Concrete;
using HR.Domain.Concrete.Identity;
using HR.Domain.Concrete.Identity.Role;
using HR.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HR.Infrastructure.Persistence;

public class HRContext : IdentityDbContext<User, UserRole, Guid>
{
    public HRContext(DbContextOptions<HRContext> options) : base(options) { }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Personnel> Personnels { get; set; }
    public DbSet<Expenditure> Expenditures { get; set; }
    public DbSet<ExpenditureType> ExpenditureTypes { get; set; }
    public DbSet<AdvancePayment> AdvancePayments { get; set; }
    public DbSet<PermissionType> Permissions { get; set; }
    public DbSet<PermissionRequest> PermissionRequests { get; set; }
    public DbSet<User> Users { get; set; }

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
        modelBuilder.ApplyConfiguration(new PersonnelConfiguration())
        .ApplyConfiguration(new DepartmentConfiguration())
        .ApplyConfiguration(new JobConfiguration())
        .ApplyConfiguration(new AdvancePaymentConfiguration());
        modelBuilder.Seed();

        modelBuilder.Entity<Personnel>().HasOne(x => x.User).WithMany(x => x.Personnels).HasForeignKey(x => x.UserId);


        base.OnModelCreating(modelBuilder);
    }
}
