using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IS_5
{
    internal class ReportService
    {
        public List<Locality> Localityes = new LocalityRepository().GetLocalitys();
        public List<Contract> Contracts = new ContractRepository().GetContracts();

        internal List<string[]> CreateReport(DateTime from, DateTime to)
        {
            var localitys = Localityes;
            var total = new Dictionary<string, (int, decimal)>();
            foreach (var locality in localitys)
                total.Add(locality.Name, (0, 0));
            var contracts = Contracts;
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

        internal void ExportToExcel(List<string> columns, DateTime from, DateTime to)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel(*.xlsx)|*.xlsx";
            saveFileDialog1.FileName = "Отчет";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var data = CreateReport(from, to);
                ExportDataToExcel.Export(columns.ToArray(), saveFileDialog1.FileName, data);
            }
        }
    }
}