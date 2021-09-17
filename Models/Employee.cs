using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebapiCurd.Models
{
    public class Employee
    {
        private int employeeId;
        private string empName;
        private string empEmailId;
        private long empPhoneno;
        private string empAddress;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public string EmpEmailId { get => empEmailId; set => empEmailId = value; }
        public long EmpPhoneno { get => empPhoneno; set => empPhoneno = value; }
        public string EmpAddress { get => empAddress; set => empAddress = value; }
    }
}