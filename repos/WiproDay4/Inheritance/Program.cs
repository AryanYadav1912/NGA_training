using Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");

        Employee emp = new Employee();
        emp.EmpId = 1;
        emp.EmpName = "Aryan";
        emp.display();

        Department dp = new Department();
        Console.WriteLine("Department class");
        dp.Dept = "Developer";
        dp.EmpId = 1;
        dp.EmpName = "Aryan";
        dp.Salary = 90000;
        dp.display();

        Manager mg = new Manager();
        mg.mgrName = "John";
        mg.EmpId = 1;
        mg.Salary = 40000;
        mg.Dept = "HR";
        mg.display();
    }
}