using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest
{
    public class CreatePermissionRequestCommandHandler : IRequestHandler<CreatePermissionRequestCommand, CreatePermissionRequestCommand>
    {
        private readonly IPermissionRequestRepository repository;
        private readonly IMapper mapper;

        public CreatePermissionRequestCommandHandler(IPermissionRequestRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CreatePermissionRequestCommand> Handle(CreatePermissionRequestCommand request, CancellationToken cancellationToken)
        {
            var permissionRequest = mapper.Map<PermissionRequest>(request);
            var gender = repository.GetByGender(permissionRequest.PersonId, cancellationToken);//cinsiyet geldi

            //if (gender == 1)
            //{

            //}
            return mapper.Map<CreatePermissionRequestCommand>(permissionRequest);//hata vermesin diye result değilde permissionrequest döndürdüm
        }
    }
}
