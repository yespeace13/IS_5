using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public class ContractController
    {
        private ContractService _contractService;
        public ContractController() 
        {
            _contractService = new ContractService();
        }

        public List<string[]> ShowContracts(int sizePages, int page,
            (string, SortOrder) sortCol, out int maxPage)
        {
            return _contractService.GetContracts(sizePages, page, sortCol, out maxPage);
        }

        internal void DeleteContract(int v)
        {
            throw new NotImplementedException();
        }
    }
}
