using System;
namespace Day_11
{
	public class Employees
	{
		private int id;
		private string Fname;
		private string Lname;
		private string address;


		public Employees(string Fname, string Lname,string address)
		{
			//this.id = id;
			this.Fname = Fname;
			this.Lname = Lname;
			this.address = address;
		}
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}
		public string FName
		{
			get { return this.Fname; }
			set { this.Fname = value; }
		}

	}
}

