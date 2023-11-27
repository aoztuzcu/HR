using HR.Application.Features.Jobs.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Jobs.Queries.GetJobByIdQuery;

public class GetJobByIdQuery : IRequest<JobVM>
{
    public Guid Id { get; set; }
}
