using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.Permission.Command.DeleteByIdPermissionRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Commands.DeleteByIdExpenditure;

public class DeleteByIdExpenditureCommandHandler : IRequestHandler<DeleteByIdExpenditureCommand, DeleteByIdExpenditureCommand>
{
    private readonly IExpenditureRepository expenditureRepository;
    private readonly IMapper mapper;

    public DeleteByIdExpenditureCommandHandler(IExpenditureRepository expenditureRepository, IMapper mapper)
    {
        this.expenditureRepository = expenditureRepository;
        this.mapper = mapper;
    }
    public async Task<DeleteByIdExpenditureCommand> Handle(DeleteByIdExpenditureCommand request, CancellationToken cancellationToken)
    {
        var expenditure = await expenditureRepository.DeleteByIdAsync(request.ExpenditureId, cancellationToken);
        return mapper.Map<DeleteByIdExpenditureCommand>(expenditure);
    }
}
