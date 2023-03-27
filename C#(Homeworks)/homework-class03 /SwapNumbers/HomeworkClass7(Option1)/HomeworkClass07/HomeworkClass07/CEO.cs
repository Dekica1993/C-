using System;
using HomeworkClass07;

namespace HomeworkClass07
{
	public class CEO : Employee1
	{
        public CEO(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            

        }
        public string[] Employees = { "Employees:", "Dejan", "Tose", "Marija", "Viktorija", "Darko" };
		public int SharesProperty { get; set; }
		protected double SharesPrice { get; set; }
        public double Shares { get;  set; }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
        public double AddSharesPrice(double SharesPrice)
		{
			return SharesPrice;
		}
        public string PrintEmployees()
        {
            return Employees;
          
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
           
           

        }

        
    }
	
}



