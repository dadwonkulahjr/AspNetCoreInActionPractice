using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionPractice.Models
{
    public class MockEmployeeImplementation : IEmployee
    {     
        public MockEmployeeImplementation()
        {
            this.ReadListOfEmployees();
        }
        public Employee CreateEmployee(Employee employee)
        {
            employee.EmployeeId = this.ReadListOfEmployees().Max(x => x.EmployeeId) + 1;
            this.ReadListOfEmployees().Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
           Employee employee = this.ReadListOfEmployees().FirstOrDefault(x => x.EmployeeId == id);
           if(employee != null)
            {
                return employee;
            }
            else { throw new Exception($"The employee with {id.ToString()} cannot be found."); }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return this.ReadListOfEmployees();
        }

        public Employee SelectEmployee(int id)
        {
          return this.ReadListOfEmployees().FirstOrDefault(x => x.EmployeeId == id);
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            Employee employee = this.ReadListOfEmployees().FirstOrDefault(x => x.EmployeeId == employeeChanges.EmployeeId);
            if (employee != null)
            {
                employee.FirstName = employeeChanges.FirstName;
                employee.LastName = employeeChanges.LastName;
                employee.Email = employeeChanges.Email;
                employee.Gender = employeeChanges.Gender;
                employee.Department.DepartmentName = employeeChanges.Department.DepartmentName;
                employee.Department.Id = employeeChanges.Department.Id;
                return employee;
                
            }
            else { throw new Exception($"The employee with {employeeChanges.ToString()} cannot be found neither updated."); }
        }


    }
}
