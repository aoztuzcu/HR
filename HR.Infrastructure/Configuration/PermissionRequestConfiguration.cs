using HR.Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Configuration;

public class PermissionRequestConfiguration : IEntityTypeConfiguration<PermissionRequest>
{
    public void Configure(EntityTypeBuilder<PermissionRequest> builder)
    {

        builder.HasQueryFilter(x => x.IsActive);
        builder.HasKey(x => x.Id);
      

        builder.Property(x => x.Days).IsRequired().HasColumnType("float");


        builder.Property(x => x.StartDate).HasMaxLength(15).HasColumnType("date").IsRequired();

        builder.Property(x => x.EndDate).HasMaxLength(15).HasColumnType("date");


        builder.Property(x=>x.Days).IsRequired().HasColumnType("float");

        builder.Property(x => x.ApprovalStatus).IsRequired().HasColumnType("int");

        builder.Property(x => x.ApprovedDate).HasMaxLength(15).HasColumnType("datetime");


        builder.HasOne(x => x.Person).WithMany(x => x.PermissonRequests).HasForeignKey(x => x.PersonId);

        builder.HasOne(x => x.PermissionType).WithMany(x => x.PermissionRequests).HasForeignKey(x => x.PermissionTypeId);


    }
}
