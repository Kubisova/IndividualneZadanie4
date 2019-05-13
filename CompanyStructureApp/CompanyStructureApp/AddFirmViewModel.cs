using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;

namespace CompanyStructureApp
{
    public class AddFirmViewModel
    {
        public string FirmCode { get; set; }
        public string FirmName { get; set; }
        public int HeadOfFirmId { get; set; }

        public List<Employee> Employees { get; set; }
        private CompanyStructureNodeRepository _companyStructureNodeRepository;
        private EmployeeRepository _employeeRepository;

        public AddFirmViewModel()
        {
            _companyStructureNodeRepository = new CompanyStructureNodeRepository(); 
            _employeeRepository = new EmployeeRepository();
        }

        public void GetEmployees()
        {
            Employees = _employeeRepository.GetEmployees();
        }

        public void AddFirm()
        {
            //_companyStructureNodeRepository.AddFirm(firm);
        }
    }

    
}
