using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.ViewModels;
using MediatR;

namespace HR.Application.Features.People.Queries.GetPerson;


public class GetPersonQueryHandler : IRequestHandler<GetPersonQuery, PersonDetailVM>
{
    private readonly IPersonRepository repository;
    private readonly IMapper mapper;

    public GetPersonQueryHandler(IPersonRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }


    public async Task<PersonDetailVM> Handle(GetPersonQuery request, CancellationToken cancellationToken)
    {
        var data = await repository.GetByIdAsync(request.Id, cancellationToken);
        return mapper.Map<PersonDetailVM>(data);
    }
}
