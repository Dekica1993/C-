using System;
namespace HomeworkClass07
{
	public class Employee3:Employee1
	{
        public Employee3 (string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = RoleEnum.Employee;
        }

    }
}

