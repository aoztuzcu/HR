using HR.Domain.Concrete;
using HR.Domain.Concrete.Identity;
using HR.Domain.Concrete.Identity.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HR.Persistence.Configuration;

public static class SeedDataExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<Personnel>();
        var departmantId = Guid.NewGuid();
        var departmantId2 = Guid.NewGuid();
        var jobId2 = Guid.NewGuid();
        var jobId = Guid.NewGuid();
        var role = Guid.NewGuid();
        var userId = Guid.NewGuid();
        var userId2 = Guid.NewGuid();
        var userIdendityId = Guid.NewGuid();

        User user = new User()
        {
            Id = userIdendityId,
            Name = "Betül",
            Surname = "Demir",
            UserName = "betuldemir",
            NormalizedUserName = "BETULDEMIR",
            Email = "betul.demir@bilgeadamboost.com",
            NormalizedEmail = "BETUL.DEMIR@BILGEADAMBOOST.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };
        modelBuilder.Entity<User>().HasData(user);

        var passwordHasher = new PasswordHasher<User>();
        user.PasswordHash = passwordHasher.HashPassword(user, "Proje123");

        modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = role, Name = "Personnel", NormalizedName = "PERSONNEL" });

        modelBuilder.Entity<Department>().HasData(
        new Department
        {
            Id = departmantId2,
            CreatedDate = DateTime.Now,
            Name = "Mekanik Tasarım"
        },
        new Department
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "İnsan Kaynakları"
        },
        new Department
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "Muhasebe"
        },
        new Department
        {
            Id = departmantId,
            CreatedDate = DateTime.Now,
            Name = "Bilişim Teknolojileri"
        }
        );
        modelBuilder.Entity<Job>().HasData(new Job
        {
            Id = jobId,
            CreatedDate = DateTime.Now,
            Name = "Yazılım Mühendisi",

        }, new Job
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "FrontEnd Geliştici",
        }, new Job
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "BackEnd Geliştici",
        },
        new Job
        {
            Id = jobId2,
            CreatedDate = DateTime.Now,
            Name = "İnşaat Mühendisi",
        }
        , new Job
        {
            Id = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            Name = "Endüstri Mühendisi",
        });



        //modelBuilder.Entity<Personnel>().HasData(
        //   new Personnel
        //   {
        //       //Id = userId,
        //       IdentityNumber = "66047609514",
        //       Address = "Kadıköy/İstanbul",
        //       BirthDate = new DateTime(1990, 05, 22),
        //       HireDate = DateTime.Now,
        //       Salary = 34000,
        //       PlaceofBirth = "İstanbul",
        //       Name = "Elif",
        //       Surname = "Demir",
        //       SecondName = "Betül",
        //       Gender = Domain.Enum.Gender.Female,
        //       PhoneNumber = "5226932145",
        //       CompanyName = "Google",
        //       Photo = "image_avatar-female.png",
        //       JobId = jobId,
        //       DepartmentId = departmantId,
        //       Email = "betul.demir@bilgeadamboost.com"
        //   },
        //     new Personnel
        //     {
        //         Id = userId2,
        //         IdentityNumber = "56555011244",
        //         Address = "Yenibosna/İstanbul",
        //         BirthDate = new DateTime(2000, 09, 25),
        //         HireDate = DateTime.Now,
        //         Salary = 34000,
        //         PlaceofBirth = "İstanbul",
        //         Name = "Muhammet",
        //         Surname = "Coşkun",
        //         Gender = Domain.Enum.Gender.Male,
        //         PhoneNumber = "5226932145",
        //         CompanyName = "Microsoft",
        //         Photo = "image_avatar-female.png",
        //         JobId = jobId2,
        //         DepartmentId = departmantId2,
        //         Email = "muhammet.coskun@bilgeadamboost.com"
        //     });
    }
}
