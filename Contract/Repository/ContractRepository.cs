using System.Collections.Generic;

namespace IS_5
{
    public class ContractRepository
    {
        public List<Contract> GetContracts()
        {
            return TestData.Contracts;
        }
    }
}