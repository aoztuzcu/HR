using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.Commands.PersonCreate;

public class PersonCreateCommandHandler : IRequestHandler<PersonCreateCommand, PersonCreateCommand>
{
    private readonly IMapper mapper;
    private readonly IPersonnelRepository repository;

    public PersonCreateCommandHandler(IMapper mapper, IPersonnelRepository repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }
    public async Task<PersonCreateCommand> Handle(PersonCreateCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Personnel>(request);
        var result = await repository.AddAsync(entity, cancellationToken);
        return mapper.Map<PersonCreateCommand>(result);
    }
}
