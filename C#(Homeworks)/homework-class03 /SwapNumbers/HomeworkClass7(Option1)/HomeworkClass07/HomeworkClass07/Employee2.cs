using System;
namespace HomeworkClass07
{
	public class Employee2 : Employee1
	{
		public Employee2 (string firstName,string lastName, double salary)
		{
			FirstName = firstName;
			LastName = lastName;
			Salary = salary;
			Role = RoleEnum.Employee;
		}

	}
		
}

