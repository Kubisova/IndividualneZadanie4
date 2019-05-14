using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;

namespace CompanyStructureApp
{
    public class CompanyStructureViewModel
    {
        //public string FirmCode { get; set; }
        //public string FirmName { get; set; }
        //public string HeadOfFirm { get; set; }

        public CompanyStructureNode Firm {get;set;}
        public List<CompanyStructureNode> Divisions { get; set; }
        public List<CompanyStructureNode> Projects { get; set; }
        public List<CompanyStructureNode> Departments { get; set; }


        public void GetFirmById(int firmId )
        {
            Firm =  RepositoryManager.CompanyStructureNodeRepository.GetNodeById(firmId);
        }

        public void GetDivisions()
        {
            Divisions = RepositoryManager.CompanyStructureNodeRepository.GetNodesByTypeAndNodeAboveId(TypeOfNode.Division, Firm.NodeId);
        }

        public void GetProjects()
        {
            Projects = RepositoryManager.CompanyStructureNodeRepository.GetNodesByType(TypeOfNode.Project);
        }

        public void GetDepartments()
        {
            Departments = RepositoryManager.CompanyStructureNodeRepository.GetNodesByType(TypeOfNode.Department);
        }
    }
}
