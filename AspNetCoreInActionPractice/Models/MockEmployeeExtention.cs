using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionPractice.Models
{
    public static class MockEmployeeExtention
    {
        public static List<Employee> ReadListOfEmployees(this MockEmployeeImplementation mock)
        {
            
           return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Mike",
                    LastName = "Benson",
                    Email = "mike@gmail.com",
                    Department = new Department(){Id=100, DepartmentName= ListOfDepartment.IT},
                    Gender = Gender.Male
                },

                 new Employee()
                {
                    EmployeeId = 2,
                    FirstName = "John",
                    LastName = "Brown",
                    Email = "john@outlook.com",
                    Department = new Department(){Id=100, DepartmentName= ListOfDepartment.IT},
                    Gender = Gender.Male
                },
                 new Employee()
                {
                    EmployeeId = 3,
                    FirstName = "Mary",
                    LastName = "Roberts",
                    Email = "mary@yahoo.com",
                    Department = new Department(){Id=200, DepartmentName= ListOfDepartment.HR},
                    Gender = Gender.Female
                },

                 new Employee()
                {
                    EmployeeId = 4,
                    FirstName = "Beatrice",
                    LastName = "Wilson",
                    Email = "beatrice@outlook.com",
                    Department = new Department(){Id=200, DepartmentName= ListOfDepartment.HR},
                    Gender = Gender.Female
                }
            };
        }
      

    }
}
