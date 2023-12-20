using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Companies.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Queries.GetManagerInCompany;

public class GetManagerInCompanyQueryHandler : IRequestHandler<GetManagerInCompanyQuery, IEnumerable<ManagerInCompaniesVM>>
{
    private readonly IMapper mapper;
    private readonly IPersonnelRepository personnelRepository;

    public GetManagerInCompanyQueryHandler(IMapper mapper, IPersonnelRepository personnelRepository)
    {
        this.mapper = mapper;
        this.personnelRepository = personnelRepository;
    }
    public async Task<IEnumerable<ManagerInCompaniesVM>> Handle(GetManagerInCompanyQuery request, CancellationToken cancellationToken)
    {
        var managerList = await personnelRepository.GetAllManagers();
        return mapper.Map<IEnumerable<ManagerInCompaniesVM>>(managerList);
    }
}
