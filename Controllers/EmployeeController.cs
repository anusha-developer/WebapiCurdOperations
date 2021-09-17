using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebapiCurd.BussinessLayer;
using WebapiCurd.Models;

namespace WebapiCurd.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeBussiness employeeBussiness;
        public EmployeeController()
        {
            employeeBussiness = new EmployeeBussiness();
        }
        [HttpPost]
        [Route("api/Employee/save")]
        public Employee SaveEmployee([FromBody]Employee employee)
        {

            try
            {
                return employeeBussiness.SaveEmployee(employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }
        [HttpGet]
        [Route("api/Employee/GetById/{employeeId}")]
        public Employee fetchEmployeeById(int employeeId)
        {
            try
            {
                return employeeBussiness.GetEmployeeById(employeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/Employee/GetAll")]
        public List<Employee> fetchAllEmployees()
        {
            try
            {
                return employeeBussiness.GetAllEmployees();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpPut]
        [Route(" api/Employee/Update/{employeeId}")]
        public Employee UpdateEmployee(int employeeId, Employee employee)
        {
            try
            {
                return employeeBussiness.UpdateEmployee(employeeId, employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpDelete]
        [Route("api/Employee/DeleteById/{employeeId}")]
        public string DeleteEmployee(int employeeId)
        {
            try
            {
                return employeeBussiness.DeleteEmployee(employeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
