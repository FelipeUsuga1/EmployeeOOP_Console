using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeOOP.Exceptions;

namespace EmployeeOOP.Clases
{
    public class Date
    {
        #region "Fields"
        private int _year;
        private int _month; 
        private int _day;

        #endregion

        #region "Constructor"
        public Date(int day, int month, int year)  //Nota: con el comando "ctor" y doble tab podemos crear un constructor de forma rapida
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month); 
            _day = ValidateDay(day, month, year);     
        }
        #endregion

        #region "Private methods"

        private bool isLeapYear(int year)
        { //Valida si un año es bisesto o no, si lo es, regresa un true y si no es un false
            return year % 400 == 0 || year % 4 == 0 && year % 100 == 0;
        }

        private int ValidateDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && isLeapYear(year))
            {
                return day;
            }
            if (month == 2 && day == 29 && isLeapYear(year))
            {
                bool isleapyear = false;
                IsLeapYearException(isleapyear, year); // Aca llamamos al metodo que nos trae la excepcion para que no se rompa el codigo.
            }

            int[] daysPerMonth = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};


            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;

            }
            else {
                throw new DayException(string.Format("El dia {0} no es valido para el mes {1}.", day, month));

            }

        }   

        private void IsLeapYearException(bool isLeapYear, int year){ //Creamos este metodo para encapsular la excepcion y que no se rompa el codigo cuando no se cumpla

            if (!isLeapYear)
            {
                throw new YearException(string.Format("El año {0} no es bisiesto.", year));
            }
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            else {
                //Creacion de la excepcion
                throw new MonthException(string.Format("El mes {0} no es valido."), month); //Aqui  creamos la clase "MonthException" dando click en crear nueva clase
            }
        
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Creacion de la excepcion
                throw new YearException(string.Format("El año {0} no es valido."), year);
            }

        }

        #endregion

        #region "Public methods"
        public override string ToString() //Metodo sobreescrito con herencia de la clase "object", esta clase tiene metodos que podemos usar
        {
            //3 formas de concatenar una variable
            var dateConcatenated1 = _day + "/" + _month + "/" + _year; //La mas vieja y fea
            var dateConcatenated2 = $"{_day:00}/{_month:00}/{_year:0000}"; //  Interpolacion, Nota: los ceros en interpolacion es para formatear las fechas y que solo tengan esos digitos.
            var dateConcatenated3 = string.Format("{0:00}/{1:00}/{2:0000}", _day, _month, _year); // Claas string.format

            return dateConcatenated3;
        }

        #endregion
    }
}
