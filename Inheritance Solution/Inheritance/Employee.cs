using System;
namespace Inheritance
{
	public class Employee : Human
	{
		public string Role;
        public string department;
        public int WorkingHours;
        public int wage;

		public Employee (string name, bool hasJob, int age, bool isMarried ,string Role, string department, int WorkingHours, int wage):base ( name,  hasJob,  age,  isMarried)
		{
			this.Role = Role;
			this.department = department;
			this.WorkingHours = WorkingHours;
			this.wage = wage;
		}
		public double CalculateSalary(double salary)
		{
			double Salary = wage * WorkingHours;
			double TotalSalary = Salary * 0.3;
			return TotalSalary;
		


        }
	}
}

