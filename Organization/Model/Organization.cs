﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IS_5.Model
{
    public class Organization
    {
        public int Id { get; set; }
        public string NameOrg { get; set; }
        public string TaxIdenNum { get; set; }
        public string KPP { get; set; }
        public string Address { get; set; }
        public TypeOrganization TypeOrganization { get; set; }

        public TypeOwnerOrganization TypeOwnerOrganization { get; set; }

        public Locality Locality { get; set; }

        public Organization(int id,
            string name, string taxIdenNum, string kpp, string address, 
            TypeOrganization typeOrganizations, TypeOwnerOrganization typeOwnerOrganization, Locality locality) 
        {
            Id = id;
            NameOrg = name;
            TaxIdenNum = taxIdenNum;
            KPP = kpp;
            Address = address;
            TypeOrganization = typeOrganizations;
            TypeOwnerOrganization = typeOwnerOrganization;
            Locality = locality;
        }
    }
}
