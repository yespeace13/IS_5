using IS_5.Model;
using System.Collections.Generic;

namespace IS_5
{
    public class Animal
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public bool Sex { get; set; }
        public string Breed { get; set; }
        public double Size { get; set; }
        public string Wool { get; set; }
        public string Color { get; set; }
        public string Ears { get; set; }
        public string Tail { get; set; }
        public string SpecialSigns { get; set; }
        public string IdentificationLabel { get; set; }
        public string ChipNumber { get; set; }
        public Locality Locality { get; set; }
        public List<Scan> Scans { get; set; }

        public Animal(int id, string category, bool sex, string breed, 
            double size, string wool, string color, string ears, string tail, 
            string specSigns, string idenLabel, string chip, Locality locality, List<Scan> scans)
        {
            Id = id;
            Category = category;
            Sex = sex;
            Breed = breed;
            Size = size;
            Wool = wool;
            Color = color;
            Ears = ears;
            Tail = tail;
            SpecialSigns = specSigns;
            IdentificationLabel = idenLabel;
            ChipNumber = chip;
            Locality = locality;
            Scans = scans;
        }

    }
}