using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Departments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Departments.Queries.GetAllDepartmens;

public class GetAllDepartmenQueryHandler : IRequestHandler<GetAllDepartmenQuery, IEnumerable<DepartmentVM>>
{
    private readonly IMapper mapper;
    private readonly IDepartmentRepository repository;

    public GetAllDepartmenQueryHandler(IMapper mapper,IDepartmentRepository repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }
    public async Task<IEnumerable<DepartmentVM>> Handle(GetAllDepartmenQuery request, CancellationToken cancellationToken)
    {
        var list = await repository.GetAllAsync(cancellationToken);
        return mapper.Map<IEnumerable<DepartmentVM>>(list);
    }
}
