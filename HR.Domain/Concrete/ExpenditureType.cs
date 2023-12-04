using HR.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Concrete;

public class ExpenditureType : BaseEntity
{
    public string Name { get; set; }
    public decimal MinAmount { get; set; }
    public decimal MaxAmount { get; set; }
   

    public virtual IEnumerable<Expenditure> Expenditures { get; set; }
}
