using System;
namespace Day13
{
	public class Employee:People
	{
		string role;
		int workingHours;
		double wages;

		public Employee(int id, string name, int age, int SNN, string Address, string role, int workingHours, double wages):base(id,name,age,SNN,Address)
		{
			this.role = role;
			this.workingHours = workingHours;
			this.wages = wages;
		}
        public override string ToString()
        {
			return base.ToString() + $" your role is {this.role}";
        }
    }
}

