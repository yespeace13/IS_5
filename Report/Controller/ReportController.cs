using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IS_5
{
    internal class ReportController
    {
        public ReportService _service;
        public ReportController()
        {
            _service = new ReportService();
        }

        internal List<string[]> CreateReport(DateTime from, DateTime to)
        {
            return _service.CreateReport(from, to);
        }

        internal void ExportToExcel(List<string> columns, DateTime from, DateTime to)
        {
            _service.ExportToExcel(columns, from, to);
        }
    }
}