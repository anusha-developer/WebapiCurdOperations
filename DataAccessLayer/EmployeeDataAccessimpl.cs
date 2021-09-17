using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebapiCurd.Connection;
using WebapiCurd.Models;

namespace WebapiCurd.DataAccessLayer
{
    public class EmployeeDataAccessimpl
    {
        SqlConnection con = null;
        public Employee CreateEmployee(Employee employee)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Employee values('" + employee.EmpName + "','" + employee.EmpEmailId + "','" + employee.EmpPhoneno + "'," +
                    "'" + employee.EmpAddress + "')", con);
                cmd.ExecuteNonQuery();
                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return employee;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from  Tbl_Employee   where EmployeeId=" + employeeId, con);
                Employee employee = new Employee();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    employee = new Employee();
                    employee.EmployeeId= Convert.ToInt32(sdr["EmployeeId"]);
                    employee.EmpName = Convert.ToString(sdr["EmpName"]);
                    employee.EmpEmailId = Convert.ToString(sdr["EmpEmailId"]);
                    employee.EmpPhoneno = Convert.ToInt64(sdr["EmpPhoneno"]);
                    employee.EmpAddress = Convert.ToString(sdr["EmpAddress"]);

                    con.Close();

                    return employee;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> EmployeeList = new List<Employee>();
            try
            {
                Employee employee = new Employee();
                con = DBConnection.CreateConnection();//DBConnection connection class
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Employee ", con);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    employee = new Employee();
                    employee.EmployeeId= Convert.ToInt32(sdr["EmployeeId"]);
                    employee.EmpName = Convert.ToString(sdr["EmpName"]);
                    employee.EmpEmailId = Convert.ToString(sdr["EmpEmailId"]);
                    employee.EmpPhoneno= Convert.ToInt64(sdr["EmpPhoneno"]);
                    employee.EmpAddress = Convert.ToString(sdr["EmpAddress"]);

                    EmployeeList.Add(employee);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return EmployeeList;

        }
        public Employee UpdateEmployee(int employeeId, Employee employee)
        {

            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_Employee  SET  EmpName = '" + employee.EmpName + "', EmpEmailId = '" + employee.EmpEmailId + "', EmpPhoneno = '" + employee.EmpPhoneno + "', EmpAddress = '" + employee.EmpAddress + "'  WHERE EmployeeId =" + employeeId, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public string DeleteEmployee(int employeeId)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete  from Tbl_Employee WHERE EmployeeId=" + employeeId, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return " Deleted Sucessfully:" + employeeId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}