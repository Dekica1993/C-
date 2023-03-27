using System;
namespace HomeworkClass07
{
    public class Contructor : Employee1
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Responsible Res { get; set; }
        

        public Contructor(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;

        }
       

        public override double GetSalary()
        {
            return WorkHours * PayPerHour;
        }
        public Responsible CurrentPosition(string res)
        {

            return Res;
        }

    }
    
}

    
	


