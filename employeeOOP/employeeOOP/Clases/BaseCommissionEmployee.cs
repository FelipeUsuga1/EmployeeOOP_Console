using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region "Properties"
        public decimal Base { get; set; }

        #endregion

        #region "Constructor"
        public BaseCommissionEmployee()
        {
                
        }


        #endregion

        #region "Public methods"
        public override decimal GetValueToPay()
        {
            decimal commission;
            commission = Sales * (CommissionPercentaje / 100);
            Base = Base + commission;  
            return Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Total a pagar: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}
