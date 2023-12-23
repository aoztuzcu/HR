using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.Commands.PersonUpdateByManager;
using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Commands.UpdateCompany;

public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdateCompanyCommand>
{
    private readonly IMapper mapper;
    private readonly ICompanyRepository companyRepository;

    public UpdateCompanyCommandHandler(IMapper mapper, ICompanyRepository companyRepository)
    {
        this.mapper = mapper;
        this.companyRepository = companyRepository;
    }

    public async Task<UpdateCompanyCommand> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Company>(request);
        var result = await companyRepository.UpdateAsync(entity, cancellationToken);
        return mapper.Map<UpdateCompanyCommand>(result);
    }
}
