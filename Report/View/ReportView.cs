using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5.Report.View
{
    public partial class ReportView : Form
    {
        private ReportController _controller;
        public ReportView()
        {
            InitializeComponent();
            _controller = new ReportController();
            ShowData();
        }

        private void ShowData()
        {
            //(string, SortOrder) sortCol = ConDataGrid.SortedColumn == null ?
            //    (null, SortOrder.None) : (ConDataGrid.SortedColumn.Name, ConDataGrid.SortOrder);
            var data = _controller.CreateReport(
                StartDateTimePicker.Value,
                EndDateTimePicker.Value
                //(int)PagesSize.Value,
                //(int)NumberOfPage.Value,
                //_filtres,
                //sortCol,
                //out int maxPage
                );
            //NumberOfPage.Maximum = maxPage;
            ReportDataGridView.Rows.Clear();
            foreach (var org in data)
                ReportDataGridView.Rows.Add(org);
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
