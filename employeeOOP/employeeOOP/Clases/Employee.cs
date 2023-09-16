using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Clases
{
    public abstract class Employee
    {
        #region "Properties"
        public int Id { get; set; } // Usamos la propiedad Elvis "?" para que permita valor nuleables
                                    // o vacios si es un string, parecido a cuando iniciamos por defecto un constructor
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? BirthDate { get; set; }
        public Date? HireDate { get; set; }
        public bool? IsActive { get; set; }

        #endregion

        #region "Private methods"

        #endregion

        #region "Public methods"
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"Informacion empleado \n\t" +
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de Cumpleaños: {BirthDate}\n\t" +
                $"Fecha de Contratacion:{HireDate}\n\t" +
                $"Empleado activo?:{IsActive}\n\t";
        }

        #endregion


    }
}
