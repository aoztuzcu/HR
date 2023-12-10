using HR.Application.Features.Jobs.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Jobs.Queries.GetAllJobQuery;

public class GetAllJobQuery : IRequest<IEnumerable<JobVM>>
{
}
