using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.ViewModels;

public class ManagerInCompaniesVM
{
    [DisplayName("İsim")]
    public string Name { get; set; }
    public string? SecondName { get; set; }

    [DisplayName("İsim")]
    public string  FullName{ get { return Name + " " + SecondName; } }
    [DisplayName("Soyisim")]
    public string Surname { get; set; }
    [DisplayName("Mail")]

    public string Email { get; set; }
    [DisplayName("Fotoğraf")]
    public string Photo { get; set; }
    public Guid CompanyId { get; set; }
    [DisplayName("Çalıştığı Şirket")]
    public CompanyVM Company { get; set; }
}
