using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dat21.Models
{
	public class Department
	{
        //[key]
        //[DatabaseGnerated(DataGeneration Option).Identity)]
		public int dep_id { get; set; }
        public string dep_name { get; set; }
        public string dep_floor { get; set; }

        public List<Employee> employ { get; set; } = new List<Employee>();

    }
}

