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
        
        //Должен быть здесь или у контракта?!
        public Contract Contract { get; set; }

        public Act() { }
    }
}
