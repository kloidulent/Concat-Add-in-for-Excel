using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;


namespace Concat_Addin
{
    public static class ColumnCleaner
    {

        public static void CleanColumns(string TargetRange,  bool TreatZeroesAsBlanks = false)
        {


            Excel.Worksheet sht = Globals.ThisAddIn.Application.ActiveSheet;

            Excel.Range processRange=   sht.Range[TargetRange];

            // if the selected range is not starting in column 1 (column A) then store an offset, which will be needed to 
            // convert the column number in the range to a column letter in the overall sheet
            int columnOffset = processRange.Cells[1, 1].Column-1;


            Excel.Range rangeToHide = null;
            int ColumnsHiddenCount = 0;



            object[,] cells = processRange.Value2;


            bool columnIsBlank = true;



            for (int col = 1; col < cells.GetLength(1); col++)
            {

                // majority of columns will not be blank.  We want to minimise the number of rows that are checked so that as soon as a value
                // is found in a row then stop checking that column and move on to the next

                // assume it is blank until found otherwise
                columnIsBlank = true;


                for (int row = 2; row < cells.GetLength(0); row++)
                {
                    // a cell is considered blank if it's NULL, "" or " ".  
                    if (cells[row,col]!=null)
                    {
                        string s = cells[row, col].ToString();

                        if (s.Length > 0 && s!=" ")      
                            if ((TreatZeroesAsBlanks && s!="0") || (TreatZeroesAsBlanks==false)) 
                            {
                                columnIsBlank = false;
                                break;
                            }
                               

                    }

                }

                


                if (columnIsBlank)
                {
                    string columnLetter = GetExcelColumnName(col+columnOffset);

                    ColumnsHiddenCount++;

                    if (rangeToHide == null)
                        rangeToHide = sht.Range[columnLetter + ":" + columnLetter];
                    else
                        rangeToHide = Globals.ThisAddIn.Application.Union(rangeToHide, sht.Range[columnLetter + ":" + columnLetter]);
                }
            }


            if (rangeToHide == null)
                Utilities.MsgboxInfoOnly("No blank columns were found", System.Windows.Forms.MessageBoxIcon.Information);
            else
            {
                rangeToHide.EntireColumn.Hidden = true;
                Utilities.MsgboxInfoOnly($"{ColumnsHiddenCount} columns were hidden.", System.Windows.Forms.MessageBoxIcon.Information);
            }

        }


        // https://stackoverflow.com/questions/181596/how-to-convert-a-column-number-e-g-127-into-an-excel-column-e-g-aa
        private static string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }





    }
}
