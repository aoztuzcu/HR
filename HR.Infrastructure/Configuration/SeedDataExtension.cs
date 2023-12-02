using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using HR.Domain.Concrete.User.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence.Configuration;

public static class SeedDataExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<Person>();
        var departmantId = Guid.NewGuid();
        var departmantId2 = Guid.NewGuid();
        var jobId2 = Guid.NewGuid();
        var jobId = Guid.NewGuid();
        var role = Guid.NewGuid();
        var userId = Guid.NewGuid();
        var userId2 = Guid.NewGuid();
        modelBuilder.Entity<Department>().HasData(
        new Department
        {
            Id = departmantId2,
            CreatedDate = DateTime.Now,
            Name = "Mechanical Design"
        },
        new Department
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "HR"
        },
        new Department
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "Accounting"
        },
        new Department
        {
            Id = departmantId,
            CreatedDate = DateTime.Now,
            Name = "Information Technology"
        }
        );
        modelBuilder.Entity<Job>().HasData(new Job
        {
            Id = jobId,
            CreatedDate = DateTime.Now,
            Name = "Software Developer",

        }, new Job
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "FrontEnd Developer",
        }, new Job
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "BackEnd Developer",
        },
        new Job
        {
            Id = jobId2,
            CreatedDate = DateTime.Now,
            Name = "Civil Engineer",
        }
        , new Job
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "Industrial Engineer",
        });
        modelBuilder.Entity<PersonRole>().HasData(
            new PersonRole { Name="Personnel", Id= role, NormalizedName="PERSONNEL"}
            );

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                  new IdentityUserRole<Guid> { RoleId = role, UserId = userId }
                  );

        modelBuilder.Entity<Person>().HasData(
           new Person
           {
               Id = userId,
               IdentityNumber = "65803196176",
               Address = "Kadıköy/İstanbul",
               BirthDate = new DateTime(1990, 05, 22),
               HireDate = DateTime.Now,
               Salary = 34000,
               PlaceofBirth = "İstanbul",
               Name = "Elif",
               Surname = "Demir",
               SecondName = "Betül",
               Gender = Domain.Enum.Gender.Female,
               PhoneNumber = "5226932145",
               CompanyName = "Google",
               Photo = "image_avatar-female.png",
               JobId = jobId,
               DepartmentId = departmantId,
               UserName="betuldemir",
               NormalizedUserName="BETULDEMIR",
               Email="elifbetul.demir@bilgeadamboost.com",
               NormalizedEmail="ELIFBETUL.DEMIR@BILGEADAMBOOST.COM",
               EmailConfirmed=true,
               PhoneNumberConfirmed=true,
               TwoFactorEnabled=false,
               LockoutEnabled=false,
               AccessFailedCount=0,
               PasswordHash = hasher.HashPassword(null,"betul12"),
               SecurityStamp= "D2C7BG653KANTFOB6NNHCOSN2R7GM27A"

		   },
             new Person
             {
                 Id = userId2,
                 IdentityNumber = "58963214568",
                 Address = "Yenibosna/İstanbul",
                 BirthDate = new DateTime(2000, 05, 22),
                 HireDate = DateTime.Now,
                 Salary = 34000,
                 PlaceofBirth = "İstanbul",
                 Name = "Muhammet",
                 Surname = "Coşkun",
                 Gender = Domain.Enum.Gender.Male,
                 PhoneNumber = "5226932145",
                 CompanyName = "Microsoft",
                 Photo = "image_avatar-female.png",
                 JobId = jobId2,
                 DepartmentId = departmantId2,
                 UserName="muhammetcoskun",
				 Email = "muhammet.coskun@bilgeadamboost.com",
				 NormalizedEmail = "MUHAMMET.COSKUN@BILGEADAMBOOST.COM",
				 EmailConfirmed = true,
				 PhoneNumberConfirmed = true,
				 TwoFactorEnabled = false,
				 LockoutEnabled = false,
				 AccessFailedCount = 0,
				 PasswordHash = hasher.HashPassword(null, "mh123"),
				 SecurityStamp = "D2C7BG653KANTFOB6NNHCOSN2R7GM27B"

			 }
		) ;
    }

}

