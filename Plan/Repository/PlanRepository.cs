using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    internal class PlanRepository
    {
        public PlanRepository() 
        {
        }
        public List<Plan> GetPlans()
        {
            return TestData.Plans;
        }
        public List<Locality> GetLocalitys()
        {
            return TestData.Localitys;
        }
        public void CreateContent(List<ContentPlan> contentPlans)
        {
            TestData.ContentPlans.Add(contentPlans);
        }

        internal void AddPlan(Plan plan)
        {
            TestData.Plans.Add(plan);
        }
    }
}
