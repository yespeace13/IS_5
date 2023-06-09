using System;
using System.Collections.Generic;
using System.Linq;

namespace IS_5
{
    internal class ReportService
    {
        public ReportService()
        {
        }

        internal List<string[]> CreateReport(DateTime from, DateTime to)
        {
            var localitys = new LocalityRepository().GetLocalitys();
            var total = new Dictionary<string, (int, decimal)>();
            foreach (var locality in localitys)
                total.Add(locality.Name, (0, 0));
            var contracts = new ContractRepository().GetContracts();
            foreach (var contract in contracts)
            {
                foreach(var act in contract.Acts.Where(a => a.DateOfCapture >= from && a.DateOfCapture <= to))
                {
                    foreach(var animal in act.Animals)
                    {
                        var count = total[animal.Locality.Name].Item1;
                        var cost = total[animal.Locality.Name].Item2;
                        count += 1;
                        cost += contract.Localitysprices
                            .Where(lp => lp.Locality.Name == animal.Locality.Name)
                            .FirstOrDefault().Price;
                        total[animal.Locality.Name] = (count, cost);
                    }
                }
            }
            var report = total.Select(t => new string[] { 
                t.Key, t.Value.Item1.ToString(), t.Value.Item2.ToString() })
                .ToList();
            return report;
        }
    }
}