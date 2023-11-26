using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Features.People.ViewModels;

public class PersonVM
{
    //Özet bilgiler; fotoğraf, ad, soyad, mail, telefon, adres, meslek, departman buradaki ad soyad ikincileri de barındırıcak (en sağ üst fotoğraf) Dikdörtgen bir şekilde cardda özet bilgilerimi görmek istiyorum. 
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Mail { get; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Photo { get; set; }
    //public Guid JobId { get; set; }
    //public Job Job { get; set; }
    //public Guid DepartmentId { get; set; }
    //public Department Department { get; set; }
    public string DepartmentName { get; set; }
    public string JobName { get; set; }
}
