using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IS_5.Model
{
    public class Organization
    {
        public string Name { get; set; }
        public string TaxIdenNum { get; set; }
        public string KPP { get; set; }
        public string Address { get; set; }
        public TypeOrganizations TypeOrganization { get; set; }

        public TypeOfPred TypeOfPred { get; set; }

        public Organization(string name, string taxIdenNum, string kpp, string address, TypeOrganizations typeOrganizations, TypeOfPred typeOf) 
        {
            Name = name;
            TaxIdenNum = taxIdenNum;
            KPP = kpp;
            Address = address;
            TypeOrganization = typeOrganizations;
            TypeOfPred = typeOf;
        }
        
    }

    public enum TypeOrganizations
    {
        first,
        second
    }

    public enum TypeOfPred
    {
        first,
        second
    }
}
