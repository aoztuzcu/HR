using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Companies.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Queries.GetCompanyById;

public class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, CompanyVM>
{
    private readonly IMapper mapper;
    private readonly ICompanyRepository repository;

    public GetCompanyByIdQueryHandler(IMapper mapper,ICompanyRepository repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }
    public async Task<CompanyVM> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
    {
        var result =await repository.GetAsync(x => x.Id == request.Id , cancellationToken);
        return mapper.Map<CompanyVM>(result);
    }
}
