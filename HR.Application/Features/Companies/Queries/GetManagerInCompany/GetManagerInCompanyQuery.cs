using HR.Application.Features.Companies.ViewModels;
using HR.Application.Features.People.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.Queries.GetManagerInCompany;

public class GetManagerInCompanyQuery: IRequest<IEnumerable<ManagerInCompaniesVM>>
{

}
