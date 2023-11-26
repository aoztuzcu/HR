using HR.Application.Features.People.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.Queries.GetPerson;

public class GetPersonQuery : IRequest<PersonDetailVM>
{
    public Guid Id { get; set; }
}
