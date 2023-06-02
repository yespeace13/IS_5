using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public class ContractService
    {
        private ContractRepository _contractRepository;
        public ContractService() 
        {
            _contractRepository = new ContractRepository();
        }

        public List<string[]> GetContracts(int sizePages, int page,
            (string, SortOrder) sortCol, out int maxPage)
        {
            var contracts = _contractRepository.GetContracts();
            maxPage = 0;
            return MapContracts(contracts);
        }

        public List<string[]> MapContracts(List<Contract> contracts)
        {
            var mapedCon = new List<string[]>();
            foreach (var contract in contracts)
            {
                mapedCon.Add(new string[]
                {
                    contract.Id.ToString(),
                    contract.Number.ToString(),
                    contract.DateOfConclusion.ToShortDateString(),
                    contract.DateValidation.ToShortDateString(),
                    contract.Executor.NameOrg,
                    contract.Client.NameOrg
                });
            }
            return mapedCon;
        }
    }
}
