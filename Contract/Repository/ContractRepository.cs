using System;
using System.Collections.Generic;
using System.Linq;

namespace IS_5
{
    public class ContractRepository
    {
        public List<Contract> GetContracts()
        {
            return TestData.Contracts;
        }

        public void DeleteContractFromRepository(int id)
        {
            TestData.Contracts.Remove(GetContract(id));
        }

        public Contract GetContract(int id)
        {
            return TestData.Contracts.Where(c => c.Id == id).FirstOrDefault();
        }

        public void AddContractToRepository(Contract c) => TestData.Contracts.Add(c);
    }
}