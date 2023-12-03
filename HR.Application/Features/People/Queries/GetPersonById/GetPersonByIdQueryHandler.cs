using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.ViewModels;
using MediatR;

namespace HR.Application.Features.People.Queries.GetPerson;
public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, PersonDetailVM>
{
    private readonly IPersonnelRepository repository;
    private readonly IMapper mapper;

    public GetPersonByIdQueryHandler(IPersonnelRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }


    public async Task<PersonDetailVM> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        var data = await repository.GetByIdAsync(request.Id, cancellationToken);
        return mapper.Map<PersonDetailVM>(data);
    }
}
