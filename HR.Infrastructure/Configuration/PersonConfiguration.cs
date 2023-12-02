using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x=>x.IdentityNumber).IsRequired().HasMaxLength(11).HasColumnType("varchar");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30).HasColumnType("varchar");

            builder.Property(x => x.SecondName).HasMaxLength(30).HasColumnType("varchar");

            builder.Property(x => x.Surname).IsRequired().HasMaxLength(30).HasColumnType("varchar");

            builder.Property(x => x.SecondSurname).HasMaxLength(30).HasColumnType("varchar");

            builder.Property(x => x.Address).IsRequired().HasMaxLength(60).HasColumnType("varchar");

            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(11).HasColumnType("varchar");


            builder.Property(x => x.Salary).HasColumnType("int").IsRequired();

            builder.Property(x => x.Photo).IsRequired().HasMaxLength(60).HasColumnType("varchar");

            builder.Property(x => x.BirthDate).IsRequired().HasMaxLength(15).HasColumnType("date");

            builder.Property(x => x.PlaceofBirth).IsRequired().HasMaxLength(30).HasColumnType("varchar");

            builder.Property(x => x.HireDate).IsRequired().HasMaxLength(15).HasColumnType("date");

            builder.Property(x => x.FireDate).HasMaxLength(15).HasColumnType("date");


            builder.HasOne(x => x.Job).WithMany(x => x.People).HasForeignKey(x => x.JobId);

            builder.HasOne(x => x.Department).WithMany(x => x.People).HasForeignKey(x => x.DepartmentId);

            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(30).HasColumnType("varchar");           
        }
    }
}
