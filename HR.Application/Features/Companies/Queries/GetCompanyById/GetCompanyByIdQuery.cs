using HR.Application.Features.Companies.ViewModels;
using HR.Domain.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Queries.GetCompanyById;

public class GetCompanyByIdQuery : IRequest<CompanyVM>
{
    public Guid Id { get; set; }

}
