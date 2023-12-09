using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.Queries.GetlAllPerson;

public class GetAllPersonQueryHandle : IRequestHandler<GetAllPersonQuery, IEnumerable<PersonVM>>
{
    private readonly IPersonnelRepository repository;
    private readonly IMapper mapper;

    public GetAllPersonQueryHandle(IPersonnelRepository repository , IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<PersonVM>> Handle(GetAllPersonQuery request, CancellationToken cancellationToken)
    {
        var list = await repository.GetAllIncludeAsync();
        return mapper.Map<IEnumerable<PersonVM>>(list);
    }
}
