using AutoMapper;
using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Features.AdvancePayments.ViewModels;
using HR.Application.Features.People.Commands.PersonUpdate;
using HR.Application.Features.People.ViewModels;
using HR.Application.Features.Permission.ViewModels;
using HR.Domain.Concrete;
using HR.Domain.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest
{
    public class CreatePermissionRequestCommandHandler : IRequestHandler<CreatePermissionRequestCommand, CreatePermissionRequestCommand>
    {
        private readonly IPermissionRequestRepository repository;
        private readonly IPersonnelRepository personnelRepository;
        private readonly IMapper mapper;

        public CreatePermissionRequestCommandHandler(IPermissionRequestRepository repository, IMapper mapper, IPersonnelRepository personnelRepository)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.personnelRepository = personnelRepository;
        }

        public async Task<CreatePermissionRequestCommand> Handle(CreatePermissionRequestCommand request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
            var personel = await personnelRepository.GetByIdAsync(request.PersonId, cancellationToken);
            var gender = personel.Gender;
=======
            var permissionRequest = mapper.Map<PermissionRequest>(request);
            var gender = repository.GetByGender(permissionRequest.PersonnelId, cancellationToken);//cinsiyet geldi
>>>>>>> main

               

            return mapper.Map<CreatePermissionRequestCommand>(personel);
        }
        // izin türlerine göre şartlar metodları yaz
       
    }
}
