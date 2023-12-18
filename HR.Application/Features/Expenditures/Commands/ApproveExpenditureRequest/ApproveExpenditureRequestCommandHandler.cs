using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace HR.Application.Features.Expenditures.Commands.ApproveExpenditureRequest;

public class ApproveExpenditureRequestCommandHandler : IRequestHandler<ApproveExpenditureRequestCommand, ApproveExpenditureRequestCommand>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;

    public ApproveExpenditureRequestCommandHandler(IExpenditureRepository expenditureRepository, IMapper mapper)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
    }

    public async Task<ApproveExpenditureRequestCommand> Handle(ApproveExpenditureRequestCommand request, CancellationToken cancellationToken)
    {
        var model = await expenditureRepository.ApproveByIdAsync(request.ExpenditureId, cancellationToken);
        return mapper.Map<ApproveExpenditureRequestCommand>(model);
    }
}
