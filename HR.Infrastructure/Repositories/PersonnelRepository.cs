using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System.Linq.Expressions;

namespace HR.Persistence.Repositories;

public class PersonnelRepository : BaseRepository<Personnel>, IPersonnelRepository
{
    private readonly RoleManager<IdentityRole> roleManager;
    public PersonnelRepository(HRContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Personnel>> GetAllIncludeAsync()
    {
        var role = await context.Roles.FirstOrDefaultAsync(x => x.Name == "Personnel");
        var rolemanager = context.UserRoles.Where(x => x.RoleId == role.Id).Select(x => x.UserId);
        return await context.Personnels.Where(x=>rolemanager.Contains(x.UserId)).Include(x => x.Department).Include(y => y.Job).ToListAsync();
    }

    public async Task<IEnumerable<Personnel>> GetAllManagers()
    {
       var role =await context.Roles.FirstOrDefaultAsync(x => x.Name == "Manager");
       var rolemanager = context.UserRoles.Where(x =>x.RoleId==role.Id).Select(x=>x.UserId);
       return await context.Personnels.Where(x=>rolemanager.Contains(x.UserId)).Include(x=>x.Company).ToListAsync();
    }

    public async Task<Personnel> GetByIdAsync(Guid Id, CancellationToken token)
         => await context.Personnels.Include(x => x.Department).Include(y => y.Job).FirstOrDefaultAsync(f => f.Id == Id, token);
    public async Task<Personnel> UpdateAsyncByPerson(Personnel entity, CancellationToken token)
    {
        var model = await context.Personnels.FirstOrDefaultAsync(f => f.Id == entity.Id) ?? throw new ArgumentNullException("Entity not found.");
        model.Address = entity.Address;
        model.PhoneNumber = entity.PhoneNumber;

        if (entity.Photo is not null)
            model.Photo = entity.Photo;

        context.Entry(model).State = EntityState.Modified;
        await context.SaveChangesAsync(token);
        return model;
    }
}
