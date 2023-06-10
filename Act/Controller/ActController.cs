using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public class ActController
    {
        private ActService _service;
        public ActController()
        {
            _service = new ActService();
        }

        public List<string[]> ShowActs(int sizePages, int page, Dictionary<string, string> filtres,
            (string, SortOrder) sortCol, out int maxPage)
        {
            return _service.GetActs(sizePages, page, filtres, sortCol, out maxPage);
        }

        public (string[], List<string>) GetAct(int id)
        {
            return _service.GetAct(id);
        }

        public string[] GetOrganizations()
        {
            return _service.GetOrganizations();
        }
        public string[] GetContracts()
        {
            return _service.GetContracts();
        }

        public (string[], List<string>) GetAnimal(int idAct, int idAnimal)
        {
            return _service.GetAnimal(idAct, idAnimal);
        }

        internal Dictionary<string[], List<string>> GetAnimals(int id)
        {
            return _service.GetAnimals(id);
        }

        public string[] GetLocalitys()
        {
            return _service.GetLocalitys();
        }

        internal void CreateAct(string[] act, List<string> scans, Dictionary<string[], List<string>> animals)
        {
            _service.CreateAct(act, scans, animals);
        }

        internal void UpdateAct(int id, string[] act, List<string> scans, Dictionary<string[], List<string>> animals)
        {
            _service.UpdateAct(id, act, scans, animals);
        }

        internal void DeleteAct(int id)
        {
            _service.DeleteAct(id);
        }

        internal void ExportToExcel(string[] columns, Dictionary<string, string> filtres)
        {
            _service.ExportToExcel(columns, filtres);
        }
    }
}
