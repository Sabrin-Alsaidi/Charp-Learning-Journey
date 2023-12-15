using System;
namespace Day13
{
	public class People :creature,INature
	{
		public int id;
		public string name;
		public int age;
		public int SNN;
		public string Address;

		public People(int id , string name, int age , int SNN , string Address)
		{
			this.name = name;
			this.age = age;
			this.SNN = SNN;
			this.Address = Address;
		}

        public override string ToString()
        {
			return $"Hello {this.name}";
        }


		public void Move()
		{
			Console.WriteLine("I'm Moving");
		}
		public void Eat()
		{
			Console.WriteLine("I'm eating ");
		}
		public void talk()
		{
			Console.WriteLine("I'm talking very well");
		}
    }
}

