using HR.Domain.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Configuration;


public class PermissionConfiguration : IEntityTypeConfiguration<Permissions>

{
    public void Configure(EntityTypeBuilder<Permissions> builder)
    {
        builder.HasQueryFilter(x => x.IsActive);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(30).HasColumnType("varchar");

        builder.Property(x => x.Days).HasColumnType("float");
    }
}


