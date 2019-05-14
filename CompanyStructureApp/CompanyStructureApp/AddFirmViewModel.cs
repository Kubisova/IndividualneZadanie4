using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Models;
using CompanyStructureCore;
using Data;

namespace CompanyStructureApp
{
    public class AddFirmViewModel
    {
        public string CodeOfNode { get; set; }
        public string NameOfNode { get; set; }
        public int HeadOfNodeId { get; set; }

        public List<Employee> Employees { get; set; }
        private NodeFactory _nodeFactory;

        public AddFirmViewModel()
        {
            _nodeFactory = new NodeFactory();
        }

        public void GetEmployeesByFirm()
        {
            Employees = RepositoryManager.EmployeeRepository.GetEmployeesByFirm();
        }

        public void AddNode(TypeOfNode typeOfNode)
        {
            CompanyStructureNode node = _nodeFactory.CreateNode(CodeOfNode, NameOfNode, typeOfNode);
            RepositoryManager.CompanyStructureNodeRepository.AddFirm(node);
        }

        public void AddNode(TypeOfNode typeOfNode, int parentId)
        {
            CompanyStructureNode node = _nodeFactory.CreateNode(CodeOfNode, NameOfNode, typeOfNode, parentId);
            RepositoryManager.CompanyStructureNodeRepository.AddNode(node);
        }
    }

    
}
