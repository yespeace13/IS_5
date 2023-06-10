using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    public class Plan
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public List<ContentPlan> ContentsPlan { get; set; }

        public Plan(int id, int month, int year, List<ContentPlan> contentsPlan) 
        {
            Id = id; 
            Month = month; 
            Year = year;
            ContentsPlan = contentsPlan;
        }

    }
}
