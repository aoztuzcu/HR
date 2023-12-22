using HR.Application.Features.People.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.Queries.GetAllPersonByCompanyId;

public class GetAllPersonByCompanyIdQuery : IRequest<IEnumerable<PersonVM>>
{
    public Guid CompanyId { get; set; }
}
