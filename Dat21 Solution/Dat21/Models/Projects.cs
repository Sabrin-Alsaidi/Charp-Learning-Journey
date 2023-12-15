using System;
namespace Dat21.Models
{
	public class Projects
	{
		public int P_id { get; set; }
        public int P_name { get; set; }
        public int P_description { get; set; }

        public ICollection<Employee> employ { get; set; } = new List<Employee>();


    }
}

