using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    internal class PlanService
    {
        private PlanRepository _planRepository;
        List<Plan> plans;

        public PlanService()
        {
            _planRepository = new PlanRepository();
        }

        public IEnumerable<Plan> GetPlans(int year)
        {
            plans = _planRepository.GetPlans();
            return plans.Where(p => p.Year == year);
        }

        public List<Locality> GetLocalitys()
        {
            var localitys = _planRepository.GetLocalitys();
            if (UserSession.User.Privilege.Organizations.Item1 == Restrictions.Locality)
                localitys = localitys
                    .Where(l => l.Name == UserSession.User.Locality.Name)
                    .ToList();
            return localitys;
        }

        public IEnumerable<int> GetId()
        {
            var q = plans.Select(p => p.Id).OrderBy(i => i);
            return q;
        }

        public void CreatePlan(int id, int month,int year, List<ContentPlan> contentPlans)
        {
            Plan plan = new Plan(id, month, year, contentPlans);
            _planRepository.AddPlan(plan);
        }
        internal void CreateContent(List<ContentPlan> contentPlans)
        {
            _planRepository.CreateContent(contentPlans);
        }

    }
}
