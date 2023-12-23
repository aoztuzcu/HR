using HR.Application.Features.Departments.ViewModels;
using HR.Application.Features.People.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.Companies.ViewModels
{
    public class CompanyListVM
    {
        public Guid Id { get; set; }
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Display(Name = "Ünvanı")]
        public string Type { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Mail Adresi ")]
        public string Email { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string MersisNo { get; set; }
        public string TaxNo { get; set; }
        public string TaxOffice { get; set; }
        [Display(Name="Logo")]
        public string LogoUrl { get; set; }
        public string Address { get; set; }
        public int EmployeesCount { get; set; }
        public int EstablishmentYear { get; set; }
        public bool IsActive { get; set; }

    }
}
