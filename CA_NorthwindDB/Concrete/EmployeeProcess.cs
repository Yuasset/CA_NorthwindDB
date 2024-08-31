using CA_NorthwindDB.Models;
using CA_NorthwindDB.Abstracts;

namespace CA_NorthwindDB.Concrete
{
    internal class EmployeeProcess : IEmployeProcess
    {
        //NorthwindContext dbContext = new NorthwindContext();

        public void EmployeeListFistname(string firstname)
        {
            var employeeData = Process.dbContext.Employees.Select(employees => employees).Where(employees => employees.FirstName == firstname).ToList();
            foreach (var item in employeeData)
            {
                Console.WriteLine($"Ad: {item.FirstName} Soyad: {item.LastName}");
            }
        }

        public void EmployeeListFistAndLastname(string firstname, string lastname)
        {
            var employeeData = Process.dbContext.Employees.Select(employees => employees).Where(employees => employees.FirstName == firstname && employees.LastName == lastname).ToList();
            foreach (var item in employeeData)
            {
                Console.WriteLine($"Ad: {item.FirstName} Soyad: {item.LastName}");
            }
        }


    }
}
