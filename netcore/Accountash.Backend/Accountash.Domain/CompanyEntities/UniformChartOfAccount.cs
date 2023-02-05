using Accountash.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Domain.CompanyEntities
{
    // UniformChartOfAccount = hesap planı
    public sealed class UniformChartOfAccount : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; } // Ana grup, grup, muavin
    }
}
