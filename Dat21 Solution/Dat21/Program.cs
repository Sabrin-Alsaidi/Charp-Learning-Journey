using Dat21.MyDbContext;

namespace Dat21;
class Program
{
    static void Main(string[] args)
    {
        #region Add to DB 
        //To add new record to the DB
        using applicationDbContext db = new applicationDbContext();
        Employee employee1 = new Employee() {emp_name="Saba",emp_age=27,emp_salary=11000 };
        db.Employees.Add(employee1);
        db.SaveChanges();


        #endregion
        #region update in Db 
        //To update in the DB  and then display 
        using applicationDbContext _db = new applicationDbContext();
        var emp = (from E in _db.Employees
                   where E.emp_id == 1
                   select E).FirstOrDefault();
        emp.emp_name = "Sabrin";
        _db.Employees.Update(emp);
        _db.SaveChanges();
        Console.WriteLine(emp?.emp_name ?? "NA");
        #endregion

    }
}

