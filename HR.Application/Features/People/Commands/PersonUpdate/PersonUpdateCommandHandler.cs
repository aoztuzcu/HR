using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using MediatR;

namespace HR.Application.Features.People.Commands.PersonUpdate;

public class PersonUpdateCommandHandler : IRequestHandler<PersonUpdateCommand>
{
    private readonly IPersonRepository repository;
    private readonly IMapper mapper;

    public PersonUpdateCommandHandler(IPersonRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public Task Handle(PersonUpdateCommand request, CancellationToken cancellationToken)
    {
        var newEntity = mapper.Map<Person>(request);
        return repository.UpdateAsync(newEntity);
    }
}
