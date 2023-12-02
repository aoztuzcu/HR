using HR.Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Configuration
{
    public class AdvancePaymentConfiguration : IEntityTypeConfiguration<AdvancePayment>


    {
        public void Configure(EntityTypeBuilder<AdvancePayment> builder)
        {

            builder.HasQueryFilter(x => x.IsActive);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ApprovalStatus).IsRequired().HasColumnType("int");

            builder.Property(x => x.AdvanceType).IsRequired().HasColumnType("int");

            builder.Property(x => x.CurrencyType).IsRequired().HasColumnType("int");

            builder.Property(x=>x.Amount).IsRequired().HasColumnType("decimal");

            builder.Property(x => x.ApprovalDate).IsRequired().HasColumnType("datetime");

            builder.Property(x=>x.Description).IsRequired().HasColumnType("varchar").HasMaxLength(100);

            builder.HasOne(x=>x.Person).WithMany(x=>x.AdvancePayments).HasForeignKey(x=>x.PersonId);



        }
    }
}
