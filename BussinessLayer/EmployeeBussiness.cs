using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebapiCurd.DataAccessLayer;
using WebapiCurd.Models;

namespace WebapiCurd.BussinessLayer
{
    public class EmployeeBussiness
    {
        private EmployeeDataAccessimpl employeeDataAccessimpl;
         public EmployeeBussiness()
        {
            employeeDataAccessimpl = new EmployeeDataAccessimpl();
        }
        public Employee SaveEmployee(Employee employee)
        {
            return employeeDataAccessimpl.CreateEmployee(employee);
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return employeeDataAccessimpl.GetEmployeeById(employeeId);
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDataAccessimpl.GetAllEmployees();
        }
        public Employee UpdateEmployee(int employeeId, Employee employee)
        {
            return employeeDataAccessimpl.UpdateEmployee(employeeId, employee);
        }
        public string DeleteEmployee(int employeeId)
        {
            return employeeDataAccessimpl.DeleteEmployee(employeeId);
        }
    }
}