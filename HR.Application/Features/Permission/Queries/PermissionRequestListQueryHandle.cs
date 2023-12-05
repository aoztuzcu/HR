using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.Expenditures.Queries.GetExpenditureListByPersonId;
using HR.Application.Features.Expenditures.ViewModels;
using HR.Application.Features.Permission.ViewModels;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Queries
{
    //public class PermissionRequestListQueryHandle : IRequestHandler<GetPermissionListQuery>, IEnumerable<PermissionRequestListVM>
    //{
    //    private readonly IPermissionRequestRepository permissionRequestRepository;
    //    private readonly IMapper mapper;



    //    public PermissionRequestListQueryHandle(IPermissionRequestRepository permissionRequestRepository, IMapper mapper)
    //    {
    //        this.permissionRequestRepository = permissionRequestRepository;
    //        this.mapper = mapper;
    //    }

    //    public IEnumerator<PermissionRequestListVM> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task Handle(GetPermissionListQuery request, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}
