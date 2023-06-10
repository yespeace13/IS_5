using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_5
{
    public class Act
    {
        public int Id { get; set; }
        public List<Animal> Animals { get; set; }
        public Organization Organization { get; set; }
        public DateTime DateOfCapture { get; set; }
        public List<Scan> Scans { get; set; }
        public Act(int id, List<Animal> animals, Organization organization, DateTime date, List<Scan> scans) 
        {
            Id = id;
            Animals = animals;
            Organization = organization;
            DateOfCapture = date;
            Scans = scans;
        }
    }
}
