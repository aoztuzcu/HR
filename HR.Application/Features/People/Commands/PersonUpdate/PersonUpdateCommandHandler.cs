using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
using MediatR;

namespace HR.Application.Features.People.Commands.PersonUpdate;

public class PersonUpdateCommandHandler : IRequestHandler<PersonUpdateCommand, PersonUpdateCommand>
{
    private readonly IPersonRepository repository;
    private readonly IMapper mapper;

    public PersonUpdateCommandHandler(IPersonRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }


    async Task<PersonUpdateCommand> IRequestHandler<PersonUpdateCommand, PersonUpdateCommand>.Handle(PersonUpdateCommand request, CancellationToken cancellationToken)
    {
        var newEntity = mapper.Map<Person>(request);
        var result = await repository.UpdateAsyncByPerson(newEntity, cancellationToken);
        return mapper.Map<PersonUpdateCommand>(result);
       
    }
}
