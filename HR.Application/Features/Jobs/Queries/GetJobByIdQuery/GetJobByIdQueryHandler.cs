using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Jobs.ViewModels;
using MediatR;

namespace HR.Application.Features.Jobs.Queries.GetJobByIdQuery;

public class GetJobByIdQueryHandler : IRequestHandler<GetJobByIdQuery, JobVM>
{
    private readonly IJobRepository repository;
    private readonly IMapper mapper;

    public GetJobByIdQueryHandler(IJobRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<JobVM> Handle(GetJobByIdQuery request, CancellationToken cancellationToken)
    {
        var data = await repository.GetByIdAsync(request.Id, cancellationToken);
        return mapper.Map<JobVM>(data);
    }
}
