using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Persistance.Constans
{
    public static class TableNames
    {
        private static string uniformChartOfAccounts = nameof(UniformChartOfAccounts);

        public static string UniformChartOfAccounts { get => uniformChartOfAccounts; set => uniformChartOfAccounts = value; }
    }
}
