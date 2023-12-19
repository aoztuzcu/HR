using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Companies.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Queries.GetAllCompany;

public class GetAllCompanyQueryHandler : IRequestHandler<GetAllCompanyQuery, IEnumerable<CompanyListVM>>
{
    private readonly ICompanyRepository repository;
    private readonly IMapper mapper;


    public GetAllCompanyQueryHandler(ICompanyRepository repository,IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<CompanyListVM>> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
    {
        var list = await repository.GetAllAsync(cancellationToken);
        return mapper.Map<IEnumerable<CompanyListVM>>(list);
         
    }
}
