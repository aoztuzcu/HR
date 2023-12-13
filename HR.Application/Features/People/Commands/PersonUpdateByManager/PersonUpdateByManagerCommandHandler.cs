using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using MediatR;

namespace HR.Application.Features.People.Commands.PersonUpdateByManager;

public class PersonUpdateByManagerCommandHandler : IRequestHandler<PersonUpdateByManagerCommand, PersonUpdateByManagerCommand>
{
    private readonly IMapper mapper;
    private readonly IPersonnelRepository personnelRepository;

    public PersonUpdateByManagerCommandHandler(IMapper mapper, IPersonnelRepository personnelRepository)
    {
        this.mapper = mapper;
        this.personnelRepository = personnelRepository;
    }

    public async Task<PersonUpdateByManagerCommand> Handle(PersonUpdateByManagerCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Personnel>(request);
        var result = await personnelRepository.UpdateAsync(entity, cancellationToken);
        return mapper.Map<PersonUpdateByManagerCommand>(result);
    }
}
