using System;
namespace Day_15
{
	public class Report
	{
		public void TotalSalaryMoreThan60K(Employee[] emp)
		{
			Console.WriteLine("Employee with total salaery more than 60K");
			Console.WriteLine("----------------------");
			foreach (Employee e in emp)
			{
				if (e.TotalSalary >= 60000)
				{
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.TotalSalary}");

                }
            }
            Console.WriteLine();
		}

        public void TotalSalaryLessThan30K(Employee[] emp)
        {
            Console.WriteLine("Employee with total salaery less than 30K");
            Console.WriteLine("----------------------");
            foreach (Employee e in emp)
            {

                if (e.TotalSalary < 30000)
                {
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.TotalSalary}");

                }
            }
            Console.WriteLine();
        }
        public void TotalSalaryLessThan60KandMoreThan30K(Employee[] emp)
        {
            Console.WriteLine("Employee with total salaery Less than 60K and more than 30K");
            Console.WriteLine("----------------------");
            foreach (Employee e in emp)
            {

                if (e.TotalSalary < 60000 && e.TotalSalary >= 30000)
                {
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.TotalSalary}");

                }
            }
            Console.WriteLine();
        }

        public delegate bool ReportConditions(Employee emp);
        public void SalaryReport(Employee[] emp, string Titel,ReportConditions con )
        {
            foreach(Employee e in emp)
            {
                if (con(e))
                {
                    Console.WriteLine($"{e.id} | {e.name} | {e.gender} | {e.TotalSalary}");

                }
            }
            Console.WriteLine();

        }


    }

}


