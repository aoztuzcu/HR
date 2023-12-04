using HR.Application.Features.Expenditures.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureListByPersonId;

public class GetExpenditureListByPersonIdQuery : IRequest<IEnumerable<ExpenditureListVM>>
{
    public Guid PersonnelId { get; set; }
}
