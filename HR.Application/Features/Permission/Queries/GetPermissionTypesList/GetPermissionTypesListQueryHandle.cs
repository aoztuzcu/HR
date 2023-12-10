using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Queries.GetPermissionTypesList;

public class GetPermissionTypesListQueryHandle : IRequestHandler<GetPermissionTypesListQuery, IEnumerable<PermissionTypeVM>>
{
    private readonly IPermissionTypeRepository permissionTypeRepository;
    private readonly IPersonnelRepository personnelRepository;
    private readonly IMapper mapper;

    public GetPermissionTypesListQueryHandle(IPermissionTypeRepository permissionTypeRepository, IPersonnelRepository personnelRepository, IMapper mapper)
    {
        this.permissionTypeRepository = permissionTypeRepository;
        this.personnelRepository = personnelRepository;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<PermissionTypeVM>> Handle(GetPermissionTypesListQuery request, CancellationToken cancellationToken)
    {
        var personnel = await personnelRepository.GetByIdAsync(request.PersonnelId, cancellationToken);
        if (personnel.Gender== Domain.Enum.Gender.Female)
        {
           var permissionTypeList= await permissionTypeRepository.GetAllAsyncByFemale(cancellationToken);
            return mapper.Map<IEnumerable<PermissionTypeVM>>(permissionTypeList);
        }
        else
        {
            var permissionTypeList = await permissionTypeRepository.GetAllAsyncByMale(cancellationToken);
            return mapper.Map<IEnumerable<PermissionTypeVM>>(permissionTypeList);
        }
    }
}
