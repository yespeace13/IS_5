using System;
using System.Collections.Generic;

namespace IS_5.Model
{
    public class UserPrivilege
    {
        public Tuple<Restrictions, Possibilities[]> Plan { get; }
        public Tuple<Restrictions, Possibilities[]> Acts { get; }
        public Tuple<Restrictions, Possibilities[]> Animals { get; }
        public Tuple<Restrictions, Possibilities[]> Organizations { get; }
        public Tuple<Restrictions, Possibilities[]> Contracts { get; }

        public UserPrivilege(
            Tuple<Restrictions, Possibilities[]> plans, 
            Tuple<Restrictions, Possibilities[]> acts, 
            Tuple<Restrictions, Possibilities[]> animals, 
            Tuple<Restrictions, Possibilities[]> organizations,
            Tuple<Restrictions, Possibilities[]> contracts)
        {
            Plan = plans;
            Acts = acts;
            Animals = animals;
            Organizations = organizations;
            Contracts = contracts;
        }
    }
}