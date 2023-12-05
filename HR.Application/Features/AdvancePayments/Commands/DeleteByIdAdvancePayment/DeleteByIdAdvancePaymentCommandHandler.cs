using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.AdvancePayments.Commands.DeleteByIdAdvancePayment;

public class DeleteByIdAdvancePaymentCommandHandler : IRequestHandler<DeleteByIdAdvancePaymentCommand, DeleteByIdAdvancePaymentCommand>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IMapper mapper;

    public DeleteByIdAdvancePaymentCommandHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper)
    {
        this.advancePaymentRepository = advancePaymentRepository;
        this.mapper = mapper;
    }

    public async Task<DeleteByIdAdvancePaymentCommand> Handle(DeleteByIdAdvancePaymentCommand request, CancellationToken cancellationToken)
    {
        var result = await advancePaymentRepository.DeleteByIdAsync(request.AdvancePaymentId, cancellationToken);
        return mapper.Map<DeleteByIdAdvancePaymentCommand>(result);
    }
}
