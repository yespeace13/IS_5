using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Model
{
    public class TypeOrganization
    {
        public string Name { get; set; }
        public TypeOrganization(string name)
        {
            Name = name;
        }
    }

    public class TypeOwnerOrganization
    {
        public string Name { get; set; }
        public TypeOwnerOrganization(string name) 
        {
            Name = name;
        }
    }
}
