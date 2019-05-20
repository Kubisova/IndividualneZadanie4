using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Data.Models
{
    public class CompanyStructureNodeForView
    {
        public int NodeId { get; set; }

        [DisplayName("Kód")]
        public string CodeOfNode { get; set; }

        [DisplayName("Názov")]
        public string NameOfNode { get; set; }

        [DisplayName("Typ")]
        public TypeOfNode TypeOfNode { get; set; }
        
        public int? NodeAboveId { get; set; }

        [DisplayName("Vedúci oddelenia")]
        public int? HeadOfNodeId { get; set; }

        public Employee HeadOfNode { get; set; }


        //public override string ToString()
        //{
        //    if (TypeOfNode == TypeOfNode.Firm)
        //    {
        //        return $"riaditeľ {TypeOfNode.ToDescriptionString()} {NameOfNode}";
        //    }
        //    else
        //    {
        //        return $"vedúci {TypeOfNode.ToDescriptionString()} {NameOfNode}";
        //    }
        //}
    }
}
