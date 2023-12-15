using System.Reflection;
using System.Xml.Linq;

namespace Day_15;
class Program
{
    static void Main(string[] args)
    {
        Employee[] emp = new Employee[]
        {
            new Employee{id=1,name="Sabrin",gender="Female",TotalSalary=70000m},
            new Employee{id=2,name="Abdullah",gender="Male",TotalSalary=15000m},
            new Employee{id=3,name="Saba",gender="Female",TotalSalary=30000m},
            new Employee{id=4,name="Mohammed",gender="Male",TotalSalary=27000m},
            new Employee{id=5,name="Raya",gender="Female",TotalSalary=82000m},
            new Employee{id=6,name="Salim",gender="Male",TotalSalary=60000m},
            new Employee{id=7,name="Mytham",gender="Male",TotalSalary=31000m},
            new Employee{id=8,name="Salma",gender="Female",TotalSalary=710000m},
            new Employee{id=9,name="Huda",gender="Female",TotalSalary=20000m},
            new Employee{id=10,name="Humood",gender="Male",TotalSalary=440000m},

        };
        Report report = new Report();
        report.TotalSalaryMoreThan60K(emp);
        report.TotalSalaryLessThan30K(emp);
        report.TotalSalaryLessThan60KandMoreThan30K(emp);
        Console.WriteLine("-------------------------------------");
        //it saves in the memory
        bool SalaryMoreThan60K(Employee emp) => emp.TotalSalary >= 60000;
        bool SalaryLessThan30K(Employee emp) => emp.TotalSalary < 30000;
        bool SalaryBetween60Kand30K(Employee emp) => emp.TotalSalary < 60000 && emp.TotalSalary >= 30000;
        //  sent the condition as a refrence 
        report.SalaryReport(emp,"Employee who's salary more than 60K ",SalaryMoreThan60K);
        report.SalaryReport(emp, "Employee who's salary Less than 60K ", SalaryLessThan30K);
        report.SalaryReport(emp, "Employee who's salary between 60K and 30K ", SalaryBetween60Kand30K);
        Console.WriteLine("-------------------------------------");
        //it do not save in the memory
        //                                            this emp is from the delegate function
        report.SalaryReport(emp, "Female Employees ", (emp) => emp.gender == "Female");
        report.SalaryReport(emp, "Male Employees ", (emp) => emp.gender == "Male");

        Console.WriteLine("-------------------------------------");
        //Generics:
        Print(3);
        Print("Sabrin");
        Print(true);
        Print(3.1);




    }

    //Generic:
    public static void Print<T>(T val)
    {
        Console.WriteLine(val);
        Console.WriteLine(typeof(T));
        Console.WriteLine();


    }
}

