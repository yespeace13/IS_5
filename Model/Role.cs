using System;
using System.Collections.Generic;

namespace IS_5.Model
{
    public class Role
    {
        int Id { get; set; }   
        public Tuple<Restrictions, Possibilities[]> Plan { get; }
        public Tuple<Restrictions, Possibilities[]> Acts { get; }
        public Tuple<Restrictions, Possibilities[]> Animals { get; }
        public Tuple<Restrictions, Possibilities[]> Organizations { get; }
        public Tuple<Restrictions, Possibilities[]> Contracts { get; }
        public string Name { get; }

        public Role(int id, string name,
            Tuple<Restrictions, Possibilities[]> plans, 
            Tuple<Restrictions, Possibilities[]> acts, 
            Tuple<Restrictions, Possibilities[]> animals, 
            Tuple<Restrictions, Possibilities[]> organizations,
            Tuple<Restrictions, Possibilities[]> contracts)
        {
            Id = id;
            Name = name;
            Plan = plans;
            Acts = acts;
            Animals = animals;
            Organizations = organizations;
            Contracts = contracts;
        }
    }
}