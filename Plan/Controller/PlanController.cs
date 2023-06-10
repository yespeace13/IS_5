using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    public class PlanController
    {
        private PlanService _planService;
        private List<ContentPlan> contentPlan;
        public PlanController()
        {
            _planService = new PlanService();
        }

        public IEnumerable<Plan> GetPlans(int year)
        {
            return _planService.GetPlans(year);
        }
        public List<Locality> ShowLocalitys()
        {
            return _planService.GetLocalitys();
        }

        public void CreatePlan(int id, int month, int year)
        {
            _planService.CreatePlan(id, month, year, contentPlan);
        }
        internal void CreateUpdateContent(List<ContentPlan> contentPlans)
        {
            contentPlan = contentPlans;
        }
        public IEnumerable<int> GetId()
        {
            return _planService.GetId();
        }
    }
}
