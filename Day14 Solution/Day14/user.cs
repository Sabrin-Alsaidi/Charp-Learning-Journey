using System;
namespace Day14
{
	public class user
	{

		public string name;
		public int age;
		public double salary;

		public user(string name, int age, double salary)
		{
			this.name = name;
			this.age = age;
			this.salary = salary;
		}

		public static double operator +(user a, user b)
		{
			double salary = a.salary + b.salary;
			return salary;
		}
	}
}

