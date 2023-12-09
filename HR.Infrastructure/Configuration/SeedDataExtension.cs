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
        #region AspNetUserSeedData
        // Id'ler oluşturuldu.
        var idendityIdUser = Guid.NewGuid();
        var idendityIdUser2 = Guid.NewGuid();
        var idendityIdUser3 = Guid.NewGuid();
        var idendityIdUser4 = Guid.NewGuid();
        var idendityIdUser5 = Guid.NewGuid();

        User user1 = new User()
        {
            Id = idendityIdUser,
            Name = "Betül",
            Surname = "Demir",
            UserName = "betuldemir",
            NormalizedUserName = "BETULDEMIR",
            Email = "betul.demir@bilgeadamboost.com",
            NormalizedEmail = "BETUL.DEMIR@BILGEADAMBOOST.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };

        User user2 = new User()
        {
            Id = idendityIdUser2,
            Name = "Muhammet",
            Surname = "Coşkun",
            UserName = "muhammetcoskun",
            NormalizedUserName = "MUHAMMETCOSKUN",
            Email = "muhammet.coskun@bilgeadamboost.com",
            NormalizedEmail = "MUHAMMET.COSKUN@BILGEADAMBOOST.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };

        User user3 = new User()
        {
            Id = idendityIdUser3,
            Name = "Mehmet Ali",
            Surname = "Mert",
            UserName = "mehmetalimert",
            NormalizedUserName = "MEHMETALIMERT",
            Email = "mehmetali.mert@bilgeadamboost.com",
            NormalizedEmail = "MEHMETALI.MERT@BILGEADAMBOOST.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };

        User user4 = new User()
        {
            Id = idendityIdUser4,
            Name = "Abdülkadir",
            Surname = "Öztuzcu",
            UserName = "abdulkadiroztuzcu",
            NormalizedUserName = "ABDULKADIROZTUZCU",
            Email = "abdulkadir.oztuzcu@bilgeadamboost.com",
            NormalizedEmail = "ABDULKADIR.OZTUZCU@BILGEADAMBOOST.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };

        User user5 = new User()
        {
            Id = idendityIdUser5,
            Name = "Furkan",
            Surname = "Umman",
            UserName = "furkanumman",
            NormalizedUserName = "FURKANUMMAN",
            Email = "furkan.umman@bilgeadamboost.com",
            NormalizedEmail = "FURKAN.UMMAN@BILGEADAMBOOST.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };

        modelBuilder.Entity<User>().HasData(user1, user2, user3, user4, user5);

        var passwordHasher = new PasswordHasher<User>();
        user1.PasswordHash = passwordHasher.HashPassword(user1, "Proje123");
        user2.PasswordHash = passwordHasher.HashPassword(user2, "Proje123");
        user3.PasswordHash = passwordHasher.HashPassword(user3, "Proje123");
        user4.PasswordHash = passwordHasher.HashPassword(user4, "Proje123");
        user5.PasswordHash = passwordHasher.HashPassword(user5, "Proje123");
        #endregion

        #region RoleSeedData
        modelBuilder.Entity<UserRole>().HasData(new UserRole { Id = Guid.NewGuid(), Name = "Personnel", NormalizedName = "PERSONNEL" });

        #endregion

        #region DepartmentSeedData
        modelBuilder.Entity<Department>().HasData(
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "AR-GE" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "İnsan Kaynakları" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Finans" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Pazarlama" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Satış" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Üretim ve Operasyon" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Müşteri Hizmetleri" },
                                                    new Department { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Bilişim Teknolojileri" }
                                                    );
        #endregion

        #region JobSeedData
        modelBuilder.Entity<Job>().HasData(
                                        new Job { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Yazılım Mühendisi", },
                                        new Job { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "FrontEnd Geliştici", },
                                        new Job { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "BackEnd Geliştici", },
                                        new Job { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "İnşaat Mühendisi", },
                                        new Job { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Endüstri Mühendisi", }
                                        );
        #endregion

        #region PermissionTypeSeedData
        modelBuilder.Entity<Permissions>().HasData(
                                       new Permissions { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Yıllık İzin", },
                                       new Permissions { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Babalık İzni", Days = 5 },
                                       new Permissions { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Evlilik İzni", Days = 3 },
                                       new Permissions { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Doğum İzni", Days = 112 },
                                       new Permissions { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Ölüm İzni", Days = 3 }
                                       );
        #endregion

        #region ExpenditureTypeSeedData
        modelBuilder.Entity<ExpenditureType>().HasData(
                                                       new ExpenditureType { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Seyahat", MinAmount = 100, MaxAmount = 5000 },
                                                       new ExpenditureType { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Gıda", MinAmount = 100, MaxAmount = 1500 },
                                                       new ExpenditureType { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Ulaşım", MinAmount = 50, MaxAmount = 3000 },
                                                       new ExpenditureType { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Sağlık", MinAmount = 50, MaxAmount = 6000 }
                                                       );
        #endregion

        #region NotUsed
        //var hasher = new PasswordHasher<Personnel>();
        //var departmantId = Guid.NewGuid();
        //var departmantId2 = Guid.NewGuid();
        //var jobId2 = Guid.NewGuid();
        //var jobId = Guid.NewGuid();
        //var userId = Guid.NewGuid();
        //var userId2 = Guid.NewGuid();
        //var role = Guid.NewGuid();

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
        #endregion
    }
}
