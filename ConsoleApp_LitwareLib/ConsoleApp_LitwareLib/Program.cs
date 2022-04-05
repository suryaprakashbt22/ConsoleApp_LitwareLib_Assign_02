// See https://aka.ms/new-console-template for more information

using ConsoleAppLitwareLib;

Console.WriteLine("------------EMPLOYEE MANAGEMENT SYSTEM FOR LITWARE ORGANISATION------------\n\n");

Console.WriteLine("-------HR staff member registers newly joined Employee-------\n\n");

Console.WriteLine("-------NEW EMPLOYEE REGISTRATION-------\n");

Employee newEmployee=new Employee(); // new object created


Console.WriteLine("Enter the Emp ID/Employee No. of the new Joinee");
try
{
    newEmployee.empNumber = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);  
}

Console.WriteLine("Enter the Name of the new Joinee");
try
{
    newEmployee.empName = Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Enter the Salary of the new Joinee");
try
{
    newEmployee.salary = Convert.ToDouble(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\n**********DETAILS OF THE NEW EMPLOYEE**********\n");
Console.WriteLine("Employee ID/No. : {0}",newEmployee.empNumber);
Console.WriteLine("Employee Name : {0}", newEmployee.empName);
double newEmployeeSalary = newEmployee.salary;

//Invoking the respective methods to calculate HRA, TA, DA

newEmployee.calculate_TA(newEmployeeSalary);
newEmployee.calculate_DA(newEmployeeSalary);
newEmployee.calculate_HRA(newEmployeeSalary);



Console.WriteLine("Employee Gross Salary : {0}", newEmployee.grossSalary(newEmployeeSalary));
