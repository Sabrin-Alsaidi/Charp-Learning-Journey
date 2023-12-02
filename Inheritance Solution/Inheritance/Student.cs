using System;
namespace Inheritance
{
	public class Student : Human
	{
		public string Qualification;
        public bool IsIntern;
        public int TotalGrad;
		public int StudyHours;

		public Student(string name, bool hasJob, int age, bool isMarried, string Qualification, bool IsIntern, int TotalGrad, int StudyHours) : base(name,  hasJob,  age, isMarried)
		{
			this.Qualification = Qualification;
			this.IsIntern = IsIntern;
			this.TotalGrad = TotalGrad;
			this.StudyHours = StudyHours;
		}
	}
}

