using HR.Application.Features.Companies.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Queries.GetAllCompany;

public class GetAllCompanyQuery:IRequest<IEnumerable<CompanyListVM>>
{



}
