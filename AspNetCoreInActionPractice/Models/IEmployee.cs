using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionPractice.Models
{
    public interface IEmployee
    {
        #region IEmployee Repository represents the Business Logic...
        //This Interface is use to perform all
        //the CRUD Operations on an Employee Object...
        //Using Depencies Injection......
        Employee SelectEmployee(int id);
        IEnumerable<Employee> GetEmployees();
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
        #endregion
    }
}
