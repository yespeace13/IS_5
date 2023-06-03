using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IS_5
{
    public static class ExportDataToExcel
    {
        public static void Export(string[] columns, string name, List<string[]> orgs)
        {
            Excel.Application app = new Excel.Application
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Workbook workBook = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Worksheet sheet = (Worksheet)app.Worksheets.get_Item(1);
            for (int i = 0; i < columns.Length; i++)
                sheet.Cells[1, i + 1] = columns[i];
            for (int i = 0; i < orgs.Count; i++)
                for (int j = 0; j < orgs[0].Length; j++)
                    sheet.Cells[i + 2, j + 1] = orgs[i][j];
            var cols = sheet.UsedRange.Columns;
            cols.Columns.AutoFit();
            app.Application.ActiveWorkbook.SaveAs(name);
            sheet = null;
            workBook.Close();
            app.Quit();
        }
    }
}
