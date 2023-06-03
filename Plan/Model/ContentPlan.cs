using IS_5.Model;

namespace IS_5
{
    public class ContentPlan
    {
        public int Day { get; set; }
        public Locality Locality { get; set; }
        public string Address { get; set; }

        public ContentPlan(int day, Locality locality, string address)
        {
            Day = day;
            Locality = locality;
            Address = address;
        }
    }
}