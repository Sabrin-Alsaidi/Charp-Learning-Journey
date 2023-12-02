using System;
namespace Inheritance
{
	public class Human
	{
		public string Name;
		public bool hasJob;
		public int age;
		public bool isMarried;

		public Human(string name, bool hasJob,int age, bool isMarried)
		{
			this.Name = name;
			this.hasJob = hasJob;
			this.age = age;
			this.isMarried = isMarried;
		}

		public void Describe()
		{

		}
		
	}
}

