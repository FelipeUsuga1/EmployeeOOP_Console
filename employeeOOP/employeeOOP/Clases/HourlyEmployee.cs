using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public abstract class HourlyEmployee : Employee
    {
        #region "Properties"
        public int Hours { get; set; }
        public decimal HoursValue { get; set; }

        #endregion

        #region "Public methods"
        public override decimal GetValueToPay()
        {
            decimal total;
            total = Hours*HoursValue;
            return total;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Total a pagar: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
