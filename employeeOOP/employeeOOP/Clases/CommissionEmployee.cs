using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public abstract class CommissionEmployee : Employee
    {

        #region "Properties"

        public int CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        #endregion


    }
}
