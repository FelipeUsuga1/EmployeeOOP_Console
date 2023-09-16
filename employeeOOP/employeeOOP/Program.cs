// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Clases;
try
{
    int day, month, year;
    Console.WriteLine("OOP Application");
    Console.WriteLine("----------------");

    Console.Write("Ingrese el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el año: ");
    year = Convert.ToInt32(Console.ReadLine());
    //Inicializacion de la clase date, el metodo main ya esta creado implicitamente (no se ve)

    Date dateobject = new Date(day, month, year);
    Console.WriteLine(dateobject.ToString());

}
catch(Exception ex) { 
    Console.WriteLine(ex.Message);   
}    






