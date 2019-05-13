using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace CompanyStructureApp
{
    public class AddFirmViewModel
    {
        public string FirmCode { get; set; }
        public string FirmName { get; set; }
        public string HeadOfFirm { get; set; }
        private CompanyStructureNodeRepository _companyStructureNodeRep;

        public AddFirmViewModel()
        {
            CompanyStructureNodeRepository companyStructureNodeRep = new CompanyStructureNodeRepository();
            _companyStructureNodeRep = companyStructureNodeRep;
        }

        public void AddFirm()
        {

        }
    }

    
}
