using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class SalaryEmployee : Employee
    {
        #region "Properties"

        public decimal Salary { get; set; }

        #endregion

        #region "Constructor"
        public SalaryEmployee()
        {
                
        }
        #endregion

        #region "Public methods"

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Devengado: {Salary:C2}\n\t";
        }

        #endregion

    }
}
