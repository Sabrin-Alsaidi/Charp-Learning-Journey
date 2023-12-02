using System;
namespace Day_11
{
	public class Human
	{
		private static int cnt;
		private int id;
		private int age;
		private string name;
		private string address;
		private string email;

		


		public Human(string name , int age , string address, string email)
		{

			id = ++cnt;
            this.name = name;
			//this.age = ageValidation(age)? age :0;
			this.age = age;
			this.address = address;
			this.email = email;
		}
        #region encapsulation 
        public int getId()
		{
			return id;
		}
		public string getEgmail()
		{
			return email;
		}
		public void setEmail(string email)
		{
			this.email = email;
		}
        #endregion




        public string PrintData() => $" your name is {this.name} \n your age is {this.age} \n " +
			$"your address is {this.address} \n and your email is {this.email} .";

        public static bool ageValidation(int age)
        {
            if (age <= 0 || age >= 100)
            {
                return false;
            }
            return true;
        }
    }
	
}

