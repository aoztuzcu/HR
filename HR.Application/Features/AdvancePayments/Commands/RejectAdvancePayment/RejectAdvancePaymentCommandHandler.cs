using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;

namespace HR.Application.Features.AdvancePayments.Commands.RejectAdvancePayment;

public class RejectAdvancePaymentCommandHandler : IRequestHandler<RejectAdvancePaymentCommand, RejectAdvancePaymentCommand>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IMapper mapper;

    public RejectAdvancePaymentCommandHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper)
    {
        this.advancePaymentRepository = advancePaymentRepository;
        this.mapper = mapper;
    }

    public async Task<RejectAdvancePaymentCommand> Handle(RejectAdvancePaymentCommand request, CancellationToken cancellationToken)
    {
        var model = await advancePaymentRepository.RejectByIdAsync(request.AdvancePaymentId, cancellationToken);
        return mapper.Map<RejectAdvancePaymentCommand>(model);
    }
}
