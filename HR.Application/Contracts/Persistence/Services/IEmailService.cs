using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Contracts.Persistence.Services;

public interface IEmailService
{
    Task SendConfirmMail(string mailAddress,string sendPassword, string managerInfo);
    Task SendConfirmMailByAdmin(string mailAddress, string sendPassword, string adminInfo);
}
