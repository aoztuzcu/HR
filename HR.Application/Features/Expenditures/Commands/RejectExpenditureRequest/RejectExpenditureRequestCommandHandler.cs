using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace HR.Application.Features.Expenditures.Commands.RejectExpenditureRequest;

public class RejectExpenditureRequestCommandHandler : IRequestHandler<RejectExpenditureRequestCommand, RejectExpenditureRequestCommand>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;

    public RejectExpenditureRequestCommandHandler(IExpenditureRepository expenditureRepository, IMapper mapper)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
    }

    public async Task<RejectExpenditureRequestCommand> Handle(RejectExpenditureRequestCommand request, CancellationToken cancellationToken)
    {
        var model = await expenditureRepository.RejectByIdAsync(request.ExpenditureId, cancellationToken);
        return mapper.Map<RejectExpenditureRequestCommand>(model);
    }
}
