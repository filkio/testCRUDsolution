using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCRUDsolution.Models
{
    public static class Repository
    {
        public static void AddEmployee(Employee employee)
        {
            using (EmployeeDbContext context = new EmployeeDbContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }
        public static List<Employee> GetEmployeesFromDb()
        {
            using (EmployeeDbContext context = new EmployeeDbContext())
            {
                List<Employee> employeesFromDb = context.Employees.ToList();
                return employeesFromDb;
            }
        }
    }
}
