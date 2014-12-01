using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace DATool
{
    class ExcelGenerator
    {
        public void generateExcelSheet()
        {
            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned  
            // by property Workbooks. The new workbook becomes the active workbook. 
            // Add has an optional parameter for specifying a praticular template.  
            // Because no argument is sent in this example, Add creates a new workbook. 
            excelApp.Workbooks.Add("decision_analysis_template.xlsx");

            // This example uses a single workSheet. The explicit type casting is 
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            // Establish column headings in cells A1 and B1.
            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";
        }

        private void createFormulaColumn()
        {
            // TODO
        }
    }
}
