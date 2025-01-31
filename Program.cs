using System.Collections;
using MultipleInheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        PermanentEmployee employee = new PermanentEmployee() { EmpId = 1, EmpName ="Aryan", salary=80000 };
        employee.BasicDetails();
        employee.SalaryDetails();
        employee.AttendMeetings();

        TemporaryEmployee temp = new TemporaryEmployee() { EmpId = 10, EmpName = "Abhishek", salaryPerDay = 40000 };
        temp.BasicDetails();
        temp.SalaryDetails();
        temp.AttendMeetings();
    }

}