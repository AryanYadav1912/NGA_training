using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleInheritance;

namespace MultipleInheritance
{
    internal interface IEmployee
    {
        void BasicDetails();
        void SalaryDetails();

    }
        interface IMeeting
    {

        void AttendMeetings();
        }



    
    class PermanentEmployee : IEmployee, IMeeting
    {
        public int EmpId { get; set; }
        public string EmpName {  get; set; }
        public int salary {  get; set; }
        public static string OrgName = "Wipro"; // shared among all instances
        public void BasicDetails()
        {
            Console.WriteLine($"Employee ID: {EmpId}, Employee Name: {EmpName} , Organisation: {OrgName}");
            
        }
        public void SalaryDetails()
        {
            Console.WriteLine($"Salary: {salary}");
        }
        public void AttendMeetings()
        {
            Console.WriteLine("Can Attend Meetings");

        }
    }

    class TemporaryEmployee : IEmployee, IMeeting
    {
        public int salaryPerDay { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public void BasicDetails()
        {
            Console.WriteLine($"Employee ID: {EmpId}, Employee Name: {EmpName} ");

        }
        public void SalaryDetails()
        {
            Console.WriteLine($"Salary: {salaryPerDay}");
        }
        public void AttendMeetings()
        {
            Console.WriteLine("Cannot Attend Meetings");

        }



    }
}
 
