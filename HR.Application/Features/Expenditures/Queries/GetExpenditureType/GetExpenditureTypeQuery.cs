using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Expenditures.Queries.GetExpenditureType;

public class GetExpenditureTypeQuery : IRequest<IEnumerable<ExpenditureType>>
{
}
