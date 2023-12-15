using System;
using System.Collections.Generic;

namespace DatabaseFirtst.Entities
{
    public partial class Departmant
    {
        public Departmant()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepId { get; set; }
        public string DepName { get; set; } = null!;
        public string? DepLocation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
