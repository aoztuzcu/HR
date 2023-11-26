using HR.Domain.Concrete;
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
        var departmantId = Guid.NewGuid();
        var departmantId2 = Guid.NewGuid();
        var jobId2 = Guid.NewGuid();
        var jobId = Guid.NewGuid();
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
        modelBuilder.Entity<Person>().HasData(
           new Person
           {
               Id = Guid.NewGuid(),
               CreatedDate = DateTime.Now,
               IdentityNumber = "65803196176",
               Address = "Kadıköy/İstanbul",
               BirthDate = new DateTime(1990, 05, 22),
               HireDate = DateTime.Now,
               Salary = 34000,
               PlaceofBirth = "İstanbul",
               Name = "Elif",
               Surname = "Demir",
               SecondName = "Betül",
               PhoneNumber = "5226932145",
               CompanyName = "Google",
               Photo = "image_avatar-female.png",
               JobId = jobId,
               DepartmentId = departmantId
           },
             new Person
             {
                 Id = Guid.NewGuid(),
                 CreatedDate = DateTime.Now,
                 IdentityNumber = "65803196176",
                 Address = "Yenibosna/İstanbul",
                 BirthDate = new DateTime(1990, 05, 22),
                 HireDate = DateTime.Now,
                 Salary = 34000,
                 PlaceofBirth = "İstanbul",
                 Name = "Muhammet",
                 Surname = "Coşkun",                 
                 PhoneNumber = "5226932145",
                 CompanyName = "Microsoft",
                 Photo = "image_avatar-female.png",
                 JobId = jobId2,
                 DepartmentId = departmantId2
             }
        );
    }

}

