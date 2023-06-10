    using IS_5.Controler;
using IS_5.Service;
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

        public List<string[]> ShowContracts(int sizePages, int page, Dictionary<string, string> filtres,
            (string, SortOrder) sortCol, out int maxPage)
        {
            return _contractService.GetContracts(sizePages, page, filtres , sortCol, out maxPage);
        }

        public void DeleteContract(int id)
        {
            _contractService.DeleteContract(id);
        }

        public (string[], List<string[]>, List<string>) ShowContract(int id)
        {
            return _contractService.GetContract(id);
        }

        public List<string[]> ShowOrganizations()
        {
            return new ContractService().GetOrganizationsAll();
        }

        public string[] ShowLocalitys()
        {
            return new ContractService().GetLocalitys();
        }

        public void CreateContract(string number, DateTime dateOfConcl, DateTime dateValid, 
            string executor, string client, List<string[]> localsprices, List<string> scans)
        {
            _contractService.CreateContract(number, dateOfConcl, dateValid, 
                executor, client, localsprices, scans);
        }

        internal void UpdateContract(int id, string number, DateTime dateOfConcl, DateTime dateValid,
            string executor, string client, List<string[]> localsprices, List<string> scans)
        {
            _contractService.UpdateContract(id, number, dateOfConcl, dateValid, 
                executor, client, localsprices, scans);
        }

        public void ExportToExcel(string[] columns, Dictionary<string, string> filters)
        {
            _contractService.ExportToExcel(columns, filters);
        }
    }
}
