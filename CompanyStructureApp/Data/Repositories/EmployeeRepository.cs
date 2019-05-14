using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using System.Data;
using System.Data.SqlClient;

namespace Data.Repositories
{
    static class Constants
    {
        public const string CONNECTION_STRING = @"Server = DESKTOP-GKFDQEI\SQLEXPRESS; Database = CompanyStructureDb;Trusted_Connection = true";
    }

    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "Select * from Employee";
                    command.Connection = connection;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.EmployeeId = reader.GetInt32(0);
                            employee.NodeId = reader.GetInt32(1);
                            employee.Name = reader.GetString(2);
                            employee.Surname = reader.GetString(3);
                            employee.Phone = reader.GetString(4);
                            employee.Email = reader.GetString(5);
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }
    }
}
