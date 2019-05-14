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
        public List<Employee> GetEmployeesByFirm()
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
                            employee.Title = reader.GetString(2);
                            employee.Name = reader.GetString(3);
                            employee.Surname = reader.GetString(4);
                            employee.Phone = reader.GetString(5);
                            employee.Email = reader.GetString(6);
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public void AddEmployee()
        {
           
            using (SqlConnection connection = new SqlConnection(Constants.CONNECTION_STRING))
            {
                

                //connection.Open();
                //using (SqlCommand command = connection.CreateCommand())
                //{
                //    command.CommandText = @"insert into Card output inserted.CardId 
                //                                values(@cardNumber, @pin, @cardValidity, @isBlocked)";

                //    command.Parameters.Add("@cardNumber", SqlDbType.Int).Value = card.CardNumber;
                //    command.Parameters.Add("@pin", SqlDbType.Int).Value = card.Pin;
                //    command.Parameters.Add("@cardValidity", SqlDbType.Date).Value = card.CardValidity;
                //    command.Parameters.Add("@isBlocked", SqlDbType.Bit).Value = card.IsBlocked;

                //    cardId = Convert.ToInt32(command.ExecuteScalar());
                //}

                //using (SqlCommand command = connection.CreateCommand())
                //{
                //    command.CommandText = @"insert into AccountCard 
                //                                (AccountId, CardId) 
                //                                values(@accountId, @cardId)";

                //    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
                //    command.Parameters.Add("@cardId", SqlDbType.Int).Value = cardId;

                //    success = (command.ExecuteNonQuery() > 0);
                //}

                //using (SqlCommand command = connection.CreateCommand())
                //{
                //    command.CommandText = @"Update Account set CardsCount = (CardsCount + 1) where AccountId = @accountId";
                //    command.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;

                //    command.ExecuteNonQuery();
                //}
            }
        }
    }
}
