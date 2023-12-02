using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.AdvancePayments.Queries.GetAdvancePaymentListByPersonId;

public class GetAdvancePaymentListByPersonIdQueryHandler : IRequestHandler<GetAdvancePaymentListByPersonIdQuery, IEnumerable<AdvancePaymentVM>>
{
    private readonly IAdvancePaymentRepository advancePaymentRepository;
    private readonly IMapper mapper;

    public GetAdvancePaymentListByPersonIdQueryHandler(IAdvancePaymentRepository advancePaymentRepository, IMapper mapper)
    {
        this.advancePaymentRepository = advancePaymentRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<AdvancePaymentVM>> Handle(GetAdvancePaymentListByPersonIdQuery request, CancellationToken cancellationToken)
    {
        //var list = await advancePaymentRepository.get
        throw new NotImplementedException();
    }
}
