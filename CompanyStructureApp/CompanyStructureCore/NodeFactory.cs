﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;

namespace CompanyStructureCore
{
    public class NodeFactory
    {
        public CompanyStructureNode CreateNode(string codeOfNode, string nameOfNode, TypeOfNode typeOfNode, int? parentNode, int? headOfNodeId)
        {
            CompanyStructureNode node = new CompanyStructureNode();
            node.CodeOfNode = codeOfNode;
            node.NameOfNode = nameOfNode;
            node.TypeOfNode = typeOfNode;
            node.NodeAboveId = parentNode;
            node.HeadOfNodeId = headOfNodeId;

            return node;
        }
    }
}
