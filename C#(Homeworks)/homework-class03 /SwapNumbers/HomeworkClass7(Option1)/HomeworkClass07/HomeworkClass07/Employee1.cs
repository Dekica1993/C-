using System;
namespace HomeworkClass07
{
	public class Employee1
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Salary { get; set; }
		public RoleEnum Role { get; set; }

		public  virtual string GetInfo()
		{
			return $"FirstName: {FirstName} LastName:  {LastName} Salary: {Salary}";
		}
		public virtual double GetSalary()
		{
			return Salary;
		}
	}
}

