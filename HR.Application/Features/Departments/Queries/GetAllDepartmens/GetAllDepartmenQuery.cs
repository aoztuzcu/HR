using HR.Application.Features.Departments.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Departments.Queries.GetAllDepartmens;

public class GetAllDepartmenQuery : IRequest<IEnumerable<DepartmentVM>>
{

}
