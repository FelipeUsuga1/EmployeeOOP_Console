// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Clases;
try
{
    int day, month, year;
    string firstName, lastName;
    decimal salary;
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
    Console.WriteLine("\n");
    Console.WriteLine(dateobject.ToString());

    Console.Write("Ingrese su nombre: ");
    firstName = Console.ReadLine();
    Console.Write("Ingrese sus apellidos: ");
    lastName = Console.ReadLine();
    Console.Write("Ingrese su salario: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee() {
        Id = 12345,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateobject,
        HireDate = dateobject,
        IsActive = true,
        Salary = salary, //Otra forma de hacer el casting
    };

    Console.WriteLine(salaryEmployee.ToString());

}
catch(Exception ex) { 
    Console.WriteLine(ex.Message);   
}    






