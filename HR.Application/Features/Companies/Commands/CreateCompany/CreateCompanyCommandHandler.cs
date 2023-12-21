using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace HR.Application.Features.Companies.Commands.CreateCompany;

public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyCommand>
{
    private readonly IMapper mapper;
    private readonly ICompanyRepository repository;

    public CreateCompanyCommandHandler(IMapper mapper, ICompanyRepository repository)
    {
        this.mapper = mapper;
        this.repository = repository;
    }

    public async Task<CreateCompanyCommand> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<HR.Domain.Concrete.Company>(request);
        if (entity.ContractEndDate > DateTime.Now && entity.ContractStartDate<DateTime.Now)
        {
            entity.IsActive = true;
        }
        else
        {
            entity.IsActive = false;
        }
        var result = await repository.AddAsync(entity, cancellationToken);
        return mapper.Map<CreateCompanyCommand>(result);
    }


}



