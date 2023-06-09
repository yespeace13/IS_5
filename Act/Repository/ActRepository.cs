using System;
using System.Collections.Generic;
using System.Linq;

namespace IS_5
{
    public class ActRepository
    {
        public List<Act> GetActs()
        {
            return TestData.Acts;
        }

        public void DeleteActFromRepository(int id)
        {
            TestData.Acts.Remove(GetAct(id));
        }

        public Act GetAct(int id)
        {
            return TestData.Acts.Where(a => a.Id == id).FirstOrDefault();
        }

        public void AddActToRepository(Act a) => TestData.Acts.Add(a);
    }
}