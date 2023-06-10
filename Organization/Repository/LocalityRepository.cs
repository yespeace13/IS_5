using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    internal class LocalityRepository
    {
        public List<Locality> GetLocalitys()
        {
            return TestData.Localitys;
        }
    }
}
