using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.ViewModels;
using MediatR;

namespace HR.Application.Features.People.Queries.GetAllPersonByCompanyId;

public class GetAllPersonByCompanyIdQueryHandler : IRequestHandler<GetAllPersonByCompanyIdQuery, IEnumerable<PersonVM>>
{
    private readonly IPersonnelRepository personnelRepository;
    private readonly IMapper mapper;

    public GetAllPersonByCompanyIdQueryHandler(IPersonnelRepository personnelRepository, IMapper mapper)
    {
        this.personnelRepository = personnelRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<PersonVM>> Handle(GetAllPersonByCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var list = await personnelRepository.GetAllByCompanyIdIncludeAsync(request.CompanyId);
        return mapper.Map<IEnumerable<PersonVM>>(list);
    }
}
