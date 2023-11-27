using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.Jobs.ViewModels;
using MediatR;

namespace HR.Application.Features.Departments.Queries.GetDepartmentByIdQuery;

public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, DepartmentVM>
{
    private readonly IDepartmentRepository repository;
    private readonly IMapper mapper;

    public GetDepartmentByIdQueryHandler(IDepartmentRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<DepartmentVM> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
    {
        var data = await repository.GetByIdAsync(request.Id, cancellationToken);
        return mapper.Map<DepartmentVM>(data);
    }
}
