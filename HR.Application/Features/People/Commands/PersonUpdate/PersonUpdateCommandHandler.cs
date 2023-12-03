using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using MediatR;

namespace HR.Application.Features.People.Commands.PersonUpdate;

public class PersonUpdateCommandHandler : IRequestHandler<PersonUpdateCommand, PersonUpdateCommand>
{
    private readonly IPersonnelRepository repository;
    private readonly IMapper mapper;

    public PersonUpdateCommandHandler(IPersonnelRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<PersonUpdateCommand> Handle(PersonUpdateCommand request, CancellationToken cancellationToken)
    {
        var newEntity = mapper.Map<Personnel>(request);
        var result = await repository.UpdateAsyncByPerson(newEntity, cancellationToken);
        return mapper.Map<PersonUpdateCommand>(result);
    }
}
