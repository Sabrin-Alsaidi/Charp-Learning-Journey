using System;
using System.Collections.Generic;

namespace DatabaseFirtst.Entities
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public int? EmpAge { get; set; }
        public int? EmpSalary { get; set; }
        public int? DId { get; set; }

        public virtual Departmant? DIdNavigation { get; set; }
    }
}
