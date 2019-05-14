using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

namespace CompanyStructureApp
{
    public class EmployeesViewModel
    {
        public List<Employee> Employees { get; set; }

        public void GetEmployees()
        {
            //Employees = RepositoryManager.EmployeeRepository.GetEmployeesByFirm();
        }
    }
}
