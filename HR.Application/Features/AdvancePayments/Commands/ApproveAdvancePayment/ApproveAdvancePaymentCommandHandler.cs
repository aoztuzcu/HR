using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Commands.ApproveAdvancePayment;

public class ApproveAdvancePaymentCommandHandler : IRequestHandler<ApproveAdvancePaymentCommand, ApproveAdvancePaymentCommand>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IMapper mapper;

    public ApproveAdvancePaymentCommandHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper)
    {
        this.advancePaymentRepository = advancePaymentRepository;
        this.mapper = mapper;
    }

    public async Task<ApproveAdvancePaymentCommand> Handle(ApproveAdvancePaymentCommand request, CancellationToken cancellationToken)
    {
        var model = await advancePaymentRepository.ApproveByIdAsync(request.AdvancePaymentId, cancellationToken);
        return mapper.Map<ApproveAdvancePaymentCommand>(model);
    }
}
