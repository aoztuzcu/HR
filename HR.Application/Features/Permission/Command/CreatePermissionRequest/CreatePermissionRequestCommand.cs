using HR.Application.Features.EnumViewModels;
using HR.Application.Features.Permission.ViewModels;
using MediatR;

namespace HR.Application.Features.Permission.Command.CreatePermissionRequest;

public class CreatePermissionRequestCommand : IRequest<CreatePermissionRequestCommand>
{
    public Guid PersonId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public float Days { get; set; }
    public ApprovalStatusVM ApprovalStatus { get; set; } = ApprovalStatusVM.ApprovalWaiting;
    public DateTime ApprovedDate { get; set; }
    public Guid PermissionTypeId { get; set; }
   public PermissionTypeVM PermissionType { get; set; }
     
    
}
