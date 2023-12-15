using System;
using System.ComponentModel.DataAnnotations.Schema;
using Dat21.Models;

namespace Dat21
{
    public class Employee
	{
        //[key]
        //[DatabaseGnerated(DataGeneration Option).Identity)]
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public int emp_age { get; set; }
        public double emp_salary { get; set; }
        public int? depId { get; set; }
        public Department? department { get; set; }
        public ICollection<Projects> project { get; set; } = new List<Projects>();


    }
}

