using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.Queries.GetlAllPerson;

public class GetAllPersonQuery : IRequest<IEnumerable<PersonVM>>
{
}
