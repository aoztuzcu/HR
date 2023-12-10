using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Jobs.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Jobs.Queries.GetAllJobQuery;

public class GetAllJobQueryHandler : IRequestHandler<GetAllJobQuery, IEnumerable<JobVM>>
{
    private readonly IMapper mapper;
    private readonly IJobRepository repository;

    public GetAllJobQueryHandler(IMapper mapper,IJobRepository repository )
    {
        this.mapper = mapper;
        this.repository = repository;
    }
    public async Task<IEnumerable<JobVM>> Handle(GetAllJobQuery request, CancellationToken cancellationToken)
    {
        var list = await repository.GetAllAsync(cancellationToken);
        return mapper.Map<IEnumerable<JobVM>>(list);
    }
}
