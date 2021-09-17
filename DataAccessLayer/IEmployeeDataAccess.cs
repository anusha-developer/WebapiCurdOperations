using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebapiCurd.Models;

namespace WebapiCurd.DataAccessLayer
{
    interface IEmployeeDataAccess
    {
      
        Employee CreateEmployee(Employee employee);

         string DeleteEmployee(int employeeId);

         Employee GetEmployeeById(int employeeId);
          Employee UpdateEmployee(int employeeId, Employee employee);


         List<Employee> GetAllEmployees();

    }
}