using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5.Model
{
    public class TypeOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeOrganization(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
